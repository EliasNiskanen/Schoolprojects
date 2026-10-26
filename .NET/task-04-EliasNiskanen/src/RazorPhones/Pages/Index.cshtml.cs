using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorPhones.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IList<Data.Phone> puhelimet { get; set; }

    private readonly RazorPhones.Data.PhonesContext _context;

    public IndexModel(ILogger<IndexModel> logger, Data.PhonesContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async void OnGetAsync()
    {
        puhelimet = await _context.Phones.OrderByDescending(p => p.Id).Take(3).ToListAsync();

    }
}
