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
    public partial class Query_4 : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Query_4()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } // function end

        private void Load_databases_Click(object sender, EventArgs e)
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

      } // function end

        private void district_tehsilll_Click(object sender, EventArgs e)
        {
            district_tehsil.Items.Clear();
            mouza_town.Items.Clear();
            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection(NewconnectionString);
            string sqlselectQuery = " SELECT * from District_Tehsil";



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

                        if ( sdr[1].ToString().Trim().Count() < 10)
                        {
                            district_tehsil.Items.Add(sdr[1].ToString());
                        }
                    } // while end
                } // using end
            } // using end
        } // function end

        private void district_tehsil_SelectedIndexChanged(object sender, EventArgs e)
        {
            mouza_town.Items.Clear();
            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection(NewconnectionString);
            string sqlselectQuery = " SELECT DISTINCT Mouza_Town_Name from Mouza_Town Left Join Fact_Table on Mouza_Town.Mouza_Town_ID = Fact_Table.Mouza_Town_ID where Fact_Table.District_Tehsil_ID = ( SELECT District_Tehsil_ID from District_Tehsil where District_Tehsil_Name = '" + district_tehsil.SelectedItem.ToString()+"' )   ";



            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = openCon;
            sqlCmd.CommandType = CommandType.Text;
            //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
            //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
            //SELECT * FROM " + treeView1.SelectedNode.Text + "
            //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
            sqlCmd.CommandText = sqlselectQuery;
            openCon.Open();
            int count = 0;
            using (openCon)
            {
                using (SqlDataReader sdr = sqlCmd.ExecuteReader())
                {

                    while (sdr.Read()) // Start Reading records 
                    {
                        bool containsInt = sdr[0].ToString().Any(char.IsDigit);
                        if ( ! containsInt)
                        {
                            mouza_town.Items.Add(sdr[0].ToString());
                        }
                    } // while 
                } // using end
            } // using end




        } // function end

        private void execute_query_Click(object sender, EventArgs e)
        {
            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection(NewconnectionString);
            string sqlselectQuery = " SELECT * from Pestiside_Used"
                        + " left Join Fact_Table on Pestiside_Used.Pestiside_Used_ID = Fact_Table.Pestiside_Used_ID  where  ( Fact_Table.Mouza_Town_ID = (Select Mouza_Town_ID from Mouza_Town where Mouza_Town_Name = '" + mouza_town.SelectedItem.ToString()+"' ))";



            Dictionary<string, int> pestiside_used = new Dictionary<string, int>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = openCon;
            sqlCmd.CommandType = CommandType.Text;
            //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
            //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
            //SELECT * FROM " + treeView1.SelectedNode.Text + "
            //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
            sqlCmd.CommandText = sqlselectQuery;
            openCon.Open();
            int count = 0;
            using (openCon)
            {
                using (SqlDataReader sdr = sqlCmd.ExecuteReader())
                {

                    while (sdr.Read()) // Start Reading records 
                    {

                        if ( pestiside_used.ContainsKey(sdr[0].ToString().Trim() + " " + sdr[1].ToString().Trim()) )
                        {
                            pestiside_used[sdr[0].ToString().Trim() + " " + sdr[1].ToString().Trim()] = pestiside_used[sdr[0].ToString().Trim() + " " + sdr[1].ToString().Trim()] + 1;
                        }
                        else
                        {
                            pestiside_used.Add(sdr[0].ToString().Trim() + " "+sdr[1].ToString().Trim(), 0);
                        }

                        //richTextBox1.Text += sdr[1].ToString() + "\n";

                    } // while 
                } // using end
            } // using end


            var top5 = pestiside_used.OrderByDescending(pair => pair.Value).Take(pestiside_used.Count());
            foreach (var val in top5)
            {
                richTextBox1.Text += val.Key + "\n" ;
            }




            } // function end
    } // class end
} // namespace end
