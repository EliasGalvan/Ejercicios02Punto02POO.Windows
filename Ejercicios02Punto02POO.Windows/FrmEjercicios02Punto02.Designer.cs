
namespace Ejercicios02Punto02POO.Windows
{
    partial class FrmEjercicios02Punto02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlturaTextBox = new System.Windows.Forms.TextBox();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.GeneratrizTextBox = new System.Windows.Forms.TextBox();
            this.SalirButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la altura del cono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el radio de giro del cono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la generatriz del cono";
            // 
            // AlturaTextBox
            // 
            this.AlturaTextBox.Location = new System.Drawing.Point(372, 97);
            this.AlturaTextBox.Name = "AlturaTextBox";
            this.AlturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlturaTextBox.TabIndex = 3;
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(372, 147);
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadioTextBox.TabIndex = 3;
            // 
            // GeneratrizTextBox
            // 
            this.GeneratrizTextBox.Location = new System.Drawing.Point(372, 47);
            this.GeneratrizTextBox.Name = "GeneratrizTextBox";
            this.GeneratrizTextBox.Size = new System.Drawing.Size(100, 20);
            this.GeneratrizTextBox.TabIndex = 3;
            // 
            // SalirButton
            // 
            this.SalirButton.Image = global::Ejercicios02Punto02POO.Windows.Properties.Resources.icons8_exit_26px;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalirButton.Location = new System.Drawing.Point(702, 395);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(86, 43);
            this.SalirButton.TabIndex = 4;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::Ejercicios02Punto02POO.Windows.Properties.Resources.icons8_unavailable_24px;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(555, 242);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(86, 43);
            this.CancelarButton.TabIndex = 4;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Image = global::Ejercicios02Punto02POO.Windows.Properties.Resources.icons8_tick_box_30px;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.Location = new System.Drawing.Point(372, 242);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(87, 43);
            this.AceptarButton.TabIndex = 4;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // FrmEjercicios02Punto02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.GeneratrizTextBox);
            this.Controls.Add(this.RadioTextBox);
            this.Controls.Add(this.AlturaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmEjercicios02Punto02";
            this.Text = "CALCULO DEL ÁREA Y VOLUMEN DE UN CONO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlturaTextBox;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.TextBox GeneratrizTextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SalirButton;
    }
}

