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
    public partial class DominosHuston : Form
    {
        double pizzaPrice, pizza, pepperoniPrice, pepperoni, pepperPrice, pepper, subtotal, total, taxAmount, tendered, change;

        private void tenderedLabel_Click(object sender, EventArgs e)
        {

        }

        double tax = 0.13;
        SoundPlayer player = new SoundPlayer(Properties.Resources.printerNoise);

        public DominosHuston()
        {
            InitializeComponent();
        }
        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                pizzaPrice = 12.50;
                pizza = Convert.ToDouble(pizzaInput.Text);

                pepperoniPrice = 0.50;
                pepperoni = Convert.ToDouble(pepperoniInput.Text);

                pepperPrice = 0.12;
                pepper = Convert.ToDouble(pepperInput.Text);

                subtotal = (pizzaPrice * pizza) + (pepperoniPrice * pepperoni) + (pepperPrice * pepper);
                taxAmount = subtotal * tax;
                total = subtotal + taxAmount;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch
            {
                pizzaInput.Text = "ERROR";
                pepperoniInput.Text = "ERROR";
                pepperInput.Text = "ERROR";

                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";

                tenderedInput.Text = "ERROR";
                changeOutput.Text = "ERROR";

                reciptLabel.Text = "ERROR";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                change = tendered - total;

                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                pizzaInput.Text = "ERROR";
                pepperoniInput.Text = "ERROR";
                pepperInput.Text = "ERROR";

                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";

                tenderedInput.Text = "ERROR";
                changeOutput.Text = "ERROR";

                reciptLabel.Text = "ERROR";
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            player.Play();
            Thread.Sleep(350);

            reciptLabel.Text = $"\n\n                                Dominos Huston";

            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126";

            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023";

            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50";

            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:  X{pepper} @ 0.12";

            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:  X{pepper} @ 0.12\n\n Subtotal:   {subtotal.ToString("C")}";

            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:  X{pepper} @ 0.12\n\n Subtotal:   {subtotal.ToString("C")}\n Tax:  {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:  X{pepper} @ 0.12\n\n Subtotal:   {subtotal.ToString("C")}\n Tax:  {taxAmount.ToString("C")}\n Total:  {total.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:  X{pepper} @ 0.12\n\n Subtotal:   {subtotal.ToString("C")}\n Tax:  {taxAmount.ToString("C")}\n Total:  {total.ToString("C")}\n\n Tendered:    {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(600);

            reciptLabel.Text = $"\n\n                                Dominos Huston\n\n Order Number:  126\n Februrary 22, 2023\n\n Pizzas:   X{pizza} @ $12.50\n Pepperonis:    X{pepperoni} @ $0.50\n Peppers:  X{pepper} @ 0.12\n\n Subtotal:   {subtotal.ToString("C")}\n Tax:  {taxAmount.ToString("C")}\n Total:  {total.ToString("C")}\n\n Tendered:    {tendered.ToString("C")}\n Change:    {change.ToString("C")}";
        }
        private void newOrderButton_Click(object sender, EventArgs e)
        {
                pizzaInput.Text = "";
                pepperoniInput.Text = "";
                pepperInput.Text = "";

                subtotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";

                tenderedInput.Text = "";
                changeOutput.Text = "";

                reciptLabel.Text = "";
            } 
        }
    }
