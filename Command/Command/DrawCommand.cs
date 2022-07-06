using Command.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class DrawCommand : ICommand
    {
        //描画対象
        protected Drawable drawable;

        //描画位置
        private Point point;

        //コンストラクタ
        public DrawCommand(Drawable drawable, Point point)
        {
            this.drawable = drawable;
            this.point = point;
        }

        //実行
        public void Execute()
        {
            drawable.Draw(point.X, point.Y);
        }
    }
}
