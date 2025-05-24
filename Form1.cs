using System;
using System.Windows.Forms;

namespace Box_of_Noodles {
    public partial class Form1 : Form {
        /// <summary>
        /// 2322441018
        /// Rick 缪彭哲
        /// This program is designed for the order noodles.
        /// </summary>

        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Click the button and caculate the total cost of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_calculate_Click(object sender, EventArgs e) {
            // Check the noodle type
            foreach (RadioButton item in groupBox_noodleType.Controls) {
                if (item.Checked) {
                    // Check the flavour
                    if (comboBox_flavour.Text != "") {
                        // Check the name
                        if (textBox_name.Text != "") {
                            // Caculate the price and display
                            UpdatePrice();
                            ControlOrderDetails(true);
                            return;
                        }
                        MessageBox.Show("Please supply a name for this order!");
                        return;
                    }
                    MessageBox.Show("Please select a flavour!");
                    return;
                }
            }
            MessageBox.Show("Please select a noodle type!");
        }

        /// <summary>
        /// Caculate the price
        /// </summary>
        private void UpdatePrice() {
            // The base cost of noodles
            double baseCost = 5.5;

            // Check the meat type
            foreach (Control item in groupBox_addMeat.Controls) {
                if (item is RadioButton button && button.Checked) {
                    // Seafoof is $7 and others are $ 5
                    baseCost += button.Text == "Seafood" ? 7 :
                               button.Text == "None" ? 0 : 5;
                }
            }
            // Count the numver of vegetable
            int vegetableCount = 0;
            foreach (CheckBox item in groupBox_addVegetables.Controls) {
                if (item.Checked) {
                    vegetableCount++;
                }
            }
            // If vegetable number is over 4, we need to add more money
            if (vegetableCount > 4) {
                baseCost += 0.5 * (vegetableCount - 4);
            }
            // If customer need big serve 
            if (checkBox_bigServe.Checked) {
                baseCost *= 1.5;
            }
            // 1 aud = 0.64 usd (2025.5.10)
            double displayCost = radioButton_aud.Checked ? baseCost : baseCost * 0.64;
            textBox_order.Text = string.Format("${0:f2}", displayCost);
        }

        /// <summary>
        /// Hide the order details when change the meat and vegetable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideOrderDetails(object sender, EventArgs e) {
            ControlOrderDetails(false);
        }

        /// <summary>
        /// Control the show and hide the order details.
        /// </summary>
        /// <param name="option">show or hide</param>
        private void ControlOrderDetails(bool option) {
            label_orderText.Visible = option;
            textBox_order.Visible = option;
            groupBox_currency.Visible = option;
        }

        // When change the big serve or usd/aud
        private void UpdatePrice(object sender, EventArgs e) {
            UpdatePrice();
        }
    }
}