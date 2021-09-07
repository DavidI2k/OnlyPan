
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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Nombre:");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Cédula:");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Pan Aliñado:");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Pan No Aliñado:");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Pan Especial:");
            this.lblPanAli = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblPanNali = new System.Windows.Forms.Label();
            this.lblPanEsp = new System.Windows.Forms.Label();
            this.txtPali = new System.Windows.Forms.TextBox();
            this.txtPnoali = new System.Windows.Forms.TextBox();
            this.txtPesp = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtNcliente = new System.Windows.Forms.TextBox();
            this.lblCedulaC = new System.Windows.Forms.Label();
            this.textCecliente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaComp = new System.Windows.Forms.DateTimePicker();
            this.btnVender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPanAli
            // 
            this.lblPanAli.AutoSize = true;
            this.lblPanAli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanAli.Location = new System.Drawing.Point(93, 48);
            this.lblPanAli.Name = "lblPanAli";
            this.lblPanAli.Size = new System.Drawing.Size(140, 16);
            this.lblPanAli.TabIndex = 0;
            this.lblPanAli.Text = "Pan Aliñado: 1000$";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.listView1.Location = new System.Drawing.Point(30, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 112);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblPanNali
            // 
            this.lblPanNali.AutoSize = true;
            this.lblPanNali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanNali.Location = new System.Drawing.Point(93, 91);
            this.lblPanNali.Name = "lblPanNali";
            this.lblPanNali.Size = new System.Drawing.Size(156, 16);
            this.lblPanNali.TabIndex = 2;
            this.lblPanNali.Text = "Pan No Aliñado: 500$";
            // 
            // lblPanEsp
            // 
            this.lblPanEsp.AutoSize = true;
            this.lblPanEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanEsp.Location = new System.Drawing.Point(93, 135);
            this.lblPanEsp.Name = "lblPanEsp";
            this.lblPanEsp.Size = new System.Drawing.Size(148, 16);
            this.lblPanEsp.TabIndex = 3;
            this.lblPanEsp.Text = "Pan Especial: 2000$";
            // 
            // txtPali
            // 
            this.txtPali.Location = new System.Drawing.Point(30, 44);
            this.txtPali.Name = "txtPali";
            this.txtPali.Size = new System.Drawing.Size(42, 20);
            this.txtPali.TabIndex = 4;
            this.txtPali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPnoali
            // 
            this.txtPnoali.Location = new System.Drawing.Point(30, 87);
            this.txtPnoali.Name = "txtPnoali";
            this.txtPnoali.Size = new System.Drawing.Size(42, 20);
            this.txtPnoali.TabIndex = 5;
            this.txtPnoali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesp
            // 
            this.txtPesp.Location = new System.Drawing.Point(30, 131);
            this.txtPesp.Name = "txtPesp";
            this.txtPesp.Size = new System.Drawing.Size(42, 20);
            this.txtPesp.TabIndex = 6;
            this.txtPesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.ForeColor = System.Drawing.Color.Red;
            this.lblTot.Location = new System.Drawing.Point(27, 194);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(37, 15);
            this.lblTot.TabIndex = 8;
            this.lblTot.Text = "Total:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(340, 9);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(145, 16);
            this.lblNombreC.TabIndex = 9;
            this.lblNombreC.Text = "Nombre del Cliente:";
            // 
            // txtNcliente
            // 
            this.txtNcliente.Location = new System.Drawing.Point(343, 44);
            this.txtNcliente.Name = "txtNcliente";
            this.txtNcliente.Size = new System.Drawing.Size(142, 20);
            this.txtNcliente.TabIndex = 10;
            // 
            // lblCedulaC
            // 
            this.lblCedulaC.AutoSize = true;
            this.lblCedulaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaC.Location = new System.Drawing.Point(340, 87);
            this.lblCedulaC.Name = "lblCedulaC";
            this.lblCedulaC.Size = new System.Drawing.Size(139, 16);
            this.lblCedulaC.TabIndex = 11;
            this.lblCedulaC.Text = "Cédula del Cliente:";
            // 
            // textCecliente
            // 
            this.textCecliente.Location = new System.Drawing.Point(343, 117);
            this.textCecliente.Name = "textCecliente";
            this.textCecliente.Size = new System.Drawing.Size(142, 20);
            this.textCecliente.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(340, 160);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 16);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaComp
            // 
            this.dtpFechaComp.Location = new System.Drawing.Point(323, 189);
            this.dtpFechaComp.Name = "dtpFechaComp";
            this.dtpFechaComp.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaComp.TabIndex = 14;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(238, 261);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 15;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // Ventana_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.dtpFechaComp);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.textCecliente);
            this.Controls.Add(this.lblCedulaC);
            this.Controls.Add(this.txtNcliente);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.txtPesp);
            this.Controls.Add(this.txtPnoali);
            this.Controls.Add(this.txtPali);
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
        private System.Windows.Forms.TextBox txtPali;
        private System.Windows.Forms.TextBox txtPnoali;
        private System.Windows.Forms.TextBox txtPesp;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox txtNcliente;
        private System.Windows.Forms.Label lblCedulaC;
        private System.Windows.Forms.TextBox textCecliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaComp;
        private System.Windows.Forms.Button btnVender;
    }
}