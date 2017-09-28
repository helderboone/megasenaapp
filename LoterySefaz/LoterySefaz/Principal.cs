using LoterySefaz.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LoterySefaz
{
    public partial class Principal : Form
    {
        private Random rnd = new Random();
        public Player player { get; set; }
        public Bet bet { get; set; }
        
        public List<int> values = new List<int>();
        public List<Bet> amountBets = new List<Bet>();

        public Principal()
        {
            player = new Player();
            bet = new Bet();
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Check if the fields are filled correctly   
            if (string.IsNullOrEmpty(txtBetAmount.Text.Replace("_", "").Trim()) || string.IsNullOrEmpty(txtName.Text.Trim()) )
            {
                MessageBox.Show("Fill the fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Not allow amount of zero numbers chosen
            if (Convert.ToInt32(txtBetAmount.Text) == 0)
            {
                MessageBox.Show("Can not be 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chkGenerateBet.Checked)
            {
                var betAmount = 1;

                while (player.BetList.Count < Convert.ToInt32(txtBetAmount.Text))
                {
                    bet = new Bet();

                    values = new List<int>();

                    var possibleNumbers = new List<int>();

                    for (int i = 1; i <= Constants.MegaSenaRange; i++)
                    {
                        possibleNumbers.Add(i);
                    }
                        
                    var drawnNumbersLoterry = from n in possibleNumbers orderby rnd.Next(possibleNumbers.Count) select n;

                    foreach (var number in drawnNumbersLoterry)
                    {
                        if (values.Count == Constants.Sena)
                        {
                            break;
                        }

                        values.Add(number);
                    }

                    bet.BetId = betAmount;
                    bet.Numbers = values;
                    bet.BetDate = DateTime.Now;

                    player.Name = txtName.Text;
                    player.BetList.Add(bet);
                    player.AmountBetNumber++;

                    //Reset the values
                    values = null;
                    bet = null;
                }


                var draw = new Draw(this);

                draw.Show();

                Hide();
            }
            else
            {
                player.Name = txtName.Text;

                player.AmountBetNumber = Convert.ToInt32(txtBetAmount.Text);

                var numbersChosen = new NumbersChosen(this);

                numbersChosen.Show();

                Hide();
            }
        }
    }
}
