namespace QueryBuilder
{
    partial class Transformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transformation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databases = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tables = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.start_transformation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.target_database = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Source";
            // 
            // databases
            // 
            this.databases.FormattingEnabled = true;
            this.databases.Location = new System.Drawing.Point(156, 55);
            this.databases.Name = "databases";
            this.databases.Size = new System.Drawing.Size(175, 21);
            this.databases.TabIndex = 2;
            this.databases.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Databases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(156, 101);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(175, 21);
            this.tables.TabIndex = 4;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(403, 101);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(120, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(131, 264);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // start_transformation
            // 
            this.start_transformation.Location = new System.Drawing.Point(403, 148);
            this.start_transformation.Name = "start_transformation";
            this.start_transformation.Size = new System.Drawing.Size(120, 23);
            this.start_transformation.TabIndex = 7;
            this.start_transformation.Text = "Start Transformation";
            this.start_transformation.UseVisualStyleBackColor = true;
            this.start_transformation.Click += new System.EventHandler(this.start_transformation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Target Database";
            // 
            // target_database
            // 
            this.target_database.FormattingEnabled = true;
            this.target_database.Location = new System.Drawing.Point(156, 148);
            this.target_database.Name = "target_database";
            this.target_database.Size = new System.Drawing.Size(175, 21);
            this.target_database.TabIndex = 9;
            // 
            // Transformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 421);
            this.Controls.Add(this.target_database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_transformation);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.databases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transformation";
            this.Text = "Transformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox databases;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button start_transformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox target_database;
    }
}