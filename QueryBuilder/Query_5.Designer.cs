namespace QueryBuilder
{
    partial class Query_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_5));
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.district_tehsil = new System.Windows.Forms.ComboBox();
            this.mouza_town = new System.Windows.Forms.ComboBox();
            this.load_databases = new System.Windows.Forms.Button();
            this.load_district_tehsil = new System.Windows.Forms.Button();
            this.execute_query = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(499, 140);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(115, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "District / Tehsil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mouza / Town";
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(158, 50);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(261, 21);
            this.source_databases.TabIndex = 4;
            // 
            // district_tehsil
            // 
            this.district_tehsil.FormattingEnabled = true;
            this.district_tehsil.Location = new System.Drawing.Point(158, 93);
            this.district_tehsil.Name = "district_tehsil";
            this.district_tehsil.Size = new System.Drawing.Size(261, 21);
            this.district_tehsil.TabIndex = 5;
            this.district_tehsil.SelectedIndexChanged += new System.EventHandler(this.district_tehsil_SelectedIndexChanged);
            // 
            // mouza_town
            // 
            this.mouza_town.FormattingEnabled = true;
            this.mouza_town.Location = new System.Drawing.Point(158, 138);
            this.mouza_town.Name = "mouza_town";
            this.mouza_town.Size = new System.Drawing.Size(261, 21);
            this.mouza_town.TabIndex = 6;
            // 
            // load_databases
            // 
            this.load_databases.Location = new System.Drawing.Point(499, 50);
            this.load_databases.Name = "load_databases";
            this.load_databases.Size = new System.Drawing.Size(115, 23);
            this.load_databases.TabIndex = 7;
            this.load_databases.Text = "Load Databases";
            this.load_databases.UseVisualStyleBackColor = true;
            this.load_databases.Click += new System.EventHandler(this.load_databases_Click);
            // 
            // load_district_tehsil
            // 
            this.load_district_tehsil.Location = new System.Drawing.Point(499, 94);
            this.load_district_tehsil.Name = "load_district_tehsil";
            this.load_district_tehsil.Size = new System.Drawing.Size(115, 23);
            this.load_district_tehsil.TabIndex = 8;
            this.load_district_tehsil.Text = "Load District / Tehsil";
            this.load_district_tehsil.UseVisualStyleBackColor = true;
            this.load_district_tehsil.Click += new System.EventHandler(this.load_district_tehsil_Click);
            // 
            // execute_query
            // 
            this.execute_query.Location = new System.Drawing.Point(499, 196);
            this.execute_query.Name = "execute_query";
            this.execute_query.Size = new System.Drawing.Size(115, 23);
            this.execute_query.TabIndex = 9;
            this.execute_query.Text = "Execute Query";
            this.execute_query.UseVisualStyleBackColor = true;
            this.execute_query.Click += new System.EventHandler(this.execute_query_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(158, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Query_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 363);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.execute_query);
            this.Controls.Add(this.load_district_tehsil);
            this.Controls.Add(this.load_databases);
            this.Controls.Add(this.mouza_town);
            this.Controls.Add(this.district_tehsil);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query_5";
            this.Text = "Query # 5";
            this.Load += new System.EventHandler(this.Query_5_Load);
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
        private System.Windows.Forms.Button load_databases;
        private System.Windows.Forms.Button load_district_tehsil;
        private System.Windows.Forms.Button execute_query;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}