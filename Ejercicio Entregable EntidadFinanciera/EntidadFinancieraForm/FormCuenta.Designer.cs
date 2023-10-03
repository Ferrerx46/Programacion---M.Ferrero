namespace EntidadFinancieraForm
{
    partial class FormCuenta
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
            txtNumeroCuenta = new TextBox();
            txtSaldo = new TextBox();
            buttonGuardarCuenta = new Button();
            label4 = new Label();
            cboTipoCuenta = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Numero de cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 155);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 213);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(218, 100);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(192, 23);
            txtNumeroCuenta.TabIndex = 3;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(218, 160);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(192, 23);
            txtSaldo.TabIndex = 4;
            // 
            // buttonGuardarCuenta
            // 
            buttonGuardarCuenta.Location = new Point(175, 295);
            buttonGuardarCuenta.Name = "buttonGuardarCuenta";
            buttonGuardarCuenta.Size = new Size(75, 23);
            buttonGuardarCuenta.TabIndex = 6;
            buttonGuardarCuenta.Text = "Guardar";
            buttonGuardarCuenta.UseVisualStyleBackColor = true;
            buttonGuardarCuenta.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(150, 20);
            label4.Name = "label4";
            label4.Size = new Size(109, 37);
            label4.TabIndex = 7;
            label4.Text = "Cuenta";
            // 
            // cboTipoCuenta
            // 
            cboTipoCuenta.FormattingEnabled = true;
            cboTipoCuenta.Items.AddRange(new object[] { "Ahorro", "Corriente" });
            cboTipoCuenta.Location = new Point(218, 215);
            cboTipoCuenta.Name = "cboTipoCuenta";
            cboTipoCuenta.Size = new Size(192, 23);
            cboTipoCuenta.TabIndex = 8;
            // 
            // FormCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 361);
            Controls.Add(cboTipoCuenta);
            Controls.Add(label4);
            Controls.Add(buttonGuardarCuenta);
            Controls.Add(txtSaldo);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCuenta";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumeroCuenta;
        private TextBox txtSaldo;
        private Button buttonGuardarCuenta;
        private Label label4;
        private ComboBox cboTipoCuenta;
    }
}