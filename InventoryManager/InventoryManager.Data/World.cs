using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace InventoryManager.Data
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string WelcomeMessage { get; set; }
        public List<Room> Rooms { get; set; }
        public World()
        {
            Rooms = new List<Room>();
            WelcomeMessage = new string(new char[] { });
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach(Room room in Rooms)
            {
                room.BuildNeighborsFromName(Rooms);
            }
        }
    }
}
