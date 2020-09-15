using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFDemo.Models;

namespace WPFDemo.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
           // LoginCommand = new RelayCommand(loginmethod);
            this.LoginCommand = new RelayCommand<Window>(this.loginmethod);
            this.User = new User();
            User.Username = "Bahman";
            User.Password = "12345";
        }

        #region MyRegion
        public RelayCommand<Window> LoginCommand { get; private set; }

      //  public ICommand LoginCommand { get; private set; }
        //private void CloseWindow(Window window)
        //{
        //    if (window != null)
        //    {
        //        window.Close();
        //    }
        //}
        #endregion

        #region Properties



        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                RaisePropertyChanged("User");
            }
        }


      

        #endregion

        #region Commands






        #endregion //Commands

        #region Command Methods
       

       


        private void loginmethod(Window window)
        {
            if (this.User.Username == "Bahman" && this.User.Password == "12345")
            {
                var newForm = new MainWindow(); //create your new form.
                newForm.Show(); //show the new form.


                if (window != null)
                {
                    window.Close();
                }

            }
        }


       
        #endregion

    }
}
