namespace Box_of_Noodles
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_title = new System.Windows.Forms.Label();
            this.label_choiceText = new System.Windows.Forms.Label();
            this.groupBox_noodleType = new System.Windows.Forms.GroupBox();
            this.radioButton_Hokien = new System.Windows.Forms.RadioButton();
            this.radioButton_thickEgg = new System.Windows.Forms.RadioButton();
            this.radioButton_wideFlatRice = new System.Windows.Forms.RadioButton();
            this.radioButton_udon = new System.Windows.Forms.RadioButton();
            this.radioButton_thinEgg = new System.Windows.Forms.RadioButton();
            this.radioButton_riceVermicelli = new System.Windows.Forms.RadioButton();
            this.groupBox_addMeat = new System.Windows.Forms.GroupBox();
            this.label_seafoodPrice = new System.Windows.Forms.Label();
            this.label_beefPrice = new System.Windows.Forms.Label();
            this.label_porkPrice = new System.Windows.Forms.Label();
            this.label_chickenPrice = new System.Windows.Forms.Label();
            this.radioButton_none = new System.Windows.Forms.RadioButton();
            this.radioButton_seafood = new System.Windows.Forms.RadioButton();
            this.radioButton_beef = new System.Windows.Forms.RadioButton();
            this.radioButton_pork = new System.Windows.Forms.RadioButton();
            this.radioButton_chicken = new System.Windows.Forms.RadioButton();
            this.groupBox_addVegetables = new System.Windows.Forms.GroupBox();
            this.checkBox_sprouts = new System.Windows.Forms.CheckBox();
            this.checkBox_snowPeas = new System.Windows.Forms.CheckBox();
            this.checkBox_bokChoy = new System.Windows.Forms.CheckBox();
            this.checkBox_shallots = new System.Windows.Forms.CheckBox();
            this.checkBox_cabbage = new System.Windows.Forms.CheckBox();
            this.checkBox_greenBeans = new System.Windows.Forms.CheckBox();
            this.checkBox_Onion = new System.Windows.Forms.CheckBox();
            this.checkBox_carrot = new System.Windows.Forms.CheckBox();
            this.checkBox_broccoli = new System.Windows.Forms.CheckBox();
            this.checkBox_capscicum = new System.Windows.Forms.CheckBox();
            this.label_addVegetablesTip = new System.Windows.Forms.Label();
            this.label_chooseFlavour = new System.Windows.Forms.Label();
            this.comboBox_flavour = new System.Windows.Forms.ComboBox();
            this.label_yourName = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.checkBox_bigServe = new System.Windows.Forms.CheckBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label_orderText = new System.Windows.Forms.Label();
            this.textBox_order = new System.Windows.Forms.TextBox();
            this.groupBox_currency = new System.Windows.Forms.GroupBox();
            this.radioButton_usd = new System.Windows.Forms.RadioButton();
            this.radioButton_aud = new System.Windows.Forms.RadioButton();
            this.groupBox_noodleType.SuspendLayout();
            this.groupBox_addMeat.SuspendLayout();
            this.groupBox_addVegetables.SuspendLayout();
            this.groupBox_currency.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(145, 36);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(724, 56);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Order Your Box of Noodles";
            // 
            // label_choiceText
            // 
            this.label_choiceText.AutoSize = true;
            this.label_choiceText.BackColor = System.Drawing.Color.Transparent;
            this.label_choiceText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_choiceText.Location = new System.Drawing.Point(73, 107);
            this.label_choiceText.Name = "label_choiceText";
            this.label_choiceText.Size = new System.Drawing.Size(189, 19);
            this.label_choiceText.TabIndex = 1;
            this.label_choiceText.Text = "Make your choices:";
            // 
            // groupBox_noodleType
            // 
            this.groupBox_noodleType.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_noodleType.Controls.Add(this.radioButton_Hokien);
            this.groupBox_noodleType.Controls.Add(this.radioButton_thickEgg);
            this.groupBox_noodleType.Controls.Add(this.radioButton_wideFlatRice);
            this.groupBox_noodleType.Controls.Add(this.radioButton_udon);
            this.groupBox_noodleType.Controls.Add(this.radioButton_thinEgg);
            this.groupBox_noodleType.Controls.Add(this.radioButton_riceVermicelli);
            this.groupBox_noodleType.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox_noodleType.Location = new System.Drawing.Point(77, 142);
            this.groupBox_noodleType.Name = "groupBox_noodleType";
            this.groupBox_noodleType.Size = new System.Drawing.Size(365, 100);
            this.groupBox_noodleType.TabIndex = 2;
            this.groupBox_noodleType.TabStop = false;
            this.groupBox_noodleType.Text = "Noodle type:";
            // 
            // radioButton_Hokien
            // 
            this.radioButton_Hokien.AutoSize = true;
            this.radioButton_Hokien.Font = new System.Drawing.Font("宋体", 9.75F);
            this.radioButton_Hokien.Location = new System.Drawing.Point(273, 61);
            this.radioButton_Hokien.Name = "radioButton_Hokien";
            this.radioButton_Hokien.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Hokien.TabIndex = 5;
            this.radioButton_Hokien.Text = "Hokien";
            this.radioButton_Hokien.UseVisualStyleBackColor = true;
            // 
            // radioButton_thickEgg
            // 
            this.radioButton_thickEgg.AutoSize = true;
            this.radioButton_thickEgg.Font = new System.Drawing.Font("宋体", 9.75F);
            this.radioButton_thickEgg.Location = new System.Drawing.Point(172, 61);
            this.radioButton_thickEgg.Name = "radioButton_thickEgg";
            this.radioButton_thickEgg.Size = new System.Drawing.Size(88, 17);
            this.radioButton_thickEgg.TabIndex = 4;
            this.radioButton_thickEgg.Text = "Thick Egg";
            this.radioButton_thickEgg.UseVisualStyleBackColor = true;
            // 
            // radioButton_wideFlatRice
            // 
            this.radioButton_wideFlatRice.AutoSize = true;
            this.radioButton_wideFlatRice.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_wideFlatRice.Location = new System.Drawing.Point(28, 61);
            this.radioButton_wideFlatRice.Name = "radioButton_wideFlatRice";
            this.radioButton_wideFlatRice.Size = new System.Drawing.Size(123, 17);
            this.radioButton_wideFlatRice.TabIndex = 3;
            this.radioButton_wideFlatRice.Text = "Wide Flat Rice";
            this.radioButton_wideFlatRice.UseVisualStyleBackColor = true;
            // 
            // radioButton_udon
            // 
            this.radioButton_udon.AutoSize = true;
            this.radioButton_udon.Font = new System.Drawing.Font("宋体", 9.75F);
            this.radioButton_udon.Location = new System.Drawing.Point(273, 28);
            this.radioButton_udon.Name = "radioButton_udon";
            this.radioButton_udon.Size = new System.Drawing.Size(53, 17);
            this.radioButton_udon.TabIndex = 2;
            this.radioButton_udon.Text = "Udon";
            this.radioButton_udon.UseVisualStyleBackColor = true;
            // 
            // radioButton_thinEgg
            // 
            this.radioButton_thinEgg.AutoSize = true;
            this.radioButton_thinEgg.Font = new System.Drawing.Font("宋体", 9.75F);
            this.radioButton_thinEgg.Location = new System.Drawing.Point(172, 28);
            this.radioButton_thinEgg.Name = "radioButton_thinEgg";
            this.radioButton_thinEgg.Size = new System.Drawing.Size(81, 17);
            this.radioButton_thinEgg.TabIndex = 1;
            this.radioButton_thinEgg.Text = "Thin Egg";
            this.radioButton_thinEgg.UseVisualStyleBackColor = true;
            // 
            // radioButton_riceVermicelli
            // 
            this.radioButton_riceVermicelli.AutoSize = true;
            this.radioButton_riceVermicelli.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_riceVermicelli.Location = new System.Drawing.Point(28, 28);
            this.radioButton_riceVermicelli.Name = "radioButton_riceVermicelli";
            this.radioButton_riceVermicelli.Size = new System.Drawing.Size(130, 17);
            this.radioButton_riceVermicelli.TabIndex = 0;
            this.radioButton_riceVermicelli.Text = "Rice Vermicelli";
            this.radioButton_riceVermicelli.UseVisualStyleBackColor = true;
            // 
            // groupBox_addMeat
            // 
            this.groupBox_addMeat.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_addMeat.Controls.Add(this.label_seafoodPrice);
            this.groupBox_addMeat.Controls.Add(this.label_beefPrice);
            this.groupBox_addMeat.Controls.Add(this.label_porkPrice);
            this.groupBox_addMeat.Controls.Add(this.label_chickenPrice);
            this.groupBox_addMeat.Controls.Add(this.radioButton_none);
            this.groupBox_addMeat.Controls.Add(this.radioButton_seafood);
            this.groupBox_addMeat.Controls.Add(this.radioButton_beef);
            this.groupBox_addMeat.Controls.Add(this.radioButton_pork);
            this.groupBox_addMeat.Controls.Add(this.radioButton_chicken);
            this.groupBox_addMeat.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox_addMeat.Location = new System.Drawing.Point(77, 247);
            this.groupBox_addMeat.Name = "groupBox_addMeat";
            this.groupBox_addMeat.Size = new System.Drawing.Size(213, 157);
            this.groupBox_addMeat.TabIndex = 6;
            this.groupBox_addMeat.TabStop = false;
            this.groupBox_addMeat.Text = "Add meat:";
            this.groupBox_addMeat.Enter += new System.EventHandler(this.HideOrderDetails);
            // 
            // label_seafoodPrice
            // 
            this.label_seafoodPrice.AutoSize = true;
            this.label_seafoodPrice.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label_seafoodPrice.Location = new System.Drawing.Point(127, 101);
            this.label_seafoodPrice.Name = "label_seafoodPrice";
            this.label_seafoodPrice.Size = new System.Drawing.Size(21, 13);
            this.label_seafoodPrice.TabIndex = 10;
            this.label_seafoodPrice.Text = "$7";
            // 
            // label_beefPrice
            // 
            this.label_beefPrice.AutoSize = true;
            this.label_beefPrice.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label_beefPrice.Location = new System.Drawing.Point(127, 78);
            this.label_beefPrice.Name = "label_beefPrice";
            this.label_beefPrice.Size = new System.Drawing.Size(21, 13);
            this.label_beefPrice.TabIndex = 9;
            this.label_beefPrice.Text = "$5";
            // 
            // label_porkPrice
            // 
            this.label_porkPrice.AutoSize = true;
            this.label_porkPrice.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label_porkPrice.Location = new System.Drawing.Point(127, 53);
            this.label_porkPrice.Name = "label_porkPrice";
            this.label_porkPrice.Size = new System.Drawing.Size(21, 13);
            this.label_porkPrice.TabIndex = 8;
            this.label_porkPrice.Text = "$5";
            // 
            // label_chickenPrice
            // 
            this.label_chickenPrice.AutoSize = true;
            this.label_chickenPrice.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label_chickenPrice.Location = new System.Drawing.Point(127, 29);
            this.label_chickenPrice.Name = "label_chickenPrice";
            this.label_chickenPrice.Size = new System.Drawing.Size(21, 13);
            this.label_chickenPrice.TabIndex = 7;
            this.label_chickenPrice.Text = "$5";
            // 
            // radioButton_none
            // 
            this.radioButton_none.AutoSize = true;
            this.radioButton_none.Checked = true;
            this.radioButton_none.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_none.Location = new System.Drawing.Point(20, 120);
            this.radioButton_none.Name = "radioButton_none";
            this.radioButton_none.Size = new System.Drawing.Size(53, 17);
            this.radioButton_none.TabIndex = 6;
            this.radioButton_none.TabStop = true;
            this.radioButton_none.Text = "None";
            this.radioButton_none.UseVisualStyleBackColor = true;
            // 
            // radioButton_seafood
            // 
            this.radioButton_seafood.AutoSize = true;
            this.radioButton_seafood.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_seafood.Location = new System.Drawing.Point(20, 97);
            this.radioButton_seafood.Name = "radioButton_seafood";
            this.radioButton_seafood.Size = new System.Drawing.Size(74, 17);
            this.radioButton_seafood.TabIndex = 5;
            this.radioButton_seafood.Text = "Seafood";
            this.radioButton_seafood.UseVisualStyleBackColor = true;
            // 
            // radioButton_beef
            // 
            this.radioButton_beef.AutoSize = true;
            this.radioButton_beef.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_beef.Location = new System.Drawing.Point(20, 74);
            this.radioButton_beef.Name = "radioButton_beef";
            this.radioButton_beef.Size = new System.Drawing.Size(53, 17);
            this.radioButton_beef.TabIndex = 4;
            this.radioButton_beef.Text = "Beef";
            this.radioButton_beef.UseVisualStyleBackColor = true;
            // 
            // radioButton_pork
            // 
            this.radioButton_pork.AutoSize = true;
            this.radioButton_pork.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_pork.Location = new System.Drawing.Point(20, 51);
            this.radioButton_pork.Name = "radioButton_pork";
            this.radioButton_pork.Size = new System.Drawing.Size(53, 17);
            this.radioButton_pork.TabIndex = 3;
            this.radioButton_pork.Text = "Pork";
            this.radioButton_pork.UseVisualStyleBackColor = true;
            // 
            // radioButton_chicken
            // 
            this.radioButton_chicken.AutoSize = true;
            this.radioButton_chicken.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_chicken.Location = new System.Drawing.Point(20, 28);
            this.radioButton_chicken.Name = "radioButton_chicken";
            this.radioButton_chicken.Size = new System.Drawing.Size(74, 17);
            this.radioButton_chicken.TabIndex = 0;
            this.radioButton_chicken.Text = "Chicken";
            this.radioButton_chicken.UseVisualStyleBackColor = true;
            // 
            // groupBox_addVegetables
            // 
            this.groupBox_addVegetables.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_addVegetables.Controls.Add(this.checkBox_sprouts);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_snowPeas);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_bokChoy);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_shallots);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_cabbage);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_greenBeans);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_Onion);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_carrot);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_broccoli);
            this.groupBox_addVegetables.Controls.Add(this.checkBox_capscicum);
            this.groupBox_addVegetables.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox_addVegetables.Location = new System.Drawing.Point(312, 247);
            this.groupBox_addVegetables.Name = "groupBox_addVegetables";
            this.groupBox_addVegetables.Size = new System.Drawing.Size(275, 157);
            this.groupBox_addVegetables.TabIndex = 11;
            this.groupBox_addVegetables.TabStop = false;
            this.groupBox_addVegetables.Text = "Add vegetables:";
            this.groupBox_addVegetables.Enter += new System.EventHandler(this.HideOrderDetails);
            // 
            // checkBox_sprouts
            // 
            this.checkBox_sprouts.AutoSize = true;
            this.checkBox_sprouts.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_sprouts.Location = new System.Drawing.Point(153, 120);
            this.checkBox_sprouts.Name = "checkBox_sprouts";
            this.checkBox_sprouts.Size = new System.Drawing.Size(75, 17);
            this.checkBox_sprouts.TabIndex = 9;
            this.checkBox_sprouts.Text = "Sprouts";
            this.checkBox_sprouts.UseVisualStyleBackColor = true;
            // 
            // checkBox_snowPeas
            // 
            this.checkBox_snowPeas.AutoSize = true;
            this.checkBox_snowPeas.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_snowPeas.Location = new System.Drawing.Point(153, 97);
            this.checkBox_snowPeas.Name = "checkBox_snowPeas";
            this.checkBox_snowPeas.Size = new System.Drawing.Size(89, 17);
            this.checkBox_snowPeas.TabIndex = 8;
            this.checkBox_snowPeas.Text = "Snow Peas";
            this.checkBox_snowPeas.UseVisualStyleBackColor = true;
            // 
            // checkBox_bokChoy
            // 
            this.checkBox_bokChoy.AutoSize = true;
            this.checkBox_bokChoy.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_bokChoy.Location = new System.Drawing.Point(154, 75);
            this.checkBox_bokChoy.Name = "checkBox_bokChoy";
            this.checkBox_bokChoy.Size = new System.Drawing.Size(82, 17);
            this.checkBox_bokChoy.TabIndex = 7;
            this.checkBox_bokChoy.Text = "Bok Choy";
            this.checkBox_bokChoy.UseVisualStyleBackColor = true;
            // 
            // checkBox_shallots
            // 
            this.checkBox_shallots.AutoSize = true;
            this.checkBox_shallots.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_shallots.Location = new System.Drawing.Point(153, 52);
            this.checkBox_shallots.Name = "checkBox_shallots";
            this.checkBox_shallots.Size = new System.Drawing.Size(82, 17);
            this.checkBox_shallots.TabIndex = 6;
            this.checkBox_shallots.Text = "Shallots";
            this.checkBox_shallots.UseVisualStyleBackColor = true;
            // 
            // checkBox_cabbage
            // 
            this.checkBox_cabbage.AutoSize = true;
            this.checkBox_cabbage.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_cabbage.Location = new System.Drawing.Point(153, 29);
            this.checkBox_cabbage.Name = "checkBox_cabbage";
            this.checkBox_cabbage.Size = new System.Drawing.Size(75, 17);
            this.checkBox_cabbage.TabIndex = 5;
            this.checkBox_cabbage.Text = "Cabbage";
            this.checkBox_cabbage.UseVisualStyleBackColor = true;
            // 
            // checkBox_greenBeans
            // 
            this.checkBox_greenBeans.AutoSize = true;
            this.checkBox_greenBeans.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_greenBeans.Location = new System.Drawing.Point(26, 120);
            this.checkBox_greenBeans.Name = "checkBox_greenBeans";
            this.checkBox_greenBeans.Size = new System.Drawing.Size(103, 17);
            this.checkBox_greenBeans.TabIndex = 4;
            this.checkBox_greenBeans.Text = "Green Beans";
            this.checkBox_greenBeans.UseVisualStyleBackColor = true;
            // 
            // checkBox_Onion
            // 
            this.checkBox_Onion.AutoSize = true;
            this.checkBox_Onion.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_Onion.Location = new System.Drawing.Point(26, 97);
            this.checkBox_Onion.Name = "checkBox_Onion";
            this.checkBox_Onion.Size = new System.Drawing.Size(61, 17);
            this.checkBox_Onion.TabIndex = 3;
            this.checkBox_Onion.Text = "Onion";
            this.checkBox_Onion.UseVisualStyleBackColor = true;
            // 
            // checkBox_carrot
            // 
            this.checkBox_carrot.AutoSize = true;
            this.checkBox_carrot.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_carrot.Location = new System.Drawing.Point(27, 75);
            this.checkBox_carrot.Name = "checkBox_carrot";
            this.checkBox_carrot.Size = new System.Drawing.Size(68, 17);
            this.checkBox_carrot.TabIndex = 2;
            this.checkBox_carrot.Text = "Carrot";
            this.checkBox_carrot.UseVisualStyleBackColor = true;
            // 
            // checkBox_broccoli
            // 
            this.checkBox_broccoli.AutoSize = true;
            this.checkBox_broccoli.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_broccoli.Location = new System.Drawing.Point(26, 52);
            this.checkBox_broccoli.Name = "checkBox_broccoli";
            this.checkBox_broccoli.Size = new System.Drawing.Size(82, 17);
            this.checkBox_broccoli.TabIndex = 1;
            this.checkBox_broccoli.Text = "Broccoli";
            this.checkBox_broccoli.UseVisualStyleBackColor = true;
            // 
            // checkBox_capscicum
            // 
            this.checkBox_capscicum.AutoSize = true;
            this.checkBox_capscicum.Font = new System.Drawing.Font("宋体", 9.75F);
            this.checkBox_capscicum.Location = new System.Drawing.Point(26, 29);
            this.checkBox_capscicum.Name = "checkBox_capscicum";
            this.checkBox_capscicum.Size = new System.Drawing.Size(89, 17);
            this.checkBox_capscicum.TabIndex = 0;
            this.checkBox_capscicum.Text = "Capscicum";
            this.checkBox_capscicum.UseVisualStyleBackColor = true;
            // 
            // label_addVegetablesTip
            // 
            this.label_addVegetablesTip.AutoSize = true;
            this.label_addVegetablesTip.BackColor = System.Drawing.Color.Transparent;
            this.label_addVegetablesTip.Font = new System.Drawing.Font("宋体", 12F);
            this.label_addVegetablesTip.Location = new System.Drawing.Point(325, 437);
            this.label_addVegetablesTip.Name = "label_addVegetablesTip";
            this.label_addVegetablesTip.Size = new System.Drawing.Size(295, 32);
            this.label_addVegetablesTip.TabIndex = 12;
            this.label_addVegetablesTip.Text = "Choose up to 4 vegetables.\r\nEach additional vegetable = $0.50AUD\r\n";
            // 
            // label_chooseFlavour
            // 
            this.label_chooseFlavour.AutoSize = true;
            this.label_chooseFlavour.BackColor = System.Drawing.Color.Transparent;
            this.label_chooseFlavour.Font = new System.Drawing.Font("宋体", 13F);
            this.label_chooseFlavour.Location = new System.Drawing.Point(180, 486);
            this.label_chooseFlavour.Name = "label_chooseFlavour";
            this.label_chooseFlavour.Size = new System.Drawing.Size(143, 18);
            this.label_chooseFlavour.TabIndex = 13;
            this.label_chooseFlavour.Text = "Choose Flavour:";
            // 
            // comboBox_flavour
            // 
            this.comboBox_flavour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_flavour.Font = new System.Drawing.Font("宋体", 13F);
            this.comboBox_flavour.FormattingEnabled = true;
            this.comboBox_flavour.Items.AddRange(new object[] {
            "VERY Hot and spicy ",
            "MEDIUM Hot and spicy ",
            "MILD spicy ",
            "Sweet chilli ",
            "Soy and honey "});
            this.comboBox_flavour.Location = new System.Drawing.Point(329, 486);
            this.comboBox_flavour.Name = "comboBox_flavour";
            this.comboBox_flavour.Size = new System.Drawing.Size(244, 25);
            this.comboBox_flavour.TabIndex = 14;
            // 
            // label_yourName
            // 
            this.label_yourName.AutoSize = true;
            this.label_yourName.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label_yourName.Location = new System.Drawing.Point(539, 107);
            this.label_yourName.Name = "label_yourName";
            this.label_yourName.Size = new System.Drawing.Size(99, 19);
            this.label_yourName.TabIndex = 15;
            this.label_yourName.Text = "Yor Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("宋体", 14.25F);
            this.textBox_name.Location = new System.Drawing.Point(543, 142);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(400, 29);
            this.textBox_name.TabIndex = 16;
            // 
            // checkBox_bigServe
            // 
            this.checkBox_bigServe.AutoSize = true;
            this.checkBox_bigServe.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_bigServe.Font = new System.Drawing.Font("宋体", 13F);
            this.checkBox_bigServe.Location = new System.Drawing.Point(612, 203);
            this.checkBox_bigServe.Name = "checkBox_bigServe";
            this.checkBox_bigServe.Size = new System.Drawing.Size(225, 40);
            this.checkBox_bigServe.TabIndex = 17;
            this.checkBox_bigServe.Text = "I\'m feeling hungry ...\r\nMake it a big serve!";
            this.checkBox_bigServe.UseVisualStyleBackColor = false;
            this.checkBox_bigServe.CheckedChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // button_calculate
            // 
            this.button_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_calculate.Font = new System.Drawing.Font("宋体", 25F);
            this.button_calculate.Location = new System.Drawing.Point(612, 249);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(257, 61);
            this.button_calculate.TabIndex = 18;
            this.button_calculate.Text = "CALCULATE";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label_orderText
            // 
            this.label_orderText.AutoSize = true;
            this.label_orderText.BackColor = System.Drawing.Color.Transparent;
            this.label_orderText.Font = new System.Drawing.Font("宋体", 13F);
            this.label_orderText.Location = new System.Drawing.Point(610, 348);
            this.label_orderText.Name = "label_orderText";
            this.label_orderText.Size = new System.Drawing.Size(188, 18);
            this.label_orderText.TabIndex = 19;
            this.label_orderText.Text = "Your order comes to:";
            this.label_orderText.Visible = false;
            // 
            // textBox_order
            // 
            this.textBox_order.Enabled = false;
            this.textBox_order.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox_order.Location = new System.Drawing.Point(613, 369);
            this.textBox_order.Name = "textBox_order";
            this.textBox_order.Size = new System.Drawing.Size(185, 35);
            this.textBox_order.TabIndex = 20;
            this.textBox_order.Text = "$";
            this.textBox_order.Visible = false;
            // 
            // groupBox_currency
            // 
            this.groupBox_currency.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_currency.Controls.Add(this.radioButton_usd);
            this.groupBox_currency.Controls.Add(this.radioButton_aud);
            this.groupBox_currency.Location = new System.Drawing.Point(804, 344);
            this.groupBox_currency.Name = "groupBox_currency";
            this.groupBox_currency.Size = new System.Drawing.Size(105, 69);
            this.groupBox_currency.TabIndex = 21;
            this.groupBox_currency.TabStop = false;
            this.groupBox_currency.Visible = false;
            // 
            // radioButton_usd
            // 
            this.radioButton_usd.AutoSize = true;
            this.radioButton_usd.Font = new System.Drawing.Font("宋体", 10F);
            this.radioButton_usd.Location = new System.Drawing.Point(40, 40);
            this.radioButton_usd.Name = "radioButton_usd";
            this.radioButton_usd.Size = new System.Drawing.Size(46, 18);
            this.radioButton_usd.TabIndex = 1;
            this.radioButton_usd.Text = "USD";
            this.radioButton_usd.UseVisualStyleBackColor = true;
            // 
            // radioButton_aud
            // 
            this.radioButton_aud.AutoSize = true;
            this.radioButton_aud.Checked = true;
            this.radioButton_aud.Font = new System.Drawing.Font("宋体", 10F);
            this.radioButton_aud.Location = new System.Drawing.Point(40, 18);
            this.radioButton_aud.Name = "radioButton_aud";
            this.radioButton_aud.Size = new System.Drawing.Size(46, 18);
            this.radioButton_aud.TabIndex = 0;
            this.radioButton_aud.TabStop = true;
            this.radioButton_aud.Text = "AUD";
            this.radioButton_aud.UseVisualStyleBackColor = true;
            this.radioButton_aud.CheckedChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 536);
            this.Controls.Add(this.groupBox_currency);
            this.Controls.Add(this.textBox_order);
            this.Controls.Add(this.label_orderText);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.checkBox_bigServe);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_yourName);
            this.Controls.Add(this.comboBox_flavour);
            this.Controls.Add(this.label_chooseFlavour);
            this.Controls.Add(this.label_addVegetablesTip);
            this.Controls.Add(this.groupBox_addVegetables);
            this.Controls.Add(this.groupBox_addMeat);
            this.Controls.Add(this.groupBox_noodleType);
            this.Controls.Add(this.label_choiceText);
            this.Controls.Add(this.label_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Box of Noodles";
            this.groupBox_noodleType.ResumeLayout(false);
            this.groupBox_noodleType.PerformLayout();
            this.groupBox_addMeat.ResumeLayout(false);
            this.groupBox_addMeat.PerformLayout();
            this.groupBox_addVegetables.ResumeLayout(false);
            this.groupBox_addVegetables.PerformLayout();
            this.groupBox_currency.ResumeLayout(false);
            this.groupBox_currency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_choiceText;
        private System.Windows.Forms.GroupBox groupBox_noodleType;
        private System.Windows.Forms.RadioButton radioButton_riceVermicelli;
        private System.Windows.Forms.RadioButton radioButton_thinEgg;
        private System.Windows.Forms.RadioButton radioButton_udon;
        private System.Windows.Forms.RadioButton radioButton_Hokien;
        private System.Windows.Forms.RadioButton radioButton_thickEgg;
        private System.Windows.Forms.RadioButton radioButton_wideFlatRice;
        private System.Windows.Forms.GroupBox groupBox_addMeat;
        private System.Windows.Forms.RadioButton radioButton_pork;
        private System.Windows.Forms.RadioButton radioButton_chicken;
        private System.Windows.Forms.RadioButton radioButton_beef;
        private System.Windows.Forms.RadioButton radioButton_seafood;
        private System.Windows.Forms.RadioButton radioButton_none;
        private System.Windows.Forms.Label label_chickenPrice;
        private System.Windows.Forms.Label label_seafoodPrice;
        private System.Windows.Forms.Label label_beefPrice;
        private System.Windows.Forms.Label label_porkPrice;
        private System.Windows.Forms.GroupBox groupBox_addVegetables;
        private System.Windows.Forms.CheckBox checkBox_capscicum;
        private System.Windows.Forms.CheckBox checkBox_broccoli;
        private System.Windows.Forms.CheckBox checkBox_carrot;
        private System.Windows.Forms.CheckBox checkBox_Onion;
        private System.Windows.Forms.CheckBox checkBox_greenBeans;
        private System.Windows.Forms.CheckBox checkBox_sprouts;
        private System.Windows.Forms.CheckBox checkBox_snowPeas;
        private System.Windows.Forms.CheckBox checkBox_bokChoy;
        private System.Windows.Forms.CheckBox checkBox_shallots;
        private System.Windows.Forms.CheckBox checkBox_cabbage;
        private System.Windows.Forms.Label label_addVegetablesTip;
        private System.Windows.Forms.Label label_chooseFlavour;
        private System.Windows.Forms.ComboBox comboBox_flavour;
        private System.Windows.Forms.Label label_yourName;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.CheckBox checkBox_bigServe;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label_orderText;
        private System.Windows.Forms.TextBox textBox_order;
        private System.Windows.Forms.GroupBox groupBox_currency;
        private System.Windows.Forms.RadioButton radioButton_usd;
        private System.Windows.Forms.RadioButton radioButton_aud;
    }
}

