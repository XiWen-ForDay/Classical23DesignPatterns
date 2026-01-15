using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRichBoxToolkit
{
    public static class ConsoleBox
    {
        public static RichTextBox richTextBox;
        public static void Initialize(RichTextBox RichTextBox)
        {
            richTextBox = RichTextBox;
        }
        public static void WriteLine(string text)
        {
            richTextBox.AppendText(text+'\n');
        }
        public static void Clear()
        {
            richTextBox.Clear();
        }
    }
}
