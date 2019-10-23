namespace InventoryManager.WinForms
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
            this.FileLabel = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FileSearch = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.removePlayersButton = new System.Windows.Forms.Button();
            this.addPlayersButton = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.playersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.worldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).BeginInit();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(16, 18);
            this.FileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(34, 17);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "Filename", true));
            this.filenameTextBox.Location = new System.Drawing.Point(59, 14);
            this.filenameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(681, 22);
            this.filenameTextBox.TabIndex = 1;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // FileSearch
            // 
            this.FileSearch.Location = new System.Drawing.Point(749, 11);
            this.FileSearch.Margin = new System.Windows.Forms.Padding(4);
            this.FileSearch.Name = "FileSearch";
            this.FileSearch.Size = new System.Drawing.Size(67, 31);
            this.FileSearch.TabIndex = 2;
            this.FileSearch.Text = "...";
            this.FileSearch.UseVisualStyleBackColor = true;
            this.FileSearch.Click += new System.EventHandler(this.FileSearch_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(19, 43);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(797, 685);
            this.mainTabControl.TabIndex = 3;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.removePlayersButton);
            this.playersTabPage.Controls.Add(this.addPlayersButton);
            this.playersTabPage.Controls.Add(this.playerListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersTabPage.Size = new System.Drawing.Size(789, 656);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // removePlayersButton
            // 
            this.removePlayersButton.Location = new System.Drawing.Point(87, 617);
            this.removePlayersButton.Name = "removePlayersButton";
            this.removePlayersButton.Size = new System.Drawing.Size(75, 23);
            this.removePlayersButton.TabIndex = 2;
            this.removePlayersButton.Text = "&Remove";
            this.removePlayersButton.UseVisualStyleBackColor = true;
            // 
            // addPlayersButton
            // 
            this.addPlayersButton.Location = new System.Drawing.Point(6, 617);
            this.addPlayersButton.Name = "addPlayersButton";
            this.addPlayersButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayersButton.TabIndex = 1;
            this.addPlayersButton.Text = "&Add...";
            this.addPlayersButton.UseVisualStyleBackColor = true;
            // 
            // playerListBox
            // 
            this.playerListBox.DataSource = this.playersBindingSource2;
            this.playerListBox.DisplayMember = "Name";
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 16;
            this.playerListBox.Location = new System.Drawing.Point(6, 6);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(156, 596);
            this.playerListBox.TabIndex = 0;
            this.playerListBox.ValueMember = "Health";
            // 
            // playersBindingSource2
            // 
            this.playersBindingSource2.DataMember = "Players";
            this.playersBindingSource2.DataSource = this.worldBindingSource;
            // 
            // worldBindingSource
            // 
            this.worldBindingSource.DataMember = "World";
            this.worldBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.button1);
            this.itemsTabPage.Controls.Add(this.button2);
            this.itemsTabPage.Controls.Add(this.listBox1);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(789, 656);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldBindingSource;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "Players";
            this.playersBindingSource1.DataSource = this.worldBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Add...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.itemsBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 596);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 740);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.FileSearch);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.FileLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).EndInit();
            this.itemsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button FileSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.Button removePlayersButton;
        private System.Windows.Forms.Button addPlayersButton;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.BindingSource worldBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private System.Windows.Forms.BindingSource playersBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}

