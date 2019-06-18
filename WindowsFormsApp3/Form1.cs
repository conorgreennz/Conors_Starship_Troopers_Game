﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StarShip_Troopers
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
            // Secondary image provides as a base for the computer to reference while the image rotates and pixelates 

            OGShipImage = GetResourceByImageName("Ship");
            OGShipImage.MakeTransparent(Color.Black);

            OGEnemyImage = GetResourceByImageName("Enemy");
            OGEnemyImage.MakeTransparent(Color.Black);

            OGBulletImage = GetResourceByImageName("Bullet");
            OGBulletImage.MakeTransparent(Color.Black);

            //create and set the variables for the moving components
            myShip = new Ship();
            myShip.X = 50;
            myShip.Y = 140;
            myShip.Angle = 0;

        }
        public Bitmap GetResourceByImageName(string imageName) // collect the resource using its name as a reference
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
