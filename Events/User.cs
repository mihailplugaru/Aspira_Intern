using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class User
    {
        private string password;

        public event ModifyUser ChangePass;

        public string Name { get; set; }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                ChangePass?.Invoke($"The pass changed  {this.Password}");
            }
        }


        public override string ToString()
        {
            return "Name: " + Name + "   Pass:  " + Password;
        }
    }
}
