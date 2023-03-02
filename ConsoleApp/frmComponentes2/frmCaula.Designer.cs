
namespace frmComponentes2
{
    partial class frmCaula
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butTon1 = new System.Windows.Forms.Button();
            this.buTton2 = new System.Windows.Forms.Button();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(352, 123);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(53, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero1:";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(411, 123);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(167, 20);
            this.txtBox1.TabIndex = 0;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(355, 205);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(53, 13);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Numero2:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 1;
            // 
            // butTon1
            // 
            this.butTon1.Location = new System.Drawing.Point(324, 292);
            this.butTon1.Name = "butTon1";
            this.butTon1.Size = new System.Drawing.Size(116, 57);
            this.butTon1.TabIndex = 2;
            this.butTon1.Text = "&Caulcular";
            this.butTon1.UseVisualStyleBackColor = true;
            // 
            // buTton2
            // 
            this.buTton2.Location = new System.Drawing.Point(494, 292);
            this.buTton2.Name = "buTton2";
            this.buTton2.Size = new System.Drawing.Size(118, 57);
            this.buTton2.TabIndex = 3;
            this.buTton2.Text = "&Limpar";
            this.buTton2.UseVisualStyleBackColor = true;
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.Location = new System.Drawing.Point(353, 385);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(67, 16);
            this.lblNum3.TabIndex = 6;
            this.lblNum3.Text = "Resposta";
            // 
            // lblNum4
            // 
            this.lblNum4.AutoSize = true;
            this.lblNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum4.Location = new System.Drawing.Point(523, 385);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(70, 16);
            this.lblNum4.TabIndex = 7;
            this.lblNum4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Caulculando valores";
            // 
            // frmCaula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.buTton2);
            this.Controls.Add(this.butTon1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblNum1);
            this.Name = "frmCaula";
            this.Text = "frmCaula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butTon1;
        private System.Windows.Forms.Button buTton2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label label5;
    }
}