namespace WinFormsFun
{
    partial class Interface
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
            this.browseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTextbox = new System.Windows.Forms.TextBox();
            this.imageGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertiesGroup = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.prop3Name = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.prop2Name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.prop1Name = new System.Windows.Forms.TextBox();
            this.propValue = new System.Windows.Forms.Label();
            this.propType = new System.Windows.Forms.Label();
            this.propName = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.nameTypeLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.imageGroup.SuspendLayout();
            this.propertiesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(112, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(64, 20);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem,
            this.windowedToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // windowedToolStripMenuItem
            // 
            this.windowedToolStripMenuItem.Name = "windowedToolStripMenuItem";
            this.windowedToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.windowedToolStripMenuItem.Text = "Windowed";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // imageTextbox
            // 
            this.imageTextbox.Location = new System.Drawing.Point(6, 19);
            this.imageTextbox.Name = "imageTextbox";
            this.imageTextbox.Size = new System.Drawing.Size(100, 20);
            this.imageTextbox.TabIndex = 4;
            // 
            // imageGroup
            // 
            this.imageGroup.Controls.Add(this.panel1);
            this.imageGroup.Controls.Add(this.imageTextbox);
            this.imageGroup.Controls.Add(this.browseButton);
            this.imageGroup.Location = new System.Drawing.Point(259, 27);
            this.imageGroup.Name = "imageGroup";
            this.imageGroup.Size = new System.Drawing.Size(322, 344);
            this.imageGroup.TabIndex = 5;
            this.imageGroup.TabStop = false;
            this.imageGroup.Text = "Image";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 292);
            this.panel1.TabIndex = 5;
            // 
            // propertiesGroup
            // 
            this.propertiesGroup.Controls.Add(this.nameTypeLabel);
            this.propertiesGroup.Controls.Add(this.nameTextBox);
            this.propertiesGroup.Controls.Add(this.itemName);
            this.propertiesGroup.Controls.Add(this.textBox6);
            this.propertiesGroup.Controls.Add(this.prop3Name);
            this.propertiesGroup.Controls.Add(this.comboBox3);
            this.propertiesGroup.Controls.Add(this.comboBox2);
            this.propertiesGroup.Controls.Add(this.textBox4);
            this.propertiesGroup.Controls.Add(this.prop2Name);
            this.propertiesGroup.Controls.Add(this.comboBox1);
            this.propertiesGroup.Controls.Add(this.textBox3);
            this.propertiesGroup.Controls.Add(this.prop1Name);
            this.propertiesGroup.Controls.Add(this.propValue);
            this.propertiesGroup.Controls.Add(this.propType);
            this.propertiesGroup.Controls.Add(this.propName);
            this.propertiesGroup.Location = new System.Drawing.Point(0, 27);
            this.propertiesGroup.Name = "propertiesGroup";
            this.propertiesGroup.Size = new System.Drawing.Size(253, 344);
            this.propertiesGroup.TabIndex = 6;
            this.propertiesGroup.TabStop = false;
            this.propertiesGroup.Text = "Properties";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(83, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(12, 45);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(58, 13);
            this.itemName.TabIndex = 13;
            this.itemName.Text = "Item Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(158, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(83, 20);
            this.textBox6.TabIndex = 11;
            // 
            // prop3Name
            // 
            this.prop3Name.Location = new System.Drawing.Point(10, 121);
            this.prop3Name.Name = "prop3Name";
            this.prop3Name.Size = new System.Drawing.Size(72, 20);
            this.prop3Name.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Text",
            "Numeric",
            "Boolean"});
            this.comboBox3.Location = new System.Drawing.Point(88, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Text",
            "Numeric",
            "Boolean"});
            this.comboBox2.Location = new System.Drawing.Point(88, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(64, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 20);
            this.textBox4.TabIndex = 7;
            // 
            // prop2Name
            // 
            this.prop2Name.Location = new System.Drawing.Point(10, 94);
            this.prop2Name.Name = "prop2Name";
            this.prop2Name.Size = new System.Drawing.Size(72, 20);
            this.prop2Name.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Text",
            "Numeric",
            "Boolean"});
            this.comboBox1.Location = new System.Drawing.Point(88, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 4;
            // 
            // prop1Name
            // 
            this.prop1Name.Location = new System.Drawing.Point(10, 68);
            this.prop1Name.Name = "prop1Name";
            this.prop1Name.Size = new System.Drawing.Size(72, 20);
            this.prop1Name.TabIndex = 3;
            this.prop1Name.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // propValue
            // 
            this.propValue.Location = new System.Drawing.Point(155, 20);
            this.propValue.Name = "propValue";
            this.propValue.Size = new System.Drawing.Size(48, 19);
            this.propValue.TabIndex = 2;
            this.propValue.Text = "Value";
            this.propValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propType
            // 
            this.propType.Location = new System.Drawing.Point(85, 20);
            this.propType.Name = "propType";
            this.propType.Size = new System.Drawing.Size(36, 19);
            this.propType.TabIndex = 1;
            this.propType.Text = "Type";
            this.propType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propName
            // 
            this.propName.Location = new System.Drawing.Point(12, 20);
            this.propName.Name = "propName";
            this.propName.Size = new System.Drawing.Size(36, 19);
            this.propName.TabIndex = 0;
            this.propName.Text = "Name";
            this.propName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTypeLabel
            // 
            this.nameTypeLabel.AutoSize = true;
            this.nameTypeLabel.Location = new System.Drawing.Point(85, 46);
            this.nameTypeLabel.Name = "nameTypeLabel";
            this.nameTypeLabel.Size = new System.Drawing.Size(28, 13);
            this.nameTypeLabel.TabIndex = 19;
            this.nameTypeLabel.Text = "Text";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 373);
            this.Controls.Add(this.propertiesGroup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imageGroup);
            this.Name = "Interface";
            this.Text = "Item Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.imageGroup.ResumeLayout(false);
            this.imageGroup.PerformLayout();
            this.propertiesGroup.ResumeLayout(false);
            this.propertiesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowedToolStripMenuItem;
        private System.Windows.Forms.TextBox imageTextbox;
        private System.Windows.Forms.GroupBox imageGroup;
        private System.Windows.Forms.GroupBox propertiesGroup;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox prop1Name;
        private System.Windows.Forms.Label propValue;
        private System.Windows.Forms.Label propType;
        private System.Windows.Forms.Label propName;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox prop3Name;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox prop2Name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameTypeLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

