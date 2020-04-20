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
    /// Logica di interazione per GuitarMusicView.xaml
    /// </summary>
    public partial class GuitarMusicView : UserControl
    {
        private string data;

        public void ReloadMusic() => this.Canvas.LoadMusic();
        public void LoadMusic(string music) => this.Canvas.LoadMusic(music);

        public GuitarMusicView(string data)
        {
            this.data = data;
            InitializeComponent();

            /*this.SizeChanged += (s, e) =>
            {
                this.Canvas.Width = this.Width;
                this.Canvas.Height = this.Height - this.TopPanel.Height;

                this.TopPanel.Width = this.Width;
            };*/
        }
    }
}
