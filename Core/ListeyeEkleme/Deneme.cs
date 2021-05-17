using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.ListeyeEkleme
{
    public class Deneme <T> where T: ListBox
    {
        void olustur(T entity)
        {
            T.Container("s");
        }
    }
}
