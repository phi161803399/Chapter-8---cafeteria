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
            this.banana = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.btnAddFlapjacks = new System.Windows.Forms.Button();
            this.btnNextLumberjack = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.ListBox();
            this.lblNextInLine = new System.Windows.Forms.Label();
            this.nextInLine = new System.Windows.Forms.Label();
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
            this.btnAddLumberjack.Click += new System.EventHandler(this.btnAddLumberjack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.numFood);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.btnNextLumberjack);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.btnAddFlapjacks);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Location = new System.Drawing.Point(145, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 320);
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
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Checked = true;
            this.banana.Location = new System.Drawing.Point(6, 127);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 3;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(6, 104);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 2;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 81);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 1;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(6, 58);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 0;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // btnAddFlapjacks
            // 
            this.btnAddFlapjacks.Location = new System.Drawing.Point(6, 156);
            this.btnAddFlapjacks.Name = "btnAddFlapjacks";
            this.btnAddFlapjacks.Size = new System.Drawing.Size(124, 23);
            this.btnAddFlapjacks.TabIndex = 4;
            this.btnAddFlapjacks.Text = "Add flapjacks";
            this.btnAddFlapjacks.UseVisualStyleBackColor = true;
            this.btnAddFlapjacks.Click += new System.EventHandler(this.btnAddFlapjacks_Click);
            // 
            // btnNextLumberjack
            // 
            this.btnNextLumberjack.Location = new System.Drawing.Point(6, 271);
            this.btnNextLumberjack.Name = "btnNextLumberjack";
            this.btnNextLumberjack.Size = new System.Drawing.Size(124, 23);
            this.btnNextLumberjack.TabIndex = 6;
            this.btnNextLumberjack.Text = "Next lumberjack";
            this.btnNextLumberjack.UseVisualStyleBackColor = true;
            this.btnNextLumberjack.Click += new System.EventHandler(this.btnNextLumberjack_Click);
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(15, 104);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(124, 264);
            this.line.TabIndex = 7;
            // 
            // lblNextInLine
            // 
            this.lblNextInLine.AutoSize = true;
            this.lblNextInLine.Location = new System.Drawing.Point(12, 78);
            this.lblNextInLine.Name = "lblNextInLine";
            this.lblNextInLine.Size = new System.Drawing.Size(71, 13);
            this.lblNextInLine.TabIndex = 8;
            this.lblNextInLine.Text = "Breakfast line";
            // 
            // nextInLine
            // 
            this.nextInLine.AutoSize = true;
            this.nextInLine.Location = new System.Drawing.Point(6, 182);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(0, 13);
            this.nextInLine.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 448);
            this.Controls.Add(this.lblNextInLine);
            this.Controls.Add(this.line);
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
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.Button btnAddFlapjacks;
        private System.Windows.Forms.Button btnNextLumberjack;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label lblNextInLine;
        private System.Windows.Forms.Label nextInLine;
    }
}

