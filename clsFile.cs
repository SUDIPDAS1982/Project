//===============================================================================
//                                                                              '
//                          SOFTWARE  :  "SealTest-Utility"                     '
//                      CLASS MODULE  :  clsFile                                '
//                        VERSION NO  :  1.0                                    '
//                      DEVELOPED BY  :  AdvEnSoft, Inc.                        '
//                     LAST MODIFIED  :  01DEC17                                '
//                                                                              '
//===============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class clsFile
    {
        const string mConfigFile_Name = "";

       #region "MEMBER VARIABLES:"

            private String mDataSourceName;
            private string mLogFileName;

        #endregion    
       
        #region "PROPERTY ROUTINES:"
            
            public String DataSourceName
            //=======================
            {
                get { return mDataSourceName; }
                set { mDataSourceName = value; }
            }

        #endregion


            #region "CONSTRUCTOR:"
            
                public clsFile()
                //===============
                {
                    //....Reads Configuration File.
                    ////ReadConfigFile();
                }
            #endregion


            #region  "UTILITY ROUTINES:"


                public void ReadConfigFile()
                //=======================
                {
                    FileStream pSR;
                    XmlDocument pXML;
                    pXML = new XmlDocument();

                    try
                    {
                          pSR = new FileStream(mConfigFile_Name, FileMode.Open);
                          pXML.Load(pSR);

                        //....Root Node of XML.
                        XmlNode pRoot;
                        pRoot = pXML.DocumentElement;

                        foreach (XmlNode pRChild in pRoot.ChildNodes)
                        {
                            switch (pRChild.Name)
                            {
                                case "DataSource":
                                    //--------------
                                    mDataSourceName = pRChild.InnerText;
                                    break;
                            }
                        }
                    }
                    catch(Exception pExp)
                    {
                        MessageBox.Show(pExp.Message, "DataSourceName Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        #endregion
    }
}
