namespace EntidadFinancieraForm
{
    partial class FormDeposito
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
            txtMonto = new TextBox();
            buttonDepositar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNumeroCuenta = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la cantidad deseada";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(276, 135);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(201, 23);
            txtMonto.TabIndex = 1;
            // 
            // buttonDepositar
            // 
            buttonDepositar.Location = new Point(208, 210);
            buttonDepositar.Name = "buttonDepositar";
            buttonDepositar.Size = new Size(75, 23);
            buttonDepositar.TabIndex = 2;
            buttonDepositar.Text = "Depositar";
            buttonDepositar.UseVisualStyleBackColor = true;
            buttonDepositar.Click += buttonDepositar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 70);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 4;
            label3.Text = "Numero de cuenta";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(276, 75);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(201, 23);
            txtNumeroCuenta.TabIndex = 5;
            // 
            // FormDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 271);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonDepositar);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Name = "FormDeposito";
            Text = "FormDeposito";
            Load += FormDeposito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMonto;
        private Button buttonDepositar;
        private Label label2;
        private Label label3;
        private TextBox txtNumeroCuenta;
    }
}