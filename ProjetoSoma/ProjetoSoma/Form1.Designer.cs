namespace ProjetoSoma
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.txbSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(28, 28);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // txbPrimeiroNumero
            // 
            this.txbPrimeiroNumero.Location = new System.Drawing.Point(28, 44);
            this.txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            this.txbPrimeiroNumero.Size = new System.Drawing.Size(188, 20);
            this.txbPrimeiroNumero.TabIndex = 1;
            // 
            // txbSegundoNumero
            // 
            this.txbSegundoNumero.Location = new System.Drawing.Point(28, 104);
            this.txbSegundoNumero.Name = "txbSegundoNumero";
            this.txbSegundoNumero.Size = new System.Drawing.Size(188, 20);
            this.txbSegundoNumero.TabIndex = 3;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(28, 88);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(31, 142);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.toolTip1.SetToolTip(this.btnSomar, "Clique neste botão para somar ");
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 216);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 5;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(141, 142);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.toolTip1.SetToolTip(this.btnSubtrair, "Clique neste botão para somar ");
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(31, 171);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "Multiplicar";
            this.toolTip1.SetToolTip(this.btnMultiplicar, "Clique neste botão para somar ");
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(141, 171);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "Dividir";
            this.toolTip1.SetToolTip(this.btnDividir, "Clique neste botão para somar ");
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(253, 239);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txbSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txbPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Name = "frmPrincipal";
            this.Text = "Somar dois números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txbPrimeiroNumero;
        private System.Windows.Forms.TextBox txbSegundoNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;

    }
}

