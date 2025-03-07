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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox2 = new GroupBox();
            label3 = new Label();
            lblAcronymDisplay = new Label();
            lblTurnDisplay = new Label();
            btnSubmit = new Button();
            txtPlayerInput = new TextBox();
            gboxResults = new GroupBox();
            listBoxResults = new ListBox();
            btnNewTurn = new Button();
            btnEndTurn = new Button();
            btnReroll = new Button();
            mnuMain = new MenuStrip();
            itmFile = new ToolStripMenuItem();
            itmAbout = new ToolStripMenuItem();
            itmSettings = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            itmQuit = new ToolStripMenuItem();
            gBoxSettings = new GroupBox();
            label1 = new Label();
            lblCustomFileName = new Label();
            lblCustomWordList = new Label();
            btnOpenWordList = new Button();
            btnApply = new Button();
            btnCancel = new Button();
            groupBox2.SuspendLayout();
            gboxResults.SuspendLayout();
            mnuMain.SuspendLayout();
            gBoxSettings.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblAcronymDisplay);
            groupBox2.Controls.Add(lblTurnDisplay);
            groupBox2.Controls.Add(btnSubmit);
            groupBox2.Controls.Add(txtPlayerInput);
            groupBox2.Location = new Point(12, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 144);
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
            lblAcronymDisplay.BackColor = SystemColors.Control;
            lblAcronymDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcronymDisplay.Location = new Point(6, 19);
            lblAcronymDisplay.Name = "lblAcronymDisplay";
            lblAcronymDisplay.Size = new Size(694, 65);
            lblAcronymDisplay.TabIndex = 0;
            lblAcronymDisplay.Text = "A B C D E F ThisIsALongWord";
            lblAcronymDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTurnDisplay
            // 
            lblTurnDisplay.AutoSize = true;
            lblTurnDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurnDisplay.Location = new Point(548, 110);
            lblTurnDisplay.Name = "lblTurnDisplay";
            lblTurnDisplay.Size = new Size(71, 21);
            lblTurnDisplay.TabIndex = 4;
            lblTurnDisplay.Text = "Player 1";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(625, 109);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPlayerInput
            // 
            txtPlayerInput.BorderStyle = BorderStyle.FixedSingle;
            txtPlayerInput.Location = new Point(95, 110);
            txtPlayerInput.Name = "txtPlayerInput";
            txtPlayerInput.Size = new Size(430, 23);
            txtPlayerInput.TabIndex = 2;
            txtPlayerInput.TextChanged += txtPlayerInput_TextChanged;
            txtPlayerInput.KeyDown += txtPlayerInput_KeyDown;
            // 
            // gboxResults
            // 
            gboxResults.Controls.Add(listBoxResults);
            gboxResults.Location = new Point(12, 206);
            gboxResults.Name = "gboxResults";
            gboxResults.Size = new Size(706, 263);
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
            listBoxResults.Size = new Size(694, 228);
            listBoxResults.TabIndex = 4;
            // 
            // btnNewTurn
            // 
            btnNewTurn.Location = new Point(637, 177);
            btnNewTurn.Name = "btnNewTurn";
            btnNewTurn.Size = new Size(75, 23);
            btnNewTurn.TabIndex = 6;
            btnNewTurn.Text = "Play Again";
            btnNewTurn.UseVisualStyleBackColor = true;
            btnNewTurn.Click += btnNewTurn_Click;
            // 
            // btnEndTurn
            // 
            btnEndTurn.Location = new Point(18, 177);
            btnEndTurn.Name = "btnEndTurn";
            btnEndTurn.Size = new Size(148, 23);
            btnEndTurn.TabIndex = 7;
            btnEndTurn.Text = "End Turn (Show Results)";
            btnEndTurn.UseVisualStyleBackColor = true;
            btnEndTurn.Click += btnEndTurn_Click;
            // 
            // btnReroll
            // 
            btnReroll.Location = new Point(556, 177);
            btnReroll.Name = "btnReroll";
            btnReroll.Size = new Size(75, 23);
            btnReroll.TabIndex = 8;
            btnReroll.Text = "Reroll";
            btnReroll.UseVisualStyleBackColor = true;
            btnReroll.Click += bteReroll_Click;
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { itmFile });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(957, 24);
            mnuMain.TabIndex = 10;
            mnuMain.Text = "menuStrip1";
            // 
            // itmFile
            // 
            itmFile.DropDownItems.AddRange(new ToolStripItem[] { itmAbout, itmSettings, toolStripSeparator1, itmQuit });
            itmFile.Name = "itmFile";
            itmFile.Size = new Size(37, 20);
            itmFile.Text = "File";
            // 
            // itmAbout
            // 
            itmAbout.Name = "itmAbout";
            itmAbout.Size = new Size(116, 22);
            itmAbout.Text = "About...";
            itmAbout.Click += aboutToolStripMenuItem_Click;
            // 
            // itmSettings
            // 
            itmSettings.Name = "itmSettings";
            itmSettings.Size = new Size(116, 22);
            itmSettings.Text = "Settings";
            itmSettings.Click += toolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(113, 6);
            // 
            // itmQuit
            // 
            itmQuit.Name = "itmQuit";
            itmQuit.Size = new Size(116, 22);
            itmQuit.Text = "Quit";
            itmQuit.Click += quitToolStripMenuItem_Click;
            // 
            // gBoxSettings
            // 
            gBoxSettings.Controls.Add(label1);
            gBoxSettings.Controls.Add(lblCustomFileName);
            gBoxSettings.Controls.Add(lblCustomWordList);
            gBoxSettings.Controls.Add(btnOpenWordList);
            gBoxSettings.Location = new Point(724, 27);
            gBoxSettings.Name = "gBoxSettings";
            gBoxSettings.Size = new Size(225, 144);
            gBoxSettings.TabIndex = 11;
            gBoxSettings.TabStop = false;
            gBoxSettings.Text = "Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 92);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 14;
            label1.Text = "Current Wordlist:";
            // 
            // lblCustomFileName
            // 
            lblCustomFileName.AutoSize = true;
            lblCustomFileName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomFileName.Location = new Point(17, 107);
            lblCustomFileName.Name = "lblCustomFileName";
            lblCustomFileName.Size = new Size(63, 21);
            lblCustomFileName.TabIndex = 2;
            lblCustomFileName.Text = "Default";
            // 
            // lblCustomWordList
            // 
            lblCustomWordList.AutoSize = true;
            lblCustomWordList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomWordList.Location = new Point(17, 28);
            lblCustomWordList.Name = "lblCustomWordList";
            lblCustomWordList.Size = new Size(132, 21);
            lblCustomWordList.TabIndex = 1;
            lblCustomWordList.Text = "Custom Wordlist";
            // 
            // btnOpenWordList
            // 
            btnOpenWordList.Location = new Point(17, 52);
            btnOpenWordList.Name = "btnOpenWordList";
            btnOpenWordList.Size = new Size(75, 23);
            btnOpenWordList.TabIndex = 0;
            btnOpenWordList.Text = "Open...";
            btnOpenWordList.UseVisualStyleBackColor = true;
            btnOpenWordList.Click += btnOpenWordList_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(869, 177);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 12;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(788, 177);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(957, 481);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(gBoxSettings);
            Controls.Add(btnReroll);
            Controls.Add(btnEndTurn);
            Controls.Add(btnNewTurn);
            Controls.Add(gboxResults);
            Controls.Add(groupBox2);
            Controls.Add(mnuMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnuMain;
            Name = "Form1";
            Text = "WTF Does That Stand For?";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gboxResults.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            gBoxSettings.ResumeLayout(false);
            gBoxSettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Label lblTurnDisplay;
        private Button btnSubmit;
        private TextBox txtPlayerInput;
        private Label lblAcronymDisplay;
        private GroupBox gboxResults;
        private Label label3;
        private Button btnNewTurn;
        private Button btnEndTurn;
        private ListBox listBoxResults;
        private Button btnReroll;
        private MenuStrip mnuMain;
        private ToolStripMenuItem itmFile;
        private ToolStripMenuItem itmAbout;
        private ToolStripMenuItem itmSettings;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem itmQuit;
        private GroupBox gBoxSettings;
        private Button btnApply;
        private Button btnCancel;
        private Label lblCustomWordList;
        private Button btnOpenWordList;
        private Label lblCustomFileName;
        private Label label1;
    }
}
