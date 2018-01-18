using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Snakii
{
    public partial class MapChoose : CustomForm
    {
        public MapChoose(bool edit)
        {
            InitializeComponent();
            if (edit)
                newButton.Visible = true;
        }

        public bool SkipObjectives
        {
            get; set;
        }

        public Map ChosenMap
        {
            get;set;
        }

        private void MapChoose_Load(object sender, EventArgs e)
        {

            loadBar.Maximum = Directory.GetFiles("Map", "*.json").Length;
            loadMaps.RunWorkerAsync();
        }

        List<Map> Maps = new List<Map>();

        public void LoadMap(Map l)
        {
            ChosenMap = l;
            SkipObjectives = checkBox1.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void newButton_Click(object sender, EventArgs e)
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


                ChosenMap = newMap;
                SkipObjectives = false;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void loadMaps_DoWork(object sender, DoWorkEventArgs e)
        {

            int i = 1;
            foreach (string f in Directory.GetFiles("Map", "*.json"))
            {
                string json = File.ReadAllText(Path.GetFullPath(f));
                Maps.Add(JsonConvert.DeserializeObject<Map>(json));
                i++;
                loadMaps.ReportProgress(i-1);
            }
        }

        private void loadMaps_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel2.Hide();
            int i = 1;
            foreach (Map m in Maps)
            {
                MapItem mp = new Snakii.MapItem(m);
                int d = i - 1;
                mp.Location = new Point(0, d * 94);
                if (i % 2 == 0)
                    mp.bColor = Color.LightGray;
                panel1.Controls.Add(mp);
                i++;
            }
        }

        private void loadMaps_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadBar.Value = e.ProgressPercentage;
        }
    }
}
