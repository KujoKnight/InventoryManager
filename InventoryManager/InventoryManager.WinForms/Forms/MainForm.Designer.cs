namespace InventoryManager.WinForms.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.neighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.removeRoomButton = new System.Windows.Forms.Button();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomDescLabel = new System.Windows.Forms.Label();
            this.roomDescTextBox = new System.Windows.Forms.TextBox();
            this.roomNeighborGroupBox = new System.Windows.Forms.GroupBox();
            this.roomNeighborRemoveButton = new System.Windows.Forms.Button();
            this.roomNeighborListBox = new System.Windows.Forms.ListBox();
            this.neighborNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomNeighborAddButton = new System.Windows.Forms.Button();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.startingLocationCheckBox = new System.Windows.Forms.CheckBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMsgTextBox = new System.Windows.Forms.TextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.worldNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.roomNeighborGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighborNamesBindingSource)).BeginInit();
            this.playersTabPage.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // neighborsBindingSource
            // 
            this.neighborsBindingSource.DataMember = "Neighbors";
            this.neighborsBindingSource.DataSource = this.roomsBindingSource;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(832, 28);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.newWorldToolStripMenuItem.Text = "&New World";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.newWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.openWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World Files (*.json)|*.json";
            this.saveFileDialog.Title = "Save World File";
            // 
            // roomListBox
            // 
            this.roomListBox.DataSource = this.roomsBindingSource;
            this.roomListBox.DisplayMember = "Name";
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 16;
            this.roomListBox.Location = new System.Drawing.Point(5, 6);
            this.roomListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(156, 596);
            this.roomListBox.TabIndex = 0;
            this.roomListBox.ValueMember = "Description";
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.roomListBox_SelectedIndexChanged);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(5, 617);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // removeRoomButton
            // 
            this.removeRoomButton.Location = new System.Drawing.Point(87, 617);
            this.removeRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeRoomButton.Name = "removeRoomButton";
            this.removeRoomButton.Size = new System.Drawing.Size(75, 23);
            this.removeRoomButton.TabIndex = 2;
            this.removeRoomButton.Text = "&Delete";
            this.removeRoomButton.UseVisualStyleBackColor = true;
            this.removeRoomButton.Click += new System.EventHandler(this.removeRoomButton_Click);
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(169, 6);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(90, 17);
            this.roomNameLabel.TabIndex = 10;
            this.roomNameLabel.Text = "Room Name:";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Location = new System.Drawing.Point(173, 27);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(287, 22);
            this.roomNameTextBox.TabIndex = 11;
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Location = new System.Drawing.Point(169, 66);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(124, 17);
            this.roomDescLabel.TabIndex = 12;
            this.roomDescLabel.Text = "Room Description:";
            // 
            // roomDescTextBox
            // 
            this.roomDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescTextBox.Location = new System.Drawing.Point(173, 87);
            this.roomDescTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomDescTextBox.Name = "roomDescTextBox";
            this.roomDescTextBox.Size = new System.Drawing.Size(287, 22);
            this.roomDescTextBox.TabIndex = 13;
            // 
            // roomNeighborGroupBox
            // 
            this.roomNeighborGroupBox.Controls.Add(this.roomNeighborRemoveButton);
            this.roomNeighborGroupBox.Controls.Add(this.roomNeighborListBox);
            this.roomNeighborGroupBox.Controls.Add(this.roomNeighborAddButton);
            this.roomNeighborGroupBox.Location = new System.Drawing.Point(173, 162);
            this.roomNeighborGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNeighborGroupBox.Name = "roomNeighborGroupBox";
            this.roomNeighborGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.roomNeighborGroupBox.Size = new System.Drawing.Size(288, 403);
            this.roomNeighborGroupBox.TabIndex = 16;
            this.roomNeighborGroupBox.TabStop = false;
            this.roomNeighborGroupBox.Text = "Neighbors";
            // 
            // roomNeighborRemoveButton
            // 
            this.roomNeighborRemoveButton.Location = new System.Drawing.Point(166, 369);
            this.roomNeighborRemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomNeighborRemoveButton.Name = "roomNeighborRemoveButton";
            this.roomNeighborRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.roomNeighborRemoveButton.TabIndex = 18;
            this.roomNeighborRemoveButton.Text = "&Remove";
            this.roomNeighborRemoveButton.UseVisualStyleBackColor = true;
            this.roomNeighborRemoveButton.Click += new System.EventHandler(this.roomNeighborRemoveButton_Click);
            // 
            // roomNeighborListBox
            // 
            this.roomNeighborListBox.DataSource = this.neighborNamesBindingSource;
            this.roomNeighborListBox.DisplayMember = "Name";
            this.roomNeighborListBox.FormattingEnabled = true;
            this.roomNeighborListBox.ItemHeight = 16;
            this.roomNeighborListBox.Location = new System.Drawing.Point(8, 23);
            this.roomNeighborListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomNeighborListBox.Name = "roomNeighborListBox";
            this.roomNeighborListBox.Size = new System.Drawing.Size(271, 340);
            this.roomNeighborListBox.TabIndex = 0;
            this.roomNeighborListBox.ValueMember = "Name";
            this.roomNeighborListBox.SelectedIndexChanged += new System.EventHandler(this.roomNeighborListBox_SelectedIndexChanged);
            // 
            // neighborNamesBindingSource
            // 
            this.neighborNamesBindingSource.DataMember = "NeighborNames";
            this.neighborNamesBindingSource.DataSource = this.roomsBindingSource;
            // 
            // roomNeighborAddButton
            // 
            this.roomNeighborAddButton.Location = new System.Drawing.Point(45, 369);
            this.roomNeighborAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomNeighborAddButton.Name = "roomNeighborAddButton";
            this.roomNeighborAddButton.Size = new System.Drawing.Size(75, 23);
            this.roomNeighborAddButton.TabIndex = 17;
            this.roomNeighborAddButton.Text = "&Add...";
            this.roomNeighborAddButton.UseVisualStyleBackColor = true;
            this.roomNeighborAddButton.Click += new System.EventHandler(this.roomNeighborAddButton_Click);
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.startingLocationCheckBox);
            this.playersTabPage.Controls.Add(this.roomNeighborGroupBox);
            this.playersTabPage.Controls.Add(this.roomDescTextBox);
            this.playersTabPage.Controls.Add(this.roomDescLabel);
            this.playersTabPage.Controls.Add(this.roomNameTextBox);
            this.playersTabPage.Controls.Add(this.roomNameLabel);
            this.playersTabPage.Controls.Add(this.removeRoomButton);
            this.playersTabPage.Controls.Add(this.addRoomButton);
            this.playersTabPage.Controls.Add(this.roomListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersTabPage.Size = new System.Drawing.Size(789, 668);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Rooms";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // startingLocationCheckBox
            // 
            this.startingLocationCheckBox.AutoSize = true;
            this.startingLocationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.roomsBindingSource, "StartingLocation", true));
            this.startingLocationCheckBox.Location = new System.Drawing.Point(250, 125);
            this.startingLocationCheckBox.Name = "startingLocationCheckBox";
            this.startingLocationCheckBox.Size = new System.Drawing.Size(137, 21);
            this.startingLocationCheckBox.TabIndex = 17;
            this.startingLocationCheckBox.Text = "Starting Location";
            this.startingLocationCheckBox.UseVisualStyleBackColor = true;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(681, 9);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            this.welcomeMessageLabel.TabIndex = 7;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeMsgTextBox
            // 
            this.welcomeMsgTextBox.Location = new System.Drawing.Point(492, 29);
            this.welcomeMsgTextBox.Name = "welcomeMsgTextBox";
            this.welcomeMsgTextBox.Size = new System.Drawing.Size(320, 22);
            this.welcomeMsgTextBox.TabIndex = 6;
            this.welcomeMsgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.welcomeMsgTextBox.TextChanged += new System.EventHandler(this.welcomeMsgTextBox_TextChanged);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(19, 32);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(797, 697);
            this.mainTabControl.TabIndex = 3;
            // 
            // worldNameLabel
            // 
            this.worldNameLabel.AutoSize = true;
            this.worldNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.worldNameLabel.Location = new System.Drawing.Point(400, 735);
            this.worldNameLabel.Name = "worldNameLabel";
            this.worldNameLabel.Size = new System.Drawing.Size(112, 20);
            this.worldNameLabel.TabIndex = 5;
            this.worldNameLabel.Text = "World Name";
            this.worldNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 763);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.welcomeMsgTextBox);
            this.Controls.Add(this.worldNameLabel);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork World Builder";
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.roomNeighborGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neighborNamesBindingSource)).EndInit();
            this.playersTabPage.ResumeLayout(false);
            this.playersTabPage.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource neighborsBindingSource;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button removeRoomButton;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomDescLabel;
        private System.Windows.Forms.TextBox roomDescTextBox;
        private System.Windows.Forms.GroupBox roomNeighborGroupBox;
        private System.Windows.Forms.Button roomNeighborRemoveButton;
        private System.Windows.Forms.ListBox roomNeighborListBox;
        private System.Windows.Forms.Button roomNeighborAddButton;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.BindingSource neighborNamesBindingSource;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.Label worldNameLabel;
        private System.Windows.Forms.CheckBox startingLocationCheckBox;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.TextBox welcomeMsgTextBox;
    }
}

