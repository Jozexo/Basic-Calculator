namespace MIEVA001
{
    partial class Form_Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calculadora));
            panel1 = new Panel();
            pbLogo = new PictureBox();
            gbOperadores = new GroupBox();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnResta = new Button();
            btnSuma = new Button();
            gbOperaciones = new GroupBox();
            button1 = new Button();
            btnCalcular = new Button();
            labelIgual = new Label();
            txtResultado = new TextBox();
            labelOperador = new Label();
            txtOperador2 = new TextBox();
            txtOperador1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbOperadores.SuspendLayout();
            gbOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(gbOperadores);
            panel1.Controls.Add(gbOperaciones);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 311);
            panel1.TabIndex = 1;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(227, 135);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(182, 161);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // gbOperadores
            // 
            gbOperadores.Controls.Add(btnMultiplicacion);
            gbOperadores.Controls.Add(btnDivision);
            gbOperadores.Controls.Add(btnResta);
            gbOperadores.Controls.Add(btnSuma);
            gbOperadores.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbOperadores.Location = new Point(12, 135);
            gbOperadores.Name = "gbOperadores";
            gbOperadores.Size = new Size(209, 162);
            gbOperadores.TabIndex = 6;
            gbOperadores.TabStop = false;
            gbOperadores.Text = "OPERADORES";
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.LightSteelBlue;
            btnMultiplicacion.Image = (Image)resources.GetObject("btnMultiplicacion.Image");
            btnMultiplicacion.Location = new Point(112, 90);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(53, 50);
            btnMultiplicacion.TabIndex = 3;
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.LightSteelBlue;
            btnDivision.Image = (Image)resources.GetObject("btnDivision.Image");
            btnDivision.Location = new Point(43, 90);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(53, 50);
            btnDivision.TabIndex = 2;
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.LightSteelBlue;
            btnResta.Image = (Image)resources.GetObject("btnResta.Image");
            btnResta.Location = new Point(112, 34);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(53, 50);
            btnResta.TabIndex = 1;
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.LightSteelBlue;
            btnSuma.Image = (Image)resources.GetObject("btnSuma.Image");
            btnSuma.Location = new Point(43, 34);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(53, 50);
            btnSuma.TabIndex = 0;
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // gbOperaciones
            // 
            gbOperaciones.Controls.Add(button1);
            gbOperaciones.Controls.Add(btnCalcular);
            gbOperaciones.Controls.Add(labelIgual);
            gbOperaciones.Controls.Add(txtResultado);
            gbOperaciones.Controls.Add(labelOperador);
            gbOperaciones.Controls.Add(txtOperador2);
            gbOperaciones.Controls.Add(txtOperador1);
            gbOperaciones.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbOperaciones.Location = new Point(12, 12);
            gbOperaciones.Name = "gbOperaciones";
            gbOperaciones.Size = new Size(397, 117);
            gbOperaciones.TabIndex = 0;
            gbOperaciones.TabStop = false;
            gbOperaciones.Text = "OPERACIONES";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(134, 72);
            button1.Name = "button1";
            button1.Size = new Size(245, 30);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightSteelBlue;
            btnCalcular.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(17, 72);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // labelIgual
            // 
            labelIgual.AutoSize = true;
            labelIgual.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIgual.Location = new Point(254, 32);
            labelIgual.Name = "labelIgual";
            labelIgual.Size = new Size(19, 21);
            labelIgual.TabIndex = 4;
            labelIgual.Text = "=";
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Cascadia Code", 9F);
            txtResultado.Location = new Point(279, 32);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 21);
            txtResultado.TabIndex = 3;
            // 
            // labelOperador
            // 
            labelOperador.AutoSize = true;
            labelOperador.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOperador.Location = new Point(123, 31);
            labelOperador.Name = "labelOperador";
            labelOperador.Size = new Size(19, 21);
            labelOperador.TabIndex = 1;
            labelOperador.Text = "*";
            labelOperador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOperador2
            // 
            txtOperador2.Font = new Font("Cascadia Code", 9F);
            txtOperador2.Location = new Point(148, 32);
            txtOperador2.Name = "txtOperador2";
            txtOperador2.Size = new Size(100, 21);
            txtOperador2.TabIndex = 2;
            txtOperador2.TextChanged += txtOperador2_TextChanged;
            txtOperador2.KeyPress += txtOperador2_KeyPress;
            // 
            // txtOperador1
            // 
            txtOperador1.Font = new Font("Cascadia Code", 9F);
            txtOperador1.Location = new Point(17, 32);
            txtOperador1.Name = "txtOperador1";
            txtOperador1.Size = new Size(100, 21);
            txtOperador1.TabIndex = 1;
            txtOperador1.TextChanged += txtOperador1_TextChanged;
            txtOperador1.KeyPress += txtOperador1_KeyPress;
            // 
            // Form_Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 311);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULADORA";
            Load += Form_Calculadora_Load;
            Shown += Form_Calculadora_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbOperadores.ResumeLayout(false);
            gbOperaciones.ResumeLayout(false);
            gbOperaciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbLogo;
        private GroupBox gbOperadores;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnResta;
        private Button btnSuma;
        private GroupBox gbOperaciones;
        private Button button1;
        private Button btnCalcular;
        private Label labelIgual;
        private TextBox txtResultado;
        private Label labelOperador;
        private TextBox txtOperador2;
        private TextBox txtOperador1;
    }
}
