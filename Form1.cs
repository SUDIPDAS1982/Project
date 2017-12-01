//===============================================================================
//                                                                              '
//                          SOFTWARE  :  "SealTest-Utility"                     '
//                      CLASS MODULE  :  frmMain                                '
//                        VERSION NO  :  1.0                                    '
//                      DEVELOPED BY  :  AdvEnSoft, Inc.                        '
//                     LAST MODIFIED  :  01DEC17                                '
//                                                                              '
//===============================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> pOrg_No;
       
        List<string> pTemp_No;
        List<string> pTemp_No_Suffix;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        //===================================================
        {
            

        }

        private void cmdDataTransfer_Click(object sender, EventArgs e)
            //=========================================================
        {
            string pstrSQL = "";
            SqlConnection pCon = null;
            SqlDataReader pDR = null;
            String pstrActionSQL = "";
            string pstrINSERT = "";
            string pstrValues = "";

            Cursor = Cursors.WaitCursor;
            StreamWriter pSW = null;
            string pFilePath = "C:\\Seal Suite\\SealTest\\Log File\\Log.txt";

            if (File.Exists(pFilePath))
            {
                pSW = new StreamWriter(pFilePath, true);
                pSW.WriteLine("Date".PadRight(15) + "Time");
                pSW.WriteLine(DateTime.Now.ToShortDateString().PadRight(15) + DateTime.Now.ToShortTimeString());
                pSW.WriteLine();
                pSW.WriteLine("Database Name:".PadRight(15) + "SealPartDB2");
                pSW.WriteLine("==============");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "Delete Existing Records:");
                pSW.WriteLine("".PadRight(5) + "------------------------");
                pSW.WriteLine();
                //pSW.Close();
            }
            else
            {
                pSW = File.CreateText(pFilePath);               
                pSW.WriteLine();
                pSW.WriteLine("Date".PadRight(15) + "Time");
                pSW.WriteLine(DateTime.Now.ToShortDateString().PadRight(15) + DateTime.Now.ToShortTimeString());
                pSW.WriteLine();
                pSW.WriteLine("Database Name:".PadRight(15) + "SealPartDB2");
                pSW.WriteLine("==============");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "Delete Existing Records:");
                pSW.WriteLine("".PadRight(5) + "------------------------");
                pSW.WriteLine();
               //pSW.Close();
            }

            //=============================

            #region "DELETE EXISTING RECORDS FROM TABLES:"


                #region "tblCustomer:"           
                //....tblCustomer
                int pSuccess = 0;
                pstrActionSQL = "Delete FROM tblCustomer";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblCustomer:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "tblCust_Index:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblPlatform:"
                //....tblPlatform
                pstrActionSQL = "Delete FROM tblPlatform";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblPlatform:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "tblPlat_Index:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblLocation:"               
                //....tblLocation
                pstrActionSQL = "Delete FROM tblLocation";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblLocation:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "tblLoc_Index:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblPN:"
                //....tblPN
                pstrActionSQL = "Delete FROM tblPN";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblPN:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "tblPN_Index:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblRev:"
                //....tblRev
                pstrActionSQL = "Delete FROM tblRev";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblRev:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "tblRev_Index:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblProject:"               
                //....tblProject
                pstrActionSQL = "Delete FROM tblProject";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblProject:".PadRight(18) + "All Records of have been deleted successfully");

                #endregion


                #region "tblHW_Face:"               
                //....tblHW_Face
                pstrActionSQL = "Delete FROM tblHW_Face";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblHW_Face:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblHW_AdjCSeal:"                
                //....tblHW_AdjCSeal
                pstrActionSQL = "Delete FROM tblHW_AdjCSeal";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblHW_AdjCSeal:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblHW_AdjESeal:"               
                //....tblHW_AdjESeal
                pstrActionSQL = "Delete FROM tblHW_AdjESeal";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblHW_AdjESeal:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                #endregion


                #region "tblHW_AdjUSeal:"                          
                //....tblHW_AdjUSeal
                pstrActionSQL = "Delete FROM tblHW_AdjUSeal";
                pSuccess = modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                pSW.WriteLine("".PadRight(5) + "tblHW_AdjUSeal:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine();

                #endregion

            #endregion

            ////MessageBox.Show("All Recrords have been Deleted success fully", "Delete Records", MessageBoxButtons.OK);

            //pSW.Close();

            #region "COPY RECORDS FROM OLD DATABASE:"

                pSW.WriteLine("".PadRight(5) + "Copy Records from SealPartDB1a to SealPartDB2:");
                pSW.WriteLine("".PadRight(5) + "------------------------------------------------");

                #region "tblCustomer:"

                //....tblCustomer
                pstrSQL = "Select * FROM tblCustomer ORDER BY fldID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                Boolean pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblCustomer (fldID, fldName, fldDimUnit, fldCulturalFormat)";
                            pstrValues = " Values (" + pDR["fldID"] + ",'" + pDR["fldName"] + "','" + pDR["fldUnit"] + "', '" + pDR["fldCulturalFormat"] + "')";

                            pstrActionSQL = pstrINSERT + pstrValues;

                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #region "tblCust_Index:"

                            //....tblCust_Index
                            if (pDR["fldIndex"] != DBNull.Value)
                            {
                                pstrINSERT = "INSERT INTO tblCust_Index (fldID, fldIndex)";
                                pstrValues = " Values (" + pDR["fldID"] + "," + pDR["fldIndex"] + ")";

                            }
                            else
                            {
                                pstrINSERT = "INSERT INTO tblCust_Index (fldID)";
                                //pstrValues = " Values (" + pDR["fldID"] + "," + DBNull.Value + ")";
                                pstrValues = " Values (" + pDR["fldID"] + ")";
                            }

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #endregion
                        }

                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblCustomer:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }

                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblCustomer:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblCustomer:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblPlatform:"               

                //....tblPlatform
                pstrSQL = "Select * FROM tblPlatform ORDER BY fldID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblPlatform (fldCustID, fldID, fldName)";
                            pstrValues = " Values (" + pDR["fldCustID"] + "," + pDR["fldID"] + ",'" + pDR["fldName"] + "')";

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #region "tblPlat_Index:"

                            //....tblPlat_Index
                            if (pDR["fldIndex"] != DBNull.Value)
                            {
                                pstrINSERT = "INSERT INTO tblPlat_Index (fldCustID, fldID, fldIndex)";
                                pstrValues = " Values (" + pDR["fldCustID"] + "," + pDR["fldID"] + "," + pDR["fldIndex"] + ")";
                            }
                            else
                            {
                                pstrINSERT = "INSERT INTO tblPlat_Index (fldCustID, fldID)";
                                pstrValues = " Values (" + pDR["fldCustID"] + "," + pDR["fldID"] + ")";
                            }

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #endregion
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblPlatform:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblPlatform:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pSW.WriteLine("".PadRight(5) + "tblPlat_Index:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }

                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblPlatform:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                    pSW.WriteLine("".PadRight(5) + "tblPlat_Index:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblLocation:"
               
                //....tblLocation
                pstrSQL = "Select * FROM tblLocation ORDER BY fldID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblLocation (fldCustID, fldPlatformID, fldID, fldLoc)";
                            pstrValues = " Values (" + pDR["fldCustID"] + "," + pDR["fldPlatformID"] + "," + pDR["fldID"] + ",'" + pDR["fldLoc"] + "')";

                            pstrActionSQL = pstrINSERT + pstrValues;

                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #region "tblPN_Index:"

                            //....tblLoc_Index
                            if (pDR["fldIndex"] != DBNull.Value)
                            {
                                pstrINSERT = "INSERT INTO tblLoc_Index (fldCustID, fldPlatformID, fldID, fldIndex)";
                                pstrValues = " Values (" + pDR["fldCustID"] + "," + pDR["fldPlatformID"] + "," + pDR["fldID"] + "," + pDR["fldIndex"] + ")";
                            }
                            else
                            {
                                pstrINSERT = "INSERT INTO tblLoc_Index (fldCustID, fldPlatformID, fldID)";
                                pstrValues = " Values (" + pDR["fldCustID"] + "," + pDR["fldPlatformID"] + "," + pDR["fldID"] + ")";
                            }
                            
                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #endregion
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLocation:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }

                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLocation:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pSW.WriteLine("".PadRight(5) + "tblLoc_Index:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblLocation:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                    pSW.WriteLine("".PadRight(5) + "tblLoc_Index:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblPN:"
               
                //....tblPN
                pstrSQL = "Select * FROM tblPN ORDER BY fldID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblPN (fldID, fldCurrentExists, fldCurrent, fldLegacyExists, fldLegacyType, fldLegacy, " +
                                          "fldParentCurrentExists, fldParentCurrent, fldParentCurrentRev, fldAppType" + ")";

                            int pCurrentExists = 0;
                            int pLegaceExists = 0;
                            int pParenCurrentExists = 0;
                            int pLegacyType = -1;
                            if (pDR["fldNew"].ToString() != "")
                            {
                                pCurrentExists = 1;
                            }

                            if (pDR["fldLegacy"].ToString() != "")
                            {
                                pLegaceExists = 1;
                            }

                            if (pDR["fldParent"].ToString() != "")
                            {
                                pParenCurrentExists = 1;
                            }

                            if (Convert.ToInt16(pDR["fldLegacyType"]) == 1)
                            {
                                pLegacyType = 0;
                            }
                            else if (Convert.ToInt16(pDR["fldLegacyType"]) == 0)
                            {
                                pLegacyType = 1;
                            }


                            pstrValues = " Values (" + pDR["fldID"] + "," + pCurrentExists + ",'" + pDR["fldNew"] + "'," + pLegaceExists + "," + pLegacyType +
                                           ",'" + pDR["fldLegacy"] + "'," + pParenCurrentExists + ",'" + pDR["fldParent"] + "','" + pDR["fldParentRev"] +
                                          "','" + pDR["fldAppType"] + "')";

                            pstrActionSQL = pstrINSERT + pstrValues;

                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #region "tblPN_Index:"

                            //....tblPN_Index
                            if (pDR["fldIndex"] != DBNull.Value)
                            {
                                pstrINSERT = "INSERT INTO tblPN_Index (fldID, fldIndex)";
                                pstrValues = " Values (" + pDR["fldID"] + "," + pDR["fldIndex"] + ")";
                            }
                            else
                            {
                                pstrINSERT = "INSERT INTO tblPN_Index (fldID)";
                                pstrValues = " Values (" + pDR["fldID"] + ")";
                            }

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            #endregion
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblPN:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblPN:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pSW.WriteLine("".PadRight(5) + "tblPN_Index:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblPN:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                    pSW.WriteLine("".PadRight(5) + "tblPN_Index:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblRev:"

                //....tblRev
                pstrSQL = "Select * FROM tblRev ORDER BY fldID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblRev (fldPNID, fldID, fldCurrent, fldLegacy, fldDWGFile)";
                            pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldID"] + ",'" + pDR["fldNew"] + "','" + pDR["fldLegacy"] + "','" + pDR["fldDWGFile"] + "')";

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            //....tblRev_Index
                            if (pDR["fldIndex"] != DBNull.Value)
                            {
                                pstrINSERT = "INSERT INTO tblRev_Index (fldPNID, fldID, fldIndex)";
                                pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldID"] + "," + pDR["fldIndex"] + ")";
                            }
                            else
                            {
                                pstrINSERT = "INSERT INTO tblRev_Index (fldPNID, fldID)";
                                pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldID"] + ")";
                            }

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblRev:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblRev:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pSW.WriteLine("".PadRight(5) + "tblRev_Index:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblRev:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                    pSW.WriteLine("".PadRight(5) + "tblRev:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblProject:"
               
                //....tblProject
                pstrSQL = "Select * FROM tblPNR_CustInfo ORDER BY fldID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblProject (fldPNID, fldRevID, fldCustID, fldPlatformID, fldLocID, fldID, fldPN_Cust)";
                            pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldRevID"] + "," + pDR["fldCustID"] + "," + pDR["fldPlatformID"] +
                                         "," + pDR["fldLocID"] + "," + pDR["fldID"] + ",'" + pDR["fldPN_Cust"] + "')";

                            pstrActionSQL = pstrINSERT + pstrValues;

                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblProject:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblProject:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblProject:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblHW_Face:"

                //....tblHW_Face
                pstrSQL = "Select * FROM tblHW_Face ORDER BY fldPNID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblHW_Face (fldPNID, fldRevID, fldType, fldMCS, fldSegmented, fldSegmentCount, fldMatName, fldHT, fldTemper, fldCoating, " +
                                          "fldSFinish, fldIsPlating, fldPlatingCode, fldPlatingThickCode, fldHfreeStd, fldHFreeTol1, fldHFreeTol2, fldPOrient, fldDControl," +
                                          "fldH11Tol, fldAdjusted)";

                            int pPlatingExists = 0;
                            object pSegmented = 0;
                            object pAdjusted = 0;
                            object pCoating = "NULL";
                            object pPlatingCode = "NULL";
                            object pPlatingThickCode = "NULL";

                            object pSFinish = 0;

                            if (pDR["fldPlating"] != DBNull.Value)
                            {
                                pPlatingExists = 1;
                            }

                            if (pDR["fldSegmented"] != DBNull.Value)
                            {
                                pSegmented = Convert.ToInt16(pDR["fldSegmented"]);

                            }
                            else
                            {
                                pSegmented = "NULL";
                            }

                            if (pDR["fldAdjusted"] != DBNull.Value)
                            {
                                pAdjusted = Convert.ToInt16(pDR["fldAdjusted"]);
                            }
                            else
                            {
                                pAdjusted = "NULL";
                            }

                            if (pDR["fldCoating"] != DBNull.Value)
                            {
                                pCoating = Convert.ToString(pDR["fldCoating"]);
                            }

                            if (pDR["fldSFinish"] != DBNull.Value)
                            {
                                pSFinish = Convert.ToInt16(pDR["fldSFinish"]).ToString();

                            }
                            else
                            {
                                pSFinish = "NULL";
                            }

                            if (pDR["fldPlating"] != DBNull.Value)
                            {
                                pPlatingCode = Convert.ToString(pDR["fldPlating"]);
                            }

                            if (pDR["fldPlatingThickCode"] != DBNull.Value)
                            {
                                pPlatingThickCode = Convert.ToString(pDR["fldPlatingThickCode"]);
                            }


                            pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldRevID"] + ",'" + pDR["fldType"] + "','" + pDR["fldMCS"] + "'," + pSegmented + "," + pDR["fldSegmentCount"] +
                                ",'" + pDR["fldMatName"] + "'," + pDR["fldHT"] + "," + pDR["fldTemper"] + ",'" + pDR["fldCoating"] + "'," + pSFinish + "," + pPlatingExists +
                                         ",'" + pPlatingCode + "','" + pPlatingThickCode + "'," + pDR["fldHfreeStd"] + "," + pDR["fldHFreeTol1"] + "," + pDR["fldHFreeTol2"] +
                                         ",'" + pDR["fldPOrient"] + "'," + pDR["fldDControl"] + "," + pDR["fldH11Tol"] + "," + pAdjusted + ")";

                            pstrActionSQL = pstrINSERT + pstrValues;

                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

                            //....Update fldGeomTemplate
                            String pstrSET = "", pstrWHERE;

                            int pPNID = Convert.ToInt16(pDR["fldPNID"]);
                            int pRevID = Convert.ToInt16(pDR["fldRevID"]);

                            #region "tblPN:"
                            //....tblPN
                            string pstrSQL1 = "Select * FROM tblPN WHERE fldID = " + pPNID + " ORDER BY fldID ASC";
                            pCon = new SqlConnection();
                            SqlDataReader pDR1 = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL1, ref pCon);

                            while (pDR1.Read())
                            {

                                object pGeomTemplate = 0;

                                if (pDR1["fldGeomTemplate"] != DBNull.Value)
                                {
                                    pGeomTemplate = Convert.ToInt16(pDR1["fldGeomTemplate"]);
                                }
                                else
                                {
                                    pGeomTemplate = "NULL";
                                }

                            #endregion

                            #region "Update tblHW_Face:"
                                

                            pstrSET = " SET fldGeomTemplate = " + pGeomTemplate;
                            pstrWHERE = " WHERE fldPNID = " + pPNID + " and fldRevID = " + pRevID;
                            pstrActionSQL = "UPDATE tblHW_Face" + pstrSET + pstrWHERE;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                            #endregion
                            }
                        }

                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblHW_Face:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }

                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblHW_Face:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblHW_Face:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblHW_AdjCSeal:"               

                //....
                pstrSQL = "Select * FROM tblHW_AdjCSeal ORDER BY fldPNID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblHW_AdjCSeal (fldPNID, fldRevID, fldDHFree, fldDThetaOpening, fldDT)";
                            pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldRevID"] + "," + pDR["fldDHFree"] + "," + pDR["fldDThetaOpening"] + "," + pDR["fldDT"] + ")";
                            pstrActionSQL = pstrINSERT + pstrValues;

                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblHW_AdjCSeal:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblHW_AdjCSeal:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblHW_AdjCSeal:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblHW_AdjESeal:"
               
                //....tblHW_AdjESeal
                pstrSQL = "Select * FROM tblHW_AdjESeal ORDER BY fldPNID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblHW_AdjESeal (fldPNID, fldRevID, fldDThetaE1, fldDThetaM1)";
                            pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldRevID"] + "," + pDR["fldDThetaE1"] + "," + pDR["fldDThetaM1"] + ")";

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblHW_AdjESeal:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblHW_AdjESeal:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblHW_AdjESeal:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion


                #region "tblHW_AdjUSeal:"
                

                //....tblHW_AdjUSeal
                pstrSQL = "Select * FROM tblHW_AdjUSeal ORDER BY fldPNID ASC";
                pCon = new SqlConnection();
                pDR = modMain.gDB.GetDataReader("SealPartDB1", pstrSQL, ref pCon);
                pError = false;

                if (pDR.HasRows)
                {
                    while (pDR.Read())
                    {
                        try
                        {
                            pstrINSERT = "INSERT INTO tblHW_AdjUSeal (fldPNID, fldRevID, fldDT, fldDTheta1, fldDTheta2, fldDRad1, fldDRad2, fldDLLeg)";

                            pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldRevID"] + "," + pDR["fldDT"] + "," + pDR["fldDTheta1"] + "," + pDR["fldDTheta2"] +
                                          "," + pDR["fldDRad1"] + "," + pDR["fldDRad2"] + "," + pDR["fldDLLeg"] + ")";

                            pstrActionSQL = pstrINSERT + pstrValues;
                            modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
                        }
                        catch
                        {
                            pSW.WriteLine("".PadRight(5) + "tblHW_AdjUSeal:".PadRight(18) + "No Records of have been copied successfully");
                            pError = true;
                            break;
                        }
                    }

                    if (!pError)
                    {
                        pSW.WriteLine("".PadRight(5) + "tblHW_AdjUSeal:".PadRight(18) + "All Records of have been copied successfully");
                        pSW.WriteLine();
                        pDR = null;
                    }
                }
                else
                {
                    pSW.WriteLine("".PadRight(5) + "tblHW_AdjUSeal:".PadRight(18) + "No Record Exists");
                    pSW.WriteLine();
                }

                #endregion

              
            #endregion

            pSW.Close();
            MessageBox.Show("Records have been copied succesfully", "Copy Data", MessageBoxButtons.OK);
            Cursor = Cursors.Default;

        }

        private void cmdClear_Click(object sender, EventArgs e)
            //==================================================
        {
            //string pstrActionSQL = "";

            ////....tblCustomer
            //pstrActionSQL = "Delete FROM tblCustomer";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblPlatform
            //pstrActionSQL = "Delete FROM tblPlatform";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblLocation
            //pstrActionSQL = "Delete FROM tblLocation";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblPN
            //pstrActionSQL = "Delete FROM tblPN";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");
            
            ////....tblRev
            //pstrActionSQL = "Delete FROM tblRev";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblHW_Face
            //pstrActionSQL = "Delete FROM tblHW_Face";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblHW_AdjCSeal
            //pstrActionSQL = "Delete FROM tblHW_AdjCSeal";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblHW_AdjESeal
            //pstrActionSQL = "Delete FROM tblHW_AdjESeal";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            ////....tblHW_AdjUSeal
            //pstrActionSQL = "Delete FROM tblHW_AdjUSeal";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealPartDB2");

            //MessageBox.Show("All Recrords have been Deleted success fully", "Delete Records", MessageBoxButtons.OK);

        }

        private void cmdDelete_Test_Click(object sender, EventArgs e)
            //========================================================
        {
            //string pstrActionSQL = "";

            ////....Standalone Tables
            ////........tblFile
            //pstrActionSQL = "Delete FROM tblFile";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            ////....tblFlowMeter
            //pstrActionSQL = "Delete FROM tblFlowMeter";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            ////....tblForceStand
            //pstrActionSQL = "Delete FROM tblForceStand";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");


            ////....tblLeakMedium
            //pstrActionSQL = "Delete FROM tblLeakMedium";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            ////....tblLeakStand
            //pstrActionSQL = "Delete FROM tblLeakStand";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");


            ////....tblLoadCell
            //pstrActionSQL = "Delete FROM tblLoadCell";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            ////....tblPlatenSurfaceFinish
            //pstrActionSQL = "Delete FROM tblPlatenSurfaceFinish";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            ////....tblTestUser
            //pstrActionSQL = "Delete FROM tblTestUser";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            ////....Cascading Table Deletion
            ////....tblTestProject
            //pstrActionSQL = "Delete FROM tblTestProject";
            //modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");

            //MessageBox.Show("All Recrords have been Deleted success fully", "Delete Records", MessageBoxButtons.OK);
        }

        private void cmdCopy_Test_Click(object sender, EventArgs e)
            //======================================================
        {
            string pstrSQL = "";
            SqlConnection pCon = null;
            SqlDataReader pDR = null;
            String pstrActionSQL = "";
            string pstrINSERT = "";
            string pstrValues = "";

            Cursor = Cursors.WaitCursor;

            StreamWriter pSW = null;
            string pFilePath = "C:\\Seal Suite\\SealTest\\Log File\\Log.txt";

            if (File.Exists(pFilePath))
            {
                pSW = new StreamWriter(pFilePath, true);
                pSW.WriteLine("Date".PadRight(15) + "Time");
                pSW.WriteLine(DateTime.Now.ToShortDateString().PadRight(15) + DateTime.Now.ToShortTimeString());
                pSW.WriteLine();
                pSW.WriteLine("Database Name:".PadRight(15) + "SealTestDB2");
                pSW.WriteLine("==============");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "Delete Existing Records:");
                pSW.WriteLine("".PadRight(5) + "------------------------");
                pSW.WriteLine();
                //pSW.Close();
            }
            else
            {
                pSW = File.CreateText(pFilePath);
                pSW.WriteLine();
                pSW.WriteLine("Date".PadRight(15) + "Time");
                pSW.WriteLine(DateTime.Now.ToShortDateString().PadRight(15) + DateTime.Now.ToShortTimeString());
                pSW.WriteLine();
                pSW.WriteLine("Database Name:".PadRight(15) + "SealTestDB2");
                pSW.WriteLine("==============");
                pSW.WriteLine();
                pSW.WriteLine("".PadRight(5) + "Delete Existing Records:");
                pSW.WriteLine("".PadRight(5) + "------------------------");
                pSW.WriteLine();
                //pSW.Close();
            }


            #region "DELETE EXISTING RECORDS FROM TABLES:"

                #region "STANDALONE TABLES:"
            
                //........tblFile
                pstrActionSQL = "Delete FROM tblFile";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblFile:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
         
                //....tblFlowMeter
                pstrActionSQL = "Delete FROM tblFlowMeter";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblFlowMeter:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                //....tblForceStand
                pstrActionSQL = "Delete FROM tblForceStand";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblForceStand:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();


                //....tblLeakMedium
                pstrActionSQL = "Delete FROM tblLeakMedium";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblLeakMedium:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                //....tblLeakStand
                pstrActionSQL = "Delete FROM tblLeakStand";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblLeakStand:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();


                //....tblLoadCell
                pstrActionSQL = "Delete FROM tblLoadCell";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblLoadCell:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                //....tblPlatenSurfaceFinish
                pstrActionSQL = "Delete FROM tblPlatenSurfaceFinish";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblFile:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

                //....tblTestUser
                pstrActionSQL = "Delete FROM tblTestUser";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblPlatenSurfaceFinish:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();

            #endregion

                #region "CASCADING TABLES:"
                //....tblTestProject
                pstrActionSQL = "Delete FROM tblTestProject";
                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                pSW.WriteLine("".PadRight(5) + "tblTestProject:".PadRight(18) + "All Records of have been deleted successfully");
                pSW.WriteLine();
                pSW.WriteLine();

                #endregion                             

            #endregion

            //MessageBox.Show("All Recrords have been Deleted success fully", "Delete Records", MessageBoxButtons.OK);


            pSW.WriteLine("".PadRight(5) + "Copy Records from SealTestDB2 to SealTestDB2a:");
            pSW.WriteLine("".PadRight(5) + "----------------------------------------------");
            pSW.WriteLine();

            #region "COPY RECORDS FROM OLD DATABASE:"

                #region "tblFile:"
           
                    //....tblFile
                    pstrSQL = "Select * FROM tblFile";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    Boolean pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblFile (fldID, fldFileName_EquipList, fldFileName_LeakProcedure, fldFileName_LoadProcedure)";

                                pstrValues = " Values (" + pDR["fldID"] + ",'" + pDR["fldFileName_EquipList"] + "','" + pDR["fldFileName_LeakProcedure"] + "','" + pDR["fldFileName_LoadProcedure"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblFile:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                       }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblFile:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }               
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblFile:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblFlowMeter:"
           
                    //....tblFlowMeter
                    pstrSQL = "Select * FROM tblFlowMeter";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblFlowMeter (fldMake, fldSN, fldRange, fldModelNo, fldDateCalibrationDue)";
                                pstrValues = " Values ('" + pDR["fldMake"] + "','" + pDR["fldSN"] + "','" + pDR["fldRange"] + "','" + pDR["fldModelNo"] + "','" + pDR["fldDateCalibrationDue"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblFlowMeter:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblFlowMeter:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblFlowMeter:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblFlowMeter:"

                    //....tblForceStand
                    pstrSQL = "Select * FROM tblForceStand";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblForceStand (fldName, fldSN, fldDateCalibrationDue)";
                                pstrValues = " Values ('" + pDR["fldName"] + "','" + pDR["fldSN"] + "','" + pDR["fldDateCalibrationDue"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblForceStand:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblForceStand:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }               
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblForceStand:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblFlowMeter:"
           
                    //....tblLeakMedium
                    pstrSQL = "Select * FROM tblLeakMedium";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblLeakMedium (fldName)";
                                pstrValues = " Values ('" + pDR["fldName"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLeakMedium:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLeakMedium:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLeakMedium:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblLeakStand:"
           
                    //....tblLeakStand
                    pstrSQL = "Select * FROM tblLeakStand";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblLeakStand (fldName, fldFixture)";
                                pstrValues = " Values ('" + pDR["fldName"] + "','" + pDR["fldFixture"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLeakStand:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLeakStand:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLeakStand:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblLoadCell:"
           
                    //....tblLoadCell
                    pstrSQL = "Select * FROM tblLoadCell";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblLoadCell (fldMake, fldSN, fldRange, fldModelNo, fldDateCalibrationDue)";
                                pstrValues = " Values ('" + pDR["fldMake"] + "','" + pDR["fldSN"] + "','" + pDR["fldRange"] + "','" + pDR["fldModelNo"] + "','" + pDR["fldDateCalibrationDue"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLoadCell:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }

                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLoadCell:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLoadCell:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblPlatenSurfaceFinish:"

                    //....tblPlatenSurfaceFinish
                    pstrSQL = "Select * FROM tblPlatenSurfaceFinish";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblPlatenSurfaceFinish (fldSF_Platen )";
                                pstrValues = " Values (" + pDR["fldSF_Platen"] + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblPlatenSurfaceFinish:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblPlatenSurfaceFinish:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblPlatenSurfaceFinish:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblTestProject:"

                    //....tblTestProject
                    pstrSQL = "Select * FROM tblTestProject";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            object pUserAdmin = "NULL";
                            object pUserSignedOff = 0;

                            if (pDR["fldUserAdmin"] != DBNull.Value)
                            {
                                pUserAdmin = Convert.ToString(pDR["fldUserAdmin"]);

                            }
                            else
                            {
                                pUserAdmin = "NULL";
                            }

                            if (pDR["fldSignedOff"] != DBNull.Value)
                            {
                                pUserSignedOff = Convert.ToInt16(pDR["fldSignedOff"]);

                            }
                            else
                            {
                                pUserSignedOff = "NULL";
                            }
                            try
                            {
                                pstrINSERT = "INSERT INTO tblTestProject (fldPNID, fldRevID, fldPNR_CustInfoID, fldID, fldUserAdmin, fldDateAdmin, fldSignedOff, fldUserSignedOff, fldDateSignedOff)";

                                pstrValues = " Values (" + pDR["fldPNID"] + "," + pDR["fldRevID"] + "," + pDR["fldPNR_CustInfoID"] + "," + pDR["fldID"] + ",'" +
                                               pDR["fldUserAdmin"] + "','" + pDR["fldDateAdmin"] + "'," + pUserSignedOff + ",'" + pDR["fldUserSignedOff"] + "','" + pDR["fldDateSignedOff"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;

                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblTestProject:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblTestProject:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblTestProject:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblSpec:"
            

                    //....tblSpec
                    int pTestProjectID = 0;
                    int pPNPD = 0;
                    int pRevID = 0;


                    object pLeakCavityDepth = "NULL";
                    object pLeakProcedure_FileName = "NULL";
                    object pLeakMedium = "NULL";
                    object pLeakPress = "NULL";

                    object pIsLeak_Leakege = "NULL";
           
                    object pIsLeakSpringBack = "NULL";
          
                    object pLoadProcedure_FileName = "NULL";
                    object pLoadType = "NULL";
                    object pLoadMin_CavityDepth = "NULL";
                    object pLoadRange_CavityDepth = "NULL";
                    object pLoadMax_CavityDepth = "NULL";
                    object pLoadMin = "NULL";
                    object pLoadMax = "NULL";

                    object pIsLoadSpringBack = "NULL";
                    Boolean pPlatingExists = false;         

                    pstrSQL = "Select * FROM tblSpec";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            pstrINSERT = "INSERT INTO tblSpec (fldTestProjectID, fldSealQty, fldIsLeak, fldIsLoad, fldIsPressure, fldSealFHIniMin_Unplated, fldSealFHIniMax_Unplated, " +
                                         "fldSealODPreMin_Unplated, fldSealODPreMax_Unplated, fldSealIDPreMin_Unplated, fldSealIDPreMax_Unplated, fldSealFHIniMin_Plated, fldSealFHIniMax_Plated, " +
                                         "fldSealODPreMin_Plated, fldSealODPreMax_Plated, fldSealIDPreMin_Plated, fldSealIDPreMax_Plated, fldLeakCavityDepth, fldLeakProcedure_FileName, " +
                                         "fldLeakMedium, fldLeakPress, fldIsLeak_Leakage, fldLeakMax_Unplated, fldLeakMax_Plated, fldIsLeakSpringBack, fldLeakSpringBackMin_Unplated, " +
                                         "fldLeakSpringBackMin_Plated, fldLoadProcedure_FileName, fldLoadType, fldLoadMin_CavityDepth, fldLoadRange_CavityDepth, fldLoadMax_CavityDepth, " +
                                         "fldLoadMin, fldLoadMax, fldIsLoadSpringBack, fldLoadSpringBackMin_Unplated, fldLoadSpringBackMin_Plated)";

                            try
                            {

                                pTestProjectID = Convert.ToInt16(pDR["fldTestProjectID"]);

                                if (pDR["fldLeakCavityDepth"] != DBNull.Value)
                                {
                                    pLeakCavityDepth = Convert.ToDouble(pDR["fldLeakCavityDepth"]);

                                }

                                if (pDR["fldLeakProcedure_FileName"] != DBNull.Value)
                                {
                                    pLeakProcedure_FileName = Convert.ToString(pDR["fldLeakProcedure_FileName"]);
                                }

                                if (pDR["fldLeakMedium"] != DBNull.Value)
                                {
                                    pLeakMedium = Convert.ToString(pDR["fldLeakMedium"]);
                                }


                                if (pDR["fldLeakPress"] != DBNull.Value)
                                {
                                    pLeakPress = Convert.ToDouble(pDR["fldLeakPress"]);
                                }

                                if (pDR["fldLeakMax"] != DBNull.Value)
                                {
                                    double pVal = Convert.ToDouble(pDR["fldLeakMax"]);

                                    if (Math.Abs(pVal) > 0)
                                    {
                                        pIsLeak_Leakege = 1;
                                    }
                                    else
                                    {
                                        pIsLeak_Leakege = 0;
                                    }
                                }

                                if (pDR["fldIsLeakSpringBack"] != DBNull.Value)
                                {
                                    pIsLeakSpringBack = Convert.ToInt16(pDR["fldIsLeakSpringBack"]);
                                }

                                if (pDR["fldLoadProcedure_FileName"] != DBNull.Value)
                                {
                                    pLoadProcedure_FileName = Convert.ToString(pDR["fldLoadProcedure_FileName"]);
                                }

                                if (pDR["fldLoadType"] != DBNull.Value)
                                {
                                    pLoadType = Convert.ToString(pDR["fldLoadType"]);
                                }

                                if (pDR["fldLoadMin_CavityDepth"] != DBNull.Value)
                                {
                                    pLoadMin_CavityDepth = Convert.ToDouble(pDR["fldLoadMin_CavityDepth"]);
                                }

                                if (pDR["fldLoadRange_CavityDepth"] != DBNull.Value)
                                {
                                    pLoadRange_CavityDepth = Convert.ToDouble(pDR["fldLoadRange_CavityDepth"]);
                                }

                                if (pDR["fldLoadMax_CavityDepth"] != DBNull.Value)
                                {
                                    pLoadMax_CavityDepth = Convert.ToDouble(pDR["fldLoadMax_CavityDepth"]);
                                }

                                if (pDR["fldLoadMin"] != DBNull.Value)
                                {
                                    pLoadMin = Convert.ToDouble(pDR["fldLoadMin"]);
                                }

                                if (pDR["fldLoadMax"] != DBNull.Value)
                                {
                                    pLoadMax = Convert.ToDouble(pDR["fldLoadMax"]);
                                }

                                if (pDR["fldIsLoadSpringBack"] != DBNull.Value)
                                {
                                    pIsLoadSpringBack = Convert.ToInt16(pDR["fldIsLoadSpringBack"]);
                                }

                                //....tblTestProject
                                string pstrSQL1 = "Select * FROM tblTestProject WHERE fldID = " + pTestProjectID + " ORDER BY fldID ASC";

                                pCon = new SqlConnection();

                                SqlDataReader pDR1 = modMain.gDB.GetDataReader("SealTestDB2a", pstrSQL1, ref pCon);

                                object pSealFHIniMin_Unplated = "NULL";
                                object pSealFHIniMax_Unplated = "NULL";
                                object pSealODPreMin_Unplated = "NULL";
                                object pSealODPreMax_Unplated = "NULL";
                                object pSealIDPreMin_Unplated = "NULL";
                                object pSealIDPreMax_Unplated = "NULL";

                                object pSealFHIniMin_Plated = "NULL";
                                object pSealFHIniMax_Plated = "NULL";
                                object pSealODPreMin_Plated = "NULL";
                                object pSealODPreMax_Plated = "NULL";
                                object pSealIDPreMin_Plated = "NULL";
                                object pSealIDPreMax_Plated = "NULL";

                                object pLeakMax_Unplated = "NULL";
                                object pLeakMax_Plated = "NULL";

                                object pLeakSpringBackMin_Unplated = "NULL";
                                object pLeakSpringBackMin_Plated = "NULL";

                                object pLoadSpringBackMin_Unplated = "NULL";
                                object pLoadSpringBackMin_Plated = "NULL";

                                if (pDR1.Read())
                                {
                                    pPNPD = Convert.ToInt16(pDR1["fldPNID"]);
                                    pRevID = Convert.ToInt16(pDR1["fldRevID"]);


                                    string pstrSQL2 = "Select * FROM tblHW_Face WHERE fldPNID = " + pPNPD + "AND fldRevID = " + pRevID + " ORDER BY fldPNID ASC";
                                    SqlDataReader pDR2 = modMain.gDB.GetDataReader("SealPartDB2", pstrSQL2, ref pCon);

                                    //Boolean pPlatingExists;
                                    if (pDR2.Read())
                                    {
                                        pPlatingExists = Convert.ToBoolean(pDR2["fldIsPlating"]);

                                        if (pPlatingExists)
                                        {
                                            pSealFHIniMin_Plated = Convert.ToDouble(pDR["fldSealFHIniMin"]);
                                            pSealFHIniMax_Plated = Convert.ToDouble(pDR["fldSealFHIniMax"]);
                                            pSealODPreMin_Plated = Convert.ToDouble(pDR["fldSealODPreMin"]);
                                            pSealODPreMax_Plated = Convert.ToDouble(pDR["fldSealODPreMax"]);
                                            pSealIDPreMin_Plated = Convert.ToDouble(pDR["fldSealIDPreMin"]);
                                            pSealIDPreMax_Plated = Convert.ToDouble(pDR["fldSealIDPreMax"]);
                                            pLeakMax_Plated = Convert.ToDouble(pDR["fldLeakMax"]);
                                            pLeakSpringBackMin_Plated = Convert.ToDouble(pDR["fldLeakSpringBackMin"]);
                                            pLoadSpringBackMin_Plated = Convert.ToDouble(pDR["fldLoadSpringBackMin"]);
                                        }
                                        else
                                        {
                                            pSealFHIniMin_Unplated = Convert.ToDouble(pDR["fldSealFHIniMin"]);
                                            pSealFHIniMax_Unplated = Convert.ToDouble(pDR["fldSealFHIniMax"]);
                                            pSealODPreMin_Unplated = Convert.ToDouble(pDR["fldSealODPreMin"]);
                                            pSealODPreMax_Unplated = Convert.ToDouble(pDR["fldSealODPreMax"]);
                                            pSealIDPreMin_Unplated = Convert.ToDouble(pDR["fldSealIDPreMin"]);
                                            pSealIDPreMax_Unplated = Convert.ToDouble(pDR["fldSealIDPreMax"]);
                                            pLeakMax_Unplated = Convert.ToDouble(pDR["fldLeakMax"]);
                                            pLeakSpringBackMin_Unplated = Convert.ToDouble(pDR["fldLeakSpringBackMin"]);
                                            pLoadSpringBackMin_Unplated = Convert.ToDouble(pDR["fldLoadSpringBackMin"]);
                                        }
                                    }
                                }

                                pstrValues = " Values (" + pTestProjectID + "," + pDR["fldSealQty"] + "," + Convert.ToInt16(pDR["fldIsLeak"]) +
                                            "," + Convert.ToInt16(pDR["fldIsLoad"]) + "," + Convert.ToInt16(pDR["fldIsPressure"]) +
                                            "," + pSealFHIniMin_Unplated + "," + pSealFHIniMax_Unplated +
                                            "," + pSealODPreMin_Unplated + "," + pSealODPreMax_Unplated + "," + pSealIDPreMin_Unplated +
                                            "," + pSealIDPreMax_Unplated + "," + pSealFHIniMin_Plated + "," + pSealFHIniMax_Plated +
                                            "," + pSealODPreMin_Plated + "," + pSealODPreMax_Plated + "," + pSealIDPreMin_Plated +
                                            "," + pSealIDPreMax_Plated + "," + pLeakCavityDepth + ",'" + pLeakProcedure_FileName +
                                            "','" + pLeakMedium + "'," + pLeakPress + "," + pIsLeak_Leakege + "," + pLeakMax_Unplated +
                                            "," + pLeakMax_Plated + "," + pIsLeakSpringBack + "," + pLeakSpringBackMin_Unplated +
                                            "," + pLeakSpringBackMin_Plated + ",'" + pLoadProcedure_FileName + "','" + pLoadType +
                                            "'," + pLoadMin_CavityDepth + "," + pLoadRange_CavityDepth + "," + pLoadMax_CavityDepth +
                                            "," + pLoadMin + "," + pLoadMax + "," + pIsLoadSpringBack + "," + pLoadSpringBackMin_Unplated +
                                            "," + pLoadSpringBackMin_Plated + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }

                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblSpec:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblSpec:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblSpec:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblMO:"
           
                    //....tblMO
                    pstrSQL = "Select * FROM tblMO";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblMO (fldTestProjectID, fldID, fldNo)";
                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldID"] + "," + pDR["fldNo"] + ")";
                                pstrActionSQL = pstrINSERT + pstrValues;

                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblMO:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblMO:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblMO:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblUnit:"
           
                    //....tblUnit
                    pstrSQL = "Select * FROM tblUnit";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblUnit (fldTestProjectID, fldLUnitPH, fldFUnitPH, fldPUnitPH, fldLeakUnitPH, fldLUnitCust, fldFUnitCust, " +
                                                                  "fldPUnitCust, fldLeakUnitCust)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + ",'" + pDR["fldLUnitPH"] + "','" + pDR["fldFUnitPH"] + "','" + pDR["fldPUnitPH"] + "','" +
                                               pDR["fldLeakUnitPH"] + "','" + pDR["fldLUnitCust"] + "','" + pDR["fldFUnitCust"] + "','" + pDR["fldPUnitCust"] + "','" + pDR["fldLeakUnitCust"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblUnit:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblUnit:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblUnit:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblTestCavity:"
           
                    //....tblTestCavity
                    pstrSQL = "Select * FROM tblTestCavity";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblTestCavity (fldTestProjectID, fldDate, fldCavityID, fldCavityDepth, fldCavityDepthTol1, fldCavityDepthTol2)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + ",'" + pDR["fldDate"] + "'," + pDR["fldCavityID"] + "," + pDR["fldCavityDepth"] + "," +
                                               pDR["fldCavityDepthTol1"] + "," + pDR["fldCavityDepthTol2"] + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }

                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblUnit:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblTestCavity:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblTestCavity:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblTestOpCond:"
            
                    //....tblTestOpCond
                    pstrSQL = "Select * FROM tblTestOpCond";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblTestOpCond (fldTestProjectID, fldDate, fldOpCondID, fldUnitUserP, fldPDiff, fldTOper)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + ",'" + pDR["fldDate"] + "'," + pDR["fldOpCondID"] + ",'" + pDR["fldUnitUserP"] + "'," +
                                               pDR["fldPDiff"] + ",'" + pDR["fldTOper"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblTestOpCond:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblTestOpCond:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblTestOpCond:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblReport:"
          
                    //....tblReport
                    pstrSQL = "Select * FROM tblReport";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;
                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                object pIsLeak_Leakage_Rpt = "NULL";
                                object pLeak_Press_Rpt = "NULL";
                                object pNotes = "NULL";
                                int pIsLeak_Leakage_Plated = 0;

                                pstrINSERT = "INSERT INTO tblReport (fldTestProjectID, fldTestMOID, fldID, fldNo, fldDateOpen, fldSealQty, fldIsLeak, fldIsLeak_Leakage, fldIsLeak_LeakagePlated, " +
                                                                    "fldIsLeak_Springback, fldIsLoad, fldIsLoad_Springback, fldIsPressure, fldLeakPress, fldNotes, fldOverridden, " +
                                                                    "fldUserTester, fldTesterSigned, fldDateTester, fldUserEngg, fldEnggSigned, fldDateEngg, fldUserQuality, " +
                                                                    "fldQualitySigned, fldDateQuality)";

                                String pstrSQL_Spec = "Select * FROM tblSpec WHERE fldTestProjectID = " + Convert.ToInt16(pDR["fldTestProjectID"]);
                                SqlConnection pCon_Spec = new SqlConnection();
                                SqlDataReader pDR_Spec = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL_Spec, ref pCon_Spec);

                                if (pDR["fldLeakPress"] != DBNull.Value)
                                {
                                    pLeak_Press_Rpt = Convert.ToDouble(pDR["fldLeakPress"]);
                                }

                                if (pDR["fldNotes"] != DBNull.Value)
                                {
                                    pNotes = Convert.ToString(pDR["fldNotes"]);
                                }


                                if (pDR_Spec.Read())
                                {
                                    if (pDR_Spec["fldLeakMax"] != DBNull.Value)
                                    {
                                        double pVal = Convert.ToDouble(pDR_Spec["fldLeakMax"]);

                                        if (Math.Abs(pVal) > 0)
                                        {
                                            pIsLeak_Leakage_Rpt = 1;
                                        }
                                        else
                                        {
                                            pIsLeak_Leakage_Rpt = 0;
                                        }
                                    }
                                }


                                if (pPlatingExists)
                                {
                                    pIsLeak_Leakage_Plated = 1;
                                }

                                object pIsLeakSpringBack_Leak = "NULL";
                                object pIsLeakSpringBack_Load = "NULL";

                                //....tblLeak
                                String pstrSQL_Leak = "Select * FROM tblLeak WHERE fldTestProjectID = " + Convert.ToInt16(pDR["fldTestProjectID"]) +
                                                      " AND fldTestMOID = " + Convert.ToInt16(pDR["fldTestMOID"]) +
                                                      " AND fldTestRptID = " + Convert.ToInt16(pDR["fldID"]) + " ORDER BY fldTestProjectID ASC";

                                SqlConnection pConn_Leak = new SqlConnection();
                                SqlDataReader pDR_Leak = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL_Leak, ref pConn_Leak);

                                if (pDR_Leak.Read())
                                {
                                    if (pDR_Leak["fldIsSpringBack"] != DBNull.Value)
                                    {
                                        pIsLeakSpringBack_Leak = Convert.ToInt16(pDR_Leak["fldIsSpringBack"]);
                                    }
                                }

                                //....tblLoad
                                String pstrSQL_Load = "Select * FROM tblLoad WHERE fldTestProjectID = " + Convert.ToInt16(pDR["fldTestProjectID"]) +
                                      " AND fldTestMOID = " + Convert.ToInt16(pDR["fldTestMOID"]) +
                                      " AND fldTestRptID = " + Convert.ToInt16(pDR["fldID"]) + " ORDER BY fldTestProjectID ASC";

                                SqlConnection pConn_Load = new SqlConnection();
                                SqlDataReader pDR_Load = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL_Load, ref pConn_Load);


                                if (pDR_Load.Read())
                                {
                                    if (pDR_Load["fldIsSpringBack"] != DBNull.Value)
                                    {
                                        pIsLeakSpringBack_Load = Convert.ToInt16(pDR_Load["fldIsSpringBack"]);
                                    }
                                }

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldID"] + "," + pDR["fldNo"] + ",'" +
                                               pDR["fldDateOpen"] + "'," + pDR["fldSealQty"] + "," + Convert.ToInt16(pDR["fldIsLeak"]) + "," + pIsLeak_Leakage_Plated + "," + pIsLeak_Leakage_Plated + "," +
                                               pIsLeakSpringBack_Leak + "," + Convert.ToInt16(pDR["fldIsLoad"]) + "," + pIsLeakSpringBack_Load + "," + Convert.ToInt16(pDR["fldIsPressure"]) + "," +
                                               pLeak_Press_Rpt + ",'" + pDR["fldNotes"] + "'," + Convert.ToInt16(pDR["fldOverridden"]) + ",'" + pDR["fldUserTester"] + "'," + Convert.ToInt16(pDR["fldTesterSigned"]) + ",'" +
                                               pDR["fldDateTester"] + "','" + pDR["fldUserEngg"] + "'," + Convert.ToInt16(pDR["fldEnggSigned"]) + ",'" + pDR["fldDateEngg"] + "','" +
                                               pDR["fldUserQuality"] + "'," + Convert.ToInt16(pDR["fldQualitySigned"]) + ",'" + pDR["fldDateQuality"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }

                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblReport:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }

                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblReport:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblReport:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblLeak:"
            
                    //....tblLeak
                    pstrSQL = "Select * FROM tblLeak";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    Object pShimDesc = "NULL";
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                if (pDR["fldShimDescrip"] != DBNull.Value)
                                {
                                    pShimDesc = Convert.ToString(pDR["fldShimDescrip"]);
                                }

                                pstrINSERT = "INSERT INTO tblLeak (fldTestProjectID, fldTestMOID, fldTestRptID, fldStandName, fldT, fldFixture, fldShimActual, " +
                                                                  "fldShimDescrip, fldSF_Platen, fldTestMeterMake, fldTestMeterSN, fldIsSpringBack)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + ",'" + pDR["fldStandName"] + "'," +
                                               pDR["fldT"] + ",'" + pDR["fldFixture"] + "'," + pDR["fldShimActual"] + ",'" + pShimDesc + "'," + pDR["fldSF_Platen"] + ",'" +
                                               pDR["fldTestMeterMake"] + "','" + pDR["fldTestMeterSN"] + "'," + Convert.ToInt16(pDR["fldIsSpringBack"]) + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }

                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLeak:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLeak:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLeak:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblLeakData:"
            
                    //....tblLeakData
                    pstrSQL = "Select * FROM tblLeakData";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblLeakData (fldTestProjectID, fldTestMOID, fldTestRptID, fldSealSeqID, fldFHIni, fldFHFinal, fldODPre, " +
                                                                      "fldODPost, fldIDPre, fldIDPost, fldVal)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + "," + pDR["fldSealSeqID"] + "," +
                                               pDR["fldFHIni"] + "," + pDR["fldFHFinal"] + "," + pDR["fldODPre"] + "," + pDR["fldODPost"] + "," + pDR["fldIDPre"] + "," +
                                               pDR["fldIDPost"] + "," + pDR["fldVal"] + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLeakData:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLeakData:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLeakData:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblLoad:"
            
                    //....tblLoad
                    pstrSQL = "Select * FROM tblLoad";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblLoad (fldTestProjectID, fldTestMOID, fldTestRptID, fldStandName, fldStandSN, fldLoadCellMake, " +
                                                                   "fldLoadCellSN, fldIsSpringBack)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + ",'" + pDR["fldStandName"] + "','" +
                                               pDR["fldStandSN"] + "','" + pDR["fldLoadCellMake"] + "','" + pDR["fldLoadCellSN"] + "'," + Convert.ToInt16(pDR["fldIsSpringBack"]) + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLoad:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLoad:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLoad:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblLoadData:"
            
                    //....tblLoadData
                    pstrSQL = "Select * FROM tblLoadData";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblLoadData (fldTestProjectID, fldTestMOID, fldTestRptID, fldSealSeqID, fldFHIni, fldFHFinal, fldODPre, " +
                                                                      "fldODPost, fldIDPre, fldIDPost, fldVal)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + "," + pDR["fldSealSeqID"] + "," +
                                               pDR["fldFHIni"] + "," + pDR["fldFHFinal"] + "," + pDR["fldODPre"] + "," + pDR["fldODPost"] + "," + pDR["fldIDPre"] + "," +
                                               pDR["fldIDPost"] + "," + pDR["fldVal"] + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblLoadData:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblLoadData:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblLoadData:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblPress:"
           
                    //....tblPress
                    pstrSQL = "Select * FROM tblPress";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblPress (fldTestProjectID, fldTestMOID, fldTestRptID, fldStandName, fldMeasureDevice)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + ",'" + pDR["fldStandName"] + "','" +
                                               pDR["fldMeasureDevice"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblPress:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblPress:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblPress:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblPressureData:"
           
                    //....tblPressureData
                    pstrSQL = "Select * FROM tblPressureData";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblPressureData (fldTestProjectID, fldTestMOID, fldTestRptID, fldSealSeqID, fldPressureMin, fldPressureFail)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + "," + pDR["fldSealSeqID"] + "," +
                                               pDR["fldPressureMin"] + "," + pDR["fldPressureFail"] + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblPressureData:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                    
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblPressureData:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblPressureData:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblReportGenSeal:"
               
                    //....tblReportGenSeal
                    pstrSQL = "Select * FROM tblReportGenSeal";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblReportGenSeal (fldTestProjectID, fldTestMOID, fldTestRptID, fldSealSeqID, fldSealSN)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + "," + pDR["fldSealSeqID"] + ",'" +
                                                pDR["fldSealSN"] + "')";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch (Exception pEx)
                            {
                                pSW.WriteLine("".PadRight(5) + "tblReportGenSeal:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblReportGenSeal:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblReportGenSeal:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblReportGenImage:"
           
                    //....tblReportGenImage
                    pstrSQL = "Select * FROM tblReportGenImage";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {                    
                            Image pImg = null;
                            byte[] pArray = (byte[])(pDR["fldImage"]);
                            MemoryStream pMS = null;
                    
                            if (((pArray != null)))
                            {
                                pMS = new MemoryStream(pArray);
                                pImg = Image.FromStream(pMS);
                                //pictureBox1.Image = pImg;
                                //pictureBox1.Visible = true;
                            }

                            try
                            {
                                SqlConnection pConn = new SqlConnection();
                                pConn = modMain.gDB.GetConnection("SealTestDB2a");

                                string strACTIONQry = "";
                                strACTIONQry = "INSERT INTO tblReportGenImage(fldTestProjectID,fldTestMOID, fldTestRptID, fldImageID, fldImageFile, fldImageNameTag, fldImageCaption, fldImage, fldSelected) " +
                                               "values(@fldTestProjectID,@fldTestMOID, @fldTestRptID, @fldImageID, @fldImageFile, @fldImageNameTag, @fldImageCaption, @fldImage, @fldSelected)";
                                SqlCommand pCmd = new SqlCommand(strACTIONQry, pConn);
                                int pCountRecords = 0;
                                pCmd.Parameters.Add("@fldTestProjectID", System.Data.SqlDbType.Real, 18);
                                pCmd.Parameters.Add("@fldTestMOID", System.Data.SqlDbType.Real, 18);
                                pCmd.Parameters.Add("@fldTestRptID", System.Data.SqlDbType.Real, 18);
                                pCmd.Parameters.Add("@fldImageID", System.Data.SqlDbType.Real, 18);
                                pCmd.Parameters.Add("@fldImageFile", System.Data.SqlDbType.VarChar);
                                pCmd.Parameters.Add("@fldImageNameTag", System.Data.SqlDbType.VarChar);
                                pCmd.Parameters.Add("@fldImageCaption", System.Data.SqlDbType.VarChar);
                                pCmd.Parameters.Add("@fldImage", System.Data.SqlDbType.Image);
                                pCmd.Parameters.Add("@fldSelected", System.Data.SqlDbType.Bit);
                                pCmd.Parameters["@fldTestProjectID"].Value = Convert.ToInt16(pDR["fldTestProjectID"]);
                                pCmd.Parameters["@fldTestMOID"].Value = Convert.ToInt16(pDR["fldTestMOID"]);
                                pCmd.Parameters["@fldTestRptID"].Value = Convert.ToInt16(pDR["fldTestRptID"]);
                                pCmd.Parameters["@fldImageID"].Value = Convert.ToInt16(pDR["fldImageID"]);
                                pCmd.Parameters["@fldImageFile"].Value = Convert.ToString(pDR["fldImageFile"]);
                                pCmd.Parameters["@fldImageNameTag"].Value = Convert.ToString(pDR["fldImageNameTag"]);
                                pCmd.Parameters["@fldImageCaption"].Value = Convert.ToString(pDR["fldImageCaption"]);
                                pCmd.Parameters["@fldImage"].Value = pArray;
                                pCmd.Parameters["@fldSelected"].Value = Convert.ToInt16(pDR["fldSelected"]);
                                pCountRecords = pCmd.ExecuteNonQuery();
                                pConn.Close();

                            }
                            catch
                            {
                                pSW.WriteLine("".PadRight(5) + "tblReportGenImage:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblReportGenImage:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblReportGenImage:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion


                #region "tblReportResult:"
            
                    //....tblReportResult
                    pstrSQL = "Select * FROM tblReportResult";
                    pCon = new SqlConnection();
                    pDR = modMain.gDB.GetDataReader("SealTestDB2", pstrSQL, ref pCon);
                    pError = false;

                    if (pDR.HasRows)
                    {
                        while (pDR.Read())
                        {
                            try
                            {
                                pstrINSERT = "INSERT INTO tblReportResult (fldTestProjectID, fldTestMOID, fldTestRptID, fldDSealing, fldLeak_UnitLoad, fldLeak_FHFinal)";

                                pstrValues = " Values (" + pDR["fldTestProjectID"] + "," + pDR["fldTestMOID"] + "," + pDR["fldTestRptID"] + "," + pDR["fldDSealing"] + "," +
                                                   pDR["fldLeak_UnitLoad"] + "," + pDR["fldLeak_FHFinal"] + ")";

                                pstrActionSQL = pstrINSERT + pstrValues;
                                modMain.gDB.ExecuteCommand(pstrActionSQL, "SealTestDB2a");
                            }
                            catch
                            {
                                pSW.WriteLine("".PadRight(5) + "tblReportResult:".PadRight(18) + "No Records of have been copied successfully");
                                pError = true;
                                break;
                            }
                        }

                        if (!pError)
                        {
                            pSW.WriteLine("".PadRight(5) + "tblReportResult:".PadRight(18) + "All Records of have been copied successfully");
                            pSW.WriteLine();
                            pDR = null;
                        }
                    }
                    else
                    {
                        pSW.WriteLine("".PadRight(5) + "tblReportResult:".PadRight(18) + "No Record Exists");
                        pSW.WriteLine();
                    }

                #endregion

            #endregion

            pSW.Close();
            MessageBox.Show("Records have been copied succesfully", "Copy Data", MessageBoxButtons.OK);
            Cursor = Cursors.Default;                     

        }

      
        private byte[] ImgToByteArray(Image img)
            //==================================
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        ////private void button2_Click(object sender, EventArgs e)
        ////{
        ////    try
        ////    {
        ////        //....tblReportGenImage
        ////        String pstrSQL = "Select * FROM tblReportGenImage where fldTestProjectID = 1";

        ////        SqlConnection pCon = new SqlConnection();
        ////        SqlDataReader pDR = modMain.gDB.GetDataReader("SealTestDB2a", pstrSQL, ref pCon);

        ////        if (pDR.Read())
        ////        {
        ////            Image pImg1 = null;
        ////            int pID = Convert.ToInt16(pDR["fldTestProjectID"]);
        ////            //pictureBox1.Image = Base64ToImage(pDR[7].ToString());

        ////            if (pID == 1)
        ////            {
        ////               // byte[] pImgArray = new byte[0];
        ////               //pImgArray = (byte[])(pDR["fldImage"]);
        ////               // //MemoryStream pMS1 = null;
        ////               // //if (((pImgArray != null)))
        ////               // //{
        ////               // //    pMS1 = new MemoryStream(pImgArray);
        ////               // //    pImg1 = Image.FromStream(pMS1);
        ////               // //    pictureBox1.Image = pImg1;
        ////               // //}
        ////               //pictureBox1.Image = Base64ToImage(pDR["fldImage"].ToString());

        ////                Image pImg = null;
        ////                byte[] pArray = (byte[])(pDR["fldImage"]);
        ////                MemoryStream pMS = null;


        ////                if (((pArray != null)))
        ////                {
        ////                    pMS = new MemoryStream(pArray);
        ////                    pImg = Image.FromStream(pMS);
        ////                    pictureBox1.Image = pImg;
        ////                    pictureBox1.Visible = true;
        ////                }
        ////            }
        ////        }
        ////    }
        ////    catch
        ////    {
        ////    }
        ////}

    }
}
