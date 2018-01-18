using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Snakii
{
    public partial class MapItem : UserControl
    {

        public string MapName
        {
            get
            {
                return mapName.Text;
            }
            set
            {
                mapName.Text = value;
            }
        }
        public string MapDescription
        {
            get
            {
                return mapDescription.Text;
            }
            set
            {
                mapDescription.Text = value;
            }
        }

        public string MapObjective
        {
            get
            {
                return mapObjective.Text;
            }
            set
            {
                
                mapObjective.Text = value;
            }
        }
        public string MapObjectiveValue
        {
            get
            {
                return mapValue.Text;
            }
            set
            {
                mapValue.Text = value;
            }
        }

        public Image Image
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
            }
        }

        Map theMap;

        public Map thisMap
        {
            get
            {
                return theMap;
            }
            set
            {
                theMap = value;
                MapName = theMap.Name;
                MapDescription = theMap.Description;


                
                MapObjectiveValue = theMap.objectivevalue.ToString();
                if (theMap.objective == 0)
                {
                    mapValue.Show();

                    MapObjective = "Score";
                }
                else
                {
                    mapValue.Hide();
                    MapObjective = "Goal";
                }
                Image = getMapImage(theMap);
            }
        }

        public Image getMapImage(Map m)
        {

            Bitmap img = new Bitmap(500, 500);
            using (Graphics graph = Graphics.FromImage(img)) {
                for (int x = 0; x < 20; x++)
                {
                    for (int y = 0; y < 20; y++)
                    {
                        if (theMap.wallMap[x][y] == '#')
                        {
                            graph.FillRectangle(Brushes.White, x * 25, y * 25, 25, 25);
                        }
                        if (theMap.wallMap[x][y] == '.')
                        {
                            graph.FillRectangle(Brushes.ForestGreen, x * 25, y * 25, 25, 25);
                        }

                    }
                }

                for (int i = 0; i < theMap.Objects.Count; i++)
                {
                    Point pos = theMap.Objects[i].getPos();
                    if (theMap.Objects[i].type == "Spawn")
                        graph.FillRectangle(Brushes.Yellow, new Rectangle(pos.X * 25, pos.Y * 25, 25, 25));

                }
            }

            return img;


        }

        public Color bColor
        {
            set
            {
                panel2.BackColor = value;
            }
        }


        public MapItem(Map m)
        {
            InitializeComponent();


            thisMap = m;
        }

        private void loadMap_Click(object sender, EventArgs e)
        {
            MapChoose parentForm = (this.Parent.Parent as MapChoose);
            parentForm.LoadMap(theMap);
        }

        private void deleteMap_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("Map/" + theMap.Name + ".json");
                undoButton.Visible = true;
                loadMap.Visible = false;
                deleteMap.Visible = false;

            }
            catch
            {
                MessageBox.Show("Couldn't delete the Map.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Create("Map/" + theMap.Name + ".json").Close(); ;
                File.WriteAllText("Map/" + theMap.Name + ".json",JsonConvert.SerializeObject(theMap));
                undoButton.Visible = false;
                loadMap.Visible = true;
                deleteMap.Visible = true;
            }
            catch
            {
                MessageBox.Show("Couldn't recover the Map.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
