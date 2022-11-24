namespace controlActividades.vistas
{
    partial class frmEliminarA
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
            this.textBoxDNombreA = new System.Windows.Forms.TextBox();
            this.textBoxDUsuarioA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la Actividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario que la Realizo ";
            // 
            // textBoxDNombreA
            // 
            this.textBoxDNombreA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDNombreA.Location = new System.Drawing.Point(415, 146);
            this.textBoxDNombreA.Name = "textBoxDNombreA";
            this.textBoxDNombreA.Size = new System.Drawing.Size(307, 38);
            this.textBoxDNombreA.TabIndex = 4;
            // 
            // textBoxDUsuarioA
            // 
            this.textBoxDUsuarioA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDUsuarioA.Location = new System.Drawing.Point(415, 242);
            this.textBoxDUsuarioA.Name = "textBoxDUsuarioA";
            this.textBoxDUsuarioA.Size = new System.Drawing.Size(307, 38);
            this.textBoxDUsuarioA.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(248, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar Actividad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEliminarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDUsuarioA);
            this.Controls.Add(this.textBoxDNombreA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEliminarA";
            this.Text = "frmEliminarA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDNombreA;
        private TextBox textBoxDUsuarioA;
        private Button button1;
    }
}