using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPhones.Data;

namespace RazorPhones.Pages.Phones
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPhones.Data.PhonesContext _context;

        public DetailsModel(RazorPhones.Data.PhonesContext context)
        {
            _context = context;
        }

      public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Phones == null)
            {
                return NotFound();
            }

            var phone = await _context.Phones.FirstOrDefaultAsync(m => m.Id == id);
            if (phone == null)
            {
                return NotFound();
            }
            else 
            {
                Phone = phone;
            }
            return Page();
        }
    }
}
