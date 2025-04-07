namespace SETEA_Sistema.SeccionRP
{
        partial class Cliente_Show_RPS
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
                        this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
                        this.FechaCliente = new System.Windows.Forms.DateTimePicker();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.DireccionCliente = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.CorreoCliente = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
                        this.TelefonoCliente = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
                        this.NombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
                        this.ProductoNombreFind = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
                        this.MyClienteInfoDG = new System.Windows.Forms.DataGridView();
                        this.materialCard1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.MyClienteInfoDG)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.materialFloatingActionButton1);
                        this.materialCard1.Controls.Add(this.FechaCliente);
                        this.materialCard1.Controls.Add(this.materialLabel3);
                        this.materialCard1.Controls.Add(this.materialLabel2);
                        this.materialCard1.Controls.Add(this.DireccionCliente);
                        this.materialCard1.Controls.Add(this.materialLabel1);
                        this.materialCard1.Controls.Add(this.CorreoCliente);
                        this.materialCard1.Controls.Add(this.materialLabel16);
                        this.materialCard1.Controls.Add(this.TelefonoCliente);
                        this.materialCard1.Controls.Add(this.materialLabel7);
                        this.materialCard1.Controls.Add(this.NombreCliente);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(4, 130);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(369, 536);
                        this.materialCard1.TabIndex = 0;
                        // 
                        // materialFloatingActionButton1
                        // 
                        this.materialFloatingActionButton1.Depth = 0;
                        this.materialFloatingActionButton1.Icon = global::SETEA_Sistema.Properties.Resources.escoba;
                        this.materialFloatingActionButton1.Location = new System.Drawing.Point(313, 0);
                        this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
                        this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
                        this.materialFloatingActionButton1.TabIndex = 44;
                        this.materialFloatingActionButton1.Text = "limpiar";
                        this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
                        this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
                        // 
                        // FechaCliente
                        // 
                        this.FechaCliente.Location = new System.Drawing.Point(16, 476);
                        this.FechaCliente.Name = "FechaCliente";
                        this.FechaCliente.Size = new System.Drawing.Size(337, 20);
                        this.FechaCliente.TabIndex = 36;
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel3.Location = new System.Drawing.Point(16, 438);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(161, 24);
                        this.materialLabel3.TabIndex = 35;
                        this.materialLabel3.Text = "Fecha del registro";
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel2.Location = new System.Drawing.Point(16, 342);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(181, 24);
                        this.materialLabel2.TabIndex = 33;
                        this.materialLabel2.Text = "Direccion del cliente";
                        // 
                        // DireccionCliente
                        // 
                        this.DireccionCliente.AnimateReadOnly = false;
                        this.DireccionCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.DireccionCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.DireccionCliente.Depth = 0;
                        this.DireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.DireccionCliente.HideSelection = true;
                        this.DireccionCliente.LeadingIcon = global::SETEA_Sistema.Properties.Resources.mapas_y_banderas;
                        this.DireccionCliente.Location = new System.Drawing.Point(16, 373);
                        this.DireccionCliente.MaxLength = 32767;
                        this.DireccionCliente.MouseState = MaterialSkin.MouseState.OUT;
                        this.DireccionCliente.Name = "DireccionCliente";
                        this.DireccionCliente.PasswordChar = '\0';
                        this.DireccionCliente.PrefixSuffixText = null;
                        this.DireccionCliente.ReadOnly = false;
                        this.DireccionCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.DireccionCliente.SelectedText = "";
                        this.DireccionCliente.SelectionLength = 0;
                        this.DireccionCliente.SelectionStart = 0;
                        this.DireccionCliente.ShortcutsEnabled = true;
                        this.DireccionCliente.Size = new System.Drawing.Size(337, 48);
                        this.DireccionCliente.TabIndex = 32;
                        this.DireccionCliente.TabStop = false;
                        this.DireccionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.DireccionCliente.TrailingIcon = null;
                        this.DireccionCliente.UseSystemPasswordChar = false;
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel1.Location = new System.Drawing.Point(16, 242);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(158, 24);
                        this.materialLabel1.TabIndex = 31;
                        this.materialLabel1.Text = "Correo del cliente";
                        // 
                        // CorreoCliente
                        // 
                        this.CorreoCliente.AnimateReadOnly = false;
                        this.CorreoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.CorreoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.CorreoCliente.Depth = 0;
                        this.CorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.CorreoCliente.HideSelection = true;
                        this.CorreoCliente.LeadingIcon = global::SETEA_Sistema.Properties.Resources.gmail;
                        this.CorreoCliente.Location = new System.Drawing.Point(16, 273);
                        this.CorreoCliente.MaxLength = 32767;
                        this.CorreoCliente.MouseState = MaterialSkin.MouseState.OUT;
                        this.CorreoCliente.Name = "CorreoCliente";
                        this.CorreoCliente.PasswordChar = '\0';
                        this.CorreoCliente.PrefixSuffixText = null;
                        this.CorreoCliente.ReadOnly = false;
                        this.CorreoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.CorreoCliente.SelectedText = "";
                        this.CorreoCliente.SelectionLength = 0;
                        this.CorreoCliente.SelectionStart = 0;
                        this.CorreoCliente.ShortcutsEnabled = true;
                        this.CorreoCliente.Size = new System.Drawing.Size(337, 48);
                        this.CorreoCliente.TabIndex = 30;
                        this.CorreoCliente.TabStop = false;
                        this.CorreoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.CorreoCliente.TrailingIcon = null;
                        this.CorreoCliente.UseSystemPasswordChar = false;
                        // 
                        // materialLabel16
                        // 
                        this.materialLabel16.AutoSize = true;
                        this.materialLabel16.Depth = 0;
                        this.materialLabel16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel16.Location = new System.Drawing.Point(16, 143);
                        this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel16.Name = "materialLabel16";
                        this.materialLabel16.Size = new System.Drawing.Size(177, 24);
                        this.materialLabel16.TabIndex = 29;
                        this.materialLabel16.Text = "Telefono del cliente";
                        // 
                        // TelefonoCliente
                        // 
                        this.TelefonoCliente.AnimateReadOnly = false;
                        this.TelefonoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.TelefonoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.TelefonoCliente.Depth = 0;
                        this.TelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.TelefonoCliente.HideSelection = true;
                        this.TelefonoCliente.LeadingIcon = global::SETEA_Sistema.Properties.Resources.llamada_telefonica;
                        this.TelefonoCliente.Location = new System.Drawing.Point(16, 174);
                        this.TelefonoCliente.MaxLength = 32767;
                        this.TelefonoCliente.MouseState = MaterialSkin.MouseState.OUT;
                        this.TelefonoCliente.Name = "TelefonoCliente";
                        this.TelefonoCliente.PasswordChar = '\0';
                        this.TelefonoCliente.PrefixSuffixText = null;
                        this.TelefonoCliente.ReadOnly = false;
                        this.TelefonoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.TelefonoCliente.SelectedText = "";
                        this.TelefonoCliente.SelectionLength = 0;
                        this.TelefonoCliente.SelectionStart = 0;
                        this.TelefonoCliente.ShortcutsEnabled = true;
                        this.TelefonoCliente.Size = new System.Drawing.Size(337, 48);
                        this.TelefonoCliente.TabIndex = 28;
                        this.TelefonoCliente.TabStop = false;
                        this.TelefonoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.TelefonoCliente.TrailingIcon = null;
                        this.TelefonoCliente.UseSystemPasswordChar = false;
                        // 
                        // materialLabel7
                        // 
                        this.materialLabel7.AutoSize = true;
                        this.materialLabel7.Depth = 0;
                        this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel7.Location = new System.Drawing.Point(16, 41);
                        this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel7.Name = "materialLabel7";
                        this.materialLabel7.Size = new System.Drawing.Size(174, 24);
                        this.materialLabel7.TabIndex = 27;
                        this.materialLabel7.Text = "Nombre del cliente ";
                        // 
                        // NombreCliente
                        // 
                        this.NombreCliente.AnimateReadOnly = false;
                        this.NombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.NombreCliente.Depth = 0;
                        this.NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NombreCliente.HideSelection = true;
                        this.NombreCliente.LeadingIcon = global::SETEA_Sistema.Properties.Resources.firma;
                        this.NombreCliente.Location = new System.Drawing.Point(16, 77);
                        this.NombreCliente.MaxLength = 32767;
                        this.NombreCliente.MouseState = MaterialSkin.MouseState.OUT;
                        this.NombreCliente.Name = "NombreCliente";
                        this.NombreCliente.PasswordChar = '\0';
                        this.NombreCliente.PrefixSuffixText = null;
                        this.NombreCliente.ReadOnly = false;
                        this.NombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NombreCliente.SelectedText = "";
                        this.NombreCliente.SelectionLength = 0;
                        this.NombreCliente.SelectionStart = 0;
                        this.NombreCliente.ShortcutsEnabled = true;
                        this.NombreCliente.Size = new System.Drawing.Size(337, 48);
                        this.NombreCliente.TabIndex = 26;
                        this.NombreCliente.TabStop = false;
                        this.NombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.NombreCliente.TrailingIcon = null;
                        this.NombreCliente.UseSystemPasswordChar = false;
                        // 
                        // materialLabel4
                        // 
                        this.materialLabel4.AutoSize = true;
                        this.materialLabel4.Depth = 0;
                        this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel4.Location = new System.Drawing.Point(4, 92);
                        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel4.Name = "materialLabel4";
                        this.materialLabel4.Size = new System.Drawing.Size(200, 24);
                        this.materialLabel4.TabIndex = 37;
                        this.materialLabel4.Text = "Informacon del cliente";
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(443, 174);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(150, 36);
                        this.materialButton1.TabIndex = 38;
                        this.materialButton1.Text = "Agregar cliente";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // materialButton2
                        // 
                        this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton2.Depth = 0;
                        this.materialButton2.HighEmphasis = true;
                        this.materialButton2.Icon = null;
                        this.materialButton2.Location = new System.Drawing.Point(601, 174);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(133, 36);
                        this.materialButton2.TabIndex = 39;
                        this.materialButton2.Text = "Editar cliente";
                        this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton2.UseAccentColor = false;
                        this.materialButton2.UseVisualStyleBackColor = true;
                        this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
                        // 
                        // materialButton3
                        // 
                        this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton3.Depth = 0;
                        this.materialButton3.HighEmphasis = true;
                        this.materialButton3.Icon = null;
                        this.materialButton3.Location = new System.Drawing.Point(742, 174);
                        this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton3.Name = "materialButton3";
                        this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton3.Size = new System.Drawing.Size(150, 36);
                        this.materialButton3.TabIndex = 40;
                        this.materialButton3.Text = "Eliminar cliente";
                        this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton3.UseAccentColor = false;
                        this.materialButton3.UseVisualStyleBackColor = true;
                        this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
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
                        this.ProductoNombreFind.Location = new System.Drawing.Point(443, 117);
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
                        this.ProductoNombreFind.Size = new System.Drawing.Size(449, 48);
                        this.ProductoNombreFind.TabIndex = 42;
                        this.ProductoNombreFind.TabStop = false;
                        this.ProductoNombreFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.ProductoNombreFind.TrailingIcon = null;
                        this.ProductoNombreFind.UseSystemPasswordChar = false;
                        this.ProductoNombreFind.TextChanged += new System.EventHandler(this.ProductoNombreFind_TextChanged);
                        // 
                        // materialLabel5
                        // 
                        this.materialLabel5.AutoSize = true;
                        this.materialLabel5.Depth = 0;
                        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel5.Location = new System.Drawing.Point(440, 95);
                        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel5.Name = "materialLabel5";
                        this.materialLabel5.Size = new System.Drawing.Size(50, 19);
                        this.materialLabel5.TabIndex = 41;
                        this.materialLabel5.Text = "Buscar";
                        // 
                        // MyClienteInfoDG
                        // 
                        this.MyClienteInfoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.MyClienteInfoDG.Location = new System.Drawing.Point(443, 229);
                        this.MyClienteInfoDG.Name = "MyClienteInfoDG";
                        this.MyClienteInfoDG.Size = new System.Drawing.Size(448, 437);
                        this.MyClienteInfoDG.TabIndex = 43;
                        this.MyClienteInfoDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyClienteInfoDG_CellClick);
                        this.MyClienteInfoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyClienteInfoDG_CellContentClick);
                        this.MyClienteInfoDG.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MyClienteInfoDG_DataError);
                        // 
                        // Cliente_Show_RPS
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(919, 677);
                        this.Controls.Add(this.MyClienteInfoDG);
                        this.Controls.Add(this.ProductoNombreFind);
                        this.Controls.Add(this.materialLabel5);
                        this.Controls.Add(this.materialButton3);
                        this.Controls.Add(this.materialButton2);
                        this.Controls.Add(this.materialButton1);
                        this.Controls.Add(this.materialLabel4);
                        this.Controls.Add(this.materialCard1);
                        this.Name = "Cliente_Show_RPS";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Clientes";
                        this.Load += new System.EventHandler(this.Cliente_Show_RPS_Load);
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.MyClienteInfoDG)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialTextBox2 DireccionCliente;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialTextBox2 CorreoCliente;
                private MaterialSkin.Controls.MaterialLabel materialLabel16;
                private MaterialSkin.Controls.MaterialTextBox2 TelefonoCliente;
                private MaterialSkin.Controls.MaterialLabel materialLabel7;
                private MaterialSkin.Controls.MaterialTextBox2 NombreCliente;
                private System.Windows.Forms.DateTimePicker FechaCliente;
                private MaterialSkin.Controls.MaterialLabel materialLabel4;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private MaterialSkin.Controls.MaterialButton materialButton3;
                private MaterialSkin.Controls.MaterialTextBox2 ProductoNombreFind;
                private MaterialSkin.Controls.MaterialLabel materialLabel5;
                private System.Windows.Forms.DataGridView MyClienteInfoDG;
                private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        }
}