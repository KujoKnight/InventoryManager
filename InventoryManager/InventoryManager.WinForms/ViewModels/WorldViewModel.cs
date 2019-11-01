using System;
using System.ComponentModel;
using System.IO;
using InventoryManager.Data;
using Newtonsoft.Json;

namespace InventoryManager.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        public string Message { get; set; }
        public BindingList<Room> Rooms { get; set; }
        public World World
        {
            set
            {
                if (mWorld != value)
                {
                    mWorld = value;
                    if (mWorld != null)
                    {
                        Rooms = new BindingList<Room>(mWorld.Rooms);
                        Message = new string(new char[] { });
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        Message = new string(new char[] { });
                    }
                }
            }
        }

        public WorldViewModel(World world = null)
        {
            World = world;
        }

        public void SaveWorld(bool newFile)
        {
            mWorld.WelcomeMessage = Message;
            bool startingLocSet = false;
            foreach (Room room in mWorld.Rooms)
            {
                if (room.StartingLocation == true)
                {
                    if(startingLocSet == false)
                    {
                        startingLocSet = true;
                    }
                    else
                    {
                        room.StartingLocation = false;
                    }
                }

            }

            if (!newFile)
            {
                if (string.IsNullOrEmpty(Filename))
                {
                    throw new InvalidProgramException("Filename expected.");
                }

                JsonSerializer serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };
                using (StreamWriter streamWriter = new StreamWriter(Filename))
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jsonWriter, mWorld);
                }
            }
            else
            {
                JsonSerializer serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };
                using (StreamWriter streamWriter = new StreamWriter(Filename))
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jsonWriter, mWorld);
                }
            }
        }

        private World mWorld;
    }
}
