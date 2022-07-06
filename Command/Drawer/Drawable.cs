using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command.Drawer
{
    public interface Drawable
    {
        public void Draw(int x, int y);
    }
}
