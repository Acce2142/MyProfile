using System;
using MyProfile.Core;
using MyShop.Core.Helpers;

namespace EmailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailHelper helper = new EmailHelper();
            helper.send();
            
        }
    }
}
