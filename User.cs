using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class User
    {
        public String username { get; set; }
      //  public String passowrd { get; set; }
        private String _password;
       public String passowrd
       {
            get { return _password;}
            set{
                if (value.Length >= 5) _password = value;
                else throw new Exception("password must be 5 characters at least !");
            }
        }
       public DateTime birthday { get; set; }
       public String Email { get; set; }

        public String Account()
        {
            return "username : " + username + "\nPassword : " + passowrd;
        }
        public bool Check(String U, String P)
        {
            if (U.CompareTo("Admin") == 0 && P.CompareTo("Admin") == 0) return true;
            else return false;
        }

        
    }
   
}
