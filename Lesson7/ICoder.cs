using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public interface ICoder
    {
        public string Encode(string input);
        public string Decode(string input);
    }
}
