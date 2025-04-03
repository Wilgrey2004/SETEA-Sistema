namespace SETEA_Sistema.Gestion_Productos
{
        partial class ListaDeCompras
        {
                /// <summary>
                /// Required designer variable.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Clean up any resources being used.
                /// </summary>
                /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
                protected override void Dispose( bool disposing ) {
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
                private void InitializeComponent() {
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeCompras));
                        this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
                        this.tabPage1 = new System.Windows.Forms.TabPage();
                        this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
                        this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
                        this.txtCantidadRestante = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
                        this.ProductoName = new MaterialSkin.Controls.MaterialComboBox();
                        this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
                        this.Cantidad = new System.Windows.Forms.NumericUpDown();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.MyDataProductosAgotados = new System.Windows.Forms.DataGridView();
                        this.tabPage2 = new System.Windows.Forms.TabPage();
                        this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
                        this.CantidadNewProduct = new System.Windows.Forms.NumericUpDown();
                        this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
                        this.PrecioNewProducto = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.NameNewProducto = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
                        this.ListaDeComprasVariada = new System.Windows.Forms.DataGridView();
                        this.imageList1 = new System.Windows.Forms.ImageList(this.components);
                        this.materialTabControl1.SuspendLayout();
                        this.tabPage1.SuspendLayout();
                        this.materialCard1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.MyDataProductosAgotados)).BeginInit();
                        this.tabPage2.SuspendLayout();
                        this.materialCard2.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.CantidadNewProduct)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ListaDeComprasVariada)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // materialTabControl1
                        // 
                        this.materialTabControl1.Controls.Add(this.tabPage1);
                        this.materialTabControl1.Controls.Add(this.tabPage2);
                        this.materialTabControl1.Depth = 0;
                        this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.materialTabControl1.ImageList = this.imageList1;
                        this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
                        this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialTabControl1.Multiline = true;
                        this.materialTabControl1.Name = "materialTabControl1";
                        this.materialTabControl1.SelectedIndex = 0;
                        this.materialTabControl1.Size = new System.Drawing.Size(1006, 566);
                        this.materialTabControl1.TabIndex = 0;
                        // 
                        // tabPage1
                        // 
                        this.tabPage1.Controls.Add(this.materialCard1);
                        this.tabPage1.Controls.Add(this.materialButton4);
                        this.tabPage1.Controls.Add(this.materialLabel5);
                        this.tabPage1.Controls.Add(this.materialLabel4);
                        this.tabPage1.Controls.Add(this.Cantidad);
                        this.tabPage1.Controls.Add(this.materialLabel3);
                        this.tabPage1.Controls.Add(this.materialButton3);
                        this.tabPage1.Controls.Add(this.materialButton2);
                        this.tabPage1.Controls.Add(this.materialButton1);
                        this.tabPage1.Controls.Add(this.materialLabel2);
                        this.tabPage1.Controls.Add(this.materialLabel1);
                        this.tabPage1.Controls.Add(this.MyDataProductosAgotados);
                        this.tabPage1.ImageKey = "lista-de-verificacion.png";
                        this.tabPage1.Location = new System.Drawing.Point(4, 23);
                        this.tabPage1.Name = "tabPage1";
                        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
                        this.tabPage1.Size = new System.Drawing.Size(998, 539);
                        this.tabPage1.TabIndex = 0;
                        this.tabPage1.Text = "Productos Agotados";
                        this.tabPage1.UseVisualStyleBackColor = true;
                        this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.materialLabel7);
                        this.materialCard1.Controls.Add(this.txtCantidadRestante);
                        this.materialCard1.Controls.Add(this.materialLabel6);
                        this.materialCard1.Controls.Add(this.ProductoName);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(479, 45);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(473, 130);
                        this.materialCard1.TabIndex = 11;
                        // 
                        // materialLabel7
                        // 
                        this.materialLabel7.AutoSize = true;
                        this.materialLabel7.Depth = 0;
                        this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel7.Location = new System.Drawing.Point(301, 31);
                        this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel7.Name = "materialLabel7";
                        this.materialLabel7.Size = new System.Drawing.Size(135, 19);
                        this.materialLabel7.TabIndex = 20;
                        this.materialLabel7.Text = "Cantidad Restante ";
                        // 
                        // txtCantidadRestante
                        // 
                        this.txtCantidadRestante.AllowPromptAsInput = true;
                        this.txtCantidadRestante.AnimateReadOnly = false;
                        this.txtCantidadRestante.AsciiOnly = false;
                        this.txtCantidadRestante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.txtCantidadRestante.BeepOnError = false;
                        this.txtCantidadRestante.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.txtCantidadRestante.Depth = 0;
                        this.txtCantidadRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.txtCantidadRestante.HidePromptOnLeave = false;
                        this.txtCantidadRestante.HideSelection = true;
                        this.txtCantidadRestante.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.txtCantidadRestante.LeadingIcon = null;
                        this.txtCantidadRestante.Location = new System.Drawing.Point(304, 53);
                        this.txtCantidadRestante.Mask = "";
                        this.txtCantidadRestante.MaxLength = 32767;
                        this.txtCantidadRestante.MouseState = MaterialSkin.MouseState.OUT;
                        this.txtCantidadRestante.Name = "txtCantidadRestante";
                        this.txtCantidadRestante.PasswordChar = '\0';
                        this.txtCantidadRestante.PrefixSuffixText = null;
                        this.txtCantidadRestante.PromptChar = '_';
                        this.txtCantidadRestante.ReadOnly = true;
                        this.txtCantidadRestante.RejectInputOnFirstFailure = false;
                        this.txtCantidadRestante.ResetOnPrompt = true;
                        this.txtCantidadRestante.ResetOnSpace = true;
                        this.txtCantidadRestante.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.txtCantidadRestante.SelectedText = "";
                        this.txtCantidadRestante.SelectionLength = 0;
                        this.txtCantidadRestante.SelectionStart = 0;
                        this.txtCantidadRestante.ShortcutsEnabled = true;
                        this.txtCantidadRestante.Size = new System.Drawing.Size(154, 48);
                        this.txtCantidadRestante.SkipLiterals = true;
                        this.txtCantidadRestante.TabIndex = 19;
                        this.txtCantidadRestante.TabStop = false;
                        this.txtCantidadRestante.Text = "0";
                        this.txtCantidadRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.txtCantidadRestante.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.txtCantidadRestante.TrailingIcon = null;
                        this.txtCantidadRestante.UseSystemPasswordChar = false;
                        this.txtCantidadRestante.ValidatingType = null;
                        // 
                        // materialLabel6
                        // 
                        this.materialLabel6.AutoSize = true;
                        this.materialLabel6.Depth = 0;
                        this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel6.Location = new System.Drawing.Point(15, 30);
                        this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel6.Name = "materialLabel6";
                        this.materialLabel6.Size = new System.Drawing.Size(250, 19);
                        this.materialLabel6.TabIndex = 16;
                        this.materialLabel6.Text = "Selecciona El Nombre Del Producto";
                        // 
                        // ProductoName
                        // 
                        this.ProductoName.AutoResize = false;
                        this.ProductoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.ProductoName.Depth = 0;
                        this.ProductoName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                        this.ProductoName.DropDownHeight = 174;
                        this.ProductoName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        this.ProductoName.DropDownWidth = 121;
                        this.ProductoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.ProductoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.ProductoName.FormattingEnabled = true;
                        this.ProductoName.IntegralHeight = false;
                        this.ProductoName.ItemHeight = 43;
                        this.ProductoName.Location = new System.Drawing.Point(19, 52);
                        this.ProductoName.MaxDropDownItems = 4;
                        this.ProductoName.MouseState = MaterialSkin.MouseState.OUT;
                        this.ProductoName.Name = "ProductoName";
                        this.ProductoName.Size = new System.Drawing.Size(265, 49);
                        this.ProductoName.StartIndex = 0;
                        this.ProductoName.TabIndex = 15;
                        this.ProductoName.SelectedIndexChanged += new System.EventHandler(this.ProductoName_SelectedIndexChanged);
                        // 
                        // materialButton4
                        // 
                        this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton4.Depth = 0;
                        this.materialButton4.HighEmphasis = true;
                        this.materialButton4.Icon = null;
                        this.materialButton4.Location = new System.Drawing.Point(480, 362);
                        this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton4.Name = "materialButton4";
                        this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton4.Size = new System.Drawing.Size(193, 36);
                        this.materialButton4.TabIndex = 10;
                        this.materialButton4.Text = "Eliminar Un producto";
                        this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton4.UseAccentColor = false;
                        this.materialButton4.UseVisualStyleBackColor = true;
                        this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
                        // 
                        // materialLabel5
                        // 
                        this.materialLabel5.AutoSize = true;
                        this.materialLabel5.Depth = 0;
                        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel5.Location = new System.Drawing.Point(480, 337);
                        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel5.Name = "materialLabel5";
                        this.materialLabel5.Size = new System.Drawing.Size(221, 19);
                        this.materialLabel5.TabIndex = 9;
                        this.materialLabel5.Text = "Eliminar Un producto de la lista";
                        // 
                        // materialLabel4
                        // 
                        this.materialLabel4.AutoSize = true;
                        this.materialLabel4.Depth = 0;
                        this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel4.Location = new System.Drawing.Point(480, 401);
                        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel4.Name = "materialLabel4";
                        this.materialLabel4.Size = new System.Drawing.Size(317, 19);
                        this.materialLabel4.TabIndex = 8;
                        this.materialLabel4.Text = "Genera El pdf Con la informacion de la tabla ";
                        // 
                        // Cantidad
                        // 
                        this.Cantidad.Location = new System.Drawing.Point(706, 295);
                        this.Cantidad.Name = "Cantidad";
                        this.Cantidad.Size = new System.Drawing.Size(112, 20);
                        this.Cantidad.TabIndex = 7;
                        this.Cantidad.ValueChanged += new System.EventHandler(this.Cantidad_ValueChanged);
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.Location = new System.Drawing.Point(480, 270);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(218, 19);
                        this.materialLabel3.TabIndex = 6;
                        this.materialLabel3.Text = "Mostrar Por Cantidad Restante";
                        // 
                        // materialButton3
                        // 
                        this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton3.Depth = 0;
                        this.materialButton3.HighEmphasis = true;
                        this.materialButton3.Icon = null;
                        this.materialButton3.Location = new System.Drawing.Point(480, 295);
                        this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton3.Name = "materialButton3";
                        this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton3.Size = new System.Drawing.Size(186, 36);
                        this.materialButton3.TabIndex = 5;
                        this.materialButton3.Text = "Buscar Por Cantidad";
                        this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton3.UseAccentColor = false;
                        this.materialButton3.UseVisualStyleBackColor = true;
                        this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
                        // 
                        // materialButton2
                        // 
                        this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton2.Depth = 0;
                        this.materialButton2.HighEmphasis = true;
                        this.materialButton2.Icon = null;
                        this.materialButton2.Location = new System.Drawing.Point(480, 228);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(320, 36);
                        this.materialButton2.TabIndex = 4;
                        this.materialButton2.Text = "Cargar Solo los productos agotados";
                        this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton2.UseAccentColor = false;
                        this.materialButton2.UseVisualStyleBackColor = true;
                        this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(480, 426);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(338, 36);
                        this.materialButton1.TabIndex = 3;
                        this.materialButton1.Text = "Generar Lista con Los Datos De la Tabla";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel2.Location = new System.Drawing.Point(475, 7);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(82, 24);
                        this.materialLabel2.TabIndex = 2;
                        this.materialLabel2.Text = "Acciones";
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel1.Location = new System.Drawing.Point(3, 3);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(180, 24);
                        this.materialLabel1.TabIndex = 1;
                        this.materialLabel1.Text = "Productos agotados";
                        // 
                        // MyDataProductosAgotados
                        // 
                        this.MyDataProductosAgotados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.MyDataProductosAgotados.Location = new System.Drawing.Point(6, 45);
                        this.MyDataProductosAgotados.Name = "MyDataProductosAgotados";
                        this.MyDataProductosAgotados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.MyDataProductosAgotados.Size = new System.Drawing.Size(456, 488);
                        this.MyDataProductosAgotados.TabIndex = 0;
                        this.MyDataProductosAgotados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataProductosAgotados_CellClick);
                        this.MyDataProductosAgotados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataProductosAgotados_CellContentClick);
                        this.MyDataProductosAgotados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MyDataProductosAgotados_CellFormatting);
                        this.MyDataProductosAgotados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataProductosAgotados_CellValueChanged);
                        this.MyDataProductosAgotados.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MyDataProductosAgotados_DataError);
                        // 
                        // tabPage2
                        // 
                        this.tabPage2.Controls.Add(this.materialButton10);
                        this.tabPage2.Controls.Add(this.materialButton9);
                        this.tabPage2.Controls.Add(this.materialButton7);
                        this.tabPage2.Controls.Add(this.materialLabel9);
                        this.tabPage2.Controls.Add(this.materialCard2);
                        this.tabPage2.Controls.Add(this.materialLabel8);
                        this.tabPage2.Controls.Add(this.ListaDeComprasVariada);
                        this.tabPage2.ImageKey = "ListaIcon2.png";
                        this.tabPage2.Location = new System.Drawing.Point(4, 23);
                        this.tabPage2.Name = "tabPage2";
                        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                        this.tabPage2.Size = new System.Drawing.Size(998, 539);
                        this.tabPage2.TabIndex = 1;
                        this.tabPage2.Text = "Compras Adicionales";
                        this.tabPage2.UseVisualStyleBackColor = true;
                        // 
                        // materialButton10
                        // 
                        this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton10.Depth = 0;
                        this.materialButton10.HighEmphasis = true;
                        this.materialButton10.Icon = null;
                        this.materialButton10.Location = new System.Drawing.Point(10, 431);
                        this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton10.Name = "materialButton10";
                        this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton10.Size = new System.Drawing.Size(216, 36);
                        this.materialButton10.TabIndex = 21;
                        this.materialButton10.Text = "Generar Pdf Con La Lista";
                        this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton10.UseAccentColor = false;
                        this.materialButton10.UseVisualStyleBackColor = true;
                        this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
                        // 
                        // materialButton9
                        // 
                        this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton9.Depth = 0;
                        this.materialButton9.HighEmphasis = true;
                        this.materialButton9.Icon = null;
                        this.materialButton9.Location = new System.Drawing.Point(10, 383);
                        this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton9.Name = "materialButton9";
                        this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton9.Size = new System.Drawing.Size(116, 36);
                        this.materialButton9.TabIndex = 20;
                        this.materialButton9.Text = "Vaciar Lista";
                        this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton9.UseAccentColor = false;
                        this.materialButton9.UseVisualStyleBackColor = true;
                        this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
                        // 
                        // materialButton7
                        // 
                        this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton7.Depth = 0;
                        this.materialButton7.HighEmphasis = true;
                        this.materialButton7.Icon = null;
                        this.materialButton7.Location = new System.Drawing.Point(10, 335);
                        this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton7.Name = "materialButton7";
                        this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton7.Size = new System.Drawing.Size(350, 36);
                        this.materialButton7.TabIndex = 19;
                        this.materialButton7.Text = "Eliminar Producto De La Lista De Compras";
                        this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton7.UseAccentColor = false;
                        this.materialButton7.UseVisualStyleBackColor = true;
                        this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
                        // 
                        // materialLabel9
                        // 
                        this.materialLabel9.AutoSize = true;
                        this.materialLabel9.Depth = 0;
                        this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel9.Location = new System.Drawing.Point(6, 9);
                        this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel9.Name = "materialLabel9";
                        this.materialLabel9.Size = new System.Drawing.Size(87, 24);
                        this.materialLabel9.TabIndex = 4;
                        this.materialLabel9.Text = "Acciones ";
                        // 
                        // materialCard2
                        // 
                        this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard2.Controls.Add(this.CantidadNewProduct);
                        this.materialCard2.Controls.Add(this.materialButton8);
                        this.materialCard2.Controls.Add(this.materialLabel13);
                        this.materialCard2.Controls.Add(this.materialButton6);
                        this.materialCard2.Controls.Add(this.PrecioNewProducto);
                        this.materialCard2.Controls.Add(this.NameNewProducto);
                        this.materialCard2.Controls.Add(this.materialLabel12);
                        this.materialCard2.Controls.Add(this.materialLabel11);
                        this.materialCard2.Controls.Add(this.materialLabel10);
                        this.materialCard2.Depth = 0;
                        this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard2.Location = new System.Drawing.Point(10, 36);
                        this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard2.Name = "materialCard2";
                        this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard2.Size = new System.Drawing.Size(509, 288);
                        this.materialCard2.TabIndex = 3;
                        // 
                        // CantidadNewProduct
                        // 
                        this.CantidadNewProduct.Location = new System.Drawing.Point(242, 132);
                        this.CantidadNewProduct.Name = "CantidadNewProduct";
                        this.CantidadNewProduct.Size = new System.Drawing.Size(250, 20);
                        this.CantidadNewProduct.TabIndex = 20;
                        // 
                        // materialButton8
                        // 
                        this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton8.Depth = 0;
                        this.materialButton8.HighEmphasis = true;
                        this.materialButton8.Icon = null;
                        this.materialButton8.Location = new System.Drawing.Point(117, 242);
                        this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton8.Name = "materialButton8";
                        this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton8.Size = new System.Drawing.Size(140, 36);
                        this.materialButton8.TabIndex = 19;
                        this.materialButton8.Text = "Reiniciar Cajas";
                        this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton8.UseAccentColor = false;
                        this.materialButton8.UseVisualStyleBackColor = true;
                        this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
                        // 
                        // materialLabel13
                        // 
                        this.materialLabel13.AutoSize = true;
                        this.materialLabel13.Depth = 0;
                        this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel13.Location = new System.Drawing.Point(14, 14);
                        this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel13.Name = "materialLabel13";
                        this.materialLabel13.Size = new System.Drawing.Size(166, 24);
                        this.materialLabel13.TabIndex = 5;
                        this.materialLabel13.Text = "Agregar A La Lista";
                        // 
                        // materialButton6
                        // 
                        this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton6.Depth = 0;
                        this.materialButton6.HighEmphasis = true;
                        this.materialButton6.Icon = null;
                        this.materialButton6.Location = new System.Drawing.Point(21, 242);
                        this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton6.Name = "materialButton6";
                        this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton6.Size = new System.Drawing.Size(88, 36);
                        this.materialButton6.TabIndex = 18;
                        this.materialButton6.Text = "Agregar";
                        this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton6.UseAccentColor = false;
                        this.materialButton6.UseVisualStyleBackColor = true;
                        this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
                        // 
                        // PrecioNewProducto
                        // 
                        this.PrecioNewProducto.AllowPromptAsInput = true;
                        this.PrecioNewProducto.AnimateReadOnly = false;
                        this.PrecioNewProducto.AsciiOnly = false;
                        this.PrecioNewProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.PrecioNewProducto.BeepOnError = false;
                        this.PrecioNewProducto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.PrecioNewProducto.Depth = 0;
                        this.PrecioNewProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.PrecioNewProducto.HidePromptOnLeave = false;
                        this.PrecioNewProducto.HideSelection = true;
                        this.PrecioNewProducto.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.PrecioNewProducto.LeadingIcon = null;
                        this.PrecioNewProducto.Location = new System.Drawing.Point(242, 182);
                        this.PrecioNewProducto.Mask = "";
                        this.PrecioNewProducto.MaxLength = 32767;
                        this.PrecioNewProducto.MouseState = MaterialSkin.MouseState.OUT;
                        this.PrecioNewProducto.Name = "PrecioNewProducto";
                        this.PrecioNewProducto.PasswordChar = '\0';
                        this.PrecioNewProducto.PrefixSuffixText = null;
                        this.PrecioNewProducto.PromptChar = '_';
                        this.PrecioNewProducto.ReadOnly = false;
                        this.PrecioNewProducto.RejectInputOnFirstFailure = false;
                        this.PrecioNewProducto.ResetOnPrompt = true;
                        this.PrecioNewProducto.ResetOnSpace = true;
                        this.PrecioNewProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.PrecioNewProducto.SelectedText = "";
                        this.PrecioNewProducto.SelectionLength = 0;
                        this.PrecioNewProducto.SelectionStart = 0;
                        this.PrecioNewProducto.ShortcutsEnabled = true;
                        this.PrecioNewProducto.Size = new System.Drawing.Size(250, 48);
                        this.PrecioNewProducto.SkipLiterals = true;
                        this.PrecioNewProducto.TabIndex = 10;
                        this.PrecioNewProducto.TabStop = false;
                        this.PrecioNewProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.PrecioNewProducto.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.PrecioNewProducto.TrailingIcon = null;
                        this.PrecioNewProducto.UseSystemPasswordChar = false;
                        this.PrecioNewProducto.ValidatingType = null;
                        // 
                        // NameNewProducto
                        // 
                        this.NameNewProducto.AllowPromptAsInput = true;
                        this.NameNewProducto.AnimateReadOnly = false;
                        this.NameNewProducto.AsciiOnly = false;
                        this.NameNewProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NameNewProducto.BeepOnError = false;
                        this.NameNewProducto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NameNewProducto.Depth = 0;
                        this.NameNewProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NameNewProducto.HidePromptOnLeave = false;
                        this.NameNewProducto.HideSelection = true;
                        this.NameNewProducto.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.NameNewProducto.LeadingIcon = null;
                        this.NameNewProducto.Location = new System.Drawing.Point(242, 52);
                        this.NameNewProducto.Mask = "";
                        this.NameNewProducto.MaxLength = 32767;
                        this.NameNewProducto.MouseState = MaterialSkin.MouseState.OUT;
                        this.NameNewProducto.Name = "NameNewProducto";
                        this.NameNewProducto.PasswordChar = '\0';
                        this.NameNewProducto.PrefixSuffixText = null;
                        this.NameNewProducto.PromptChar = '_';
                        this.NameNewProducto.ReadOnly = false;
                        this.NameNewProducto.RejectInputOnFirstFailure = false;
                        this.NameNewProducto.ResetOnPrompt = true;
                        this.NameNewProducto.ResetOnSpace = true;
                        this.NameNewProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NameNewProducto.SelectedText = "";
                        this.NameNewProducto.SelectionLength = 0;
                        this.NameNewProducto.SelectionStart = 0;
                        this.NameNewProducto.ShortcutsEnabled = true;
                        this.NameNewProducto.Size = new System.Drawing.Size(250, 48);
                        this.NameNewProducto.SkipLiterals = true;
                        this.NameNewProducto.TabIndex = 8;
                        this.NameNewProducto.TabStop = false;
                        this.NameNewProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.NameNewProducto.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NameNewProducto.TrailingIcon = null;
                        this.NameNewProducto.UseSystemPasswordChar = false;
                        this.NameNewProducto.ValidatingType = null;
                        // 
                        // materialLabel12
                        // 
                        this.materialLabel12.AutoSize = true;
                        this.materialLabel12.Depth = 0;
                        this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel12.Location = new System.Drawing.Point(17, 197);
                        this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel12.Name = "materialLabel12";
                        this.materialLabel12.Size = new System.Drawing.Size(154, 24);
                        this.materialLabel12.TabIndex = 7;
                        this.materialLabel12.Text = "Precio De Unidad";
                        // 
                        // materialLabel11
                        // 
                        this.materialLabel11.AutoSize = true;
                        this.materialLabel11.Depth = 0;
                        this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel11.Location = new System.Drawing.Point(17, 132);
                        this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel11.Name = "materialLabel11";
                        this.materialLabel11.Size = new System.Drawing.Size(200, 24);
                        this.materialLabel11.TabIndex = 6;
                        this.materialLabel11.Text = "Cantidad Del Prodicto ";
                        // 
                        // materialLabel10
                        // 
                        this.materialLabel10.AutoSize = true;
                        this.materialLabel10.Depth = 0;
                        this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel10.Location = new System.Drawing.Point(17, 65);
                        this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel10.Name = "materialLabel10";
                        this.materialLabel10.Size = new System.Drawing.Size(192, 24);
                        this.materialLabel10.TabIndex = 5;
                        this.materialLabel10.Text = "Nombre Del Producto";
                        // 
                        // materialLabel8
                        // 
                        this.materialLabel8.AutoSize = true;
                        this.materialLabel8.Depth = 0;
                        this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel8.Location = new System.Drawing.Point(536, 9);
                        this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel8.Name = "materialLabel8";
                        this.materialLabel8.Size = new System.Drawing.Size(149, 24);
                        this.materialLabel8.TabIndex = 2;
                        this.materialLabel8.Text = "Lista De Compra";
                        // 
                        // ListaDeComprasVariada
                        // 
                        this.ListaDeComprasVariada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.ListaDeComprasVariada.Location = new System.Drawing.Point(536, 36);
                        this.ListaDeComprasVariada.Name = "ListaDeComprasVariada";
                        this.ListaDeComprasVariada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.ListaDeComprasVariada.Size = new System.Drawing.Size(444, 497);
                        this.ListaDeComprasVariada.TabIndex = 1;
                        this.ListaDeComprasVariada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeComprasVariada_CellClick);
                        // 
                        // imageList1
                        // 
                        this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
                        this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
                        this.imageList1.Images.SetKeyName(0, "lista-de-verificacion.png");
                        this.imageList1.Images.SetKeyName(1, "ListaIcon2.png");
                        // 
                        // ListaDeCompras
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1012, 633);
                        this.Controls.Add(this.materialTabControl1);
                        this.DrawerTabControl = this.materialTabControl1;
                        this.Name = "ListaDeCompras";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Listas De Compras ";
                        this.Load += new System.EventHandler(this.ListaDeCompras_Load);
                        this.materialTabControl1.ResumeLayout(false);
                        this.tabPage1.ResumeLayout(false);
                        this.tabPage1.PerformLayout();
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.MyDataProductosAgotados)).EndInit();
                        this.tabPage2.ResumeLayout(false);
                        this.tabPage2.PerformLayout();
                        this.materialCard2.ResumeLayout(false);
                        this.materialCard2.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.CantidadNewProduct)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ListaDeComprasVariada)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
                private System.Windows.Forms.TabPage tabPage1;
                private System.Windows.Forms.TabPage tabPage2;
                private System.Windows.Forms.DataGridView MyDataProductosAgotados;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialButton materialButton3;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private System.Windows.Forms.NumericUpDown Cantidad;
                private MaterialSkin.Controls.MaterialLabel materialLabel4;
                private System.Windows.Forms.ImageList imageList1;
                private MaterialSkin.Controls.MaterialButton materialButton4;
                private MaterialSkin.Controls.MaterialLabel materialLabel5;
                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialLabel materialLabel6;
                private MaterialSkin.Controls.MaterialComboBox ProductoName;
                private MaterialSkin.Controls.MaterialLabel materialLabel7;
                private MaterialSkin.Controls.MaterialMaskedTextBox txtCantidadRestante;
                private MaterialSkin.Controls.MaterialLabel materialLabel8;
                private System.Windows.Forms.DataGridView ListaDeComprasVariada;
                private MaterialSkin.Controls.MaterialLabel materialLabel9;
                private MaterialSkin.Controls.MaterialCard materialCard2;
                private MaterialSkin.Controls.MaterialLabel materialLabel10;
                private MaterialSkin.Controls.MaterialLabel materialLabel11;
                private MaterialSkin.Controls.MaterialLabel materialLabel12;
                private MaterialSkin.Controls.MaterialMaskedTextBox NameNewProducto;
                private MaterialSkin.Controls.MaterialMaskedTextBox PrecioNewProducto;
                private MaterialSkin.Controls.MaterialLabel materialLabel13;
                private MaterialSkin.Controls.MaterialButton materialButton6;
                private MaterialSkin.Controls.MaterialButton materialButton7;
                private MaterialSkin.Controls.MaterialButton materialButton9;
                private MaterialSkin.Controls.MaterialButton materialButton8;
                private System.Windows.Forms.NumericUpDown CantidadNewProduct;
                private MaterialSkin.Controls.MaterialButton materialButton10;
        }
}