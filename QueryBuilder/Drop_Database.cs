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
    public partial class Drop_Database : Form
    {
        SqlConnection cnn;
        bool connection_status;
        public Drop_Database(SqlConnection cnn)
        {
            InitializeComponent();
            this.cnn = cnn;
            this.cnn = cnn;
            cnn.Open();
            connection_status = true;
            status.Text = "Connection opened";

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (connection_status)
            {
                cnn.Close();

            }
            this.Hide();
        } // function end

        private void clear_Click(object sender, EventArgs e)
        {
            dropp_database.Text = "";
        } // function end

        private void database_ddrop_Click(object sender, EventArgs e)
        {
            if (!connection_status)
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }
            if ( dropp_database.Text != null)
            {
                var command = cnn.CreateCommand();
                command.CommandText = "DROP DATABASE " + dropp_database.Text.ToString();
                command.ExecuteNonQuery();
                status.Text = "Database Dropped";
                cnn.Close();
                connection_status = false;
                dropp_database.Text = "";
            } // if end
            else
            {
                status.Text = "Enter Database name!";
            } // else end
        } // function end

        private void refresh_Click(object sender, EventArgs e)
        {
            if (!connection_status)
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }
            databases_name.Items.Clear();
            string strSQL = "select name from sys.sysdatabases";
            using (cnn)
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, cnn))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            databases_name.Items.Add(reader[0].ToString());

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end

            cnn.Close();
            connection_status = false;
        } // function end

        private void databases_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ( databases_name.SelectedItem != null)
            {
                dropp_database.Text = databases_name.SelectedItem.ToString();
            } // if end
        } // function end
    } // class end
} // namespace end
