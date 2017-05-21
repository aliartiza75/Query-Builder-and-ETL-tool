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
    public partial class Insert_Data : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Insert_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextBox[] txt = new TextBox[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    txt[i] = new TextBox();
            //    txt[i].Text = i.ToString();

            //    if (i > 0)
            //    {
            //        txt[i].Left = txt[i - 1].Right;
            //    }

            //    this.Controls.Add(txt[i]);
            //}


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

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end


        } // function end

        private void load_tables_Click(object sender, EventArgs e)
        {
            tables.Items.Clear();
            queries.Items.Clear();    

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
            queries.Items.Add("Insert");
            queries.Items.Add("Update");
            queries.Items.Add("Delete");

        } // function end

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_query_Click(object sender, EventArgs e)
        {
            string ss;
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
            //////////////////////////////////////////////////////


            var command = sql.CreateCommand();
            if  ( queries.SelectedItem.Equals("Insert") )
            {
               
                //command.CommandText = "INSERT INTO Data ( ";
                //command.ExecuteNonQuery();
                ss = "INSERT INTO "+tables.SelectedItem+" ( ";


               
                string strSQL;
                strSQL = "select COLUMN_NAME from information_schema.COLUMNS where TABLE_NAME='" + tables.SelectedItem + "'";
                using (sql)
                {
                    using (SqlCommand myCommand = new SqlCommand(strSQL, sql))
                    {
                        using (SqlDataReader reader = myCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ss += reader[0].ToString()+",";
                            } // while end

                        } // inner most using end
                    } // inner using end
                } // outer using end


                //ss[(ss.Length - 1)] = "";
                ss = ss.Remove(ss.Length-1 );
                ss += ") Values ();";

                richTextBox1.Text += ss;
                








            } // if end
            else if  (queries.SelectedItem.Equals("Update") )
            {

            } // else end
            else if  (queries.SelectedItem.Equals("Delete") )
            {

            } // else end
            else if (queries.SelectedItem.Equals("Alter") )
            {

            } // else end

        } // function end

        private void Execute_Click(object sender, EventArgs e)
        {

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

            var command = sql.CreateCommand();
            command.CommandText =richTextBox1.Text;
            command.ExecuteNonQuery();

        } // function end
    } //class end
} // namespace end
