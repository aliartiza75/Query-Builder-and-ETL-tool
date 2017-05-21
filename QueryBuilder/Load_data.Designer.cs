namespace QueryBuilder
{
    partial class Load_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_data));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.directory_path = new System.Windows.Forms.TextBox();
            this.load_databases = new System.Windows.Forms.Button();
            this.load_files = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.select_data_source = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Source";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // directory_path
            // 
            this.directory_path.Location = new System.Drawing.Point(156, 112);
            this.directory_path.Name = "directory_path";
            this.directory_path.Size = new System.Drawing.Size(200, 20);
            this.directory_path.TabIndex = 3;
            // 
            // load_databases
            // 
            this.load_databases.Location = new System.Drawing.Point(443, 38);
            this.load_databases.Name = "load_databases";
            this.load_databases.Size = new System.Drawing.Size(106, 23);
            this.load_databases.TabIndex = 4;
            this.load_databases.Text = "Load Databases";
            this.load_databases.UseVisualStyleBackColor = true;
            this.load_databases.Click += new System.EventHandler(this.load_databases_Click);
            // 
            // load_files
            // 
            this.load_files.Location = new System.Drawing.Point(443, 74);
            this.load_files.Name = "load_files";
            this.load_files.Size = new System.Drawing.Size(106, 23);
            this.load_files.TabIndex = 5;
            this.load_files.Text = "Upload Data";
            this.load_files.UseVisualStyleBackColor = true;
            this.load_files.Click += new System.EventHandler(this.load_files_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(156, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(368, 213);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // select_data_source
            // 
            this.select_data_source.Location = new System.Drawing.Point(156, 73);
            this.select_data_source.Name = "select_data_source";
            this.select_data_source.Size = new System.Drawing.Size(200, 23);
            this.select_data_source.TabIndex = 8;
            this.select_data_source.Text = "Select Data Source";
            this.select_data_source.UseVisualStyleBackColor = true;
            this.select_data_source.Click += new System.EventHandler(this.select_data_source_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(443, 112);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(106, 23);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Load_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 420);
            this.Controls.Add(this.close);
            this.Controls.Add(this.select_data_source);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.load_files);
            this.Controls.Add(this.load_databases);
            this.Controls.Add(this.directory_path);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load_data";
            this.Text = "Data Staging";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox directory_path;
        private System.Windows.Forms.Button load_databases;
        private System.Windows.Forms.Button load_files;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button select_data_source;
        private System.Windows.Forms.Button close;
    }
}