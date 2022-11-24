namespace controlActividades.vistas
{
    partial class frmInsertarA
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBoxNombreA = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Actividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario que la Realizo ";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreate.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(273, 321);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(230, 79);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Crear Actividad ";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textBoxNombreA
            // 
            this.textBoxNombreA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombreA.Location = new System.Drawing.Point(398, 141);
            this.textBoxNombreA.Name = "textBoxNombreA";
            this.textBoxNombreA.Size = new System.Drawing.Size(289, 38);
            this.textBoxNombreA.TabIndex = 4;
            // 
            // textBoxUsuarioA
            // 
            this.textBoxUsuarioA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsuarioA.Location = new System.Drawing.Point(398, 219);
            this.textBoxUsuarioA.Name = "textBoxUsuarioA";
            this.textBoxUsuarioA.Size = new System.Drawing.Size(289, 38);
            this.textBoxUsuarioA.TabIndex = 5;
            // 
            // frmInsertarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUsuarioA);
            this.Controls.Add(this.textBoxNombreA);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInsertarA";
            this.Text = "frmInsertarA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreate;
        private TextBox textBoxNombreA;
        private TextBox textBoxUsuarioA;
    }
}