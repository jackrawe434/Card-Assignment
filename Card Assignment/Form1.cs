using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Card_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphics, starting clear, sound, and green pen setup
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Pen greenPen = new Pen(Color.Green, 10);
            SoundPlayer keyboardClick = new SoundPlayer(Properties.Resources.Button);

            //Dialogue box
            g.DrawRectangle(greenPen, 55, 45, 700, 350);

            //"Agent 47" text


            // Note: Letters are spaced 25 pixels apart
            // Note: Spaces inbetween words are 50 pixels apart

            //A
            Font greenFont = new Font("mono 07_55", 20, FontStyle.Bold);
            SolidBrush startUpText = new SolidBrush(Color.Green);
            g.DrawString("A", greenFont, startUpText, 70, 70);
            keyboardClick.Play();
            Thread.Sleep(100);

            //G
            g.DrawString("G", greenFont, startUpText, 95, 70);
            keyboardClick.Play();
            Thread.Sleep(100);

            //E
            g.DrawString("E", greenFont, startUpText, 120, 70);
            keyboardClick.Play();
            Thread.Sleep(100);

            //N
            g.DrawString("N", greenFont, startUpText, 145, 70);
            keyboardClick.Play();
            Thread.Sleep(100);

            //T
            g.DrawString("T", greenFont, startUpText, 170, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //4
            g.DrawString("4", greenFont, startUpText, 220, 70);
            keyboardClick.Play();
            Thread.Sleep(100);

            //7
            g.DrawString("7", greenFont, startUpText, 245, 70);
            keyboardClick.Play();
            Thread.Sleep(100);

            //:
            g.DrawString(":", greenFont, startUpText, 260, 70);
            keyboardClick.Play();
            Thread.Sleep(100);


            //"Your mission is to eliminate" text

                //Your

            //Y
            g.DrawString("Y", greenFont, startUpText, 70, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //O
            g.DrawString("O", greenFont, startUpText, 95, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //U
            g.DrawString("U", greenFont, startUpText, 120, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //R
            g.DrawString("R", greenFont, startUpText, 145, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

             //Mission

            //M
            g.DrawString("M", greenFont, startUpText, 195, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //I
            g.DrawString("I", greenFont, startUpText, 220, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //S
            g.DrawString("S", greenFont, startUpText, 245, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //S
            g.DrawString("S", greenFont, startUpText, 270, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //I
            g.DrawString("I", greenFont, startUpText, 295, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //O
            g.DrawString("O", greenFont, startUpText, 320, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //N
            g.DrawString("N", greenFont, startUpText, 345, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

             //"Is"

            //I
            g.DrawString("I", greenFont, startUpText, 395, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //S
            g.DrawString("S", greenFont, startUpText, 420, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

                //"To"

            //T
            g.DrawString("T", greenFont, startUpText, 470, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

            //O
            g.DrawString("O", greenFont, startUpText, 495, 120);
            keyboardClick.Play();
            Thread.Sleep(100);

                //"Eliminate"

            //E
            g.DrawString("E", greenFont, startUpText, 70, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //L
            g.DrawString("L", greenFont, startUpText, 95, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //I
            g.DrawString("I", greenFont, startUpText, 120, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //M
            g.DrawString("M", greenFont, startUpText, 145, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //I
            g.DrawString("I", greenFont, startUpText, 170, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //N
            g.DrawString("N", greenFont, startUpText, 195, 170);
            keyboardClick.Play();
            Thread.Sleep(100);
         
            //A
            g.DrawString("A", greenFont, startUpText, 220, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //T
            g.DrawString("T", greenFont, startUpText, 245, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //E
            g.DrawString("E", greenFont, startUpText, 270, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

                //"Mr."

            //M
            g.DrawString("M", greenFont, startUpText, 320, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //r
            g.DrawString("r", greenFont, startUpText, 345, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //.
            g.DrawString(".", greenFont, startUpText, 361, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

                //"White"

            //W
            g.DrawString("W", greenFont, startUpText, 411, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //H
            g.DrawString("H", greenFont, startUpText, 436, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //I
            g.DrawString("I", greenFont, startUpText, 461, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //T
            g.DrawString("T", greenFont, startUpText, 486, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //E
            g.DrawString("E", greenFont, startUpText, 511, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //,
            g.DrawString(",", greenFont, startUpText, 526, 170);
            keyboardClick.Play();
            Thread.Sleep(100);

            //"Good"

            //G
            g.DrawString("G", greenFont, startUpText, 70, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //O
            g.DrawString("O", greenFont, startUpText, 95, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //O
            g.DrawString("O", greenFont, startUpText, 120, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //D
            g.DrawString("D", greenFont, startUpText, 145, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

                //"Luck"

            //L
            g.DrawString("L", greenFont, startUpText, 195, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //U
            g.DrawString("U", greenFont, startUpText, 220, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //C
            g.DrawString("C", greenFont, startUpText, 245, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //K
            g.DrawString("K", greenFont, startUpText, 270, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //.
            g.DrawString(".", greenFont, startUpText, 295, 220);
            keyboardClick.Play();
            Thread.Sleep(100);

            //"Click To Begin"
            g.DrawString("Click To Begin...", greenFont, startUpText, 250, 400);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Click event setup 
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            SoundPlayer reload = new SoundPlayer(Properties.Resources.Reload);
            SoundPlayer shoot = new SoundPlayer(Properties.Resources.Shoot);
            SoundPlayer bomb = new SoundPlayer(Properties.Resources.Bomb);

            //Brush setup
            SolidBrush greenBrush = new SolidBrush(Color.ForestGreen);
            Pen blackPen = new Pen(Color.Black, 9);
            Pen whitePen = new Pen(Color.White, 12);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush grayBrush = new SolidBrush(Color.Gray);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);

            //String setup
            Font endFont = new Font("Times New Roman", 20, FontStyle.Bold);

            //Start eventreload.Play();
            reload.Play();
            Thread.Sleep(1000);
            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

                //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 280, 100, 150);

             //Sniper Reticle

            //Black circle
            g.DrawEllipse(blackPen, 600, 200, 80, 80);

         


                //Frame 1 

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 599, 199, 80, 80);


            Thread.Sleep(50);

            //Frame 2

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 598, 198, 80, 80);

            Thread.Sleep(50);

                //Frame 3

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 597, 197, 80, 80);

            Thread.Sleep(50);


            //Frame 4

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 596, 196, 80, 80);

            Thread.Sleep(50);


            //Frame 5

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 595, 195, 80, 80);

            Thread.Sleep(50);

             //Frame 6

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 594, 194, 80, 80);

            Thread.Sleep(50);

            //Frame 7

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 593, 193, 80, 80);

            Thread.Sleep(50);

            //Frame 7

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 592, 192, 80, 80);

            Thread.Sleep(50);

                //Frame 8

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 591, 191, 80, 80);

            Thread.Sleep(50);

             //Frame 9

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 590, 190, 80, 80);

            Thread.Sleep(50);

                //Frame 10

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 589, 189, 80, 80);

            Thread.Sleep(50);

            //Frame 11

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 588, 188, 80, 80);

            Thread.Sleep(500);

            //Frame 12

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 587, 187, 80, 80);

            Thread.Sleep(50);

                //Frame 13

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 586, 186, 80, 80);

            Thread.Sleep(50);

                //Frame 14

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 585, 185, 80, 80);

            Thread.Sleep(50);

             //Frame 15

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 584, 184, 80, 80);

            Thread.Sleep(50);

                //Frame 16

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 583, 183, 80, 80);

            Thread.Sleep(50);

             //Frame 17

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 582, 182, 80, 80);

            Thread.Sleep(50);

             //Frame 18

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 581, 181, 80, 80);


            Thread.Sleep(50);

             //Frame 19

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 580, 180, 80, 80);

            Thread.Sleep(50);

            //Frame 20

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 579, 179, 80, 80);

           

            Thread.Sleep(50);

            //Frame 21

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 578, 178, 80, 80);

            Thread.Sleep(50);

            //Frame 22

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 577, 177, 80, 80);

            Thread.Sleep(50);

            //Frame 23

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 576, 176, 80, 80);

            Thread.Sleep(50);

            //Frame 24

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 575, 175, 80, 80);

            Thread.Sleep(50);

            //Frame 25

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 574, 174, 80, 80);

            Thread.Sleep(50);

            //Frame 26

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 573, 173, 80, 80);

            Thread.Sleep(50);

            //Frame 27

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 572, 172, 80, 80);

            Thread.Sleep(50);

            //Frame 28

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 571, 171, 80, 80);

            Thread.Sleep(50);

                              //Frame 29

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 570, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 30

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 569, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 31

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 568, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 32

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 567, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 33

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 566, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 34

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 565, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 35

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 564, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 36

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 563, 170, 80, 80);

            Thread.Sleep(50);

            //Frame 37

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Reticle
            g.DrawEllipse(blackPen, 562, 170, 80, 80);

            Thread.Sleep(50);

            //Fire sound
            shoot.Play();

            //Bullet
            g.FillRectangle(yellowBrush, 570, 175, 55, 55);
            Thread.Sleep(1000);

            //Frame 38

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);


            //Frame 38

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 575, 176, 45, 45);
            Thread.Sleep(1000);


            //Frame 39

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 575, 176, 45, 45);
            Thread.Sleep(1000);



            //Frame 40

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 575, 176, 45, 45);
            Thread.Sleep(1000);

            //Frame 41

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 575, 176, 45, 45);
            Thread.Sleep(100);

            //Frame 42

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 576, 177, 35, 35);
            Thread.Sleep(100);


            //Frame 44

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 577, 178, 25, 25);
            Thread.Sleep(100);


            //Frame 45

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            g.FillRectangle(yellowBrush, 578, 179, 15, 15);
            Thread.Sleep(100);



            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);


            g.FillRectangle(yellowBrush, 579, 180, 5, 5);
            Thread.Sleep(100);

            //Explosion
            bomb.Play();

            //Frame 44

            g.Clear(Color.SkyBlue);

            //Grass
            g.FillRectangle(greenBrush, 0, 220, 2000, 1500);

            //Sidewalk
            g.FillRectangle(grayBrush, 0, 290, 900, 50);

            //Sun
            g.FillEllipse(yellowBrush, 0, 0, 90, 100);

            //Mr. White

            //Mr. White legs 
            g.DrawLine(whitePen, 300, 285, 317, 210);
            g.DrawLine(whitePen, 350, 285, 317, 210);

            //Mr. White Torso
            g.DrawLine(whitePen, 317, 210, 317, 150);

            //Mr. White Head
            g.FillEllipse(whiteBrush, 290, 100, 50, 60);

            //Mr. White Arms
            g.DrawLine(whitePen, 300, 200, 317, 160);
            g.DrawLine(whitePen, 350, 200, 317, 160);

            //Red barrel
            g.FillRectangle(redBrush, 562, 180, 100, 150);

            //Orange explosion
            g.FillRectangle(orangeBrush, 570, 175, 55, 55);
            Thread.Sleep(500);
            g.FillRectangle(orangeBrush, 500, 120, 95, 95);
            Thread.Sleep(500);
            g.FillRectangle(orangeBrush, 450, 90, 200, 200);
            Thread.Sleep(500);
            g.FillRectangle(orangeBrush, 290, 60, 400, 400);
            Thread.Sleep(500);
            g.FillRectangle(orangeBrush, 0, 0, 5500, 5500);
            Thread.Sleep(1000);


            //Mission accomplished
            g.DrawString("Mission accomplished, target eliminated", endFont, blackBrush, 100, 100);
        }
    }
}
