using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Optimizer.BO {
    public class Roster {
        #region Properties

        public Player LeftWing;
        public Player Center;
        public Player RightWing;
        public Player Defenseman1;
        public Player Defenseman2;
        public Player Goaltender;

        public int Points {
            get {
                return LeftWing.Points + Center.Points + RightWing.Points + Defenseman1.Points + Defenseman2.Points + Goaltender.Points;
            }
        }

        public double Salary {
            get {
                return LeftWing.Salary + Center.Salary + RightWing.Salary + Defenseman1.Salary + Defenseman2.Salary + Goaltender.Salary;
            }
        }

        public List<Player> Players
        {
            get
            {
                List<Player> players = new List<Player>();
                if (LeftWing != null) players.Add(LeftWing);
                if (Center != null) players.Add(Center);
                if (RightWing != null) players.Add(RightWing);
                if (Defenseman1 != null) players.Add(Defenseman1);
                if (Defenseman2 != null) players.Add(Defenseman2);
                if (Goaltender != null) players.Add(Goaltender);
                return players;
            }
        }

        #endregion
    }
}
