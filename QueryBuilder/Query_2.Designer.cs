namespace QueryBuilder
{
    partial class Query_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_2));
            this.Close = new System.Windows.Forms.Button();
            this.Load_Databases = new System.Windows.Forms.Button();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pestisides_names = new System.Windows.Forms.ComboBox();
            this.load_pestisides_names = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(460, 132);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(130, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Load_Databases
            // 
            this.Load_Databases.Location = new System.Drawing.Point(460, 46);
            this.Load_Databases.Name = "Load_Databases";
            this.Load_Databases.Size = new System.Drawing.Size(130, 23);
            this.Load_Databases.TabIndex = 1;
            this.Load_Databases.Text = "Load Databases";
            this.Load_Databases.UseVisualStyleBackColor = true;
            this.Load_Databases.Click += new System.EventHandler(this.Load_Databases_Click);
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(135, 45);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(220, 21);
            this.source_databases.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "What is the effect of pesticides on population of pests and predators?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Execute Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pestisides";
            // 
            // pestisides_names
            // 
            this.pestisides_names.FormattingEnabled = true;
            this.pestisides_names.Location = new System.Drawing.Point(135, 88);
            this.pestisides_names.Name = "pestisides_names";
            this.pestisides_names.Size = new System.Drawing.Size(220, 21);
            this.pestisides_names.TabIndex = 7;
            // 
            // load_pestisides_names
            // 
            this.load_pestisides_names.Location = new System.Drawing.Point(460, 87);
            this.load_pestisides_names.Name = "load_pestisides_names";
            this.load_pestisides_names.Size = new System.Drawing.Size(130, 23);
            this.load_pestisides_names.TabIndex = 8;
            this.load_pestisides_names.Text = "Load Pestisides Names";
            this.load_pestisides_names.UseVisualStyleBackColor = true;
            this.load_pestisides_names.Click += new System.EventHandler(this.load_pestisides_names_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 242);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Query_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 379);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.load_pestisides_names);
            this.Controls.Add(this.pestisides_names);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.Load_Databases);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query_2";
            this.Text = "Query # 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Load_Databases;
        private System.Windows.Forms.ComboBox source_databases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pestisides_names;
        private System.Windows.Forms.Button load_pestisides_names;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}