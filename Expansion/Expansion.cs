using Expansion.Controls;
using Expansion.Models;
using Expansion.Models.Algorithms;
using Expansion.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expansion
{
    public partial class MainForm : Form
    {
        private Game game;
        private BoardControl control;
        private ColorPicker colorPicker;
        private Color[] colors;
        static string[] rndColors = new string[] {
            "FF0000", "00FF00", "0000FF", "FFFF00", "FF00FF", "00FFFF", "000000",
            "800000", "008000", "000080", "808000", "800080", "008080", "808080",
            "C00000", "00C000", "0000C0", "C0C000", "C000C0", "00C0C0", "C0C0C0",
            "400000", "004000", "000040", "404000", "400040", "004040", "404040",
            "200000", "002000", "000020", "202000", "200020", "002020", "202020",
            "600000", "006000", "000060", "606000", "600060", "006060", "606060",
            "A00000", "00A000", "0000A0", "A0A000", "A000A0", "00A0A0", "A0A0A0",
            "E00000", "00E000", "0000E0", "E0E000", "E000E0", "00E0E0", "E0E0E0",
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            game.NextMove();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            game.NextMove();
        }

        /// <summary>
        /// Start new game
        /// </summary>
        private void NewGame()
        {
            var settings = new SettingsForm();
            if (settings.ShowDialog() != DialogResult.OK) return;
            var maxColor = settings.Colors;
            GenerateColors(maxColor);
            // set up the game
            game = new Game(settings.Player1, settings.Player2, settings.BoardSize, maxColor);
            game.Update += Game_Update;
            game.End += Game_End;
            // create a new board
            control = new BoardControl(game.Board, colors);
            control.CellClick += Control_CellClick;
            boardPanel.Controls.Clear();
            boardPanel.Controls.Add(control);
            // create color pickers
            colorPicker = new ColorPicker(colors, game.GetMoves());
            colorPicker.CellClick += Control_CellClick;
            SwitchPicker(game.CurrentPlayer, game.CurPlayer.Bot);
            //set scores
            UpdateScores();
            //set names
            player1Label.Text = game.Player1.Name;
            player2Label.Text = game.Player2.Name;
        }

        /// <summary>
        /// Show a victory message and restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_End(object sender, EventArgs e)
        {
            var lastGame = (Game)sender;
            var message = "";
            if (lastGame.Player1.Score > lastGame.Player2.Score)
            {
                message = lastGame.Player1.Name + " won !";
            }
            else if (lastGame.Player1.Score < lastGame.Player2.Score)
            {
                message = lastGame.Player2.Name + " won !";
            }
            else
            {
                message = "Draw !";
            }
            MessageBox.Show(message, "", MessageBoxButtons.OK);
            NewGame();
            game.NextMove();
        }
        
        /// <summary>
        /// Generate random colors
        /// </summary>
        /// <param name="maxColor">number of colors to generate</param>
        private void GenerateColors(int maxColor)
        {
            colors = new Color[maxColor];
            for (int i = 0; i < maxColor; i++)
            {
                Color color;
                do
                {
                    int argb = Int32.Parse("FF" + rndColors[Rand.Next(rndColors.Length)], NumberStyles.HexNumber);
                    color = Color.FromArgb(argb);
                } while (colors.Contains(color));
                colors[i] = color;
            }
        }

        /// <summary>
        /// Update the boards UI after a move 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_Update(object sender, EventArgs e)
        {
            control.UpdateBoard(game.Board);
            SwitchPicker(game.CurrentPlayer, game.CurPlayer.Bot);
            colorPicker.UpdateColorPicker(game.GetMoves());
            //control.Refresh();
            UpdateScores();
        }

        /// <summary>
        /// Update Score labels
        /// </summary>
        public void UpdateScores()
        {
            score1Label.Text = game.Player1.Score.ToString();
            score2Label.Text = game.Player2.Score.ToString();
            Refresh();
        }

        /// <summary>
        /// Detect a click on the one of the cells 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_CellClick(object sender, EventArgs e)
        {
            if (!game.CurPlayer.Bot)
            {
                game.MakeMove(((CellControl)sender).Cell.Color);
            }
        }

        /// <summary>
        /// Switch place of thecolor picker
        /// </summary>
        /// <param name="player">current player</param>
        /// <param name="bot">true if current player is a bot</param>
        private void SwitchPicker(int player, bool bot)
        {
            colorPanel1.Controls.Clear();
            colorPanel2.Controls.Clear();
            if (bot)
            {
                return;
            }
            if (player == 0)
            {
                colorPanel1.Controls.Add(colorPicker);
            }
            else
            {
                colorPanel2.Controls.Add(colorPicker);
            }
        }
    }
}
