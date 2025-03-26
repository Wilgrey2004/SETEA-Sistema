namespace SETEA_Sistema.Gestion_Productos
{
    partial class Codigos_Agregar_editar
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MyCodigoDeBarras = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.MyIdSeleccionadoTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.AgregarCodigo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.EdicionCodigo = new MaterialSkin.Controls.MaterialButton();
            this.MyListaDeProductos = new System.Windows.Forms.DataGridView();
            this.MyListaDeCodigos = new System.Windows.Forms.DataGridView();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyListaDeProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyListaDeCodigos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.MyListaDeCodigos);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.MyListaDeProductos);
            this.materialCard1.Controls.Add(this.EdicionCodigo);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.AgregarCodigo);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.MyIdSeleccionadoTxt);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.MyCodigoDeBarras);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1263, 416);
            this.materialCard1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Codigo @accion";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Codigo De barras";
            // 
            // MyCodigoDeBarras
            // 
            this.MyCodigoDeBarras.AnimateReadOnly = false;
            this.MyCodigoDeBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyCodigoDeBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MyCodigoDeBarras.Depth = 0;
            this.MyCodigoDeBarras.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MyCodigoDeBarras.HideSelection = true;
            this.MyCodigoDeBarras.LeadingIcon = null;
            this.MyCodigoDeBarras.Location = new System.Drawing.Point(20, 89);
            this.MyCodigoDeBarras.MaxLength = 32767;
            this.MyCodigoDeBarras.MouseState = MaterialSkin.MouseState.OUT;
            this.MyCodigoDeBarras.Name = "MyCodigoDeBarras";
            this.MyCodigoDeBarras.PasswordChar = '\0';
            this.MyCodigoDeBarras.PrefixSuffixText = null;
            this.MyCodigoDeBarras.ReadOnly = false;
            this.MyCodigoDeBarras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyCodigoDeBarras.SelectedText = "";
            this.MyCodigoDeBarras.SelectionLength = 0;
            this.MyCodigoDeBarras.SelectionStart = 0;
            this.MyCodigoDeBarras.ShortcutsEnabled = true;
            this.MyCodigoDeBarras.Size = new System.Drawing.Size(250, 48);
            this.MyCodigoDeBarras.TabIndex = 2;
            this.MyCodigoDeBarras.TabStop = false;
            this.MyCodigoDeBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MyCodigoDeBarras.TrailingIcon = null;
            this.MyCodigoDeBarras.UseSystemPasswordChar = false;
            this.MyCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyCodigoDeBarras_KeyDown);
            this.MyCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyCodigoDeBarras_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(803, 30);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(282, 41);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Lista de productos";
            // 
            // MyIdSeleccionadoTxt
            // 
            this.MyIdSeleccionadoTxt.AnimateReadOnly = false;
            this.MyIdSeleccionadoTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyIdSeleccionadoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MyIdSeleccionadoTxt.Depth = 0;
            this.MyIdSeleccionadoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MyIdSeleccionadoTxt.HideSelection = true;
            this.MyIdSeleccionadoTxt.LeadingIcon = null;
            this.MyIdSeleccionadoTxt.Location = new System.Drawing.Point(20, 169);
            this.MyIdSeleccionadoTxt.MaxLength = 32767;
            this.MyIdSeleccionadoTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.MyIdSeleccionadoTxt.Name = "MyIdSeleccionadoTxt";
            this.MyIdSeleccionadoTxt.PasswordChar = '\0';
            this.MyIdSeleccionadoTxt.PrefixSuffixText = null;
            this.MyIdSeleccionadoTxt.ReadOnly = false;
            this.MyIdSeleccionadoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyIdSeleccionadoTxt.SelectedText = "";
            this.MyIdSeleccionadoTxt.SelectionLength = 0;
            this.MyIdSeleccionadoTxt.SelectionStart = 0;
            this.MyIdSeleccionadoTxt.ShortcutsEnabled = true;
            this.MyIdSeleccionadoTxt.Size = new System.Drawing.Size(250, 48);
            this.MyIdSeleccionadoTxt.TabIndex = 5;
            this.MyIdSeleccionadoTxt.TabStop = false;
            this.MyIdSeleccionadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MyIdSeleccionadoTxt.TrailingIcon = null;
            this.MyIdSeleccionadoTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(23, 147);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(110, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "ID Del producto";
            // 
            // AgregarCodigo
            // 
            this.AgregarCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarCodigo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarCodigo.Depth = 0;
            this.AgregarCodigo.HighEmphasis = true;
            this.AgregarCodigo.Icon = null;
            this.AgregarCodigo.Location = new System.Drawing.Point(20, 268);
            this.AgregarCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AgregarCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarCodigo.Name = "AgregarCodigo";
            this.AgregarCodigo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarCodigo.Size = new System.Drawing.Size(223, 36);
            this.AgregarCodigo.TabIndex = 7;
            this.AgregarCodigo.Text = "Agregar codigo a la lista ";
            this.AgregarCodigo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarCodigo.UseAccentColor = false;
            this.AgregarCodigo.UseVisualStyleBackColor = true;
            this.AgregarCodigo.Click += new System.EventHandler(this.AgregarCodigo_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 243);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(65, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Acciones";
            // 
            // EdicionCodigo
            // 
            this.EdicionCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EdicionCodigo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EdicionCodigo.Depth = 0;
            this.EdicionCodigo.HighEmphasis = true;
            this.EdicionCodigo.Icon = null;
            this.EdicionCodigo.Location = new System.Drawing.Point(20, 313);
            this.EdicionCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EdicionCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.EdicionCodigo.Name = "EdicionCodigo";
            this.EdicionCodigo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EdicionCodigo.Size = new System.Drawing.Size(291, 36);
            this.EdicionCodigo.TabIndex = 9;
            this.EdicionCodigo.Text = "Edicion de informacion del codigo";
            this.EdicionCodigo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EdicionCodigo.UseAccentColor = false;
            this.EdicionCodigo.UseVisualStyleBackColor = true;
            this.EdicionCodigo.Click += new System.EventHandler(this.EdicionCodigo_Click);
            // 
            // MyListaDeProductos
            // 
            this.MyListaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyListaDeProductos.Location = new System.Drawing.Point(801, 74);
            this.MyListaDeProductos.Name = "MyListaDeProductos";
            this.MyListaDeProductos.Size = new System.Drawing.Size(434, 291);
            this.MyListaDeProductos.TabIndex = 10;
            this.MyListaDeProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyListaDeProductos_CellClick);
            // 
            // MyListaDeCodigos
            // 
            this.MyListaDeCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyListaDeCodigos.Location = new System.Drawing.Point(348, 74);
            this.MyListaDeCodigos.Name = "MyListaDeCodigos";
            this.MyListaDeCodigos.Size = new System.Drawing.Size(434, 291);
            this.MyListaDeCodigos.TabIndex = 12;
            this.MyListaDeCodigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyListaDeCodigos_CellClick);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(341, 30);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(252, 41);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Lista de Codigos";
            // 
            // Codigos_Agregar_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 483);
            this.Controls.Add(this.materialCard1);
            this.Name = "Codigos_Agregar_editar";
            this.Text = "Codigos Agregar editar";
            this.Load += new System.EventHandler(this.Codigos_Agregar_editar_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyListaDeProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyListaDeCodigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 MyCodigoDeBarras;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 MyIdSeleccionadoTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton AgregarCodigo;
        private MaterialSkin.Controls.MaterialButton EdicionCodigo;
        private System.Windows.Forms.DataGridView MyListaDeProductos;
        private System.Windows.Forms.DataGridView MyListaDeCodigos;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}