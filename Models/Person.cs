using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payot_Week08_Work09.Models
{
    //2nd Done
    public abstract class Person // this is a base class for Employee
    {
        
        public int Id;
        public string Lastname;
        public string Firstname;
        public string Middlename;
        public string Address;
        public DateTime Birthdate;
        public string Gender;

        public void setID(int id)
        {
            this.Id = id;
        }

        public string GetFullName()
        {
            return $"{this.Lastname}, {this.Firstname}";
        }
    }
}
