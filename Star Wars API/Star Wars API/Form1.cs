using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;


namespace Star_Wars_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Species_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_IDBox.Clear();
            Species mySpecies = new Species();
            Planet myPlanet = new Planet();

            int i = 1;

            while (i <= 37)
            {
                mySpecies = await JSONHelper.GetSpecies(i);
                myPlanet = await JSONHelper.GetPlanet(i);

                listBox1.Items.Add("Species Number: " + i);
                listBox1.Items.Add("Species Name: " + mySpecies.name);
                listBox1.Items.Add("Species Classification: " + mySpecies.classification);
                listBox1.Items.Add("Species Designation: " + mySpecies.designation);
                listBox1.Items.Add("Species Average Height: " + mySpecies.average_height);
                listBox1.Items.Add("Species Skin Colors: " + mySpecies.skin_colors);
                listBox1.Items.Add("Species Hair Colors: " + mySpecies.hair_colors);
                listBox1.Items.Add("Species Eye Colors: " + mySpecies.eye_colors);
                listBox1.Items.Add("Species Average Lifespan: " + mySpecies.average_lifespan);
                listBox1.Items.Add("Species Homeworld: " + myPlanet.name);
                listBox1.Items.Add("Species Language: " + mySpecies.language);
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                i++;
            }
        }

        private async void btn_Planet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Planet myPlanet = new Planet();

            string id = txt_IDBox.Text;
            int i;
            if (int.TryParse(id, out i))
            {
                i = Convert.ToInt32(id);
                myPlanet = await JSONHelper.GetPlanet(i);
            }
            else
            {
                MessageBox.Show("Please enter the ID of a Planet");
                txt_IDBox.Clear();
            }
            txt_IDBox.Clear();

            listBox1.Items.Add("Planet Name: " + myPlanet.name);
            listBox1.Items.Add("Planet Rotation Period: " + myPlanet.rotation_period);
            listBox1.Items.Add("Planet Orbital Period: " + myPlanet.orbital_period);
            listBox1.Items.Add("Planet Diameter: " + myPlanet.diameter);
            listBox1.Items.Add("Planet Climate: " + myPlanet.climate);
            listBox1.Items.Add("Planet Gravity: " + myPlanet.gravity);
            listBox1.Items.Add("Planet Terrain: " + myPlanet.terrain);
            listBox1.Items.Add("Planet Surface Water: " + myPlanet.surface_water);
            listBox1.Items.Add("Planet Population: " + myPlanet.population);
        }

        private async void btn_Character_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Character myCharacter = new Character();
            Planet myPlanet = new Planet();
            string id = txt_IDBox.Text;
            int i;
            if (int.TryParse(id, out i))
            {
                i = Convert.ToInt32(id);
                myCharacter = await JSONHelper.GetCharacter(i);
                myPlanet = await JSONHelper.GetPlanet(i);
            }
            else
            {
                MessageBox.Show("Please enter the ID of a Planet");
                txt_IDBox.Clear();
            }
            txt_IDBox.Clear();

            listBox1.Items.Add("Character Name: " + myCharacter.name);
            listBox1.Items.Add("Character Height: " + myCharacter.height);
            listBox1.Items.Add("Character Mass: " + myCharacter.mass);
            listBox1.Items.Add("Character Hair Color: " + myCharacter.hair_color);
            listBox1.Items.Add("Character Skin Color: " + myCharacter.skin_color);
            listBox1.Items.Add("Character Eye Color: " + myCharacter.eye_color);
            listBox1.Items.Add("Character Birth Year: " + myCharacter.birth_year);
            listBox1.Items.Add("Character Gender: " + myCharacter.gender);
            listBox1.Items.Add("Character Homeworld: " + myPlanet.name);
        }
    }
}
