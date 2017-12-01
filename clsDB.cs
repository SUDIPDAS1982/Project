//===============================================================================
//                                                                              '
//                          SOFTWARE  :  "SealTest-Utility"                     '
//                      CLASS MODULE  :  clsDB                                  '
//                        VERSION NO  :  1.0                                    '
//                      DEVELOPED BY  :  AdvEnSoft, Inc.                        '
//                     LAST MODIFIED  :  01DEC17                                '
//                                                                              '
//===============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace WindowsFormsApplication1
{
   
    class clsDB
    {
        private String mDataSourceName;


        //public clsDB(String DataSourceName_In)
        //{
        //    mDataSourceName = DataSourceName_In;
        //}

        public SqlConnection GetConnection(String DBName_In)
        //===================================================
        {
            SqlConnection pGetConnection = new SqlConnection();

            try
            {
                string pstrConnectDB = "";
                pstrConnectDB = "Data source= PC-06;" +
                                //"Initial Catalog = BearingDB3a;" +
                                 "Initial Catalog = " + DBName_In + ";" +
                                "Integrated Security= SSPI;";


                //....Create & Open a new Connection -
                pGetConnection = new SqlConnection(pstrConnectDB);
                pGetConnection.Open();
            }

            catch (System.Data.SqlClient.SqlException pEXP)
            {
                //throw new System.Exception(pEXP.Message, pEXP.InnerException);
                //....Handles connection-level Errors
                MessageBox.Show(pEXP.Message + "--" + pEXP.StackTrace, "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (InvalidOperationException pEXP)
            {
                MessageBox.Show(pEXP.Message + "--" + pEXP.StackTrace, "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return pGetConnection;
        }

        public SqlDataReader GetDataReader(String DBName_In, string strSELECTQry_In,ref SqlConnection Conn_In)
        //=================================================================================== 

               //This routine returns DataReader
        //       Input   Parameters      :   SQL Statement 
        //       Output  Parameters      :   DataReader
        {
            try
            {
                string pstrConnectDB = "";
                pstrConnectDB = "Data source= PC-06;" +
                                //"Initial Catalog = BearingDB3a;" +
                                "Initial Catalog = " + DBName_In + ";" +
                                "Integrated Security= SSPI;";

                //....Create & Open a new Connection -
                Conn_In = new SqlConnection(pstrConnectDB);
                Conn_In.Open();
            }

            catch (System.Data.SqlClient.SqlException pEXP)
            {
                //throw new System.Exception(pEXP.Message, pEXP.InnerException);
                //....Handles connection-level Errors
                MessageBox.Show(pEXP.Message + "--" + pEXP.StackTrace, "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (InvalidOperationException pEXP)
            {
                MessageBox.Show(pEXP.Message + "--" + pEXP.StackTrace, "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlDataReader pGetDataReader = null;
            SqlCommand pCmd = new SqlCommand(strSELECTQry_In, Conn_In);
            SqlDataReader pDR = null;

            try
            { pDR = pCmd.ExecuteReader(); }

            catch (Exception pEXP)
            {
                MessageBox.Show(pEXP.Message + "--" + pEXP.StackTrace, "Data Read Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            { pGetDataReader = pDR; }

            return pGetDataReader;
        }

        public int ExecuteCommand(string strACTIONQry_In, string DBName_In)
        //==================================================================

                //This routine returns DataReader
        //       Input   Parameters      :   SQL Statement 
        //       Output  Parameters      :   DataReader
        {
            int pExecuteCommand = 0;

            SqlConnection pConn = new SqlConnection();
            pConn = GetConnection(DBName_In);

            SqlCommand pCmd = new SqlCommand(strACTIONQry_In, pConn);
            int pCountRecords = 0;
            
            try
            {
                pCountRecords = pCmd.ExecuteNonQuery();
            }

            catch (System.Data.SqlClient.SqlException pEXP)
            {
                MessageBox.Show("Error in Data Entry.", "Command Execution Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                pExecuteCommand = pCountRecords;
            }

            pConn.Close();

            return pExecuteCommand;
        }

          

    }
}
