using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBasic.Core.Models;
using WebApplicationBasic.Persistence;

namespace WebApplicationBasic.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;

        public MakesController(VegaDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public IEnumerable<Make> GetMakes() 
        {
            return context.Makes.ToList();
        } 
    }
}