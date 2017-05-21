namespace QueryBuilder
{
    partial class Update_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Table));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.databases = new System.Windows.Forms.ComboBox();
            this.tables = new System.Windows.Forms.ComboBox();
            this.attributes_name = new System.Windows.Forms.ComboBox();
            this.new_value = new System.Windows.Forms.TextBox();
            this.load_database = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attribute Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attribute new value";
            // 
            // databases
            // 
            this.databases.FormattingEnabled = true;
            this.databases.Location = new System.Drawing.Point(168, 24);
            this.databases.Name = "databases";
            this.databases.Size = new System.Drawing.Size(273, 21);
            this.databases.TabIndex = 4;
            this.databases.SelectedIndexChanged += new System.EventHandler(this.Upload_tables);
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(168, 55);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(273, 21);
            this.tables.TabIndex = 5;
            this.tables.SelectedIndexChanged += new System.EventHandler(this.Choosen_Table);
            // 
            // attributes_name
            // 
            this.attributes_name.FormattingEnabled = true;
            this.attributes_name.Location = new System.Drawing.Point(168, 88);
            this.attributes_name.Name = "attributes_name";
            this.attributes_name.Size = new System.Drawing.Size(273, 21);
            this.attributes_name.TabIndex = 6;
            // 
            // new_value
            // 
            this.new_value.Location = new System.Drawing.Point(168, 120);
            this.new_value.Name = "new_value";
            this.new_value.Size = new System.Drawing.Size(273, 20);
            this.new_value.TabIndex = 7;
            // 
            // load_database
            // 
            this.load_database.Location = new System.Drawing.Point(564, 24);
            this.load_database.Name = "load_database";
            this.load_database.Size = new System.Drawing.Size(105, 23);
            this.load_database.TabIndex = 8;
            this.load_database.Text = "Load Database";
            this.load_database.UseVisualStyleBackColor = true;
            this.load_database.Click += new System.EventHandler(this.load_database_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(564, 54);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 23);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(168, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 68);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 181);
            this.dataGridView1.TabIndex = 11;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(564, 153);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(105, 23);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(564, 120);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "Clear Query";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(320, 155);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 20);
            this.value.TabIndex = 16;
            this.value.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "To choose record";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // Update_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 512);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.value);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.load_database);
            this.Controls.Add(this.new_value);
            this.Controls.Add(this.attributes_name);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.databases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_Table";
            this.Text = "Update Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox databases;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.ComboBox attributes_name;
        private System.Windows.Forms.TextBox new_value;
        private System.Windows.Forms.Button load_database;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}