﻿
namespace CapaVistaNomina
{
    partial class PrestacionesDeducciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvalorfijo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttipoprestaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreprestaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDprestaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPer = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 44);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestaciones Y Deducciones";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtestado);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtvalorfijo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtporcentaje);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txttipoprestaciones);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtnombreprestaciones);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIDprestaciones);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridPer);
            this.panel2.Location = new System.Drawing.Point(34, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 372);
            this.panel2.TabIndex = 2;
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtestado.Location = new System.Drawing.Point(128, 257);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(80, 22);
            this.txtestado.TabIndex = 18;
            this.txtestado.Tag = "estado_prestdeduc";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(64, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(16, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado";
            // 
            // txtvalorfijo
            // 
            this.txtvalorfijo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtvalorfijo.Location = new System.Drawing.Point(16, 216);
            this.txtvalorfijo.Name = "txtvalorfijo";
            this.txtvalorfijo.Size = new System.Drawing.Size(192, 22);
            this.txtvalorfijo.TabIndex = 12;
            this.txtvalorfijo.Tag = "valorFijo_prestdeduc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(16, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Tag = "";
            this.label6.Text = "Valor Fijo";
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtporcentaje.Location = new System.Drawing.Point(16, 168);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(192, 22);
            this.txtporcentaje.TabIndex = 13;
            this.txtporcentaje.Tag = "porcentaje_prestdeduc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Tag = "";
            this.label5.Text = "Porcentaje";
            // 
            // txttipoprestaciones
            // 
            this.txttipoprestaciones.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txttipoprestaciones.Location = new System.Drawing.Point(16, 120);
            this.txttipoprestaciones.Name = "txttipoprestaciones";
            this.txttipoprestaciones.Size = new System.Drawing.Size(192, 22);
            this.txttipoprestaciones.TabIndex = 14;
            this.txttipoprestaciones.Tag = "tipo_prestdeduc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 9;
            this.label4.Tag = "";
            this.label4.Text = "Tipo Prestacion Y Dedu.";
            // 
            // txtnombreprestaciones
            // 
            this.txtnombreprestaciones.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtnombreprestaciones.Location = new System.Drawing.Point(16, 72);
            this.txtnombreprestaciones.Name = "txtnombreprestaciones";
            this.txtnombreprestaciones.Size = new System.Drawing.Size(192, 22);
            this.txtnombreprestaciones.TabIndex = 15;
            this.txtnombreprestaciones.Tag = "nombre_prestdeduc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Prestacion Y Dedu.";
            // 
            // txtIDprestaciones
            // 
            this.txtIDprestaciones.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtIDprestaciones.Location = new System.Drawing.Point(16, 24);
            this.txtIDprestaciones.Name = "txtIDprestaciones";
            this.txtIDprestaciones.Size = new System.Drawing.Size(192, 22);
            this.txtIDprestaciones.TabIndex = 5;
            this.txtIDprestaciones.Tag = "pk_id_prestdeduc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Prestaciones Y Deducciones";
            // 
            // dataGridPer
            // 
            this.dataGridPer.AllowUserToAddRows = false;
            this.dataGridPer.AllowUserToDeleteRows = false;
            this.dataGridPer.AllowUserToResizeColumns = false;
            this.dataGridPer.AllowUserToResizeRows = false;
            this.dataGridPer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPer.Location = new System.Drawing.Point(240, 16);
            this.dataGridPer.MultiSelect = false;
            this.dataGridPer.Name = "dataGridPer";
            this.dataGridPer.ReadOnly = true;
            this.dataGridPer.RowHeadersVisible = false;
            this.dataGridPer.RowHeadersWidth = 51;
            this.dataGridPer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridPer.ShowEditingIcon = false;
            this.dataGridPer.Size = new System.Drawing.Size(464, 349);
            this.dataGridPer.TabIndex = 0;
            this.dataGridPer.Tag = "tbl_percepciones";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(98, 50);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 3;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // PrestacionesDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrestacionesDeducciones";
            this.Text = "PrestacionesDeducciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvalorfijo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttipoprestaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombreprestaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDprestaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPer;
        private NavegadorVista.Navegador navegador1;
    }
}