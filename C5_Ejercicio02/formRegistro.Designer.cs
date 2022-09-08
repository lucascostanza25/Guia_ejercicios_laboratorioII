namespace C5_Ejercicio02
{
    partial class formRegistro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Edad = new System.Windows.Forms.NumericUpDown();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Nb = new System.Windows.Forms.RadioButton();
            this.radioButton_Fem = new System.Windows.Forms.RadioButton();
            this.radioButton_Masc = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Pais = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_JavaS = new System.Windows.Forms.CheckBox();
            this.checkBox_Cplus = new System.Windows.Forms.CheckBox();
            this.checkBox_Csharp = new System.Windows.Forms.CheckBox();
            this.button_Ingresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Edad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_Edad);
            this.groupBox1.Controls.Add(this.textBox_Direccion);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // numericUpDown_Edad
            // 
            this.numericUpDown_Edad.Location = new System.Drawing.Point(63, 77);
            this.numericUpDown_Edad.Name = "numericUpDown_Edad";
            this.numericUpDown_Edad.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_Edad.TabIndex = 5;
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(63, 48);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(131, 23);
            this.textBox_Direccion.TabIndex = 4;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(63, 16);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(131, 23);
            this.textBox_Nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Nb);
            this.groupBox2.Controls.Add(this.radioButton_Fem);
            this.groupBox2.Controls.Add(this.radioButton_Masc);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Género";
            // 
            // radioButton_Nb
            // 
            this.radioButton_Nb.AutoSize = true;
            this.radioButton_Nb.Location = new System.Drawing.Point(15, 72);
            this.radioButton_Nb.Name = "radioButton_Nb";
            this.radioButton_Nb.Size = new System.Drawing.Size(81, 19);
            this.radioButton_Nb.TabIndex = 2;
            this.radioButton_Nb.TabStop = true;
            this.radioButton_Nb.Text = "No binario";
            this.radioButton_Nb.UseVisualStyleBackColor = true;
            // 
            // radioButton_Fem
            // 
            this.radioButton_Fem.AutoSize = true;
            this.radioButton_Fem.Location = new System.Drawing.Point(15, 47);
            this.radioButton_Fem.Name = "radioButton_Fem";
            this.radioButton_Fem.Size = new System.Drawing.Size(78, 19);
            this.radioButton_Fem.TabIndex = 1;
            this.radioButton_Fem.TabStop = true;
            this.radioButton_Fem.Text = "Femenino";
            this.radioButton_Fem.UseVisualStyleBackColor = true;
            // 
            // radioButton_Masc
            // 
            this.radioButton_Masc.AutoSize = true;
            this.radioButton_Masc.Location = new System.Drawing.Point(15, 22);
            this.radioButton_Masc.Name = "radioButton_Masc";
            this.radioButton_Masc.Size = new System.Drawing.Size(80, 19);
            this.radioButton_Masc.TabIndex = 0;
            this.radioButton_Masc.TabStop = true;
            this.radioButton_Masc.Text = "Masculino";
            this.radioButton_Masc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Pais);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "País";
            // 
            // listBox_Pais
            // 
            this.listBox_Pais.FormattingEnabled = true;
            this.listBox_Pais.ItemHeight = 15;
            this.listBox_Pais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBox_Pais.Location = new System.Drawing.Point(6, 22);
            this.listBox_Pais.Name = "listBox_Pais";
            this.listBox_Pais.Size = new System.Drawing.Size(188, 94);
            this.listBox_Pais.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_JavaS);
            this.groupBox4.Controls.Add(this.checkBox_Cplus);
            this.groupBox4.Controls.Add(this.checkBox_Csharp);
            this.groupBox4.Location = new System.Drawing.Point(227, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 118);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cursos";
            // 
            // checkBox_JavaS
            // 
            this.checkBox_JavaS.AutoSize = true;
            this.checkBox_JavaS.Location = new System.Drawing.Point(15, 79);
            this.checkBox_JavaS.Name = "checkBox_JavaS";
            this.checkBox_JavaS.Size = new System.Drawing.Size(78, 19);
            this.checkBox_JavaS.TabIndex = 2;
            this.checkBox_JavaS.Text = "JavaScript";
            this.checkBox_JavaS.UseVisualStyleBackColor = true;
            // 
            // checkBox_Cplus
            // 
            this.checkBox_Cplus.AutoSize = true;
            this.checkBox_Cplus.Location = new System.Drawing.Point(15, 51);
            this.checkBox_Cplus.Name = "checkBox_Cplus";
            this.checkBox_Cplus.Size = new System.Drawing.Size(50, 19);
            this.checkBox_Cplus.TabIndex = 1;
            this.checkBox_Cplus.Text = "C++";
            this.checkBox_Cplus.UseVisualStyleBackColor = true;
            // 
            // checkBox_Csharp
            // 
            this.checkBox_Csharp.AutoSize = true;
            this.checkBox_Csharp.Location = new System.Drawing.Point(15, 22);
            this.checkBox_Csharp.Name = "checkBox_Csharp";
            this.checkBox_Csharp.Size = new System.Drawing.Size(41, 19);
            this.checkBox_Csharp.TabIndex = 0;
            this.checkBox_Csharp.Text = "C#";
            this.checkBox_Csharp.UseVisualStyleBackColor = true;
            // 
            // button_Ingresar
            // 
            this.button_Ingresar.Location = new System.Drawing.Point(227, 242);
            this.button_Ingresar.Name = "button_Ingresar";
            this.button_Ingresar.Size = new System.Drawing.Size(144, 23);
            this.button_Ingresar.TabIndex = 4;
            this.button_Ingresar.Text = "Ingresar";
            this.button_Ingresar.UseVisualStyleBackColor = true;
            this.button_Ingresar.Click += new System.EventHandler(this.button_Ingresar_Click);
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 277);
            this.Controls.Add(this.button_Ingresar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formRegistro";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Edad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Edad;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Nb;
        private System.Windows.Forms.RadioButton radioButton_Fem;
        private System.Windows.Forms.RadioButton radioButton_Masc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_JavaS;
        private System.Windows.Forms.CheckBox checkBox_Cplus;
        private System.Windows.Forms.CheckBox checkBox_Csharp;
        private System.Windows.Forms.Button button_Ingresar;
        private System.Windows.Forms.ListBox listBox_Pais;
    }
}
