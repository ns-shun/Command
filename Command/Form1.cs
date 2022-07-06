using Command.Command;
using Command.Drawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        private MacroCommand history = new MacroCommand();

        //private DrawCanvas drawCanvas;

        public Form1()
        {
            InitializeComponent();

            drawingCanvas1.SetHistory(history);
            drawingCanvas1.MouseClick += drawingCanvas1_MouseClick;
            //drawingCanvas1.MouseMove += drawingCanvas1_MouseMove;
            //drawingCanvas1.MouseUp += drawingCanvas1_MouseUp;
            //drawingCanvas1.MouseDown += drawingCanvas1_MouseDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool drag = false;

        //マウスが動いている時
        private void drawingCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                ICommand command = new DrawCommand(drawingCanvas1, e.Location);
                history.Apppend(command);
                command.Execute();
            }
        }

        private void drawingCanvas1_MouseClick(object sender, MouseEventArgs e)
        {
            ICommand command = new DrawCommand(drawingCanvas1, e.Location);
            history.Apppend(command);
            command.Execute();
        }

        private void drawingCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void drawingCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void drawingCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawingCanvas1.Refresh();
            history.Undo();
            history.Execute();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            history.Clear();
            drawingCanvas1.Invalidate();
        }
    }
}
