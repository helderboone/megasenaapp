namespace LoterySefaz
{
    partial class Draw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBetList = new System.Windows.Forms.Label();            
            this.lblDrawResult = new System.Windows.Forms.Label();
            this.lblQuadraWinners = new System.Windows.Forms.Label();
            this.lblQuinaWinners = new System.Windows.Forms.Label();
            this.lblSenaWinners = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.lblBetList.AutoSize = true;
            this.lblBetList.Location = new System.Drawing.Point(70, 222);
            this.lblBetList.Name = "lblBetList";
            this.lblBetList.Size = new System.Drawing.Size(56, 13);
            this.lblBetList.TabIndex = 11;
            this.lblBetList.Text = "All Bet List";
            
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(362, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(161, 27);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "See the champions below";
            
            this.lblDrawResult.AutoSize = true;
            this.lblDrawResult.Location = new System.Drawing.Point(70, 106);
            this.lblDrawResult.Name = "lblDrawResult";
            this.lblDrawResult.Size = new System.Drawing.Size(65, 13);
            this.lblDrawResult.TabIndex = 9;
            this.lblDrawResult.Text = "Draw Result";
            
            this.lblQuadraWinners.AutoSize = true;
            this.lblQuadraWinners.Location = new System.Drawing.Point(70, 195);
            this.lblQuadraWinners.Name = "lblQuadraWinners";
            this.lblQuadraWinners.Size = new System.Drawing.Size(84, 13);
            this.lblQuadraWinners.TabIndex = 8;
            this.lblQuadraWinners.Text = "Quadra Winners";
            
            this.lblQuinaWinners.AutoSize = true;
            this.lblQuinaWinners.Location = new System.Drawing.Point(69, 163);
            this.lblQuinaWinners.Name = "lblQuinaWinners";
            this.lblQuinaWinners.Size = new System.Drawing.Size(77, 13);
            this.lblQuinaWinners.TabIndex = 7;
            this.lblQuinaWinners.Text = "Quina Winners";
            
            this.lblSenaWinners.AutoSize = true;
            this.lblSenaWinners.Location = new System.Drawing.Point(69, 136);
            this.lblSenaWinners.Name = "lblSenaWinners";
            this.lblSenaWinners.Size = new System.Drawing.Size(74, 13);
            this.lblSenaWinners.TabIndex = 6;
            this.lblSenaWinners.Text = "Sena Winners";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1027, 796);
            this.Controls.Add(this.lblBetList);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDrawResult);
            this.Controls.Add(this.lblQuadraWinners);
            this.Controls.Add(this.lblQuinaWinners);
            this.Controls.Add(this.lblSenaWinners);
            this.Name = "Draw";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Draw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuadraWinners;
        private System.Windows.Forms.Label lblQuinaWinners;
        private System.Windows.Forms.Label lblSenaWinners;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblBetList;
        private System.Windows.Forms.Label lblDrawResult;
    }
}