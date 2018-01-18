using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakii
{
    public class MapObject
    {
        public string type;
        Point position = new Point(0, 0);

        public Point getPos()
        {
            return position;
        }

        public string Position
        {
            get
            {
                return position.X + "," + position.Y;
            }
            set
            {
                string[] s = value.Split(',');
                if (s.Length > 1)
                {
                    try
                    {
                        position = new Point(Int32.Parse(s[0]), Int32.Parse(s[1]));
                    }
                    catch
                    {
                        position = new Point(0, 0);
                    }
                }
            }
        }
        public string ext1;
        public string ext2;
    }

    public class Map
    {
        public string Name;
        public string Description;
        public int objective;
        public int objectivevalue;

        public string[] wallMap;

        public Map Copy()
        {
            Map m = NewMap();
            m.Name = this.Name;
            m.Description = this.Description;
            m.objective = this.objective;
            m.objectivevalue = this.objectivevalue;
            m.wallMap = this.wallMap;
            m.Objects = this.Objects;
            return m;
        }

        public List<MapObject> Objects;

        public static Map NewMap()
        {
            Map m = new Snakii.Map();
            m.Name = "Empty";
            m.Description = "...";
            m.objective = 1;
            m.objectivevalue = 20;


            m.wallMap = new String[20];

            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    m.wallMap[y] += "-";
                }
            }

            MapObject s = new MapObject();
            s.type = "Spawn";
            s.Position = "0,0";
            s.ext1 = "2";

            m.Objects = new List<MapObject>();
            m.Objects.Add(s);

            return m;
        }
    }
}
