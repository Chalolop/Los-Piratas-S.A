namespace PiratasCostaRica.Formularios
{
    partial class FormCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.textCced = new System.Windows.Forms.TextBox();
            this.textCnom = new System.Windows.Forms.TextBox();
            this.textCedad = new System.Windows.Forms.TextBox();
            this.textCap = new System.Windows.Forms.TextBox();
            this.buttonCbuscar = new System.Windows.Forms.Button();
            this.buttonCadd = new System.Windows.Forms.Button();
            this.buttonCupdate = new System.Windows.Forms.Button();
            this.buttonCInhabilitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // textCced
            // 
            this.textCced.Location = new System.Drawing.Point(143, 45);
            this.textCced.Name = "textCced";
            this.textCced.Size = new System.Drawing.Size(134, 20);
            this.textCced.TabIndex = 5;
            // 
            // textCnom
            // 
            this.textCnom.Location = new System.Drawing.Point(143, 100);
            this.textCnom.Name = "textCnom";
            this.textCnom.Size = new System.Drawing.Size(134, 20);
            this.textCnom.TabIndex = 6;
            // 
            // textCedad
            // 
            this.textCedad.Location = new System.Drawing.Point(143, 179);
            this.textCedad.Name = "textCedad";
            this.textCedad.Size = new System.Drawing.Size(134, 20);
            this.textCedad.TabIndex = 7;
            // 
            // textCap
            // 
            this.textCap.Location = new System.Drawing.Point(143, 141);
            this.textCap.Name = "textCap";
            this.textCap.Size = new System.Drawing.Size(134, 20);
            this.textCap.TabIndex = 8;
            // 
            // buttonCbuscar
            // 
            this.buttonCbuscar.Location = new System.Drawing.Point(305, 42);
            this.buttonCbuscar.Name = "buttonCbuscar";
            this.buttonCbuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonCbuscar.TabIndex = 9;
            this.buttonCbuscar.Text = "Buscar";
            this.buttonCbuscar.UseVisualStyleBackColor = true;
            // 
            // buttonCadd
            // 
            this.buttonCadd.Location = new System.Drawing.Point(46, 284);
            this.buttonCadd.Name = "buttonCadd";
            this.buttonCadd.Size = new System.Drawing.Size(75, 23);
            this.buttonCadd.TabIndex = 10;
            this.buttonCadd.Text = "Agregar";
            this.buttonCadd.UseVisualStyleBackColor = true;
            // 
            // buttonCupdate
            // 
            this.buttonCupdate.Location = new System.Drawing.Point(168, 284);
            this.buttonCupdate.Name = "buttonCupdate";
            this.buttonCupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonCupdate.TabIndex = 11;
            this.buttonCupdate.Text = "Actualizar";
            this.buttonCupdate.UseVisualStyleBackColor = true;
            // 
            // buttonCInhabilitar
            // 
            this.buttonCInhabilitar.Location = new System.Drawing.Point(287, 284);
            this.buttonCInhabilitar.Name = "buttonCInhabilitar";
            this.buttonCInhabilitar.Size = new System.Drawing.Size(75, 23);
            this.buttonCInhabilitar.TabIndex = 12;
            this.buttonCInhabilitar.Text = "Inhabilitar";
            this.buttonCInhabilitar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.buttonCInhabilitar);
            this.Controls.Add(this.buttonCupdate);
            this.Controls.Add(this.buttonCadd);
            this.Controls.Add(this.buttonCbuscar);
            this.Controls.Add(this.textCap);
            this.Controls.Add(this.textCedad);
            this.Controls.Add(this.textCnom);
            this.Controls.Add(this.textCced);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCced;
        private System.Windows.Forms.TextBox textCnom;
        private System.Windows.Forms.TextBox textCedad;
        private System.Windows.Forms.TextBox textCap;
        private System.Windows.Forms.Button buttonCbuscar;
        private System.Windows.Forms.Button buttonCadd;
        private System.Windows.Forms.Button buttonCupdate;
        private System.Windows.Forms.Button buttonCInhabilitar;
    }
}