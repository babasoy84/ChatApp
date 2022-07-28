using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.Media;
using VisioForge.Core.VideoCapture;
using VisioForge.Types.VideoCapture;
using VisioForge.Types;
using VisioForge.Types.Output;

namespace ChatApp___WPF__
{
    /// <summary>
    /// Interaction logic for VideoCallWindow.xaml
    /// </summary>
    public partial class VideoCallWindow : Window
    {
        public string fullname { get; set; }

        public string imageSource { get; set; }

        private VideoCaptureCore core;


        public VideoCallWindow(string fullname, string imageSource)
        {
            InitializeComponent();
            this.fullname = fullname;
            this.imageSource = imageSource;
            DataContext = this;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            core = new VideoCaptureCore(videoView);
            core.Video_CaptureDevice = new VideoCaptureSource(core.Video_CaptureDevices[0].Name);
            core.Audio_CaptureDevice = new AudioCaptureSource(core.Audio_CaptureDevices[0].Name);

            core.Mode = VideoCaptureMode.VideoCapture;

            core.Output_Format = new MP4Output();

            core.Output_Filename = "output.mp4";

            await core.StartAsync();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private async void btn_microphone_Click(object sender, RoutedEventArgs e)
        {
            if (icon_microphone.Kind == MaterialDesignThemes.Wpf.PackIconKind.MicrophoneOff)
            {
                icon_microphone.Kind = MaterialDesignThemes.Wpf.PackIconKind.Microphone;
                btn_microphone.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("Transparent"));
                icon_microphone.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA4A4A4"));
                await core.StopAsync();
                core = new VideoCaptureCore(videoView);
                core.Video_CaptureDevice = new VideoCaptureSource(core.Video_CaptureDevices[0].Name);
                core.Audio_CaptureDevice = new AudioCaptureSource(core.Audio_CaptureDevices[0].Name);

                core.Mode = VideoCaptureMode.VideoCapture;

                core.Output_Format = new MP4Output();

                core.Output_Filename = "output.mp4";

                await core.StartAsync();
            }
            else
            {
                icon_microphone.Kind = MaterialDesignThemes.Wpf.PackIconKind.MicrophoneOff;
                btn_microphone.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("White"));
                icon_microphone.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF202C33"));
                await core.StopAsync();
                core.Audio_CaptureDevice = null;
                await core.StartAsync();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private async  void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            await core.StopAsync();
        }
    }
}
