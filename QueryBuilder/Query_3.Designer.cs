namespace QueryBuilder
{
    partial class Query_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_3));
            this.Close = new System.Windows.Forms.Button();
            this.load_databases = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.TextBox();
            this.Execute_Query = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.range = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(336, 113);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(106, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // load_databases
            // 
            this.load_databases.Location = new System.Drawing.Point(336, 64);
            this.load_databases.Name = "load_databases";
            this.load_databases.Size = new System.Drawing.Size(106, 23);
            this.load_databases.TabIndex = 1;
            this.load_databases.Text = "Load Databases";
            this.load_databases.UseVisualStyleBackColor = true;
            this.load_databases.Click += new System.EventHandler(this.load_databases_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Databases";
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(104, 64);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(186, 21);
            this.source_databases.TabIndex = 3;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(104, 115);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(110, 20);
            this.year.TabIndex = 4;
            // 
            // Execute_Query
            // 
            this.Execute_Query.Location = new System.Drawing.Point(336, 163);
            this.Execute_Query.Name = "Execute_Query";
            this.Execute_Query.Size = new System.Drawing.Size(106, 23);
            this.Execute_Query.TabIndex = 5;
            this.Execute_Query.Text = "Execute Query";
            this.Execute_Query.UseVisualStyleBackColor = true;
            this.Execute_Query.Click += new System.EventHandler(this.Execute_Query_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(104, 267);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Range";
            // 
            // range
            // 
            this.range.Location = new System.Drawing.Point(104, 163);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(110, 20);
            this.range.TabIndex = 9;
            // 
            // Query_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this.range);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Execute_Query);
            this.Controls.Add(this.year);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_databases);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query_3";
            this.Text = "Query # 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button load_databases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox source_databases;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button Execute_Query;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox range;
    }
}