using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatApp___WPF__
{
    public class Message
    {
        public string text { get; set; }
        public string dateTime { get; set; }
        public string color { get; set; }
        public HorizontalAlignment horizontalAlignment { get; set; }

        public Message()
        {

        }

        public Message(string text, HorizontalAlignment horizontalAlignment)
        {
            this.text = text;
            this.horizontalAlignment = horizontalAlignment;
            if (DateTime.Now.Hour < 10 && DateTime.Now.Minute < 10)
            {
                dateTime = $"0{DateTime.Now.Hour}:0{DateTime.Now.Minute}";
            }
            else if (DateTime.Now.Hour < 10)
            {
                dateTime = $"0{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            }
            else if (DateTime.Now.Minute < 10)
            {
                dateTime = $"{DateTime.Now.Hour}:0{DateTime.Now.Minute}";
            }
            else
            {
                dateTime = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            }
            if (horizontalAlignment == HorizontalAlignment.Left)
            {
                color = "#FF202C33";
            }
            else
            {
                color = "#FF005C4B";
            }
        }
    }
}
