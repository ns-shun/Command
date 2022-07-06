using Command.Command;
using Command.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class DrawCanvas : UserControl, Drawable
{
    private Color color = Color.Red;

    private int radius = 6;

    private MacroCommand _history;

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // DrawCanvas
        // 
        this.Name = "DrawCanvas";
        this.Load += new System.EventHandler(this.DrawCanvas_Load);
        this.ResumeLayout(false);

    }

    private void DrawCanvas_Load(object sender, EventArgs e)
    {

    }

    public DrawCanvas(MacroCommand history)
    {
        InitializeComponent();
        _history = history;
    }

    public void paint(Graphics g)
    {
        _history.Execute();
    }

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

