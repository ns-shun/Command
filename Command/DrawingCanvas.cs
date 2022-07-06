using Command.Command;
using Command.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class DrawingCanvas : UserControl, Drawable
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.Name = "DrawingCanvas";
            this.Load += new System.EventHandler(this.DrawingCanvas_Load);
            this.ResumeLayout(false);

        }

        private void DrawingCanvas_Load(object sender, EventArgs e)
        {

        }

        private Color color = Color.Red;

        private int radius = 6;

        private MacroCommand _history;

        public DrawingCanvas()
        {
            InitializeComponent();
        }

        public void SetHistory(MacroCommand history) => _history = history;

        public void Draw(int x, int y)
        {
            using (var g = CreateGraphics())
            using (var redBrush = new SolidBrush(color))
            {
                Rectangle rectangle = new Rectangle(x, y, radius, radius);
                g.FillEllipse(redBrush, rectangle);
            }
        }
    }
}
