using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ETradeContext: DbContext
    {
        public IDbSet<Product> Products { get; set; }


    }
}
