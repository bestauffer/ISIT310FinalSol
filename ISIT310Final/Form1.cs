using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISIT310Final
{
    public partial class Form1 : Form
    {
        CatsModelContainer myData = new CatsModelContainer();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void UpdateDGV()
        {
            var catQuery = from eachCat in myData.Cats
                           select new
                           {
                               eachCat.Breed,
                               eachCat.ActivityLevel.ActivityLevelValue,
                               eachCat.Playfullness.PlayfullnessValue,
                               eachCat.Color.ColorValue
                           };
            dataGridView1.DataSource = catQuery.ToList();

            comboBoxColor.DataSource = myData.Colors.ToList();
            comboBoxColor.DisplayMember = "ColorValue";
            comboBoxColor.ValueMember = "ColorID";

            comboBoxActivityLevle.DataSource = myData.ActivityLevels.ToList();
            comboBoxActivityLevle.DisplayMember = "ActivityLevelValue";
            comboBoxActivityLevle.ValueMember = "ActivityLevelID";

            comboBoxPlayfullness.DataSource = myData.Playfullnesses.ToList();
            comboBoxPlayfullness.DisplayMember = "PlayfullnessValue";
            comboBoxPlayfullness.ValueMember = "PlayfullnessID";
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            Color newColor = new Color
            {
                ColorValue = textBoxColor.Text
            };
            myData.Colors.Add(newColor);
            myData.SaveChanges();

            UpdateDGV();
        }

        private void buttonActivityLevel_Click(object sender, EventArgs e)
        {
            ActivityLevel newActivityLevel = new ActivityLevel
            {
                ActivityLevelValue = textBoxActivityLevel.Text
            };
            myData.ActivityLevels.Add(newActivityLevel);
            myData.SaveChanges();

            UpdateDGV();
        }

        private void buttonAddPlayfullness_Click(object sender, EventArgs e)
        {
            Playfullness newPlayfullness = new Playfullness
            {
                PlayfullnessValue = textBoxPlayfullness.Text
            };
            myData.Playfullnesses.Add(newPlayfullness);
            myData.SaveChanges();

            UpdateDGV();
        }

        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            Cat newCat = new Cat
            {
                Breed = textBoxBreed.Text,
                Color = (Color)comboBoxColor.SelectedItem,
                ActivityLevel = (ActivityLevel)comboBoxActivityLevle.SelectedItem,
                Playfullness = (Playfullness)comboBoxPlayfullness.SelectedItem,
            };
            myData.Cats.Add(newCat);
            myData.SaveChanges();

            UpdateDGV();
        }
    }
}
