using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList

{
    class Contact
    {
        private string phone;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length == 9)
                {
                    phone = value;
                }
                else
                {
                    phone = "000000000";
                }
            }
        }
        public Contact()

        {
            FirstName = "Jan";
            LastName = "Kowalski";
            Phone = "000000000";            
        }
        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;     
        }
        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1}", LastName, FirstName);
            output += String.Format(" {0}-{1}-{2}", Phone.Substring(0, 3), Phone.Substring(3, 3), Phone.Substring(6, 3));
            return output;
        }

    }// koniec klasy
}// koniec namespace
