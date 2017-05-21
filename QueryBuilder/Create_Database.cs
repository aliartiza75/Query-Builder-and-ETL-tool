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
    public partial class Create_Database : Form
    {
        SqlConnection cnn;
        bool connection_status;
        public Create_Database( SqlConnection cnn)
        {
            InitializeComponent();
            this.cnn = cnn;
            cnn.Open();
            connection_status = true;
            status.Text = "Connection opened";
        } // function end



        private void create_db_Click(object sender, EventArgs e)
        {
            if (!(ConnectionState.Open == cnn.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }


            if  (get_db_txt_bx_1.Text != null)
            {
                var command = cnn.CreateCommand();
                command.CommandText = "CREATE DATABASE " + get_db_txt_bx_1.Text.ToString();
                command.ExecuteNonQuery();
                status.Text = "Database Created";
                cnn.Close();
                connection_status = false;
                get_db_txt_bx_1.Text = "";

            } // if end
            else
            {
                status.Text = "Enter Database name!";
            } // else end

        }// function end

        private void Clear_Click(object sender, EventArgs e)
        {
            get_db_txt_bx_1.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (connection_status)
            {
                cnn.Close();

            }
            this.Hide(); 
        }

        private void refresh_list_Click(object sender, EventArgs e)
        {
            if (!(ConnectionState.Open == cnn.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }
            database_names_combo.Items.Clear();
            string strSQL = "select name from sys.sysdatabases";
            using (cnn)
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, cnn))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            database_names_combo.Items.Add( reader[0].ToString());

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end

            cnn.Close();
            connection_status = false;
        } // function end

        private void database_names_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } // class end
} // namespace end
