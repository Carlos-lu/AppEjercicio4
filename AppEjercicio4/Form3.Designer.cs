namespace AppEjercicio4
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtvolumen = new System.Windows.Forms.TextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.btnNUEVO = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULAR AREA Y VOLUMEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RADIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ALTURA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AREA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VOLUMEN";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(105, 106);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(100, 20);
            this.txtradio.TabIndex = 5;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(105, 59);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 6;
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(241, 82);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 7;
            // 
            // txtvolumen
            // 
            this.txtvolumen.Enabled = false;
            this.txtvolumen.Location = new System.Drawing.Point(241, 129);
            this.txtvolumen.Name = "txtvolumen";
            this.txtvolumen.Size = new System.Drawing.Size(100, 20);
            this.txtvolumen.TabIndex = 8;
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Location = new System.Drawing.Point(12, 175);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(90, 26);
            this.btnCALCULAR.TabIndex = 9;
            this.btnCALCULAR.Text = "CALCULAR";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            this.btnCALCULAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNUEVO
            // 
            this.btnNUEVO.Location = new System.Drawing.Point(135, 175);
            this.btnNUEVO.Name = "btnNUEVO";
            this.btnNUEVO.Size = new System.Drawing.Size(97, 26);
            this.btnNUEVO.TabIndex = 10;
            this.btnNUEVO.Text = "NUEVO";
            this.btnNUEVO.UseVisualStyleBackColor = true;
            this.btnNUEVO.Click += new System.EventHandler(this.btnNUEVO_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(272, 175);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(95, 26);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 222);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnNUEVO);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.txtvolumen);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "CALCULAR AREA Y VOLUMEN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtvolumen;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Button btnNUEVO;
        private System.Windows.Forms.Button btnSALIR;
    }
}