using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BygasProject.Domain.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVegetarian { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
