using ContosoCrafts.Website.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Website.Pages
{
    public class AccountModel : PageModel
    {
        private readonly ConnectionDBClass _db;

        public AccountModel(ConnectionDBClass db)
        {
            _db = db;
        }

        public IEnumerable<AccountClass> getrecords { get; set; }

        public async Task OnGet()
        {
            getrecords = await _db.account.ToListAsync();
        }
   
    }
}
