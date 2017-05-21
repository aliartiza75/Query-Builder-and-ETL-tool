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
    public partial class Delete_Table : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Delete_Table()
        {
            InitializeComponent();
        }

        private void load_databases_Click(object sender, EventArgs e)
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
        } // function end

        private void load_tables_Click(object sender, EventArgs e)
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
                using (SqlCommand myCommand = new SqlCommand(strSQL,sql))
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

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void droop_table_Click(object sender, EventArgs e)
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
            command.CommandText = "DROP TABLE "+tables.SelectedItem+"";
            command.ExecuteNonQuery();

        } // function end


    } // class end
} // namespace end
