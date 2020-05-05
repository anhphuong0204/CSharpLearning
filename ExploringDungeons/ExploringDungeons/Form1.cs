﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploringDungeons
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender,
        EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {

        }
    }
}
