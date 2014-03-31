using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TmAlignCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WorkingDirectory = @"C:\";
            p.StartInfo.FileName = @"C:\tmalign";

            for (int i = 2; i < 5; i++)
            {
                p.StartInfo.Arguments = "-A a1.pdb -B a3.pdb";
                p.Start();


                //Process.Start(
                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }

            //Process.Start(@"D:\other pen drive backup\Umassd Sem 1\tmalign\Debug\tmalign.exe", "-A a1 -B a2");

        }
    }
}
