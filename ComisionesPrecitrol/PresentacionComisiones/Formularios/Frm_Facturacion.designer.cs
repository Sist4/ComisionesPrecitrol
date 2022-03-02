namespace Sistemas_Precitrol.Formularios
{
    partial class Frm_Facturacion
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.txtHoja2 = new System.Windows.Forms.TextBox();
            this.dataGridview2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(920, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "Guardar Informacion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cargar Informacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(59, 124);
            this.txtArchivo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.Size = new System.Drawing.Size(323, 22);
            this.txtArchivo2.TabIndex = 11;
            this.txtArchivo2.Visible = false;
            // 
            // txtHoja2
            // 
            this.txtHoja2.Location = new System.Drawing.Point(390, 124);
            this.txtHoja2.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoja2.Name = "txtHoja2";
            this.txtHoja2.Size = new System.Drawing.Size(220, 22);
            this.txtHoja2.TabIndex = 10;
            this.txtHoja2.Text = "Sheet1";
            this.txtHoja2.Visible = false;
            // 
            // dataGridview2
            // 
            this.dataGridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview2.Location = new System.Drawing.Point(29, 154);
            this.dataGridview2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridview2.Name = "dataGridview2";
            this.dataGridview2.Size = new System.Drawing.Size(1193, 363);
            this.dataGridview2.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 82);
            this.panel2.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrecentacionComisiones.Properties.Resources.recepcion;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACION";
            // 
            // Frm_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1247, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.txtHoja2);
            this.Controls.Add(this.dataGridview2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Facturacion";
            this.Text = "Frm_Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.TextBox txtHoja2;
        private System.Windows.Forms.DataGridView dataGridview2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

    }
}