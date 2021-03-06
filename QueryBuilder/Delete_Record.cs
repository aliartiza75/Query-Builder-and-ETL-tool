﻿using System;
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
    public partial class Delete_Record : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Delete_Record()
        {
            InitializeComponent();
        }

        private void index_Changed(object sender, EventArgs e)
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

        } // function end

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        } // function end

        private void load_database_Click(object sender, EventArgs e)
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

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end

        }

        private void button1_Click(object sender, EventArgs e)
        {

           



        } // function end

        private void Load_Table_data(object sender, EventArgs e)
        {
            SqlConnection sqll = new SqlConnection();
            //
            // Render message box.
            //


            if (!(ConnectionState.Open == sqll.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + databases.SelectedItem + "; Integrated Security=True";
                sqll = new SqlConnection(connetionString);
                sqll.Open();
            }
            else
            {
                sqll.Close();
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog=" + databases.SelectedItem + "; Integrated Security=True";
                sqll = new SqlConnection(connetionString);
                sqll.Open();

            }



            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqll;
            sqlCmd.CommandType = CommandType.Text;
            //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
            //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
            //SELECT * FROM " + treeView1.SelectedNode.Text + "
            //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
            sqlCmd.CommandText = "SELECT * FROM " + tables.SelectedItem + "";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;


        } // function end

        private void button2_Click(object sender, EventArgs e)
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
            command.CommandText = "DELETE FROM "+ tables.SelectedItem +" where "+id.Text+" ='"+value.Text+"'";
            command.ExecuteNonQuery();


        } // function end
    } // class end
} // namespace end
