using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace CV09
{


    public partial class NewWindow : Form
    {
        private bool firstload = true;
        private int[] rgb;
        private string name;
        private int[] currentrgb = { 0, 0, 0 };
        private int oldred;
        private int newred;
        private int oldgreen;
        private int newgreen;
        private int oldblue;
        private int newblue;


        public NewWindow()
        {
            InitializeComponent();
        }

        public NewWindow(int[] rgb, string name)
        {
            InitializeComponent();
            this.rgb = rgb;
            this.name = name;
        }


        private void NewWindow_Load(object sender, EventArgs e)
        {
            if (firstload)
            {
                this.BackColor = Color.FromArgb(currentrgb[0], currentrgb[1], currentrgb[2]);
                firstload = false;
                this.Text = "Okno " + this.name;
                currentrgb = Form1.getCurrentColor();
            }
            Morphcolor();
        }
        private void Morphcolor()
        {
            oldred = currentrgb[0];
            newred = rgb[0];
            oldgreen = currentrgb[1];
            newgreen = rgb[1];
            oldblue = currentrgb[2];
            newblue = rgb[2];
            Thread redThr = new Thread(changeRed);
            Thread greenThr = new Thread(changeGreen);
            Thread blueThr = new Thread(changeBlue);
            redThr.Start();
            greenThr.Start();
            blueThr.Start();
            Form1.setCurrentColor(currentrgb);
        }

        private void changeRed()
        {
            while (this.oldred != this.newred)
            {
                if (oldred > newred)
                {
                    touchBg();
                    oldred--;
                    currentrgb[0] = oldred;
                    Thread.Sleep(10);
                }
                else
                {
                    touchBg();
                    oldred++;
                    Thread.Sleep(10);
                }
                currentrgb[0] = oldred;
                touchBg();
            }
        }

        private void changeGreen()
        {
            while (this.oldgreen != this.newgreen)
            {
                if (oldgreen > newgreen)
                {
                    touchBg();
                    oldgreen--;
                    currentrgb[1] = oldgreen;
                    Thread.Sleep(10);
                }
                else
                {
                    touchBg();
                    oldgreen++;
                    currentrgb[1] = oldgreen;
                    Thread.Sleep(10);
                }
                currentrgb[1] = oldgreen;
                touchBg();
            }
        }
        private void changeBlue()
        {
            while (this.oldblue != this.newblue)
            {
                if (oldblue > newblue)
                {
                    touchBg();
                    oldblue--;
                    currentrgb[2] = oldblue;
                    Thread.Sleep(10);
                }
                else
                {
                    touchBg();
                    oldblue++;
                    currentrgb[2] = oldblue;
                    Thread.Sleep(10);
                }
                currentrgb[2] = oldblue;
                touchBg();
            }
        }

        private void touchBg()
        {
            this.BackColor = Color.FromArgb(currentrgb[0], currentrgb[1], currentrgb[2]);
        }
    }




}
