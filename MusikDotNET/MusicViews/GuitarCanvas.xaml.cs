﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static MusikDotNET.MusicViews.GuitarMusicView;
using static MusikDotNET.Note;

namespace MusikDotNET.MusicViews
{
    /// <summary>
    /// Logica di interazione per StringsCanvas.xaml
    /// </summary>
    public partial class GuitarCanvas : Canvas
    {
        private string music = string.Empty;
        private GuitarViewType type;
        private NoteLayout layout;
        private List<Note> Notes = new List<Note>();

        private double RealWidth { get { return MainWindow.instance.WindowState == WindowState.Maximized ? SystemParameters.WorkArea.Width : MainWindow.instance.Width; } }
        private double RealHeight { get { return MainWindow.instance.WindowState == WindowState.Maximized ? SystemParameters.WorkArea.Height : MainWindow.instance.Height; } }

        public void LoadMusic() => LoadMusic(this.music, this.type);

        private void LoadTabs(string music)
        {
            List<Sheet> data = new List<Sheet>();

            int c = 0;

            List<string> notes = new List<string>();

            foreach (string line in music.Split('\n'))
            {
                if (line.StartsWith("-"))
                {
                    notes.Add(line);
                    c++;
                    if (c == 6)
                    {
                        c = 0;
                        data.Add(new Sheet(notes));
                        notes.Clear();
                    }
                }
            }

            foreach (Sheet s in data)
                foreach (Note n in s.Notes)
                    this.Notes.Add(n);

            try
            {
                int space = 0;
                foreach (Sheet cd in data)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int y = 30 + space * 100 + i * 15;
                        this.Children.Add(new Line() { X1 = 0, X2 = this.RealWidth, Y1 = y, Y2 = y, Stroke = Brushes.White, StrokeThickness = .5f });
                    }
                    int prespace = space;
                    int maxs = 0;
                    for (int nn = 0; nn < cd.Notes.Count; nn++)
                    {
                        Note note = cd.Notes[nn];
                        TextBlock n = new TextBlock() { Text = note.Name, FontSize = 16f, Foreground = Brushes.White };
                        this.Children.Add(n);

                        if ((int)((note.GuitarPosition.Pos * 10) / this.RealWidth) > maxs)
                        {
                            maxs = (note.GuitarPosition.Pos * 10) / (int)this.RealWidth;
                            space = prespace;
                            for (int k = 0; k < maxs; ++k)
                            {
                                space++;
                                for (int i = 0; i < 6; i++)
                                {
                                    int y = 30 + space * 100 + i * 15;
                                    this.Children.Add(new Line() { X1 = 0, X2 = this.RealWidth, Y1 = y, Y2 = y, Stroke = Brushes.White, StrokeThickness = .5f });
                                }
                            }
                        }

                        int leftsub = (int)this.RealWidth * (int)((10 * note.GuitarPosition.Pos) / this.RealWidth);
                        Canvas.SetLeft(n, (10 * note.GuitarPosition.Pos) - leftsub);
                        Canvas.SetTop(n, 18 + space * 100 + 15 * note.GuitarPosition.String);
                    }
                    space++;
                }
            }
            catch { }
        }

        private void LoadChords(string music)
        {
            string slayout = music.Split('\n')[0];
            music = music.Substring(music.Split('\n')[0].Length + 1);

            if (slayout.ToLower().Trim() == "it")
                this.layout = NoteLayout.Italian;
            else if (slayout.ToLower().Trim() == "en")
                this.layout = NoteLayout.English;

            List<Note> chords = new List<Note>();

            string refMusic = string.Empty;
            
            //Buongiorno Magical
            //TODO: Mettere stringhe e note in posti separati, per note editing

            //Refactor
            for (int i = 0; i < music.Split('\n').Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (this.layout == NoteLayout.Italian)
                        foreach (string chord in MusicUtils.itChords)
                        {
                            List<int> poss = music.Split('\n')[i].AllIndexesOf(chord);
                            foreach (int pos in poss)
                                chords.Add(new Note(chord, new GuitarPos(i, pos)));
                        }
                }
                refMusic += music.Split('\n')[i] + (i % 2 == 0 ? "\n" : "\n\n");
            }

            this.Notes = chords;

            TextBox chordBox = new TextBox();

            chordBox.Text = refMusic;
            chordBox.HorizontalAlignment = HorizontalAlignment.Stretch;
            chordBox.VerticalAlignment = VerticalAlignment.Stretch;
            chordBox.Width = this.RealWidth;
            chordBox.Height = this.RealHeight;
            chordBox.IsReadOnlyCaretVisible = false;
            chordBox.IsReadOnly = true;
            chordBox.Background = this.Background;
            chordBox.Foreground = Brushes.White;
            Canvas.SetTop(chordBox, 0);
            Canvas.SetLeft(chordBox, 0);

            this.Children.Add(chordBox);
        }

        public void TranspUp()
        {
            for (int i = 0; i < this.Notes.Count; i++)
            {
                Note note = this.Notes[i];
                MusicUtils.TranspUp(ref note, this.layout);
                this.Notes[i] = note;
            }
            this.LoadMusic();
        }

        public void TranspDown()
        {
            for (int i = 0; i < this.Notes.Count; i++)
            {
                Note note = this.Notes[i];
                MusicUtils.TranspDown(ref note, this.layout);
                this.Notes[i] = note;
            }
            this.LoadMusic();
        }

        public void LoadMusic(string music, GuitarViewType type)
        {
            this.music = music;
            this.type = type;

            if (string.IsNullOrEmpty(this.music))
                return;

            this.Children.Clear();

            if (type == GuitarViewType.Tabs)
                this.LoadTabs(music);
            else if (type == GuitarViewType.Chords)
                this.LoadChords(music);
        }

        public GuitarCanvas()
        {
            InitializeComponent();
            this.SizeChanged += (s, e) => this.LoadMusic();
        }
    }
}
