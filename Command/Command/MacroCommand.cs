using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> commands = new Stack<ICommand>();

        // 実行
        public void Execute()
        {
            if (commands.Count > 0)
            {
                IEnumerator enumerator = commands.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ICommand obj = (ICommand)enumerator.Current;
                    obj.Execute();
                }
            }
        }

        // 追加
        public virtual void Apppend(ICommand addCommand)
        {
            if (addCommand != this) commands.Push(addCommand);
        }

        // 削除
        public void Undo()
        {
            if (commands.Count > 0) commands.Pop();
        }

        // 全件削除
        public void Clear() => commands.Clear();
    }
}
