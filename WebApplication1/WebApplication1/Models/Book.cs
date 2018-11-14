using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class BookContect : DbContext {

    }
    public class Book
    {
        public string ID { set; get;}
        public string NAME { set; get; }
        public string ISBN { set; get; }
    }
}
