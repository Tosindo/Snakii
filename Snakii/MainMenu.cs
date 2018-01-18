using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakii
{
    public partial class MainMenu : CustomForm
    {

        List<Point> SnakePositions = new List<Point>();
        int SnakeSize = 5;
        int dirX = 1, dirY = 0, size = 25;


        public static Color headColor = Color.White;
        public static Color bodyColor = Color.Gray;
        public static Color tailColor = Color.DarkGray;
        public static Color deadColor = Color.Red;

        public MainMenu()
        {
            InitializeComponent();
            SnakePositions.Add(new Point(0, 0));
        }

        private void replayDisplay_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < SnakePositions.Count; i++)
            {
                Point p = SnakePositions[i];

                SolidBrush color;
                if (i == 0)
                {
                    color = new SolidBrush(headColor);
                }
                else if (i == SnakePositions.Count - 1)
                {
                    color = new SolidBrush(tailColor);
                }
                else
                {
                    color = new SolidBrush(bodyColor);
                }

                //if (dead) color = new SolidBrush(deadColor);


                e.Graphics.FillRectangle(color, p.X * size, p.Y * size, size, size);
            }
        }




        void MovePlayer(int dx, int dy)
        {
            if ((dirX != 0 && dx != 0) || (dirY != 0 && dy != 0))
            {
                return;
            }
            dirX = dx;
            dirY = dy;
        }

        private void mapeditorButton_Click(object sender, EventArgs e)
        {
            MapChoose mc = new MapChoose(true);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK)
            {
                MapEditor s = new MapEditor(mc.ChosenMap);
                s.ShowDialog();
            }
            
        }

        private void underScore_Tick(object sender, EventArgs e)
        {

            if (label1.Text == "Snakii")
                label1.Text = "Snakii_";
            else label1.Text = "Snakii";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MapChoose mc = new MapChoose(false);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK)
            {
                Game g = new Snakii.Game(mc.ChosenMap, mc.SkipObjectives);
                g.ShowDialog();
            }
        }

        int randOneM(Random r)
        {
            
            return (r.Next(0,2) < 1) ? -1 : 1;
        }

        private void replayTicks_Tick(object sender, EventArgs e)
        {
            if (SnakePositions.Count < SnakeSize + 1)
            {
                Point a = new Point(SnakePositions[0].X + dirX, SnakePositions[0].Y + dirY);
                SnakePositions.Insert(0, a);
            }
            else
            {
                SnakePositions.RemoveRange(SnakeSize, SnakePositions.Count - SnakeSize);
            }


            Random rnd = new Random();

            if (rnd.Next(0,2) < 1)
            {
                MovePlayer(randOneM(rnd),0);    
            }
            else
            {
                MovePlayer(0,randOneM(rnd));
            }


            Point curPos = SnakePositions[0];
            

            if (curPos.X < 0)
            {
                SnakePositions[0] = new Point(20 - 1, curPos.Y);
            }
            if (curPos.Y < 0)
            {
                SnakePositions[0] = new Point(curPos.X, 20 - 1);
            }
            if (curPos.X >= 20)
            {
                SnakePositions[0] = new Point(0, curPos.Y);
            }
            if (curPos.Y >= 20)
            {
                SnakePositions[0] = new Point(curPos.X, 0);
            }
            curPos = SnakePositions[0];

            replayDisplay.Invalidate();
        }
    }
}
