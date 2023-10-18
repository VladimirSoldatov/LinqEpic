using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEpic
{
    internal struct Company
    {
        public int ID_comp { set; get; }
        public string name { set; get; }

        public override string ToString()
        {
            return $"ID: {ID_comp}\nCompany: {name}";
        }

    }
}
