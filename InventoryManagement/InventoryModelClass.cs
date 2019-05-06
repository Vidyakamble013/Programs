using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram1.InventoryManagement
{
   public class InventoryModelClass
    {
        private string name;

        private double price;

        private double weight;

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public double Price
        {
            get => this.price;
            set => this.price = value;
        }

        public double Weight
        {
            get => this.weight;
            set => this.weight = value;
        }

        public class InventoryInfo
        {
            public List<InventoryModelClass> Rices
            { get; set; }

            public List<InventoryModelClass> Wheat

            { get; set; }

            public List<InventoryModelClass> Pulses
            { get; set; }
        }

    }
}
