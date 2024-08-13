namespace ProyectoFinalUwU
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.Valor1 = new System.Windows.Forms.MaskedTextBox();
            this.Valor2 = new System.Windows.Forms.MaskedTextBox();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblshowresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(624, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Literalmente la mejor calculadora de la fokin historia ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(104, 54);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(100, 20);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Primer valor";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(610, 54);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(115, 20);
            this.lblnum2.TabIndex = 2;
            this.lblnum2.Text = "Segundo valor";
            // 
            // Valor1
            // 
            this.Valor1.Location = new System.Drawing.Point(108, 112);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(105, 22);
            this.Valor1.TabIndex = 3;
            this.Valor1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(614, 112);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(111, 22);
            this.Valor2.TabIndex = 4;
            this.Valor2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // lbloperacion
            // 
            this.lbloperacion.AutoSize = true;
            this.lbloperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion.Location = new System.Drawing.Point(295, 153);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(262, 20);
            this.lbloperacion.TabIndex = 5;
            this.lbloperacion.Text = "Selecciona la operación a realizar";
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.SystemColors.Info;
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(128, 191);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 29);
            this.btnsuma.TabIndex = 6;
            this.btnsuma.Text = "Sumar";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.SystemColors.Info;
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(258, 191);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(97, 29);
            this.btnresta.TabIndex = 7;
            this.btnresta.Text = "Restar";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.SystemColors.Info;
            this.btnmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(410, 191);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(125, 29);
            this.btnmult.TabIndex = 8;
            this.btnmult.Text = "Multiplicar";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndividir
            // 
            this.btndividir.BackColor = System.Drawing.SystemColors.Info;
            this.btndividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(614, 191);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(95, 28);
            this.btndividir.TabIndex = 9;
            this.btndividir.Text = "Dividir";
            this.btndividir.UseVisualStyleBackColor = false;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(346, 251);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(84, 20);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "Resultado";
            // 
            // lblshowresult
            // 
            this.lblshowresult.AutoSize = true;
            this.lblshowresult.Location = new System.Drawing.Point(382, 295);
            this.lblshowresult.Name = "lblshowresult";
            this.lblshowresult.Size = new System.Drawing.Size(15, 16);
            this.lblshowresult.TabIndex = 11;
            this.lblshowresult.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblshowresult);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.lbloperacion);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.MaskedTextBox Valor1;
        private System.Windows.Forms.MaskedTextBox Valor2;
        private System.Windows.Forms.Label lbloperacion;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblshowresult;
    }
}

