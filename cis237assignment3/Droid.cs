using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        // droid variables
        public string material;
        public string model;
        public string color;
        public decimal baseCost = 50;
        public decimal totalCost;

       

        // default constructor
        public Droid()
        {

        }

        // 3 parameter constructor
        public Droid(string material, string model, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }

        // Methods
        public void DroidCost()
        {
            

        }

    }
}
