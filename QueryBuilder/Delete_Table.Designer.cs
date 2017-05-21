namespace QueryBuilder
{
    partial class Delete_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Table));
            this.databases = new System.Windows.Forms.ComboBox();
            this.tables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load_databases = new System.Windows.Forms.Button();
            this.load_tables = new System.Windows.Forms.Button();
            this.droop_table = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // databases
            // 
            this.databases.FormattingEnabled = true;
            this.databases.Location = new System.Drawing.Point(113, 50);
            this.databases.Name = "databases";
            this.databases.Size = new System.Drawing.Size(193, 21);
            this.databases.TabIndex = 0;
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(113, 97);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(193, 21);
            this.tables.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table";
            // 
            // load_databases
            // 
            this.load_databases.Location = new System.Drawing.Point(413, 47);
            this.load_databases.Name = "load_databases";
            this.load_databases.Size = new System.Drawing.Size(111, 23);
            this.load_databases.TabIndex = 4;
            this.load_databases.Text = "Load Databases";
            this.load_databases.UseVisualStyleBackColor = true;
            this.load_databases.Click += new System.EventHandler(this.load_databases_Click);
            // 
            // load_tables
            // 
            this.load_tables.Location = new System.Drawing.Point(413, 94);
            this.load_tables.Name = "load_tables";
            this.load_tables.Size = new System.Drawing.Size(111, 23);
            this.load_tables.TabIndex = 5;
            this.load_tables.Text = "Load Tables";
            this.load_tables.UseVisualStyleBackColor = true;
            this.load_tables.Click += new System.EventHandler(this.load_tables_Click);
            // 
            // droop_table
            // 
            this.droop_table.Location = new System.Drawing.Point(413, 139);
            this.droop_table.Name = "droop_table";
            this.droop_table.Size = new System.Drawing.Size(111, 23);
            this.droop_table.TabIndex = 6;
            this.droop_table.Text = "Drop Table";
            this.droop_table.UseVisualStyleBackColor = true;
            this.droop_table.Click += new System.EventHandler(this.droop_table_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(413, 185);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(111, 23);
            this.Close.TabIndex = 7;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Delete_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 385);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.droop_table);
            this.Controls.Add(this.load_tables);
            this.Controls.Add(this.load_databases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.databases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_Table";
            this.Text = "Delete Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox databases;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load_databases;
        private System.Windows.Forms.Button load_tables;
        private System.Windows.Forms.Button droop_table;
        private System.Windows.Forms.Button Close;
    }
}