using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;



namespace QueryBuilder
{
public partial class Load_data : Form
{

    SqlConnection cnn = new SqlConnection();
    string Source_Directory_path;
    public Load_data()
    {
        InitializeComponent();
        Source_Directory_path = null;
    }

    private void load_databases_Click(object sender, EventArgs e)
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
            
        cnn.Close();

    } // function end
    /// <summary>
    /// To Load data in database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void load_files_Click(object sender, EventArgs e)
    {



        if (Source_Directory_path != null)
        {


            Stack<string> dirs = new Stack<string>(20);

            if (!System.IO.Directory.Exists(Source_Directory_path.ToString()))
            {
                // Edit this exception
                throw new ArgumentException();

            }
            dirs.Push(Source_Directory_path.ToString());

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable 
                // to ignore the exception and continue enumerating the remaining files and 
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception 
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The 
                // choice of which exceptions to catch depends entirely on the specific task 
                // you are intending to perform and also on how much you know with certainty 
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException ee)
                {
                    status.Text = (ee.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException ee)
                {
                    status.Text = (ee.Message);
                    continue;
                }

                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir);
                }

                catch (UnauthorizedAccessException ee)
                {

                    status.Text = (ee.Message);
                    continue;
                }

                catch (System.IO.DirectoryNotFoundException ee)
                {
                    status.Text = (ee.Message);
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.
                foreach (string file in files)
                {
                    try
                    {
                        //string[] lines = System.IO.File.ReadAllLines(file);
                        richTextBox1.Text += file + "   \n";


                        /////////// Code to Load Data Start /////////////////


                        /* using (Stream s =   new StreamReader(@"C:\TestData.txt")   )
                        // convert string to stream
                        // byte[] byteArray = Encoding.UTF8.GetBytes(fi);
                        // byte[] byteArray = Encoding.ASCII.GetBytes(contents);
                        // MemoryStream stream = new MemoryStream(byteArray);
                        // StreamReader d = new StreamReader(file.ToString());*/
                        //                      using (Stream s = d.BaseStream)
                        //                      {



                        // This code here Load a single file data and upload it to database
                        //BulkUploadToSql myData = new BulkUploadToSql(Path.GetFileNameWithoutExtension(file), 10000);

                        BulkUploadToSql myData = BulkUploadToSql.Load(file, Path.GetFileNameWithoutExtension(file), 10000, currentDir);
                        myData.Flush(comboBox1.SelectedItem.ToString()); // this code send the database name
                                                                            //} // using end

                        /////////// Code to Load Data Start /////////////////



                        // Perform whatever action is required in your scenario.
                        //System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        //Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime);

                    } // try end

                    catch (System.IO.FileNotFoundException ee)
                    {
                        // If file was deleted by a separate application
                        //  or thread since the call to TraverseTree()
                        // then just continue.
                        status.Text = (ee.Message);
                        continue;
                    } // catch end

                } // foreach end

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);
            } // while end


        } // Source_Directory_path condition end


            
        

} // function end

    private void select_data_source_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd2 = new FolderBrowserDialog();
        fbd2.Description = "Select datasource folder";
        DialogResult result2 = fbd2.ShowDialog();
        Source_Directory_path = fbd2.SelectedPath.ToString();
            
    }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /////////////////////////////////////
    } // class end



}
// namespace end
