namespace QueryBuilder
{
    partial class Create_Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Database));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.get_db_txt_bx_1 = new System.Windows.Forms.TextBox();
            this.database_name = new System.Windows.Forms.Label();
            this.create_db = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.database_names_combo = new System.Windows.Forms.ComboBox();
            this.Database_names = new System.Windows.Forms.Label();
            this.refresh_list = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // get_db_txt_bx_1
            // 
            this.get_db_txt_bx_1.Location = new System.Drawing.Point(126, 63);
            this.get_db_txt_bx_1.Name = "get_db_txt_bx_1";
            this.get_db_txt_bx_1.Size = new System.Drawing.Size(189, 20);
            this.get_db_txt_bx_1.TabIndex = 1;
            // 
            // database_name
            // 
            this.database_name.AutoSize = true;
            this.database_name.Location = new System.Drawing.Point(12, 63);
            this.database_name.Name = "database_name";
            this.database_name.Size = new System.Drawing.Size(84, 13);
            this.database_name.TabIndex = 2;
            this.database_name.Text = "Database Name";
            // 
            // create_db
            // 
            this.create_db.Location = new System.Drawing.Point(370, 60);
            this.create_db.Name = "create_db";
            this.create_db.Size = new System.Drawing.Size(138, 23);
            this.create_db.TabIndex = 3;
            this.create_db.Text = "Create Database";
            this.create_db.UseVisualStyleBackColor = true;
            this.create_db.Click += new System.EventHandler(this.create_db_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(370, 98);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(138, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear ";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(370, 136);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(138, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // database_names_combo
            // 
            this.database_names_combo.FormattingEnabled = true;
            this.database_names_combo.Location = new System.Drawing.Point(126, 23);
            this.database_names_combo.Name = "database_names_combo";
            this.database_names_combo.Size = new System.Drawing.Size(189, 21);
            this.database_names_combo.TabIndex = 6;
            this.database_names_combo.SelectedIndexChanged += new System.EventHandler(this.database_names_combo_SelectedIndexChanged);
            // 
            // Database_names
            // 
            this.Database_names.AutoSize = true;
            this.Database_names.Location = new System.Drawing.Point(15, 23);
            this.Database_names.Name = "Database_names";
            this.Database_names.Size = new System.Drawing.Size(58, 13);
            this.Database_names.TabIndex = 7;
            this.Database_names.Text = "Databases";
            // 
            // refresh_list
            // 
            this.refresh_list.Location = new System.Drawing.Point(370, 23);
            this.refresh_list.Name = "refresh_list";
            this.refresh_list.Size = new System.Drawing.Size(138, 23);
            this.refresh_list.TabIndex = 8;
            this.refresh_list.Text = "Load Databases";
            this.refresh_list.UseVisualStyleBackColor = true;
            this.refresh_list.Click += new System.EventHandler(this.refresh_list_Click);
            // 
            // Create_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 201);
            this.Controls.Add(this.refresh_list);
            this.Controls.Add(this.Database_names);
            this.Controls.Add(this.database_names_combo);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.create_db);
            this.Controls.Add(this.database_name);
            this.Controls.Add(this.get_db_txt_bx_1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_Database";
            this.Text = "Create Database";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.TextBox get_db_txt_bx_1;
        private System.Windows.Forms.Label database_name;
        private System.Windows.Forms.Button create_db;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox database_names_combo;
        private System.Windows.Forms.Label Database_names;
        private System.Windows.Forms.Button refresh_list;
    }
}