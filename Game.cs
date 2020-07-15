﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {
        Area area = new Area();
        Snake snake = new Snake();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Height = 600;
            this.Width = 600;

            this.Controls.Add(area);
            area.Top = 100;
            area.Left = 100;

            snake.Render(this);
        }
    }
}
