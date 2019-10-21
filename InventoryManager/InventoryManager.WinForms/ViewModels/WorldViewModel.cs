using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Data;

namespace InventoryManager.WinForms.ViewModels
{
    public class WorldViewModel
    {
        public string Filename { get; set; }
        public World World { get; set; }
    }
}
