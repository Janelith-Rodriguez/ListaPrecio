namespace ListaPrecio
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.btLogintud = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btPrueba = new System.Windows.Forms.Button();
            this.btMayuscula = new System.Windows.Forms.Button();
            this.btMinuscula = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.txtDeletrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(6, 22);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(822, 38);
            this.txtString.TabIndex = 5;
            // 
            // btLogintud
            // 
            this.btLogintud.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogintud.Location = new System.Drawing.Point(6, 72);
            this.btLogintud.Name = "btLogintud";
            this.btLogintud.Size = new System.Drawing.Size(130, 42);
            this.btLogintud.TabIndex = 1;
            this.btLogintud.Text = "Longitud";
            this.btLogintud.UseVisualStyleBackColor = true;
            this.btLogintud.Click += new System.EventHandler(this.btLogintud_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(24, 154);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // btPrueba
            // 
            this.btPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrueba.Location = new System.Drawing.Point(166, 72);
            this.btPrueba.Name = "btPrueba";
            this.btPrueba.Size = new System.Drawing.Size(115, 42);
            this.btPrueba.TabIndex = 3;
            this.btPrueba.Text = "Prueba";
            this.btPrueba.UseVisualStyleBackColor = true;
            this.btPrueba.Click += new System.EventHandler(this.btPrueba_Click);
            // 
            // btMayuscula
            // 
            this.btMayuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMayuscula.Location = new System.Drawing.Point(312, 72);
            this.btMayuscula.Name = "btMayuscula";
            this.btMayuscula.Size = new System.Drawing.Size(160, 42);
            this.btMayuscula.TabIndex = 0;
            this.btMayuscula.Text = "Mayuscula";
            this.btMayuscula.Click += new System.EventHandler(this.btMayuscula_Click);
            // 
            // btMinuscula
            // 
            this.btMinuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinuscula.Location = new System.Drawing.Point(491, 72);
            this.btMinuscula.Name = "btMinuscula";
            this.btMinuscula.Size = new System.Drawing.Size(160, 42);
            this.btMinuscula.TabIndex = 4;
            this.btMinuscula.Text = "Minuscula";
            this.btMinuscula.Click += new System.EventHandler(this.btMinuscula_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(668, 72);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(160, 42);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscado.Location = new System.Drawing.Point(831, 22);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(243, 38);
            this.txtBuscado.TabIndex = 7;
            // 
            // txtDeletrear
            // 
            this.txtDeletrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeletrear.Location = new System.Drawing.Point(834, 72);
            this.txtDeletrear.Name = "txtDeletrear";
            this.txtDeletrear.Size = new System.Drawing.Size(160, 42);
            this.txtDeletrear.TabIndex = 8;
            this.txtDeletrear.Text = "Deletrear";
            this.txtDeletrear.Click += new System.EventHandler(this.txtDeletrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 261);
            this.Controls.Add(this.txtDeletrear);
            this.Controls.Add(this.txtBuscado);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btMinuscula);
            this.Controls.Add(this.btMayuscula);
            this.Controls.Add(this.btPrueba);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btLogintud);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btLogintud;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btPrueba;
        private System.Windows.Forms.Button btMayuscula;
        private System.Windows.Forms.Button btMinuscula;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button txtDeletrear;
    }
}

