using BygasProject.Domain.Models;
using BygasProject.Repository.Interfaces;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace BygasProject.Repository
{
    public class FileRepository : IFileRepository
    {
        private readonly IConfiguration _configuration;

        public readonly string fileName;

        public FileRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            //fileName = _configuration["MockDatabase:BasePath"] + @"base.json";
            fileName = @".\base.json";
        }

        public bool WriteFile(List<Dish> fileInfo)
        {
            try
            {
                var sw = new StreamWriter(fileName);

                var json = JsonSerializer.Serialize(fileInfo);

                sw.WriteLine(json);

                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);

                return false;
            }
        }

        public List<Dish> ReadFile()
        {
            var response = new List<Dish>();

            try
            {
                var sr = new StreamReader(fileName);

                response = JsonSerializer.Deserialize<List<Dish>>(sr.ReadToEnd());

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return response;
        }
    }
}
