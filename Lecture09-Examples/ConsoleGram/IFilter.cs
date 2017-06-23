using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public interface IFilter
    {
        string GetImage(string image);
    }
}
