﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.nombre2 = new System.Windows.Forms.TextBox();
            this.labelasesino = new System.Windows.Forms.Label();
            this.killstotales = new System.Windows.Forms.RadioButton();
            this.numkills = new System.Windows.Forms.RadioButton();
            this.kills = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 241);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Salir);
            this.groupBox1.Controls.Add(this.nombre2);
            this.groupBox1.Controls.Add(this.labelasesino);
            this.groupBox1.Controls.Add(this.killstotales);
            this.groupBox1.Controls.Add(this.numkills);
            this.groupBox1.Controls.Add(this.kills);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(924, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "+";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(515, 241);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(100, 28);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // nombre2
            // 
            this.nombre2.Location = new System.Drawing.Point(485, 73);
            this.nombre2.Margin = new System.Windows.Forms.Padding(4);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(229, 22);
            this.nombre2.TabIndex = 13;
            // 
            // labelasesino
            // 
            this.labelasesino.AutoSize = true;
            this.labelasesino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelasesino.Location = new System.Drawing.Point(32, 66);
            this.labelasesino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelasesino.Name = "labelasesino";
            this.labelasesino.Size = new System.Drawing.Size(416, 31);
            this.labelasesino.TabIndex = 12;
            this.labelasesino.Text = "Asesino (para la segunda opción)";
            // 
            // killstotales
            // 
            this.killstotales.AutoSize = true;
            this.killstotales.Location = new System.Drawing.Point(141, 174);
            this.killstotales.Margin = new System.Windows.Forms.Padding(4);
            this.killstotales.Name = "killstotales";
            this.killstotales.Size = new System.Drawing.Size(377, 21);
            this.killstotales.TabIndex = 11;
            this.killstotales.TabStop = true;
            this.killstotales.Text = "Dime el nombre de quien quieres saber sus kills totales";
            this.killstotales.UseVisualStyleBackColor = true;
            // 
            // numkills
            // 
            this.numkills.AutoSize = true;
            this.numkills.Location = new System.Drawing.Point(141, 145);
            this.numkills.Margin = new System.Windows.Forms.Padding(4);
            this.numkills.Name = "numkills";
            this.numkills.Size = new System.Drawing.Size(472, 21);
            this.numkills.TabIndex = 7;
            this.numkills.TabStop = true;
            this.numkills.Text = "Dime tu nombre y de quien quieres saber cuantas veces te ha matado";
            this.numkills.UseVisualStyleBackColor = true;
            // 
            // kills
            // 
            this.kills.AutoSize = true;
            this.kills.Location = new System.Drawing.Point(141, 117);
            this.kills.Margin = new System.Windows.Forms.Padding(4);
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(433, 21);
            this.kills.TabIndex = 10;
            this.kills.TabStop = true;
            this.kills.Text = "Dime el nombre de quien quieras saber sus partidas con +5 kills";
            this.kills.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kills;
        private System.Windows.Forms.RadioButton numkills;
        private System.Windows.Forms.RadioButton killstotales;
        private System.Windows.Forms.TextBox nombre2;
        private System.Windows.Forms.Label labelasesino;
        private System.Windows.Forms.Button Salir;
    }
}

