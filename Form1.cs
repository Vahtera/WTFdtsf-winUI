using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WTFdtsf_winUI
{
    public partial class Form1 : Form
    {
        List<string> lstResults = new List<string>();
        List<string> asChar = new List<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().Select(c => c.ToString()).ToList());
        int numPlayer = 1;
        int asLength;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            listBoxResults.Items.Clear();
            lblTurnDisplay.Text = "Player " + numPlayer.ToString();
            btnNewTurn.Enabled = false;

            asLength = WeightedRandomLength();
            int asLocation = random.Next(0, asLength);
            int isWord = random.Next(0, 2);

            Randomize();
            lblAcronymDisplay.Text = SetAcronymDisplay(asLength);
        }

        private static int WeightedRandomLength()
        {
            Random random = new Random();
            // Define weights for each length from 2 to 7
            Dictionary<int, int> weights = new Dictionary<int, int>
            {
                { 2, 5 },
                { 3, 55 },
                { 4, 30 },
                { 5, 5 },
                { 6, 3 },
                { 7, 2 }
            };

            // Calculate the total weight
            int totalWeight = weights.Values.Sum();

            // Generate a random number between 0 and totalWeight - 1
            int randomNumber = random.Next(totalWeight);

            // Determine the length based on the random number and weights
            int cumulativeWeight = 0;
            foreach (var kvp in weights)
            {
                cumulativeWeight += kvp.Value;
                if (randomNumber < cumulativeWeight)
                {
                    return kvp.Key;
                }
            }

            // Fallback in case of an error
            return 2;
        }

        private string SetAcronymDisplay(int nymLength)
        {
            Random random = new Random();
            string tAcronymDisplay = string.Empty;
            for (int i = 0; i < nymLength; i++)
            {
                tAcronymDisplay += asChar[random.Next(asChar.Count)] + " ";
            }
            return tAcronymDisplay.Trim();
        }

        private void Randomize()
        {
            Random random = new Random();
            asLength = WeightedRandomLength();
            int asLocation = random.Next(0, asLength);
            int isWord = random.Next(0, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(745, 230);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            Size = new Size(745, 500);
            btnSubmit.Enabled = false;
            txtPlayerInput.Enabled = false;
            lblTurnDisplay.Text = "---";
            btnEndTurn.Enabled = false;
            btnNewTurn.Enabled = true;

            ListBox.ObjectCollection list = listBoxResults.Items;
            Random random = new Random();
            int n = list.Count;
            listBoxResults.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            listBoxResults.EndUpdate();
            listBoxResults.Invalidate();
        }

        private void btnNewTurn_Click(object sender, EventArgs e)
        {
            Size = new Size(745, 230);
            numPlayer = 1;
            lblTurnDisplay.Text = "Player " + numPlayer.ToString();
            btnSubmit.Enabled = true;
            txtPlayerInput.Enabled = true;
            listBoxResults.Items.Clear();
            btnEndTurn.Enabled = true;
            btnNewTurn.Enabled = false;
            btnReroll.Enabled = true;
            Randomize();
            lblAcronymDisplay.Text = SetAcronymDisplay(asLength);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Add(txtPlayerInput.Text);
            txtPlayerInput.Text = string.Empty;
            numPlayer++;
            lblTurnDisplay.Text = "Player " + numPlayer.ToString();
            btnReroll.Enabled = false;
        }

        private void bteReroll_Click(object sender, EventArgs e)
        {
            Randomize();
            lblAcronymDisplay.Text = SetAcronymDisplay(asLength);
        }
    }
}
