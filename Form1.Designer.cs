
namespace SaludosBotones_MDQS
{
    partial class Form1
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
            this.btnMario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMario
            // 
            this.btnMario.Location = new System.Drawing.Point(325, 142);
            this.btnMario.Name = "btnMario";
            this.btnMario.Size = new System.Drawing.Size(135, 106);
            this.btnMario.TabIndex = 0;
            this.btnMario.Text = "Hola, soy Mario";
            this.btnMario.UseVisualStyleBackColor = true;
            this.btnMario.Click += new System.EventHandler(this.btnMario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMario;
    }
}

