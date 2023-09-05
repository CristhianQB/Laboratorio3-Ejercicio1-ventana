namespace Laboratorio3_Ejercicio1_ventana
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            txtb3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtb2 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de fruta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 179);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Distancia";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(250, 58);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(52, 23);
            txtb1.TabIndex = 2;
            // 
            // txtb3
            // 
            txtb3.Location = new System.Drawing.Point(135, 176);
            txtb3.Name = "txtb3";
            txtb3.Size = new System.Drawing.Size(139, 23);
            txtb3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(63, 265);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 28);
            label3.TabIndex = 4;
            label3.Text = "Total";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(171, 265);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(62, 37);
            lbl.TabIndex = 5;
            lbl.Text = "000";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(97, 326);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 49);
            button1.TabIndex = 6;
            button1.Text = "total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(254, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "(1)Fresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(171, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "(0)Naranja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(321, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 15);
            label6.TabIndex = 9;
            label6.Text = "(2)Mango";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(43, 117);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 15);
            label7.TabIndex = 10;
            label7.Text = "Cantidad de cajas";
            // 
            // txtb2
            // 
            txtb2.Location = new System.Drawing.Point(171, 117);
            txtb2.Name = "txtb2";
            txtb2.Size = new System.Drawing.Size(62, 23);
            txtb2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(473, 450);
            Controls.Add(txtb2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(lbl);
            Controls.Add(label3);
            Controls.Add(txtb3);
            Controls.Add(txtb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb2;
    }
}
