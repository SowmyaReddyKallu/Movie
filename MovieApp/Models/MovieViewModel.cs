using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieViewModel :MovieModel
    {
        private int _pageIndex;
         
        public int PageIndex
        {
            get { return _pageIndex; }
            set { _pageIndex = value; }
        }        
    }
}
