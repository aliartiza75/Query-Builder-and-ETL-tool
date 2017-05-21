namespace QueryBuilder
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataInSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.dropToolStripMenuItem,
            this.tableOperationToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.tableToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // dropToolStripMenuItem
            // 
            this.dropToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem1,
            this.tableToolStripMenuItem1});
            this.dropToolStripMenuItem.Name = "dropToolStripMenuItem";
            this.dropToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dropToolStripMenuItem.Text = "Drop";
            // 
            // databaseToolStripMenuItem1
            // 
            this.databaseToolStripMenuItem1.Name = "databaseToolStripMenuItem1";
            this.databaseToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem1.Text = "Database";
            this.databaseToolStripMenuItem1.Click += new System.EventHandler(this.databaseToolStripMenuItem1_Click);
            // 
            // tableToolStripMenuItem1
            // 
            this.tableToolStripMenuItem1.Name = "tableToolStripMenuItem1";
            this.tableToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.tableToolStripMenuItem1.Text = "Table";
            this.tableToolStripMenuItem1.Click += new System.EventHandler(this.tableToolStripMenuItem1_Click);
            // 
            // tableOperationToolStripMenuItem
            // 
            this.tableOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.alterToolStripMenuItem});
            this.tableOperationToolStripMenuItem.Name = "tableOperationToolStripMenuItem";
            this.tableOperationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tableOperationToolStripMenuItem.Text = "Table Operation";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // alterToolStripMenuItem
            // 
            this.alterToolStripMenuItem.Name = "alterToolStripMenuItem";
            this.alterToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.alterToolStripMenuItem.Text = "Update";
            this.alterToolStripMenuItem.Click += new System.EventHandler(this.alterToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractLoadToolStripMenuItem,
            this.transformationToolStripMenuItem,
            this.loadDataInSchemaToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadToolStripMenuItem.Text = "ETL Tools";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // extractLoadToolStripMenuItem
            // 
            this.extractLoadToolStripMenuItem.Name = "extractLoadToolStripMenuItem";
            this.extractLoadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.extractLoadToolStripMenuItem.Text = "Data Staging";
            this.extractLoadToolStripMenuItem.Click += new System.EventHandler(this.extractLoadToolStripMenuItem_Click);
            // 
            // transformationToolStripMenuItem
            // 
            this.transformationToolStripMenuItem.Name = "transformationToolStripMenuItem";
            this.transformationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.transformationToolStripMenuItem.Text = "Data Transformation";
            this.transformationToolStripMenuItem.Click += new System.EventHandler(this.transformationToolStripMenuItem_Click);
            // 
            // loadDataInSchemaToolStripMenuItem
            // 
            this.loadDataInSchemaToolStripMenuItem.Name = "loadDataInSchemaToolStripMenuItem";
            this.loadDataInSchemaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loadDataInSchemaToolStripMenuItem.Text = "Load Data in Schema";
            this.loadDataInSchemaToolStripMenuItem.Click += new System.EventHandler(this.loadDataInSchemaToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem,
            this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem,
            this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem,
            this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem,
            this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem,
            this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem
            // 
            this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem.Name = "whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem";
            this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem.Size = new System.Drawing.Size(476, 22);
            this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem.Text = "Which group of pesticide is effective against certain group of pests?";
            this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem.Click += new System.EventHandler(this.whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem_Click);
            // 
            // whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem
            // 
            this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem.Name = "whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem";
            this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem.Size = new System.Drawing.Size(476, 22);
            this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem.Text = "What is the effect of predators on pest population?";
            this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem.Click += new System.EventHandler(this.whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem_Click);
            // 
            // whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem
            // 
            this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem.Name = "whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem";
            this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem.Size = new System.Drawing.Size(476, 22);
            this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem.Text = "Which pests have been dominant in the last X years?";
            this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem.Click += new System.EventHandler(this.whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem_Click);
            // 
            // whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem
            // 
            this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem.Name = "whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem";
            this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem.Size = new System.Drawing.Size(476, 22);
            this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem.Text = "Which pesticides are commonly used in a specific area?";
            this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem.Click += new System.EventHandler(this.whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem_Click);
            // 
            // whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem
            // 
            this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem.Name = "whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem" +
    "";
            this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem.Size = new System.Drawing.Size(476, 22);
            this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem.Text = "What are the major varieties being sowed in different agro-ecological zones?";
            this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem.Click += new System.EventHandler(this.whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(131, 274);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 274);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem
            // 
            this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem.Name = "whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem";
            this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem.Size = new System.Drawing.Size(476, 22);
            this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem.Text = "What is the effect on pest population as regards to sowing date?";
            this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem.Click += new System.EventHandler(this.whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem tableOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataInSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whichGroupOfPesticideIsEffectiveAgainstCertainGroupOfPestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatIsTheEffectOfPredatorsOnPestPopulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whichPestsHaveBeenDominantInTheLastXYearsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whichPesticidesAreCommonlyUsedInASpecificAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatAreTheMajorVarietiesBeingSowedInDifferentAgroecologicalZonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatIsTheEffectOnPestPopulationAsRegardsToSowingDateToolStripMenuItem;
    }
}