
namespace Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.lblRenta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(211, 81);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(71, 17);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(218, 140);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(52, 17);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(319, 79);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtEmpleado.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(319, 135);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 22);
            this.txtSueldo.TabIndex = 4;
            // 
            // txtRenta
            // 
            this.txtRenta.Location = new System.Drawing.Point(319, 193);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(100, 22);
            this.txtRenta.TabIndex = 5;
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(218, 198);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(46, 17);
            this.lblRenta.TabIndex = 6;
            this.lblRenta.Text = "Renta";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(195, 292);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 46);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(359, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRenta);
            this.Controls.Add(this.txtRenta);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}

