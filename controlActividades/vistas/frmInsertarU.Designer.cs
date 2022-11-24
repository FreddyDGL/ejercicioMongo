namespace controlActividades.vistas
{
    partial class frmInsertarU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApMaterno = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxApPaterno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "insertar Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(215, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(246, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(358, 94);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(242, 38);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApMaterno
            // 
            this.textBoxApMaterno.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxApMaterno.Location = new System.Drawing.Point(358, 219);
            this.textBoxApMaterno.Name = "textBoxApMaterno";
            this.textBoxApMaterno.Size = new System.Drawing.Size(242, 38);
            this.textBoxApMaterno.TabIndex = 6;
            this.textBoxApMaterno.TextChanged += new System.EventHandler(this.textBoxApMaterno_TextChanged);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEdad.Location = new System.Drawing.Point(358, 283);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(242, 38);
            this.textBoxEdad.TabIndex = 7;
            this.textBoxEdad.TextChanged += new System.EventHandler(this.textBoxEdad_TextChanged);
            // 
            // textBoxApPaterno
            // 
            this.textBoxApPaterno.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxApPaterno.Location = new System.Drawing.Point(358, 153);
            this.textBoxApPaterno.Name = "textBoxApPaterno";
            this.textBoxApPaterno.Size = new System.Drawing.Size(242, 38);
            this.textBoxApPaterno.TabIndex = 8;
            this.textBoxApPaterno.TextChanged += new System.EventHandler(this.textBoxApPaterno_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(246, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInsertarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxApPaterno);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxApMaterno);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInsertarU";
            this.Text = "frmInsertarU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNombre;
        private TextBox textBoxApMaterno;
        private TextBox textBoxEdad;
        private TextBox textBoxApPaterno;
        private Button button1;
    }
}