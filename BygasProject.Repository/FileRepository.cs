using BygasProject.Domain.Models;
using BygasProject.Repository.Interfaces;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BygasProject.Repository
{
    public class FileRepository : IFileRepository
    {
        string defaultPath = AppDomain.CurrentDomain.BaseDirectory;

        public bool WriteFile(List<Dish> fileInfo)
        {
            try
            {
                var sw = new StreamWriter(defaultPath);

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
                var sr = new StreamReader(defaultPath);

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
