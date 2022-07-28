using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp___WPF__
{
    public class Contact : INotifyPropertyChanged
    {
        public string fullName { get; set; }
        public string imageSource { get; set; }
        private ObservableCollection<Message> messages { get; set; } = new ObservableCollection<Message>();

        public ObservableCollection<Message> Messages
        {
            get { return messages; }
            set
            {
                messages = value;
                RaisePropertyChanged("Messages");
            }
        }

        private string _lastMessage;

        public string lastMessage
        {
            get { return _lastMessage; }
            set
            {
                _lastMessage = value;
                OnPropertyChanged("lastMessage");
            }
        }

        private string _lastDateTime;

        public string lastDateTime
        {
            get { return _lastDateTime; }
            set
            {
                _lastDateTime = value;
                OnPropertyChanged("lastDateTime");
            }
        }

        public Contact()
        {

        }

        public Contact(string fullName, string imageSource)
        {
            this.fullName = fullName;
            this.imageSource = imageSource;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
