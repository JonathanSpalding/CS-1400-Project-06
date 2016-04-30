// Author: Jonathan Spalding
// Assignment: Project 6
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 3/5/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_Rates
{
    public partial class Form1 : Form
    {
        // create a Invoice_Class object
        ShippingRatesClass objectRef;
        // create Constants
        private const double STANDARD = 1;
        private const double EXPRESS = 2;
        private const double SAME = 3;
        private const double WEIGHT = 4;
        private const double PIECE = 5;
        public Form1()
        {
            InitializeComponent();
            objectRef = new ShippingRatesClass();
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProjecct 06");
        }
        // The shippingMethod_SelectIndexChanged method
        // Purpose: checks the combo box to see if what method was chosen, then assigns that method in the SetMethod method.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void shippingMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // create string for which item is selected.
            string selectedItem = shippingMethod.Text;
            // if statement for standard that assigns SetMethod to Standard
            if (selectedItem == "Standard")
                objectRef.SetMethod(STANDARD);
            // else if statement for Express that assigs SetMethod to Express
            else if (selectedItem == "Express")
                objectRef.SetMethod(EXPRESS);
            // else if statement for Same Day that assigns SetMethod to Same Day
            else if (selectedItem == "Same Day")
                objectRef.SetMethod(SAME);
        
        }
        // The category_SelectedIndexChanged method
        // Purpose: checks the category combo box and sees if weight or items was chosen. Then assigns those categories to the SetCategory method in the class.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if statement for finding if weight is chosen. Then assigns to SetCategory Method
            if (category.Text == "By Weight")
            {
                numOfItemsLabel.Text = "Weight of Shipment";
                objectRef.SetCategory(WEIGHT);
            }
            // if statement for finding if Items is chosen. Then assigns to SetCategory Method
            if (category.Text == "Number of Items")
            {
                numOfItemsLabel.Text = "Number of Items";
                objectRef.SetCategory(PIECE);
            }
        }
        // The yes_CheckedChanged method
        // Purpose: radio button for checking yes to have Surecharge
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void yes_CheckedChanged(object sender, EventArgs e)
        {
            // if statement for if Yes is checked. Assigns to SetSurcharge method
            if (yes.Checked)
                objectRef.SetSurcharge(true);
        }
        // The no_CheckedChanged method
        // Purpose: radio button for checking no to not have a Surecharge
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void no_CheckedChanged(object sender, EventArgs e)
        {
            // if statement for if No is checked. Assigns to SetSurcharge method
            if (no.Checked)
                objectRef.SetSurcharge(false);
        }
        // The numOfItems_TextChanged method
        // Purpose: Allows the user to enter the total for number of items or weight, parses it to a string, then outputs it into the SetWeight, or SetNumItems methods.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void numOfItems_TextChanged(object sender, EventArgs e)
        {
            // if statement that checks for the weight of the item, else check for the number of items. Then parse into a string and assign to SetWeight or SetNumItems.
            if (category.Text == "By Weight")
                objectRef.SetWeight(double.Parse(numOfItems.Text));
            else
                objectRef.SetNumItems(double.Parse(numOfItems.Text));
        }
        // The calcShippingBtn_Click method
        // Purpose: displays the total returned in the calShippingCost Method.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void calcShippingBtn_Click(object sender, EventArgs e)
        {
            // Change the label to show the calculated Shipping Cost.
            shippingCost.Text = string.Format("{0:C}", objectRef.calcShippingCost());
        }
    }
}
