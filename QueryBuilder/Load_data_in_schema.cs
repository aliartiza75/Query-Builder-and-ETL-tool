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
    public partial class Load_data_in_schema : Form
    {
        SqlConnection cnn = new SqlConnection();

        public Load_data_in_schema()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } // function end

        private void Load_databases_Click(object sender, EventArgs e)
        {
            source_databases.Items.Clear();
            target_databases.Items.Clear();
            source_tables.Items.Clear();
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
                            source_databases.Items.Add(reader[0].ToString());
                            target_databases.Items.Add(reader[0].ToString());

                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end

        } // function end

        private void source_databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            source_tables.Items.Clear();

            SqlConnection sql = new SqlConnection();
            if (!(ConnectionState.Open == sql.State))
            {
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem + "; Integrated Security=True";
                sql = new SqlConnection(connetionString);
                sql.Open();
            }
            else
            {
                sql.Close();
                string connetionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog=" + source_databases.SelectedItem + "; Integrated Security=True";
                sql = new SqlConnection(connetionString);
                sql.Open();

            }

            string strSQL = "select table_name from " + source_databases.SelectedItem + ".INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'";
            using (sql)
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, sql))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            source_tables.Items.Add(reader[0].ToString());
                        } // while end

                    } // inner most using end
                } // inner using end
            } // outer using end
        } // function end

        private void start_loading_Click(object sender, EventArgs e)
        {


            int commit_Size = 1;
            int records_processed = 0;

            //// START DATABASE READING CODE /////
            string NewconnectionString = "Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + source_databases.SelectedItem.ToString() + "; Integrated Security=True";
            SqlConnection openCon = new SqlConnection("Data Source=WNDOWS-SAVJEG8; Initial Catalog= " + target_databases.SelectedItem.ToString() + "; Integrated Security=True");
            string sqlselectQuery = "select * from " + source_tables.SelectedItem.ToString() + "";
            SqlCommand sqlcmd = new SqlCommand();


            openCon.Open();

            string District_Tehsil          = "District_Tehsil";
            string Mouza_Town               = "Mouza_Town";
            string Farmer                   = "Farmer";
            string Variety_of_Corps         = "Variety_of_Corps";
            string Sowing_Dates             = "Sowing_Dates";
            string Visit_Dates              = "Visit_Dates";
            string Pestiside_Spray_Dates    = "Pestiside_Spray_Dates";
            string Pestiside_Used           = "Pestiside_Used";
            string Fact_Table               = "Fact_Table";
            /// Creating Tables 
            var commandStr = "If not exists (select name from sysobjects where name = '" + District_Tehsil + "') CREATE TABLE " + District_Tehsil + "("

                    + "District_Tehsil_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                    + "District_Tehsil_Name     char(200),"
                    + "CONSTRAINT U_District_Tehsil_Name UNIQUE(District_Tehsil_Name)  )";
            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }
            commandStr = "If not exists (select name from sysobjects where name = '" + Mouza_Town + "') CREATE TABLE " + Mouza_Town + "("

                   + "Mouza_Town_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                   + "Mouza_Town_Name     char(200),"
                   + "CONSTRAINT U_Mouza_Town_Name UNIQUE(Mouza_Town_Name))";

            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }
            commandStr = "If not exists (select name from sysobjects where name = '" + Farmer + "') CREATE TABLE " + Farmer + "("

                   + "Farmer_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                   + "Farmer_Name       char(200),"
                   + "Father_Name       char(200),"
                   + "Gender            char(200),"
                   + "CONSTRAINT U_Farmer_Name UNIQUE(Farmer_Name))";

            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }
            commandStr = "If not exists (select name from sysobjects where name = '" + Variety_of_Corps + "') CREATE TABLE " + Variety_of_Corps + "("

                  + "Variety_of_Corps_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                  + "Corp_Name       char(200),"
                  + "Corp_ID       char(200),"
                  + "CONSTRAINT U_Corp_ID UNIQUE(Corp_ID))";

            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }



            commandStr = "If not exists (select name from sysobjects where name = '" + Sowing_Dates + "') CREATE TABLE " + Sowing_Dates + "("
                  + "Date_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                  + "Sowing_Date_Date               int,"
                  + "Sowing_Date_Month              int,"
                  + "Sowing_Date_Year               int"
                  + ")";
            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }
            commandStr = "If not exists (select name from sysobjects where name = '" + Visit_Dates + "') CREATE TABLE " + Visit_Dates + "("
                  + "Date_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                  + "Visit_Date_Date                int,"
                  + "Visit_Date_Month               int,"
                  + "Visit_Date_Year                int"
                  + ")";
            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }
            commandStr = "If not exists (select name from sysobjects where name = '" + Pestiside_Spray_Dates + "') CREATE TABLE " + Pestiside_Spray_Dates + "("
                  + "Date_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                  + "Pestiside_Spray_Date           int,"
                  + "Pestiside_Spray_Month          int,"
                  + "Pestiside_Spray_Year           int"
                  + ")";
            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }
            commandStr = "If not exists (select name from sysobjects where name = '" + Pestiside_Used + "') CREATE TABLE " + Pestiside_Used + "("

                   + "Pestiside_Used_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,"
                   + "Pestiside_Used_Name    char(200),"
                   + "CONSTRAINT U_Pestiside_Used_Name UNIQUE(Pestiside_Used_Name))";

            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }

            commandStr = "If not exists (select name from sysobjects where name = '" + Fact_Table + "') CREATE TABLE " + Fact_Table + "("

                   + "Fact_ID                       int IDENTITY(1,1) NOT NULL,"
                   + "District_Tehsil_ID            INT NOT NULL,"
                   + "Mouza_Town_ID                 INT NOT NULL,"
                   + "Farmer_ID                     INT NOT NULL,"
                   + "Variety_of_Corps_ID           INT NOT NULL,"
                   + "Date_ID_Sowing                INT NOT NULL,"
                   + "Date_ID_Visit                 INT NOT NULL,"
                   + "Date_ID_PSD                   INT NOT NULL,"
                   + "Pestiside_Used_ID             INT NOT NULL,"
                   + "Area                          INT,"
                   + "Area_Unit                     char(200),"
                   + "Pest_Population_1             numeric(7,2),"
                   + "Pest_Population_2             numeric(7,2),"
                   + "Pest_Population_3             numeric(7,2),"
                   + "Pest_Population_4             numeric(7,2),"
                   + "Pest_Population_5             numeric(7,2),"
                   + "Pest_Population_6             numeric(7,2),"
                   + "Pest_Population_7             numeric(7,2),"
                   + "Pest_Population_8             numeric(7,2),"
                   + "Pest_Population_9             numeric(7,2),"
                   + "Pest_Population_10            numeric(7,2),"
                   + "Pest_Population_11            numeric(7,2),"
                   + "Pest_Population_12            numeric(7,2),"
                   + "Pestiside_Dosage              INT,"
                   + "Pestiside_Dosage_Unit         char(100),"
                   + "CLCV_Disease                  INT,"
                   + "CLCV_Disease_Level            char(100),"
                   + "Plant_Height                  INT,"
                   + "Plant_Height_Unit             char(50),"
                   // Foreign Keys
                   + "CONSTRAINT [FK_FACT_TABLE_District_Tehsil]        FOREIGN KEY (District_Tehsil_ID)    REFERENCES District_Tehsil       (District_Tehsil_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Mouza_Town]             FOREIGN KEY (Mouza_Town_ID)         REFERENCES Mouza_Town            (Mouza_Town_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Farmer]                 FOREIGN KEY (Farmer_ID)             REFERENCES Farmer                (Farmer_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Variety_of_Corps]       FOREIGN KEY (Variety_of_Corps_ID)   REFERENCES Variety_of_Corps      (Variety_of_Corps_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Sowing_Dates]           FOREIGN KEY (Date_ID_Sowing)        REFERENCES Sowing_Dates          (Date_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Visit_Dates]            FOREIGN KEY (Date_ID_Visit)         REFERENCES Visit_Dates           (Date_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Pestiside_Spray_Dates]  FOREIGN KEY (Date_ID_PSD)           REFERENCES Pestiside_Spray_Dates (Date_ID) ,"
                   + "CONSTRAINT [FK_FACT_TABLE_Pestiside_Used]         FOREIGN KEY (Pestiside_Used_ID)     REFERENCES Pestiside_Used        (Pestiside_Used_ID) ,"
                   // Composite Primary Keys
                   + "PRIMARY KEY   (   Fact_ID,    District_Tehsil_ID,   Mouza_Town_ID,    Farmer_ID,  Variety_of_Corps_ID,    Date_ID_Sowing,     Date_ID_Visit,      Date_ID_PSD,    Pestiside_Used_ID  ))";

            using (SqlCommand command = new SqlCommand(commandStr, openCon))
            {
                command.ExecuteNonQuery();
            }





            int[] Fact_Table_ID = new int[8];






            SqlConnection Loading_data_to_Scheme_conn = new SqlConnection(NewconnectionString);
            sqlcmd.Connection = Loading_data_to_Scheme_conn;
            sqlcmd.CommandTimeout = 0;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sqlselectQuery;
            Loading_data_to_Scheme_conn.Open();


            using (Loading_data_to_Scheme_conn)
            {
                using (SqlDataReader sdr = sqlcmd.ExecuteReader())
                {
                    
                    while (sdr.Read()) // Start Reading records 
                    {

                        // Location Insertion Part


                       /* using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM District_Tehsil WHERE (District_Tehsil_Name = '" + sdr[0].ToString().ToLower() + "')", openCon))
                        {
                            int UserExist = (int)check_User_Name.ExecuteScalar();
                            if (UserExist < 1)
                            {
                                string saveStaff = "INSERT into District_Tehsil (District_Tehsil_Name) " + " VALUES ('" + sdr[0].ToString().ToLower() + "');";
                                sqlcmd = new SqlCommand(saveStaff, openCon);
                                sqlcmd.ExecuteNonQuery();
                            }
                        }

                        // Mouza Town
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Mouza_Town WHERE (Mouza_Town_Name = '" + sdr[1].ToString().ToLower() + "')", openCon))
                        {
                            int UserExist = (int)check_User_Name.ExecuteScalar();
                            if (UserExist < 1)
                            {
                                string saveStaff = "INSERT into Mouza_Town (Mouza_Town_Name) " + " VALUES ('" + sdr[1].ToString().ToLower() + "');";
                                sqlcmd = new SqlCommand(saveStaff, openCon);
                                sqlcmd.ExecuteNonQuery();
                            }
                        }
                        // Farmer
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Farmer WHERE (Farmer_Name = '" + sdr[2].ToString().ToLower() + "')", openCon))
                        {
                            int UserExist = (int)check_User_Name.ExecuteScalar();
                            if (UserExist < 1)
                            {
                                string saveStaff = "INSERT into Farmer (Farmer_Name,Father_Name,Gender)  VALUES ("
                                    + "'" + sdr[2].ToString().ToLower() + "',"
                                    + "'" + sdr[3].ToString().ToLower() + "',"
                                    + "'" + sdr[4].ToString().ToLower() + "');";


                                sqlcmd = new SqlCommand(saveStaff, openCon);
                                sqlcmd.ExecuteNonQuery();
                            }
                        } // using end
                        // Variety Of Corps
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Variety_of_Corps WHERE (Corp_ID = '" + sdr[8].ToString().ToLower() + "')", openCon))
                        {
                            int UserExist = (int)check_User_Name.ExecuteScalar();
                            if (UserExist < 1)
                            {
                                string saveStaff = "INSERT into Variety_of_Corps (Corp_Name,Corp_ID)  VALUES ("
                                    + "'" + sdr[7].ToString().ToLower() + "',"
                                    + "'" + sdr[8].ToString().ToLower() + "');";


                                sqlcmd = new SqlCommand(saveStaff, openCon);
                                sqlcmd.ExecuteNonQuery();
                            }
                        } // using end
                        //Sowing Date
                        string saveStafff = "INSERT into Sowing_Dates (Sowing_Date_Date,Sowing_Date_Month,Sowing_Date_Year)  VALUES ("
                                    + "'" + sdr[9].ToString().ToLower() + "',"
                                    + "'" + sdr[10].ToString().ToLower() + "',"
                                    + "'" + sdr[11].ToString().ToLower() + "');";


                          sqlcmd = new SqlCommand(saveStafff, openCon);
                          sqlcmd.ExecuteNonQuery();

                        //Visit Date
                        string saveStaffff = "INSERT into Visit_Dates (Visit_Date_Date,Visit_Date_Month,Visit_Date_Year)  VALUES ("
                                    + "'" + sdr[12].ToString().ToLower() + "',"
                                    + "'" + sdr[13].ToString().ToLower() + "',"
                                    + "'" + sdr[14].ToString().ToLower() + "');";


                        sqlcmd = new SqlCommand(saveStaffff, openCon);
                        sqlcmd.ExecuteNonQuery();

                        //Pestiside Spray Date
                        string saveStafffff = "INSERT into Pestiside_Spray_Dates (Pestiside_Spray_Date,Pestiside_Spray_Month,Pestiside_Spray_Year)  VALUES ("
                                    + "'" + sdr[28].ToString().ToLower() + "',"
                                    + "'" + sdr[29].ToString().ToLower() + "',"
                                    + "'" + sdr[30].ToString().ToLower() + "');";


                        sqlcmd = new SqlCommand(saveStafffff, openCon);
                        sqlcmd.ExecuteNonQuery();
                        // Pestiside Used
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Pestiside_Used WHERE (Pestiside_Used_Name = '" + sdr[27].ToString().ToLower() + "')", openCon))
                        {
                            int UserExist = (int)check_User_Name.ExecuteScalar();
                            if (UserExist < 1)
                            {
                                string saveStaff = "INSERT into Pestiside_Used (Pestiside_Used_Name) " + " VALUES ('" + sdr[27].ToString().ToLower() + "');";
                                sqlcmd = new SqlCommand(saveStaff, openCon);
                                sqlcmd.ExecuteNonQuery();
                            }
                        }
                        */
















                        // Getting ID's for fact Table
                        // District_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT District_Tehsil_ID FROM District_Tehsil WHERE ( District_Tehsil_Name = '" + sdr[0].ToString().ToLower() + "')", openCon))
                        {
                            Fact_Table_ID[0] = (int)check_User_Name.ExecuteScalar();
                        }


                        // Mouza_Town_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Mouza_Town_ID FROM Mouza_Town WHERE ( Mouza_Town_Name = '" + sdr[1].ToString().ToLower() + "')", openCon))
                        {
                            Fact_Table_ID[1] = (int)check_User_Name.ExecuteScalar();
                        }

                        // Farmer_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Farmer_ID FROM Farmer WHERE ( Farmer_Name = '" + sdr[2].ToString().ToLower() + "')", openCon))
                        {
                            Fact_Table_ID[2] = (int)check_User_Name.ExecuteScalar();
                        }

                        // Variety_of_Corps_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Variety_of_Corps_ID FROM Variety_of_Corps WHERE ( Corp_ID = '" + sdr[8].ToString().ToLower() + "')", openCon))
                        {
                            Fact_Table_ID[3] = (int)check_User_Name.ExecuteScalar();
                        }

                        // Sowing_Dates_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Date_ID FROM Sowing_Dates WHERE ( Sowing_Date_Date = '" + sdr[9].ToString().ToLower() + "' AND   Sowing_Date_Month = '" + sdr[10].ToString().ToLower() + "' AND Sowing_Date_Year = '" + sdr[11].ToString().ToLower() + "'       )", openCon))
                        {
                            Fact_Table_ID[4] = (int)check_User_Name.ExecuteScalar();
                        }


                        // Visit_Dates_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Date_ID FROM Visit_Dates WHERE ( Visit_Date_Date = '" + sdr[12].ToString().ToLower() + "' AND   Visit_Date_Month = '" + sdr[13].ToString().ToLower() + "' AND Visit_Date_Year = '" + sdr[14].ToString().ToLower() + "'       )", openCon))
                        {
                            Fact_Table_ID[5] = (int)check_User_Name.ExecuteScalar();
                        }

                        // Pestiside_Spray_Dates
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Date_ID FROM Pestiside_Spray_Dates WHERE ( Pestiside_Spray_Date = '" + sdr[28].ToString().ToLower() + "' AND   Pestiside_Spray_Month = '" + sdr[29].ToString().ToLower() + "' AND Pestiside_Spray_Year = '" + sdr[30].ToString().ToLower() + "'       )", openCon))
                        {
                            Fact_Table_ID[6] = (int)check_User_Name.ExecuteScalar();
                        }

                        // Pestiside_Used_ID
                        using (SqlCommand check_User_Name = new SqlCommand("SELECT Pestiside_Used_ID FROM Pestiside_Used WHERE ( Pestiside_Used_Name = '" + sdr[27].ToString().ToLower() + "')", openCon))
                        {
                            Fact_Table_ID[7] = (int)check_User_Name.ExecuteScalar();
                        }




                        // Fact Table
                        string saveStafffs = "INSERT into Fact_Table (District_Tehsil_ID, Mouza_Town_ID, Farmer_ID, Variety_of_Corps_ID, Date_ID_Sowing, Date_ID_Visit, Date_ID_PSD, Pestiside_Used_ID, Area, Area_Unit,"
                                                + "Pest_Population_1, Pest_Population_2, Pest_Population_3, Pest_Population_4, Pest_Population_5, Pest_Population_6, Pest_Population_7, Pest_Population_8, Pest_Population_9, Pest_Population_10,"
                                                + "Pest_Population_11, Pest_Population_12, Pestiside_Dosage, Pestiside_Dosage_Unit, CLCV_Disease, CLCV_Disease_Level, Plant_Height, Plant_Height_Unit ) " + " VALUES ('" + Fact_Table_ID[0] + "',"
                                                + "'"+  Fact_Table_ID[1] + "',"
                                                + "'" + Fact_Table_ID[2] + "',"
                                                + "'" + Fact_Table_ID[3] + "',"
                                                + "'" + Fact_Table_ID[4] + "',"
                                                + "'" + Fact_Table_ID[5] + "',"
                                                + "'" + Fact_Table_ID[6] + "',"
                                                + "'" + Fact_Table_ID[7] + "',"
                                                + "'" + int.Parse(sdr[5].ToString()) +"',"
                                                + "'" + sdr[6].ToString().ToLower() + "',"
                                                + "'" + double.Parse(sdr[15].ToString())+"',"
                                                + "'" + double.Parse(sdr[16].ToString()) + "',"
                                                + "'" + double.Parse(sdr[17].ToString()) + "',"
                                                + "'" + double.Parse(sdr[18].ToString()) + "',"
                                                + "'" + double.Parse(sdr[19].ToString()) + "',"
                                                + "'" + double.Parse(sdr[20].ToString()) + "',"
                                                + "'" + double.Parse(sdr[21].ToString()) + "',"
                                                + "'" + double.Parse(sdr[22].ToString()) + "',"
                                                + "'" + double.Parse(sdr[23].ToString()) + "',"
                                                + "'" + double.Parse(sdr[24].ToString()) + "',"
                                                + "'" + double.Parse(sdr[25].ToString()) + "',"
                                                + "'" + double.Parse(sdr[26].ToString()) + "',"
                                                + "'" + int.Parse(sdr[31].ToString()) +"',"
                                                + "'" + sdr[32].ToString().ToLower() + "',"
                                                + "'" + int.Parse(sdr[33].ToString()) +"',"
                                                + "'" + sdr[34].ToString().ToLower() + "',"
                                                + "'" + int.Parse(sdr[35].ToString())+"',"
                                                + "'" + sdr[36].ToString().ToLower() + "');";
                        sqlcmd = new SqlCommand(saveStafffs, openCon);
                        sqlcmd.ExecuteNonQuery();






                    } // while end DB reading end


                    Loading_data_to_Scheme_conn.Close();
                } // inner using end
            } // outer using end

       } // function end
    } // class end

} // namespace end
