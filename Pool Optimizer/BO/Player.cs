using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Optimizer.BO {
    public class Player {
        #region Properties

        public string Name;
        public Position Position;
        public int Points;
        public double Salary;
        public bool Available;
        public bool Picked;

        #endregion

        #region Constructors

        public Player() {
            this.Available = true;
            this.Picked = false;
        }

        #endregion

        #region Public methods

        public override string ToString() {
            return this.Name + ": " + this.Points + " pts, " + this.Salary + "M$";
        }

        #endregion
    }
}
