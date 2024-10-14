namespace InsertarEF
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbIDProducto = new System.Windows.Forms.TextBox();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.btnObtenerTodo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBuscarPorID = new System.Windows.Forms.TextBox();
            this.btnBuscarporID = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(45, 101);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(489, 238);
            this.dgvProductos.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "IDProducto";
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(641, 203);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(100, 20);
            this.txbStock.TabIndex = 62;
            this.txbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStock_KeyPress);
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(641, 177);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 61;
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecio_KeyPress);
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(641, 229);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(100, 20);
            this.txbMarca.TabIndex = 60;
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(641, 255);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(100, 20);
            this.txbCategoria.TabIndex = 59;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(641, 125);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 58;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(641, 151);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txbDescripcion.TabIndex = 57;
            // 
            // txbIDProducto
            // 
            this.txbIDProducto.Location = new System.Drawing.Point(641, 99);
            this.txbIDProducto.Name = "txbIDProducto";
            this.txbIDProducto.Size = new System.Drawing.Size(100, 20);
            this.txbIDProducto.TabIndex = 56;
            this.txbIDProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDProducto_KeyPress);
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.Location = new System.Drawing.Point(641, 308);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(100, 23);
            this.btnInsertarProducto.TabIndex = 55;
            this.btnInsertarProducto.Text = "Insertar";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // btnObtenerTodo
            // 
            this.btnObtenerTodo.Location = new System.Drawing.Point(44, 379);
            this.btnObtenerTodo.Name = "btnObtenerTodo";
            this.btnObtenerTodo.Size = new System.Drawing.Size(98, 23);
            this.btnObtenerTodo.TabIndex = 73;
            this.btnObtenerTodo.Text = "Obtener Todo";
            this.btnObtenerTodo.UseVisualStyleBackColor = true;
            this.btnObtenerTodo.Click += new System.EventHandler(this.btnObtenerTodo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "ID:";
            // 
            // txbBuscarPorID
            // 
            this.txbBuscarPorID.Location = new System.Drawing.Point(339, 382);
            this.txbBuscarPorID.Name = "txbBuscarPorID";
            this.txbBuscarPorID.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarPorID.TabIndex = 71;
            // 
            // btnBuscarporID
            // 
            this.btnBuscarporID.Location = new System.Drawing.Point(446, 379);
            this.btnBuscarporID.Name = "btnBuscarporID";
            this.btnBuscarporID.Size = new System.Drawing.Size(88, 23);
            this.btnBuscarporID.TabIndex = 70;
            this.btnBuscarporID.Text = "Buscar por ID";
            this.btnBuscarporID.UseVisualStyleBackColor = true;
            this.btnBuscarporID.Click += new System.EventHandler(this.btnBuscarporID_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "Insertar producto con Entity Framework";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnObtenerTodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbBuscarPorID);
            this.Controls.Add(this.btnBuscarporID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbIDProducto);
            this.Controls.Add(this.btnInsertarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbIDProducto;
        private System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.Button btnObtenerTodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBuscarPorID;
        private System.Windows.Forms.Button btnBuscarporID;
        private System.Windows.Forms.Label label9;
    }
}

