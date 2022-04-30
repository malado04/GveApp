using System;
using System.Collections.Generic;
using System.Text;

namespace GveApp.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return this.Message;
        }
    }
}
