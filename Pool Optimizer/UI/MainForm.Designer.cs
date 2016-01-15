namespace Pool_Optimizer.UI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLW = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtRW = new System.Windows.Forms.TextBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLWLockIn = new System.Windows.Forms.Button();
            this.btnLWUnavailable = new System.Windows.Forms.Button();
            this.btnCUnavailable = new System.Windows.Forms.Button();
            this.btnCLockIn = new System.Windows.Forms.Button();
            this.btnRWUnavailable = new System.Windows.Forms.Button();
            this.btnRWLockIn = new System.Windows.Forms.Button();
            this.btnD1Unavailable = new System.Windows.Forms.Button();
            this.btnD1LockIn = new System.Windows.Forms.Button();
            this.btnD2Unavailable = new System.Windows.Forms.Button();
            this.btnD2LockIn = new System.Windows.Forms.Button();
            this.btnGUnavailable = new System.Windows.Forms.Button();
            this.btnGLockIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlRoster = new System.Windows.Forms.Panel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSalaryCap = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlRoster.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaryCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left Wing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Center:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Right Wing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Defenseman 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Defenseman 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Goaltender:";
            // 
            // txtLW
            // 
            this.txtLW.Location = new System.Drawing.Point(106, 12);
            this.txtLW.Name = "txtLW";
            this.txtLW.ReadOnly = true;
            this.txtLW.Size = new System.Drawing.Size(267, 20);
            this.txtLW.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(106, 38);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(267, 20);
            this.txtC.TabIndex = 7;
            // 
            // txtRW
            // 
            this.txtRW.Location = new System.Drawing.Point(106, 64);
            this.txtRW.Name = "txtRW";
            this.txtRW.ReadOnly = true;
            this.txtRW.Size = new System.Drawing.Size(267, 20);
            this.txtRW.TabIndex = 8;
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(106, 90);
            this.txtD1.Name = "txtD1";
            this.txtD1.ReadOnly = true;
            this.txtD1.Size = new System.Drawing.Size(267, 20);
            this.txtD1.TabIndex = 9;
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(106, 116);
            this.txtD2.Name = "txtD2";
            this.txtD2.ReadOnly = true;
            this.txtD2.Size = new System.Drawing.Size(267, 20);
            this.txtD2.TabIndex = 10;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(106, 142);
            this.txtG.Name = "txtG";
            this.txtG.ReadOnly = true;
            this.txtG.Size = new System.Drawing.Size(267, 20);
            this.txtG.TabIndex = 11;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(106, 180);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(267, 20);
            this.txtPoints.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Points:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(106, 206);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(267, 20);
            this.txtSalary.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salary:";
            // 
            // btnLWLockIn
            // 
            this.btnLWLockIn.Location = new System.Drawing.Point(379, 10);
            this.btnLWLockIn.Name = "btnLWLockIn";
            this.btnLWLockIn.Size = new System.Drawing.Size(75, 23);
            this.btnLWLockIn.TabIndex = 16;
            this.btnLWLockIn.Text = "Pick";
            this.btnLWLockIn.UseVisualStyleBackColor = true;
            this.btnLWLockIn.Click += new System.EventHandler(this.btnLWLockIn_Click);
            // 
            // btnLWUnavailable
            // 
            this.btnLWUnavailable.Location = new System.Drawing.Point(460, 10);
            this.btnLWUnavailable.Name = "btnLWUnavailable";
            this.btnLWUnavailable.Size = new System.Drawing.Size(75, 23);
            this.btnLWUnavailable.TabIndex = 17;
            this.btnLWUnavailable.Text = "Unavailable";
            this.btnLWUnavailable.UseVisualStyleBackColor = true;
            this.btnLWUnavailable.Click += new System.EventHandler(this.btnLWUnavailable_Click);
            // 
            // btnCUnavailable
            // 
            this.btnCUnavailable.Location = new System.Drawing.Point(460, 36);
            this.btnCUnavailable.Name = "btnCUnavailable";
            this.btnCUnavailable.Size = new System.Drawing.Size(75, 23);
            this.btnCUnavailable.TabIndex = 19;
            this.btnCUnavailable.Text = "Unavailable";
            this.btnCUnavailable.UseVisualStyleBackColor = true;
            this.btnCUnavailable.Click += new System.EventHandler(this.btnCUnavailable_Click);
            // 
            // btnCLockIn
            // 
            this.btnCLockIn.Location = new System.Drawing.Point(379, 36);
            this.btnCLockIn.Name = "btnCLockIn";
            this.btnCLockIn.Size = new System.Drawing.Size(75, 23);
            this.btnCLockIn.TabIndex = 18;
            this.btnCLockIn.Text = "Pick";
            this.btnCLockIn.UseVisualStyleBackColor = true;
            this.btnCLockIn.Click += new System.EventHandler(this.btnCLockIn_Click);
            // 
            // btnRWUnavailable
            // 
            this.btnRWUnavailable.Location = new System.Drawing.Point(460, 62);
            this.btnRWUnavailable.Name = "btnRWUnavailable";
            this.btnRWUnavailable.Size = new System.Drawing.Size(75, 23);
            this.btnRWUnavailable.TabIndex = 21;
            this.btnRWUnavailable.Text = "Unavailable";
            this.btnRWUnavailable.UseVisualStyleBackColor = true;
            this.btnRWUnavailable.Click += new System.EventHandler(this.btnRWUnavailable_Click);
            // 
            // btnRWLockIn
            // 
            this.btnRWLockIn.Location = new System.Drawing.Point(379, 62);
            this.btnRWLockIn.Name = "btnRWLockIn";
            this.btnRWLockIn.Size = new System.Drawing.Size(75, 23);
            this.btnRWLockIn.TabIndex = 20;
            this.btnRWLockIn.Text = "Pick";
            this.btnRWLockIn.UseVisualStyleBackColor = true;
            this.btnRWLockIn.Click += new System.EventHandler(this.btnRWLockIn_Click);
            // 
            // btnD1Unavailable
            // 
            this.btnD1Unavailable.Location = new System.Drawing.Point(460, 88);
            this.btnD1Unavailable.Name = "btnD1Unavailable";
            this.btnD1Unavailable.Size = new System.Drawing.Size(75, 23);
            this.btnD1Unavailable.TabIndex = 23;
            this.btnD1Unavailable.Text = "Unavailable";
            this.btnD1Unavailable.UseVisualStyleBackColor = true;
            this.btnD1Unavailable.Click += new System.EventHandler(this.btnD1Unavailable_Click);
            // 
            // btnD1LockIn
            // 
            this.btnD1LockIn.Location = new System.Drawing.Point(379, 88);
            this.btnD1LockIn.Name = "btnD1LockIn";
            this.btnD1LockIn.Size = new System.Drawing.Size(75, 23);
            this.btnD1LockIn.TabIndex = 22;
            this.btnD1LockIn.Text = "Pick";
            this.btnD1LockIn.UseVisualStyleBackColor = true;
            this.btnD1LockIn.Click += new System.EventHandler(this.btnD1LockIn_Click);
            // 
            // btnD2Unavailable
            // 
            this.btnD2Unavailable.Location = new System.Drawing.Point(460, 114);
            this.btnD2Unavailable.Name = "btnD2Unavailable";
            this.btnD2Unavailable.Size = new System.Drawing.Size(75, 23);
            this.btnD2Unavailable.TabIndex = 25;
            this.btnD2Unavailable.Text = "Unavailable";
            this.btnD2Unavailable.UseVisualStyleBackColor = true;
            this.btnD2Unavailable.Click += new System.EventHandler(this.btnD2Unavailable_Click);
            // 
            // btnD2LockIn
            // 
            this.btnD2LockIn.Location = new System.Drawing.Point(379, 114);
            this.btnD2LockIn.Name = "btnD2LockIn";
            this.btnD2LockIn.Size = new System.Drawing.Size(75, 23);
            this.btnD2LockIn.TabIndex = 24;
            this.btnD2LockIn.Text = "Pick";
            this.btnD2LockIn.UseVisualStyleBackColor = true;
            this.btnD2LockIn.Click += new System.EventHandler(this.btnD2LockIn_Click);
            // 
            // btnGUnavailable
            // 
            this.btnGUnavailable.Location = new System.Drawing.Point(460, 140);
            this.btnGUnavailable.Name = "btnGUnavailable";
            this.btnGUnavailable.Size = new System.Drawing.Size(75, 23);
            this.btnGUnavailable.TabIndex = 27;
            this.btnGUnavailable.Text = "Unavailable";
            this.btnGUnavailable.UseVisualStyleBackColor = true;
            this.btnGUnavailable.Click += new System.EventHandler(this.btnGUnavailable_Click);
            // 
            // btnGLockIn
            // 
            this.btnGLockIn.Location = new System.Drawing.Point(379, 140);
            this.btnGLockIn.Name = "btnGLockIn";
            this.btnGLockIn.Size = new System.Drawing.Size(75, 23);
            this.btnGLockIn.TabIndex = 26;
            this.btnGLockIn.Text = "Pick";
            this.btnGLockIn.UseVisualStyleBackColor = true;
            this.btnGLockIn.Click += new System.EventHandler(this.btnGLockIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlRoster
            // 
            this.pnlRoster.Controls.Add(this.label11);
            this.pnlRoster.Controls.Add(this.nudSalaryCap);
            this.pnlRoster.Controls.Add(this.label10);
            this.pnlRoster.Controls.Add(this.pnlLoading);
            this.pnlRoster.Controls.Add(this.label1);
            this.pnlRoster.Controls.Add(this.btnReset);
            this.pnlRoster.Controls.Add(this.label2);
            this.pnlRoster.Controls.Add(this.btnGUnavailable);
            this.pnlRoster.Controls.Add(this.label3);
            this.pnlRoster.Controls.Add(this.btnGLockIn);
            this.pnlRoster.Controls.Add(this.label4);
            this.pnlRoster.Controls.Add(this.btnD2Unavailable);
            this.pnlRoster.Controls.Add(this.label5);
            this.pnlRoster.Controls.Add(this.btnD2LockIn);
            this.pnlRoster.Controls.Add(this.label6);
            this.pnlRoster.Controls.Add(this.btnD1Unavailable);
            this.pnlRoster.Controls.Add(this.txtLW);
            this.pnlRoster.Controls.Add(this.btnD1LockIn);
            this.pnlRoster.Controls.Add(this.txtC);
            this.pnlRoster.Controls.Add(this.btnRWUnavailable);
            this.pnlRoster.Controls.Add(this.txtRW);
            this.pnlRoster.Controls.Add(this.btnRWLockIn);
            this.pnlRoster.Controls.Add(this.txtD1);
            this.pnlRoster.Controls.Add(this.btnCUnavailable);
            this.pnlRoster.Controls.Add(this.txtD2);
            this.pnlRoster.Controls.Add(this.btnCLockIn);
            this.pnlRoster.Controls.Add(this.txtG);
            this.pnlRoster.Controls.Add(this.btnLWUnavailable);
            this.pnlRoster.Controls.Add(this.label7);
            this.pnlRoster.Controls.Add(this.btnLWLockIn);
            this.pnlRoster.Controls.Add(this.txtPoints);
            this.pnlRoster.Controls.Add(this.txtSalary);
            this.pnlRoster.Controls.Add(this.label8);
            this.pnlRoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoster.Location = new System.Drawing.Point(0, 0);
            this.pnlRoster.Name = "pnlRoster";
            this.pnlRoster.Size = new System.Drawing.Size(562, 291);
            this.pnlRoster.TabIndex = 29;
            this.pnlRoster.Visible = false;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Controls.Add(this.label9);
            this.pnlLoading.Location = new System.Drawing.Point(469, 221);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(562, 291);
            this.pnlLoading.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loading...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Salary cap:";
            // 
            // nudSalaryCap
            // 
            this.nudSalaryCap.Location = new System.Drawing.Point(106, 240);
            this.nudSalaryCap.Name = "nudSalaryCap";
            this.nudSalaryCap.Size = new System.Drawing.Size(43, 20);
            this.nudSalaryCap.TabIndex = 32;
            this.nudSalaryCap.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "M$";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 291);
            this.Controls.Add(this.pnlRoster);
            this.Name = "MainForm";
            this.Text = "Pool Optimizer 2014";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlRoster.ResumeLayout(false);
            this.pnlRoster.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaryCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLW;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtRW;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLWLockIn;
        private System.Windows.Forms.Button btnLWUnavailable;
        private System.Windows.Forms.Button btnCUnavailable;
        private System.Windows.Forms.Button btnCLockIn;
        private System.Windows.Forms.Button btnRWUnavailable;
        private System.Windows.Forms.Button btnRWLockIn;
        private System.Windows.Forms.Button btnD1Unavailable;
        private System.Windows.Forms.Button btnD1LockIn;
        private System.Windows.Forms.Button btnD2Unavailable;
        private System.Windows.Forms.Button btnD2LockIn;
        private System.Windows.Forms.Button btnGUnavailable;
        private System.Windows.Forms.Button btnGLockIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlRoster;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudSalaryCap;
        private System.Windows.Forms.Label label10;

    }
}

