using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_forsty_cone
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public int ProductPrice { get; set; } = 0;

        public string imageurl { get; set; } = "";



        public Products(int id_in,string name_in , int price_int, string img_in)
        {
            this.ProductId = id_in;
            this.ProductName = name_in;
            this.ProductPrice = price_int;
            this.imageurl = img_in;

        }



        public Products()
        {
            

        }


        

    }


}
