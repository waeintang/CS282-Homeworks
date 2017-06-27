using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Obeserve
{
    public interface IObserver
    {
        void Render(Object sender, EventArgs e);
    }
}
