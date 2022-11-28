namespace Ex2_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.TrianglePerimeterNumeric = new System.Windows.Forms.NumericUpDown();
            this.CalculateAreaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrianglePerimeterNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите периметр равностроннего треугольника:";
            // 
            // TrianglePerimeterNumeric
            // 
            this.TrianglePerimeterNumeric.DecimalPlaces = 2;
            this.TrianglePerimeterNumeric.Location = new System.Drawing.Point(324, 20);
            this.TrianglePerimeterNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.TrianglePerimeterNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.TrianglePerimeterNumeric.Name = "TrianglePerimeterNumeric";
            this.TrianglePerimeterNumeric.Size = new System.Drawing.Size(120, 23);
            this.TrianglePerimeterNumeric.TabIndex = 1;
            this.TrianglePerimeterNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculateAreaButton
            // 
            this.CalculateAreaButton.Location = new System.Drawing.Point(153, 81);
            this.CalculateAreaButton.Name = "CalculateAreaButton";
            this.CalculateAreaButton.Size = new System.Drawing.Size(151, 34);
            this.CalculateAreaButton.TabIndex = 2;
            this.CalculateAreaButton.Text = "Вычислить площадь";
            this.CalculateAreaButton.UseVisualStyleBackColor = true;
            this.CalculateAreaButton.Click += new System.EventHandler(this.CalculateAreaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 143);
            this.Controls.Add(this.CalculateAreaButton);
            this.Controls.Add(this.TrianglePerimeterNumeric);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Башилов Неделя 1 Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.TrianglePerimeterNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown TrianglePerimeterNumeric;
        private Button CalculateAreaButton;
    }
}