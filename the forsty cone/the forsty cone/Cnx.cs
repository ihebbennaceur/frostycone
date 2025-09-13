using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace the_forsty_cone
{
   public class Cnx

    {

        private readonly SqlConnection con;

        public static readonly string cs= "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";


        public Cnx() { }


        

    }
}
