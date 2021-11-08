
namespace HW4_5_Triangle
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
            this.TextAC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextCB = new System.Windows.Forms.TextBox();
            this.TextAB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckEquilateral = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.BPerimeter = new System.Windows.Forms.Button();
            this.BArea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BAngleA = new System.Windows.Forms.Button();
            this.BAngleC = new System.Windows.Forms.Button();
            this.BAngleB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAC
            // 
            this.TextAC.Location = new System.Drawing.Point(73, 132);
            this.TextAC.Name = "TextAC";
            this.TextAC.Size = new System.Drawing.Size(100, 20);
            this.TextAC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AC:";
            // 
            // TextCB
            // 
            this.TextCB.Location = new System.Drawing.Point(73, 210);
            this.TextCB.Name = "TextCB";
            this.TextCB.Size = new System.Drawing.Size(100, 20);
            this.TextCB.TabIndex = 2;
            // 
            // TextAB
            // 
            this.TextAB.Location = new System.Drawing.Point(73, 287);
            this.TextAB.Name = "TextAB";
            this.TextAB.Size = new System.Drawing.Size(100, 20);
            this.TextAB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AB:";
            // 
            // CheckEquilateral
            // 
            this.CheckEquilateral.AutoSize = true;
            this.CheckEquilateral.Location = new System.Drawing.Point(321, 132);
            this.CheckEquilateral.Name = "CheckEquilateral";
            this.CheckEquilateral.Size = new System.Drawing.Size(75, 17);
            this.CheckEquilateral.TabIndex = 6;
            this.CheckEquilateral.Text = "Equilateral";
            this.CheckEquilateral.UseVisualStyleBackColor = true;
            this.CheckEquilateral.Click += new System.EventHandler(this.CheckEquilateral_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result:";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(155, 393);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(188, 20);
            this.textResult.TabIndex = 8;
            // 
            // BPerimeter
            // 
            this.BPerimeter.Location = new System.Drawing.Point(73, 334);
            this.BPerimeter.Name = "BPerimeter";
            this.BPerimeter.Size = new System.Drawing.Size(100, 23);
            this.BPerimeter.TabIndex = 9;
            this.BPerimeter.Text = "Perimeter";
            this.BPerimeter.UseVisualStyleBackColor = true;
            this.BPerimeter.Click += new System.EventHandler(this.BPerimeter_Click);
            // 
            // BArea
            // 
            this.BArea.Enabled = false;
            this.BArea.Location = new System.Drawing.Point(321, 334);
            this.BArea.Name = "BArea";
            this.BArea.Size = new System.Drawing.Size(75, 23);
            this.BArea.TabIndex = 10;
            this.BArea.Text = "Area";
            this.BArea.UseVisualStyleBackColor = true;
            this.BArea.Click += new System.EventHandler(this.BArea_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "To find the perimeter of a triangle, enter all of its sides.\r\nNote that if the tr" +
    "iangle is equilateral, check the box, and the area will be available,\r\nbut some " +
    "functions will not make sense.\r\n";
            // 
            // BAngleA
            // 
            this.BAngleA.Location = new System.Drawing.Point(209, 184);
            this.BAngleA.Name = "BAngleA";
            this.BAngleA.Size = new System.Drawing.Size(75, 23);
            this.BAngleA.TabIndex = 12;
            this.BAngleA.Text = "Angle A";
            this.BAngleA.UseVisualStyleBackColor = true;
            this.BAngleA.Click += new System.EventHandler(this.BAngleA_Click);
            // 
            // BAngleC
            // 
            this.BAngleC.Location = new System.Drawing.Point(209, 261);
            this.BAngleC.Name = "BAngleC";
            this.BAngleC.Size = new System.Drawing.Size(75, 23);
            this.BAngleC.TabIndex = 13;
            this.BAngleC.Text = "Angle C";
            this.BAngleC.UseVisualStyleBackColor = true;
            this.BAngleC.Click += new System.EventHandler(this.BAngleC_Click);
            // 
            // BAngleB
            // 
            this.BAngleB.Location = new System.Drawing.Point(209, 333);
            this.BAngleB.Name = "BAngleB";
            this.BAngleB.Size = new System.Drawing.Size(75, 23);
            this.BAngleB.TabIndex = 14;
            this.BAngleB.Text = "Angle B";
            this.BAngleB.UseVisualStyleBackColor = true;
            this.BAngleB.Click += new System.EventHandler(this.BAngleB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 446);
            this.Controls.Add(this.BAngleB);
            this.Controls.Add(this.BAngleC);
            this.Controls.Add(this.BAngleA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BArea);
            this.Controls.Add(this.BPerimeter);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckEquilateral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextAB);
            this.Controls.Add(this.TextCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAC);
            this.Name = "Form1";
            this.Text = "Triang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextCB;
        private System.Windows.Forms.TextBox TextAB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckEquilateral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button BPerimeter;
        private System.Windows.Forms.Button BArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BAngleA;
        private System.Windows.Forms.Button BAngleC;
        private System.Windows.Forms.Button BAngleB;
    }
}

