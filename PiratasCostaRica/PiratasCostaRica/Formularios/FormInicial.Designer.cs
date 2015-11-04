namespace PiratasCostaRica.Formularios
{
    partial class FormInicial
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
            this.textuserlog = new System.Windows.Forms.TextBox();
            this.textpasslog = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonregistrolog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // textuserlog
            // 
            this.textuserlog.Location = new System.Drawing.Point(102, 167);
            this.textuserlog.Name = "textuserlog";
            this.textuserlog.Size = new System.Drawing.Size(193, 20);
            this.textuserlog.TabIndex = 2;
            // 
            // textpasslog
            // 
            this.textpasslog.Location = new System.Drawing.Point(102, 242);
            this.textpasslog.Name = "textpasslog";
            this.textpasslog.Size = new System.Drawing.Size(193, 20);
            this.textpasslog.TabIndex = 3;
            // 
            // buttonlogin
            // 
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlogin.Location = new System.Drawing.Point(149, 293);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(96, 23);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "Iniciar sesión";
            this.buttonlogin.UseVisualStyleBackColor = true;
            // 
            // buttonregistrolog
            // 
            this.buttonregistrolog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonregistrolog.Location = new System.Drawing.Point(281, 27);
            this.buttonregistrolog.Name = "buttonregistrolog";
            this.buttonregistrolog.Size = new System.Drawing.Size(97, 23);
            this.buttonregistrolog.TabIndex = 5;
            this.buttonregistrolog.Text = "Registrarse";
            this.buttonregistrolog.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.buttonregistrolog);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textpasslog);
            this.Controls.Add(this.textuserlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuserlog;
        private System.Windows.Forms.TextBox textpasslog;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonregistrolog;
    }
}