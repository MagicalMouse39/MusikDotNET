using Microsoft.Win32;
using MusikDotNET.MusicViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace MusikDotNET
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;

        private void ShowMusicView(string music)
        {
            string data = music.Substring(music.Split('\n')[0].Length + 1);
            
            switch (music.Split('\n')[0].ToLower().Trim())
            {
                case "guitar":
                    {
                        this.MainView.Children.Clear();

                        GuitarViewType type = GuitarViewType.Tabs;
                        string stype = data.Split('\n')[0];
                        if (stype.ToLower().StartsWith("tab"))
                            type = GuitarViewType.Tabs;
                        else if (stype.ToLower().StartsWith("chord"))
                            type = GuitarViewType.Chords;
                        else
                            return;

                        data = data.Substring(data.Split('\n')[0].Length + 1);
                        this.MainView.Children.Add(new GuitarMusicView(data, type));
                    }
                    break;

                case "flute":
                    {
                        this.MainView.Children.Clear();
                        //this.MainView.Children.Add(new FluteMusicView(data));
                    }
                    break;
            }
        }

        private void HandleEvents()
        {
            this.BtnOpenFile.Click += (s, e) =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                if (ofd.FileName == null || ofd.FileName == string.Empty)
                    return;
                string music = File.ReadAllText(ofd.FileName);
                this.ShowMusicView(music);
            };
            this.BtnSaveFile.Click += (s, e) =>
            {
                /*
                var data = (this.MainView.Children[0] as MusicView).MusicType;
                data += (this.MainView.Children[0] as MusicView).GetMusicString();
                */
            };
        }

        public MainWindow()
        {
            MusicUtils.InitNotesDict();
            InitializeComponent();

            instance = this;
            HandleEvents();
        }
    }
}
