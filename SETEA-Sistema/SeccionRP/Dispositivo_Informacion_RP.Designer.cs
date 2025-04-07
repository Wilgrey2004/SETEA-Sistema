namespace SETEA_Sistema.SeccionRP
{
        partial class Dispositivo_Informacion_RP
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
                        this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
                        this.IdRecienCreada = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.TipoDispositivoCombobox = new MaterialSkin.Controls.MaterialComboBox();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.MarcaCombobox = new MaterialSkin.Controls.MaterialComboBox();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.FalloEncontradoTxt = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
                        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
                        this.DescripcionDelClienteTxt = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.InfoDispositivoDg = new System.Windows.Forms.DataGridView();
                        this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
                        this.ProductoNombreFind = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
                        this.materialCard1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.InfoDispositivoDg)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.IdRecienCreada);
                        this.materialCard1.Controls.Add(this.materialLabel4);
                        this.materialCard1.Controls.Add(this.materialButton1);
                        this.materialCard1.Controls.Add(this.materialLabel3);
                        this.materialCard1.Controls.Add(this.TipoDispositivoCombobox);
                        this.materialCard1.Controls.Add(this.materialLabel2);
                        this.materialCard1.Controls.Add(this.MarcaCombobox);
                        this.materialCard1.Controls.Add(this.materialLabel1);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(28, 446);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(387, 340);
                        this.materialCard1.TabIndex = 0;
                        this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
                        // 
                        // IdRecienCreada
                        // 
                        this.IdRecienCreada.AllowPromptAsInput = true;
                        this.IdRecienCreada.AnimateReadOnly = false;
                        this.IdRecienCreada.AsciiOnly = false;
                        this.IdRecienCreada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.IdRecienCreada.BeepOnError = false;
                        this.IdRecienCreada.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
                        this.IdRecienCreada.Depth = 0;
                        this.IdRecienCreada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.IdRecienCreada.HidePromptOnLeave = false;
                        this.IdRecienCreada.HideSelection = true;
                        this.IdRecienCreada.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.IdRecienCreada.LeadingIcon = null;
                        this.IdRecienCreada.Location = new System.Drawing.Point(213, 278);
                        this.IdRecienCreada.Mask = "";
                        this.IdRecienCreada.MaxLength = 32767;
                        this.IdRecienCreada.MouseState = MaterialSkin.MouseState.OUT;
                        this.IdRecienCreada.Name = "IdRecienCreada";
                        this.IdRecienCreada.PasswordChar = '\0';
                        this.IdRecienCreada.PrefixSuffixText = null;
                        this.IdRecienCreada.PromptChar = '_';
                        this.IdRecienCreada.ReadOnly = false;
                        this.IdRecienCreada.RejectInputOnFirstFailure = false;
                        this.IdRecienCreada.ResetOnPrompt = true;
                        this.IdRecienCreada.ResetOnSpace = true;
                        this.IdRecienCreada.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.IdRecienCreada.SelectedText = "";
                        this.IdRecienCreada.SelectionLength = 0;
                        this.IdRecienCreada.SelectionStart = 0;
                        this.IdRecienCreada.ShortcutsEnabled = true;
                        this.IdRecienCreada.Size = new System.Drawing.Size(113, 48);
                        this.IdRecienCreada.SkipLiterals = true;
                        this.IdRecienCreada.TabIndex = 7;
                        this.IdRecienCreada.TabStop = false;
                        this.IdRecienCreada.Text = "0";
                        this.IdRecienCreada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.IdRecienCreada.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.IdRecienCreada.TrailingIcon = null;
                        this.IdRecienCreada.UseSystemPasswordChar = false;
                        this.IdRecienCreada.ValidatingType = null;
                        // 
                        // materialLabel4
                        // 
                        this.materialLabel4.AutoSize = true;
                        this.materialLabel4.Depth = 0;
                        this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel4.Location = new System.Drawing.Point(61, 294);
                        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel4.Name = "materialLabel4";
                        this.materialLabel4.Size = new System.Drawing.Size(146, 19);
                        this.materialLabel4.TabIndex = 6;
                        this.materialLabel4.Text = "ID del tipo generado:";
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(75, 233);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(237, 36);
                        this.materialButton1.TabIndex = 5;
                        this.materialButton1.Text = "Generar tipo de dispositivo";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.Location = new System.Drawing.Point(126, 137);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(135, 19);
                        this.materialLabel3.TabIndex = 4;
                        this.materialLabel3.Text = "Tipo de dispositivo";
                        // 
                        // TipoDispositivoCombobox
                        // 
                        this.TipoDispositivoCombobox.AutoResize = false;
                        this.TipoDispositivoCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.TipoDispositivoCombobox.Depth = 0;
                        this.TipoDispositivoCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                        this.TipoDispositivoCombobox.DropDownHeight = 174;
                        this.TipoDispositivoCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        this.TipoDispositivoCombobox.DropDownWidth = 121;
                        this.TipoDispositivoCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.TipoDispositivoCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.TipoDispositivoCombobox.FormattingEnabled = true;
                        this.TipoDispositivoCombobox.IntegralHeight = false;
                        this.TipoDispositivoCombobox.ItemHeight = 43;
                        this.TipoDispositivoCombobox.Location = new System.Drawing.Point(60, 159);
                        this.TipoDispositivoCombobox.MaxDropDownItems = 4;
                        this.TipoDispositivoCombobox.MouseState = MaterialSkin.MouseState.OUT;
                        this.TipoDispositivoCombobox.Name = "TipoDispositivoCombobox";
                        this.TipoDispositivoCombobox.Size = new System.Drawing.Size(267, 49);
                        this.TipoDispositivoCombobox.StartIndex = 0;
                        this.TipoDispositivoCombobox.TabIndex = 3;
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.Location = new System.Drawing.Point(170, 54);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(46, 19);
                        this.materialLabel2.TabIndex = 2;
                        this.materialLabel2.Text = "Marca";
                        // 
                        // MarcaCombobox
                        // 
                        this.MarcaCombobox.AutoResize = false;
                        this.MarcaCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.MarcaCombobox.Depth = 0;
                        this.MarcaCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                        this.MarcaCombobox.DropDownHeight = 174;
                        this.MarcaCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        this.MarcaCombobox.DropDownWidth = 121;
                        this.MarcaCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.MarcaCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.MarcaCombobox.FormattingEnabled = true;
                        this.MarcaCombobox.IntegralHeight = false;
                        this.MarcaCombobox.ItemHeight = 43;
                        this.MarcaCombobox.Location = new System.Drawing.Point(60, 76);
                        this.MarcaCombobox.MaxDropDownItems = 4;
                        this.MarcaCombobox.MouseState = MaterialSkin.MouseState.OUT;
                        this.MarcaCombobox.Name = "MarcaCombobox";
                        this.MarcaCombobox.Size = new System.Drawing.Size(267, 49);
                        this.MarcaCombobox.StartIndex = 0;
                        this.MarcaCombobox.TabIndex = 1;
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.Location = new System.Drawing.Point(31, 15);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(324, 19);
                        this.materialLabel1.TabIndex = 0;
                        this.materialLabel1.Text = "Seleccione un tipo de dispositivo y una marca";
                        // 
                        // FalloEncontradoTxt
                        // 
                        this.FalloEncontradoTxt.AnimateReadOnly = false;
                        this.FalloEncontradoTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.FalloEncontradoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.FalloEncontradoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.FalloEncontradoTxt.Depth = 0;
                        this.FalloEncontradoTxt.HideSelection = true;
                        this.FalloEncontradoTxt.Location = new System.Drawing.Point(28, 106);
                        this.FalloEncontradoTxt.MaxLength = 32767;
                        this.FalloEncontradoTxt.MouseState = MaterialSkin.MouseState.OUT;
                        this.FalloEncontradoTxt.Name = "FalloEncontradoTxt";
                        this.FalloEncontradoTxt.PasswordChar = '\0';
                        this.FalloEncontradoTxt.ReadOnly = false;
                        this.FalloEncontradoTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
                        this.FalloEncontradoTxt.SelectedText = "";
                        this.FalloEncontradoTxt.SelectionLength = 0;
                        this.FalloEncontradoTxt.SelectionStart = 0;
                        this.FalloEncontradoTxt.ShortcutsEnabled = true;
                        this.FalloEncontradoTxt.Size = new System.Drawing.Size(390, 157);
                        this.FalloEncontradoTxt.TabIndex = 1;
                        this.FalloEncontradoTxt.TabStop = false;
                        this.FalloEncontradoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.FalloEncontradoTxt.UseSystemPasswordChar = false;
                        // 
                        // materialLabel5
                        // 
                        this.materialLabel5.AutoSize = true;
                        this.materialLabel5.Depth = 0;
                        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel5.Location = new System.Drawing.Point(28, 84);
                        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel5.Name = "materialLabel5";
                        this.materialLabel5.Size = new System.Drawing.Size(120, 19);
                        this.materialLabel5.TabIndex = 8;
                        this.materialLabel5.Text = "Fallo encontrado";
                        // 
                        // materialLabel6
                        // 
                        this.materialLabel6.AutoSize = true;
                        this.materialLabel6.Depth = 0;
                        this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel6.Location = new System.Drawing.Point(28, 266);
                        this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel6.Name = "materialLabel6";
                        this.materialLabel6.Size = new System.Drawing.Size(286, 19);
                        this.materialLabel6.TabIndex = 10;
                        this.materialLabel6.Text = "Descripcion del fallo de parrte del cliente";
                        // 
                        // DescripcionDelClienteTxt
                        // 
                        this.DescripcionDelClienteTxt.AnimateReadOnly = false;
                        this.DescripcionDelClienteTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.DescripcionDelClienteTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.DescripcionDelClienteTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.DescripcionDelClienteTxt.Depth = 0;
                        this.DescripcionDelClienteTxt.HideSelection = true;
                        this.DescripcionDelClienteTxt.Location = new System.Drawing.Point(28, 288);
                        this.DescripcionDelClienteTxt.MaxLength = 32767;
                        this.DescripcionDelClienteTxt.MouseState = MaterialSkin.MouseState.OUT;
                        this.DescripcionDelClienteTxt.Name = "DescripcionDelClienteTxt";
                        this.DescripcionDelClienteTxt.PasswordChar = '\0';
                        this.DescripcionDelClienteTxt.ReadOnly = false;
                        this.DescripcionDelClienteTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
                        this.DescripcionDelClienteTxt.SelectedText = "";
                        this.DescripcionDelClienteTxt.SelectionLength = 0;
                        this.DescripcionDelClienteTxt.SelectionStart = 0;
                        this.DescripcionDelClienteTxt.ShortcutsEnabled = true;
                        this.DescripcionDelClienteTxt.Size = new System.Drawing.Size(390, 148);
                        this.DescripcionDelClienteTxt.TabIndex = 9;
                        this.DescripcionDelClienteTxt.TabStop = false;
                        this.DescripcionDelClienteTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.DescripcionDelClienteTxt.UseSystemPasswordChar = false;
                        // 
                        // materialButton2
                        // 
                        this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton2.Depth = 0;
                        this.materialButton2.HighEmphasis = true;
                        this.materialButton2.Icon = null;
                        this.materialButton2.Location = new System.Drawing.Point(432, 163);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(312, 36);
                        this.materialButton2.TabIndex = 11;
                        this.materialButton2.Text = "Agregar Informacion del dispositivo";
                        this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton2.UseAccentColor = false;
                        this.materialButton2.UseVisualStyleBackColor = true;
                        this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
                        // 
                        // InfoDispositivoDg
                        // 
                        this.InfoDispositivoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.InfoDispositivoDg.Location = new System.Drawing.Point(432, 262);
                        this.InfoDispositivoDg.Name = "InfoDispositivoDg";
                        this.InfoDispositivoDg.Size = new System.Drawing.Size(627, 524);
                        this.InfoDispositivoDg.TabIndex = 12;
                        this.InfoDispositivoDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoDispositivoDg_CellClick);
                        this.InfoDispositivoDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoDispositivoDg_CellContentClick);
                        this.InfoDispositivoDg.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.InfoDispositivoDg_DataError);
                        // 
                        // materialLabel7
                        // 
                        this.materialLabel7.AutoSize = true;
                        this.materialLabel7.Depth = 0;
                        this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel7.Location = new System.Drawing.Point(429, 84);
                        this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel7.Name = "materialLabel7";
                        this.materialLabel7.Size = new System.Drawing.Size(50, 19);
                        this.materialLabel7.TabIndex = 13;
                        this.materialLabel7.Text = "Buscar";
                        // 
                        // ProductoNombreFind
                        // 
                        this.ProductoNombreFind.AnimateReadOnly = false;
                        this.ProductoNombreFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.ProductoNombreFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.ProductoNombreFind.Depth = 0;
                        this.ProductoNombreFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.ProductoNombreFind.HideSelection = true;
                        this.ProductoNombreFind.LeadingIcon = global::SETEA_Sistema.Properties.Resources.busqueda_de_lupa1;
                        this.ProductoNombreFind.Location = new System.Drawing.Point(432, 106);
                        this.ProductoNombreFind.MaxLength = 32767;
                        this.ProductoNombreFind.MouseState = MaterialSkin.MouseState.OUT;
                        this.ProductoNombreFind.Name = "ProductoNombreFind";
                        this.ProductoNombreFind.PasswordChar = '\0';
                        this.ProductoNombreFind.PrefixSuffixText = null;
                        this.ProductoNombreFind.ReadOnly = false;
                        this.ProductoNombreFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.ProductoNombreFind.SelectedText = "";
                        this.ProductoNombreFind.SelectionLength = 0;
                        this.ProductoNombreFind.SelectionStart = 0;
                        this.ProductoNombreFind.ShortcutsEnabled = true;
                        this.ProductoNombreFind.Size = new System.Drawing.Size(627, 48);
                        this.ProductoNombreFind.TabIndex = 33;
                        this.ProductoNombreFind.TabStop = false;
                        this.ProductoNombreFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.ProductoNombreFind.TrailingIcon = null;
                        this.ProductoNombreFind.UseSystemPasswordChar = false;
                        this.ProductoNombreFind.TextChanged += new System.EventHandler(this.ProductoNombreFind_TextChanged);
                        // 
                        // materialButton3
                        // 
                        this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton3.Depth = 0;
                        this.materialButton3.HighEmphasis = true;
                        this.materialButton3.Icon = null;
                        this.materialButton3.Location = new System.Drawing.Point(884, 163);
                        this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton3.Name = "materialButton3";
                        this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton3.Size = new System.Drawing.Size(175, 36);
                        this.materialButton3.TabIndex = 34;
                        this.materialButton3.Text = "Editar informacion";
                        this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton3.UseAccentColor = false;
                        this.materialButton3.UseVisualStyleBackColor = true;
                        this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
                        // 
                        // materialButton4
                        // 
                        this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton4.Depth = 0;
                        this.materialButton4.HighEmphasis = true;
                        this.materialButton4.Icon = null;
                        this.materialButton4.Location = new System.Drawing.Point(867, 211);
                        this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton4.Name = "materialButton4";
                        this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton4.Size = new System.Drawing.Size(192, 36);
                        this.materialButton4.TabIndex = 35;
                        this.materialButton4.Text = "Eliminar Informacion";
                        this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton4.UseAccentColor = false;
                        this.materialButton4.UseVisualStyleBackColor = true;
                        this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
                        // 
                        // materialButton5
                        // 
                        this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton5.Depth = 0;
                        this.materialButton5.HighEmphasis = true;
                        this.materialButton5.Icon = null;
                        this.materialButton5.Location = new System.Drawing.Point(432, 211);
                        this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton5.Name = "materialButton5";
                        this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton5.Size = new System.Drawing.Size(343, 36);
                        this.materialButton5.TabIndex = 36;
                        this.materialButton5.Text = "Generar Reporte de toda la informacion";
                        this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton5.UseAccentColor = false;
                        this.materialButton5.UseVisualStyleBackColor = true;
                        this.materialButton5.Visible = false;
                        this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
                        // 
                        // materialButton6
                        // 
                        this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton6.Depth = 0;
                        this.materialButton6.HighEmphasis = true;
                        this.materialButton6.Icon = null;
                        this.materialButton6.Location = new System.Drawing.Point(28, 795);
                        this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton6.Name = "materialButton6";
                        this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton6.Size = new System.Drawing.Size(116, 36);
                        this.materialButton6.TabIndex = 37;
                        this.materialButton6.Text = "Limpiar Info";
                        this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton6.UseAccentColor = false;
                        this.materialButton6.UseVisualStyleBackColor = true;
                        this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
                        // 
                        // materialButton7
                        // 
                        this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton7.Depth = 0;
                        this.materialButton7.HighEmphasis = true;
                        this.materialButton7.Icon = null;
                        this.materialButton7.Location = new System.Drawing.Point(787, 795);
                        this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton7.Name = "materialButton7";
                        this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton7.Size = new System.Drawing.Size(271, 36);
                        this.materialButton7.TabIndex = 38;
                        this.materialButton7.Text = "Cargar toda la info de la tabla";
                        this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton7.UseAccentColor = false;
                        this.materialButton7.UseVisualStyleBackColor = true;
                        this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
                        // 
                        // Dispositivo_Informacion_RP
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1065, 833);
                        this.Controls.Add(this.materialButton7);
                        this.Controls.Add(this.materialButton6);
                        this.Controls.Add(this.materialButton5);
                        this.Controls.Add(this.materialButton4);
                        this.Controls.Add(this.materialButton3);
                        this.Controls.Add(this.ProductoNombreFind);
                        this.Controls.Add(this.materialLabel7);
                        this.Controls.Add(this.InfoDispositivoDg);
                        this.Controls.Add(this.materialButton2);
                        this.Controls.Add(this.materialLabel6);
                        this.Controls.Add(this.DescripcionDelClienteTxt);
                        this.Controls.Add(this.materialLabel5);
                        this.Controls.Add(this.FalloEncontradoTxt);
                        this.Controls.Add(this.materialCard1);
                        this.Name = "Dispositivo_Informacion_RP";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Dispositivo info";
                        this.Load += new System.EventHandler(this.Dispositivo_Informacion_RP_Load);
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.InfoDispositivoDg)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialComboBox TipoDispositivoCombobox;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialComboBox MarcaCombobox;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialLabel materialLabel4;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialMaskedTextBox IdRecienCreada;
                private MaterialSkin.Controls.MaterialMultiLineTextBox2 FalloEncontradoTxt;
                private MaterialSkin.Controls.MaterialLabel materialLabel5;
                private MaterialSkin.Controls.MaterialLabel materialLabel6;
                private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescripcionDelClienteTxt;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private System.Windows.Forms.DataGridView InfoDispositivoDg;
                private MaterialSkin.Controls.MaterialLabel materialLabel7;
                private MaterialSkin.Controls.MaterialTextBox2 ProductoNombreFind;
                private MaterialSkin.Controls.MaterialButton materialButton3;
                private MaterialSkin.Controls.MaterialButton materialButton4;
                private MaterialSkin.Controls.MaterialButton materialButton5;
                private MaterialSkin.Controls.MaterialButton materialButton6;
                private MaterialSkin.Controls.MaterialButton materialButton7;
        }
}