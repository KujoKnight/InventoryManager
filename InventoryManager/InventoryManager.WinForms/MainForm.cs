﻿using System.IO;
using System.Windows.Forms;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;
using Newtonsoft.Json;

namespace InventoryManager.WinForms
{
    public partial class InventoryManager : Form
    {
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set => mViewModel = value;
        }

        public InventoryManager()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void FileSearch_Click(object sender, System.EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                //filenameTextBox.Text = openFileDialog.FileName;
            }
        }

        private WorldViewModel mViewModel;
    }
}