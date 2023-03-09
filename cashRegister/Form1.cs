using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace cashRegister
{
    public partial class dominosHouston : Form
    {
        // declaring variables
        double pizza, pepperoni, pepper, subtotal, total, taxAmount, tendered, change;

        double pizzaPrice = 12.50;
        double pepperPrice = 0.12;
        double pepperoniPrice = 0.50;
        double tax = 0.13;

        SoundPlayer player = new SoundPlayer(Properties.Resources.printerNoise);

        public dominosHouston()
        {
            InitializeComponent();

            // disabling the buttons
            reciptButton.Enabled = false;
            changeButton.Enabled = false;

            // disabling the tendered input
            tenderedInput.Enabled = false;
        }
        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                // getting info from inputs
                pizza = Convert.ToDouble(pizzaInput.Text);
                pepperoni = Convert.ToDouble(pepperoniInput.Text);
                pepper = Convert.ToDouble(pepperInput.Text);

                // calculating price
                subtotal = (pizzaPrice * pizza) + (pepperoniPrice * pepperoni) + (pepperPrice * pepper);
                taxAmount = subtotal * tax;
                total = subtotal + taxAmount;

                // displaying cost
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";

                // enabling changeButton
                changeButton.Enabled = true;

                // disabling the tendered input
                tenderedInput.Enabled = true;
            }
            catch
            {
                // setting all the inputs and outputs to ERROR
                pizzaInput.Text = "ERROR";
                pepperoniInput.Text = "ERROR";
                pepperInput.Text = "ERROR";

                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";

                tenderedInput.Text = "ERROR";
                changeOutput.Text = "ERROR";

                reciptLabel.Text = "ERROR";

                // reseting variables
                pizza = 0;
                pepperoni = 0;
                pepper = 0;

                // disabling the buttons
                reciptButton.Enabled = false;
                changeButton.Enabled = false;

                // disabling the tendered input
                tenderedInput.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // getting tendered input
                tendered = Convert.ToDouble(tenderedInput.Text);

                // calculating and siplaying change
                change = tendered - total;
                changeOutput.Text = $"{change.ToString("C")}";

                // enabling the recipt button
                reciptButton.Enabled = true;
            }
            catch
            {
                // setting all the inputs and outputs to ERROR
                pizzaInput.Text = "ERROR";
                pepperoniInput.Text = "ERROR";
                pepperInput.Text = "ERROR";

                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";

                tenderedInput.Text = "ERROR";
                changeOutput.Text = "ERROR";

                reciptLabel.Text = "ERROR";

                // reseting variables
                pizza = 0;
                pepperoni = 0;
                pepper = 0;

                // disabling the recipt button
                reciptButton.Enabled = false;
                changeButton.Enabled = false;

                // disabling the tendered input
                tenderedInput.Enabled = false;
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            // playing the recipt sound
            player.Play();
            Thread.Sleep(350);

            // printing the recipt
            reciptLabel.Text = $"\n\n                              Dominos Houston";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:         X{pepper} @ $0.12";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:         X{pepper} @ $0.12\n\n Subtotal:                    {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:         X{pepper} @ $0.12\n\n Subtotal:                    {subtotal.ToString("C")}\n Tax:                           {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:         X{pepper} @ $0.12\n\n Subtotal:                    {subtotal.ToString("C")}\n Tax:                           {taxAmount.ToString("C")}\n Total:                         {total.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:         X{pepper} @ $0.12\n\n Subtotal:                    {subtotal.ToString("C")}\n Tax:                           {taxAmount.ToString("C")}\n Total:                         {total.ToString("C")}\n\n Tendered:                  {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                              Dominos Houston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:            X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:         X{pepper} @ $0.12\n\n Subtotal:                    {subtotal.ToString("C")}\n Tax:                           {taxAmount.ToString("C")}\n Total:                         {total.ToString("C")}\n\n Tendered:                  {tendered.ToString("C")}\n Change:                     {change.ToString("C")}";
        }
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            // clearing the text boxes
            pizzaInput.Text = "";
            pepperoniInput.Text = "";
            pepperInput.Text = "";

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            tenderedInput.Text = "";
            changeOutput.Text = "";

            reciptLabel.Text = "";

            // resetting variables
            pizza = 0;
            pepperoni = 0;
            pepper = 0;

            // disabling buttons
            changeButton.Enabled = false;
            reciptButton.Enabled = false;

            // disabling the tendered input
            tenderedInput.Enabled = false;
        }
    }
}