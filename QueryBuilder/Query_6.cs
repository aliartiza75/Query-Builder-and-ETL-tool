using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class Query_6 : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Query_6()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } // function end

        private void load_databases_Click(object sender, EventArgs e)
        {
            source_databases.Items.Clear();
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
                            source_databases.Items.Add(reader[0].ToString());
                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end
        } // function en

        private void execute_query_Click(object sender, EventArgs e)
        {
           
            Dictionary<string, double> old = new Dictionary<string, double>();
            Dictionary<string, double> new_val = new Dictionary<string, double>();


            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection(NewconnectionString);
            string sqlselectQuery = " SELECT Pestiside_Used.Pestiside_Used_Name, Fact_Table.Pestiside_Dosage, Fact_Table.Pestiside_Dosage_Unit from Pestiside_Used left Join Fact_Table on Pestiside_Used.Pestiside_Used_ID = Fact_Table.Pestiside_Used_ID     right Join    Visit_Dates on  Fact_Table.Date_ID_Visit  =   Visit_Dates.Date_ID    where Visit_Dates.Visit_Date_Year = '" + previous_year.SelectedItem.ToString().Trim()+"'";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = openCon;
            sqlCmd.CommandType = CommandType.Text;
            //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
            //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
            //SELECT * FROM " + treeView1.SelectedNode.Text + "
            //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
            sqlCmd.CommandText = sqlselectQuery;
            openCon.Open();

            previous_year.Items.Clear();
            new_year.Items.Clear();

            using (openCon)
            {
                using (SqlDataReader sdr = sqlCmd.ExecuteReader())
                {
                    while (sdr.Read()) // Start Reading records 
                    {

                        if ( old.ContainsKey(sdr[0].ToString().Trim()))
                        {
                            if ( sdr[2].ToString().Trim() == "kilograms" || sdr[2].ToString().Trim() == "liters" || sdr[2].ToString().Trim() == "l")
                            {
                                try
                                {
                                    old[sdr[0].ToString().Trim()] = old[sdr[0].ToString().Trim()] + (double.Parse(sdr[1].ToString().Trim()));
                                }
                                catch (Exception ee)
                                {
                                    old[sdr[0].ToString().Trim()] = old[sdr[0].ToString().Trim()] + (0.00);
                                }
                            }
                            else if (sdr[2].ToString().Trim() == "grams"  || sdr[2].ToString().Trim() == "ml" || sdr[2].ToString().Trim() == "m")
                            {
                                try
                                {
                                    old[sdr[0].ToString().Trim()] = old[sdr[0].ToString().Trim()] + (double.Parse(sdr[1].ToString().Trim()) / 1000);
                                }
                                catch (Exception ee)
                                {
                                    old[sdr[0].ToString().Trim()] = old[sdr[0].ToString().Trim()] + (0.00);
                                }
                            }
                            else
                            {
                                try
                                {
                                    old[sdr[0].ToString().Trim()] = old[sdr[0].ToString().Trim()] + (double.Parse(sdr[1].ToString().Trim()) / 1000);
                                }
                                catch (Exception ee )
                                {
                                    old[sdr[0].ToString().Trim()] = old[sdr[0].ToString().Trim()] + (0.00);
                                }

                            }
                        }
                        else
                        {

                            if (sdr[2].ToString().Trim() == "kilograms" || sdr[2].ToString().Trim() == "liters" || sdr[2].ToString().Trim() == "l")
                            {
                                try
                                {
                                    old.Add(sdr[0].ToString().Trim(), double.Parse(sdr[1].ToString().Trim()));

                                }
                                catch (Exception ee)
                                {
                                    old.Add(sdr[0].ToString().Trim(), 0.0);

                                }
                            }
                            else if (sdr[2].ToString().Trim() == "grams" || sdr[2].ToString().Trim() == "ml" || sdr[2].ToString().Trim() == "m")
                            {
                                try
                                {
                                    old.Add(sdr[0].ToString().Trim(), double.Parse(sdr[1].ToString().Trim()) / 1000);

                                }
                                catch (Exception ee)
                                {
                                    old.Add(sdr[0].ToString().Trim(), 0.0);

                                }
                            }
                            else
                            {
                                try
                                {
                                    old.Add(sdr[0].ToString().Trim(), double.Parse(sdr[1].ToString().Trim()) / 1000);

                                }
                                catch (Exception ee)
                                {
                                    old.Add(sdr[0].ToString().Trim(), 0.0);

                                }
                            }

                                
                        }
                                                    
                    } // while end
                } // using end
            } // using end






            openCon.Close();

            NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            openCon = new SqlConnection(NewconnectionString);
            sqlselectQuery = " SELECT Pestiside_Used.Pestiside_Used_Name, Fact_Table.Pestiside_Dosage, Fact_Table.Pestiside_Dosage_Unit from Pestiside_Used left Join Fact_Table on Pestiside_Used.Pestiside_Used_ID = Fact_Table.Pestiside_Used_ID     right Join    Visit_Dates on  Fact_Table.Date_ID_Visit  =   Visit_Dates.Date_ID    where Visit_Dates.Visit_Date_Year = '" + previous_year.SelectedItem.ToString().Trim() + "'";

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = openCon;
            sqlCmd.CommandType = CommandType.Text;
            //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
            //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
            //SELECT * FROM " + treeView1.SelectedNode.Text + "
            //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
            sqlCmd.CommandText = sqlselectQuery;
            openCon.Open();

            

            using (openCon)
            {
                using (SqlDataReader sdr = sqlCmd.ExecuteReader())
                {
                    while (sdr.Read()) // Start Reading records 
                    {

                        if (old.ContainsKey(sdr[0].ToString().Trim()))
                        {
                            if (sdr[2].ToString().Trim() == "kilograms" || sdr[2].ToString().Trim() == "liters" || sdr[2].ToString().Trim() == "l")
                            {
                                try
                                {
                                    new_val[sdr[0].ToString().Trim()] = new_val[sdr[0].ToString().Trim()] + (double.Parse(sdr[1].ToString().Trim()));
                                }
                                catch (Exception ee)
                                {
                                    new_val[sdr[0].ToString().Trim()] = new_val[sdr[0].ToString().Trim()] + (0.00);
                                }
                            }
                            else if (sdr[2].ToString().Trim() == "grams" || sdr[2].ToString().Trim() == "ml" || sdr[2].ToString().Trim() == "m")
                            {
                                try
                                {
                                    new_val[sdr[0].ToString().Trim()] = new_val[sdr[0].ToString().Trim()] + (double.Parse(sdr[1].ToString().Trim()) / 1000);
                                }
                                catch (Exception ee)
                                {
                                    new_val[sdr[0].ToString().Trim()] = new_val[sdr[0].ToString().Trim()] + (0.00);
                                }
                            }
                            else
                            {
                                try
                                {
                                    new_val[sdr[0].ToString().Trim()] = new_val[sdr[0].ToString().Trim()] + (double.Parse(sdr[1].ToString().Trim()) / 1000);
                                }
                                catch (Exception ee)
                                {
                                    new_val[sdr[0].ToString().Trim()] = new_val[sdr[0].ToString().Trim()] + (0.00);
                                }

                            }
                        }
                        else
                        {

                            if (sdr[2].ToString().Trim() == "kilograms" || sdr[2].ToString().Trim() == "liters" || sdr[2].ToString().Trim() == "l")
                            {
                                try
                                {
                                    new_val.Add(sdr[0].ToString().Trim(), double.Parse(sdr[1].ToString().Trim()));

                                }
                                catch (Exception ee)
                                {
                                    new_val.Add(sdr[0].ToString().Trim(), 0.0);

                                }
                            }
                            else if (sdr[2].ToString().Trim() == "grams" || sdr[2].ToString().Trim() == "ml" || sdr[2].ToString().Trim() == "m")
                            {
                                try
                                {
                                    new_val.Add(sdr[0].ToString().Trim(), double.Parse(sdr[1].ToString().Trim()) / 1000);

                                }
                                catch (Exception ee)
                                {
                                    new_val.Add(sdr[0].ToString().Trim(), 0.0);

                                }
                            }
                            else
                            {
                                try
                                {
                                    new_val.Add(sdr[0].ToString().Trim(), double.Parse(sdr[1].ToString().Trim()) / 1000);

                                }
                                catch (Exception ee)
                                {
                                    new_val.Add(sdr[0].ToString().Trim(), 0.0);

                                }
                            }


                        }

                        

                    } // while end
                } // using end
            } // using end





            foreach ( var a in old)
            {
                foreach ( var b in new_val)
                {
                    if ( a.Key == b.Key)
                    {
                        richTextBox1.Text += a.Key+"  "+ (a.Value + b.Value) / a.Value * 100;
                    }
                }
            }








        } // function end

        private void load_year_Click(object sender, EventArgs e)
        {
            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection(NewconnectionString);
            string sqlselectQuery = " SELECT Distinct Visit_Date_Year from Visit_Dates";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = openCon;
            sqlCmd.CommandType = CommandType.Text;
            //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
            //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
            //SELECT * FROM " + treeView1.SelectedNode.Text + "
            //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
            sqlCmd.CommandText = sqlselectQuery;
            openCon.Open();
            using (openCon)
            {
                using (SqlDataReader sdr = sqlCmd.ExecuteReader())
                {
                    while (sdr.Read()) // Start Reading records 
                    {
                        if (!(int.Parse(sdr[0].ToString().Trim()) <= 1000))
                        {
                            previous_year.Items.Add(sdr[0].ToString().Trim());
                            new_year.Items.Add(sdr[0].ToString().Trim());
                        }
                    } // while end
                } // using end
            } // using end
        } // function end
    } // class end
} // namespace end
