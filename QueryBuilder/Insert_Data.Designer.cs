namespace QueryBuilder
{
    partial class Insert_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Data));
            this.Load_Database = new System.Windows.Forms.Button();
            this.load_tables = new System.Windows.Forms.Button();
            this.databases = new System.Windows.Forms.ComboBox();
            this.tables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.queries = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.add_query = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_Database
            // 
            this.Load_Database.Location = new System.Drawing.Point(530, 30);
            this.Load_Database.Name = "Load_Database";
            this.Load_Database.Size = new System.Drawing.Size(119, 23);
            this.Load_Database.TabIndex = 0;
            this.Load_Database.Text = "Load Database";
            this.Load_Database.UseVisualStyleBackColor = true;
            this.Load_Database.Click += new System.EventHandler(this.button1_Click);
            // 
            // load_tables
            // 
            this.load_tables.Location = new System.Drawing.Point(530, 70);
            this.load_tables.Name = "load_tables";
            this.load_tables.Size = new System.Drawing.Size(119, 23);
            this.load_tables.TabIndex = 1;
            this.load_tables.Text = "Load Tables";
            this.load_tables.UseVisualStyleBackColor = true;
            this.load_tables.Click += new System.EventHandler(this.load_tables_Click);
            // 
            // databases
            // 
            this.databases.FormattingEnabled = true;
            this.databases.Location = new System.Drawing.Point(104, 31);
            this.databases.Name = "databases";
            this.databases.Size = new System.Drawing.Size(345, 21);
            this.databases.TabIndex = 2;
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(104, 71);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(345, 21);
            this.tables.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Queries";
            // 
            // queries
            // 
            this.queries.FormattingEnabled = true;
            this.queries.Location = new System.Drawing.Point(104, 113);
            this.queries.Name = "queries";
            this.queries.Size = new System.Drawing.Size(345, 21);
            this.queries.TabIndex = 7;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(530, 302);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(119, 23);
            this.Close.TabIndex = 8;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(104, 205);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 120);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(530, 205);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(119, 23);
            this.Execute.TabIndex = 10;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // add_query
            // 
            this.add_query.Location = new System.Drawing.Point(530, 113);
            this.add_query.Name = "add_query";
            this.add_query.Size = new System.Drawing.Size(119, 23);
            this.add_query.TabIndex = 11;
            this.add_query.Text = "Add Query";
            this.add_query.UseVisualStyleBackColor = true;
            this.add_query.Click += new System.EventHandler(this.add_query_Click);
            // 
            // Insert_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 337);
            this.Controls.Add(this.add_query);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.queries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.databases);
            this.Controls.Add(this.load_tables);
            this.Controls.Add(this.Load_Database);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insert_Data";
            this.Text = "Insert Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_Database;
        private System.Windows.Forms.Button load_tables;
        private System.Windows.Forms.ComboBox databases;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox queries;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button add_query;
    }
}