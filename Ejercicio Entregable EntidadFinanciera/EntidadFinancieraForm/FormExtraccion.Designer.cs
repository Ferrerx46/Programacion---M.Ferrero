namespace EntidadFinancieraForm
{
    partial class FormExtraccion
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
            txtNumero = new TextBox();
            txtMonto = new TextBox();
            buttonExtraer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(207, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el numero de cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 131);
            label2.Name = "label2";
            label2.Size = new Size(235, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el monto que desa extraer";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(273, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(176, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(273, 132);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(176, 23);
            txtMonto.TabIndex = 3;
            // 
            // buttonExtraer
            // 
            buttonExtraer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExtraer.Location = new Point(174, 203);
            buttonExtraer.Name = "buttonExtraer";
            buttonExtraer.Size = new Size(111, 41);
            buttonExtraer.TabIndex = 4;
            buttonExtraer.Text = "Extraer";
            buttonExtraer.UseVisualStyleBackColor = true;
            buttonExtraer.Click += buttonExtraer_Click;
            // 
            // FormExtraccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 281);
            Controls.Add(buttonExtraer);
            Controls.Add(txtMonto);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormExtraccion";
            Text = "FormExtraccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private TextBox txtMonto;
        private Button buttonExtraer;
    }
}