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
        BindingList<Player> _unavailablePlayers = new BindingList<Player>();

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
                CreateDataGridView();

                BringToFront();
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

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvUnavailablePlayers.SelectedRows)
            {
                Player player = (Player) row.DataBoundItem;
                this.MakePlayerAvailable(player);
            }
        }

        #endregion

        #region Private methods

        private void CreateDataSource(string dataPath)
        {
            this._dataSource = new CSVDataSource(dataPath);
            this._dataSource.Populate();
        }

        private void CreateDataGridView()
        {
            dgvUnavailablePlayers.AutoGenerateColumns = false;
            dgvUnavailablePlayers.AllowUserToAddRows = false;
            dgvUnavailablePlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnavailablePlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnavailablePlayers.DataSource = _unavailablePlayers;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";
            dgvUnavailablePlayers.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn positionColumn = new DataGridViewTextBoxColumn();
            positionColumn.Name = "Position";
            positionColumn.HeaderText = "Position";
            positionColumn.DataPropertyName = "Position";
            dgvUnavailablePlayers.Columns.Add(positionColumn);

            DataGridViewTextBoxColumn teamColumn = new DataGridViewTextBoxColumn();
            teamColumn.Name = "Team";
            teamColumn.HeaderText = "Team";
            teamColumn.DataPropertyName = "Team";
            dgvUnavailablePlayers.Columns.Add(teamColumn);

            DataGridViewTextBoxColumn pointsColumn = new DataGridViewTextBoxColumn();
            pointsColumn.Name = "Points";
            pointsColumn.HeaderText = "Points";
            pointsColumn.DataPropertyName = "Points";
            dgvUnavailablePlayers.Columns.Add(pointsColumn);

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.Name = "Salary";
            salaryColumn.HeaderText = "Salary";
            salaryColumn.DataPropertyName = "Salary";
            dgvUnavailablePlayers.Columns.Add(salaryColumn);
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
                leftWings = _dataSource.LeftWings.Where(lw => lw.Available == true).OrderByDescending(p => p.Points).ToList();
            }

            if (_roster != null && _roster.Center != null && _roster.Center.Picked)
            {
                centers.Add(_roster.Center);
            }
            else
            {
                centers = _dataSource.Centers.Where(c => c.Available == true).OrderByDescending(p => p.Points).ToList();
            }

            if (_roster != null && _roster.RightWing != null && _roster.RightWing.Picked)
            {
                rightWings.Add(_roster.RightWing);
            }
            else
            {
                rightWings = _dataSource.RightWings.Where(rw => rw.Available == true).OrderByDescending(p => p.Points).ToList();
            }

            if (_roster != null && _roster.Defenseman1 != null && _roster.Defenseman1.Picked)
            {
                defensemen1.Add(_roster.Defenseman1);
            }
            else
            {
                defensemen1 = _dataSource.Defensemen.Where(d1 => d1.Available == true).OrderByDescending(p => p.Points).ToList();
            }

            if (_roster != null && _roster.Defenseman2 != null && _roster.Defenseman2.Picked)
            {
                defensemen2.Add(_roster.Defenseman2);
            }
            else
            {
                defensemen2 = _dataSource.Defensemen.Where(d2 => d2.Available == true).OrderByDescending(p => p.Points).ToList();
            }

            if (_roster != null && _roster.Goaltender != null && _roster.Goaltender.Picked)
            {
                goaltenders.Add(_roster.Goaltender);
            }
            else
            {
                goaltenders = _dataSource.Goaltenders.Where(g => g.Available == true).OrderByDescending(p => p.Points).ToList();
            }

            int iLW = 0;
            int iC = 0;
            int iRW = 0;
            int iD1 = 0;
            int iD2 = 1;
            int iG = 0;

            while (bestRoster == null)
            {
                Roster currentRoster = new Roster();
                currentRoster.LeftWing = leftWings.ElementAtOrDefault(iLW);
                currentRoster.Center = centers.ElementAtOrDefault(iC);
                currentRoster.RightWing = rightWings.ElementAtOrDefault(iRW);
                currentRoster.Defenseman1 = defensemen1.ElementAtOrDefault(iD1);
                currentRoster.Defenseman2 = defensemen2.ElementAtOrDefault(iD2);
                currentRoster.Goaltender = goaltenders.ElementAtOrDefault(iG);

                if (currentRoster.Salary < salaryCap)
                {
                    bestRoster = currentRoster;
                }
                else
                {
                    Player playerToChange = currentRoster.Players.Min(p => p);
                    if (playerToChange == currentRoster.LeftWing)
                    {
                        iLW++;
                    }
                    else if (playerToChange == currentRoster.Center)
                    {
                        iC++;
                    }
                    else if (playerToChange == currentRoster.RightWing)
                    {
                        iRW++;
                    }
                    else if (playerToChange == currentRoster.Defenseman1)
                    {
                        iD1++;
                        if (iD1 == iD2)
                        {
                            iD1++;
                        }
                    }
                    else if (playerToChange == currentRoster.Defenseman2)
                    {
                        iD2++;
                        if (iD1 == iD2)
                        {
                            iD2++;
                        }
                    }
                    else if (playerToChange == currentRoster.Goaltender)
                    {
                        iG++;
                    }
                }
            }

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
            txtSalary.Text = this._roster.Salary / 1000000 + "M$";
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
            _unavailablePlayers.Add(player);

            this.DisplayOptimalRoster();
        }

        private void MakePlayerAvailable(Player player)
        {
            player.Status = PlayerStatus.AVAILABLE;
            _unavailablePlayers.Remove(player);

            this.DisplayOptimalRoster();
        }

        #endregion
    }
}
