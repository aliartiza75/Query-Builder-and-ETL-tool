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
    public partial class Query_1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Query_1()
        {
            InitializeComponent();
            threshold_value.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } // function end

        private void Load_databases_Click(object sender, EventArgs e)
        {
            source_databases.Items.Clear();
            pest_populations.Items.Clear();
            if (!(ConnectionState.Open == cnn.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }




            for ( int i = 1; i <= 12; i++)
            {
                pest_populations.Items.Add("Pest_Population_" + i);
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
        } // function end


        
        // Execute Query Button
        private void button1_Click(object sender, EventArgs e)
        {
            threshold_value.Text = "1";

            richTextBox1.Clear();

            if (threshold_value.Text != "")
            {


                try
                {

                    string[] array_pop = new string[12];
                    for ( int i = 0; i < array_pop.Count(); i++)
                    {
                        array_pop[i] = "Pest_population_" + (i+1);
                    }


                    Dictionary<int, double> value = new Dictionary<int,double>();

                    //// START DATABASE READING CODE /////
                    string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
                    SqlConnection openCon = new SqlConnection(NewconnectionString);
                    string sqlselectQuery = " SELECT Pestiside_Used_ID, "+array_pop[pest_populations.SelectedIndex].ToString()  +" from Fact_Table";


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
                                //richTextBox1.Text += sdr[0].ToString() + sdr[1].ToString() + "\n";
                                if ( value.ContainsKey  (       int.Parse(sdr[0].ToString())    ) )
                                {
                                    value[int.Parse(sdr[0].ToString())] = value[int.Parse(sdr[0].ToString())] + double.Parse(sdr[1].ToString());
                                } // if end
                                else
                                {
                                    value.Add(int.Parse(sdr[0].ToString()), double.Parse(sdr[1].ToString())  );
                                }

                            } // while end
                        } // inner using end
                    } // outer using end

                    //top 5
                    var top5 = value.OrderByDescending(pair => pair.Value).Take(5);
                    // bottom 5
                    var bottom5 = value.OrderBy(pair => pair.Value).Take(value.Count());

                    openCon.Close();



                    foreach (var val in bottom5)
                    {
                        string NewconnectionStringg = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
                        SqlConnection openConn = new SqlConnection(NewconnectionString);
                        sqlselectQuery = " Select Pestiside_Used_ID, Pestiside_Used_Name from Pestiside_Used where (Pestiside_Used_ID = '"+val.Key+"') ";
                        SqlCommand sqlCmdd = new SqlCommand();
                        sqlCmdd.Connection = openConn;
                        sqlCmdd.CommandType = CommandType.Text;
                        sqlCmdd.CommandText = sqlselectQuery;
                        openConn.Open();
                        using (openConn)
                        {
                            using (SqlDataReader sdrr = sqlCmdd.ExecuteReader())
                            {

                                while (sdrr.Read()) // Start Reading records 
                                {
                                    bool containsInt = sdrr[1].ToString().Any(char.IsDigit);
                                    if (! containsInt)
                                    {
                                        richTextBox1.Text += sdrr[0].ToString() + "   " + sdrr[1].ToString() + "\n";
                                    }

                                } // while end
                            } // inner using end
                        } // outer using end

                        openConn.Close();
                    } // foreach end
                    


                    //DataTable dt = new DataTable();
                    //SqlDataAdapter sda = new SqlDataAdapter("select * from information_schema.COLUMNS where TABLE_NAME='Course_Registration'", cnn);
                    //sda.Fill(dt);
                    //dataGridView1.DataSource = dt;
                }
                catch (Exception ee)
                {
                    //status_text.Text = ee.ToString() ;
                }


            }
            else
            {
                status_text.Text = "Kindly enter threshold value";
            }









        } // function end
    } // class end
} // namespace end
