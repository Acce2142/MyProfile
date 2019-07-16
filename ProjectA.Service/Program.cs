using ProjectA.Core.Services;
using System;

namespace ProjectA.Service
{
    class Program
    {
        static void Main()
        {
           
                NetworkHelper helper = new NetworkHelper();
                helper.GetRequest("www.google.com.au");
            
        }
    }
}
