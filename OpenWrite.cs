using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shifr1
{
    internal class OpenWrite
    {
        private string ext = "*";

        public OpenWrite() {
        }
        public OpenWrite(string Ext)
        {
            ext = Ext;
        }

        public byte[] open()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = $"Файл(*.{ext})|*.{ext}";
            if (op.ShowDialog() == true)
            {
                using (FileStream obj = new FileStream(op.FileName, FileMode.Open))
                {
                    byte[] fo = new byte[obj.Length];
                    obj.Read(fo, 0, fo.Length);
                    obj.Close();
                    return fo;
                }
                
            }
            return null;
        }

        public void write(byte[] fo)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = $"Файл(*.{ext})|*.{ext}";
            if (op.ShowDialog() == true)
            {
                using (FileStream obj = new FileStream(op.FileName, FileMode.Create))
                {
                    obj.Write(fo, 0, fo.Length);
                    obj.Close();
                }
            }
            
        }
    }
}
