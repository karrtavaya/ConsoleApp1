using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DB
{
    internal class Category
    {
        [Key]
        public Guid IdCategory { get; set; }
        public string Name { get; set; }


    }
}
