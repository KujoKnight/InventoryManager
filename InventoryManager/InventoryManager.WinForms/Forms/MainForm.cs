using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;
using Newtonsoft.Json;

namespace InventoryManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                mainTabControl.Enabled = mIsWorldLoaded;
                saveToolStripMenuItem.Enabled = mIsWorldLoaded;
                saveAsToolStripMenuItem.Enabled = mIsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void AddPlayersButton_Click(object sender, System.EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {
                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    ViewModel.Players.Add(player);
                }
            }
        }

        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removePlayersButton.Enabled = playerListBox.SelectedItem != null;
        }
        private void RemovePlayersButton_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Players.Remove((Player)playerListBox.SelectedItem);
                playerListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item { Name = addItemForm.ItemName };
                    ViewModel.Items.Add(item);
                }
            }
        }
        private void itemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeItemButton.Enabled = itemListbox.SelectedItem != null;
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Items.Remove((Item)itemListbox.SelectedItem);
                itemListbox.SelectedItem = ViewModel.Items.FirstOrDefault();
            }
        }
        private void playerInvAddButton_Click(object sender, EventArgs e)
        {

        }
        private void playerInventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerInvRemoveButton.Enabled = playerInventoryListBox.SelectedItem != null;
        }

        private void playerInvRemoveButton_Click(object sender, EventArgs e)
        {
        }

        #region MainMenu
        private void openWorldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e) => ViewModel.SaveWorld();

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;

    }
}
