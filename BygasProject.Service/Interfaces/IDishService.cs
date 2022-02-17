using BygasProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BygasProject.Service.Interfaces
{
    public interface IDishService
    {
        public List<Dish> GetAllDishes();
        public Dish GetDish(int id);
        public Dish AddDish(Dish dish);
        public Dish EditDish(Dish dish);
        public bool DeleteDish(int id);
    }
}
