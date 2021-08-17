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
    public class IndexModel : PageModel
    {
        private readonly ToDoContext _context;

        public IndexModel(ToDoContext context)
        {
            _context = context;
        }

        public IList<ToDo> ToDo { get;set; }

        public async Task OnGetAsync()
        {
            ToDo = await _context.ToDo.ToListAsync();
        }
    }
}
