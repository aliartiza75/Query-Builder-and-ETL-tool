namespace QueryBuilder
{
    partial class Load_data_in_schema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_data_in_schema));
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.source_databases = new System.Windows.Forms.ComboBox();
            this.source_tables = new System.Windows.Forms.ComboBox();
            this.target_databases = new System.Windows.Forms.ComboBox();
            this.Load_databases = new System.Windows.Forms.Button();
            this.start_loading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(467, 109);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(117, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target Database";
            // 
            // source_databases
            // 
            this.source_databases.FormattingEnabled = true;
            this.source_databases.Location = new System.Drawing.Point(197, 69);
            this.source_databases.Name = "source_databases";
            this.source_databases.Size = new System.Drawing.Size(190, 21);
            this.source_databases.TabIndex = 4;
            this.source_databases.SelectedIndexChanged += new System.EventHandler(this.source_databases_SelectedIndexChanged);
            // 
            // source_tables
            // 
            this.source_tables.FormattingEnabled = true;
            this.source_tables.Location = new System.Drawing.Point(197, 107);
            this.source_tables.Name = "source_tables";
            this.source_tables.Size = new System.Drawing.Size(190, 21);
            this.source_tables.TabIndex = 5;
            // 
            // target_databases
            // 
            this.target_databases.FormattingEnabled = true;
            this.target_databases.Location = new System.Drawing.Point(197, 144);
            this.target_databases.Name = "target_databases";
            this.target_databases.Size = new System.Drawing.Size(190, 21);
            this.target_databases.TabIndex = 6;
            // 
            // Load_databases
            // 
            this.Load_databases.Location = new System.Drawing.Point(467, 69);
            this.Load_databases.Name = "Load_databases";
            this.Load_databases.Size = new System.Drawing.Size(117, 23);
            this.Load_databases.TabIndex = 7;
            this.Load_databases.Text = "Load Databases";
            this.Load_databases.UseVisualStyleBackColor = true;
            this.Load_databases.Click += new System.EventHandler(this.Load_databases_Click);
            // 
            // start_loading
            // 
            this.start_loading.Location = new System.Drawing.Point(467, 144);
            this.start_loading.Name = "start_loading";
            this.start_loading.Size = new System.Drawing.Size(117, 23);
            this.start_loading.TabIndex = 8;
            this.start_loading.Text = "Start Loading";
            this.start_loading.UseVisualStyleBackColor = true;
            this.start_loading.Click += new System.EventHandler(this.start_loading_Click);
            // 
            // Load_data_in_schema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.start_loading);
            this.Controls.Add(this.Load_databases);
            this.Controls.Add(this.target_databases);
            this.Controls.Add(this.source_tables);
            this.Controls.Add(this.source_databases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load_data_in_schema";
            this.Text = "Load Data in Schema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox source_databases;
        private System.Windows.Forms.ComboBox source_tables;
        private System.Windows.Forms.ComboBox target_databases;
        private System.Windows.Forms.Button Load_databases;
        private System.Windows.Forms.Button start_loading;
    }
}