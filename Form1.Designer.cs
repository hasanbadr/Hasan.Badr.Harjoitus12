namespace Hasan.Badr.Harjoitus12
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
            kysymysLB = new Label();
            VastausLB = new Label();
            groupBox1 = new GroupBox();
            VastausDRB = new RadioButton();
            VastausCRB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausARB = new RadioButton();
            DummyRB = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // kysymysLB
            // 
            kysymysLB.AutoSize = true;
            kysymysLB.Location = new Point(30, 31);
            kysymysLB.Name = "kysymysLB";
            kysymysLB.Size = new Size(236, 30);
            kysymysLB.TabIndex = 0;
            kysymysLB.Text = "Vasraus 1. kysymykseen:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(30, 208);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(83, 30);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(VastausDRB);
            groupBox1.Controls.Add(VastausCRB);
            groupBox1.Controls.Add(VastausBRB);
            groupBox1.Controls.Add(VastausARB);
            groupBox1.Controls.Add(DummyRB);
            groupBox1.Location = new Point(275, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(100, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "vastaus";
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(9, 154);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(46, 34);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(9, 123);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(44, 34);
            VastausCRB.TabIndex = 3;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(9, 83);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(43, 34);
            VastausBRB.TabIndex = 2;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(9, 43);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(45, 34);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            DummyRB.AutoCheck = false;
            DummyRB.AutoSize = true;
            DummyRB.Location = new Point(9, 43);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(42, 34);
            DummyRB.TabIndex = 0;
            DummyRB.TabStop = true;
            DummyRB.Text = "E";
            DummyRB.UseVisualStyleBackColor = true;
            DummyRB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 258);
            Controls.Add(groupBox1);
            Controls.Add(VastausLB);
            Controls.Add(kysymysLB);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton VastausCRB;
        private RadioButton VastausBRB;
        private RadioButton VastausARB;
        private RadioButton DummyRB;
        private RadioButton VastausDRB;
    }
}