using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEpic
{
    internal class ManageClass
    {
        List<Company> companies;
        List<Pass_in_trap> pass_In_Traps;
        List<Passenger> passengers;
        List<Trip> trips;
        public ManageClass()
        {
            companies = new List<Company>();
            pass_In_Traps = new List<Pass_in_trap>();
            passengers = new List<Passenger>();
            trips = new List<Trip>();
        }
        public void getCompanies()
        {
            if (!File.Exists("Company.csv"))
                Console.WriteLine("Файл Company.csv не существует");
            else
            {
                using (StreamReader sr = new StreamReader("Company.csv"))
                {
                    int str = 0;
                    while(!sr.EndOfStream)
                    {
                        str++;
                        if (str == 1)
                        {
                            sr.ReadLine();
                            continue;
                        }
                        string[] line = sr.ReadLine().Split(';');
                        companies.Add(new Company{ID_comp = Int32.Parse(line[0]) , name = line[1].Trim('"')});
                    }
                }
            }
        }
        public void viewCompanies()
        {
            companies.ForEach(s => Console.WriteLine(s));
        }
    }
}
