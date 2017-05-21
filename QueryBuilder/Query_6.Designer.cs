namespace QueryBuilder
{
    partial class Query_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_6));
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.load_databases = new System.Windows.Forms.Button();
            this.new_year = new System.Windows.Forms.ComboBox();
            this.previous_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.execute_query = new System.Windows.Forms.Button();
            this.load_year = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(525, 95);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Databases";
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(124, 45);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(253, 21);
            this.source_databases.TabIndex = 2;
            // 
            // load_databases
            // 
            this.load_databases.Location = new System.Drawing.Point(525, 45);
            this.load_databases.Name = "load_databases";
            this.load_databases.Size = new System.Drawing.Size(109, 23);
            this.load_databases.TabIndex = 3;
            this.load_databases.Text = "Load Databases";
            this.load_databases.UseVisualStyleBackColor = true;
            this.load_databases.Click += new System.EventHandler(this.load_databases_Click);
            // 
            // new_year
            // 
            this.new_year.FormattingEnabled = true;
            this.new_year.Location = new System.Drawing.Point(124, 149);
            this.new_year.Name = "new_year";
            this.new_year.Size = new System.Drawing.Size(253, 21);
            this.new_year.TabIndex = 4;
            // 
            // previous_year
            // 
            this.previous_year.FormattingEnabled = true;
            this.previous_year.Location = new System.Drawing.Point(124, 95);
            this.previous_year.Name = "previous_year";
            this.previous_year.Size = new System.Drawing.Size(253, 21);
            this.previous_year.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Previous Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Year";
            // 
            // execute_query
            // 
            this.execute_query.Location = new System.Drawing.Point(525, 195);
            this.execute_query.Name = "execute_query";
            this.execute_query.Size = new System.Drawing.Size(109, 23);
            this.execute_query.TabIndex = 8;
            this.execute_query.Text = "Execute Query";
            this.execute_query.UseVisualStyleBackColor = true;
            this.execute_query.Click += new System.EventHandler(this.execute_query_Click);
            // 
            // load_year
            // 
            this.load_year.Location = new System.Drawing.Point(525, 146);
            this.load_year.Name = "load_year";
            this.load_year.Size = new System.Drawing.Size(109, 23);
            this.load_year.TabIndex = 9;
            this.load_year.Text = "Load Year";
            this.load_year.UseVisualStyleBackColor = true;
            this.load_year.Click += new System.EventHandler(this.load_year_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(124, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(397, 132);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Query_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 383);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.load_year);
            this.Controls.Add(this.execute_query);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.previous_year);
            this.Controls.Add(this.new_year);
            this.Controls.Add(this.load_databases);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query_6";
            this.Text = "Query # 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox source_databases;
        private System.Windows.Forms.Button load_databases;
        private System.Windows.Forms.ComboBox new_year;
        private System.Windows.Forms.ComboBox previous_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button execute_query;
        private System.Windows.Forms.Button load_year;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}