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
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        bool connection_status;
        public Form1( bool connection_status)
        {
            
            InitializeComponent();
            this.connection_status = connection_status;
            if (this.connection_status)
            {
                status.Text = "Connected";

            } // if end
            else
            {

                status.Text = "Disconnected";

            } // else end
        } // constructor end

        public Form1(SqlConnection cnn)
        {

            InitializeComponent();
            if (ConnectionState.Open == cnn.State)
            {
                status.Text = "Connected";

            } // if end
            else
            {

                status.Text = "Disconnected";

            } // else end
        }  // constructor end


        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
            try
            {

               
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                connection_status = true;
                status.Text = "Connection opened ! ";
                

                this.Hide();
                Menu obj = new Menu(connection_status , cnn);
                obj.Show();

                cnn.Close();

            }
            catch (Exception ex)
            {
                connection_status = false;
                status.Text = "Can not open connection ! " + ex.ToString();
            }

        } // function end

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Close();
                Environment.Exit(2);
            }
            catch(Exception ee) {
                status.Text = ee.ToString();
                Environment.Exit(2);
            }


        } //function end

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    } // class end
} // namespace end
