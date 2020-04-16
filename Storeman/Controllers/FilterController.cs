using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Storeman.Models;

namespace Storeman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly STORESQLContext _context;
        public FilterController(STORESQLContext context)
        {
            _context = context;
        }

        [HttpGet("{upc}")]
        public async Task<IActionResult> GetUPC(string upc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var filter = await _context.FilTab.FirstOrDefaultAsync();
            if(filter==null)
            {
                FilTab initialFilter = new FilTab();
                initialFilter.F1101 = 901001;
                initialFilter.F1025 = "Main code";
                initialFilter.F1026 = "=";
                initialFilter.F1027 = "0000000000001";
                initialFilter.F1028 = "";
                _context.FilTab.Add(initialFilter);
                await _context.SaveChangesAsync();
            }
            else
            {
                filter.F1025 = "Alternate code";
                filter.F1027 = upc;
                await _context.SaveChangesAsync();
                
            }    
            return Ok(filter);
            
        }
    }
}