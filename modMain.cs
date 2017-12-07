//===============================================================================
//                                                                              '
//                          SOFTWARE  :  "DataTransferUtility"                  '
//                      CLASS MODULE  :  modMain                                '
//                        VERSION NO  :  1.0                                    '
//                      DEVELOPED BY  :  AdvEnSoft, Inc.                        '
//                     LAST MODIFIED  :  07DEC17                                '
//                                                                              '
//===============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class modMain
    {
		public static clsFile gFile = new clsFile();
        public static clsDB gDB = new clsDB();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new frmMain());
        }
    }
}
