// Author: Jonathan Spalding
// Assignment: Project 06
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 3/5/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Rates
{
    class ShippingRatesClass
    {
        // State Constants
        private const double ASTANDARD = 3;
        private const double BSTANDARD = 1.45;
        private const double AEXPRESS = 4;
        private const double BEXPRESS = 2.5;
        private const double ASAME = 5.5;
        private const double BSAME = 3;
        private const double STANDARDSURCHARGE = 2.5;
        private const double EXPRESSSURCHARGE = 5;
        private const double SAMESURCHARGE = 8;
        private const double STANDARD = 1;
        private const double EXPRESS = 2;
        private const double SAME = 3;
        private const double WEIGHT = 4;
        private const double ITEM = 5;
        private const double TOTAL = 0;
        // State the data members of the class.
        private double method;
        private double category;
        private double weight;
        private double numItems;
        private bool surcharge;

        // The parameterized constructor
        // Purpose: It sets all declared variables (data members of the class) to the values passed in.
        // Parameters: doubles, method, category, weight, numItems, and bool surcharge
        // Returns: None
        public ShippingRatesClass()
        {
            method = 0;
            category = 0;
            weight = 0;
            numItems = 0;
            surcharge = false;
        }
        // The SetMethod method
        // Purpose: setter for method
        // Parameters: double _method
        // Returns: none
        public void SetMethod(double _method)
        {
            method = _method;
        }
        // The SetCategory method
        // Purpose: setter for category
        // Parameters: double _category
        // Returns: none
        public void SetCategory(double _category)
        {
            category = _category;
        }
        // The SetWeight method
        // Purpose: setter for weight
        // Parameters: double _weight
        // Returns: none
        public void SetWeight(double _weight)
        {
            weight = _weight;
        }
        // The SetNumItems method
        // Purpose: setter for numItems
        // Parameters: double _numItems
        // Returns: none
        public void SetNumItems(double _numItems)
        {
            numItems = _numItems;
        }
        // The SetMethod setSurcharge
        // Purpose: setter for surcharge
        // Parameters: bool _surcharge
        // Returns: none
        public void SetSurcharge(bool _surcharge)
        {
            surcharge = _surcharge;
        }
        // The GetMethod method
        // Purpose: return Method
        // Parameters: None
        // Returns: double method
        public double GetMethod()
        {
            return method;
        }
        // The GetCategory method
        // Purpose: return Method
        // Parameters: None
        // Returns: double category
        public double GetCategory()
        {
            return category;
        }
        // The GetWeight method
        // Purpose: return weight
        // Parameters: None
        // Returns: double weight
        public double GetWeight()
        {
            return weight;
        }
        // The GetNumItems method
        // Purpose: return numItems
        // Parameters: None
        // Returns: double numItems
        public double GetNumItems()
        {
            return numItems;
        }
        // The GetSurcharge method
        // Purpose: return surcharge
        // Parameters: None
        // Returns: double surcharge
        public bool GetSurcharge()
        {
            return surcharge;
        }
        // The calcShippingCost method
        // Purpose: 
        // Parameters: None
        // Returns: double ShippingCostTotal
        public double calcShippingCost()
        {
            // create a variable for the total.
            double ShippingCostTotal = TOTAL;
            // if else statement for finding total with Standard shipping depending on category and surcharge
            if (method == STANDARD && category == ITEM && !surcharge)
                ShippingCostTotal = ASTANDARD * numItems;
            else if (method == STANDARD && category == ITEM && surcharge)
                ShippingCostTotal = ASTANDARD * numItems + STANDARDSURCHARGE;
            else if (method == STANDARD && category == WEIGHT && !surcharge)
                ShippingCostTotal = BSTANDARD * weight;
            else if (method == STANDARD && category == WEIGHT && surcharge)
                ShippingCostTotal = BSTANDARD * weight + STANDARDSURCHARGE;
            // if else statement for finding total with Express shipping depending on category and surcharge
            else if (method == EXPRESS && category == ITEM && !surcharge)
                ShippingCostTotal = AEXPRESS * numItems;
            else if (method == EXPRESS && category == ITEM && surcharge)
                ShippingCostTotal = AEXPRESS * numItems + EXPRESSSURCHARGE;
            else if (method == EXPRESS && category == WEIGHT && !surcharge)
                ShippingCostTotal = BEXPRESS * weight;
            else if (method == EXPRESS && category == WEIGHT && surcharge)
                ShippingCostTotal = BEXPRESS * weight + EXPRESSSURCHARGE;
            // if else statement for finding total with Same Day shipping depending on category and surcharge
            else if (method == SAME && category == ITEM && !surcharge)
                ShippingCostTotal = ASAME * numItems;
            else if (method == SAME && category == ITEM && surcharge)
                ShippingCostTotal = ASAME * numItems + SAMESURCHARGE;
            else if (method == SAME && category == WEIGHT && !surcharge)
                ShippingCostTotal = BSAME * weight;
            else if (method == SAME && category == WEIGHT && surcharge)
                ShippingCostTotal = BSAME * weight + SAMESURCHARGE;
            //return the result
            return ShippingCostTotal;
        }
    }
}
