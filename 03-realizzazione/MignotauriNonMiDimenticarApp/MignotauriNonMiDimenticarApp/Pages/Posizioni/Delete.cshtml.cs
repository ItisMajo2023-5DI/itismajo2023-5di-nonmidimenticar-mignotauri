using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MignotauriNonMiDimenticarApp.Data;
using MignotauriNonMiDimenticarApp.Models;

namespace MignotauriNonMiDimenticarApp.Pages.Posizioni
{
    public class DeleteModel : PageModel
    {
        private readonly MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext _context;

        public DeleteModel(MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Posizione Posizione { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Posizione = await _context.Posizioni.FirstOrDefaultAsync(m => m.id == id);

            if (Posizione == null)
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

            Posizione = await _context.Posizioni.FindAsync(id);

            if (Posizione != null)
            {
                _context.Posizioni.Remove(Posizione);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
