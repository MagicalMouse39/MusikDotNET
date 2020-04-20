using System;
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

namespace MusikDotNET.MusicViews
{
    /// <summary>
    /// Logica di interazione per StringsCanvas.xaml
    /// </summary>
    public partial class StringsCanvas : Canvas
    {
        private string music = string.Empty;

        private double RealWidth { get { return MainWindow.instance.WindowState == WindowState.Maximized ? SystemParameters.WorkArea.Width : MainWindow.instance.Width; } }
        private double RealHeight { get { return MainWindow.instance.WindowState == WindowState.Maximized ? SystemParameters.WorkArea.Height : MainWindow.instance.Height; } }

        public void LoadMusic() => LoadMusic(this.music);

        public void LoadMusic(string music)
        {
            this.music = music;

            List<Note> notes = new List<Note>();
            
            
            for (int i = 0; i < 6; i++)
            {
                int y = 30 + i * 15;
                this.Children.Add(new Line() { X1 = 0, X2 = this.RealWidth, Y1 = y, Y2 = y, Stroke = Brushes.White, StrokeThickness = .5f });
            }
        }

        public StringsCanvas()
        {
            InitializeComponent();
            this.SizeChanged += (s, e) =>
            {
                this.Children.Clear();
                this.LoadMusic();
            };
        }
    }
}
