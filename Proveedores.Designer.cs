namespace WindowsFormsApplication1.pantallas
{
    partial class Proveedores : Form1
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
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblcostmin = new System.Windows.Forms.Label();
            this.txtcostmi = new System.Windows.Forms.TextBox();
            this.lblcostma = new System.Windows.Forms.Label();
            this.txtcostma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.grwconsulta = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.lblvar = new System.Windows.Forms.Label();
            this.txtvar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grwconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(56, 181);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(63, 13);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Descripcion";
            // 
            // lblcostmin
            // 
            this.lblcostmin.AutoSize = true;
            this.lblcostmin.Location = new System.Drawing.Point(56, 250);
            this.lblcostmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcostmin.Name = "lblcostmin";
            this.lblcostmin.Size = new System.Drawing.Size(56, 13);
            this.lblcostmin.TabIndex = 5;
            this.lblcostmin.Text = "Costo min:";
            // 
            // txtcostmi
            // 
            this.txtcostmi.Location = new System.Drawing.Point(133, 250);
            this.txtcostmi.Margin = new System.Windows.Forms.Padding(2);
            this.txtcostmi.Name = "txtcostmi";
            this.txtcostmi.Size = new System.Drawing.Size(125, 20);
            this.txtcostmi.TabIndex = 6;
            // 
            // lblcostma
            // 
            this.lblcostma.AutoSize = true;
            this.lblcostma.Location = new System.Drawing.Point(56, 284);
            this.lblcostma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcostma.Name = "lblcostma";
            this.lblcostma.Size = new System.Drawing.Size(59, 13);
            this.lblcostma.TabIndex = 7;
            this.lblcostma.Text = "Costo max:";
            // 
            // txtcostma
            // 
            this.txtcostma.Location = new System.Drawing.Point(133, 284);
            this.txtcostma.Margin = new System.Windows.Forms.Padding(2);
            this.txtcostma.Name = "txtcostma";
            this.txtcostma.Size = new System.Drawing.Size(125, 20);
            this.txtcostma.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo:";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(133, 216);
            this.txtcod.Margin = new System.Windows.Forms.Padding(2);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(198, 20);
            this.txtcod.TabIndex = 10;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(133, 180);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(362, 20);
            this.txtdesc.TabIndex = 2;
            // 
            // grwconsulta
            // 
            this.grwconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grwconsulta.Location = new System.Drawing.Point(59, 401);
            this.grwconsulta.Margin = new System.Windows.Forms.Padding(2);
            this.grwconsulta.Name = "grwconsulta";
            this.grwconsulta.RowTemplate.Height = 24;
            this.grwconsulta.Size = new System.Drawing.Size(955, 234);
            this.grwconsulta.TabIndex = 11;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(133, 355);
            this.btnconsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(102, 24);
            this.btnconsultar.TabIndex = 12;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // lblvar
            // 
            this.lblvar.AutoSize = true;
            this.lblvar.Location = new System.Drawing.Point(57, 318);
            this.lblvar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvar.Name = "lblvar";
            this.lblvar.Size = new System.Drawing.Size(55, 13);
            this.lblvar.TabIndex = 13;
            this.lblvar.Text = "Costo var:";
            // 
            // txtvar
            // 
            this.txtvar.Location = new System.Drawing.Point(133, 318);
            this.txtvar.Margin = new System.Windows.Forms.Padding(2);
            this.txtvar.Name = "txtvar";
            this.txtvar.Size = new System.Drawing.Size(125, 20);
            this.txtvar.TabIndex = 14;
            this.txtvar.Text = "0";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 808);
            this.Controls.Add(this.txtvar);
            this.Controls.Add(this.lblvar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.grwconsulta);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcostma);
            this.Controls.Add(this.lblcostma);
            this.Controls.Add(this.txtcostmi);
            this.Controls.Add(this.lblcostmin);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lbldesc);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.Controls.SetChildIndex(this.lbldesc, 0);
            this.Controls.SetChildIndex(this.txtdesc, 0);
            this.Controls.SetChildIndex(this.lblcostmin, 0);
            this.Controls.SetChildIndex(this.txtcostmi, 0);
            this.Controls.SetChildIndex(this.lblcostma, 0);
            this.Controls.SetChildIndex(this.txtcostma, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtcod, 0);
            this.Controls.SetChildIndex(this.grwconsulta, 0);
            this.Controls.SetChildIndex(this.btnconsultar, 0);
            this.Controls.SetChildIndex(this.lblvar, 0);
            this.Controls.SetChildIndex(this.txtvar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grwconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblcostmin;
        private System.Windows.Forms.TextBox txtcostmi;
        private System.Windows.Forms.Label lblcostma;
        private System.Windows.Forms.TextBox txtcostma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.DataGridView grwconsulta;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label lblvar;
        private System.Windows.Forms.TextBox txtvar;

    }
}