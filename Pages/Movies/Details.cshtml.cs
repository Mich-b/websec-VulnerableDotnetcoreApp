using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VulnerableApplication.Models;

namespace VulnerableApplication.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly VulnerableApplication.Models.VulnerableApplicationContext _context;

        public DetailsModel(VulnerableApplication.Models.VulnerableApplicationContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sql = $"SELECT * from dbo.Movie Where ID = {id}";
            Movie = await _context.Movie.FromSqlRaw(sql).FirstOrDefaultAsync();

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
