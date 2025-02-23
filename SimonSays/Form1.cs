﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

// James Hopper ICS4U
// Feburary 20, 2023
namespace SimonSays
{
    public partial class Form1 : Form
    {
        public static int guesses = 0;
        public static SoundPlayer menu = new SoundPlayer(Properties.Resources.menuMusic);
        //TODO: create a List to store the pattern. Must be accessable on other screens
        public static List<int> patterns = new List<int>();
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //TODO: Launch MenuScreen
            MenuScreen ms = new MenuScreen();

            //Center screen
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

            this.Controls.Add(ms);
            ms.Focus();
        }

        public void gameTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
