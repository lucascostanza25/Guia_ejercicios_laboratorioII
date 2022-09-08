namespace C5_Ejercicio01
{
    partial class formSaludador
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
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Titulo.Location = new System.Drawing.Point(12, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(67, 25);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "label1";
            // 
            // label_Mensaje
            // 
            this.label_Mensaje.AutoSize = true;
            this.label_Mensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Mensaje.Location = new System.Drawing.Point(12, 52);
            this.label_Mensaje.Name = "label_Mensaje";
            this.label_Mensaje.Size = new System.Drawing.Size(52, 21);
            this.label_Mensaje.TabIndex = 1;
            this.label_Mensaje.Text = "label2";
            // 
            // formSaludador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 103);
            this.Controls.Add(this.label_Mensaje);
            this.Controls.Add(this.label_Titulo);
            this.Name = "formSaludador";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Mensaje;
    }
}