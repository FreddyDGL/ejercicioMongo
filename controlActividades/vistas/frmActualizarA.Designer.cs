namespace controlActividades.vistas
{
    partial class frmActualizarA
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
            this.textBoxANombreA = new System.Windows.Forms.TextBox();
            this.textBoxAUsuarioA = new System.Windows.Forms.TextBox();
            this.btnUpdateA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Actividad ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario que la Realizo ";
            // 
            // textBoxANombreA
            // 
            this.textBoxANombreA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxANombreA.Location = new System.Drawing.Point(396, 145);
            this.textBoxANombreA.Name = "textBoxANombreA";
            this.textBoxANombreA.Size = new System.Drawing.Size(253, 38);
            this.textBoxANombreA.TabIndex = 4;
            // 
            // textBoxAUsuarioA
            // 
            this.textBoxAUsuarioA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAUsuarioA.Location = new System.Drawing.Point(396, 248);
            this.textBoxAUsuarioA.Name = "textBoxAUsuarioA";
            this.textBoxAUsuarioA.Size = new System.Drawing.Size(253, 38);
            this.textBoxAUsuarioA.TabIndex = 5;
            // 
            // btnUpdateA
            // 
            this.btnUpdateA.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateA.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateA.Location = new System.Drawing.Point(247, 335);
            this.btnUpdateA.Name = "btnUpdateA";
            this.btnUpdateA.Size = new System.Drawing.Size(255, 72);
            this.btnUpdateA.TabIndex = 6;
            this.btnUpdateA.Text = "Actualizar Actividad ";
            this.btnUpdateA.UseVisualStyleBackColor = false;
            this.btnUpdateA.Click += new System.EventHandler(this.btnUpdateA_Click);
            // 
            // frmActualizarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateA);
            this.Controls.Add(this.textBoxAUsuarioA);
            this.Controls.Add(this.textBoxANombreA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmActualizarA";
            this.Text = "frmActualizarA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxANombreA;
        private TextBox textBoxAUsuarioA;
        private Button btnUpdateA;
    }
}