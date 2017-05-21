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
public partial class Menu : Form
{
SqlConnection cnn;
bool connection_status;

public Menu(bool connection_status , SqlConnection cnn)
{
            
    InitializeComponent();
    this.connection_status = connection_status;
    this.cnn = cnn;
    if (this.connection_status)
    {
        status.Text = "Connected";

    } // if end
    else
    {

        status.Text = "Disconnected";

    } // else end
} // func end

private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
{
    if ( ConnectionState.Open == cnn.State )
    {
        cnn.Close();
        connection_status = false;
        this.Hide();
        Form1 obj = new Form1(connection_status);
        obj.Show();
    }
    else
    {
        connection_status = false;
        this.Hide();
        Form1 obj = new Form1(connection_status);
        obj.Show();
    } // else end

} // function end

private void closeToolStripMenuItem_Click(object sender, EventArgs e)
{
    Environment.Exit(2) ;
} // function end

private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
{
    //this.Hide();
    cnn.Close();
    Create_Database obj = new Create_Database(cnn);
    obj.Show();

}

private void databaseToolStripMenuItem1_Click(object sender, EventArgs e)
{
    cnn.Close();
    Drop_Database obj = new Drop_Database(cnn);
    obj.Show();
}

private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
{
    try
    {
            status.Text = "";
        treeView1.ResetText();
        TreeNode node = treeView1.SelectedNode;
        SqlConnection sql = new SqlConnection();
        //
        // Render message box.
        //

        MessageBox.Show(string.Format("You selected: {0}", treeView1.SelectedNode.Parent.Text));

        if (!(ConnectionState.Open == sql.State))
        {
            string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + treeView1.SelectedNode.Parent.Text + "; Integrated Security=True";
            sql = new SqlConnection(connetionString);
            sql.Open();
        }
        {
            sql.Close();
            string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog=" + treeView1.SelectedNode.Parent.Text + "; Integrated Security=True";
            sql = new SqlConnection(connetionString);
            sql.Open();

        }



        SqlCommand sqlCmd = new SqlCommand();
        sqlCmd.Connection = sql;
        sqlCmd.CommandType = CommandType.Text;
        //SELECT * FROM sys.indexes WHERE[object_id] = OBJECT_ID('"+ treeView1.SelectedNode.Text +"')
        //select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='Course_Registration'
        //SELECT * FROM " + treeView1.SelectedNode.Text + "
        //sqlCmd.CommandText = "select COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE, IS_NULLABLE from information_schema.COLUMNS where TABLE_NAME='" + treeView1.SelectedNode.Text + "'";
        sqlCmd.CommandText = "SELECT TOP(50) * FROM " + treeView1.SelectedNode.Text + "";
        SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

        DataTable dtRecord = new DataTable();
        sqlDataAdap.Fill(dtRecord);
        dataGridView1.DataSource = dtRecord;

        cnn.Close();

        //DataTable dt = new DataTable();
        //SqlDataAdapter sda = new SqlDataAdapter("select * from information_schema.COLUMNS where TABLE_NAME='Course_Registration'", cnn);
        //sda.Fill(dt);
        //dataGridView1.DataSource = dt;
    }
        catch (Exception ee)
        {
            //status.Text = "Kindly select table not the Database";
        }

} // function end

private void connectToolStripMenuItem_Click(object sender, EventArgs e)
{
    treeView1.Nodes.Clear();
    if ( !(ConnectionState.Open == cnn.State))
    {
        string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
        cnn = new SqlConnection(connetionString);
        cnn.Open();
    }
            
    List<TreeNode> list = new List<TreeNode>();
    List<string> list2 = new List<string>(); 
    TreeNode [] ass = new TreeNode[10];
    TreeNode obj = new TreeNode();
                            
                    string strSQL = "select name from sys.sysdatabases";
                    using (cnn)
                    {
                        using (SqlCommand myCommand = new SqlCommand(strSQL, cnn))
                        {
                            using (SqlDataReader reader = myCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    list2.Add(reader[0].ToString());
                                                                  
                                    } // while end
                            } // inner most using end
                        } // inner using end
                    } // outer using end

    List<string> list3 = new List<string>();
    list3 = list2.Distinct().ToList();    


    for ( int i = 0; i < list3.Count(); i++ ) {
        if (!(ConnectionState.Open == cnn.State))
        {
            string connetionString = "Data Source=WNDOWS-SAVJEG8;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
        }

        strSQL = "select table_name from "+list3[i]+".INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'";
        using (cnn)
        {
            using (SqlCommand myCommand = new SqlCommand(strSQL, cnn))
            {
                using (SqlDataReader reader = myCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TreeNode(reader[0].ToString()));
                    } // while end

                } // inner most using end
            } // inner using end
        } // outer using end
        obj = new TreeNode(list3[i], list.ToArray());
        list.Clear();
        treeView1.Nodes.Add(obj);
    } // for end


} // function end

private void tableToolStripMenuItem_Click(object sender, EventArgs e)
{
    cnn.Close();
    Create_Table obj = new Create_Table(cnn);
    obj.Show();
} // function end

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
{
    cnn.Close();
    Delete_Table obj = new Delete_Table();
    obj.Show();
}

private void insertToolStripMenuItem_Click(object sender, EventArgs e)
{
    Insert_Data obj = new Insert_Data();
    obj.Show();
}

private void alterToolStripMenuItem_Click(object sender, EventArgs e)
{
    Update_Table obj = new Update_Table();
    obj.Show();
}

private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
{
    Delete_Record obj = new Delete_Record();
    obj.Show();
} // function end

private void loadToolStripMenuItem_Click(object sender, EventArgs e)
{
   
} // function end

    private void extractLoadToolStripMenuItem_Click(object sender, EventArgs e)
    {
            Load_data obj = new Load_data();
            obj.Show();

        } // function end

        private void transformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transformation obj = new Transformation();
            obj.Show();
        }

        private void loadDataInSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_data_in_schema obj = new Load_data_in_schema();
            obj.Show();
        } // function end

        private void whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query_1 obj = new Query_1();
            obj.Show();
        }// function end

        private void whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query_2 obj = new Query_2();
            obj.Show()
;        } // function end

        private void whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query_3 obj = new Query_3();
            obj.Show();
                 
        } // function end



        private void whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query_4 obj = new Query_4();
            obj.Show();
        } // function end

        private void whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query_5 obj = new Query_5();
            obj.Show();
        } // function end

        private void whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query_6 obj = new Query_6();
            obj.Show();
        }
    } // class end
} // namespace end
