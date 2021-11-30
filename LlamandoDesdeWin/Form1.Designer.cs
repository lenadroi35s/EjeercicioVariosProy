namespace LlamandoDesdeWin
{
    partial class Form_Mostrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSUMA = new System.Windows.Forms.TextBox();
            this.txtFACTO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_enviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.facto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado 1, suma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado 2, factorial";
            // 
            // txtSUMA
            // 
            this.txtSUMA.Location = new System.Drawing.Point(271, 126);
            this.txtSUMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSUMA.Name = "txtSUMA";
            this.txtSUMA.Size = new System.Drawing.Size(163, 20);
            this.txtSUMA.TabIndex = 2;
            // 
            // txtFACTO
            // 
            this.txtFACTO.Location = new System.Drawing.Point(271, 205);
            this.txtFACTO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFACTO.Name = "txtFACTO";
            this.txtFACTO.Size = new System.Drawing.Size(163, 20);
            this.txtFACTO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "TAREA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bnt_enviar
            // 
            this.bnt_enviar.Location = new System.Drawing.Point(394, 271);
            this.bnt_enviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnt_enviar.Name = "bnt_enviar";
            this.bnt_enviar.Size = new System.Drawing.Size(140, 63);
            this.bnt_enviar.TabIndex = 5;
            this.bnt_enviar.Text = "Aceptar";
            this.bnt_enviar.UseVisualStyleBackColor = true;
            this.bnt_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese el 1er valor a sumar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ingrese el 2do valor a sumar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ingrese el factorial";
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(271, 58);
            this.sum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(76, 20);
            this.sum1.TabIndex = 9;
            // 
            // sum2
            // 
            this.sum2.Location = new System.Drawing.Point(271, 86);
            this.sum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(76, 20);
            this.sum2.TabIndex = 10;
            // 
            // facto
            // 
            this.facto.Location = new System.Drawing.Point(271, 165);
            this.facto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facto.Name = "facto";
            this.facto.Size = new System.Drawing.Size(76, 20);
            this.facto.TabIndex = 11;
            // 
            // Form_Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.facto);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bnt_enviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFACTO);
            this.Controls.Add(this.txtSUMA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Mostrar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSUMA;
        private System.Windows.Forms.TextBox txtFACTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_enviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.TextBox facto;
    }
}

