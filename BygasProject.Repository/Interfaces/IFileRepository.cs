using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BygasProject.Domain.Models;

namespace BygasProject.Repository.Interfaces
{
    public interface IFileRepository
    {
        public bool WriteFile(List<Dish> fileInfo);
        public List<Dish> ReadFile();
    }
}
