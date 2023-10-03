namespace EntidadFinancieraForm
{
    partial class FormTransferencia
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
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtMonto = new TextBox();
            buttonTransferir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 52);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Cuenta de origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Cuenta destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 168);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(150, 49);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(180, 23);
            txtOrigen.TabIndex = 3;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(150, 107);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(180, 23);
            txtDestino.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(150, 169);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 23);
            txtMonto.TabIndex = 5;
            // 
            // buttonTransferir
            // 
            buttonTransferir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTransferir.Location = new Point(105, 226);
            buttonTransferir.Name = "buttonTransferir";
            buttonTransferir.Size = new Size(116, 54);
            buttonTransferir.TabIndex = 6;
            buttonTransferir.Text = "Transferir";
            buttonTransferir.UseVisualStyleBackColor = true;
            buttonTransferir.Click += buttonTransferir_Click;
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 309);
            Controls.Add(buttonTransferir);
            Controls.Add(txtMonto);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtMonto;
        private Button buttonTransferir;
    }
}