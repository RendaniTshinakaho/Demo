using System;
using System.Windows.Forms;

namespace MethodsExample
{
    public partial class Form1 : Form
    {
        private const double US_TAX_AMOUNT = 0.065;
        private const double GB_TAX_AMOUNT = 0.0825;
        private const double CA_TAX_AMOUNT = 0.0775;
        public Form1()
        {
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight;
            double distance;        
            //
            weight = double.Parse(txtWeight.Text);
            distance = double.Parse(txtDistance.Text);
            //
            calculateAmount(weight,distance,US_TAX_AMOUNT);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcGB_Click(object sender, EventArgs e)
        {
            double weight;
            double distance;
            //
            weight = double.Parse(txtWeight.Text);
            distance = double.Parse(txtDistance.Text);
            //
            calculateAmount(weight, distance, GB_TAX_AMOUNT);
        }

        private void btnCalcCA_Click(object sender, EventArgs e)
        {
            double weight;
            double distance;
            //
            weight = double.Parse(txtWeight.Text);
            distance = double.Parse(txtDistance.Text);
            //
            calculateAmount(weight, distance, CA_TAX_AMOUNT);
        }
        private void calculateAmount(double weight, double distance, double taxPercentage)
        {
            double subtotal;
            double tax;
            double total;
            //
            subtotal = CalculateSubTotal(weight, distance);
            tax = calculateTax(taxPercentage, subtotal);
            total = subtotal + tax;
            //
            DisplayResults(subtotal,tax,total);
        }
        private double calculateTax(double taxPercentage,double taxAmount)
        {
            return taxPercentage*taxAmount;
        }
        private double CalculateSubTotal(double weight, double distance)
        {
            return weight * distance * 0.5;
        }
        private void DisplayResults(double subTotal,double taxAmount,double total)
        {
            lblSubTotal.Text = string.Format("{0:C}", subTotal);
            lblDisplayTax.Text = string.Format("{0:C}", taxAmount);
            lblDisplayTotal.Text = string.Format("{0:C}", total);
        }
    }
}
