using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakii
{

    public enum optionsType
    {
        New, Save, Edit
    }


    public partial class MapOptions : CustomForm
    {

        public string MapName { get; set; }
        public string MapDescription { get; set; }
        public int ObjectiveType { get; set; }
        public int ObjectiveValue { get; set; }

        public string mN = "";

        public MapOptions(optionsType type)
        {
            InitializeComponent();
            if (type == optionsType.New)
            {
                Text = "New Map:";
                doneButton.Text = "New";
                objectiveType.SelectedIndex = 0;
            }
        }

        public MapOptions(optionsType type, Map c)
        {
            InitializeComponent();
            if (type == optionsType.Edit)
            {
                Text = "Map Options:";
                doneButton.Text = "Done";
                nameBox.Text = c.Name;
                descriptionBox.Text = c.Description;
                objectiveType.SelectedIndex = c.objective;
                objectiveValue.Value = c.objectivevalue;
                mN = c.Name;

            }
            if (type == optionsType.Save)
            {
                Text = "Save Map As:";
                doneButton.Text = "Save";
                nameBox.Text = c.Name;
                descriptionBox.Text = c.Description;
                objectiveType.SelectedIndex = c.objective;
                objectiveValue.Value = c.objectivevalue;
            }
        }

        private void objectiveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectiveType.SelectedIndex == 0)
                objectiveValue.Enabled = true;
            else 
                objectiveValue.Enabled = false;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || nameBox.Text.Length < 3)
            {
                MessageBox.Show("O nome do mapa tem de ser maior que 3 letras!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (string f in Directory.GetFiles("Map", "*.json"))
            {
                if (Path.GetFileNameWithoutExtension(f) == nameBox.Text)
                {
                    if (mN != "" && mN == nameBox.Text)
                        continue;
                    DialogResult d = MessageBox.Show("Já existe um mapa com esse nome, tem a certeza que deseja o substituir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if (objectiveType.SelectedIndex < 0)
            {
                objectiveType.SelectedIndex = 0;
            }
            
            MapName = nameBox.Text;
            if (descriptionBox.Text == "")
                MapDescription = "...";
            else
                MapDescription = descriptionBox.Text;

            ObjectiveType = objectiveType.SelectedIndex;
            ObjectiveValue = (int)objectiveValue.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MapOptions_Load(object sender, EventArgs e)
        {
            
        }
    }
}
