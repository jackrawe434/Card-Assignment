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
            Thread.Sleep(200);

            //G
            g.DrawString("G", greenFont, startUpText, 95, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //E
            g.DrawString("E", greenFont, startUpText, 120, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //N
            g.DrawString("N", greenFont, startUpText, 145, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //T
            g.DrawString("T", greenFont, startUpText, 170, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //4
            g.DrawString("4", greenFont, startUpText, 220, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //7
            g.DrawString("7", greenFont, startUpText, 245, 70);
            keyboardClick.Play();
            Thread.Sleep(200);

            //:
            g.DrawString(":", greenFont, startUpText, 260, 70);
            keyboardClick.Play();
            Thread.Sleep(200);


            //"Your mission is to eliminate" text

                //Your

            //Y
            g.DrawString("Y", greenFont, startUpText, 70, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //O
            g.DrawString("O", greenFont, startUpText, 95, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //U
            g.DrawString("U", greenFont, startUpText, 120, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //R
            g.DrawString("R", greenFont, startUpText, 145, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

             //Mission

            //M
            g.DrawString("M", greenFont, startUpText, 195, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //I
            g.DrawString("I", greenFont, startUpText, 220, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //S
            g.DrawString("S", greenFont, startUpText, 245, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //S
            g.DrawString("S", greenFont, startUpText, 270, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //I
            g.DrawString("I", greenFont, startUpText, 295, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //O
            g.DrawString("O", greenFont, startUpText, 320, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //N
            g.DrawString("N", greenFont, startUpText, 345, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

             //"Is"

            //I
            g.DrawString("I", greenFont, startUpText, 395, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //S
            g.DrawString("S", greenFont, startUpText, 420, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

                //"To"

            //T
            g.DrawString("T", greenFont, startUpText, 470, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

            //O
            g.DrawString("O", greenFont, startUpText, 495, 120);
            keyboardClick.Play();
            Thread.Sleep(200);

                //"Eliminate"

            //E
            g.DrawString("E", greenFont, startUpText, 70, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //L
            g.DrawString("L", greenFont, startUpText, 95, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //I
            g.DrawString("I", greenFont, startUpText, 120, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //M
            g.DrawString("M", greenFont, startUpText, 145, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //I
            g.DrawString("I", greenFont, startUpText, 170, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //N
            g.DrawString("N", greenFont, startUpText, 195, 170);
            keyboardClick.Play();
            Thread.Sleep(200);
         
            //A
            g.DrawString("A", greenFont, startUpText, 220, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //T
            g.DrawString("T", greenFont, startUpText, 245, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //E
            g.DrawString("E", greenFont, startUpText, 270, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

                //"Mr."

            //M
            g.DrawString("M", greenFont, startUpText, 320, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //r
            g.DrawString("r", greenFont, startUpText, 345, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //.
            g.DrawString(".", greenFont, startUpText, 361, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

                //"White"

            //W
            g.DrawString("W", greenFont, startUpText, 411, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //H
            g.DrawString("H", greenFont, startUpText, 436, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //I
            g.DrawString("I", greenFont, startUpText, 461, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //T
            g.DrawString("T", greenFont, startUpText, 486, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //E
            g.DrawString("E", greenFont, startUpText, 511, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //,
            g.DrawString(",", greenFont, startUpText, 526, 170);
            keyboardClick.Play();
            Thread.Sleep(200);

            //"Good"

            //G
            g.DrawString("G", greenFont, startUpText, 70, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //O
            g.DrawString("O", greenFont, startUpText, 95, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //O
            g.DrawString("O", greenFont, startUpText, 120, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //D
            g.DrawString("D", greenFont, startUpText, 145, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

                //"Luck"

            //L
            g.DrawString("L", greenFont, startUpText, 195, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //U
            g.DrawString("U", greenFont, startUpText, 220, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //C
            g.DrawString("C", greenFont, startUpText, 245, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //K
            g.DrawString("K", greenFont, startUpText, 270, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //.
            g.DrawString(".", greenFont, startUpText, 295, 220);
            keyboardClick.Play();
            Thread.Sleep(200);

            //"Click To Begin"
            g.DrawString("Click To Begin...", greenFont, startUpText, 250, 400);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Click event setup 
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            SoundPlayer reload = new SoundPlayer(Properties.Resources.Reload);

            //Brush setup
            SolidBrush greenBrush = new SolidBrush(Color.ForestGreen);
            Pen blackPen = new Pen(Color.Black, 15);
            Pen whitePen = new Pen(Color.White, 12);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush grayBrush = new SolidBrush(Color.Gray);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush whiteBrush = new SolidBrush(Color.White);


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

                //Sniper Reticle

            //Black circle
            g.DrawEllipse(blackPen, 400, 100, 70, 80)''
        }
    }
}
