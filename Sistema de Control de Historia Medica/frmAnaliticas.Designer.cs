﻿namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmAnaliticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaliticas));
            this.dgvAnaliticas = new System.Windows.Forms.DataGridView();
            this.gbDetalleAnalitica = new System.Windows.Forms.GroupBox();
            this.txtTipoAnalitica = new System.Windows.Forms.TextBox();
            this.txtPropositoAnalitica = new System.Windows.Forms.TextBox();
            this.pdfVisorAnalitica = new AxAcroPDFLib.AxAcroPDF();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarAnalitica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliticas)).BeginInit();
            this.gbDetalleAnalitica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisorAnalitica)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnaliticas
            // 
            this.dgvAnaliticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnaliticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAnaliticas.Location = new System.Drawing.Point(0, 53);
            this.dgvAnaliticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAnaliticas.Name = "dgvAnaliticas";
            this.dgvAnaliticas.RowHeadersWidth = 51;
            this.dgvAnaliticas.RowTemplate.Height = 24;
            this.dgvAnaliticas.Size = new System.Drawing.Size(638, 129);
            this.dgvAnaliticas.TabIndex = 0;
            // 
            // gbDetalleAnalitica
            // 
            this.gbDetalleAnalitica.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalleAnalitica.Controls.Add(this.panel2);
            this.gbDetalleAnalitica.Controls.Add(this.pdfVisorAnalitica);
            this.gbDetalleAnalitica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDetalleAnalitica.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleAnalitica.Location = new System.Drawing.Point(0, 197);
            this.gbDetalleAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDetalleAnalitica.Name = "gbDetalleAnalitica";
            this.gbDetalleAnalitica.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDetalleAnalitica.Size = new System.Drawing.Size(638, 417);
            this.gbDetalleAnalitica.TabIndex = 1;
            this.gbDetalleAnalitica.TabStop = false;
            this.gbDetalleAnalitica.Text = "Detalle de la analítica";
            // 
            // txtTipoAnalitica
            // 
            this.txtTipoAnalitica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipoAnalitica.Enabled = false;
            this.txtTipoAnalitica.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnalitica.Location = new System.Drawing.Point(419, 18);
            this.txtTipoAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipoAnalitica.Multiline = true;
            this.txtTipoAnalitica.Name = "txtTipoAnalitica";
            this.txtTipoAnalitica.Size = new System.Drawing.Size(198, 23);
            this.txtTipoAnalitica.TabIndex = 13;
            // 
            // txtPropositoAnalitica
            // 
            this.txtPropositoAnalitica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPropositoAnalitica.Enabled = false;
            this.txtPropositoAnalitica.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropositoAnalitica.Location = new System.Drawing.Point(185, 53);
            this.txtPropositoAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPropositoAnalitica.Multiline = true;
            this.txtPropositoAnalitica.Name = "txtPropositoAnalitica";
            this.txtPropositoAnalitica.Size = new System.Drawing.Size(432, 23);
            this.txtPropositoAnalitica.TabIndex = 12;
            // 
            // pdfVisorAnalitica
            // 
            this.pdfVisorAnalitica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdfVisorAnalitica.Enabled = true;
            this.pdfVisorAnalitica.Location = new System.Drawing.Point(2, 172);
            this.pdfVisorAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pdfVisorAnalitica.Name = "pdfVisorAnalitica";
            this.pdfVisorAnalitica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfVisorAnalitica.OcxState")));
            this.pdfVisorAnalitica.Size = new System.Drawing.Size(634, 243);
            this.pdfVisorAnalitica.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(136, 88);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(481, 49);
            this.txtObservaciones.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(140, 19);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(138, 23);
            this.dtpFecha.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Propósito del análisis";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de analítica";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(48, 22);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de analíticas";
            // 
            // btnRegistrarAnalitica
            // 
            this.btnRegistrarAnalitica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarAnalitica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnRegistrarAnalitica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAnalitica.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAnalitica.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAnalitica.Location = new System.Drawing.Point(310, 13);
            this.btnRegistrarAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarAnalitica.Name = "btnRegistrarAnalitica";
            this.btnRegistrarAnalitica.Size = new System.Drawing.Size(312, 30);
            this.btnRegistrarAnalitica.TabIndex = 3;
            this.btnRegistrarAnalitica.Text = "Registrar nueva analítica";
            this.btnRegistrarAnalitica.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegistrarAnalitica);
            this.panel1.Controls.Add(this.dgvAnaliticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 182);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTipoAnalitica);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPropositoAnalitica);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(2, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 156);
            this.panel2.TabIndex = 30;
            // 
            // frmAnaliticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(638, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDetalleAnalitica);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "frmAnaliticas";
            this.Text = "Registro de Analíticas";
            this.Load += new System.EventHandler(this.frmAnaliticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliticas)).EndInit();
            this.gbDetalleAnalitica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisorAnalitica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnaliticas;
        private System.Windows.Forms.GroupBox gbDetalleAnalitica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarAnalitica;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private AxAcroPDFLib.AxAcroPDF pdfVisorAnalitica;
        private System.Windows.Forms.TextBox txtPropositoAnalitica;
        private System.Windows.Forms.TextBox txtTipoAnalitica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}