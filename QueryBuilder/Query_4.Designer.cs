namespace QueryBuilder
{
    partial class Query_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_4));
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.district_tehsil = new System.Windows.Forms.ComboBox();
            this.mouza_town = new System.Windows.Forms.ComboBox();
            this.Load_databases = new System.Windows.Forms.Button();
            this.district_tehsilll = new System.Windows.Forms.Button();
            this.execute_query = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(517, 116);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(121, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "District / Tehsil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mouza / Town";
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(133, 40);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(314, 21);
            this.source_databases.TabIndex = 4;
            // 
            // district_tehsil
            // 
            this.district_tehsil.FormattingEnabled = true;
            this.district_tehsil.Location = new System.Drawing.Point(133, 77);
            this.district_tehsil.Name = "district_tehsil";
            this.district_tehsil.Size = new System.Drawing.Size(314, 21);
            this.district_tehsil.TabIndex = 5;
            this.district_tehsil.SelectedIndexChanged += new System.EventHandler(this.district_tehsil_SelectedIndexChanged);
            // 
            // mouza_town
            // 
            this.mouza_town.FormattingEnabled = true;
            this.mouza_town.Location = new System.Drawing.Point(133, 116);
            this.mouza_town.Name = "mouza_town";
            this.mouza_town.Size = new System.Drawing.Size(314, 21);
            this.mouza_town.TabIndex = 6;
            // 
            // Load_databases
            // 
            this.Load_databases.Location = new System.Drawing.Point(517, 41);
            this.Load_databases.Name = "Load_databases";
            this.Load_databases.Size = new System.Drawing.Size(121, 23);
            this.Load_databases.TabIndex = 7;
            this.Load_databases.Text = "Load Databases";
            this.Load_databases.UseVisualStyleBackColor = true;
            this.Load_databases.Click += new System.EventHandler(this.Load_databases_Click);
            // 
            // district_tehsilll
            // 
            this.district_tehsilll.Location = new System.Drawing.Point(517, 77);
            this.district_tehsilll.Name = "district_tehsilll";
            this.district_tehsilll.Size = new System.Drawing.Size(121, 23);
            this.district_tehsilll.TabIndex = 8;
            this.district_tehsilll.Text = "Load Districts / Tehsil";
            this.district_tehsilll.UseVisualStyleBackColor = true;
            this.district_tehsilll.Click += new System.EventHandler(this.district_tehsilll_Click);
            // 
            // execute_query
            // 
            this.execute_query.Location = new System.Drawing.Point(517, 158);
            this.execute_query.Name = "execute_query";
            this.execute_query.Size = new System.Drawing.Size(121, 23);
            this.execute_query.TabIndex = 9;
            this.execute_query.Text = "Execute Query";
            this.execute_query.UseVisualStyleBackColor = true;
            this.execute_query.Click += new System.EventHandler(this.execute_query_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(133, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 121);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Query_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 397);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.execute_query);
            this.Controls.Add(this.district_tehsilll);
            this.Controls.Add(this.Load_databases);
            this.Controls.Add(this.mouza_town);
            this.Controls.Add(this.district_tehsil);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query_4";
            this.Text = "Query # 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox source_databases;
        private System.Windows.Forms.ComboBox district_tehsil;
        private System.Windows.Forms.ComboBox mouza_town;
        private System.Windows.Forms.Button Load_databases;
        private System.Windows.Forms.Button district_tehsilll;
        private System.Windows.Forms.Button execute_query;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}