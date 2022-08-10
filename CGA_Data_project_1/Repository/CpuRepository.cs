using CGA_Data_project_1.Data;
using CGA_Data_project_1.Models;
using CGA_Data_project_1.Repository.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGA_Data_project_1.Repository
{
    public class CpuRepository : ICpuRepository
    {
        private readonly AppDbContext _db;

        public CpuRepository(AppDbContext appDb)
        {
            _db = appDb;
        }
        public List<CPU> GetAllCpus()
        {
            var data = _db.Cpus.Include(b => b.Brands).ToList();
            return data;
        }

        public List<CPU> GetCPUByBrand(int id)
        {
            var data = _db.Cpus.Include(b => b.Brands).Where(c => c.BrandId == id).ToList();
            return data;
        }

        public bool DExists(int id)
        {
            return _db.Cpus.Any(c => c.BrandId == id);
        }
    }
}
