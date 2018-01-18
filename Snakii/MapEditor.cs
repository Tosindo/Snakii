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
using Newtonsoft.Json;
using System.IO;
using System.Security.AccessControl;

namespace Snakii
{
    public partial class MapEditor : CustomForm
    {
        Map edit;



        bool mouseDown = false;
        bool grid = false;
        bool mouseHover = false;
        Point mousePos = new Point(0, 0);


        // For line and rectangle modes:
        Point startPos = new Point(0, 0);
        Point endPos = new Point(0, 0);

        


    public MapEditor(Map m)
        {
            InitializeComponent();
            edit = m;

            for (int i = 0; i < edit.Objects.Count; i++)
            {
                if (edit.Objects[i].type == "Spawn")
                {
                    int d = Int32.Parse(edit.Objects[i].ext1);
                    spawnToolDirection.SelectedIndex = d;
                    break;
                }
                    

            }
        }
        public MapEditor()
        {
            InitializeComponent();
            edit = Map.NewMap();


            for (int i = 0; i < edit.Objects.Count; i++)
            {
                if (edit.Objects[i].type == "Spawn")
                {
                    int d = Int32.Parse(edit.Objects[i].ext1);
                    spawnToolDirection.SelectedIndex = d;
                    break;
                }


            }
        }

        private void MapEditor_Load(object sender, EventArgs e)
        {
            wallTool.Appearance = Appearance.Button;
            typeof(Panel).InvokeMember("DoubleBuffered",
    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
    null, editPanel, new object[] { true });
        }


        #region "Toolstrip Names"

        private void setupToolstrip(string text, int toolSet=-1)
        {

            setTeleportPos.Visible = false;

            toolNameLabel.Text = text;

            if (toolSet == 1)
                setTeleportPos.Visible = true;
        }

        private void nofoodTool_CheckedChanged(object sender, EventArgs e)
        {
            setupToolstrip("No Food Tool");
        }

        private void removeTool_CheckedChanged(object sender, EventArgs e)
        {
            setupToolstrip("Remove Tool");
        }

        private void wallTool_CheckedChanged(object sender, EventArgs e)
        {
            setupToolstrip("Wall Tool");
        }

        private void spawnTool_CheckedChanged(object sender, EventArgs e)
        {
            setupToolstrip("Spawn Tool");
            normalMode.Checked = true;
            fillMode.Enabled = false;
            rectangleMode.Enabled = false;
            lineMode.Enabled = false;
            spawnToolDirection.Visible = true;
            if (!spawnTool.Checked)
            {
                fillMode.Enabled = true;
                rectangleMode.Enabled = true;
                lineMode.Enabled = true;
                spawnToolDirection.Visible = false;
            }
        }

        private void teleportTool_CheckedChanged(object sender, EventArgs e)
        {
            setupToolstrip("Teleport Tool",1);
        }


        private void goalTool_CheckedChanged(object sender, EventArgs e)
        {
            setupToolstrip("Goal Tool");
        }
        #endregion


        private Point getBoardPos(int eX, int eY)
        {

            int x = (int)Math.Floor((decimal)eX / 25);
            int y = (int)Math.Floor((decimal)eY / 25);
            if (x < 0) x = 0;
            if (x >= 20) x = 19;
            if (y < 0) y = 0;
            if (y >= 20) y = 19;

            return new Point(x, y);
        }

        private void paintBoard(int eX, int eY)
        {
            Point xy = getBoardPos(eX, eY);
            int x = xy.X;
            int y = xy.Y;

            if (wallTool.Checked)
            {

                //if (edit.startPos.X != x || edit.startPos.Y != y)
                //{
                    StringBuilder sb = new StringBuilder(edit.wallMap[x]);
                    sb[y] = '#';

                    edit.wallMap[x] = sb.ToString();
                //}
            }
            else if (removeTool.Checked)
            {

                StringBuilder sb = new StringBuilder(edit.wallMap[x]);
                sb[y] = '-';

                edit.wallMap[x] = sb.ToString();
            }
            else if (spawnTool.Checked)
            {
                //if (edit.wallMap[x][y] != '#' || wallMap.map[x][y] != '.') edit.startPos = new Point(x, y);
            }
            else if (nofoodTool.Checked)
            {
                if (edit.wallMap[x][y] != '#')
                {
                    StringBuilder sb = new StringBuilder(edit.wallMap[x]);
                    sb[y] = 'x';

                    edit.wallMap[x] = sb.ToString();
                }
            }
            else if (goalTool.Checked)
            {
                //if (edit.startPos.X != x || edit.startPos.Y != y)
                //{
                    StringBuilder sb = new StringBuilder(edit.wallMap[x]);
                    sb[y] = '.';

                    edit.wallMap[x] = sb.ToString();
                //}
            }

            editPanel.Invalidate();
        }

        private void fill(int x, int y, char oldc, char newc)
        {
            if (x >= 20 || x < 0 || y >= 20 || y < 0)
                return;
            if (edit.wallMap[x][y] != oldc || oldc == newc)
                return;
            
            for (int i = 0; i < edit.Objects.Count; i++)
            {
                Point pos = edit.Objects[i].getPos();
                if (pos.X == x && pos.Y == y)
                {
                    return;
                }
            }


                StringBuilder sb = new StringBuilder(edit.wallMap[x]);
            sb[y] = newc;

            edit.wallMap[x] = sb.ToString();

            fill(x + 1, y, oldc, newc);
            fill(x - 1, y, oldc, newc);
            fill(x, y + 1, oldc, newc);
            fill(x, y - 1, oldc, newc);

        }

        private void fillBoard(int eX, int eY)
        {
            Point mousePos = getBoardPos(eX, eY);
            
            if (wallTool.Checked)
            {
                fill(mousePos.X, mousePos.Y, edit.wallMap[mousePos.X][mousePos.Y], '#');
            }
            if (removeTool.Checked)
            {
                fill(mousePos.X, mousePos.Y, edit.wallMap[mousePos.X][mousePos.Y], '-');
            }
            if(nofoodTool.Checked)
            {
                fill(mousePos.X, mousePos.Y, edit.wallMap[mousePos.X][mousePos.Y], 'x');
            }
            if (goalTool.Checked)
            {
                fill(mousePos.X, mousePos.Y, edit.wallMap[mousePos.X][mousePos.Y], '.');
            }
        }

        private void DrawRectangle(int x0, int y0, int x1, int y1)
        {
            //char c = '-';
            //if (wallTool.Checked)
            //{
            //    c = '#';
            //}
            //if (nofoodTool.Checked)
            //{
            //    c = 'x';
            //}
            //if (removeTool.Checked)
            //{
            //    c = '-';
            //}

            if (rectFill.Checked)
            {
                int dY, ndY;
                if (y0 > y1) {
                    dY = y0;
                    ndY = y1;
                }
                else
                {
                    dY = y1;
                    ndY = y0;
                }

                for (int y = ndY; y<=dY; y++)
                {
                    DrawLine(x0, y, x1, y);
                }
            }
            else
            {
                DrawLine(x0, y0, x1, y0);
                DrawLine(x0, y1, x1, y1);
                DrawLine(x0, y0, x0, y1);
                DrawLine(x1, y0, x1, y1);
            }
        }

        private void DrawLine(int x0, int y0, int x1, int y1)
        {
            char c = '-';
            if (wallTool.Checked)
            {
                c = '#';
            }
            if (nofoodTool.Checked)
            {
                c = 'x';
            }
            if (removeTool.Checked)
            {
                c = '-';
            }
            if (goalTool.Checked)
            {
                c = '.';
            }

            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (;;)
            {

                bool Obj = false;
                for (int i = 0; i < edit.Objects.Count; i++)
                {
                    Point pos = edit.Objects[i].getPos();
                    if (pos.X == x0 && pos.Y == y0)
                    {
                        Obj = true;
                    }
                }

                if (!Obj)
                {
                    StringBuilder sb = new StringBuilder(edit.wallMap[x0]);
                    sb[y0] = c;

                    edit.wallMap[x0] = sb.ToString();
                }

                if (x0 == x1 && y0 == y1) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
                

            }
        }


        private void editPanel_Paint(object sender, PaintEventArgs e)
        {


            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {

                    if (edit.wallMap[x][y] == '#')
                    {
                        e.Graphics.FillRectangle(Brushes.White, x * 25, y * 25, 25, 25);
                    }

                    if (edit.wallMap[x][y] == '.')
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.ForestGreen), x * 25, y * 25, 25, 25);
                    }
                    if (edit.wallMap[x][y] == 'x')
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 12, 0)), x * 25, y * 25, 25, 25);
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 156, 156)), x * 25, y * 25, 25, 25);
                    }


                    if (startPos.X == x && startPos.Y == y && mouseDown && (lineMode.Checked || rectangleMode.Checked))
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.Lime, 4f), x * 25, y * 25, 25, 25);
                    }
                    if (mousePos.X == x && mousePos.Y == y && mouseHover)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.Pink, 4f), x * 25, y * 25, 25, 25);
                    }
                }
            }

            for (int i = 0; i < edit.Objects.Count; i++)
            {
                Point pos = edit.Objects[i].getPos();
                if (edit.Objects[i].type == "Spawn")
                    e.Graphics.FillRectangle(Brushes.Yellow, new Rectangle(pos.X * 25, pos.Y * 25, 25, 25));

            }

            if (grid)
            {
                for (int x = 0; x < 20; x++)
                {
                    e.Graphics.DrawLine(Pens.Wheat, x * 25, 0, x * 25, 500);
                }
                for (int y = 0; y < 20; y++)
                {
                    e.Graphics.DrawLine(Pens.Wheat, 0, y * 25, 500, y * 25);
                }
            }
        }

        private void editPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            if (spawnTool.Checked)
            {
                Point pos = getBoardPos(e.X, e.Y);
                for (int i = 0; i < edit.Objects.Count; i++)
                {
                    if (edit.Objects[i].type == "Spawn")
                    {
                        edit.Objects[i].Position = pos.X + "," + pos.Y;
                        break;
                    }

                }
            }
            else if (fillMode.Checked)
                fillBoard(e.X, e.Y);
            else if (lineMode.Checked || rectangleMode.Checked)
                startPos = getBoardPos(e.X, e.Y);
            else
                paintBoard(e.X, e.Y);
            
        }

        private void editPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (lineMode.Checked)
                DrawLine(startPos.X, startPos.Y, getBoardPos(e.X, e.Y).X, getBoardPos(e.X, e.Y).Y);
            if (rectangleMode.Checked)
            {
                DrawRectangle(startPos.X, startPos.Y, getBoardPos(e.X, e.Y).X, getBoardPos(e.X, e.Y).Y);
            }
        }

        private void editPanel_MouseHover(object sender, EventArgs e)
        {
            mouseHover = true;
            editPanel.Invalidate();
        }

        private void editPanel_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = getBoardPos(e.X, e.Y);

            if (mouseDown)
            {
                if (!normalMode.Checked )
                {
                    if (fillMode.Checked)
                    {

                        fillBoard(e.X, e.Y);
                    }
                }
                
                else 
                    paintBoard(e.X, e.Y);
            }
            if (mouseHover)
                editPanel.Invalidate();
        }

        private void editPanel_MouseLeave(object sender, EventArgs e)
        {
            mouseHover = false;
            editPanel.Invalidate();
            Cursor.Show();
        }

        private void editPanel_MouseEnter(object sender, EventArgs e)
        {
            mouseHover = true;
            Cursor.Hide();
        }

        private void rectFill_Click(object sender, EventArgs e)
        {
            rectFill.Checked = !rectFill.Checked;
        }

        private void rectangleMode_CheckedChanged(object sender, EventArgs e)
        {

            if (rectangleMode.Checked)
                rectFill.Visible = true;
            else
                rectFill.Visible = false;
        }

        private void spawnToolDirection_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < edit.Objects.Count; i++)
            {
                if (edit.Objects[i].type == "Spawn")
                {
                    edit.Objects[i].ext1 = spawnToolDirection.SelectedIndex.ToString();
                    break;
                }


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeThis();
        }


        void closeThis()
        {
            DialogResult mustSave = MessageBox.Show("Save before closing?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (mustSave == DialogResult.Yes)
            {
                Save();
            }
            

            if (mustSave != DialogResult.Cancel)
            {
                this.Close();
            }
        }

        void Save()
        {

            string json = JsonConvert.SerializeObject(edit, Formatting.Indented);
            if (!Directory.Exists("Map"))
            {
                Directory.CreateDirectory("Map");
            }
            
            File.WriteAllText("Map/" + edit.Name + ".json", json);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid = !grid;
            showGridToolStripMenuItem.Checked = grid;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Game tG = new Snakii.Game(edit, false);
            tG.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapOptions mo = new Snakii.MapOptions(optionsType.Edit, edit);

            mo.ShowDialog();
            if (mo.DialogResult == DialogResult.OK)
            {
                edit.Description = mo.MapDescription;
                edit.objective = mo.ObjectiveValue;
                edit.objective = mo.ObjectiveType;
                if (edit.Name != mo.MapName)
                {
                    if (File.Exists("Map/" + edit.Name + ".json"))
                    {
                        File.Move("Map/" + edit.Name + ".json", "Map/" + mo.MapName + ".json");
                    }
                }

                edit.Name = mo.MapName;
                Save();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MapOptions mo = new Snakii.MapOptions(optionsType.New);

            Map newMap = Map.NewMap();

            mo.ShowDialog();
            if (mo.DialogResult == DialogResult.OK)
            {
                newMap.Name = mo.MapName;
                newMap.Description = mo.MapDescription;
                newMap.objective = mo.ObjectiveType;
                newMap.objectivevalue = mo.ObjectiveValue;

                MapEditor ed = new MapEditor(newMap);
                ed.Show();
                this.Close();
            }
        }
        
    }
}
