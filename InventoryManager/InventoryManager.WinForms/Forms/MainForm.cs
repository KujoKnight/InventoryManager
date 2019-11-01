using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

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
                welcomeMsgTextBox.Enabled = mIsWorldLoaded;
            }
        }

        private bool createdNewFile { get; set; }

        public MainForm()
        {
            if(!Directory.Exists(Directory.GetCurrentDirectory() + "/WorldFiles/"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/WorldFiles/");
            }
            InitializeComponent();
            ViewModel = new WorldViewModel();
            worldNameLabel.Text = "";
            IsWorldLoaded = false;
            createdNewFile = false;
        }
        private void welcomeMsgTextBox_TextChanged(object sender, EventArgs e)
        {
            
            ViewModel.Message =  welcomeMsgTextBox.Text;
        }

        #region MainMenu

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Please input the name for this world", "Create New World", "", -1, -1);

            if (input != null)
            {
                ViewModel.World = new World();
                ViewModel.Filename = "WorldFiles/" + input + ".json";
                worldNameLabel.Text = "World: " + input;
                IsWorldLoaded = true;
                createdNewFile = true;
            }
        }
        private void openWorldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                worldNameLabel.Text = "World: " + Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                IsWorldLoaded = true;
                createdNewFile = false;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e) => ViewModel.SaveWorld(createdNewFile);

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(ViewModel.Filename);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld(createdNewFile);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region RoomListControls

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeRoomButton.Enabled = roomListBox.SelectedItem != null;
        }

        private void removeRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomListBox.SelectedItem);
                roomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        #endregion

        #region NeighborListControls

        private void roomNeighborAddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room currentRoom = (Room)roomListBox.SelectedItem;
                    foreach (Room room in ViewModel.Rooms)
                    {
                        if (room.Name.ToLower() == addRoomForm.RoomName.ToLower() && room.Name.ToLower() != currentRoom.Name.ToLower())
                        {
                            currentRoom.NeighborNames.Add(room.Name);
                        }
                    }
                }
            }
            neighborNamesBindingSource.ResetBindings(false);
        }
        private void roomNeighborListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomNeighborRemoveButton.Enabled = roomNeighborListBox.SelectedItem != null;
        }

        private void roomNeighborRemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this neighbor?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Room currentRoom = (Room)roomListBox.SelectedItem;
                currentRoom.NeighborNames.Remove((string)roomNeighborListBox.SelectedItem);
                roomNeighborListBox.SelectedItem = currentRoom.Neighbors.FirstOrDefault();
            }
            neighborNamesBindingSource.ResetBindings(false);
        }

        #endregion

        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;

    }
}
