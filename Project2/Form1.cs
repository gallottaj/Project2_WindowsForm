using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        private string selectedEntree;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void choice1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (choice1RadioButton.Checked) { MessageBox.Show("You selected Cola!"); }
        }

        private void choice2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (choice2RadioButton.Checked) { MessageBox.Show("You selected Root Beer!"); }
        }

        private void choice3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (choice3RadioButton.Checked) { MessageBox.Show("You selected Ginger Ale!"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxRadioButton_Enter(object sender, EventArgs e)
        {

        }

        private void frenchFriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (frenchFriesCheckBox.Checked) { MessageBox.Show("You selected French Fries!"); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void listBoxSelection_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // ENTREE SELECTION         

            string entree;
            if (entreeListBox.SelectedIndex != -1)
            {
                entree = entreeListBox.SelectedItem.ToString();
                switch (entree)
                {
                    case "Steak":
                        selectedEntreeLabel.Text = "Steak";
                        break;
                    case "Meatloaf":
                        selectedEntreeLabel.Text = "Meatloaf";
                        break;
                    case "Roast Beef":
                        selectedEntreeLabel.Text = "Roast Beef";
                        break;
                    case "Shrimp":
                        selectedEntreeLabel.Text = "Shrimp";
                        break;
                    case "Pork Chop":
                        selectedEntreeLabel.Text = "Pork Chop";
                        break;
                    case "Ribs":
                        selectedEntreeLabel.Text = "Ribs";
                        break;
                }
            }


            else
            {
                MessageBox.Show("Please select and entree");
            }


            //DRINK SELECTION

            //cola
            if (choice1RadioButton.Checked)
            {
                selectedDrinkLabel.Text = "Cola";
            }
            //root beer
            if (choice2RadioButton.Checked)
            {
                selectedDrinkLabel.Text = "Root Beer";
            }
            if (choice3RadioButton.Checked)
            {
                selectedDrinkLabel.Text = "Ginger Ale";
            }

            //SIDE SELECTION
            
                if (frenchFriesCheckBox.Checked)
                {
                    selectedSidesLabel.Text = "French Fries";
                }
                if (sideSaladCheckBox.Checked)
                {
                    selectedSidesLabel.Text = "Side Salad";
                }
                if (frenchFriesCheckBox.Checked && sideSaladCheckBox.Checked)
                {
                    selectedSidesLabel.Text = "French Fries, Side Salad";
                }
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

