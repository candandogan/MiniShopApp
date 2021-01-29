using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        //each brand can have more than one product.
        public IList<Product> Product { get; set; }
    }

}
