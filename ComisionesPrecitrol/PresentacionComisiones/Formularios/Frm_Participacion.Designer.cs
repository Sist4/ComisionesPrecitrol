namespace PrecentacionComisiones.Formularios
{
    partial class Frm_Participacion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.txtHoja2 = new System.Windows.Forms.TextBox();
            this.dataGridview2 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtArchivo2);
            this.panel2.Controls.Add(this.txtHoja2);
            this.panel2.Controls.Add(this.dataGridview2);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 492);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1165, 439);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Guardar Informacion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1149, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cargar Informacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(5, 18);
            this.txtArchivo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.Size = new System.Drawing.Size(323, 22);
            this.txtArchivo2.TabIndex = 6;
            // 
            // txtHoja2
            // 
            this.txtHoja2.Location = new System.Drawing.Point(337, 18);
            this.txtHoja2.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoja2.Name = "txtHoja2";
            this.txtHoja2.Size = new System.Drawing.Size(220, 22);
            this.txtHoja2.TabIndex = 5;
            this.txtHoja2.Text = "Sheet1";
            // 
            // dataGridview2
            // 
            this.dataGridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview2.Location = new System.Drawing.Point(5, 64);
            this.dataGridview2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridview2.Name = "dataGridview2";
            this.dataGridview2.Size = new System.Drawing.Size(1335, 368);
            this.dataGridview2.TabIndex = 1;
            // 
            // Frm_Participacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1417, 647);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Participacion";
            this.Text = "Frm_Participacion";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.TextBox txtHoja2;
        private System.Windows.Forms.DataGridView dataGridview2;
    }
}