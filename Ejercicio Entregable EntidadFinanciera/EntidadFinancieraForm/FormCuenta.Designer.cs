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
            label2 = new Label();
            label3 = new Label();
            txtSaldo = new TextBox();
            buttonGuardarCuenta = new Button();
            label4 = new Label();
            cboTipoCuenta = new ComboBox();
            dataGridViewCuentas = new DataGridView();
            label1 = new Label();
            txtDNI = new TextBox();
            txtNumero = new TextBox();
            label5 = new Label();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuentas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 151);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(175, 96);
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
            cboTipoCuenta.Location = new Point(175, 151);
            cboTipoCuenta.Name = "cboTipoCuenta";
            cboTipoCuenta.Size = new Size(192, 23);
            cboTipoCuenta.TabIndex = 8;
            // 
            // dataGridViewCuentas
            // 
            dataGridViewCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCuentas.Location = new Point(435, 45);
            dataGridViewCuentas.Name = "dataGridViewCuentas";
            dataGridViewCuentas.RowTemplate.Height = 25;
            dataGridViewCuentas.Size = new Size(448, 260);
            dataGridViewCuentas.TabIndex = 9;
            dataGridViewCuentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 202);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 10;
            label1.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(175, 207);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(192, 23);
            txtDNI.TabIndex = 11;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(666, 322);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(192, 23);
            txtNumero.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(472, 322);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 13;
            label5.Text = "Numero de cuenta";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(627, 366);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // FormCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 401);
            Controls.Add(buttonEliminar);
            Controls.Add(label5);
            Controls.Add(txtNumero);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Controls.Add(dataGridViewCuentas);
            Controls.Add(cboTipoCuenta);
            Controls.Add(label4);
            Controls.Add(buttonGuardarCuenta);
            Controls.Add(txtSaldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormCuenta";
            Text = "Form1";
            Load += FormCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtSaldo;
        private Button buttonGuardarCuenta;
        private Label label4;
        private ComboBox cboTipoCuenta;
        private DataGridView dataGridViewCuentas;
        private Label label1;
        private TextBox txtDNI;
        private TextBox txtNumero;
        private Label label5;
        private Button buttonEliminar;
    }
}