using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MignotauriNonMiDimenticarApp.Data;
using MignotauriNonMiDimenticarApp.Models;

namespace MignotauriNonMiDimenticarApp.Pages.Profili
{
    public class DeleteModel : PageModel
    {
        private readonly MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext _context;

        public DeleteModel(MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Profilo Profilo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Profilo = await _context.Profili.FirstOrDefaultAsync(m => m.id == id);

            if (Profilo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Profilo = await _context.Profili.FindAsync(id);

            if (Profilo != null)
            {
                _context.Profili.Remove(Profilo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
