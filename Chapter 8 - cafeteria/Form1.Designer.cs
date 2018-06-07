namespace Chapter_8___cafeteria
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddLumberjack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numFood = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnAddFlapjacks = new System.Windows.Forms.Button();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.btnNextLumberjack = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.ListBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Lumberjack name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAddLumberjack
            // 
            this.btnAddLumberjack.Location = new System.Drawing.Point(12, 38);
            this.btnAddLumberjack.Name = "btnAddLumberjack";
            this.btnAddLumberjack.Size = new System.Drawing.Size(257, 23);
            this.btnAddLumberjack.TabIndex = 2;
            this.btnAddLumberjack.Text = "Add lumberjack";
            this.btnAddLumberjack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numFood);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(145, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed lumberjack";
            // 
            // numFood
            // 
            this.numFood.Location = new System.Drawing.Point(6, 19);
            this.numFood.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFood.Name = "numFood";
            this.numFood.Size = new System.Drawing.Size(51, 20);
            this.numFood.TabIndex = 4;
            this.numFood.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Crispy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Soggy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 104);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Browned";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 127);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Banana";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnAddFlapjacks
            // 
            this.btnAddFlapjacks.Location = new System.Drawing.Point(145, 234);
            this.btnAddFlapjacks.Name = "btnAddFlapjacks";
            this.btnAddFlapjacks.Size = new System.Drawing.Size(124, 23);
            this.btnAddFlapjacks.TabIndex = 4;
            this.btnAddFlapjacks.Text = "Add flapjacks";
            this.btnAddFlapjacks.UseVisualStyleBackColor = true;
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(145, 263);
            this.txtOrders.Multiline = true;
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(124, 80);
            this.txtOrders.TabIndex = 5;
            // 
            // btnNextLumberjack
            // 
            this.btnNextLumberjack.Location = new System.Drawing.Point(145, 350);
            this.btnNextLumberjack.Name = "btnNextLumberjack";
            this.btnNextLumberjack.Size = new System.Drawing.Size(124, 23);
            this.btnNextLumberjack.TabIndex = 6;
            this.btnNextLumberjack.Text = "Next lumberjack";
            this.btnNextLumberjack.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(15, 104);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(124, 264);
            this.line.TabIndex = 7;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(12, 78);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(71, 13);
            this.lblLine.TabIndex = 8;
            this.lblLine.Text = "Breakfast line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 390);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btnNextLumberjack);
            this.Controls.Add(this.txtOrders);
            this.Controls.Add(this.btnAddFlapjacks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddLumberjack);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddLumberjack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numFood;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnAddFlapjacks;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Button btnNextLumberjack;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label lblLine;
    }
}

