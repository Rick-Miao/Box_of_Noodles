using System;
using System.Windows.Forms;

namespace Box_of_Noodles {

    public partial class Form1 : Form {
        /// <summary>
        /// 2322441018
        /// Rick 缪彭哲
        /// This program is designed for the order noodles.
        /// </summary>

        // Some usefull const number.
        private const double BASE_NOODLE_PRICE = 5.5;
        private const double SEAFOOD_PRICE = 7.0;
        private const double OTHER_MEAT_PRICE = 5.0;
        private const int FREE_VEGETABLE_LIMIT = 4;
        private const double EXTRA_VEGETABLE_PRICE = 0.5;
        private const double BIG_SERVE_MULTIPLIER = 1.5;
        private const double USD_EXCHANGE_RATE = 0.64;

        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Click the button and calculate the total cost of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_calculate_Click(object sender, EventArgs e) {
            if (InformationIsValid()) {
                UpdatePrice();
                ControlOrderDetails(true);
            }
        }

        /// <summary>
        /// Calculate the price
        /// </summary>
        private void UpdatePrice() {
            // The base cost of noodles
            double baseCost = BASE_NOODLE_PRICE;

            // Check the meat type
            foreach (Control item in groupBox_addMeat.Controls) {
                if (item is RadioButton button && button.Checked) {
                    // Seafood is $7 and others are $ 5
                    baseCost += button.Text == "Seafood" ? SEAFOOD_PRICE :
                               button.Text == "None" ? 0 : OTHER_MEAT_PRICE;
                }
            }
            // Count the number of vegetable
            int vegetableCount = 0;
            foreach (CheckBox item in groupBox_addVegetables.Controls) {
                if (item.Checked) {
                    vegetableCount++;
                }
            }
            // If vegetable number is over 4, we need to add more money
            if (vegetableCount > FREE_VEGETABLE_LIMIT) {
                baseCost += EXTRA_VEGETABLE_PRICE * (vegetableCount - FREE_VEGETABLE_LIMIT);
            }
            // If customer need big serve 
            if (checkBox_bigServe.Checked) {
                baseCost *= BIG_SERVE_MULTIPLIER;
            }
            // 1 aud = 0.64 usd (2025.5.10)
            double displayCost = radioButton_aud.Checked ? baseCost : baseCost * USD_EXCHANGE_RATE;
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
        /// <param name="isVisible ">show or hide</param>
        private void ControlOrderDetails(bool isVisible) {
            label_orderText.Visible = isVisible;
            textBox_order.Visible = isVisible;
            groupBox_currency.Visible = isVisible;
        }

        // When change the big serve or usd/aud
        private void UpdatePrice(object sender, EventArgs e) {
            UpdatePrice();
        }

        /// <summary>
        /// Check three information is given or not.
        /// </summary>
        /// <returns></returns>
        private bool InformationIsValid() {
            // Check the noodle type is checked or not
            bool noodleTypeIsCheck = false;
            foreach (RadioButton item in groupBox_noodleType.Controls) {
                if (item.Checked) {
                    noodleTypeIsCheck = true;
                }
            }
            if (!noodleTypeIsCheck) {
                MessageBox.Show("Please select a noodle type!");
                return false;
            }
            // Check the name is supply or not
            if (textBox_name.Text == "") {
                MessageBox.Show("Please supply a name for this order!");
                return false;
            }
            // Check the flavour is selected or not
            if (comboBox_flavour.Text == "") {
                MessageBox.Show("Please select a flavour!");
                return false;
            }
            return true;
        }
    }
}