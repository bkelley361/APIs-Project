using PokeAPI;
using System;
using System.Windows.Forms;

namespace Pokemon_API
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

        public async void GetSpecies(int i) 
        {
            PokemonSpecies p = await DataFetcher.GetApiObject<PokemonSpecies>(i);
            listBox1.Items.Add("Name: " + p.Name);
            listBox1.Items.Add("Base Happiness: " + p.BaseHappiness);
            listBox1.Items.Add("Capture Rate: " + p.CaptureRate);
            listBox1.Items.Add("Flavor Text: " + p.FlavorTexts[1].FlavorText);
            listBox1.Items.Add("Habitat: " + p.Habitat.Name);
            listBox1.Items.Add("Growth Rate: " + p.GrowthRate.Name);
            listBox1.Items.Add("Egg Groups: " + p.EggGroups[0].Name);
        }

        private void btn_ID_Click(object sender, EventArgs e)
        {
            int i = 0;
            string id = txt_IDBox.Text;
            listBox1.Items.Clear();
            if (int.TryParse(id, out i))
            {
                i = Convert.ToInt32(id);
                GetSpecies(i);
            }
            else
            {
                MessageBox.Show("Please enter the ID of a Pokemon");
                txt_IDBox.Clear();
            }
            txt_IDBox.Clear();
        }
    }
}
