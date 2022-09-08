using auction_app.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auction_app.VM
{
    public class MainVM
    {
        private AppDbContext _context;
        public MainVM(AppDbContext context)
        {
            _context = context;
        }
    }
}
