using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinGame
{
    public partial class Interface : Form
    {

        private GameEngine gameEngine;


        public Interface()
        {
            InitializeComponent();

            

            

        }

        public void Populate(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies)
        {
            gameEngine = new GameEngine(minWidth, maxWidth, minHeight, maxHeight, numOfEnemies);
        }

        public void UpdateForm()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = gameEngine.ToString();
        }
    }
}
