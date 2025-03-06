namespace WTFdtsf_winUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            label3 = new Label();
            lblAcronymDisplay = new Label();
            lblTurnDisplay = new Label();
            btnSubmit = new Button();
            txtPlayerInput = new TextBox();
            gboxResults = new GroupBox();
            listBoxResults = new ListBox();
            btnExit = new Button();
            btnNewTurn = new Button();
            btnEndTurn = new Button();
            btnReroll = new Button();
            groupBox2.SuspendLayout();
            gboxResults.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblAcronymDisplay);
            groupBox2.Controls.Add(lblTurnDisplay);
            groupBox2.Controls.Add(btnSubmit);
            groupBox2.Controls.Add(txtPlayerInput);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 144);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 5;
            label3.Text = "Acronym:";
            // 
            // lblAcronymDisplay
            // 
            lblAcronymDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcronymDisplay.Location = new Point(43, 19);
            lblAcronymDisplay.Name = "lblAcronymDisplay";
            lblAcronymDisplay.Size = new Size(687, 65);
            lblAcronymDisplay.TabIndex = 0;
            lblAcronymDisplay.Text = "A B C D E F ThisIsALongWord";
            lblAcronymDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTurnDisplay
            // 
            lblTurnDisplay.AutoSize = true;
            lblTurnDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurnDisplay.Location = new Point(622, 110);
            lblTurnDisplay.Name = "lblTurnDisplay";
            lblTurnDisplay.Size = new Size(71, 21);
            lblTurnDisplay.TabIndex = 4;
            lblTurnDisplay.Text = "Player 1";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(695, 110);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPlayerInput
            // 
            txtPlayerInput.Location = new Point(88, 110);
            txtPlayerInput.Name = "txtPlayerInput";
            txtPlayerInput.Size = new Size(524, 23);
            txtPlayerInput.TabIndex = 2;
            // 
            // gboxResults
            // 
            gboxResults.Controls.Add(listBoxResults);
            gboxResults.Location = new Point(12, 191);
            gboxResults.Name = "gboxResults";
            gboxResults.Size = new Size(776, 263);
            gboxResults.TabIndex = 4;
            gboxResults.TabStop = false;
            gboxResults.Text = "Results";
            // 
            // listBoxResults
            // 
            listBoxResults.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 32;
            listBoxResults.Location = new Point(6, 22);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(764, 228);
            listBoxResults.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(707, 162);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnNewTurn
            // 
            btnNewTurn.Location = new Point(626, 162);
            btnNewTurn.Name = "btnNewTurn";
            btnNewTurn.Size = new Size(75, 23);
            btnNewTurn.TabIndex = 6;
            btnNewTurn.Text = "Play Again";
            btnNewTurn.UseVisualStyleBackColor = true;
            btnNewTurn.Click += btnNewTurn_Click;
            // 
            // btnEndTurn
            // 
            btnEndTurn.Location = new Point(18, 162);
            btnEndTurn.Name = "btnEndTurn";
            btnEndTurn.Size = new Size(148, 23);
            btnEndTurn.TabIndex = 7;
            btnEndTurn.Text = "End Turn (Show Results)";
            btnEndTurn.UseVisualStyleBackColor = true;
            btnEndTurn.Click += btnEndTurn_Click;
            // 
            // btnReroll
            // 
            btnReroll.Location = new Point(545, 162);
            btnReroll.Name = "btnReroll";
            btnReroll.Size = new Size(75, 23);
            btnReroll.TabIndex = 8;
            btnReroll.Text = "Reroll";
            btnReroll.UseVisualStyleBackColor = true;
            btnReroll.Click += bteReroll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(793, 461);
            Controls.Add(btnReroll);
            Controls.Add(btnEndTurn);
            Controls.Add(btnNewTurn);
            Controls.Add(btnExit);
            Controls.Add(gboxResults);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "WTF Does That Stand For?";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gboxResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label lblTurnDisplay;
        private Button btnSubmit;
        private TextBox txtPlayerInput;
        private Label lblAcronymDisplay;
        private GroupBox gboxResults;
        private Label label3;
        private Button btnExit;
        private Button btnNewTurn;
        private Button btnEndTurn;
        private ListBox listBoxResults;
        private Button btnReroll;
    }
}
