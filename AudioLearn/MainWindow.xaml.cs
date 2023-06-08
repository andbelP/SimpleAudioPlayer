using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
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
using System.Windows.Threading;

namespace AudioLearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }
        private MediaPlayer mediaPlayer = new MediaPlayer();

       

        

        private void Playbtn(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
            
        }
        
        private void Pausebtn(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void Breakbtn(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
        private void VolumeMin(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(VolumeBox.Text) < 10)
            {
                VolumeBox.Text = "0";
            }
            else
            {
                VolumeBox.Text = Convert.ToString(Convert.ToInt32(VolumeBox.Text) - 10);
            }
            mediaPlayer.Volume = Convert.ToDouble(VolumeBox.Text) / 100;
            
        }
        private void VolumePlus(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(VolumeBox.Text) > 90)
            {
                VolumeBox.Text = "100";
            }
            else
            {
                VolumeBox.Text = Convert.ToString(Convert.ToInt32(VolumeBox.Text) + 10);
            }
            mediaPlayer.Volume = Convert.ToDouble(VolumeBox.Text) / 100;
        }
        private void Openbtn(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                urlOfSong.Text = Convert.ToString(mediaPlayer.Source);
                
        }

    }
}
