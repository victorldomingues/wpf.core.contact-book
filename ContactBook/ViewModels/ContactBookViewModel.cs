using System.Collections.Generic;
using System.Windows.Documents;
using ContactBook.Models;
using GalaSoft.MvvmLight;

namespace ContactBook.ViewModels
{
    public class ContactBookViewModel : ViewModelBase
    {
        public string SearchText { get; set; }
        public bool SearchInactive { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
