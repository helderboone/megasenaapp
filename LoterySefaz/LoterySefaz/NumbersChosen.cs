using LoterySefaz.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoterySefaz
{
    public partial class NumbersChosen : Form
    {
        private readonly Principal principalForm;

        private int count;
        private int betAmount = 1;

        public List<List<int>> amountValues = new List<List<int>>();
        public Dictionary<int, List<int>> numbers = new Dictionary<int, List<int>>();
        public List<int> values = new List<int>();

        public List<int> columnList = new List<int>();
        
        public NumbersChosen(Principal principalForm)
        {
            this.principalForm = principalForm;
            InitializeComponent();
        }

        private void ChosenNumbers_Load(object sender, EventArgs e)
        {
            if (principalForm.player.AmountBetNumber > 1)
            {
                btnNext.Hide();

                btnAnotherBet.Show();
            }
            else
            {
                btnNext.Show();

                btnAnotherBet.Hide();
            }

            FillGrid();
        }

        private void FillGrid()
        {
            grdNumbers.Rows.Clear();

            numbers = new Dictionary<int, List<int>>();

            int j = 1;

            for (int i = 1; i <= Constants.MegaSenaRange; i++)
            {
                columnList.Add(i);

                if (columnList.Count == Constants.Sena)
                {
                    numbers.Add(j, columnList);
                    columnList = new List<int>();

                    j++;
                }
            }

            foreach (var number in numbers)
            {
                int rowNum = grdNumbers.Rows.Add(new object[] 
                       { null, number.Value[0],
                        null, number.Value[1],
                        null, number.Value[2],
                        null, number.Value[3],
                        null, number.Value[4],
                        null, number.Value[5] });
            }
        }

        private void FillValues()
        {
            foreach (DataGridViewRow line in grdNumbers.Rows)
            {
                foreach (DataGridViewColumn column in grdNumbers.Columns)
                {
                    if (grdNumbers.Rows[line.Index].Cells[column.Index].GetType() == typeof(DataGridViewCheckBoxCell)
                        && Convert.ToBoolean(grdNumbers.Rows[line.Index].Cells[column.Index].Value) == true)
                    {
                        values.Add(Convert.ToInt32(grdNumbers.Rows[line.Index].Cells[column.Index + 1].Value));
                    }
                }
            }
        }

        private void grdNumbers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            count = 0;

            foreach (DataGridViewRow linha in grdNumbers.Rows)
            {
                foreach (DataGridViewColumn column in grdNumbers.Columns)
                {
                    if (linha.Cells[column.Index].ValueType == typeof(bool))
                    {
                        //Check if the limit of possible numbers were hit
                        if (count == 7)
                        {
                            grdNumbers.CurrentCell.Value = false;

                            MessageBox.Show("Six numbers allowed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }

                        if (Convert.ToBoolean(linha.Cells[column.Index].Value) == true)
                        {
                            count++;
                        }
                    }
                }
            }
        }

        private void grdNumbers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (grdNumbers.IsCurrentCellDirty && grdNumbers.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                grdNumbers.EndEdit();
            }
        }

        private void btnAnotherBet_Click(object sender, EventArgs e)
        {
            if (count < Constants.Sena)
            {
                MessageBox.Show("Choose six numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            FillValues();

            var bet = new Bet();
            bet.BetId = betAmount;
            bet.BetDate = DateTime.Now;
            bet.Numbers = values;

            principalForm.player.BetList.Add(bet);

            values = new List<int>();

            FillGrid();

            if (betAmount == principalForm.player.AmountBetNumber - 1)
            {
                btnNext.Show();

                btnAnotherBet.Hide();
            }

            betAmount++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count < Constants.Sena)
            {
                MessageBox.Show("Choose six numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            FillValues();

            var bet = new Bet();
            bet.BetDate = DateTime.Now;
            bet.Numbers = values;

            principalForm.player.BetList.Add(bet);

            var draw = new Draw(principalForm);

            draw.Show();

            Hide();
        }
    }
}
