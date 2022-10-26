namespace C6_Ejercicio03
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
            this.rtbString = new System.Windows.Forms.RichTextBox();
            this.btnCalular = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbString
            // 
            this.rtbString.Location = new System.Drawing.Point(12, 12);
            this.rtbString.Name = "rtbString";
            this.rtbString.Size = new System.Drawing.Size(449, 403);
            this.rtbString.TabIndex = 0;
            this.rtbString.Text = "";
            // 
            // btnCalular
            // 
            this.btnCalular.Location = new System.Drawing.Point(339, 421);
            this.btnCalular.Name = "btnCalular";
            this.btnCalular.Size = new System.Drawing.Size(122, 23);
            this.btnCalular.TabIndex = 1;
            this.btnCalular.Text = "Calcular";
            this.btnCalular.UseVisualStyleBackColor = true;
            this.btnCalular.Click += new System.EventHandler(this.btnCalular_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(295, 425);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 15);
            this.lblContador.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 456);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnCalular);
            this.Controls.Add(this.rtbString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbString;
        private System.Windows.Forms.Button btnCalular;
        private System.Windows.Forms.Label lblContador;
    }
}
