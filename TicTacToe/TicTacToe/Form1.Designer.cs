﻿namespace TicTacToe
{
    partial class Form1
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
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.CurrentPlayer = new System.Windows.Forms.Label();
            this.PlayerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(12, 12);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(180, 180);
            this.button0.TabIndex = 0;
            this.button0.Text = "X";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(198, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 180);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 180);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 180);
            this.button3.TabIndex = 3;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(198, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 180);
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(384, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 180);
            this.button5.TabIndex = 5;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 384);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 180);
            this.button6.TabIndex = 6;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(198, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 180);
            this.button7.TabIndex = 7;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(384, 384);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 180);
            this.button8.TabIndex = 8;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(620, 12);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(369, 74);
            this.newGame.TabIndex = 9;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Controls.Add(this.CurrentPlayer);
            this.PlayerBox.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBox.Location = new System.Drawing.Point(620, 92);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(369, 252);
            this.PlayerBox.TabIndex = 10;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Text = "Current Player";
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.AutoSize = true;
            this.CurrentPlayer.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayer.Location = new System.Drawing.Point(119, 76);
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.Size = new System.Drawing.Size(126, 135);
            this.CurrentPlayer.TabIndex = 0;
            this.CurrentPlayer.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 572);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PlayerBox.ResumeLayout(false);
            this.PlayerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.Label CurrentPlayer;
    }
}

