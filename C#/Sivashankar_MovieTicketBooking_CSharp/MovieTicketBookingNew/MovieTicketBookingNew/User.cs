using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingNew
{
    /// <summary>
    /// User class have the all properties of User 
    /// </summary>
    class User
    {

        private static int Autoincrement = 100;
        public string UserName { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }

        public List<Ticket> TicketList = new List<Ticket>();

        private string UserId;

        public User(string name,int age,long phoneNumber)
        {
            this.UserName = name;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
            this.UserId = "UID" + Autoincrement.ToString();
            Autoincrement++;
        }
    }
    
}
