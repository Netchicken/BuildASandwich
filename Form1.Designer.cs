﻿namespace BuildASandwich
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbGouda = new RadioButton();
            rbMozzarella = new RadioButton();
            rbFeta = new RadioButton();
            groupBox2 = new GroupBox();
            rbItalian = new RadioButton();
            rbWhite = new RadioButton();
            rbWholemeal = new RadioButton();
            cbxOlives = new CheckBox();
            cbxTomato = new CheckBox();
            cbxLettuce = new CheckBox();
            cbxCarrot = new CheckBox();
            lblCheese = new Label();
            lblTopping = new Label();
            lblBread = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Build your Sandwich";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbGouda);
            groupBox1.Controls.Add(rbMozzarella);
            groupBox1.Controls.Add(rbFeta);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(35, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(97, 104);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cheese";
            // 
            // rbGouda
            // 
            rbGouda.AutoSize = true;
            rbGouda.Location = new Point(6, 79);
            rbGouda.Name = "rbGouda";
            rbGouda.Size = new Size(61, 19);
            rbGouda.TabIndex = 2;
            rbGouda.TabStop = true;
            rbGouda.Text = "Gouda";
            rbGouda.UseVisualStyleBackColor = true;
            rbGouda.CheckedChanged += rbGouda_CheckedChanged;
            // 
            // rbMozzarella
            // 
            rbMozzarella.AutoSize = true;
            rbMozzarella.Location = new Point(6, 54);
            rbMozzarella.Name = "rbMozzarella";
            rbMozzarella.Size = new Size(85, 19);
            rbMozzarella.TabIndex = 1;
            rbMozzarella.TabStop = true;
            rbMozzarella.Text = "Mozzarella";
            rbMozzarella.UseVisualStyleBackColor = true;
            rbMozzarella.CheckedChanged += rbMozzarella_CheckedChanged;
            // 
            // rbFeta
            // 
            rbFeta.AutoSize = true;
            rbFeta.Location = new Point(6, 29);
            rbFeta.Name = "rbFeta";
            rbFeta.Size = new Size(49, 19);
            rbFeta.TabIndex = 0;
            rbFeta.TabStop = true;
            rbFeta.Text = "Feta";
            rbFeta.UseVisualStyleBackColor = true;
            rbFeta.CheckedChanged += rbFeta_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbItalian);
            groupBox2.Controls.Add(rbWhite);
            groupBox2.Controls.Add(rbWholemeal);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(156, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(97, 104);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bread";
            // 
            // rbItalian
            // 
            rbItalian.AutoSize = true;
            rbItalian.Location = new Point(6, 79);
            rbItalian.Name = "rbItalian";
            rbItalian.Size = new Size(59, 19);
            rbItalian.TabIndex = 2;
            rbItalian.TabStop = true;
            rbItalian.Text = "Italian";
            rbItalian.UseVisualStyleBackColor = true;
            rbItalian.CheckedChanged += rbItalian_CheckedChanged;
            // 
            // rbWhite
            // 
            rbWhite.AutoSize = true;
            rbWhite.Location = new Point(6, 54);
            rbWhite.Name = "rbWhite";
            rbWhite.Size = new Size(59, 19);
            rbWhite.TabIndex = 1;
            rbWhite.TabStop = true;
            rbWhite.Text = "White";
            rbWhite.UseVisualStyleBackColor = true;
            rbWhite.CheckedChanged += rbWhite_CheckedChanged;
            // 
            // rbWholemeal
            // 
            rbWholemeal.AutoSize = true;
            rbWholemeal.Location = new Point(6, 29);
            rbWholemeal.Name = "rbWholemeal";
            rbWholemeal.Size = new Size(88, 19);
            rbWholemeal.TabIndex = 0;
            rbWholemeal.TabStop = true;
            rbWholemeal.Text = "Wholemeal";
            rbWholemeal.UseVisualStyleBackColor = true;
            rbWholemeal.CheckedChanged += rbWholemeal_CheckedChanged;
            // 
            // cbxOlives
            // 
            cbxOlives.AutoSize = true;
            cbxOlives.Location = new Point(40, 195);
            cbxOlives.Name = "cbxOlives";
            cbxOlives.Size = new Size(58, 19);
            cbxOlives.TabIndex = 4;
            cbxOlives.Text = "Olives";
            cbxOlives.UseVisualStyleBackColor = true;
            cbxOlives.CheckedChanged += cbxOlives_CheckedChanged;
            // 
            // cbxTomato
            // 
            cbxTomato.AutoSize = true;
            cbxTomato.Location = new Point(40, 270);
            cbxTomato.Name = "cbxTomato";
            cbxTomato.Size = new Size(67, 19);
            cbxTomato.TabIndex = 5;
            cbxTomato.Text = "Tomato";
            cbxTomato.UseVisualStyleBackColor = true;
            cbxTomato.CheckedChanged += cbxTomato_CheckedChanged;
            // 
            // cbxLettuce
            // 
            cbxLettuce.AutoSize = true;
            cbxLettuce.Location = new Point(40, 245);
            cbxLettuce.Name = "cbxLettuce";
            cbxLettuce.Size = new Size(65, 19);
            cbxLettuce.TabIndex = 6;
            cbxLettuce.Text = "Lettuce";
            cbxLettuce.TextAlign = ContentAlignment.MiddleCenter;
            cbxLettuce.UseVisualStyleBackColor = true;
            cbxLettuce.CheckedChanged += cbxLettuce_CheckedChanged;
            // 
            // cbxCarrot
            // 
            cbxCarrot.AutoSize = true;
            cbxCarrot.Location = new Point(41, 220);
            cbxCarrot.Name = "cbxCarrot";
            cbxCarrot.Size = new Size(59, 19);
            cbxCarrot.TabIndex = 7;
            cbxCarrot.Text = "Carrot";
            cbxCarrot.UseVisualStyleBackColor = true;
            cbxCarrot.CheckedChanged += cbxCarrot_CheckedChanged;
            // 
            // lblCheese
            // 
            lblCheese.BackColor = Color.LightBlue;
            lblCheese.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCheese.Location = new Point(145, 194);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(163, 25);
            lblCheese.TabIndex = 9;
            // 
            // lblTopping
            // 
            lblTopping.BackColor = Color.LightBlue;
            lblTopping.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTopping.Location = new Point(143, 263);
            lblTopping.Name = "lblTopping";
            lblTopping.Size = new Size(163, 51);
            lblTopping.TabIndex = 10;
            // 
            // lblBread
            // 
            lblBread.BackColor = Color.LightBlue;
            lblBread.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBread.Location = new Point(143, 228);
            lblBread.Name = "lblBread";
            lblBread.Size = new Size(163, 25);
            lblBread.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 323);
            Controls.Add(lblBread);
            Controls.Add(lblTopping);
            Controls.Add(lblCheese);
            Controls.Add(cbxCarrot);
            Controls.Add(cbxLettuce);
            Controls.Add(cbxTomato);
            Controls.Add(cbxOlives);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbGouda;
        private RadioButton rbMozzarella;
        private RadioButton rbFeta;
        private GroupBox groupBox2;
        private RadioButton rbItalian;
        private RadioButton rbWhite;
        private RadioButton rbWholemeal;
        private CheckBox cbxOlives;
        private CheckBox cbxTomato;
        private CheckBox cbxLettuce;
        private CheckBox cbxCarrot;
        private Label lblCheese;
        private Label lblTopping;
        private Label lblBread;
    }
}
