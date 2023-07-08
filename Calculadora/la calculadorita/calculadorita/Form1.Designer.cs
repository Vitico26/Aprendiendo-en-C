namespace calculadorita
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBorrartodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnSignodeelevaralcuadrado = new System.Windows.Forms.Button();
            this.btnSignoderaiz = new System.Windows.Forms.Button();
            this.btnSignodemultiplicacion = new System.Windows.Forms.Button();
            this.btnSignodedivision = new System.Windows.Forms.Button();
            this.btnSignodemas = new System.Windows.Forms.Button();
            this.btnSignodemenos = new System.Windows.Forms.Button();
            this.btnSignodeigual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnCambiodesigno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.MaxLength = 22;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(308, 46);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(12, 269);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(45, 45);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(72, 269);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(45, 45);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(132, 269);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(45, 45);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(132, 208);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(45, 45);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(72, 208);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(45, 45);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(12, 208);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(45, 45);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(132, 86);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 45);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "DEL";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBorrartodo
            // 
            this.btnBorrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrartodo.Location = new System.Drawing.Point(72, 86);
            this.btnBorrartodo.Name = "btnBorrartodo";
            this.btnBorrartodo.Size = new System.Drawing.Size(45, 45);
            this.btnBorrartodo.TabIndex = 11;
            this.btnBorrartodo.Text = "C";
            this.btnBorrartodo.UseVisualStyleBackColor = true;
            this.btnBorrartodo.Click += new System.EventHandler(this.btnBorrartodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(12, 85);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 45);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(132, 147);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(45, 45);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(72, 147);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(45, 45);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(12, 147);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(45, 45);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnSignodeelevaralcuadrado
            // 
            this.btnSignodeelevaralcuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignodeelevaralcuadrado.Location = new System.Drawing.Point(275, 85);
            this.btnSignodeelevaralcuadrado.Name = "btnSignodeelevaralcuadrado";
            this.btnSignodeelevaralcuadrado.Size = new System.Drawing.Size(45, 45);
            this.btnSignodeelevaralcuadrado.TabIndex = 14;
            this.btnSignodeelevaralcuadrado.Tag = "²";
            this.btnSignodeelevaralcuadrado.Text = "X²";
            this.btnSignodeelevaralcuadrado.UseVisualStyleBackColor = true;
            this.btnSignodeelevaralcuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSignoderaiz
            // 
            this.btnSignoderaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoderaiz.Location = new System.Drawing.Point(215, 85);
            this.btnSignoderaiz.Name = "btnSignoderaiz";
            this.btnSignoderaiz.Size = new System.Drawing.Size(45, 45);
            this.btnSignoderaiz.TabIndex = 13;
            this.btnSignoderaiz.Tag = "√";
            this.btnSignoderaiz.Text = "√";
            this.btnSignoderaiz.UseVisualStyleBackColor = true;
            this.btnSignoderaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSignodemultiplicacion
            // 
            this.btnSignodemultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignodemultiplicacion.Location = new System.Drawing.Point(275, 150);
            this.btnSignodemultiplicacion.Name = "btnSignodemultiplicacion";
            this.btnSignodemultiplicacion.Size = new System.Drawing.Size(45, 45);
            this.btnSignodemultiplicacion.TabIndex = 16;
            this.btnSignodemultiplicacion.Tag = "*";
            this.btnSignodemultiplicacion.Text = "*";
            this.btnSignodemultiplicacion.UseVisualStyleBackColor = true;
            this.btnSignodemultiplicacion.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSignodedivision
            // 
            this.btnSignodedivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignodedivision.Location = new System.Drawing.Point(215, 150);
            this.btnSignodedivision.Name = "btnSignodedivision";
            this.btnSignodedivision.Size = new System.Drawing.Size(45, 45);
            this.btnSignodedivision.TabIndex = 15;
            this.btnSignodedivision.Tag = "÷";
            this.btnSignodedivision.Text = "÷";
            this.btnSignodedivision.UseVisualStyleBackColor = true;
            this.btnSignodedivision.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSignodemas
            // 
            this.btnSignodemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignodemas.Location = new System.Drawing.Point(275, 211);
            this.btnSignodemas.Name = "btnSignodemas";
            this.btnSignodemas.Size = new System.Drawing.Size(45, 45);
            this.btnSignodemas.TabIndex = 18;
            this.btnSignodemas.Tag = "+";
            this.btnSignodemas.Text = "+";
            this.btnSignodemas.UseVisualStyleBackColor = true;
            this.btnSignodemas.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSignodemenos
            // 
            this.btnSignodemenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignodemenos.Location = new System.Drawing.Point(215, 211);
            this.btnSignodemenos.Name = "btnSignodemenos";
            this.btnSignodemenos.Size = new System.Drawing.Size(45, 45);
            this.btnSignodemenos.TabIndex = 17;
            this.btnSignodemenos.Tag = "-";
            this.btnSignodemenos.Text = "-";
            this.btnSignodemenos.UseVisualStyleBackColor = true;
            this.btnSignodemenos.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSignodeigual
            // 
            this.btnSignodeigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignodeigual.Location = new System.Drawing.Point(215, 269);
            this.btnSignodeigual.Name = "btnSignodeigual";
            this.btnSignodeigual.Size = new System.Drawing.Size(105, 45);
            this.btnSignodeigual.TabIndex = 19;
            this.btnSignodeigual.Text = "=";
            this.btnSignodeigual.UseVisualStyleBackColor = true;
            this.btnSignodeigual.Click += new System.EventHandler(this.btnSignodeigual_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(132, 331);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(45, 45);
            this.btnPunto.TabIndex = 22;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(72, 331);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(45, 45);
            this.btnCero.TabIndex = 21;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnCambiodesigno
            // 
            this.btnCambiodesigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiodesigno.Location = new System.Drawing.Point(12, 331);
            this.btnCambiodesigno.Name = "btnCambiodesigno";
            this.btnCambiodesigno.Size = new System.Drawing.Size(45, 45);
            this.btnCambiodesigno.TabIndex = 20;
            this.btnCambiodesigno.Text = "±";
            this.btnCambiodesigno.UseVisualStyleBackColor = true;
            this.btnCambiodesigno.Click += new System.EventHandler(this.btnCambiodesigno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnCambiodesigno);
            this.Controls.Add(this.btnSignodeigual);
            this.Controls.Add(this.btnSignodemas);
            this.Controls.Add(this.btnSignodemenos);
            this.Controls.Add(this.btnSignodemultiplicacion);
            this.Controls.Add(this.btnSignodedivision);
            this.Controls.Add(this.btnSignodeelevaralcuadrado);
            this.Controls.Add(this.btnSignoderaiz);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBorrartodo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrartodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnSignodeelevaralcuadrado;
        private System.Windows.Forms.Button btnSignoderaiz;
        private System.Windows.Forms.Button btnSignodemultiplicacion;
        private System.Windows.Forms.Button btnSignodedivision;
        private System.Windows.Forms.Button btnSignodemas;
        private System.Windows.Forms.Button btnSignodemenos;
        private System.Windows.Forms.Button btnSignodeigual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnCambiodesigno;
    }
}

