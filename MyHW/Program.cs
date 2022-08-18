using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using MyHomeWork;
using Starter;
using HomeWork_All;

namespace MyHW
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #region
            //Application.Run(new FrmProducts());
            //Application.Run(new FrmCategoryProducts());
            //Application.Run(new FrmListBox());
            //Application.Run(new FrmAdventureWorks());
            //Application.Run(new FrmMyAlbum_V1()); 
            //Application.Run(new FrmCustomers());
            //Application.Run(new FrmLogon());
            //Application.Run(new FrmMyAlbum_V1()); 
            //Application.Run(new FrmConnected()); 
            //Application.Run(new FrmTreeView());
            //Application.Run(new Form1());
            //Application.Run(new FrmMyAlbum_V2()); 
            #endregion
            Application.Run(new FrmLogon());


        }
    }
}
