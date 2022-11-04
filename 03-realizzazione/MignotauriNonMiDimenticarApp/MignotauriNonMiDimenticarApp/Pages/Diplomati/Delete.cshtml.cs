using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MignotauriNonMiDimenticarApp.Data;
using MignotauriNonMiDimenticarApp.Models;

namespace MignotauriNonMiDimenticarApp.Pages.Diplomati
{
    public class DeleteModel : PageModel
    {
        private readonly MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext _context;

        public DeleteModel(MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Diplomato Diplomato { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diplomato = await _context.Diplomati.FirstOrDefaultAsync(m => m.id == id);

            if (Diplomato == null)
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

            Diplomato = await _context.Diplomati.FindAsync(id);

            if (Diplomato != null)
            {
                _context.Diplomati.Remove(Diplomato);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
