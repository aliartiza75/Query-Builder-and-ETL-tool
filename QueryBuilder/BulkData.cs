using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.OleDb;
using System.Globalization;

namespace QueryBuilder
{
    public class MyRecord
    {

        public string   District_Tehsil_Name;
        public string   Mouza_town_Name;
        public string   Name;
        public string   Father_Name;
        public string   Gender;
        public string   Area;
        public string   Variety_of_Crop;
        public string   Sowing_Date;
        public string   Visit_Date;
        public string   Pest_Population1;
        public string   Pest_Population2;
        public string   Pest_Population3;
        public string   Pest_Population4;
        public string   Pest_Population5;
        public string   Pest_Population6;
        public string   Pest_Population7;
        public string   Pest_Population8;
        public string   Pest_Population9;
        public string   Pest_Population10;
        public string   Pest_Population11;
        public string   Pest_Population12;
        public string   Pesticide_Used;
        public string   Spray_Date;
        public string   Dosage;
        public string   CLCV_Disease;
        public string   Plant_Height;


        public MyRecord()
        {

        }
        public MyRecord(
        string      District_Tehsil_Name,
        string      Mouza_town_Name,
        string      Name,
        string      Father_Name,
        string      Gender,
        string      Area,
        string      Variety_of_Crop,
        string      Sowing_Date,
        string      Visit_Date,
        string      Pest_Population1,
        string      Pest_Population2,
        string      Pest_Population3,
        string      Pest_Population4,
        string      Pest_Population5,
        string      Pest_Population6,
        string      Pest_Population7,
        string      Pest_Population8,
        string      Pest_Population9,
        string      Pest_Population10,
        string      Pest_Population11,
        string      Pest_Population12,
        string      Pesticide_Used,
        string      Spray_Date,
        string      Dosage,
        string      CLCV_Disease,
        string      Plant_Height )
        {
            //B8:E8:56:31:52:46

            this.District_Tehsil_Name           = District_Tehsil_Name;
            this.Mouza_town_Name                = Mouza_town_Name;
            this.Name                           = Name;
            this.Father_Name                    = Father_Name;
            this.Gender                         = Gender;
            this.Area                           = Area;
            this.Variety_of_Crop                = Variety_of_Crop;
            this.Sowing_Date                    = Sowing_Date;
            this.Visit_Date                     = Visit_Date;
            this.Pest_Population1               = Pest_Population1;
            this.Pest_Population2               = Pest_Population2;
            this.Pest_Population3               = Pest_Population3;
            this.Pest_Population4               = Pest_Population4;
            this.Pest_Population5               = Pest_Population5;
            this.Pest_Population6               = Pest_Population6;
            this.Pest_Population7               = Pest_Population7;
            this.Pest_Population8               = Pest_Population8;
            this.Pest_Population9               = Pest_Population9;
            this.Pest_Population10              = Pest_Population10;
            this.Pest_Population11              = Pest_Population11;
            this.Pest_Population12              = Pest_Population12;
            this.Pesticide_Used                 = Pesticide_Used;
            this.Spray_Date                     = Spray_Date;
            this.Dosage                         = Dosage;
            this.CLCV_Disease                   = CLCV_Disease;
            this.Plant_Height                   = Plant_Height;


            //this.District_Tehsil = myString;

        } // function end

    } // class end




    class BulkData
    {
        public BulkData() {
        } // function end

    } // class end




    public class BulkUploadToSql

    {

        private List<MyRecord> internalStore;
        public string tableName;
        public DataTable dataTable = new DataTable();
        public int recordCount;
        public int commitBatchSize;
        public string folder_Name;







        /// <summary>
        /// This is just used for initialization of the class object
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="commitBatchSize"></param>

        public BulkUploadToSql( string tableName, int commitBatchSize)
        {

            internalStore = new List<MyRecord>();
            this.tableName = tableName;
            this.dataTable = new DataTable(tableName);
            this.recordCount = 0;
            this.commitBatchSize = commitBatchSize;
            this.folder_Name = "";
            

            // add columns to this data table
            InitializeStructures();

        } // function end
        


        /// <summary>
        /// Passing some random values
        /// </summary>
        private BulkUploadToSql() : this("MyTableName", 1000)
        {

        } // function end
        //////////////////////////////////////////////


        
        /// <summary>
        /// Here we initialize the DataTabel structure
        /// </summary>
        private void InitializeStructures()
        {

            this.dataTable.Columns.Add("District_Tehsil_Name"    , typeof(string));
            this.dataTable.Columns.Add("Mouza_town_Name"         , typeof(string));
            this.dataTable.Columns.Add("Name"                    , typeof(string));
            this.dataTable.Columns.Add("Father_Name"             , typeof(string));
            this.dataTable.Columns.Add("Gender"                  , typeof(string));
            this.dataTable.Columns.Add("Area"                    , typeof(string));
            this.dataTable.Columns.Add("Variety_of_Crop"         , typeof(string));
            this.dataTable.Columns.Add("Sowing_Date"             , typeof(string));
            this.dataTable.Columns.Add("Visit_Date"              , typeof(string));
            this.dataTable.Columns.Add("Pest_Population1"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population2"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population3"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population4"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population5"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population6"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population7"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population8"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population9"        , typeof(string));
            this.dataTable.Columns.Add("Pest_Population10"       , typeof(string));
            this.dataTable.Columns.Add("Pest_Population11"       , typeof(string));
            this.dataTable.Columns.Add("Pest_Population12"       , typeof(string));
            this.dataTable.Columns.Add("Pesticide_Used"          , typeof(string));
            this.dataTable.Columns.Add("Spray_Date"              , typeof(string));
            this.dataTable.Columns.Add("Dosage"                  , typeof(string));
            this.dataTable.Columns.Add("CLCV_Disease"            , typeof(string));
            this.dataTable.Columns.Add("Plant_Height"            , typeof(string));

            // here add the columns

        } // function end
        ///////////////////////////////////////////////////////







        /// <summary>
        /// In this function we pass the 
        /// Datatable to the writeServer() function to write it on database
        /// </summary>
        /// <param name="database_name"></param>

        private void WriteToDatabase(string database_name)
        {
         
            // get your connection string
            string connString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + database_name + "; Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            var commandStr = "If not exists (select name from sysobjects where name = '"+ this.folder_Name +"') CREATE TABLE "+ this.folder_Name +"(" 

                   + "District_Tehsil_Name          char(100),"
                   + "Mouza_town_Name               char(100),"
                   + "Name                          char(100),"
                   + "Father_Name                   char(100),"
                   + "Gender                        char(15),"
                   + "Area                          char(200),"
                   + "Variety_of_Crop               char(100),"
                   + "Sowing_Date                   char(40),"
                   + "Visit_Date                    char(40),"
                   + "Pest_Population1              char(50),"
                   + "Pest_Population2              char(50),"
                   + "Pest_Population3              char(50),"
                   + "Pest_Population4              char(50),"
                   + "Pest_Population5              char(50),"
                   + "Pest_Population6              char(50),"
                   + "Pest_Population7              char(50),"
                   + "Pest_Population8              char(50),"
                   + "Pest_Population9              char(50),"
                   + "Pest_Population10             char(50),"
                   + "Pest_Population11             char(50),"
                   + "Pest_Population12             char(50),"
                   + "Pesticide_Used                char(50),"
                   + "Spray_Date                    char(50),"
                   + "Dosage                        char(50),"
                   + "CLCV_Disease                  char(50),"
                   + "Plant_Height                  char(50))";
            
            using (SqlCommand command = new SqlCommand(commandStr, con))
            {
                command.ExecuteNonQuery();
            }


            // connect to SQL
            using (SqlConnection connection = new SqlConnection(connString))
            {

                // make sure to enable triggers
                // more on triggers in next post
                SqlBulkCopy bulkCopy =
                    new SqlBulkCopy
                    (
                    connection,
                    SqlBulkCopyOptions.TableLock |
                    SqlBulkCopyOptions.FireTriggers |
                    SqlBulkCopyOptions.UseInternalTransaction,
                    null
                    );

                /////
                ///// write code to create table if 
                ///// present create a new table
                /////
                
                // set the destination table name
                bulkCopy.DestinationTableName = this.folder_Name;
                connection.Open();
                // write the data in the “dataTable”
                bulkCopy.WriteToServer(dataTable);
                connection.Close();
            } //using end

            // reset
            this.dataTable.Clear();
            this.recordCount = 0;
        } // function end
        ////////////////////////////////////////////////////////////


        public static string GetConnectionString(string ss)
        {
            Dictionary<string, string> props = new Dictionary<string, string>();

            // XLSX - Excel 2007, 2010, 2012, 2013
            props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
            props["Extended Properties"] = "Excel 12.0 XML";
            props["Data Source"] = ss;

            // XLS - Excel 2003 and Older
            //props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
            //props["Extended Properties"] = "Excel 8.0";
            //props["Data Source"] = "C:\\MyExcel.xls";

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }

        // stirng to date
        public static DateTime string_to_date(string iDate)
        {
            iDate = iDate.Trim();
            char[] delimiterChars = new char[]{ '/' };
            string[] words = iDate.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            if (iDate.Contains("/") )
            {
                if (int.Parse(words[0]) > 31 || int.Parse(words[0]) < 1)
                {
                    words[0] = "31";
                }
                if (int.Parse(words[1]) > 12 || int.Parse(words[1]) < 1)
                {
                    words[1] = "12";
                }
                DateTime regDate;
                try
                {
                    regDate = DateTime.ParseExact((words[2].ToString().Trim() + "-" + words[1].ToString().Trim() + "-" + words[0].ToString().Trim() + "22:22:222"), "yyyy-MM-dd HH:mm:sss", CultureInfo.InvariantCulture);
                    return regDate;
                }
                catch (Exception e)
                {
                    DateTime obj = DateTime.Now;
                    return obj;
                }
                return regDate;

            }
            else
            {
                DateTime obj = DateTime.Now;
                return obj;
            }
            
        }

        // end string to date



        /// <summary>
        /// In this function Data will read from the file
        /// added to the data table
        /// In the end an object will be returned having the data in it
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>



        public static BulkUploadToSql Load(string file_Path, string file_Name , int Commit_Size , string folder_Name)
        {

            // create a new object to return
             

            BulkUploadToSql o = new BulkUploadToSql();
            int index = 0;
            string value = null; // THis will be used to get person name
            string value2 = null; // THis will be used to get person father name

            o.tableName = file_Name; // Just the filename, it is not used here
            o.commitBatchSize = Commit_Size;

            string FolderName = new DirectoryInfo(System.IO.Path.GetDirectoryName(file_Path)).Name; // Folder name of the file
            o.folder_Name = FolderName; // storing folder name in Static object of class BulkUploadToSql

            string extension = Path.GetExtension(file_Path); // Extension of the files
             


            // replace the code below
            // with your custom logic
            // code to Load data from file 
            /////////////////////  MY CODE START ///////////////////////////

            if (extension.Equals(".xlsx")) // Check for excel files
            {

                DataSet ds = new DataSet();
                string connectionString = GetConnectionString(file_Path); // function get file path return connection string for that file

                using (OleDbConnection conn = new OleDbConnection(connectionString)) // Making connecton
                {
                    conn.Open(); // opening conection
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;

                    // Get all Sheets in Excel File
                    DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    // Loop through all Sheets to get data
                    foreach (DataRow dr in dtSheet.Rows)
                    {
                        string sheetName = dr["TABLE_NAME"].ToString();

                        if (!sheetName.EndsWith("$"))
                            continue;

                        // Get all rows from the Sheet
                        cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

                        DataTable dt = new DataTable();
                        dt.TableName = sheetName;

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(dt); // filling data table with data adapter

                        // GENDER IDENTIFICATION USING SEX MACHINE
                        char[] delimiters = new char[] { ' ' };
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\john\Downloads\QueryBuilder\QueryBuilder\QueryBuilder\SexMachine-0.1.1\String.txt"))
                        {
                            for (int i = 0; i < dt.Rows.Count; i++) // loop to iterate through all the rows
                            {
                                if (dt.Rows[i][2].ToString().ToLower().Contains("s/o"))
                                {
                                    index = dt.Rows[i][2].ToString().ToLower().IndexOf("s/o"); // to get index of the S/0 for seperation of name
                                    value = dt.Rows[i][2].ToString().Substring(0, index); // person name
                                    value2 = dt.Rows[i][2].ToString().Substring(index + 3); // father name
                                }
                                else
                                {
                                    value = dt.Rows[i][2].ToString().Substring(0);  
                                    value2 = dt.Rows[i][2].ToString().Substring(0);
                                }


                                string[] parts = value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); // to seperate first name from person name
                                file.WriteLine(parts[0]); // writing firstname for gender identification
                            }  // for end

                            file.Close(); // closing string.txt file

                        } // using  end
                        // Starting a new process to run python code
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.EnableRaisingEvents = false;
                        proc.StartInfo.FileName = @"C:\Users\john\Downloads\QueryBuilder\QueryBuilder\QueryBuilder\SexMachine-0.1.1\pythonFile.bat";
                        proc.Start();
                        proc.WaitForExit();
                        proc.Close();
                        // Reading all the gender from the string1.txt file that was generated by the python code
                        string[] gender = System.IO.File.ReadAllLines(@"C:\Users\john\Downloads\QueryBuilder\QueryBuilder\QueryBuilder\SexMachine-0.1.1\String1.txt");
                        // END GENDER IDENTIFICATION USING SEX MACHINE

                        for ( int i = 0;i < dt.Rows.Count; i++) // loop to iterate through all the rows
                        {

                                    // To seperate Father Name
                            if (dt.Rows[i][2].ToString().ToLower().Contains("s/o"))
                            {
                                index = dt.Rows[i][2].ToString().ToLower().IndexOf("s/o"); // to get index of the S/0 for seperation of name
                                value = dt.Rows[i][2].ToString().Substring(0, index); // person name
                                value2 = dt.Rows[i][2].ToString().Substring(index+3); // father name
                            }
                            else
                            {
                                value = dt.Rows[i][2].ToString().Substring(0);
                                value2 = dt.Rows[i][2].ToString().Substring(0);
                            }

                            // End to seperate Father Name
                            string gender1 = gender[i].ToString(); // getting gender
                            if ( gender1.ToString().ToLower() != "female" && gender1.ToString().ToLower() != "male") // if gender neither male or female
                            {
                                gender1 = "UNKNOWN";
                            }
                            MyRecord rec = new MyRecord(
                                            dt.Rows[i][0].ToString(), // getting column values
                                            dt.Rows[i][1].ToString(),
                                            //                                          dt.Rows[i][2].ToString().Substring(0, index),
                                            //                                          dt.Rows[i][2].ToString().Substring(index),
                                            value,
                                            value2,
                                            gender1,
                                            dt.Rows[i][3].ToString(),
                                            dt.Rows[i][4].ToString(),
                                            dt.Rows[i][5].ToString(),
                                            dt.Rows[i][6].ToString(),
                                            dt.Rows[i][7].ToString(),
                                            dt.Rows[i][8].ToString(),
                                            dt.Rows[i][9].ToString(),
                                            dt.Rows[i][10].ToString(),
                                            dt.Rows[i][11].ToString(),
                                            dt.Rows[i][12].ToString(),
                                            dt.Rows[i][13].ToString(),
                                            dt.Rows[i][14].ToString(),
                                            dt.Rows[i][15].ToString(),
                                            dt.Rows[i][16].ToString(),
                                            dt.Rows[i][17].ToString(),
                                            dt.Rows[i][18].ToString(),
                                            dt.Rows[i][19].ToString(),
                                            dt.Rows[i][20].ToString(),
                                            dt.Rows[i][21].ToString(),
                                            dt.Rows[i][22].ToString(),
                                            dt.Rows[i][23].ToString()
                                            );
                            o.internalStore.Add(rec); // storing object
                        } // for end
                    } // foreach end 
                    
                    cmd = null;
                    conn.Close();
                } //using end


                //////////////////////////// END CODE TO READ XLXS FILE ////////////////////////////



            } // File Format if end

            else // FOr text files
            {


                // File reading from a datasource
                string[] lines = System.IO.File.ReadAllLines(file_Path.ToString());
                string dd = lines.Length.ToString();

                char[] delimiters = new char[] { '|', ',', '$' }; // delimeters to parse the line 

                
                // START GENDER IDENTIFICATION CODE 
                char[] delimiters2 = new char[] { ' ' }; // delimeter to sepeate firstname
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\john\Downloads\QueryBuilder\QueryBuilder\QueryBuilder\SexMachine-0.1.1\String.txt"))
                {
                   for (int cnt = 0; cnt < Int32.Parse(dd); cnt++)
                {
                    string[] parts = lines[cnt].Split(delimiters, StringSplitOptions.RemoveEmptyEntries); 
                    index = 0;
                    // To seperate Father Name
                    if (parts[2].ToLower().Contains("s/o"))
                    {
                        index = parts[2].ToLower().IndexOf("s/o"); //index to seperate person and father name
                        value = parts[2].Substring(0, index); // person name
                        value2 = parts[2].Substring(index + 3); // father name
                    }
                    else
                    {
                        value = parts[2].Substring(0);
                        value2 = parts[2].Substring(0);
                    }

                    string [] parts2 = value.Split(delimiters2, StringSplitOptions.RemoveEmptyEntries); // getting first name
                    file.WriteLine(parts2[0]); // writing firstname in file string.txt for gender identification

                } // for end
                    file.Close();
                }
                // Starting python code for gender identification
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = @"C:\Users\john\Downloads\QueryBuilder\QueryBuilder\QueryBuilder\SexMachine-0.1.1\pythonFile.bat";
                proc.Start();
                proc.WaitForExit();
                proc.Close();
                // reading all the genders
                string[] gender = System.IO.File.ReadAllLines(@"C:\Users\john\Downloads\QueryBuilder\QueryBuilder\QueryBuilder\SexMachine-0.1.1\String1.txt");
                // END GENDER IDENTIFICATION CODE 



                /////////////////////  MY CODE END ///////////////////////////
                for (int cnt = 0; cnt < Int32.Parse(dd); cnt++)
                {
                    string[] parts = lines[cnt].Split(delimiters, StringSplitOptions.RemoveEmptyEntries); // to read



                    index = 0;
                    // To seperate Father Name
                    if (parts[2].ToLower().Contains("s/o"))
                    {
                        index = parts[2].ToLower().IndexOf("s/o"); // index for seratiing person and father name
                        value = parts[2].Substring(0, index); // person name
                        value2 = parts[2].Substring(index+3); // father name
                    }
                    else
                    {
                        value = parts[2].Substring(0);
                        value2 = parts[2].Substring(0);
                    }



                    // End to seperate Father Name
                    string gender1 = gender[cnt].ToString();
                    if (gender1.ToString().ToLower() != "female" && gender1.ToString().ToLower() != "male") // if neither male or female
                    {
                        gender1 = "UNKNOWN";
                    }



                    MyRecord rec = new MyRecord(
                        parts[0],
                        parts[1],
                        value,
                        value2,
                        gender1,
                        parts[3],
                        parts[4],
                        parts[5],
                        parts[6],
                        parts[7],
                        parts[8],
                        parts[9],
                        parts[10],
                        parts[11],
                        parts[12],
                        parts[13],
                        parts[14],
                        parts[15],
                        parts[16],
                        parts[17],
                        parts[18],
                        parts[19],
                        parts[20],
                        parts[21],
                        parts[22],
                        parts[23]
                        
                        );

                    o.internalStore.Add(rec); // storing object
                } // for end
            } // else end
            return o;
         } // function end
         ///////////////////////////////////////////////////

        public void Flush(string database_Name)
        {
            // transfer data to the datatable
            foreach (MyRecord rec in this.internalStore)
            {
                this.PopulateDataTable(rec);
                if (this.recordCount >= this.commitBatchSize)
                    this.WriteToDatabase(database_Name);
            }
            // write remaining records to the DB
            if (this.recordCount > 0)  this.WriteToDatabase(database_Name);
        } // function end


        private void PopulateDataTable(MyRecord record)
        {

            DataRow row;
            // populate the values
            // using your custom logic
            row = this.dataTable.NewRow();
            row[0]  = record.District_Tehsil_Name;
            row[1]  = record.Mouza_town_Name;
            row[2]  = record.Name;
            row[3]  = record.Father_Name;
            row[4]  = record.Gender;
            row[5]  = record.Area;
            row[6]  = record.Variety_of_Crop;
            row[7]  = record.Sowing_Date;
            row[8]  = record.Visit_Date;
            row[9]  = record.Pest_Population1;
            row[10] = record.Pest_Population2;
            row[11] = record.Pest_Population3;
            row[12] = record.Pest_Population4;
            row[13] = record.Pest_Population5;
            row[14] = record.Pest_Population6;
            row[15] = record.Pest_Population7;
            row[16] = record.Pest_Population8;
            row[17] = record.Pest_Population9;
            row[18] = record.Pest_Population10;
            row[19] = record.Pest_Population11;
            row[20] = record.Pest_Population12;
            row[21] = record.Pesticide_Used;
            row[22] = record.Spray_Date;
            row[23] = record.Dosage;
            row[24] = record.CLCV_Disease;
            row[25] = record.Plant_Height;


            // add it to the base for final addition to the DB
            this.dataTable.Rows.Add(row);
            this.recordCount++;

        } // function end
    } // class end

} // namespace end
