using CGA_Data_project_1.Models;
using CGA_Data_project_1.Repository.RepoInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGA_Data_project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPUsController : ControllerBase
    {
        private readonly ICpuRepository _repo;

        public CPUsController(ICpuRepository repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public List<CPU> GetAllData()
        {
            var data = _repo.GetAllCpus();
            return data;
        }

        [HttpGet("bra/{brid}")]
        
        public List<CPU> GetCpuByBrand(int brid)
        {
          
            var data = _repo.GetCPUByBrand(brid);
            return data;
        }
    }
}
