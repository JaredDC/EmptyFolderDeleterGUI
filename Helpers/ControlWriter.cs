﻿using System.IO;
using System.Text;
using System.Windows.Forms;

namespace empty_folder_deleter.Helpers
{
    public class ControlWriter : TextWriter
    {
        private TextBox textbox;
        public ControlWriter(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            string s = "";
            s += value;
            textbox.AppendText(s);
        }

        public override void Write(string value)
        {
            textbox.AppendText(value);
        }

        public override void WriteLine(string value)
        {
            textbox.AppendText(value+NewLine);
            
            textbox.Update();
        }
        
        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
