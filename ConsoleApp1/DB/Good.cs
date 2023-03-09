using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DB
{
    internal class Good
    {
        [Key]
        public Guid IdGood { get; set; }
        public Category? Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Sale { get; set; }

    }
}
