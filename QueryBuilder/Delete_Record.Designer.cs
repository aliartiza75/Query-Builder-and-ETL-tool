namespace QueryBuilder
{
    partial class Delete_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Record));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databases = new System.Windows.Forms.ComboBox();
            this.tables = new System.Windows.Forms.ComboBox();
            this.load_database = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tables";
            // 
            // databases
            // 
            this.databases.FormattingEnabled = true;
            this.databases.Location = new System.Drawing.Point(182, 25);
            this.databases.Name = "databases";
            this.databases.Size = new System.Drawing.Size(203, 21);
            this.databases.TabIndex = 2;
            this.databases.SelectedIndexChanged += new System.EventHandler(this.index_Changed);
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(182, 68);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(203, 21);
            this.tables.TabIndex = 3;
            this.tables.SelectedIndexChanged += new System.EventHandler(this.Load_Table_data);
            // 
            // load_database
            // 
            this.load_database.Location = new System.Drawing.Point(534, 28);
            this.load_database.Name = "load_database";
            this.load_database.Size = new System.Drawing.Size(117, 23);
            this.load_database.TabIndex = 4;
            this.load_database.Text = "Load Database";
            this.load_database.UseVisualStyleBackColor = true;
            this.load_database.Click += new System.EventHandler(this.load_database_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(534, 148);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(117, 23);
            this.close.TabIndex = 5;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Table Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(182, 110);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(95, 20);
            this.id.TabIndex = 9;
            this.id.Text = "Enter Parameter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(283, 110);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(102, 20);
            this.value.TabIndex = 11;
            this.value.Text = "Enter value";
            // 
            // Delete_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 375);
            this.Controls.Add(this.value);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.load_database);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.databases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_Record";
            this.Text = "Delete Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox databases;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Button load_database;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox value;
    }
}