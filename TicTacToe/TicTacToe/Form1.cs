﻿using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[] _grid;
        private string[] _tokens = new string[] { "X", "0" };
        private int _currentToken = 0;

        private TicTacToeEngine _engine = new TicTacToeEngine();

        public Form1()
        {
            InitializeComponent();
            InitalizeGameBoard();
        }

        private void InitalizeGameBoard()
        {
            _grid = new Button[]
            {
                button0, button1, button2,
                button3, button4, button5,
                button6, button7, button8
            };

            var index = 0;
            foreach (var button in _grid)
            {
                button.Text = "";
                button.Enabled = false;
                var indexCopy = index;
                button.Click += (o, e) =>
                  {
                      MakeMove(o as Button, indexCopy);
                  };
                index++;
            }
        }

        private void MakeMove(Button b, int index)
        {
            b.Text = _tokens[_currentToken];
            _currentToken++;
            _currentToken %= 2;
            CurrentPlayer.Text = _tokens[_currentToken];

            _engine.Place(index);
            b.Enabled = false;

            var winner = _engine.IsVictory();
            if (winner == -1)
            {
                CatsGame();
            } 
            else if (winner > 0)
            {
                WinnerIs(winner - 1);
            }
        }

        private void WinnerIs(int id)
        {
            newGame.Enabled = true;
            Toggle(false);
            var winner = _tokens[id];
            MessageBox.Show($"Congratulations! {winner} wins!");
        }

        private void CatsGame()
        {
            newGame.Enabled = true;
            Toggle(false);
            MessageBox.Show("Cat's Game :(");
        }

        private void Toggle(bool enabled)
        {
            foreach (var button in _grid)
            {
                button.Enabled = enabled;
                if (enabled)
                {
                    button.Text = "";
                }
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            _engine.NewGame();
            Toggle(true);
            newGame.Enabled = false;
            _currentToken = 0;
            CurrentPlayer.Text = _tokens[_currentToken];
        }
    }
}
