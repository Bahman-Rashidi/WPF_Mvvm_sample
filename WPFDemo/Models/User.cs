using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.Models
{
   public class User: INotifyPropertyChanged
    {
        private string _username ;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
       

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Username"));
                }
            }
        }



        private string _password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
           

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }
    }
}
