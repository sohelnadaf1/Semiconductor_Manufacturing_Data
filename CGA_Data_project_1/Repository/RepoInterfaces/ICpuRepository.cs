using CGA_Data_project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGA_Data_project_1.Repository.RepoInterfaces
{
   public interface ICpuRepository
    {
        List<CPU> GetAllCpus();
         List<CPU> GetCPUByBrand(int id);
         bool DExists(int id);
    }
}
