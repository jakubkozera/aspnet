using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor;

namespace RazorPages.Pages.ToDos
{
    public class CreateModel : PageModel
    {
        private readonly ToDoContext _context;

        public CreateModel(ToDoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ToDo ToDo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ToDo.Add(ToDo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
