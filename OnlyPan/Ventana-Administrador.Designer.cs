
namespace OnlyPan
{
    partial class Ventana_Administrador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbEmpleados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(107, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido Administrador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lista de Empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbEmpleados
            // 
            this.rtbEmpleados.BackColor = System.Drawing.Color.Wheat;
            this.rtbEmpleados.Location = new System.Drawing.Point(12, 72);
            this.rtbEmpleados.Name = "rtbEmpleados";
            this.rtbEmpleados.Size = new System.Drawing.Size(118, 139);
            this.rtbEmpleados.TabIndex = 5;
            this.rtbEmpleados.Text = "";
            // 
            // Ventana_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(461, 275);
            this.Controls.Add(this.rtbEmpleados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ventana_Administrador";
            this.Text = "Ventana_Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbEmpleados;
    }
}