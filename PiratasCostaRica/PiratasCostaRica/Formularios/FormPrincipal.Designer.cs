namespace PiratasCostaRica.Formularios
{
    partial class FormPrincipal
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
            this.buttonGcliente = new System.Windows.Forms.Button();
            this.buttonGruta = new System.Windows.Forms.Button();
            this.buttonGservice = new System.Windows.Forms.Button();
            this.buttonGconductor = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGcliente
            // 
            this.buttonGcliente.Location = new System.Drawing.Point(148, 99);
            this.buttonGcliente.Name = "buttonGcliente";
            this.buttonGcliente.Size = new System.Drawing.Size(121, 23);
            this.buttonGcliente.TabIndex = 0;
            this.buttonGcliente.Text = "Gestion Cliente";
            this.buttonGcliente.UseVisualStyleBackColor = true;
            // 
            // buttonGruta
            // 
            this.buttonGruta.Location = new System.Drawing.Point(148, 154);
            this.buttonGruta.Name = "buttonGruta";
            this.buttonGruta.Size = new System.Drawing.Size(121, 23);
            this.buttonGruta.TabIndex = 1;
            this.buttonGruta.Text = "Gestion Ruta";
            this.buttonGruta.UseVisualStyleBackColor = true;
            // 
            // buttonGservice
            // 
            this.buttonGservice.Location = new System.Drawing.Point(148, 215);
            this.buttonGservice.Name = "buttonGservice";
            this.buttonGservice.Size = new System.Drawing.Size(121, 23);
            this.buttonGservice.TabIndex = 2;
            this.buttonGservice.Text = "Gestion Servicio";
            this.buttonGservice.UseVisualStyleBackColor = true;
            // 
            // buttonGconductor
            // 
            this.buttonGconductor.Location = new System.Drawing.Point(148, 274);
            this.buttonGconductor.Name = "buttonGconductor";
            this.buttonGconductor.Size = new System.Drawing.Size(121, 23);
            this.buttonGconductor.TabIndex = 3;
            this.buttonGconductor.Text = "Gestion Conductor";
            this.buttonGconductor.UseVisualStyleBackColor = true;
            // 
            // buttonlogout
            // 
            this.buttonlogout.Location = new System.Drawing.Point(262, 29);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(121, 23);
            this.buttonlogout.TabIndex = 4;
            this.buttonlogout.Text = "Cerrar sesión";
            this.buttonlogout.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonGconductor);
            this.Controls.Add(this.buttonGservice);
            this.Controls.Add(this.buttonGruta);
            this.Controls.Add(this.buttonGcliente);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGcliente;
        private System.Windows.Forms.Button buttonGruta;
        private System.Windows.Forms.Button buttonGservice;
        private System.Windows.Forms.Button buttonGconductor;
        private System.Windows.Forms.Button buttonlogout;
    }
}