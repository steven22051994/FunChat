using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superchat.MVVM.Model
{
    class ContactModel
    {
        public string Username { get; set; }
        public string ImageSource { get; set; }
        public ObservableCollection<MessageModel> Messages { get; set; }
        // Damit bekomme ich von meiner MesageModel Colection das Letzte Message Objekt
        public string LastMessage => Messages.Last().Message;
    }
}
