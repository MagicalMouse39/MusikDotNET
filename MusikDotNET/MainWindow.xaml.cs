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
                        this.MainView.Children.Add(new GuitarMusicView(data));
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

            /*this.SizeChanged += (s, e) =>
            {
                if (this.MainView.Children.Count > 0)
                {
                    try
                    {
                        if (this.MainView.Children[0].GetType() == typeof(GuitarMusicView))
                        {
                            (this.MainView.Children[0] as GuitarMusicView).Width = this.Width;
                            (this.MainView.Children[0] as GuitarMusicView).Height = this.Height;
                        }
                        if (this.MainView.Children[0].GetType() == typeof(FluteMusicView))
                        {
                            //(this.MainView.Children[0] as FluteMusicView).ReloadMusic();
                        }
                    }
                    catch { }
                }
            };

            this.StateChanged += (s, e) =>
            {
                Rect screen = SystemParameters.WorkArea;
                if (this.MainView.Children.Count > 0)
                {
                    try
                    {
                        if (this.MainView.Children[0].GetType() == typeof(GuitarMusicView))
                        {
                            (this.MainView.Children[0] as GuitarMusicView).Width = screen.Width;
                            (this.MainView.Children[0] as GuitarMusicView).Height = screen.Height;
                        }
                        if (this.MainView.Children[0].GetType() == typeof(FluteMusicView))
                        {
                            //(this.MainView.Children[0] as FluteMusicView).ReloadMusic();
                        }
                    }
                    catch { }
                }
            };*/
        }

        public MainWindow()
        {
            InitializeComponent();

            instance = this;

            this.MainView.Children.Add(new GuitarMusicView(""));

            HandleEvents();
        }
    }
}
