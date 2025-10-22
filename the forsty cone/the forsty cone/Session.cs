using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_forsty_cone
{
    public class Session
    { // singeton  pattern to prevent multiple instances of session
        private static Session instance;
        public int UserId { get; set; }
        public string Username { get; set; }
        public int IsAdmin { get; set; }

        private Session() { } // Private constructor to prevent instantiation   

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        public void Clear()
        {
            UserId = 0;
            Username = null;
            IsAdmin = 0;
        }
    }
}
