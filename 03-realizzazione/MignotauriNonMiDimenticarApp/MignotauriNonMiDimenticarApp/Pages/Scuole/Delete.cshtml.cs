﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MignotauriNonMiDimenticarApp.Data;
using MignotauriNonMiDimenticarApp.Models;

namespace MignotauriNonMiDimenticarApp.Pages.Scuole
{
    public class DeleteModel : PageModel
    {
        private readonly MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext _context;

        public DeleteModel(MignotauriNonMiDimenticarApp.Data.MignotauriNonMiDimenticarAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Scuola Scuola { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scuola = await _context.Scuole.FirstOrDefaultAsync(m => m.id == id);

            if (Scuola == null)
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

            Scuola = await _context.Scuole.FindAsync(id);

            if (Scuola != null)
            {
                _context.Scuole.Remove(Scuola);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
