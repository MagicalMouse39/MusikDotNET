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
        public enum GuitarViewType
        {
            Chords, Tabs
        }

        private string data;
        private GuitarViewType type;

        public void ReloadMusic() => this.Canvas.LoadMusic();
        
        public void LoadMusic(string music) => this.Canvas.LoadMusic(music, this.type);

        public GuitarMusicView(string data, GuitarViewType type)
        {
            this.data = data;
            this.type = type;
            InitializeComponent();

            this.BtnNoteDown.Click += (s, e) => this.Canvas.TranspDown();
            this.BtnNoteUp.Click += (s, e) => this.Canvas.TranspUp();

            if (this.type == GuitarViewType.Tabs)
            {
                this.LayoutSelector.Visibility = Visibility.Hidden;
                this.LayoutSelectorLabel.Content = "Notes Layout: Tabs";
                Grid.SetColumnSpan(this.LayoutSelectorLabel, 2);
                this.LayoutSelectorLabel.HorizontalAlignment = HorizontalAlignment.Center;
            }
            this.LoadMusic(this.data);
        }
    }
}
