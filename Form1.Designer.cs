/*
 * Name : Samer Ali
 * NetID : U33047132
 */
namespace Project_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title21 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title22 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title23 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title24 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title25 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chart_Dice_One = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Textbox_Seed = new System.Windows.Forms.TextBox();
            this.Textbox_NumberOfRolls = new System.Windows.Forms.TextBox();
            this.Chart_Dice_Two = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_Dice_Sum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chart_Dice_Product = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_Coin_Tosses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_Toss = new System.Windows.Forms.Button();
            this.Button_Toss_Simulate = new System.Windows.Forms.Button();
            this.Textbox_Toss_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Draw_Card = new System.Windows.Forms.Button();
            this.Textbox_Draw_OneCard = new System.Windows.Forms.TextBox();
            this.Textbox_Number_Cards_Left = new System.Windows.Forms.TextBox();
            this.Label_CardsLeft_One = new System.Windows.Forms.Label();
            this.Label_OneCard_Result = new System.Windows.Forms.Label();
            this.Button_Draw_Hand = new System.Windows.Forms.Button();
            this.ComboBox_Hand = new System.Windows.Forms.ComboBox();
            this.Textbox_Hand_Amount = new System.Windows.Forms.TextBox();
            this.Label_HandSize = new System.Windows.Forms.Label();
            this.Label_CardsLeft_Hand = new System.Windows.Forms.Label();
            this.Textbox_Number_Cards_Left_Hand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_HeadsSelection = new System.Windows.Forms.Label();
            this.Textbox_HeadValue = new System.Windows.Forms.TextBox();
            this.Label_HEADS = new System.Windows.Forms.Label();
            this.Label_DICEROLL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_One)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_Two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Coin_Tosses)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Dice_One
            // 
            chartArea21.Name = "ChartArea1";
            this.Chart_Dice_One.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.Chart_Dice_One.Legends.Add(legend21);
            this.Chart_Dice_One.Location = new System.Drawing.Point(25, 453);
            this.Chart_Dice_One.Name = "Chart_Dice_One";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Rolls";
            this.Chart_Dice_One.Series.Add(series21);
            this.Chart_Dice_One.Size = new System.Drawing.Size(318, 233);
            this.Chart_Dice_One.TabIndex = 0;
            this.Chart_Dice_One.Text = "chart1";
            title21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title21.Name = "Title1";
            title21.Text = "Dice One";
            this.Chart_Dice_One.Titles.Add(title21);
            // 
            // Button_Start
            // 
            this.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start.Location = new System.Drawing.Point(162, 780);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 29);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Textbox_Seed
            // 
            this.Textbox_Seed.Location = new System.Drawing.Point(81, 761);
            this.Textbox_Seed.Name = "Textbox_Seed";
            this.Textbox_Seed.Size = new System.Drawing.Size(75, 22);
            this.Textbox_Seed.TabIndex = 2;
            // 
            // Textbox_NumberOfRolls
            // 
            this.Textbox_NumberOfRolls.Location = new System.Drawing.Point(81, 801);
            this.Textbox_NumberOfRolls.Name = "Textbox_NumberOfRolls";
            this.Textbox_NumberOfRolls.Size = new System.Drawing.Size(75, 22);
            this.Textbox_NumberOfRolls.TabIndex = 3;
            // 
            // Chart_Dice_Two
            // 
            chartArea22.Name = "ChartArea1";
            this.Chart_Dice_Two.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.Chart_Dice_Two.Legends.Add(legend22);
            this.Chart_Dice_Two.Location = new System.Drawing.Point(349, 453);
            this.Chart_Dice_Two.Name = "Chart_Dice_Two";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Rolls";
            this.Chart_Dice_Two.Series.Add(series22);
            this.Chart_Dice_Two.Size = new System.Drawing.Size(312, 233);
            this.Chart_Dice_Two.TabIndex = 4;
            this.Chart_Dice_Two.Text = "chart1";
            title22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title22.Name = "Title1";
            title22.Text = "Dice Two";
            this.Chart_Dice_Two.Titles.Add(title22);
            // 
            // Chart_Dice_Sum
            // 
            chartArea23.Name = "ChartArea1";
            this.Chart_Dice_Sum.ChartAreas.Add(chartArea23);
            legend23.Name = "Legend1";
            this.Chart_Dice_Sum.Legends.Add(legend23);
            this.Chart_Dice_Sum.Location = new System.Drawing.Point(25, 73);
            this.Chart_Dice_Sum.Name = "Chart_Dice_Sum";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Rolls";
            this.Chart_Dice_Sum.Series.Add(series23);
            this.Chart_Dice_Sum.Size = new System.Drawing.Size(379, 365);
            this.Chart_Dice_Sum.TabIndex = 5;
            this.Chart_Dice_Sum.Text = "chart1";
            title23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title23.Name = "Title1";
            title23.Text = "Summed Values";
            this.Chart_Dice_Sum.Titles.Add(title23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 801);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rolls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 764);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seed";
            // 
            // Chart_Dice_Product
            // 
            chartArea24.Name = "ChartArea1";
            this.Chart_Dice_Product.ChartAreas.Add(chartArea24);
            legend24.Name = "Legend1";
            this.Chart_Dice_Product.Legends.Add(legend24);
            this.Chart_Dice_Product.Location = new System.Drawing.Point(419, 73);
            this.Chart_Dice_Product.Name = "Chart_Dice_Product";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Rolls";
            this.Chart_Dice_Product.Series.Add(series24);
            this.Chart_Dice_Product.Size = new System.Drawing.Size(570, 365);
            this.Chart_Dice_Product.TabIndex = 8;
            this.Chart_Dice_Product.Text = "chart1";
            title24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title24.Name = "Title1";
            title24.Text = "Product Values";
            this.Chart_Dice_Product.Titles.Add(title24);
            // 
            // Chart_Coin_Tosses
            // 
            chartArea25.Name = "ChartArea1";
            this.Chart_Coin_Tosses.ChartAreas.Add(chartArea25);
            legend25.Name = "Legend1";
            this.Chart_Coin_Tosses.Legends.Add(legend25);
            this.Chart_Coin_Tosses.Location = new System.Drawing.Point(689, 453);
            this.Chart_Coin_Tosses.Name = "Chart_Coin_Tosses";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "Tosses";
            this.Chart_Coin_Tosses.Series.Add(series25);
            this.Chart_Coin_Tosses.Size = new System.Drawing.Size(300, 233);
            this.Chart_Coin_Tosses.TabIndex = 9;
            this.Chart_Coin_Tosses.Text = "chart1";
            title25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title25.Name = "Title1";
            title25.Text = "Coin Tosses";
            this.Chart_Coin_Tosses.Titles.Add(title25);
            // 
            // Button_Toss
            // 
            this.Button_Toss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Toss.Location = new System.Drawing.Point(432, 780);
            this.Button_Toss.Name = "Button_Toss";
            this.Button_Toss.Size = new System.Drawing.Size(80, 31);
            this.Button_Toss.TabIndex = 12;
            this.Button_Toss.Text = "Toss";
            this.Button_Toss.UseVisualStyleBackColor = true;
            this.Button_Toss.Click += new System.EventHandler(this.Button_Toss_Click);
            // 
            // Button_Toss_Simulate
            // 
            this.Button_Toss_Simulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Toss_Simulate.Location = new System.Drawing.Point(758, 780);
            this.Button_Toss_Simulate.Name = "Button_Toss_Simulate";
            this.Button_Toss_Simulate.Size = new System.Drawing.Size(126, 43);
            this.Button_Toss_Simulate.TabIndex = 13;
            this.Button_Toss_Simulate.Text = "Simulate";
            this.Button_Toss_Simulate.UseVisualStyleBackColor = true;
            this.Button_Toss_Simulate.Click += new System.EventHandler(this.Button_Toss_Simulate_Click);
            // 
            // Textbox_Toss_Result
            // 
            this.Textbox_Toss_Result.Location = new System.Drawing.Point(475, 752);
            this.Textbox_Toss_Result.Name = "Textbox_Toss_Result";
            this.Textbox_Toss_Result.Size = new System.Drawing.Size(80, 22);
            this.Textbox_Toss_Result.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 752);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Result";
            // 
            // Button_Draw_Card
            // 
            this.Button_Draw_Card.Location = new System.Drawing.Point(1073, 168);
            this.Button_Draw_Card.Name = "Button_Draw_Card";
            this.Button_Draw_Card.Size = new System.Drawing.Size(97, 23);
            this.Button_Draw_Card.TabIndex = 16;
            this.Button_Draw_Card.Text = "Draw Card";
            this.Button_Draw_Card.UseVisualStyleBackColor = true;
            this.Button_Draw_Card.Click += new System.EventHandler(this.Button_Draw_Card_Click);
            // 
            // Textbox_Draw_OneCard
            // 
            this.Textbox_Draw_OneCard.Location = new System.Drawing.Point(1138, 126);
            this.Textbox_Draw_OneCard.Name = "Textbox_Draw_OneCard";
            this.Textbox_Draw_OneCard.Size = new System.Drawing.Size(75, 22);
            this.Textbox_Draw_OneCard.TabIndex = 17;
            // 
            // Textbox_Number_Cards_Left
            // 
            this.Textbox_Number_Cards_Left.Location = new System.Drawing.Point(1138, 98);
            this.Textbox_Number_Cards_Left.Name = "Textbox_Number_Cards_Left";
            this.Textbox_Number_Cards_Left.Size = new System.Drawing.Size(75, 22);
            this.Textbox_Number_Cards_Left.TabIndex = 18;
            this.Textbox_Number_Cards_Left.Text = "52";
            // 
            // Label_CardsLeft_One
            // 
            this.Label_CardsLeft_One.AutoSize = true;
            this.Label_CardsLeft_One.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CardsLeft_One.Location = new System.Drawing.Point(995, 100);
            this.Label_CardsLeft_One.Name = "Label_CardsLeft_One";
            this.Label_CardsLeft_One.Size = new System.Drawing.Size(121, 20);
            this.Label_CardsLeft_One.TabIndex = 19;
            this.Label_CardsLeft_One.Text = "# of Cards Left";
            // 
            // Label_OneCard_Result
            // 
            this.Label_OneCard_Result.AutoSize = true;
            this.Label_OneCard_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OneCard_Result.Location = new System.Drawing.Point(1032, 128);
            this.Label_OneCard_Result.Name = "Label_OneCard_Result";
            this.Label_OneCard_Result.Size = new System.Drawing.Size(84, 20);
            this.Label_OneCard_Result.TabIndex = 20;
            this.Label_OneCard_Result.Text = "Your Card";
            // 
            // Button_Draw_Hand
            // 
            this.Button_Draw_Hand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Draw_Hand.Location = new System.Drawing.Point(1086, 500);
            this.Button_Draw_Hand.Name = "Button_Draw_Hand";
            this.Button_Draw_Hand.Size = new System.Drawing.Size(97, 29);
            this.Button_Draw_Hand.TabIndex = 21;
            this.Button_Draw_Hand.Text = "Draw Hand";
            this.Button_Draw_Hand.UseVisualStyleBackColor = true;
            this.Button_Draw_Hand.Click += new System.EventHandler(this.Button_Draw_Hand_Click);
            // 
            // ComboBox_Hand
            // 
            this.ComboBox_Hand.FormattingEnabled = true;
            this.ComboBox_Hand.Location = new System.Drawing.Point(1066, 535);
            this.ComboBox_Hand.Name = "ComboBox_Hand";
            this.ComboBox_Hand.Size = new System.Drawing.Size(147, 24);
            this.ComboBox_Hand.TabIndex = 22;
            this.ComboBox_Hand.Text = "View Cards Below";
            // 
            // Textbox_Hand_Amount
            // 
            this.Textbox_Hand_Amount.Location = new System.Drawing.Point(1167, 453);
            this.Textbox_Hand_Amount.Name = "Textbox_Hand_Amount";
            this.Textbox_Hand_Amount.Size = new System.Drawing.Size(75, 22);
            this.Textbox_Hand_Amount.TabIndex = 23;
            // 
            // Label_HandSize
            // 
            this.Label_HandSize.AutoSize = true;
            this.Label_HandSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HandSize.Location = new System.Drawing.Point(1009, 455);
            this.Label_HandSize.Name = "Label_HandSize";
            this.Label_HandSize.Size = new System.Drawing.Size(134, 20);
            this.Label_HandSize.TabIndex = 24;
            this.Label_HandSize.Text = "Insert Hand Size";
            // 
            // Label_CardsLeft_Hand
            // 
            this.Label_CardsLeft_Hand.AutoSize = true;
            this.Label_CardsLeft_Hand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CardsLeft_Hand.Location = new System.Drawing.Point(1022, 418);
            this.Label_CardsLeft_Hand.Name = "Label_CardsLeft_Hand";
            this.Label_CardsLeft_Hand.Size = new System.Drawing.Size(121, 20);
            this.Label_CardsLeft_Hand.TabIndex = 25;
            this.Label_CardsLeft_Hand.Text = "# of Cards Left";
            // 
            // Textbox_Number_Cards_Left_Hand
            // 
            this.Textbox_Number_Cards_Left_Hand.Location = new System.Drawing.Point(1167, 416);
            this.Textbox_Number_Cards_Left_Hand.Name = "Textbox_Number_Cards_Left_Hand";
            this.Textbox_Number_Cards_Left_Hand.Size = new System.Drawing.Size(75, 22);
            this.Textbox_Number_Cards_Left_Hand.TabIndex = 26;
            this.Textbox_Number_Cards_Left_Hand.Text = "52";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 709);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "COIN TOSS ";
            // 
            // Label_HeadsSelection
            // 
            this.Label_HeadsSelection.AutoSize = true;
            this.Label_HeadsSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeadsSelection.Location = new System.Drawing.Point(672, 709);
            this.Label_HeadsSelection.Name = "Label_HeadsSelection";
            this.Label_HeadsSelection.Size = new System.Drawing.Size(312, 20);
            this.Label_HeadsSelection.TabIndex = 28;
            this.Label_HeadsSelection.Text = "Please declare value of HEADS (1 or 0):";
            // 
            // Textbox_HeadValue
            // 
            this.Textbox_HeadValue.Location = new System.Drawing.Point(785, 744);
            this.Textbox_HeadValue.Name = "Textbox_HeadValue";
            this.Textbox_HeadValue.Size = new System.Drawing.Size(68, 22);
            this.Textbox_HeadValue.TabIndex = 29;
            // 
            // Label_HEADS
            // 
            this.Label_HEADS.AutoSize = true;
            this.Label_HEADS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HEADS.Location = new System.Drawing.Point(685, 746);
            this.Label_HEADS.Name = "Label_HEADS";
            this.Label_HEADS.Size = new System.Drawing.Size(83, 20);
            this.Label_HEADS.TabIndex = 30;
            this.Label_HEADS.Text = "HEADS =";
            // 
            // Label_DICEROLL
            // 
            this.Label_DICEROLL.AutoSize = true;
            this.Label_DICEROLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DICEROLL.Location = new System.Drawing.Point(86, 709);
            this.Label_DICEROLL.Name = "Label_DICEROLL";
            this.Label_DICEROLL.Size = new System.Drawing.Size(108, 20);
            this.Label_DICEROLL.TabIndex = 31;
            this.Label_DICEROLL.Text = "DICE ROLL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1032, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "DRAW ONE CARD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1062, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "DRAW HAND";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 892);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label_DICEROLL);
            this.Controls.Add(this.Label_HEADS);
            this.Controls.Add(this.Textbox_HeadValue);
            this.Controls.Add(this.Label_HeadsSelection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Textbox_Number_Cards_Left_Hand);
            this.Controls.Add(this.Label_CardsLeft_Hand);
            this.Controls.Add(this.Label_HandSize);
            this.Controls.Add(this.Textbox_Hand_Amount);
            this.Controls.Add(this.ComboBox_Hand);
            this.Controls.Add(this.Button_Draw_Hand);
            this.Controls.Add(this.Label_OneCard_Result);
            this.Controls.Add(this.Label_CardsLeft_One);
            this.Controls.Add(this.Textbox_Number_Cards_Left);
            this.Controls.Add(this.Textbox_Draw_OneCard);
            this.Controls.Add(this.Button_Draw_Card);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Textbox_Toss_Result);
            this.Controls.Add(this.Button_Toss_Simulate);
            this.Controls.Add(this.Button_Toss);
            this.Controls.Add(this.Chart_Coin_Tosses);
            this.Controls.Add(this.Chart_Dice_Product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart_Dice_Sum);
            this.Controls.Add(this.Chart_Dice_Two);
            this.Controls.Add(this.Textbox_NumberOfRolls);
            this.Controls.Add(this.Textbox_Seed);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Chart_Dice_One);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_One)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_Two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Dice_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Coin_Tosses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Dice_One;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.TextBox Textbox_Seed;
        private System.Windows.Forms.TextBox Textbox_NumberOfRolls;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Dice_Two;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Dice_Sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Dice_Product;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Coin_Tosses;
        private System.Windows.Forms.Button Button_Toss;
        private System.Windows.Forms.Button Button_Toss_Simulate;
        private System.Windows.Forms.TextBox Textbox_Toss_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Draw_Card;
        private System.Windows.Forms.TextBox Textbox_Draw_OneCard;
        private System.Windows.Forms.TextBox Textbox_Number_Cards_Left;
        private System.Windows.Forms.Label Label_CardsLeft_One;
        private System.Windows.Forms.Label Label_OneCard_Result;
        private System.Windows.Forms.Button Button_Draw_Hand;
        private System.Windows.Forms.ComboBox ComboBox_Hand;
        private System.Windows.Forms.TextBox Textbox_Hand_Amount;
        private System.Windows.Forms.Label Label_HandSize;
        private System.Windows.Forms.Label Label_CardsLeft_Hand;
        private System.Windows.Forms.TextBox Textbox_Number_Cards_Left_Hand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label_HeadsSelection;
        private System.Windows.Forms.TextBox Textbox_HeadValue;
        private System.Windows.Forms.Label Label_HEADS;
        private System.Windows.Forms.Label Label_DICEROLL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

