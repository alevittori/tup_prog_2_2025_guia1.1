namespace Ejercicio1
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalularCosto = new System.Windows.Forms.Button();
            this.tb_vidaUtil = new System.Windows.Forms.TextBox();
            this.tb_tasaDepre = new System.Windows.Forms.TextBox();
            this.tb_valorFabrica = new System.Windows.Forms.TextBox();
            this.tb_anoCalcular = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(426, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 56);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalularCosto
            // 
            this.btnCalularCosto.Location = new System.Drawing.Point(47, 212);
            this.btnCalularCosto.Name = "btnCalularCosto";
            this.btnCalularCosto.Size = new System.Drawing.Size(112, 56);
            this.btnCalularCosto.TabIndex = 26;
            this.btnCalularCosto.Text = "Calcular Costo";
            this.btnCalularCosto.UseVisualStyleBackColor = true;
            this.btnCalularCosto.Click += new System.EventHandler(this.btnCalularCosto_Click);
            // 
            // tb_vidaUtil
            // 
            this.tb_vidaUtil.Location = new System.Drawing.Point(438, 63);
            this.tb_vidaUtil.Name = "tb_vidaUtil";
            this.tb_vidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tb_vidaUtil.TabIndex = 25;
            // 
            // tb_tasaDepre
            // 
            this.tb_tasaDepre.Location = new System.Drawing.Point(438, 30);
            this.tb_tasaDepre.Name = "tb_tasaDepre";
            this.tb_tasaDepre.Size = new System.Drawing.Size(100, 20);
            this.tb_tasaDepre.TabIndex = 24;
            // 
            // tb_valorFabrica
            // 
            this.tb_valorFabrica.Location = new System.Drawing.Point(143, 150);
            this.tb_valorFabrica.Name = "tb_valorFabrica";
            this.tb_valorFabrica.Size = new System.Drawing.Size(100, 20);
            this.tb_valorFabrica.TabIndex = 23;
            // 
            // tb_anoCalcular
            // 
            this.tb_anoCalcular.Location = new System.Drawing.Point(143, 111);
            this.tb_anoCalcular.Name = "tb_anoCalcular";
            this.tb_anoCalcular.Size = new System.Drawing.Size(100, 20);
            this.tb_anoCalcular.TabIndex = 22;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(143, 69);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(100, 20);
            this.tb_modelo.TabIndex = 21;
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(143, 30);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(100, 20);
            this.tb_marca.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tasa de depreciacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vida Util ( años ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor Fabricacion $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Año a calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modelo ( Año )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalularCosto);
            this.Controls.Add(this.tb_vidaUtil);
            this.Controls.Add(this.tb_tasaDepre);
            this.Controls.Add(this.tb_valorFabrica);
            this.Controls.Add(this.tb_anoCalcular);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasacion de motos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalularCosto;
        private System.Windows.Forms.TextBox tb_vidaUtil;
        private System.Windows.Forms.TextBox tb_tasaDepre;
        private System.Windows.Forms.TextBox tb_valorFabrica;
        private System.Windows.Forms.TextBox tb_anoCalcular;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

