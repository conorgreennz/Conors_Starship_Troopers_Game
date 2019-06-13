using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Random RandomNumber;  // create a new random number generator
        Bitmap OGShipImage; // create a new variable as the orignal ship image incase ship image is damaged during rotation
        Bitmap ShipImage; // create a new variable as the ship image 
        Ship myShip; // create new variable called my ship
        Bitmap OGEnemyImage; // create a new vairable called original Enemy image incase Enemy image gets damaged during rotation
        Bitmap OGBulletImage; // create a new variable called original bullet image incse bullet image gets damaged during rotation
        List<Enemy> EnemyList; // create a new list variable called Enemylist ( this is to hold the many Enemies used on the form)
        List<Bullet> bulletList; // create a new list for the bullets on the game panel and call it bullet list

        int EnemySpeed;

        int Points, lives;

        const int maxEnemies = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
