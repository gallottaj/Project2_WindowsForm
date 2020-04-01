namespace Project2
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
            this.choice1RadioButton = new System.Windows.Forms.RadioButton();
            this.choice2RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.choice3RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.sideSaladCheckBox = new System.Windows.Forms.CheckBox();
            this.entreeListBox = new System.Windows.Forms.ListBox();
            this.selectedEntreeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectedDrinkLabel = new System.Windows.Forms.Label();
            this.selectedSidesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxRadioButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // choice1RadioButton
            // 
            this.choice1RadioButton.AutoSize = true;
            this.choice1RadioButton.Location = new System.Drawing.Point(16, 19);
            this.choice1RadioButton.Name = "choice1RadioButton";
            this.choice1RadioButton.Size = new System.Drawing.Size(87, 17);
            this.choice1RadioButton.TabIndex = 0;
            this.choice1RadioButton.TabStop = true;
            this.choice1RadioButton.Text = "Cola (default)";
            this.choice1RadioButton.UseVisualStyleBackColor = true;
            this.choice1RadioButton.CheckedChanged += new System.EventHandler(this.choice1RadioButton_CheckedChanged);
            // 
            // choice2RadioButton
            // 
            this.choice2RadioButton.AutoSize = true;
            this.choice2RadioButton.Location = new System.Drawing.Point(16, 43);
            this.choice2RadioButton.Name = "choice2RadioButton";
            this.choice2RadioButton.Size = new System.Drawing.Size(73, 17);
            this.choice2RadioButton.TabIndex = 1;
            this.choice2RadioButton.TabStop = true;
            this.choice2RadioButton.Text = "Root Beer";
            this.choice2RadioButton.UseVisualStyleBackColor = true;
            this.choice2RadioButton.CheckedChanged += new System.EventHandler(this.choice2RadioButton_CheckedChanged);
            // 
            // groupBoxRadioButton
            // 
            this.groupBoxRadioButton.Controls.Add(this.choice3RadioButton);
            this.groupBoxRadioButton.Controls.Add(this.choice1RadioButton);
            this.groupBoxRadioButton.Controls.Add(this.choice2RadioButton);
            this.groupBoxRadioButton.Location = new System.Drawing.Point(51, 202);
            this.groupBoxRadioButton.Name = "groupBoxRadioButton";
            this.groupBoxRadioButton.Size = new System.Drawing.Size(200, 100);
            this.groupBoxRadioButton.TabIndex = 8;
            this.groupBoxRadioButton.TabStop = false;
            this.groupBoxRadioButton.Text = "Select a Drink:";
            this.groupBoxRadioButton.Enter += new System.EventHandler(this.groupBoxRadioButton_Enter);
            // 
            // choice3RadioButton
            // 
            this.choice3RadioButton.AutoSize = true;
            this.choice3RadioButton.Location = new System.Drawing.Point(16, 67);
            this.choice3RadioButton.Name = "choice3RadioButton";
            this.choice3RadioButton.Size = new System.Drawing.Size(74, 17);
            this.choice3RadioButton.TabIndex = 2;
            this.choice3RadioButton.TabStop = true;
            this.choice3RadioButton.Text = "Ginger Ale";
            this.choice3RadioButton.UseVisualStyleBackColor = true;
            this.choice3RadioButton.CheckedChanged += new System.EventHandler(this.choice3RadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sideSaladCheckBox);
            this.groupBox1.Controls.Add(this.frenchFriesCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(294, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Side (up to 2):";
            // 
            // frenchFriesCheckBox
            // 
            this.frenchFriesCheckBox.AutoSize = true;
            this.frenchFriesCheckBox.Location = new System.Drawing.Point(16, 27);
            this.frenchFriesCheckBox.Name = "frenchFriesCheckBox";
            this.frenchFriesCheckBox.Size = new System.Drawing.Size(84, 17);
            this.frenchFriesCheckBox.TabIndex = 10;
            this.frenchFriesCheckBox.Text = "French Fries";
            this.frenchFriesCheckBox.UseVisualStyleBackColor = true;
            this.frenchFriesCheckBox.CheckedChanged += new System.EventHandler(this.frenchFriesCheckBox_CheckedChanged);
            // 
            // sideSaladCheckBox
            // 
            this.sideSaladCheckBox.AutoSize = true;
            this.sideSaladCheckBox.Location = new System.Drawing.Point(16, 54);
            this.sideSaladCheckBox.Name = "sideSaladCheckBox";
            this.sideSaladCheckBox.Size = new System.Drawing.Size(77, 17);
            this.sideSaladCheckBox.TabIndex = 11;
            this.sideSaladCheckBox.Text = "Side Salad";
            this.sideSaladCheckBox.UseVisualStyleBackColor = true;
            // 
            // entreeListBox
            // 
            this.entreeListBox.FormattingEnabled = true;
            this.entreeListBox.Items.AddRange(new object[] {
            "Steak",
            "Meatloaf",
            "Roast Beef",
            "Shrimp",
            "Pork Chop",
            "Ribs"});
            this.entreeListBox.Location = new System.Drawing.Point(54, 78);
            this.entreeListBox.Name = "entreeListBox";
            this.entreeListBox.Size = new System.Drawing.Size(200, 82);
            this.entreeListBox.TabIndex = 10;
            this.entreeListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // selectedEntreeLabel
            // 
            this.selectedEntreeLabel.AutoSize = true;
            this.selectedEntreeLabel.Location = new System.Drawing.Point(74, 23);
            this.selectedEntreeLabel.Name = "selectedEntreeLabel";
            this.selectedEntreeLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedEntreeLabel.TabIndex = 11;
            this.selectedEntreeLabel.Click += new System.EventHandler(this.listBoxSelection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.selectedSidesLabel);
            this.groupBox2.Controls.Add(this.selectedDrinkLabel);
            this.groupBox2.Controls.Add(this.selectedEntreeLabel);
            this.groupBox2.Location = new System.Drawing.Point(294, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Selections:";
            // 
            // selectedDrinkLabel
            // 
            this.selectedDrinkLabel.AutoSize = true;
            this.selectedDrinkLabel.Location = new System.Drawing.Point(74, 47);
            this.selectedDrinkLabel.Name = "selectedDrinkLabel";
            this.selectedDrinkLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedDrinkLabel.TabIndex = 12;
            // 
            // selectedSidesLabel
            // 
            this.selectedSidesLabel.AutoSize = true;
            this.selectedSidesLabel.Location = new System.Drawing.Point(74, 69);
            this.selectedSidesLabel.Name = "selectedSidesLabel";
            this.selectedSidesLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedSidesLabel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select an Entree:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(284, 335);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Entree:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Drink:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Side(s):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 422);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entreeListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRadioButton);
            this.Name = "Form1";
            this.Text = "Create Food Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRadioButton.ResumeLayout(false);
            this.groupBoxRadioButton.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choice1RadioButton;
        private System.Windows.Forms.RadioButton choice2RadioButton;
        private System.Windows.Forms.GroupBox groupBoxRadioButton;
        private System.Windows.Forms.RadioButton choice3RadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sideSaladCheckBox;
        private System.Windows.Forms.CheckBox frenchFriesCheckBox;
        private System.Windows.Forms.ListBox entreeListBox;
        private System.Windows.Forms.Label selectedEntreeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label selectedSidesLabel;
        private System.Windows.Forms.Label selectedDrinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

