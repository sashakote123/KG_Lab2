using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        GLGraphics GLGraphics = new GLGraphics();
        public Form1()
        {
            InitializeComponent();
        }



        private void glControl1_Load(object sender, EventArgs e)
        {
            int texID = GLGraphics.LoadTexture("putin.png");
            GLGraphics.texturesIDs.Add(texID);

            int texID2 = GLGraphics.LoadTexture("pmc.png");
            GLGraphics.texturesIDs.Add(texID2);

            int texID3 = GLGraphics.LoadTexture("tree.jpg");
            GLGraphics.texturesIDs.Add(texID3);



            GLGraphics.Resize(glControl1.Width, glControl1.Height);
            Application.Idle += Application_Idle;
        }

        int a = 0;
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (a == 1)
            {
                GLGraphics.Update2();
                glControl1.SwapBuffers();
            }

            if (a == 2)
            {
                GLGraphics.Update3();
                glControl1.SwapBuffers();
            }

            if (a == 3)
            {
                GLGraphics.Update4();
                glControl1.SwapBuffers();
            }

            if (a == 4)
            {
                GLGraphics.Update5();
                glControl1.SwapBuffers();
            }

            if (a == 5)
            {
                GLGraphics.Update6();
                glControl1.SwapBuffers();
            }

            if (a == 6)
            {
                GLGraphics.Update7();
                glControl1.SwapBuffers();
            }

            if (a == 7)
            {
                GLGraphics.Update8();
                glControl1.SwapBuffers();
            }

            if (a == 8)
            {
                GLGraphics.Update9();
                glControl1.SwapBuffers();
            }
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            float widthCoef = (e.X - glControl1.Width * 0.5f) / (float)glControl1.Width;
            float heightCoef = (-e.Y + glControl1.Height * 0.5f) / (float)glControl1.Height;
            GLGraphics.latitude = heightCoef * 180;
            GLGraphics.longitude = widthCoef * 360;

        }


        void Application_Idle(object sender, EventArgs e)
        {

            while (glControl1.IsIdle)
                glControl1.Refresh();
        }

        private void glControl1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = 8;
        }
    }
}
