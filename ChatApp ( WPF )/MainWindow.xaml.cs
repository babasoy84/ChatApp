using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using AIMLbot;

namespace ChatApp___WPF__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Contact> contacts;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Contact> Contacts
        {
            get { return contacts; }
            set
            {
                contacts = value;
                RaisePropertyChanged("Contacts");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var contactFaker = new Bogus.Faker<Contact>()
                .RuleFor(p => p.fullName, f => f.Person.FullName)
                .RuleFor(p => p.imageSource, f => f.Person.Avatar);
            List<Contact> _contacts = contactFaker.Generate(15);
            Contacts = new ObservableCollection<Contact>();
            foreach (var c in _contacts)
            {
                Contacts.Add(c);
            }
            DataContext = this;
            listBox_contacts.SelectedIndex = 0;
        }

        internal void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
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
            Application.Current.Shutdown();
        }

        private void SortContacts()
        {
            Contact contact = listBox_contacts.SelectedItem as Contact;
            List<Contact> _contacts = new List<Contact>();
            foreach (Contact c in Contacts)
            {
                if (c != contact)
                {
                    _contacts.Add(c);
                }
            }
            Contacts.Clear();
            Contacts.Add(contact);
            foreach (var c in _contacts)
            {
                Contacts.Add(c);
            }
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_message.Text))
            {
                if (Contacts[listBox_contacts.SelectedIndex].Messages == null)
                {
                    Contacts[listBox_contacts.SelectedIndex].Messages = new ObservableCollection<Message>() { new Message(txtBox_message.Text, HorizontalAlignment.Right) };
                }
                else
                {
                    Contacts[listBox_contacts.SelectedIndex].Messages.Add(new Message(txtBox_message.Text, HorizontalAlignment.Right));
                }
                Bot AI = new Bot();
                AI.loadSettings();
                AI.loadAIMLFromFiles();
                AI.isAcceptingUserInput = false;
                User myuser = new User("Turan", AI);
                AI.isAcceptingUserInput = true;
                Request r = new Request(txtBox_message.Text, myuser, AI);
                Result res = AI.Chat(r);
                Contacts[listBox_contacts.SelectedIndex].Messages.Add(new Message(res.Output, HorizontalAlignment.Left));
                txtBox_message.Text = "";
                Contacts[listBox_contacts.SelectedIndex].lastMessage = Contacts[listBox_contacts.SelectedIndex].Messages.Last().text;
                Contacts[listBox_contacts.SelectedIndex].lastDateTime = Contacts[listBox_contacts.SelectedIndex].Messages.Last().dateTime;
                SortContacts();
                listBox_contacts.SelectedIndex = 0;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Contact> _contacts = new List<Contact>();
            foreach (Contact c in Contacts)
            {
                _contacts.Add(c);
            }
            listBox_contacts.ItemsSource = _contacts.FindAll(delegate (Contact c) {
                string str = "";
                for (int i = 0; i < txtBox_search.Text.Length; i++)
                {
                    str += c.fullName[i];
                }
                return str == txtBox_search.Text;
            }).ToList();
        }

        private void txtBox_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btn_send_Click(btn_send, new RoutedEventArgs());
            }
        }

        private void btn_emoji_Click(object sender, RoutedEventArgs e)
        {
            if (emojiPicker.Visibility == Visibility.Visible)
            {
                emojiPicker.Visibility = Visibility.Hidden;
                icon_emoji.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA7A7A7"));
            }
            else
            {
                emojiPicker.Visibility = Visibility.Visible;
                icon_emoji.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#49A078"));
            }
        }

        private void Emoji1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "😃";
        }

        private void Emoji2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "😂";
        }

        private void Emoji3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "😍";
        }

        private void Emoji4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "😅";
        }

        private void Emoji5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "🤣";
        }

        private void Emoji6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "😎";
        }

        private void Emoji7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox_message.Text += "😡";
        }

        private void btn_videoCall_Click(object sender, RoutedEventArgs e)
        {
            VideoCallWindow cw = new VideoCallWindow((listBox_contacts.SelectedItem as Contact).fullName, (listBox_contacts.SelectedItem as Contact).imageSource);
            bool? result = cw.ShowDialog();
            if ((bool)!result)
            {
                cw.Close();
            }
        }

        private void btn_call_Click(object sender, RoutedEventArgs e)
        {
            CallWindow cw = new CallWindow((listBox_contacts.SelectedItem as Contact).fullName, (listBox_contacts.SelectedItem as Contact).imageSource);
            bool? result = cw.ShowDialog();
            if ((bool)!result)
            {
                cw.Close();
            }
        }
    }
}
