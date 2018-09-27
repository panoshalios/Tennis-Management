using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Management_Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length == 1)
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(args[0]);
                if(fileInfo.Exists)
                {
                    throw new NotImplementedException("Handling of opening files not implemented.");
                }
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
