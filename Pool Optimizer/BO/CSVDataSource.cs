using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Optimizer.BO
{
    public class CSVDataSource
    {
        #region Members

        private string _filePath;

        #endregion

        #region Properties

        public List<Player> LeftWings = new List<Player>();
        public List<Player> Centers = new List<Player>();
        public List<Player> RightWings = new List<Player>();
        public List<Player> Defensemen = new List<Player>();
        public List<Player> Goaltenders = new List<Player>();

        #endregion

        #region Constructors

        public CSVDataSource(string filePath)
        {
            _filePath = filePath;
        }

        #endregion

        #region Public methods

        public void Populate()
        {
            if (_filePath != null && _filePath != "")
            {
                string line = "";
                char splitter = ';';

                StreamReader reader = new StreamReader(_filePath);

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(splitter);
                    Player player = new Player();
                    player.Name = data[0];
                    String position = data[1];
                    player.TeamAccroynym = data[2];
                    player.Points = Int32.Parse(data[3]);
                    player.Salary = Double.Parse(data[4]);

                    switch (position)
                    {
                        case "LW":
                            player.Position = Position.LeftWing;
                            this.LeftWings.Add(player);
                            break;
                        case "C":
                            player.Position = Position.Center;
                            this.Centers.Add(player);
                            break;
                        case "RW":
                            player.Position = Position.RightWing;
                            this.RightWings.Add(player);
                            break;
                        case "D":
                            player.Position = Position.Defenseman;
                            this.Defensemen.Add(player);
                            break;
                        case "G":
                            player.Position = Position.Goaltender;
                            this.Goaltenders.Add(player);
                            break;
                    }
                }

                reader.Close();
            }
        }

        #endregion
    }
}
