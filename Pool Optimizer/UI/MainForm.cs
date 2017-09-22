using Pool_Optimizer.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Optimizer.UI
{
    public partial class MainForm : Form
    {
        #region Members

        CSVDataSource _dataSource;
        Roster _roster;

        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dataPath = openFileDialog.FileName;
                CreateDataSource(dataPath);
            }
            else
            {
                Application.Exit();
            }
        }

        #endregion

        #region Events

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.DisplayOptimalRoster();
            this.ShowRosterPanel();
        }

        private void btnLWLockIn_Click(object sender, EventArgs e)
        {
            if (!this._roster.LeftWing.Picked)
            {
                this.PickPlayer(_roster.LeftWing, btnLWLockIn, btnLWUnavailable);
            }
            else
            {
                this.UnpickPlayer(_roster.LeftWing, btnLWLockIn, btnLWUnavailable);
            }
        }

        private void btnCLockIn_Click(object sender, EventArgs e)
        {
            if (!this._roster.Center.Picked)
            {
                this.PickPlayer(_roster.Center, btnCLockIn, btnCUnavailable);
            }
            else
            {
                this.UnpickPlayer(_roster.Center, btnCLockIn, btnCUnavailable);
            }
        }

        private void btnRWLockIn_Click(object sender, EventArgs e)
        {
            if (!this._roster.RightWing.Picked)
            {
                this.PickPlayer(_roster.RightWing, btnRWLockIn, btnRWUnavailable);
            }
            else
            {
                this.UnpickPlayer(_roster.RightWing, btnRWLockIn, btnRWUnavailable);
            }
        }

        private void btnD1LockIn_Click(object sender, EventArgs e)
        {
            if (!this._roster.Defenseman1.Picked)
            {
                this.PickPlayer(_roster.Defenseman1, btnD1LockIn, btnD1Unavailable);
            }
            else
            {
                this.UnpickPlayer(_roster.Defenseman1, btnD1LockIn, btnD1Unavailable);
            }
        }

        private void btnD2LockIn_Click(object sender, EventArgs e)
        {
            if (!this._roster.Defenseman2.Picked)
            {
                this.PickPlayer(_roster.Defenseman2, btnD2LockIn, btnD2Unavailable);
            }
            else
            {
                this.UnpickPlayer(_roster.Defenseman2, btnD2LockIn, btnD2Unavailable);
            }
        }

        private void btnGLockIn_Click(object sender, EventArgs e)
        {
            if (!this._roster.Goaltender.Picked)
            {
                this.PickPlayer(_roster.Goaltender, btnGLockIn, btnGUnavailable);
            }
            else
            {
                this.UnpickPlayer(_roster.Goaltender, btnGLockIn, btnGUnavailable);
            }
        }

        private void btnLWUnavailable_Click(object sender, EventArgs e)
        {
            this.MakePlayerUnavailable(_roster.LeftWing, btnLWLockIn, btnLWUnavailable);
        }

        private void btnCUnavailable_Click(object sender, EventArgs e)
        {
            this.MakePlayerUnavailable(_roster.Center, btnCLockIn, btnCUnavailable);
        }

        private void btnRWUnavailable_Click(object sender, EventArgs e)
        {
            this.MakePlayerUnavailable(_roster.RightWing, btnRWLockIn, btnRWUnavailable);
        }

        private void btnD1Unavailable_Click(object sender, EventArgs e)
        {
            this.MakePlayerUnavailable(_roster.Defenseman1, btnD1LockIn, btnD1Unavailable);
        }

        private void btnD2Unavailable_Click(object sender, EventArgs e)
        {
            this.MakePlayerUnavailable(_roster.Defenseman2, btnD2LockIn, btnD2Unavailable);
        }

        private void btnGUnavailable_Click(object sender, EventArgs e)
        {
            this.MakePlayerUnavailable(_roster.Goaltender, btnGLockIn, btnGUnavailable);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.DisplayOptimalRoster();
        }

        #endregion

        #region Private methods

        private void CreateDataSource(string dataPath)
        {
            this._dataSource = new CSVDataSource(dataPath);
            this._dataSource.Populate();
        }

        private Roster GetOptimalRoster()
        {
            Roster bestRoster = null;

            List<Player> leftWings = new List<Player>();
            List<Player> centers = new List<Player>();
            List<Player> rightWings = new List<Player>();
            List<Player> defensemen1 = new List<Player>();
            List<Player> defensemen2 = new List<Player>();
            List<Player> goaltenders = new List<Player>();

            double salaryCap = (double)nudSalaryCap.Value * 1000000;

            if (_roster != null && _roster.LeftWing != null && _roster.LeftWing.Picked)
            {
                leftWings.Add(_roster.LeftWing);
            }
            else
            {
                leftWings = _dataSource.LeftWings.Where(lw => lw.Available == true).ToList();
            }

            if (_roster != null && _roster.Center != null && _roster.Center.Picked)
            {
                centers.Add(_roster.Center);
            }
            else
            {
                centers = _dataSource.Centers.Where(c => c.Available == true).ToList();
            }

            if (_roster != null && _roster.RightWing != null && _roster.RightWing.Picked)
            {
                rightWings.Add(_roster.RightWing);
            }
            else
            {
                rightWings = _dataSource.RightWings.Where(rw => rw.Available == true).ToList();
            }

            if (_roster != null && _roster.Defenseman1 != null && _roster.Defenseman1.Picked)
            {
                defensemen1.Add(_roster.Defenseman1);
            }
            else
            {
                defensemen1 = _dataSource.Defensemen.Where(d1 => d1.Available == true).ToList();
            }

            if (_roster != null && _roster.Defenseman2 != null && _roster.Defenseman2.Picked)
            {
                defensemen2.Add(_roster.Defenseman2);
            }
            else
            {
                defensemen2 = _dataSource.Defensemen.Where(d2 => d2.Available == true).ToList();
            }

            if (_roster != null && _roster.Goaltender != null && _roster.Goaltender.Picked)
            {
                goaltenders.Add(_roster.Goaltender);
            }
            else
            {
                goaltenders = _dataSource.Goaltenders.Where(g => g.Available == true).ToList();
            }

            // Based on exemple given here: https://stackoverflow.com/questions/29729609/knapsack-with-selection-from-distinct-groups

            // 6 groups: leftWings, centers, rightWings, defensemen1, defensemen2, goaltenders
            List<List<Player>> groups = new List<List<Player>>();
            groups.Add(leftWings);
            groups.Add(centers);
            groups.Add(rightWings);
            groups.Add(defensemen1);
            groups.Add(defensemen2);
            groups.Add(goaltenders);

            List<List<double>> weights = groups.Select(g => g.Select(p => p.Salary).ToList()).ToList();
            List<List<int>> values = groups.Select(g => g.Select(p => p.Points).ToList()).ToList();
            List<List<Player>> players = groups.Select(g => g.Select(p => p).ToList()).ToList();
            double maxWeight = salaryCap;

            Dictionary<double, int> lastPoints = new Dictionary<double, int>();
            Dictionary<double, Player> lastPlayers = new Dictionary<double, Player>();
            for (int i = 0; i < weights.ElementAt(0).Count; ++i)
            {
                if (weights[0][i] > maxWeight) continue;

                Player lastPlayer = null;
                lastPlayers.TryGetValue(weights[0][i], out lastPlayer);

                Player currentPlayer = players[0][i];

                if (lastPlayer == null || lastPlayer.Points < currentPlayer.Points)
                {
                    lastPoints[weights[0][i]] = values[0][i];
                    lastPlayers[weights[0][i]] = currentPlayer;
                }
            }

            Dictionary<double, int> current = new Dictionary<double, int>();
            for (int i = 1; i < weights.Count; ++i)
            {
                for (int j = 0; j < weights[i].Count; ++j)
                {
                    for (double k = weights[i][j]; k <= maxWeight; ++k)
                    {
                        current[k] = Math.Max(current[k], lastPoints[k - weights[i][j]] + values[i][j]);
                    }
                }

                Swap<Dictionary<double, int>>(ref current, ref lastPoints);
            }

            int maxPoints = lastPoints.Values.Max();
            double maxSalary = lastPoints.FirstOrDefault(x => x.Value == maxPoints).Key;

            
            //foreach (Player player in groups.ElementAt(0))
            //{
            //    if (player.Salary > salaryCap) continue;

            //    if (player.Points > lastPoints[player.Salary])
            //    {
            //        lastPlayers[player.Salary] = player;
            //        lastPoints[player.Salary] = player.Points;
            //    }
            //}

            //int numberOfGroups = 6;
            //Dictionary<double, Player> currentPlayers = new Dictionary<double, Player>();
            //Dictionary<double, int> currentPoints = new Dictionary<double, int>();
            //// Start with group index 1, because we've already done group index 0
            //for (int i = 1; i < numberOfGroups; i++)
            //{
            //    foreach(Player player in groups.ElementAt(i))
            //    {
            //        currentPoints[player.Salary] = Math.Max(currentPoints[playerSalary], lastPoints)
            //    }
            //}

            //foreach (Player leftWing in leftWings)
            //{
            //    foreach (Player center in centers)
            //    {
            //        foreach (Player rightWing in rightWings)
            //        {
            //            foreach (Player defenseman1 in defensemen1)
            //            {
            //                foreach (Player defenseman2 in defensemen2)
            //                {
            //                    if (defenseman1.Name != defenseman2.Name)
            //                    {
            //                        foreach (Player goaltender in goaltenders)
            //                        {
            //                            Roster roster = new Roster();
            //                            roster.LeftWing = leftWing;
            //                            roster.Center = center;
            //                            roster.RightWing = rightWing;
            //                            roster.Defenseman1 = defenseman1;
            //                            roster.Defenseman2 = defenseman2;
            //                            roster.Goaltender = goaltender;

            //                            if (roster.Salary <= salaryCap && (bestRoster == null || roster.Points > bestRoster.Points))
            //                            {
            //                                bestRoster = roster;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            return bestRoster;
        }

        private void DisplayOptimalRoster()
        {
            this._roster = this.GetOptimalRoster();

            txtLW.Text = this._roster.LeftWing.ToString();
            txtC.Text = this._roster.Center.ToString();
            txtRW.Text = this._roster.RightWing.ToString();
            txtD1.Text = this._roster.Defenseman1.ToString();
            txtD2.Text = this._roster.Defenseman2.ToString();
            txtG.Text = this._roster.Goaltender.ToString();

            txtPoints.Text = this._roster.Points + " pts";
            txtSalary.Text = this._roster.Salary + "M$";
        }

        private void ShowRosterPanel()
        {
            pnlRoster.Visible = true;
            pnlLoading.Visible = false;
        }

        private void ShowLoadingPanel()
        {
            pnlLoading.Visible = true;
            pnlRoster.Visible = false;
        }

        private void PickPlayer(Player player, Button btnLockIn, Button btnUnavailable)
        {
            player.Status = PlayerStatus.PICKED;

            btnLockIn.Text = "Unpick";
            btnUnavailable.Enabled = false;
        }

        private void UnpickPlayer(Player player, Button btnLockIn, Button btnUnavailable)
        {
            player.Status = PlayerStatus.AVAILABLE;

            btnLockIn.Text = "Pick";
            btnUnavailable.Enabled = true;
        }

        private void MakePlayerUnavailable(Player player, Button btnLockIn, Button btnUnavailable)
        {
            player.Status = PlayerStatus.UNAVAILABLE;

            this.DisplayOptimalRoster();
        }

        //private void MakePlayerAvailable(Player player, Button btnLockIn, Button btnUnavailable) {
        //    player.Picked = false;
        //    player.Available = true;

        //    btnLockIn.Enabled = true;
        //    btnUnavailable.Text = "Unavailable";

        //    this.DisplayOptimalRoster();
        //}

        private void Swap<T>(ref T left, ref T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }

        #endregion
    }
}
