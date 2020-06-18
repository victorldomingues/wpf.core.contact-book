using System;

namespace ContactBook.Models
{
    public class Contact
    {
        public Contact(string name, string phone, string cellPhone, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Phone = phone;
            CellPhone = cellPhone;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string CellPhone { get; private set; }
        public string Email { get; private set; }
    }
}
