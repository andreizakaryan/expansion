using Expansion.Models;
using Expansion.Models.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expansion
{
    public partial class SettingsForm : Form
    {
        public Player Player1;
        public Player Player2;
        public int BoardSize
        {
            get => (int)sizeNumeric.Value;
        }
        public int Colors
        {
            get => (int)colorsNumeric.Value;
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Player1 = new Player();
            Player2 = new Player();
            name1Box.Text = Player1.Name = "Player 1";
            name2Box.Text = Player2.Name = "Player 2";
            player1Type.SelectedIndex = 0;
            player2Type.SelectedIndex = 0;
            strategy1Combo.SelectedIndex = 0;
            strategy2Combo.SelectedIndex = 0;
            strategy1Combo.Visible = false;
            strategy2Combo.Visible = false;
            depth1Numeric.Visible = false;
            depth2Numeric.Visible = false;
            sizeNumeric.Value = 10;
            colorsNumeric.Value = 5;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            switch (strategy1Combo.SelectedIndex)
            {
                case 0:                    
                    Player1.Strategy = new StrategyRandom();
                    break;
                case 1:
                    Player1.Strategy = new StrategyAlphaBeta((int)depth1Numeric.Value, 0);
                    break;
            }
            switch (strategy2Combo.SelectedIndex)
            {
                case 0:
                    Player2.Strategy = new StrategyRandom();
                    break;
                case 1:
                    Player2.Strategy = new StrategyAlphaBeta((int)depth2Numeric.Value, 1);
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void player1Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player1.Bot = ((ComboBox)sender).SelectedIndex != 0;
            strategy1Combo.Visible = !strategy1Combo.Visible;
            depth1Numeric.Visible = Player1.Bot && strategy1Combo.SelectedIndex == 1;
        }

        private void player2Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player2.Bot = ((ComboBox)sender).SelectedIndex != 0;
            strategy2Combo.Visible = !strategy2Combo.Visible;
            depth2Numeric.Visible = Player2.Bot && strategy2Combo.SelectedIndex == 1;
        }

        private void name1Box_TextChanged(object sender, EventArgs e)
        {
            Player1.Name = ((TextBox)sender).Text;
        }

        private void name2Box_TextChanged(object sender, EventArgs e)
        {
            Player2.Name = ((TextBox)sender).Text;
        }

        private void strategy1Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            depth1Numeric.Visible = ((ComboBox)sender).SelectedIndex == 1;
        }

        private void strategy2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            depth2Numeric.Visible = ((ComboBox)sender).SelectedIndex == 1;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
