using auction_app.Commands;
using auction_app.Data;
using auction_app.Models;
using auction_app.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace auction_app.VM
{
    public class LoginVM : INotifyPropertyChanged
    {
        public AppDbContext context { get; set; }
        public RelayCommand LoginCommand { get; set; }
        
        public string Username { get { return username; } set { username = value; NotifyPropertyChanged(); } }
        public string Password { get { return password; } set { password = value; NotifyPropertyChanged(); } }
        

        public LoginVM()
        {
            context = new AppDbContext();
            LoginCommand = new RelayCommand(
                async () =>
                {
                    
                    Globals.LoggedUser = context.Users.Where(u => u.Username == Username && u.Password == Password).FirstOrDefault();
                    if(Globals.LoggedUser != null)
                    {
                        Window.c 
                    }
                    
                    else MessageBox.Show("Invalid username or password. Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                    
                }
                );
                
        }
        private string username { get; set; }
        private string password { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

