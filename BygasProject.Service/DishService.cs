using BygasProject.Domain.Models;
using BygasProject.Repository.Interfaces;
using BygasProject.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BygasProject.Service
{
    public class DishService : IDishService
    {
        private readonly IFileRepository _repository;
        public DishService(IFileRepository repository)
        {
            _repository = repository;
        }

        public List<Dish> GetAllDishes()
        {
            var response  = _repository.ReadFile();

            return response;
        }

        public Dish GetDish(int id)
        {
            var allDishes = GetAllDishes();

            var response = allDishes.Find(x => x.Id == id);

            return response;
        }

        public Dish AddDish(Dish dish)
        {
            var allDishes = GetAllDishes();

            allDishes.Add(dish);

            _repository.WriteFile(allDishes);

            return GetDish(dish.Id);
        }

        public Dish EditDish(Dish dish)
        {
            var response = new Dish();

            var allDishes = GetAllDishes();

            if (DeleteDish(dish.Id))
            {
                return AddDish(dish);
            }   

            return response;
        }

        public bool DeleteDish(int id)
        {
            var response = false;
            var allDishes = GetAllDishes();

            if (allDishes.Exists(x => x.Id == id))
            {
                var newDishes = allDishes.Where(x => x.Id != id).ToList();

                allDishes = newDishes;

                response = true;
            }
            return response;
        }
    }
}