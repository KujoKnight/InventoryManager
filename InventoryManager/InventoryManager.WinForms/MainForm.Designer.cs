namespace InventoryManager.WinForms
{
    partial class InventoryManager
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
            this.FileSearch = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(12, 15);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(26, 13);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "Filename", true));
            this.filenameTextBox.Location = new System.Drawing.Point(44, 11);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(512, 20);
            this.filenameTextBox.TabIndex = 1;
            // 
            // FileSearch
            // 
            this.FileSearch.Location = new System.Drawing.Point(562, 9);
            this.FileSearch.Name = "FileSearch";
            this.FileSearch.Size = new System.Drawing.Size(50, 25);
            this.FileSearch.TabIndex = 2;
            this.FileSearch.Text = "...";
            this.FileSearch.UseVisualStyleBackColor = true;
            this.FileSearch.Click += new System.EventHandler(this.FileSearch_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.FileSearch);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.FileLabel);
            this.Name = "InventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button FileSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

