namespace AppEjercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCONVERTIR = new System.Windows.Forms.Button();
            this.btnNUEVO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCELCIUS = new System.Windows.Forms.TextBox();
            this.txtFAHRENHEIT = new System.Windows.Forms.TextBox();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCONVERTIR
            // 
            this.btnCONVERTIR.Location = new System.Drawing.Point(12, 142);
            this.btnCONVERTIR.Name = "btnCONVERTIR";
            this.btnCONVERTIR.Size = new System.Drawing.Size(93, 23);
            this.btnCONVERTIR.TabIndex = 0;
            this.btnCONVERTIR.Text = "CONVERTIR";
            this.btnCONVERTIR.UseVisualStyleBackColor = true;
            this.btnCONVERTIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNUEVO
            // 
            this.btnNUEVO.Location = new System.Drawing.Point(148, 142);
            this.btnNUEVO.Name = "btnNUEVO";
            this.btnNUEVO.Size = new System.Drawing.Size(75, 23);
            this.btnNUEVO.TabIndex = 1;
            this.btnNUEVO.Text = "NUEVO";
            this.btnNUEVO.UseVisualStyleBackColor = true;
            this.btnNUEVO.Click += new System.EventHandler(this.btnNUEVO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRADOS  FAHRENHEIT °F     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GRADOS CELCIUS °C    :";
            // 
            // txtCELCIUS
            // 
            this.txtCELCIUS.Location = new System.Drawing.Point(191, 50);
            this.txtCELCIUS.Name = "txtCELCIUS";
            this.txtCELCIUS.Size = new System.Drawing.Size(136, 20);
            this.txtCELCIUS.TabIndex = 4;
            // 
            // txtFAHRENHEIT
            // 
            this.txtFAHRENHEIT.Enabled = false;
            this.txtFAHRENHEIT.Location = new System.Drawing.Point(191, 93);
            this.txtFAHRENHEIT.Name = "txtFAHRENHEIT";
            this.txtFAHRENHEIT.Size = new System.Drawing.Size(136, 20);
            this.txtFAHRENHEIT.TabIndex = 5;
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(266, 142);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(75, 23);
            this.btnSALIR.TabIndex = 6;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONVERTIDOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 191);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtFAHRENHEIT);
            this.Controls.Add(this.txtCELCIUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNUEVO);
            this.Controls.Add(this.btnCONVERTIR);
            this.Name = "Form1";
            this.Text = "CONVERTIDOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCONVERTIR;
        private System.Windows.Forms.Button btnNUEVO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCELCIUS;
        private System.Windows.Forms.TextBox txtFAHRENHEIT;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Label label3;
    }
}

