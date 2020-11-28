using System;

namespace SisVendas
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaCli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListaMerc = new System.Windows.Forms.Button();
            this.btnListPed = new System.Windows.Forms.Button();
            this.btnMerc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPedido.Location = new System.Drawing.Point(12, 169);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(206, 23);
            this.btnPedido.TabIndex = 1;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCliente.Location = new System.Drawing.Point(12, 111);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(206, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(90, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnListaCli
            // 
            this.btnListaCli.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListaCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaCli.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListaCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCli.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListaCli.Location = new System.Drawing.Point(12, 247);
            this.btnListaCli.Name = "btnListaCli";
            this.btnListaCli.Size = new System.Drawing.Size(206, 23);
            this.btnListaCli.TabIndex = 6;
            this.btnListaCli.Text = "Listar Clientes";
            this.btnListaCli.UseVisualStyleBackColor = false;
            this.btnListaCli.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisVendas.Properties.Resources._64_64;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 57);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(90, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Relatórios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnListaMerc
            // 
            this.btnListaMerc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListaMerc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaMerc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaMerc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListaMerc.Location = new System.Drawing.Point(12, 277);
            this.btnListaMerc.Name = "btnListaMerc";
            this.btnListaMerc.Size = new System.Drawing.Size(206, 23);
            this.btnListaMerc.TabIndex = 8;
            this.btnListaMerc.Text = "Listar Mercadorias";
            this.btnListaMerc.UseVisualStyleBackColor = false;
            this.btnListaMerc.Click += new System.EventHandler(this.btnListaMerc_Click);
            // 
            // btnListPed
            // 
            this.btnListPed.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListPed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListPed.Location = new System.Drawing.Point(12, 308);
            this.btnListPed.Name = "btnListPed";
            this.btnListPed.Size = new System.Drawing.Size(206, 23);
            this.btnListPed.TabIndex = 9;
            this.btnListPed.Text = "Listar Pedidos";
            this.btnListPed.UseVisualStyleBackColor = false;
            this.btnListPed.Click += new System.EventHandler(this.btnListPed_Click);
            // 
            // btnMerc
            // 
            this.btnMerc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMerc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMerc.Location = new System.Drawing.Point(12, 140);
            this.btnMerc.Name = "btnMerc";
            this.btnMerc.Size = new System.Drawing.Size(206, 23);
            this.btnMerc.TabIndex = 13;
            this.btnMerc.Text = "Mercadoria";
            this.btnMerc.UseVisualStyleBackColor = false;
            this.btnMerc.Click += new System.EventHandler(this.btnMerc_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(231, 350);
            this.Controls.Add(this.btnMerc);
            this.Controls.Add(this.btnListPed);
            this.Controls.Add(this.btnListaMerc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListaCli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPedido);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "SysBee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListaCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListaMerc;
        private System.Windows.Forms.Button btnListPed;
        private System.Windows.Forms.Button btnMerc;
    }
}

