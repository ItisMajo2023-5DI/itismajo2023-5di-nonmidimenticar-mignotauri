using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MignotauriNonMiDimenticarApp.Data;
using MignotauriNonMiDimenticarApp.Models;

namespace MignotauriNonMiDimenticarApp.Pages.Diplomati
{
    public class CreateModel : PageModel
    {
        private readonly MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext _context;

        public CreateModel(MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Diplomato Diplomato { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Diplomati.Add(Diplomato);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
