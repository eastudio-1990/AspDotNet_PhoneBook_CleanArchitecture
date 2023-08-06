using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_PhoneBook.Entities
{
    public class Contact
    {
        public int Id { get;private set; }
        public string Name { get;private set; }
        public string LastName { get;private set; }
        public string Compnay { get;private set; }
        public int PhoneNumber { get;private set; }
        public DateTime CreatedAt { get;private set; }

        public Contact(string Name,string LastName,int PhoneNumber,string Company)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Compnay = Company;
            this.CreatedAt = DateTime.Now;
        }                  
        
        public void Update(string Name, string LastName, int PhoneNumber, string Company)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Compnay = Company;
        }
    }
}
