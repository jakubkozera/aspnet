using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor;

namespace RazorPages.Pages.ToDos
{
    public class DetailsModel : PageModel
    {
        private readonly ToDoContext _context;

        public DetailsModel(ToDoContext context)
        {
            _context = context;
        }

        public ToDo ToDo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDo = await _context.ToDo.FirstOrDefaultAsync(m => m.Id == id);

            if (ToDo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
