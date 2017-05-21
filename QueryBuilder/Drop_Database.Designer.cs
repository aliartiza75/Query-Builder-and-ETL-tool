namespace QueryBuilder
{
    partial class Drop_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drop_Database));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Database_names = new System.Windows.Forms.Label();
            this.database_drop = new System.Windows.Forms.Label();
            this.dropp_database = new System.Windows.Forms.TextBox();
            this.databases_name = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.database_ddrop = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // Database_names
            // 
            this.Database_names.AutoSize = true;
            this.Database_names.Location = new System.Drawing.Point(28, 51);
            this.Database_names.Name = "Database_names";
            this.Database_names.Size = new System.Drawing.Size(53, 13);
            this.Database_names.TabIndex = 1;
            this.Database_names.Text = "Database";
            // 
            // database_drop
            // 
            this.database_drop.AutoSize = true;
            this.database_drop.Location = new System.Drawing.Point(28, 85);
            this.database_drop.Name = "database_drop";
            this.database_drop.Size = new System.Drawing.Size(79, 13);
            this.database_drop.TabIndex = 2;
            this.database_drop.Text = "Drop Database";
            // 
            // dropp_database
            // 
            this.dropp_database.Location = new System.Drawing.Point(150, 80);
            this.dropp_database.Name = "dropp_database";
            this.dropp_database.Size = new System.Drawing.Size(211, 20);
            this.dropp_database.TabIndex = 3;
            // 
            // databases_name
            // 
            this.databases_name.FormattingEnabled = true;
            this.databases_name.Location = new System.Drawing.Point(150, 46);
            this.databases_name.Name = "databases_name";
            this.databases_name.Size = new System.Drawing.Size(211, 21);
            this.databases_name.TabIndex = 4;
            this.databases_name.SelectedIndexChanged += new System.EventHandler(this.databases_name_SelectedIndexChanged);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(419, 46);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(98, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Load Database";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // database_ddrop
            // 
            this.database_ddrop.Location = new System.Drawing.Point(419, 80);
            this.database_ddrop.Name = "database_ddrop";
            this.database_ddrop.Size = new System.Drawing.Size(98, 23);
            this.database_ddrop.TabIndex = 6;
            this.database_ddrop.Text = "Drop Database";
            this.database_ddrop.UseVisualStyleBackColor = true;
            this.database_ddrop.Click += new System.EventHandler(this.database_ddrop_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(419, 114);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(98, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(419, 148);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(98, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Drop_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.database_ddrop);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.databases_name);
            this.Controls.Add(this.dropp_database);
            this.Controls.Add(this.database_drop);
            this.Controls.Add(this.Database_names);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drop_Database";
            this.Text = "Drop Database";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Label Database_names;
        private System.Windows.Forms.Label database_drop;
        private System.Windows.Forms.TextBox dropp_database;
        private System.Windows.Forms.ComboBox databases_name;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button database_ddrop;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button close;
    }
}