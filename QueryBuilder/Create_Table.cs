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
    public partial class Create_Table : Form
    {
        SqlConnection cnn;
        public Create_Table(SqlConnection cnn)
        {
            InitializeComponent();
            this.cnn = cnn;

        } // function end

        private void refresh_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
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
                            comboBox1.Items.Add(reader[0].ToString());

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end
            comboBox2.Items.Add("bigint");
            comboBox2.Items.Add("bit");
            comboBox2.Items.Add("decimal");
            comboBox2.Items.Add("int");
            comboBox2.Items.Add("smallint");
            comboBox2.Items.Add("tinyint");
            comboBox2.Items.Add("money");
            comboBox2.Items.Add("smallmoney");
            comboBox2.Items.Add("numeric");
            // Approximate Numerics
            comboBox2.Items.Add("float");
            comboBox2.Items.Add("real");
            // Date & Time
            comboBox2.Items.Add("date");
            comboBox2.Items.Add("datetime");
            comboBox2.Items.Add("datetime2");
            comboBox2.Items.Add("smalldatetime");
            comboBox2.Items.Add("time");
            //Character Strings
            comboBox2.Items.Add("char");
            comboBox2.Items.Add("varchar");
            comboBox2.Items.Add("text");
            //Unicode Character Strings
            comboBox2.Items.Add("nchar");
            comboBox2.Items.Add("nvarchar");
            comboBox2.Items.Add("ntext");
            cnn.Close();
        } // function end

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        } // function end

        private void button1_Click(object sender, EventArgs e)
        {
            if (table_name.Text != "")
            {
                richTextBox1.Text = "IF EXISTS ( SELECT * FROM sys.tables WHERE name LIKE '" + table_name.Text + "') DROP TABLE " + table_name.Text + " CREATE TABLE " + table_name.Text + " ( ";
            }
            else
            {
                status.Text = "Enter table name ! ";
            }        
        } // function end

        private void button2_Click(object sender, EventArgs e)
        {
            if (attribute_name.Text != "")
            {
                if (comboBox2.SelectedItem.ToString() != "")
                {
                    /////////////////////////
                    if ((comboBox2.SelectedItem.Equals("varchar") || comboBox2.SelectedItem.Equals("char")))
                    {
                        if (value.Text != "")
                        {
                            richTextBox1.Text += attribute_name.Text + " " + comboBox2.SelectedItem + "(" + value.Text + ")";

                        }
                        else
                        {
                            status.Text = "Enter a value for characters";
                        }
                    }
                    else
                    {
                        richTextBox1.Text += attribute_name.Text + " " + comboBox2.SelectedItem;
                    }
                    if (!checkBox1.Checked)
                    {
                        richTextBox1.Text += ",";
                    }
                    else
                    {
                        richTextBox1.Text += ");";
                    }
                    //////////////////////////
                }
                else
                {
                    status.Text = "Enter attribute's value";
                }
            } // if end
            else
            {
                status.Text = "Enter attribute name ";
            } // else end
        } // function end

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createe_table_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection();
            if (!(ConnectionState.Open == sql.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + comboBox1.SelectedItem + "; Integrated Security=True";
                sql = new SqlConnection(connetionString);
                sql.Open();
            }
            else
            {
                sql.Close();
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog=" + comboBox1.SelectedItem + "; Integrated Security=True";
                sql = new SqlConnection(connetionString);
                sql.Open();

            }


            var command = sql.CreateCommand();
            command.CommandText = richTextBox1.Text;
            command.ExecuteNonQuery();


        } // function end

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    } // class end
} // namespace end
