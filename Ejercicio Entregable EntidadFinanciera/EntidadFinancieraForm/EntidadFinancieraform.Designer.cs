namespace EntidadFinancieraForm
{
    partial class EntidadFinancieraform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAgregar = new Button();
            buttonCuenta = new Button();
            buttonTarjeta = new Button();
            buttonOperaciones = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(28, 143);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(110, 65);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar Clientes";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += button1_Click;
            // 
            // buttonCuenta
            // 
            buttonCuenta.Location = new Point(189, 143);
            buttonCuenta.Name = "buttonCuenta";
            buttonCuenta.Size = new Size(115, 65);
            buttonCuenta.TabIndex = 1;
            buttonCuenta.Text = "Cuenta";
            buttonCuenta.UseVisualStyleBackColor = true;
            buttonCuenta.Click += buttonCuenta_Click;
            // 
            // buttonTarjeta
            // 
            buttonTarjeta.Location = new Point(388, 143);
            buttonTarjeta.Name = "buttonTarjeta";
            buttonTarjeta.Size = new Size(115, 65);
            buttonTarjeta.TabIndex = 2;
            buttonTarjeta.Text = "Tarjeta";
            buttonTarjeta.UseVisualStyleBackColor = true;
            buttonTarjeta.Click += buttonTarjeta_Click;
            // 
            // buttonOperaciones
            // 
            buttonOperaciones.Location = new Point(569, 143);
            buttonOperaciones.Name = "buttonOperaciones";
            buttonOperaciones.Size = new Size(115, 65);
            buttonOperaciones.TabIndex = 3;
            buttonOperaciones.Text = "Operaciones";
            buttonOperaciones.UseVisualStyleBackColor = true;
            buttonOperaciones.Click += buttonOperaciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(251, 36);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 4;
            label1.Text = "Entidad Financiera";
            // 
            // EntidadFinanciera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 264);
            Controls.Add(label1);
            Controls.Add(buttonOperaciones);
            Controls.Add(buttonTarjeta);
            Controls.Add(buttonCuenta);
            Controls.Add(buttonAgregar);
            Name = "EntidadFinanciera";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private Button buttonCuenta;
        private Button buttonTarjeta;
        private Button buttonOperaciones;
        private Label label1;
    }
}