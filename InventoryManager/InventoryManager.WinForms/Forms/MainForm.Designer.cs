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
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.playerHealthTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.removePlayersButton = new System.Windows.Forms.Button();
            this.addPlayersButton = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemValueTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemValueLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(14, 26);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(598, 566);
            this.mainTabControl.TabIndex = 3;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.playerScoreTextBox);
            this.playersTabPage.Controls.Add(this.playerScoreLabel);
            this.playersTabPage.Controls.Add(this.playerHealthTextBox);
            this.playersTabPage.Controls.Add(this.playerHealthLabel);
            this.playersTabPage.Controls.Add(this.playerNameTextBox);
            this.playersTabPage.Controls.Add(this.playerNameLabel);
            this.playersTabPage.Controls.Add(this.removePlayersButton);
            this.playersTabPage.Controls.Add(this.addPlayersButton);
            this.playersTabPage.Controls.Add(this.playerListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 22);
            this.playersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.playersTabPage.Size = new System.Drawing.Size(590, 540);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Score", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerScoreTextBox.Location = new System.Drawing.Point(130, 120);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(70, 20);
            this.playerScoreTextBox.TabIndex = 15;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(127, 103);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(70, 13);
            this.playerScoreLabel.TabIndex = 14;
            this.playerScoreLabel.Text = "Player Score:";
            // 
            // playerHealthTextBox
            // 
            this.playerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerHealthTextBox.Location = new System.Drawing.Point(130, 71);
            this.playerHealthTextBox.Name = "playerHealthTextBox";
            this.playerHealthTextBox.Size = new System.Drawing.Size(70, 20);
            this.playerHealthTextBox.TabIndex = 13;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(127, 54);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(73, 13);
            this.playerHealthLabel.TabIndex = 12;
            this.playerHealthLabel.Text = "Player Health:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerNameTextBox.Location = new System.Drawing.Point(130, 22);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.playerNameTextBox.TabIndex = 11;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(127, 5);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(70, 13);
            this.playerNameLabel.TabIndex = 10;
            this.playerNameLabel.Text = "Player Name:";
            // 
            // removePlayersButton
            // 
            this.removePlayersButton.Location = new System.Drawing.Point(65, 501);
            this.removePlayersButton.Margin = new System.Windows.Forms.Padding(2);
            this.removePlayersButton.Name = "removePlayersButton";
            this.removePlayersButton.Size = new System.Drawing.Size(56, 19);
            this.removePlayersButton.TabIndex = 2;
            this.removePlayersButton.Text = "&Delete";
            this.removePlayersButton.UseVisualStyleBackColor = true;
            this.removePlayersButton.Click += new System.EventHandler(this.RemovePlayersButton_Click);
            // 
            // addPlayersButton
            // 
            this.addPlayersButton.Location = new System.Drawing.Point(4, 501);
            this.addPlayersButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPlayersButton.Name = "addPlayersButton";
            this.addPlayersButton.Size = new System.Drawing.Size(56, 19);
            this.addPlayersButton.TabIndex = 1;
            this.addPlayersButton.Text = "&Add...";
            this.addPlayersButton.UseVisualStyleBackColor = true;
            this.addPlayersButton.Click += new System.EventHandler(this.AddPlayersButton_Click);
            // 
            // playerListBox
            // 
            this.playerListBox.DataSource = this.playersBindingSource;
            this.playerListBox.DisplayMember = "Name";
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(4, 5);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(118, 485);
            this.playerListBox.TabIndex = 0;
            this.playerListBox.ValueMember = "Name";
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox_SelectedIndexChanged);
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemValueTextBox);
            this.itemsTabPage.Controls.Add(this.itemValueLabel);
            this.itemsTabPage.Controls.Add(this.itemNameTextBox);
            this.itemsTabPage.Controls.Add(this.itemNameLabel);
            this.itemsTabPage.Controls.Add(this.removeItemButton);
            this.itemsTabPage.Controls.Add(this.addItemButton);
            this.itemsTabPage.Controls.Add(this.itemListbox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.itemsTabPage.Size = new System.Drawing.Size(590, 540);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemValueTextBox
            // 
            this.itemValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemValueTextBox.Location = new System.Drawing.Point(131, 72);
            this.itemValueTextBox.Name = "itemValueTextBox";
            this.itemValueTextBox.Size = new System.Drawing.Size(407, 20);
            this.itemValueTextBox.TabIndex = 9;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemValueLabel
            // 
            this.itemValueLabel.AutoSize = true;
            this.itemValueLabel.Location = new System.Drawing.Point(128, 55);
            this.itemValueLabel.Name = "itemValueLabel";
            this.itemValueLabel.Size = new System.Drawing.Size(60, 13);
            this.itemValueLabel.TabIndex = 8;
            this.itemValueLabel.Text = "Item Value:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemNameTextBox.Location = new System.Drawing.Point(131, 23);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(407, 20);
            this.itemNameTextBox.TabIndex = 7;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(128, 6);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 6;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(65, 501);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(56, 19);
            this.removeItemButton.TabIndex = 5;
            this.removeItemButton.Text = "&Delete";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(4, 501);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(56, 19);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "&Add...";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // itemListbox
            // 
            this.itemListbox.DataSource = this.itemsBindingSource;
            this.itemListbox.DisplayMember = "Name";
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(4, 5);
            this.itemListbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(118, 485);
            this.itemListbox.TabIndex = 3;
            this.itemListbox.ValueMember = "Name";
            this.itemListbox.SelectedIndexChanged += new System.EventHandler(this.itemListbox_SelectedIndexChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(624, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.openWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World Files (*.json)|*.json";
            this.saveFileDialog.Title = "Save World File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            this.playersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.Button removePlayersButton;
        private System.Windows.Forms.Button addPlayersButton;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.TextBox itemValueTextBox;
        private System.Windows.Forms.Label itemValueLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox playerHealthTextBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}

