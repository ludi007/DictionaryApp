using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Months
    {
        private string monthName { get; set; }

        public Months(string monthname)
        {
            this.monthName = monthname;
        }

        public override string ToString()
        {
            return string.Format("Month Name:{0}",  monthName);
        }
    }
}
