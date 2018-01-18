using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakii
{
    public partial class Game : CustomForm
    {


        bool ableToMove = true;

        Map curMap;
        List<Point> SnakePositions = new List<Point>();

        int SnakeSize = 5, score = 0;

        bool ig = false;

        bool food = false;
        int fX, fY;

        int dirX = 1, dirY = 0, size = 25;
        int oldDirX = 1, oldDirY = 0;
        bool dead = false;

        int gWidth = 0;
        int gHeight = 0;

        public static Color headColor = Color.White;
        public static Color bodyColor = Color.Gray;
        public static Color tailColor = Color.DarkGray;


        public static Color deadColor = Color.Red;


        public static Color foodColor = Color.DarkRed;
        public static Color wallColor = Color.Brown;
    

        public void Init()
        {

            SnakePositions = new List<Point>();

            SnakeSize = 5; score = 0;
            

            food = false;

            dirX = 1; dirY = 0; size = 25;
            dead = false;



            Point startPos = new Point(0, 0);
            int dir = 0;
            for (int i = 0; i < curMap.Objects.Count; i++)
            {
                if (curMap.Objects[i].type == "Spawn")
                {
                    startPos = curMap.Objects[i].getPos();
                    dir = Int32.Parse(curMap.Objects[i].ext1);
                    break;
                }


            }

            if (dir == 0)
            {
                MovePlayer(0, 1);
            }
            else if (dir == 1)
            {
                MovePlayer(-1, 0);
            }
            else if (dir == 2)
            {
                MovePlayer(1,0);
            }
            else if (dir == 3)
            {
                MovePlayer(0, -1);
            }

            SnakePositions.Add(new Point(startPos.X, startPos.Y));



            gameTicks.Start();
        }


        public Game(Map m, bool ig)
        {
            InitializeComponent();

            if (ig) this.ig = true;
            DoubleBuffered = true;

            gWidth = gameDisplay.ClientRectangle.Width / size;
            gHeight = gameDisplay.ClientRectangle.Height / size;

            typeof(Panel).InvokeMember("DoubleBuffered",
    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
    null, gameDisplay, new object[] { true });
            curMap = m;


            
            if (!ig)
            {
                if (curMap.objective == 0)
                {
                    MessageBox.Show("Your objective is to reach the score " + curMap.objectivevalue + " . Good luck!");
                }
                else
                {
                    MessageBox.Show("Your objective is to reach the green squares. Good luck!");
                }
            }
            Init();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Init();
            endGamePanel.Hide();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void Die(bool obj=false)
        {
            gameDisplay.Invalidate();
            gameTicks.Stop();
            dead = true;
            endGamePanel.Show();

            endScoreLabel.Text = "Score: " + score;

            if (curMap.objective == 0)
                objectiveEndLabel.Text = "Objective: " + curMap.objectivevalue;


            if (obj)
            {
                endText.Text = "Good Job!";
                if (curMap.objective == 1)
                {
                    endScoreLabel.Hide();
                    objectiveEndLabel.Text = "You reached the objective!";
                }  
            }
            else
            {
                endText.Text = "You died!";
                if (curMap.objective == 1)
                    objectiveEndLabel.Text = "You didn't reach the objective!";
                if (ig)
                    objectiveEndLabel.Hide();
            }


            //this.Close();
            //this.Dispose();
        }

        void MovePlayer(int dx, int dy)
        {
            if ((dirX != 0 && dx != 0) || (dirY != 0 && dy != 0))
            {
                return;
            }
            oldDirX = dirX;
            oldDirY = dirY;
            dirX = dx;
            dirY = dy;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (ableToMove)
            {
                ableToMove = false;
                if (keyData == Keys.Left || keyData == Keys.A)
                {
                    MovePlayer(-1, 0);
                }
                else if (keyData == Keys.Right || keyData == Keys.D)
                {
                    MovePlayer(1, 0);
                }
                else if (keyData == Keys.Up || keyData == Keys.W)
                {
                    MovePlayer(0, -1);
                }
                else if (keyData == Keys.Down || keyData == Keys.S)
                {
                    MovePlayer(0, 1);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gameDisplay_Paint(object sender, PaintEventArgs e)
        {

            if (food)
            {
                e.Graphics.FillRectangle(new SolidBrush(foodColor), fX * size, fY * size, size, size);
            }

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

                if (dead) color = new SolidBrush(deadColor);


                e.Graphics.FillRectangle(color, p.X * size, p.Y * size, size, size);
            }
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (curMap.wallMap[x][y] == '#')
                    {
                        e.Graphics.FillRectangle(Brushes.White, x * 25, y * 25, 25, 25);
                    }
                    if (curMap.wallMap[x][y] == '.' && !ig)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.ForestGreen), x * 25, y * 25, 25, 25);
                    }
                }
            }

        }

        private void gameTicks_Tick(object sender, EventArgs e)
        {
            if (!food)
            {
                Random rnd = new Random();

                bool able = false;
                do
                {
                    int width = gameDisplay.ClientRectangle.Width / size;
                    fX = rnd.Next(0, width + 1);
                    fY = rnd.Next(0, width + 1);
                    if (fX == gWidth) fX--;
                    if (fY == gHeight) fY--;
                    if (fX < 0) fX = 0;
                    if (fY < 0) fY = 0;
                    able = true;
                    for (int i = 0; i < SnakePositions.Count; i++)
                    {
                        Point p = SnakePositions[i];
                        if ((fX == p.X && fY == p.Y) || (curMap.wallMap[fX][fY] == '#') || (curMap.wallMap[fX][fY] == 'x'))
                        {
                            able = false;
                        }

                    }
                } while (able == false);

                food = true;
            }


            if (SnakePositions.Count > 1)
            {
                Point vp = new Point(SnakePositions[0].X + dirX, SnakePositions[0].Y + dirY);
                if (vp.X == SnakePositions[1].X && vp.Y == SnakePositions[1].Y)
                {
                    dirX = oldDirX;
                    dirY = oldDirY;
                }
            }
            if (SnakePositions.Count < SnakeSize + 1)
            {
                Point a = new Point(SnakePositions[0].X + dirX, SnakePositions[0].Y + dirY);
                SnakePositions.Insert(0, a);
            }
            else
            {
                SnakePositions.RemoveRange(SnakeSize, SnakePositions.Count - SnakeSize);
            }

            Point curPos = SnakePositions[0];
            ableToMove = true;


            //Check Self-Colision:
            for (int i = 1; i < SnakePositions.Count; i++)
            {
                Point p = SnakePositions[i];
                if (curPos.X == p.X && curPos.Y == p.Y)
                {
                    Die();
                }
            }

            //Check Border
            if (curPos.X < 0)
            {
                SnakePositions[0] = new Point(gWidth - 1, curPos.Y);
            }
            if (curPos.Y < 0)
            {
                SnakePositions[0] = new Point(curPos.X, gHeight - 1);
            }
            if (curPos.X >= gWidth)
            {
                SnakePositions[0] = new Point(0, curPos.Y);
            }
            if (curPos.Y >= gHeight)
            {
                SnakePositions[0] = new Point(curPos.X, 0);
            }
            curPos = SnakePositions[0];
            if (curMap.wallMap[curPos.X][curPos.Y] == '#')
            {
                Die();
            }
            if (curMap.objective == 1 && !ig)
            {
                if (curMap.wallMap[curPos.X][curPos.Y] == '.')
                {
                    Die(true);
                }
            }


            // Eat food
            if (curPos.X == fX && curPos.Y == fY)
            {
                food = false;

                SnakeSize++; score++;
                if (curMap.objective == 0 && !ig)
                {
                    if (score >= curMap.objectivevalue) Die(true);
                }
                scoreLabel.Text = "Score: " + score;
            }

            gameDisplay.Invalidate();
        }
    }
}
