using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor.Actions
{
    public class SaveTextAction
    {
        RichTextBox rtb;
        string path;

        public SaveTextAction(RichTextBox rTB,string path)
        {
            rtb = rTB;
            this.path = path;
        }

        public void Execute()
        {
            StreamWriter write = new StreamWriter(File.Create(path));
                write.Write(rtb.Text);
                write.Dispose();

            
        }

    }
}
