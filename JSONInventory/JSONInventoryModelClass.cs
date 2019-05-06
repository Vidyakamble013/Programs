using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram1.JSONInventory
{
    class JSONInventoryModelClass
    {
        public string Name
        { get; set; }

        public int Price
        { get; set;}

        public int Weight
        { get; set; }
    }

     class InventoryDisplayInfo
    {
        public List<JSONInventoryModelClass>Rice { get;set; }

        public List<JSONInventoryModelClass> Wheat { get; set; }

        public List<JSONInventoryModelClass>Pulses { get; set; }
    }
}
