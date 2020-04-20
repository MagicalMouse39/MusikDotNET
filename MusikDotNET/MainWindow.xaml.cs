using Microsoft.Win32;
using MusikDotNET.MusicViews;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace MusikDotNET
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
        }

        public MainWindow()
        {
            InitializeComponent();

            HandleEvents();
        }
    }
}
