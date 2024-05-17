namespace FormRjercicioB
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxTema = new TextBox();
            textBoxAlumnos = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonAgregar = new Button();
            buttonSueldo = new Button();
            button1 = new Button();
            listboxClases = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Tema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 71);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de estudiantes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 123);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de inicio";
            // 
            // textBoxTema
            // 
            textBoxTema.Location = new Point(168, 24);
            textBoxTema.Name = "textBoxTema";
            textBoxTema.Size = new Size(100, 23);
            textBoxTema.TabIndex = 3;
            // 
            // textBoxAlumnos
            // 
            textBoxAlumnos.Location = new Point(168, 71);
            textBoxAlumnos.Name = "textBoxAlumnos";
            textBoxAlumnos.Size = new Size(100, 23);
            textBoxAlumnos.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(26, 204);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonSueldo
            // 
            buttonSueldo.Location = new Point(154, 204);
            buttonSueldo.Name = "buttonSueldo";
            buttonSueldo.Size = new Size(114, 23);
            buttonSueldo.TabIndex = 7;
            buttonSueldo.Text = "Calcular sueldo";
            buttonSueldo.UseVisualStyleBackColor = true;
            buttonSueldo.Click += buttonSueldo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(319, 204);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 8;
            button1.Text = "Clases sin alumnos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listboxClases
            // 
            listboxClases.FormattingEnabled = true;
            listboxClases.ItemHeight = 15;
            listboxClases.Location = new Point(528, 24);
            listboxClases.Name = "listboxClases";
            listboxClases.Size = new Size(215, 169);
            listboxClases.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 305);
            Controls.Add(listboxClases);
            Controls.Add(button1);
            Controls.Add(buttonSueldo);
            Controls.Add(buttonAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxAlumnos);
            Controls.Add(textBoxTema);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTema;
        private TextBox textBoxAlumnos;
        private DateTimePicker dateTimePicker1;
        private Button buttonAgregar;
        private Button buttonSueldo;
        private Button button1;
        private ListBox listboxClases;
    }
}
