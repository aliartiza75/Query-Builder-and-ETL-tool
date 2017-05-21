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
    public partial class Query_2 : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Query_2()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }// function end

        private void Load_Databases_Click(object sender, EventArgs e)
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


            ///////////////////////////////////////////
           




        } // function end


        // Execute Query 
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Dictionary<int,double> pop_values = new Dictionary<int, double>();
            for ( int i = 0; i < 12; i++)
            {
                pop_values.Add(i,0.0);
            }

            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection(NewconnectionString);
            string sqlselectQuery = " SELECT Pest_Population_1, Pest_Population_2, Pest_Population_3, Pest_Population_4,  Pest_Population_5, Pest_Population_6, Pest_Population_7, Pest_Population_8, Pest_Population_9, Pest_Population_10, Pest_Population_11,  Pest_Population_12 "
                                    + " from Fact_Table where Pestiside_Used_ID = (Select Pestiside_Used_ID from Pestiside_Used where Pestiside_Used_Name = '"+pestisides_names.SelectedItem.ToString()+"')";


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
                        pop_values[0]   = pop_values[0] + double.Parse(sdr[0].ToString());
                        pop_values[1]   = pop_values[0] + double.Parse(sdr[1].ToString());
                        pop_values[2]   = pop_values[0] + double.Parse(sdr[2].ToString());
                        pop_values[3]   = pop_values[0] + double.Parse(sdr[3].ToString());
                        pop_values[4]   = pop_values[0] + double.Parse(sdr[4].ToString());
                        pop_values[5]   = pop_values[0] + double.Parse(sdr[5].ToString());
                        pop_values[6]   = pop_values[0] + double.Parse(sdr[6].ToString());
                        pop_values[7]   = pop_values[0] + double.Parse(sdr[7].ToString());
                        pop_values[8]   = pop_values[0] + double.Parse(sdr[8].ToString());
                        pop_values[9]   = pop_values[0] + double.Parse(sdr[9].ToString());
                        pop_values[10]  = pop_values[0] + double.Parse(sdr[10].ToString());
                        pop_values[11]  = pop_values[0] + double.Parse(sdr[11].ToString());
                    } // while end
                } // using end
            }// using end

            var bottom5 = pop_values.OrderBy(pair => pair.Value).Take(pop_values.Count());
            int ii = 1;
            foreach ( var s in bottom5)
            {
                if (ii == 12)
                {
                    richTextBox1.Text += "Pest Population # " + (s.Key + 1) + " : " + s.Value.ToString() + " (Predator)  \n";

                } // if end
                else
                {
                    richTextBox1.Text += "Pest Population # " + (s.Key + 1) + " : " + s.Value.ToString() + "\n";
                } // if end
                ii++;
            } // foreach end

        } // function end

        private void load_pestisides_names_Click(object sender, EventArgs e)
        {
            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openConn = new SqlConnection(NewconnectionString);

            string strSQL = "SELECT Distinct Pestiside_Used_Name from Pestiside_Used";
            openConn.Open();
            using (openConn)
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, openConn))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool containsInt = reader[0].ToString().Any(char.IsDigit);
                            if (!containsInt)
                            {
                                pestisides_names.Items.Add(reader[0].ToString());
                            }
                        } // while end
                    } // inner most using end
                } // inner using end
            } // outer using end

        } // function end
    } //class end
} // namespace end
