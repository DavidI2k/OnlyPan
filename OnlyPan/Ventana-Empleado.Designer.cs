
namespace OnlyPan
{
    partial class Ventana_Empleado
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
            this.lblPanAli = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblPanNali = new System.Windows.Forms.Label();
            this.lblPanEsp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPanAli
            // 
            this.lblPanAli.AutoSize = true;
            this.lblPanAli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanAli.Location = new System.Drawing.Point(160, 45);
            this.lblPanAli.Name = "lblPanAli";
            this.lblPanAli.Size = new System.Drawing.Size(140, 16);
            this.lblPanAli.TabIndex = 0;
            this.lblPanAli.Text = "Pan Aliñado: 1000$";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(667, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblPanNali
            // 
            this.lblPanNali.AutoSize = true;
            this.lblPanNali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanNali.Location = new System.Drawing.Point(160, 88);
            this.lblPanNali.Name = "lblPanNali";
            this.lblPanNali.Size = new System.Drawing.Size(156, 16);
            this.lblPanNali.TabIndex = 2;
            this.lblPanNali.Text = "Pan No Aliñado: 500$";
            // 
            // lblPanEsp
            // 
            this.lblPanEsp.AutoSize = true;
            this.lblPanEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanEsp.Location = new System.Drawing.Point(160, 132);
            this.lblPanEsp.Name = "lblPanEsp";
            this.lblPanEsp.Size = new System.Drawing.Size(148, 16);
            this.lblPanEsp.TabIndex = 3;
            this.lblPanEsp.Text = "Pan Especial: 2000$";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(27, 9);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(126, 13);
            this.lblCant.TabIndex = 7;
            this.lblCant.Text = "Ingrese cantidad a llevar:";
            // 
            // Ventana_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPanEsp);
            this.Controls.Add(this.lblPanNali);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblPanAli);
            this.Name = "Ventana_Empleado";
            this.Text = "Ventana_Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPanAli;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblPanNali;
        private System.Windows.Forms.Label lblPanEsp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCant;
    }
}