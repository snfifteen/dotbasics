using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotBasics.Excel
{

    public class Exporter<T> where T : ICollection<T>
    {
        private ICollection<T> _iCollection;
        public Exporter(ICollection<T> iCollection) { 
            _iCollection = iCollection;
        }
    }
    
}
