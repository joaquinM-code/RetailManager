using Caliburn.Micro;
using RMDesktopUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public string UserName
        {
            get { return _userName; }
            set 
            { 
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLoginButton);
            }
        }

        public bool CanLoginButton
        {
            get
            {
                bool output = false;
                if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
                {
                    output = true;
                }

                return output;
            }
        }

        public async Task LoginButton ()
        {
            try
            {
                var result = await _apiHelper.Authenticate(UserName, Password);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }


    }
}
