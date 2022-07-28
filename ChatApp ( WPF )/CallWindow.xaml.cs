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
using System.Windows.Shapes;

namespace ChatApp___WPF__
{
    /// <summary>
    /// Interaction logic for CallWindow.xaml
    /// </summary>
    public partial class CallWindow : Window
    {
        public string fullname { get; set; }

        public string imageSource { get; set; }


        public CallWindow(string fullname, string imageSource)
        {
            InitializeComponent();
            this.fullname = fullname;
            this.imageSource = imageSource;
            DataContext = this;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void btn_microphone_Click(object sender, RoutedEventArgs e)
        {
            if (icon_microphone.Kind == MaterialDesignThemes.Wpf.PackIconKind.MicrophoneOff)
            {
                icon_microphone.Kind = MaterialDesignThemes.Wpf.PackIconKind.Microphone;
                btn_microphone.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("Transparent"));
                icon_microphone.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA4A4A4"));
            }
            else
            {
                icon_microphone.Kind = MaterialDesignThemes.Wpf.PackIconKind.MicrophoneOff;
                btn_microphone.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("White"));
                icon_microphone.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF202C33"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
