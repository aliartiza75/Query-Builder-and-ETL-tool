using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class Transformation : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Transformation()
        {
            InitializeComponent();
        } // Constructor end

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tables.Items.Clear();

            SqlConnection sql = new SqlConnection();
            if (!(ConnectionState.Open == sql.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + databases.SelectedItem + "; Integrated Security=True";
                sql = new SqlConnection(connetionString);
                sql.Open();
            }
            else
            {
                sql.Close();
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog=" + databases.SelectedItem + "; Integrated Security=True";
                sql = new SqlConnection(connetionString);
                sql.Open();

            }

            string strSQL = "select table_name from " + databases.SelectedItem + ".INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'";
            using (sql)
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, sql))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Items.Add(reader[0].ToString());
                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end
        } // fucntion end

        private void button1_Click(object sender, EventArgs e)
        {
            databases.Items.Clear();
            if (!(ConnectionState.Open == cnn.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }

            //database_names_combo.Items.Clear();
            string strSQL = "select name from sys.sysdatabases";
            using (cnn)
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, cnn))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            databases.Items.Add(reader[0].ToString());
                            target_database.Items.Add(reader[0].ToString());

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end
        } // function end

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } // function end



        private void start_transformation_Click(object sender, EventArgs e)
        {




            int commit_Size = 1000;
            int records_processed = 0;

            //// START DATABASE READING CODE /////
            string NewconnectionString =  "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + databases.SelectedItem.ToString() + "; Integrated Security=True";
            string sqlselectQuery = "select * from " + tables.SelectedItem.ToString() + "";
            SqlCommand sqlcmd = new SqlCommand();

            SqlConnection transformation_conn = new SqlConnection(NewconnectionString);
            sqlcmd.Connection = transformation_conn;
            sqlcmd.CommandTimeout = 0;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sqlselectQuery;
            transformation_conn.Open();
            using (transformation_conn)
            {
                using (SqlDataReader sdr = sqlcmd.ExecuteReader())
                {
                    //For getting the Table Headers

                    /////
                    // START Database Reading 
                    ////

                    //BUTS stands for (BULK UPLOAD TO SQL)
                    BulkUploadToSql_For_Transformation BUTS = new BulkUploadToSql_For_Transformation();
                    BUTS.tableName = tables.SelectedItem.ToString(); // Just the filename, it is not used here
                    BUTS.commitBatchSize = commit_Size;


                    char [] Space_delimiters = new char[] { ' ' };
                    char[] Slash_delimiters = new char[] { '/' };
                    string[] Values = null;   // getting Area Values
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();

                    while (sdr.Read()) // Start Reading records 
                    {

                        // Code FOR Getting AREA FIELDS
                        Values = sdr[5].ToString().Split(Space_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        bool [] checkss = new bool[2];
                        checkss[0] = false;
                        checkss[1] = false;
                        if (Values.Length < 2)
                        {
                            try
                            {
                                dictionary.Add("Area", (int.Parse(Values[0])).ToString());
                                dictionary.Add("Area_Unit", "");
                            }
                            catch (Exception ee)
                            {
                                try
                                {
                                    dictionary.Add("Area", "0");
                                    dictionary.Add("Area_Unit", Values[0]);
                                }
                                catch (Exception eee)
                                {
                                    dictionary.Add("Area", "0");
                                    dictionary.Add("Area_Unit", Values[0]);
                                }

                            }


                        } // if end
                        else if (Values.Length == 2)
                        {
                            try
                            {
                                dictionary.Add("Area", int.Parse(Values[0]).ToString());
                                dictionary.Add("Area_Unit", Values[1]);
                            }
                            catch (Exception ee)
                            {
                                try
                                {
                                    dictionary.Add("Area", int.Parse(Values[1]).ToString());
                                    dictionary.Add("Area_Unit", Values[0]);
                                }
                                catch(Exception eee)
                                {
                                    dictionary.Add("Area", "00");
                                    dictionary.Add("Area_Unit", "Acres");
                                }

                            }

                        }
                        else
                        {
                            dictionary.Add("Area", "00");
                            dictionary.Add("Area_Unit", "Acres");
                        }
                        Values = null;
                        // Code FOR Getting AREA FIELDS


                        // START CODE FOR GETTING VARIETY OF CROPS FIELDS
                        Values = sdr[6].ToString().Split(Space_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 2)
                        {
                            try
                            {
                                dictionary.Add("Variety_of_Crop_Number", (int.Parse(Values[0])).ToString());
                                dictionary.Add("Variety_of_Crop", "");
                            }
                            catch (Exception eee)
                            {
                                dictionary.Add("Variety_of_Crop_Number", "0");
                                dictionary.Add("Variety_of_Crop", Values[0]);
                            }


                        } // if end
                        else if (Values.Length == 2)
                        {
                            try
                            {

                                int val = int.Parse(Values[0]);

                                dictionary.Add("Variety_of_Crop", Values[1]);
                                dictionary.Add("Variety_of_Crop_Number", val.ToString());
                            }
                            catch (Exception ee)
                            {
                                try {
                                    dictionary.Add("Variety_of_Crop", Values[0]);
                                    dictionary.Add("Variety_of_Crop_Number", (int.Parse(Values[1])).ToString());
                                }
                                catch (Exception eee)
                                {
                                    dictionary.Add("Variety_of_Crop_Number", "00");
                                }


                            } // cathc end

                        } // elseif ned
                        else // if values greater the 2
                        {
                            dictionary.Add("Variety_of_Crop", "");
                            dictionary.Add("Variety_of_Crop_Number", "00");
                        }
                        Values = null;
                        // END CODE FOR GETTING VARIETY OF CROPS FIELDS















                        // START CODE TO GET DATE VALUES
                        Boolean[] checks = new Boolean[3];
                        Values = sdr[7].ToString().Split(Slash_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 3)
                        {
                           /* try // This try is check if any value is not int
                            {
                                if (Values.Length == 1)
                                {
                                    int val = int.Parse(Values[0]);
                                    if (val < 12 && val > 0)
                                    {
                                        dictionary.Add("Sowing_Date_Date", "00");
                                        dictionary.Add("Sowing_Date_Month", val.ToString());
                                        dictionary.Add("Sowing_Date_Year", "0000");
                                    } // month condition
                                    else if (val > 12 && val <= 30)
                                    {
                                        dictionary.Add("Sowing_Date_Date", val.ToString());
                                        dictionary.Add("Sowing_Date_Month", "00");
                                        dictionary.Add("Sowing_Date_Year", "0000");
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Sowing_Date_Date", "00");
                                        dictionary.Add("Sowing_Date_Month", "00");
                                        dictionary.Add("Sowing_Date_Year", val.ToString());
                                    }


                                } // If Length == 1 end
                                else if (Values.Length == 2)
                                {

                                    int val = int.Parse(Values[0]);
                                    int val2 = int.Parse(Values[1]);

                                    if (val < 12 && val > 0)
                                    {
                                        dictionary.Add("Sowing_Date_Month", val.ToString());
                                        checks[1] = true;
                                    } // month condition
                                    else if (val > 12 && val <= 30)
                                    {
                                        dictionary.Add("Sowing_Date_Date", val.ToString());
                                        checks[0] = true;
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Sowing_Date_Year", val.ToString());
                                        checks[2] = true;
                                    } // else end

                                    /////////////////////////////////////////
                                    if (val2 < 12 && val2 > 0)
                                    {
                                        dictionary.Add("Sowing_Date_Month", val2.ToString());
                                        checks[1] = true;
                                    } // month condition
                                    else if (val2 > 12 && val2 <= 30)
                                    {
                                        dictionary.Add("Sowing_Date_Date", val2.ToString());
                                        checks[0] = true;
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Sowing_Date_Year", val2.ToString());
                                        checks[2] = true;
                                    }
                                    ///////////////////////////////////////////////////////

                                    if (checks[0] != true)
                                    {
                                        dictionary.Add("Sowing_Date_Date", "00");
                                    }
                                    if (checks[1] != true)
                                    {
                                        dictionary.Add("Sowing_Date_Month", "00");
                                    }
                                    if (checks[2] != true)
                                    {
                                        dictionary.Add("Sowing_Date_Year", "0000");
                                    }



                                } // If Length == 2 end

                            } // try end
                            catch (Exception ee)
                            {
                                if (Values.Length == 1)
                                {
                                    dictionary.Add("Sowing_Date_Date", "00");
                                    dictionary.Add("Sowing_Date_Month", "00");
                                    dictionary.Add("Sowing_Date_Year", "0000");
                                } // if Length == 1
                                else if (Values.Length == 2)
                                {
                                    if (checks[0] != true)
                                    {
                                        dictionary.Add("Sowing_Date_Date", "00");
                                    }
                                    if (checks[1] != true)
                                    {
                                        dictionary.Add("Sowing_Date_Month", "00");
                                    }
                                    if (checks[2] != true)
                                    {
                                        dictionary.Add("Sowing_Date_Year", "0000");
                                    }

                                } // if Length == 2



                            } // catch end

                            */
                            dictionary.Add("Sowing_Date_Date", "00");
                            dictionary.Add("Sowing_Date_Month", "00");
                            dictionary.Add("Sowing_Date_Year", "0000");
                        } // if Length < 3 end
                        else if (Values.Length == 3)
                        {
                            try // if any value is not int check
                            {
                                int val = int.Parse(Values[0]);
                                int val2 = int.Parse(Values[1]);
                                int val3 = int.Parse(Values[2]);


                                if (val < 12 && val > 0)
                                {
                                    dictionary.Add("Sowing_Date_Month", val.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val > 12 && val <= 30)
                                {
                                    dictionary.Add("Sowing_Date_Date", val.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Sowing_Date_Year", val.ToString());
                                    checks[2] = true;
                                }

                                /////////////////////////
                                if (val2 < 12 && val2 > 0)
                                {
                                    dictionary.Add("Sowing_Date_Month", val2.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val2 > 12 && val2 <= 30)
                                {
                                    dictionary.Add("Sowing_Date_Date", val2.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Sowing_Date_Year", val2.ToString());
                                    checks[2] = true;
                                }
                                /////// 

                                if (val3 < 12 && val3 > 0)
                                {
                                    dictionary.Add("Sowing_Date_Month", val3.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val3 > 12 && val3 <= 30)
                                {
                                    dictionary.Add("Sowing_Date_Date", val3.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Sowing_Date_Year", val3.ToString());
                                    checks[2] = true;
                                }




                            } // try end if  length > 3
                            catch (Exception ee)
                            {
                                if (checks[0] != true)
                                {
                                    dictionary.Add("Sowing_Date_Date", "00");
                                }
                                if (checks[1] != true)
                                {
                                    dictionary.Add("Sowing_Date_Month", "00");
                                }
                                if (checks[2] != true)
                                {
                                    dictionary.Add("Sowing_Date_Year", "0000");
                                }

                            } // catch end



                        } //else if end
                        else
                        {
                            dictionary.Add("Sowing_Date_Date", "00");
                            dictionary.Add("Sowing_Date_Month", "00");
                            dictionary.Add("Sowing_Date_Year", "0000");
                        } // else end
                        Values = null;

                        // END CODE TO GET DATA VALUES


                        // START CODE TO GET VISIT DATE VALUES
                        checks = new Boolean[3];
                        Values = sdr[8].ToString().Split(Slash_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 3)
                        {
                           /* try // This try is check if any value is not int
                            {
                                if (Values.Length == 1)
                                {
                                    int val = int.Parse(Values[0]);
                                    if (val < 12 && val > 0)
                                    {
                                        dictionary.Add("Visit_Date_Date", "00");
                                        dictionary.Add("Visit_Date_Month", val.ToString());
                                        dictionary.Add("Visit_Date_Year", "0000");
                                    } // month condition
                                    else if (val > 12 && val <= 30)
                                    {
                                        dictionary.Add("Visit_Date_Date", val.ToString());
                                        dictionary.Add("Visit_Date_Month", "00");
                                        dictionary.Add("Visit_Date_Year", "0000");
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Visit_Date_Date", "00");
                                        dictionary.Add("Visit_Date_Month", "00");
                                        dictionary.Add("Visit_Date_Year", val.ToString());
                                    }


                                } // If Length == 1 end
                                else if (Values.Length == 2)
                                {

                                    int val = int.Parse(Values[0]);
                                    int val2 = int.Parse(Values[0]);

                                    if (val < 12 && val > 0)
                                    {
                                        dictionary.Add("Visit_Date_Month", val.ToString());
                                        checks[1] = true;
                                    } // month condition
                                    else if (val > 12 && val <= 30)
                                    {
                                        dictionary.Add("Visit_Date_Date", val.ToString());
                                        checks[0] = true;
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Visit_Date_Year", val.ToString());
                                        checks[2] = true;
                                    } // else end

                                    /////////////////////////////////////////
                                    if (val2 < 12 && val2 > 0)
                                    {
                                        dictionary.Add("Visit_Date_Month", val2.ToString());
                                        checks[1] = true;
                                    } // month condition
                                    else if (val2 > 12 && val2 <= 30)
                                    {
                                        dictionary.Add("Visit_Date_Date", val2.ToString());
                                        checks[0] = true;
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Visit_Date_Year", val2.ToString());
                                        checks[2] = true;
                                    }
                                    ///////////////////////////////////////////////////////

                                    if (checks[0] != true)
                                    {
                                        dictionary.Add("Visit_Date_Date", "00");
                                    }
                                    if (checks[1] != true)
                                    {
                                        dictionary.Add("Visit_Date_Month", "00");
                                    }
                                    if (checks[2] != true)
                                    {
                                        dictionary.Add("Visit_Date_Year", "0000");
                                    }



                                } // If Length == 2 end

                            } // try end
                            catch (Exception ee)
                            {
                                if (Values.Length == 1)
                                {
                                    dictionary.Add("Visit_Date_Date", "00");
                                    dictionary.Add("Visit_Date_Month", "00");
                                    dictionary.Add("Visit_Date_Year", "0000");
                                } // if Length == 1
                                else if (Values.Length == 2)
                                {
                                    if (checks[0] != true)
                                    {
                                        dictionary.Add("Visit_Date_Date", "00");
                                    }
                                    if (checks[1] != true)
                                    {
                                        dictionary.Add("Visit_Date_Month", "00");
                                    }
                                    if (checks[2] != true)
                                    {
                                        dictionary.Add("Visit_Date_Year", "0000");
                                    }

                                } // if Length == 2



                            } // catch end
                            */
                                dictionary.Add("Visit_Date_Date", "00");
                            dictionary.Add("Visit_Date_Month", "00");
                            dictionary.Add("Visit_Date_Year", "0000");

                        } // if Length < 3 end
                        else if (Values.Length == 3)
                        {
                            try // if any value is not int check
                            {
                                int val = int.Parse(Values[0]);
                                int val2 = int.Parse(Values[1]);
                                int val3 = int.Parse(Values[2]);


                                if (val < 12 && val > 0)
                                {
                                    dictionary.Add("Visit_Date_Month", val.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val > 12 && val <= 30)
                                {
                                    dictionary.Add("Visit_Date_Date", val.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Visit_Date_Year", val.ToString());
                                    checks[2] = true;
                                }

                                /////////////////////////
                                if (val2 < 12 && val2 > 0)
                                {
                                    dictionary.Add("Visit_Date_Month", val2.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val2 > 12 && val2 <= 30)
                                {
                                    dictionary.Add("Visit_Date_Date", val2.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Visit_Date_Year", val2.ToString());
                                    checks[2] = true;
                                }
                                /////// 

                                if (val3 < 12 && val3 > 0)
                                {
                                    dictionary.Add("Visit_Date_Month", val3.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val3 > 12 && val3 <= 30)
                                {
                                    dictionary.Add("Visit_Date_Date", val3.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Visit_Date_Year", val3.ToString());
                                    checks[2] = true;
                                }




                            } // try end if  length > 3
                            catch (Exception ee)
                            {
                                if (checks[0] != true)
                                {
                                    dictionary.Add("Visit_Date_Date", "00");
                                }
                                if (checks[1] != true)
                                {
                                    dictionary.Add("Visit_Date_Month", "00");
                                }
                                if (checks[2] != true)
                                {
                                    dictionary.Add("Visit_Date_Year", "0000");
                                }

                            } // catch end


                        } //else if end
                        else
                        {
                            dictionary.Add("Visit_Date_Date", "00");
                            dictionary.Add("Visit_Date_Month", "00");
                            dictionary.Add("Visit_Date_Year", "0000");
                        } // else end
                        Values = null;

                        // END CODE TO GET VISIT DATA VALUES

















                        // START GETTING VALUES FOR PEST Population1
                        try
                        {
                            dictionary.Add("Pest_Population1", (Double.Parse(sdr[9].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population1", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population1
                        // START GETTING VALUES FOR PEST Population2
                        try
                        {
                            dictionary.Add("Pest_Population2", (Double.Parse(sdr[10].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population2", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population2
                        // START GETTING VALUES FOR PEST Population3
                        try
                        {
                            dictionary.Add("Pest_Population3", (Double.Parse(sdr[11].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population3", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population3
                        // START GETTING VALUES FOR PEST Population4
                        try
                        {
                            dictionary.Add("Pest_Population4", (Double.Parse(sdr[12].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population4", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population4
                        // START GETTING VALUES FOR PEST Population5
                        try
                        {
                            dictionary.Add("Pest_Population5", (Double.Parse(sdr[13].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population5", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population5
                        // START GETTING VALUES FOR PEST Population6
                        try
                        {
                            dictionary.Add("Pest_Population6", (Double.Parse(sdr[14].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population6", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population6
                        // START GETTING VALUES FOR PEST Population7
                        try
                        {
                            dictionary.Add("Pest_Population7", (Double.Parse(sdr[15].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population7", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population7
                        // START GETTING VALUES FOR PEST Population8
                        try
                        {
                            dictionary.Add("Pest_Population8", (Double.Parse(sdr[16].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population8", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population8
                        // START GETTING VALUES FOR PEST Population9
                        try
                        {
                            dictionary.Add("Pest_Population9", (Double.Parse(sdr[17].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population9", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population9
                        // START GETTING VALUES FOR PEST Population10
                        try
                        {
                            dictionary.Add("Pest_Population10", (Double.Parse(sdr[18].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population10", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population10
                        // START GETTING VALUES FOR PEST Population11
                        try
                        {
                            dictionary.Add("Pest_Population11", (Double.Parse(sdr[19].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population11", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population11
                        // START GETTING VALUES FOR PEST Population12
                        try
                        {
                            dictionary.Add("Pest_Population12", (Double.Parse(sdr[20].ToString())).ToString());

                        }
                        catch (Exception ee)
                        {
                            dictionary.Add("Pest_Population12", "00.00");
                        }
                        // START GETTING VALUES FOR PEST Population12







                        // START CODE TO GET Spray DATE VALUES
                        checks = new Boolean[3];
                        Values = sdr[22].ToString().Split(Slash_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 3)
                        {
                            /*try // This try is check if any value is not int
                            {
                                if (Values.Length == 1)
                                {
                                    int val = int.Parse(Values[0]);
                                    if (val < 12 && val > 0)
                                    {
                                        dictionary.Add("Spray_Date_Date", "00");
                                        dictionary.Add("Spray_Date_Month", val.ToString());
                                        dictionary.Add("Spray_Date_Year", "0000");
                                    } // month condition
                                    else if (val > 12 && val <= 30)
                                    {
                                        dictionary.Add("Spray_Date_Date", val.ToString());
                                        dictionary.Add("Spray_Date_Month", "00");
                                        dictionary.Add("Spray_Date_Year", "0000");
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Spray_Date_Date", "00");
                                        dictionary.Add("Spray_Date_Month", "00");
                                        dictionary.Add("Spray_Date_Year", val.ToString());
                                    }


                                } // If Length == 1 end
                                else if (Values.Length == 2)
                                {

                                    int val = int.Parse(Values[0]);
                                    int val2 = int.Parse(Values[0]);

                                    if (val < 12 && val > 0)
                                    {
                                        dictionary.Add("Spray_Date_Month", val.ToString());
                                        checks[1] = true;
                                    } // month condition
                                    else if (val > 12 && val <= 30)
                                    {
                                        dictionary.Add("Spray_Date_Date", val.ToString());
                                        checks[0] = true;
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Spray_Date_Year", val.ToString());
                                        checks[2] = true;
                                    } // else end

                                    /////////////////////////////////////////
                                    if (val2 < 12 && val2 > 0)
                                    {
                                        dictionary.Add("Spray_Date_Month", val2.ToString());
                                        checks[1] = true;
                                    } // month condition
                                    else if (val2 > 12 && val2 <= 30)
                                    {
                                        dictionary.Add("Spray_Date_Date", val2.ToString());
                                        checks[0] = true;
                                    } // Date
                                    else
                                    {
                                        dictionary.Add("Spray_Date_Year", val2.ToString());
                                        checks[2] = true;
                                    }
                                    ///////////////////////////////////////////////////////

                                    if (checks[0] != true)
                                    {
                                        dictionary.Add("Spray_Date_Date", "00");
                                    }
                                    if (checks[1] != true)
                                    {
                                        dictionary.Add("Spray_Date_Month", "00");
                                    }
                                    if (checks[2] != true)
                                    {
                                        dictionary.Add("Spray_Date_Year", "0000");
                                    }



                                } // If Length == 2 end

                            } // try end
                            catch (Exception ee)
                            {
                                if (Values.Length == 1)
                                {
                                    dictionary.Add("Spray_Date_Date", "00");
                                    dictionary.Add("Spray_Date_Month", "00");
                                    dictionary.Add("Spray_Date_Year", "0000");
                                } // if Length == 1
                                else if (Values.Length == 2)
                                {
                                    if (checks[0] != true)
                                    {
                                        dictionary.Add("Spray_Date_Date", "00");
                                    }
                                    if (checks[1] != true)
                                    {
                                        dictionary.Add("Spray_Date_Month", "00");
                                    }
                                    if (checks[2] != true)
                                    {
                                        dictionary.Add("Spray_Date_Year", "0000");
                                    }

                                } // if Length == 2



                            } // catch end

                            */
                            dictionary.Add("Spray_Date_Date", "00");
                            dictionary.Add("Spray_Date_Month", "00");
                            dictionary.Add("Spray_Date_Year", "0000");

                        } // if Length < 3 end
                        else if (Values.Length == 3)
                        {
                            try // if any value is not int check
                            {
                                int val = int.Parse(Values[0]);
                                int val2 = int.Parse(Values[1]);
                                int val3 = int.Parse(Values[2]);


                                if (val < 12 && val > 0)
                                {
                                    dictionary.Add("Spray_Date_Month", val.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val > 12 && val <= 30)
                                {
                                    dictionary.Add("Spray_Date_Date", val.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Spray_Date_Year", val.ToString());
                                    checks[2] = true;
                                }

                                /////////////////////////
                                if (val2 < 12 && val2 > 0)
                                {
                                    dictionary.Add("Spray_Date_Month", val2.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val2 > 12 && val2 <= 30)
                                {
                                    dictionary.Add("Spray_Date_Date", val2.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Spray_Date_Year", val2.ToString());
                                    checks[2] = true;
                                }
                                /////// 

                                if (val3 < 12 && val3 > 0)
                                {
                                    dictionary.Add("Spray_Date_Month", val3.ToString());
                                    checks[1] = true;
                                } // month condition
                                else if (val3 > 12 && val3 <= 30)
                                {
                                    dictionary.Add("Spray_Date_Date", val3.ToString());
                                    checks[0] = true;
                                } // Date
                                else
                                {
                                    dictionary.Add("Spray_Date_Year", val3.ToString());
                                    checks[2] = true;
                                }




                            } // try end if  length > 3
                            catch (Exception ee)
                            {
                                if (checks[0] != true)
                                {
                                    dictionary.Add("Spray_Date_Date", "00");
                                }
                                if (checks[1] != true)
                                {
                                    dictionary.Add("Spray_Date_Month", "00");
                                }
                                if (checks[2] != true)
                                {
                                    dictionary.Add("Spray_Date_Year", "0000");
                                }

                            } // catch end


                        } //else if end
                        else
                        {
                            dictionary.Add("Spray_Date_Date", "00");
                            dictionary.Add("Spray_Date_Month", "00");
                            dictionary.Add("Spray_Date_Year", "0000");
                        } // else end
                        Values = null;

                        // END CODE TO GET Spray DATA VALUES






                        // START CODE FOR GETTING DOSAGE FIELDS
                        Values = sdr[23].ToString().Split(Space_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 2)
                        {
                            /*try
                            {
                                dictionary.Add("Dosage", (int.Parse(Values[0])).ToString());
                                dictionary.Add("Dosage_Unit", "");
                            }
                            catch (Exception ee)
                            {
                                dictionary.Add("Dosage", "0");
                                dictionary.Add("Dosage_Unit", Values[0]);
                            }*/
                            dictionary.Add("Dosage_Unit", "");
                            dictionary.Add("Dosage", "00");


                        } // if end
                        else if (Values.Length == 2)
                        {
                            try
                            {

                                int val = int.Parse(Values[0]);

                                dictionary.Add("Dosage_Unit", Values[1]);
                                dictionary.Add("Dosage", val.ToString());
                            }
                            catch (Exception ee)
                            {
                                try
                                {
                                    dictionary.Add("Dosage_Unit", Values[0]);
                                    dictionary.Add("Dosage", (int.Parse(Values[1])).ToString());
                                }
                                catch (Exception eee)
                                {
                                    dictionary.Add("Dosage", "00");
                                }


                            } // cathc end

                        } // elseif ned
                        else // if values greater the 2
                        {
                            dictionary.Add("Dosage_Unit", "");
                            dictionary.Add("Dosage", "00");
                        }
                        Values = null;
                        // END CODE FOR GETTING DOSAGE FIELDS








                        // START CODE FOR GETTING CLCV DISEASE FIELDS
                        Values = sdr[24].ToString().Split(Space_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 2)
                        {
                            /* try
                             {
                                 dictionary.Add("CLCV_Disease", (int.Parse(Values[0])).ToString());
                                 dictionary.Add("CLCV_Disease_Level", "");
                             }
                             catch (Exception ee)
                             {
                                 try
                                 {
                                     dictionary.Add("CLCV_Disease", "0");
                                     dictionary.Add("CLCV_Disease_Level", Values[0]);

                                 }
                                 catch (Exception eee)
                                 {
                                     dictionary.Remove("CLCV_Disease");
                                     dictionary.Remove("CLCV_Disease_Level");
                                     dictionary.Add("CLCV_Disease", "0");
                                     dictionary.Add("CLCV_Disease_Level", "High");
                                 }
                             }*/
                            dictionary.Add("CLCV_Disease", "0");
                            dictionary.Add("CLCV_Disease_Level", "High");

                        } // if end
                        else if (Values.Length == 2)
                        {
                            try
                            {

                                int val = int.Parse(Values[0]);

                                dictionary.Add("CLCV_Disease_Level", Values[1]);
                                dictionary.Add("CLCV_Disease", val.ToString());
                            }
                            catch (Exception ee)
                            {
                                try
                                {
                                    dictionary.Add("CLCV_Disease_Level", Values[0]);
                                    dictionary.Add("CLCV_Disease", (int.Parse(Values[1])).ToString());
                                }
                                catch (Exception eee)
                                {
                                    dictionary.Add("CLCV_Disease", "00");
                                }


                            } // cathc end

                        } // elseif ned
                        else // if values greater the 2
                        {
                            dictionary.Add("CLCV_Disease_Level", "");
                            dictionary.Add("CLCV_Disease", "00");
                        }
                        Values = null;
                        // END CODE FOR GETTING CLCV DISEASE FIELDS






                        // START CODE FOR GETTING PLANT HEIGHT FIELDS
                        Values = sdr[25].ToString().Split(Space_delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (Values.Length < 2)
                        {
                            /*try
                            {
                                dictionary.Add("Plant_Height", (int.Parse(Values[0])).ToString());
                                dictionary.Add("Plant_Height_Unit", "");
                            }
                            catch (Exception ee)
                            {
                                try
                                {
                                    dictionary.Remove("Plant_Height");
                                    dictionary.Remove("Plant_Height_Unit");
                                    dictionary.Add("Plant_Height", "0");
                                    dictionary.Add("Plant_Height_Unit", Values[0]);
                                }
                                catch (Exception eee)
                                {
                                    dictionary.Remove("Plant_Height");
                                    dictionary.Remove("Plant_Height_Unit");
                                    dictionary.Add("Plant_Height", "0");
                                    dictionary.Add("Plant_Height_Unit", "meters");
                                }
                                
                            }*/

                            dictionary.Add("Plant_Height", "0");
                            dictionary.Add("Plant_Height_Unit", "meters");

                        } // if end
                        else if (Values.Length == 2)
                        {
                            try
                            {

                                int val = int.Parse(Values[0]);

                                dictionary.Add("Plant_Height_Unit", Values[1]);
                                dictionary.Add("Plant_Height", val.ToString());
                            }
                            catch (Exception ee)
                            {
                                try
                                {
                                    dictionary.Add("Plant_Height_Unit", Values[0]);
                                    dictionary.Add("Plant_Height", (int.Parse(Values[1])).ToString());
                                }
                                catch (Exception eee)
                                {
                                    dictionary.Add("Plant_Height", "00");
                                }


                            } // cathc end

                        } // elseif ned
                        else // if values greater the 2
                        {
                            dictionary.Add("Plant_Height_Unit", "");
                            dictionary.Add("Plant_Height", "00");
                        }
                        Values = null;
                        // END CODE FOR GETTING CLCV DISEASE FIELDS





                        try {
                            MyRecord_For_Transformation rec = new MyRecord_For_Transformation(
                                       sdr[0].ToString(), // District_Tehsil_name
                                       sdr[1].ToString(), // Town/ Mouza name
                                       sdr[2].ToString(), // Name
                                       sdr[3].ToString(), // Father Name
                                       sdr[4].ToString(), // Gender
                                       int.Parse(dictionary["Area"]),
                                       dictionary["Area_Unit"],
                                       dictionary["Variety_of_Crop"],
                                       int.Parse(dictionary["Variety_of_Crop_Number"]),
                                       int.Parse(dictionary["Sowing_Date_Date"]),
                                       int.Parse(dictionary["Sowing_Date_Month"]),
                                       int.Parse(dictionary["Sowing_Date_Year"]),
                                       int.Parse(dictionary["Visit_Date_Date"]),
                                       int.Parse(dictionary["Visit_Date_Month"]),
                                       int.Parse(dictionary["Visit_Date_Year"]),
                                       double.Parse(dictionary["Pest_Population1"]),
                                       double.Parse(dictionary["Pest_Population2"]),
                                       double.Parse(dictionary["Pest_Population3"]),
                                       double.Parse(dictionary["Pest_Population4"]),
                                       double.Parse(dictionary["Pest_Population5"]),
                                       double.Parse(dictionary["Pest_Population6"]),
                                       double.Parse(dictionary["Pest_Population7"]),
                                       double.Parse(dictionary["Pest_Population8"]),
                                       double.Parse(dictionary["Pest_Population9"]),
                                       double.Parse(dictionary["Pest_Population10"]),
                                       double.Parse(dictionary["Pest_Population11"]),
                                       double.Parse(dictionary["Pest_Population12"]),
                                       sdr[21].ToString(), // Pestiside used
                                       int.Parse(dictionary["Spray_Date_Date"]),
                                       int.Parse(dictionary["Spray_Date_Month"]),
                                       int.Parse(dictionary["Spray_Date_Year"]),
                                       int.Parse(dictionary["Dosage"]),
                                       dictionary["Dosage_Unit"],
                                       int.Parse(dictionary["CLCV_Disease"]),
                                       dictionary["CLCV_Disease_Level"],
                                       int.Parse(dictionary["Plant_Height"]),
                                       dictionary["Plant_Height_Unit"]
                                       );

                                        BUTS.internalStore.Add(rec); // storing object

                                        if (records_processed >= commit_Size)
                                        {
                                           BulkUploadToSql_For_Transformation myData = BUTS;
                                           myData.Flush(target_database.SelectedItem.ToString()); // this code send the database name
                                           BUTS.internalStore.Clear();
                                           richTextBox1.Text += "Done : " + records_processed.ToString() + "\n";
                                           records_processed = 0;

                                        } // commit_size condition end

                        } // try end
                        catch (Exception ee)
                        {
                            MyRecord_For_Transformation rec = new MyRecord_For_Transformation(
                                       "", // District_Tehsil_name
                                       "", // Town/ Mouza name
                                       "", // Name
                                       "", // Father Name
                                       "", // Gender
                                       00,
                                       "",
                                       "",
                                       00,
                                       00,
                                       00,
                                       00,
                                       00,
                                       00,
                                       00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       00.00,
                                       "", // Pestiside used
                                       00,
                                       00,
                                       00,
                                       00,
                                       "",
                                       00,
                                       "",
                                       00,
                                       ""
                                       );

                            BUTS.internalStore.Add(rec); // storing object

                            if (records_processed >= commit_Size)
                            {
                                BulkUploadToSql_For_Transformation myData = BUTS;
                                myData.Flush(target_database.SelectedItem.ToString()); // this code send the database name
                                BUTS.internalStore.Clear();
                                richTextBox1.Text += "Done : " + records_processed.ToString() + "\n";
                                records_processed = 0;

                            } // commit_size condition end
                            records_processed++;
                            dictionary.Clear();
                            continue;
                        } // cathc end



                        records_processed++;
                        richTextBox1.Text = "Done : " + records_processed.ToString() + "\n";
                        dictionary.Clear();
                    } // Reading records end while end

                    /////
                    // START Database Reading 
                    ////


                } // SqlDataReader using end
            } // transformation_conn using end

            transformation_conn.Close();


            //// START DATABASE READING CODE /////


        } //  function end



    } // class end
      ////////////////////////////////////////////////////////////////

    public class MyRecord_For_Transformation
    {

        public string   District_Tehsil_Name;
        public string   Mouza_town_Name;
        public string   Name;
        public string   Father_Name;
        public string   Gender;
        public int      Area;
        public string   Area_Unit;
        public string   Variety_of_Crop;
        public int      Variety_of_Crop_Number;
        public int      Sowing_Date_Date;
        public int      Sowing_Date_Month;
        public int      Sowing_Date_Year;
        public int      Visit_Date_Date;
        public int      Visit_Date_Month;
        public int      Visit_Date_Year;
        public double   Pest_Population1;
        public double   Pest_Population2;
        public double   Pest_Population3;
        public double   Pest_Population4;
        public double   Pest_Population5;
        public double   Pest_Population6;
        public double   Pest_Population7;
        public double   Pest_Population8;
        public double   Pest_Population9;
        public double   Pest_Population10;
        public double   Pest_Population11;
        public double   Pest_Population12;
        public string   Pesticide_Used;
        public int      Spray_Date_Date;
        public int      Spray_Date_Month;
        public int      Spray_Date_Year;
        public int      Dosage;
        public string   Dosage_Unit;
        public int      CLCV_Disease;
        public string   CLCV_Disease_Level;
        public int      Plant_Height;
        public string   Plant_Height_Unit;


        public MyRecord_For_Transformation()
        {

        }
        public MyRecord_For_Transformation(
        string District_Tehsil_Name,
        string Mouza_town_Name,
        string Name,
        string Father_Name,
        string Gender,
        int    Area,
        string Area_Unit,
        string Variety_of_Crop,
        int    Variety_of_Crop_Number,
        int    Sowing_Date_Date,
        int    Sowing_Date_Month,
        int    Sowing_Date_Year,
        int    Visit_Date_Date,
        int    Visit_Date_Month,
        int    Visit_Date_Year,
        double Pest_Population1,
        double Pest_Population2,
        double Pest_Population3,
        double Pest_Population4,
        double Pest_Population5,
        double Pest_Population6,
        double Pest_Population7,
        double Pest_Population8,
        double Pest_Population9,
        double Pest_Population10,
        double Pest_Population11,
        double Pest_Population12,
        string Pesticide_Used,
        int    Spray_Date_Date,
        int    Spray_Date_Month,
        int    Spray_Date_Year,
        int    Dosage,
        string Dosage_Unit,
        int    CLCV_Disease,
        string CLCV_Disease_Level,
        int    Plant_Height,
        string Plant_Height_Unit)
        {
            //B8:E8:56:31:52:46

            this.District_Tehsil_Name           = District_Tehsil_Name;
            this.Mouza_town_Name                = Mouza_town_Name;
            this.Name                           = Name;
            this.Father_Name                    = Father_Name;
            this.Gender                         = Gender;
            this.Area                           = Area;
            this.Variety_of_Crop                = Variety_of_Crop;
            this.Variety_of_Crop_Number         = Variety_of_Crop_Number;
            this.Sowing_Date_Date               = Sowing_Date_Date;
            this.Sowing_Date_Month              = Sowing_Date_Month;
            this.Sowing_Date_Year               = Sowing_Date_Year;
            this.Visit_Date_Date                = Visit_Date_Date;
            this.Visit_Date_Month               = Visit_Date_Month;
            this.Visit_Date_Year                = Visit_Date_Year;
            this.Pest_Population1               = Pest_Population1;
            this.Pest_Population2               = Pest_Population2;
            this.Pest_Population3               = Pest_Population3;
            this.Pest_Population4               = Pest_Population4;
            this.Pest_Population5               = Pest_Population5;
            this.Pest_Population6               = Pest_Population6;
            this.Pest_Population7               = Pest_Population7;
            this.Pest_Population8               = Pest_Population8;
            this.Pest_Population9               = Pest_Population9;
            this.Pest_Population10              = Pest_Population10;
            this.Pest_Population11              = Pest_Population11;
            this.Pest_Population12              = Pest_Population12;
            this.Pesticide_Used                 = Pesticide_Used;
            this.Spray_Date_Date                = Spray_Date_Date;
            this.Spray_Date_Month               = Spray_Date_Month;
            this.Spray_Date_Year                = Spray_Date_Year;
            this.Dosage                         = Dosage;
            this.Dosage_Unit                    = Dosage_Unit;
            this.CLCV_Disease                   = CLCV_Disease;
            this.CLCV_Disease_Level             = CLCV_Disease_Level;
            this.Plant_Height                   = Plant_Height;
            this.Plant_Height_Unit              = Plant_Height_Unit;


            //this.District_Tehsil = myString;

        } // function end

    } // class end

    class BulkData_For_Transformation
    {
        public BulkData_For_Transformation()
        {
        } // function end

    } // class end



    public class BulkUploadToSql_For_Transformation

    {

        public List<MyRecord_For_Transformation> internalStore;
        public string tableName;
        public DataTable dataTable = new DataTable();
        public int recordCount;
        public int commitBatchSize;
        public string folder_Name;







        /// <summary>
        /// This is just used for initialization of the class object
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="commitBatchSize"></param>

        public BulkUploadToSql_For_Transformation(string tableName, int commitBatchSize)
        {

            internalStore = new List<MyRecord_For_Transformation>();
            this.tableName = tableName;
            this.dataTable = new DataTable(tableName);
            this.recordCount = 0;
            this.commitBatchSize = commitBatchSize;
            this.folder_Name = "";


            // add columns to this data table
            InitializeStructures();

        } // function end



        /// <summary>
        /// Passing some random values
        /// </summary>
        public BulkUploadToSql_For_Transformation() : this("MyTableName", 1000)
        {

        } // function end
          //////////////////////////////////////////////



        /// <summary>
        /// Here we initialize the DataTabel structure
        /// </summary>
        public void InitializeStructures()
        {

            this.dataTable.Columns.Add("District_Tehsil_Name",          typeof(string));
            this.dataTable.Columns.Add("Mouza_town_Name",               typeof(string));
            this.dataTable.Columns.Add("Name",                          typeof(string));
            this.dataTable.Columns.Add("Father_Name",                   typeof(string));
            this.dataTable.Columns.Add("Gender",                        typeof(string));
            this.dataTable.Columns.Add("Area",                          typeof(int));
            this.dataTable.Columns.Add("Area_Unit",                     typeof(string));
            this.dataTable.Columns.Add("Variety_of_Crop",               typeof(string));
            this.dataTable.Columns.Add("Variety_of_Crop_Number",        typeof(int));
            this.dataTable.Columns.Add("Sowing_Date_Date",              typeof(int));
            this.dataTable.Columns.Add("Sowing_Date_Month",             typeof(int));
            this.dataTable.Columns.Add("Sowing_Date_Year",              typeof(int));
            this.dataTable.Columns.Add("Visit_Date_Date",               typeof(int));
            this.dataTable.Columns.Add("Visit_Date_Month",              typeof(int));
            this.dataTable.Columns.Add("Visit_Date_Year",               typeof(int));
            this.dataTable.Columns.Add("Pest_Population1",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population2",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population3",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population4",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population5",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population6",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population7",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population8",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population9",              typeof(double));
            this.dataTable.Columns.Add("Pest_Population10",             typeof(double));
            this.dataTable.Columns.Add("Pest_Population11",             typeof(double));
            this.dataTable.Columns.Add("Pest_Population12",             typeof(double));
            this.dataTable.Columns.Add("Pesticide_Used",                typeof(string));
            this.dataTable.Columns.Add("Spray_Date_Date",               typeof(int));
            this.dataTable.Columns.Add("Spray_Date_Month",              typeof(int));
            this.dataTable.Columns.Add("Spray_Date_Year",               typeof(int));
            this.dataTable.Columns.Add("Dosage",                        typeof(int));
            this.dataTable.Columns.Add("Dosage_Unit",                   typeof(string));
            this.dataTable.Columns.Add("CLCV_Disease",                  typeof(int));
            this.dataTable.Columns.Add("CLCV_Disease_Level",            typeof(string));
            this.dataTable.Columns.Add("Plant_Height",                  typeof(int));
            this.dataTable.Columns.Add("Plant_Height_Unit",             typeof(string));

            // here add the columns

        } // function end
        ///////////////////////////////////////////////////////







        /// <summary>
        /// In this function we pass the 
        /// Datatable to the writeServer() function to write it on database
        /// </summary>
        /// <param name="database_name"></param>

        private void WriteToDatabase(string database_name)
        {

            // get your connection string
            string connString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + database_name + "; Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            var commandStr = "If not exists (select name from sysobjects where name = '" + this.tableName + "') CREATE TABLE " + this.tableName + "("

                   + "District_Tehsil_Name          char(100),"
                   + "Mouza_town_Name               char(100),"
                   + "Name                          char(100),"
                   + "Father_Name                   char(100),"
                   + "Gender                        char(15),"
                   + "Area                          INT,"
                   + "Area_Unit                     char(10),"
                   + "Variety_of_Crop               char(100),"
                   + "Variety_of_Crop_Number        INT,"
                   + "Sowing_Date_Date              INT,"
                   + "Sowing_Date_Month             INT,"
                   + "Sowing_Date_Year              INT,"
                   + "Visit_Date_Date               INT,"
                   + "Visit_Date_Month              INT,"
                   + "Visit_Date_Year               INT,"
                   + "Pest_Population1              numeric(7,2) ,"
                   + "Pest_Population2              numeric(7,2)  ,"
                   + "Pest_Population3              numeric(7,2)  ,"
                   + "Pest_Population4              numeric(7,2)  ,"
                   + "Pest_Population5              numeric(7,2)  ,"
                   + "Pest_Population6              numeric(7,2)  ,"
                   + "Pest_Population7              numeric(7,2)  ,"
                   + "Pest_Population8              numeric(7,2)  ,"
                   + "Pest_Population9              numeric(7,2)  ,"
                   + "Pest_Population10             numeric(7,2)  ,"
                   + "Pest_Population11             numeric(7,2)  ,"
                   + "Pest_Population12             numeric(7,2)  ,"
                   + "Pesticide_Used                char(50),"
                   + "Spray_Date_Date               INT,"
                   + "Spray_Date_Month              INT,"
                   + "Spray_Date_Year               INT,"
                   + "Dosage                        INT,"
                   + "Dosage_Unit                   char(50),"
                   + "CLCV_Disease                  INT,"
                   + "CLCV_Disease_Level            char(50),"
                   + "Plant_Height                  INT,"
                   + "Plant_Height_Unit             char(50))";

            using (SqlCommand command = new SqlCommand(commandStr, con))
            {
                command.ExecuteNonQuery();
            }


            // connect to SQL
            using (SqlConnection connection = new SqlConnection(connString))
            {

                // make sure to enable triggers
                // more on triggers in next post
                SqlBulkCopy bulkCopy =
                    new SqlBulkCopy
                    (
                    connection,
                    SqlBulkCopyOptions.TableLock |
                    SqlBulkCopyOptions.FireTriggers |
                    SqlBulkCopyOptions.UseInternalTransaction,
                    null
                    );

                /////
                ///// write code to create table if 
                ///// present create a new table
                /////

                // set the destination table name
                bulkCopy.DestinationTableName = this.tableName;
                connection.Open();
                // write the data in the “dataTable”
                bulkCopy.WriteToServer(dataTable);
                connection.Close();
            } //using end

            // reset
            this.dataTable.Clear();
            this.recordCount = 0;
        } // function end
        ////////////////////////////////////////////////////////////



        /// <summary>
        /// In this function Data will read from the file
        /// added to the data table
        /// In the end an object will be returned having the data in it
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>



        public static BulkUploadToSql_For_Transformation Load(string file_Path, string file_Name, int Commit_Size, string folder_Name)
        {

            BulkUploadToSql_For_Transformation BUTS = new BulkUploadToSql_For_Transformation();

            return BUTS;

        } // function end
          ///////////////////////////////////////////////////

        public void Flush(string database_Name)
        {
            // transfer data to the datatable
            foreach (MyRecord_For_Transformation rec in this.internalStore)
            {
                this.PopulateDataTable(rec);
                if (this.recordCount >= this.commitBatchSize)
                    this.WriteToDatabase(database_Name);
            }
            // write remaining records to the DB
            if (this.recordCount > 0) this.WriteToDatabase(database_Name);
        } // function end


        private void PopulateDataTable(MyRecord_For_Transformation record)
        {

            DataRow row;
            // populate the values
            // using your custom logic
            row = this.dataTable.NewRow();
            row[0]      = record.District_Tehsil_Name;
            row[1]      = record.Mouza_town_Name;
            row[2]      = record.Name;
            row[3]      = record.Father_Name;
            row[4]      = record.Gender;
            row[5]      = record.Area;
            row[6]      = record.Area_Unit;
            row[7]      = record.Variety_of_Crop;
            row[8]      = record.Variety_of_Crop_Number;
            row[9]      = record.Sowing_Date_Date;
            row[10]     = record.Sowing_Date_Month;
            row[11]     = record.Sowing_Date_Year;
            row[12]     = record.Visit_Date_Date;
            row[13]     = record.Visit_Date_Month;
            row[14]     = record.Visit_Date_Year;
            row[15]     = record.Pest_Population1;
            row[16]     = record.Pest_Population2;
            row[17]     = record.Pest_Population3;
            row[18]     = record.Pest_Population4;
            row[19]     = record.Pest_Population5;
            row[20]     = record.Pest_Population6;
            row[21]     = record.Pest_Population7;
            row[22]     = record.Pest_Population8;
            row[23]     = record.Pest_Population9;
            row[24]     = record.Pest_Population10;
            row[25]     = record.Pest_Population11;
            row[26]     = record.Pest_Population12;
            row[27]     = record.Pesticide_Used;
            row[28]     = record.Spray_Date_Date;
            row[29]     = record.Spray_Date_Month;
            row[30]     = record.Spray_Date_Year;
            row[31]     = record.Dosage;
            row[32]     = record.Dosage_Unit;
            row[33]     = record.CLCV_Disease;
            row[34]     = record.CLCV_Disease_Level;
            row[35]     = record.Plant_Height;
            row[36]     = record.Plant_Height_Unit;
        

            // add it to the base for final addition to the DB
            this.dataTable.Rows.Add(row);
            this.recordCount++;

        } // function end
    } // class end



} // namespace end
