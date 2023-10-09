namespace EntidadFinancieraForm
{
    partial class FormTarjeta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            txtLimite = new TextBox();
            txtMonto = new TextBox();
            buttonEmitir = new Button();
            buttonPausar = new Button();
            buttonPagar = new Button();
            buttonResumen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de tarjeta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Limite de credito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto de pago";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(121, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(180, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(121, 74);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(180, 23);
            txtLimite.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(121, 114);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 23);
            txtMonto.TabIndex = 7;
            // 
            // buttonEmitir
            // 
            buttonEmitir.Location = new Point(12, 166);
            buttonEmitir.Name = "buttonEmitir";
            buttonEmitir.Size = new Size(75, 23);
            buttonEmitir.TabIndex = 9;
            buttonEmitir.Text = "Emitir";
            buttonEmitir.UseVisualStyleBackColor = true;
            buttonEmitir.Click += buttonEmitir_Click;
            // 
            // buttonPausar
            // 
            buttonPausar.Location = new Point(134, 166);
            buttonPausar.Name = "buttonPausar";
            buttonPausar.Size = new Size(75, 23);
            buttonPausar.TabIndex = 10;
            buttonPausar.Text = "Pausar";
            buttonPausar.UseVisualStyleBackColor = true;
            buttonPausar.Click += buttonPausar_Click;
            // 
            // buttonPagar
            // 
            buttonPagar.Location = new Point(241, 166);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(75, 23);
            buttonPagar.TabIndex = 11;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // buttonResumen
            // 
            buttonResumen.Location = new Point(344, 166);
            buttonResumen.Name = "buttonResumen";
            buttonResumen.Size = new Size(110, 23);
            buttonResumen.TabIndex = 12;
            buttonResumen.Text = "Mostrar resumen";
            buttonResumen.UseVisualStyleBackColor = true;
            buttonResumen.Click += buttonResumen_Click;
            // 
            // FormTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 216);
            Controls.Add(buttonResumen);
            Controls.Add(buttonPagar);
            Controls.Add(buttonPausar);
            Controls.Add(buttonEmitir);
            Controls.Add(txtMonto);
            Controls.Add(txtLimite);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTarjeta";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtLimite;
        private TextBox txtMonto;
        private Button buttonEmitir;
        private Button buttonPausar;
        private Button buttonPagar;
        private Button buttonResumen;
    }
}