
namespace Vista
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
            this.components = new System.ComponentModel.Container();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tablaDeDatos = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.botonAlta = new System.Windows.Forms.Button();
            this.botonModificacion = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(155, 96);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(147, 20);
            this.textNombre.TabIndex = 0;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(155, 122);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(147, 20);
            this.textApellido.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(71, 98);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(71, 129);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tablaDeDatos
            // 
            this.tablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeDatos.Location = new System.Drawing.Point(387, 72);
            this.tablaDeDatos.Name = "tablaDeDatos";
            this.tablaDeDatos.Size = new System.Drawing.Size(361, 205);
            this.tablaDeDatos.TabIndex = 5;
            this.tablaDeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeDatos_CellContentClick);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(288, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(178, 30);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Gestión Usuarios";
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(227, 161);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(75, 23);
            this.botonAlta.TabIndex = 7;
            this.botonAlta.Text = "Alta";
            this.botonAlta.UseVisualStyleBackColor = true;
            // 
            // botonModificacion
            // 
            this.botonModificacion.Location = new System.Drawing.Point(227, 219);
            this.botonModificacion.Name = "botonModificacion";
            this.botonModificacion.Size = new System.Drawing.Size(75, 23);
            this.botonModificacion.TabIndex = 8;
            this.botonModificacion.Text = "Modificacion";
            this.botonModificacion.UseVisualStyleBackColor = true;
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(227, 190);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(75, 23);
            this.botonBaja.TabIndex = 9;
            this.botonBaja.Text = "Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(227, 70);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(75, 20);
            this.textId.TabIndex = 10;
            this.textId.Text = "0";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(71, 70);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "Id";
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonModificacion);
            this.Controls.Add(this.botonAlta);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.tablaDeDatos);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Name = "Visualizar";
            this.Text = "Gestión ABM de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView tablaDeDatos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.Button botonModificacion;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelId;
    }
}

