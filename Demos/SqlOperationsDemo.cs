using CSharp_Fundamentals.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.Demos
{
    internal static class SqlOperationsDemo
    {
        public static void Test()
        {
            Console.WriteLine(SqlHelper.IsConnected() ?
                "Connected Successfully" :
                "Not Connected Successfully");

            SqlHelper.Insert("Kathmandu Nayabazar", "Sindhupalchok", "Kathmandu", "2", "44600");
        }
    }
}
