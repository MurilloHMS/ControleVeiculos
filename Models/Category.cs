using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVeiculos.Models
{
    internal class Category
    {
        public string Name { get; set; }
        public bool IsExpanded { get; set; }
        public List<Category> Subcategories { get; set; } = new List<Category>();
    }
}
