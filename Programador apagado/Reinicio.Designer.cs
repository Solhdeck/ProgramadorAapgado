namespace Programador_apagado
{
    partial class Reinicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Horas1 = new System.Windows.Forms.Button();
            this.Bt_30m = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Manual = new System.Windows.Forms.Button();
            this.Bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Horas1
            // 
            this.Horas1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horas1.Location = new System.Drawing.Point(12, 12);
            this.Horas1.Name = "Horas1";
            this.Horas1.Size = new System.Drawing.Size(167, 101);
            this.Horas1.TabIndex = 0;
            this.Horas1.Text = "1h";
            this.Horas1.UseVisualStyleBackColor = true;
            this.Horas1.Click += new System.EventHandler(this.Horas1_Click);
            // 
            // Bt_30m
            // 
            this.Bt_30m.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_30m.Location = new System.Drawing.Point(185, 12);
            this.Bt_30m.Name = "Bt_30m";
            this.Bt_30m.Size = new System.Drawing.Size(187, 101);
            this.Bt_30m.TabIndex = 1;
            this.Bt_30m.Text = "30m";
            this.Bt_30m.UseVisualStyleBackColor = true;
            this.Bt_30m.Click += new System.EventHandler(this.Bt_30m_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(103, 119);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 85);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "00";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 118);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 85);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "1";
            // 
            // Manual
            // 
            this.Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.Location = new System.Drawing.Point(206, 125);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(152, 78);
            this.Manual.TabIndex = 6;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // Bt_cancel
            // 
            this.Bt_cancel.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_cancel.Location = new System.Drawing.Point(61, 215);
            this.Bt_cancel.Name = "Bt_cancel";
            this.Bt_cancel.Size = new System.Drawing.Size(249, 66);
            this.Bt_cancel.TabIndex = 7;
            this.Bt_cancel.Text = "Cancelar";
            this.Bt_cancel.UseVisualStyleBackColor = true;
            this.Bt_cancel.Click += new System.EventHandler(this.Bt_cancel_Click);
            // 
            // Reinicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 293);
            this.Controls.Add(this.Bt_cancel);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_30m);
            this.Controls.Add(this.Horas1);
            this.Name = "Reinicio";
            this.Text = "Programar reinicio";
            this.Load += new System.EventHandler(this.Reinicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Horas1;
        private System.Windows.Forms.Button Bt_30m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Manual;
        private System.Windows.Forms.Button Bt_cancel;
    }
}

