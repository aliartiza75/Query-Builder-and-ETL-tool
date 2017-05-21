namespace QueryBuilder
{
    partial class Query_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_1));
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.Load_databases = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.pest_populations = new System.Windows.Forms.ComboBox();
            this.threshold_value = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(467, 100);
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
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a population of Pest against which you wanna know which pestiside is effec" +
    "tive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Which group of pesticide is effective against certain group of pests?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Execute Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Databases";
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(29, 58);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(198, 21);
            this.source_databases.TabIndex = 5;
            // 
            // Load_databases
            // 
            this.Load_databases.Location = new System.Drawing.Point(467, 58);
            this.Load_databases.Name = "Load_databases";
            this.Load_databases.Size = new System.Drawing.Size(109, 23);
            this.Load_databases.TabIndex = 6;
            this.Load_databases.Text = "Load Databases";
            this.Load_databases.UseVisualStyleBackColor = true;
            this.Load_databases.Click += new System.EventHandler(this.Load_databases_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(547, 150);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_text});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_text
            // 
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(0, 17);
            // 
            // pest_populations
            // 
            this.pest_populations.FormattingEnabled = true;
            this.pest_populations.Location = new System.Drawing.Point(28, 102);
            this.pest_populations.Name = "pest_populations";
            this.pest_populations.Size = new System.Drawing.Size(199, 21);
            this.pest_populations.TabIndex = 13;
            // 
            // threshold_value
            // 
            this.threshold_value.Location = new System.Drawing.Point(116, 140);
            this.threshold_value.Name = "threshold_value";
            this.threshold_value.Size = new System.Drawing.Size(111, 20);
            this.threshold_value.TabIndex = 11;
            // 
            // Query_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 372);
            this.Controls.Add(this.pest_populations);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.threshold_value);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Load_databases);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query_1";
            this.Text = "Query # 1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox source_databases;
        private System.Windows.Forms.Button Load_databases;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_text;
        private System.Windows.Forms.ComboBox pest_populations;
        private System.Windows.Forms.TextBox threshold_value;
    }
}