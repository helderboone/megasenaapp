using LoterySefaz.Core;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoterySefaz
{
    public partial class Draw : Form
    {
        private readonly Principal principal;

        public Draw(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void Draw_Load(object sender, System.EventArgs e)
        {
            var sena = new MegaSena();

            var result = sena.Draw(principal.player);

            lblDrawResult.Text = lblDrawResult.Text + result["Result"];

            lblBetList.Text = lblBetList.Text +  result["Bet"];

            lblQuinaWinners.Text = lblQuinaWinners.Text + result["Quina"];

            lblQuadraWinners.Text = lblQuadraWinners.Text + result["Quadra"];

            lblSenaWinners.Text = lblSenaWinners.Text + result["Sena"];
        }
    }
}
