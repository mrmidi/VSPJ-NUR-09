using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

using System.Collections;

namespace CV09
{
    public partial class Form1 : Form
    {
        public ArrayList mycolors = new ArrayList();
        private static int[] currentrgb = { 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                string col = clb.Items[i].ToString();
                Console.WriteLine(col);
                if (lb.Items.Contains(col))
                {
                    clb.SetItemChecked(i, true);
                }
            }
        }
        public void initColors()
        {
            Colors black = new Colors("Černá", 0, 0, 0);
            Colors red = new Colors("Červená", 255, 0, 0);
            Colors blue = new Colors("Modrá", 0, 0, 255);
            Colors yellow = new Colors("Žlutá", 255, 255, 0);
            Colors orange = new Colors("Oranžová", 255, 165, 0);
            Colors green = new Colors("Zelená", 0, 255, 0);
            Colors brown = new Colors("Hnědá", 150, 75, 0);
            Colors white = new Colors("Bílá", 255, 255, 255);
            mycolors.Add(black);
            mycolors.Add(red);
            mycolors.Add(blue);
            mycolors.Add(green);
            mycolors.Add(brown);
            mycolors.Add(white);
            mycolors.Add(yellow);
            mycolors.Add(orange);
        }

        public void populate()
        {
            lb.Items.Clear();
            clb.Items.Clear();
            cb.Items.Clear();
            foreach (Colors color in mycolors)
            {
                cb.Items.Add(color.getName());
            }
            foreach (Colors color in mycolors)
            {
                clb.Items.Add(color.getName());
            }
            cb.Sorted = true;
            clb.Sorted = true;
            cb.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initColors();
            populate();
            int[] startingcolor = { 0, 0, 0 };
            setCurrentColor(startingcolor);
        }

        public int getCmbIdByName()
        {
            return 0;
        }

        public Boolean isExistsInClb(String colorname)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clb.GetItemText(i).Contains(colorname))
                    return true;
            }
            return false;
        }

        public Boolean isExistsInLb(String colorname)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                if (lb.GetItemText(i).Contains(colorname))
                    return true;
            }
            return false;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex != -1)
            {
                String colorname = lb.SelectedItem.ToString();
                //Console.WriteLine(colorname);
                lb.Items.Remove(lb.SelectedItem);
                int i = clb.Items.IndexOf(colorname);
                clb.SetItemChecked(i, false);
            }

            //clb.Items.
        }

        private void add_to_lb_Click(object sender, EventArgs e)
        {
            if (!lb.Items.Contains(cb.SelectedItem.ToString()))
            {
                lb.Items.Add(cb.SelectedItem.ToString());
            }
            else
            {
                //error message
            }
            lb.Sorted = true;
        }

        private void lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lb.SelectedIndex != -1)
            {
                String col;
                col = lb.SelectedItem.ToString();
                int idx = 0;
                foreach (Colors colClass in mycolors)
                {
                    if (colClass.contains(col))
                    {
                        NewWindow form = new NewWindow(colClass.getRGB(), colClass.getNeuter());
                        form.ShowDialog();
                    }
                        
                }

            }


        }
        public static int[] getCurrentColor()
        {
            return currentrgb;
        }

        public static void setCurrentColor(int[] col)
        {
            currentrgb = col;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


