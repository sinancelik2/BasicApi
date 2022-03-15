using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Parameters
{
   public class Requestparameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public Requestparameter(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
