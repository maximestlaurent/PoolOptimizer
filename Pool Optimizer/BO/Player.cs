using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Optimizer.BO
{
    public class Player : IComparable<Player>
    {
        #region Members

        private string name;
        private string teamAccroynym;
        private Position position;
        private int points;
        private double salary;
        private PlayerStatus status;

        #endregion

        #region Properties

        public string Name { get => name; set => name = value; }
        public string TeamAccroynym { get => teamAccroynym; set => teamAccroynym = value; }
        public Position Position { get => position; set => position = value; }
        public int Points { get => points; set => points = value; }
        public double Salary { get => salary; set => salary = value; }
        public PlayerStatus Status { get => status; set => status = value; }
        public double PointsPerDollar { get => points / Salary; }

        public Boolean Picked { get => PlayerStatus.PICKED.Equals(status); }
        public Boolean Available { get => PlayerStatus.AVAILABLE.Equals(status);  }

        #endregion

        #region Constructors

        public Player()
        {
            this.Status = PlayerStatus.AVAILABLE;
        }

        #endregion

        #region Public methods

        public override string ToString()
        {
            return this.name + "(" + this.TeamAccroynym + ")" + ": " + this.Points + " pts, " + this.Salary + "M$";
        }

        public int CompareTo(Player other)
        {
            if (other == null)
            {
                return 1;
            }

            return PointsPerDollar.CompareTo(other.PointsPerDollar);
        }

        #endregion
    }

    public enum PlayerStatus
    {
        AVAILABLE, UNAVAILABLE, PICKED
    }
}
