using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEpic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageClass manage = new ManageClass();
            manage.getCompanies();
            manage.viewCompanies();

        }
    }
}
