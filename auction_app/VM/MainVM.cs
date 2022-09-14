using auction_app.Commands;
using auction_app.Data;
using auction_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace auction_app.VM
{
    public class MainVM
    {
        private AppDbContext _context { get; set; }
        public RelayCommand SwitchWindowsCommand { get; set; }
        public MainVM()
        {
            _context = new AppDbContext();
            SwitchWindowsCommand = new RelayCommand(
                async () =>
                {
                    LoginWindow window = new LoginWindow();
                    window.Show();
                }

            );
                
        }
        

        
    }
}