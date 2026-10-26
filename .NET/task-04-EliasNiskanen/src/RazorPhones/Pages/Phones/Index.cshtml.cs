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
    public class PhonesModel : PageModel
    {


        private readonly RazorPhones.Data.PhonesContext _context;
        public PhonesModel(RazorPhones.Data.PhonesContext context)
        {

            _context = context;
        }

        public IList<Phone> Phone { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Phones != null)
            {
                Phone = await _context.Phones.OrderBy(p => p.Make).ToListAsync();           
            }
        }
    }
}
