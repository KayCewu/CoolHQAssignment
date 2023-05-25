namespace CoolHQAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdBlackCar = new RadioButton();
            rdWhiteCar = new RadioButton();
            rdBlackMini = new RadioButton();
            rdWhiteMini = new RadioButton();
            btnOrder = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCarQ = new Label();
            lblMinibusQ = new Label();
            label5 = new Label();
            label6 = new Label();
            lblMinibusLine = new Label();
            label8 = new Label();
            lblSpraybooth = new Label();
            lblCarLine = new Label();
            SuspendLayout();
            // 
            // rdBlackCar
            // 
            rdBlackCar.AutoSize = true;
            rdBlackCar.Location = new Point(8, 10);
            rdBlackCar.Margin = new Padding(2, 2, 2, 2);
            rdBlackCar.Name = "rdBlackCar";
            rdBlackCar.Size = new Size(104, 19);
            rdBlackCar.TabIndex = 0;
            rdBlackCar.TabStop = true;
            rdBlackCar.Text = "Black LUX 1000";
            rdBlackCar.UseVisualStyleBackColor = true;
            // 
            // rdWhiteCar
            // 
            rdWhiteCar.AutoSize = true;
            rdWhiteCar.Location = new Point(8, 31);
            rdWhiteCar.Margin = new Padding(2, 2, 2, 2);
            rdWhiteCar.Name = "rdWhiteCar";
            rdWhiteCar.Size = new Size(107, 19);
            rdWhiteCar.TabIndex = 1;
            rdWhiteCar.TabStop = true;
            rdWhiteCar.Text = "White LUX 1000";
            rdWhiteCar.UseVisualStyleBackColor = true;
            // 
            // rdBlackMini
            // 
            rdBlackMini.AutoSize = true;
            rdBlackMini.Location = new Point(8, 52);
            rdBlackMini.Margin = new Padding(2, 2, 2, 2);
            rdBlackMini.Name = "rdBlackMini";
            rdBlackMini.Size = new Size(92, 19);
            rdBlackMini.TabIndex = 2;
            rdBlackMini.TabStop = true;
            rdBlackMini.Text = "Black MV500";
            rdBlackMini.UseVisualStyleBackColor = true;
            // 
            // rdWhiteMini
            // 
            rdWhiteMini.AutoSize = true;
            rdWhiteMini.Location = new Point(8, 73);
            rdWhiteMini.Margin = new Padding(2, 2, 2, 2);
            rdWhiteMini.Name = "rdWhiteMini";
            rdWhiteMini.Size = new Size(95, 19);
            rdWhiteMini.TabIndex = 3;
            rdWhiteMini.TabStop = true;
            rdWhiteMini.Text = "White MV500";
            rdWhiteMini.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(8, 106);
            btnOrder.Margin = new Padding(2, 2, 2, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(99, 40);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "CAR QUEUE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "MINIBUS QUEUE:";
            // 
            // lblCarQ
            // 
            lblCarQ.AutoSize = true;
            lblCarQ.Location = new Point(188, 35);
            lblCarQ.Margin = new Padding(2, 0, 2, 0);
            lblCarQ.Name = "lblCarQ";
            lblCarQ.Size = new Size(38, 15);
            lblCarQ.TabIndex = 7;
            lblCarQ.Text = "label3";
            // 
            // lblMinibusQ
            // 
            lblMinibusQ.AutoSize = true;
            lblMinibusQ.Location = new Point(418, 35);
            lblMinibusQ.Margin = new Padding(2, 0, 2, 0);
            lblMinibusQ.Name = "lblMinibusQ";
            lblMinibusQ.Size = new Size(38, 15);
            lblMinibusQ.TabIndex = 8;
            lblMinibusQ.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 101);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 9;
            label5.Text = "Car Assembly Line:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 149);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 10;
            label6.Text = "Minibus Assembly Line:";
            // 
            // lblMinibusLine
            // 
            lblMinibusLine.AutoSize = true;
            lblMinibusLine.Location = new Point(260, 172);
            lblMinibusLine.Margin = new Padding(2, 0, 2, 0);
            lblMinibusLine.Name = "lblMinibusLine";
            lblMinibusLine.Size = new Size(38, 15);
            lblMinibusLine.TabIndex = 11;
            lblMinibusLine.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 198);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 12;
            label8.Text = "Spraybooth:";
            // 
            // lblSpraybooth
            // 
            lblSpraybooth.AutoSize = true;
            lblSpraybooth.Location = new Point(260, 223);
            lblSpraybooth.Margin = new Padding(2, 0, 2, 0);
            lblSpraybooth.Name = "lblSpraybooth";
            lblSpraybooth.Size = new Size(38, 15);
            lblSpraybooth.TabIndex = 13;
            lblSpraybooth.Text = "label9";
            // 
            // lblCarLine
            // 
            lblCarLine.AutoSize = true;
            lblCarLine.Location = new Point(260, 124);
            lblCarLine.Margin = new Padding(2, 0, 2, 0);
            lblCarLine.Name = "lblCarLine";
            lblCarLine.Size = new Size(44, 15);
            lblCarLine.TabIndex = 14;
            lblCarLine.Text = "label10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblCarLine);
            Controls.Add(lblSpraybooth);
            Controls.Add(label8);
            Controls.Add(lblMinibusLine);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblMinibusQ);
            Controls.Add(lblCarQ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOrder);
            Controls.Add(rdWhiteMini);
            Controls.Add(rdBlackMini);
            Controls.Add(rdWhiteCar);
            Controls.Add(rdBlackCar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdBlackCar;
        private RadioButton rdWhiteCar;
        private RadioButton rdBlackMini;
        private RadioButton rdWhiteMini;
        private Button btnOrder;
        private Label label1;
        private Label label2;
        private Label lblCarQ;
        private Label lblMinibusQ;
        private Label label5;
        private Label label6;
        private Label lblMinibusLine;
        private Label label8;
        private Label lblSpraybooth;
        private Label lblCarLine;
    }
}