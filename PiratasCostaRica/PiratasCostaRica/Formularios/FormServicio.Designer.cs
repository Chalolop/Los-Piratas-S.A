namespace PiratasCostaRica.Formularios
{
    partial class FormServicio
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
            this.textSced = new System.Windows.Forms.TextBox();
            this.comboruta = new System.Windows.Forms.ComboBox();
            this.textSdistancia = new System.Windows.Forms.TextBox();
            this.textScolon = new System.Windows.Forms.TextBox();
            this.textSdolar = new System.Windows.Forms.TextBox();
            this.buttonSrealizar = new System.Windows.Forms.Button();
            this.buttonSvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total a pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distancia (Km):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ruta:";
            // 
            // textSced
            // 
            this.textSced.Location = new System.Drawing.Point(169, 66);
            this.textSced.Name = "textSced";
            this.textSced.Size = new System.Drawing.Size(137, 20);
            this.textSced.TabIndex = 4;
            // 
            // comboruta
            // 
            this.comboruta.FormattingEnabled = true;
            this.comboruta.Location = new System.Drawing.Point(169, 104);
            this.comboruta.Name = "comboruta";
            this.comboruta.Size = new System.Drawing.Size(137, 21);
            this.comboruta.TabIndex = 5;
            // 
            // textSdistancia
            // 
            this.textSdistancia.Location = new System.Drawing.Point(169, 162);
            this.textSdistancia.Name = "textSdistancia";
            this.textSdistancia.Size = new System.Drawing.Size(137, 20);
            this.textSdistancia.TabIndex = 6;
            // 
            // textScolon
            // 
            this.textScolon.Location = new System.Drawing.Point(169, 208);
            this.textScolon.Name = "textScolon";
            this.textScolon.Size = new System.Drawing.Size(64, 20);
            this.textScolon.TabIndex = 7;
            // 
            // textSdolar
            // 
            this.textSdolar.Location = new System.Drawing.Point(242, 208);
            this.textSdolar.Name = "textSdolar";
            this.textSdolar.Size = new System.Drawing.Size(64, 20);
            this.textSdolar.TabIndex = 8;
            // 
            // buttonSrealizar
            // 
            this.buttonSrealizar.Location = new System.Drawing.Point(146, 271);
            this.buttonSrealizar.Name = "buttonSrealizar";
            this.buttonSrealizar.Size = new System.Drawing.Size(100, 23);
            this.buttonSrealizar.TabIndex = 9;
            this.buttonSrealizar.Text = "Realizar viaje";
            this.buttonSrealizar.UseVisualStyleBackColor = true;
            // 
            // buttonSvolver
            // 
            this.buttonSvolver.Location = new System.Drawing.Point(336, 326);
            this.buttonSvolver.Name = "buttonSvolver";
            this.buttonSvolver.Size = new System.Drawing.Size(56, 23);
            this.buttonSvolver.TabIndex = 10;
            this.buttonSvolver.Text = "Volver";
            this.buttonSvolver.UseVisualStyleBackColor = true;
            // 
            // FormServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.buttonSvolver);
            this.Controls.Add(this.buttonSrealizar);
            this.Controls.Add(this.textSdolar);
            this.Controls.Add(this.textScolon);
            this.Controls.Add(this.textSdistancia);
            this.Controls.Add(this.comboruta);
            this.Controls.Add(this.textSced);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormServicio";
            this.Text = "FormServicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSced;
        private System.Windows.Forms.ComboBox comboruta;
        private System.Windows.Forms.TextBox textSdistancia;
        private System.Windows.Forms.TextBox textScolon;
        private System.Windows.Forms.TextBox textSdolar;
        private System.Windows.Forms.Button buttonSrealizar;
        private System.Windows.Forms.Button buttonSvolver;
    }
}