using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApressXaml.Usb
{
    public class UserLoginService : IUserLoginService
    {
        public string GreetUser(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("userName");

            if (userName.Length == 0)
                throw new ArgumentException("userName must have at least one character.");

            return string.Format("Hello {0}!", userName);
        }
    }
}
