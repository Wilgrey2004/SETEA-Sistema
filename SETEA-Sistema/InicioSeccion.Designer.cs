namespace SETEA_Sistema
{
        partial class InicioSeccion
        {
                /// <summary>
                /// Variable del diseñador necesaria.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Limpiar los recursos que se estén usando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
                protected override void Dispose( bool disposing ) {
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
                private void InitializeComponent() {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSeccion));
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.UserCorreo = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.UserPass = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.linkLabel1 = new System.Windows.Forms.LinkLabel();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
                        this.materialLabel1.Location = new System.Drawing.Point(64, 114);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(301, 29);
                        this.materialLabel1.TabIndex = 0;
                        this.materialLabel1.Text = "Nombre de usuario o correo";
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
                        this.materialLabel2.Location = new System.Drawing.Point(158, 233);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(124, 29);
                        this.materialLabel2.TabIndex = 1;
                        this.materialLabel2.Text = "Contraseña";
                        // 
                        // UserCorreo
                        // 
                        this.UserCorreo.AllowPromptAsInput = true;
                        this.UserCorreo.AnimateReadOnly = false;
                        this.UserCorreo.AsciiOnly = false;
                        this.UserCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.UserCorreo.BeepOnError = false;
                        this.UserCorreo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.UserCorreo.Depth = 0;
                        this.UserCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.UserCorreo.HidePromptOnLeave = false;
                        this.UserCorreo.HideSelection = true;
                        this.UserCorreo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.UserCorreo.LeadingIcon = global::SETEA_Sistema.Properties.Resources.avatar;
                        this.UserCorreo.Location = new System.Drawing.Point(95, 162);
                        this.UserCorreo.Mask = "";
                        this.UserCorreo.MaxLength = 32767;
                        this.UserCorreo.MouseState = MaterialSkin.MouseState.OUT;
                        this.UserCorreo.Name = "UserCorreo";
                        this.UserCorreo.PasswordChar = '\0';
                        this.UserCorreo.PrefixSuffixText = null;
                        this.UserCorreo.PromptChar = '_';
                        this.UserCorreo.ReadOnly = false;
                        this.UserCorreo.RejectInputOnFirstFailure = false;
                        this.UserCorreo.ResetOnPrompt = true;
                        this.UserCorreo.ResetOnSpace = true;
                        this.UserCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.UserCorreo.SelectedText = "";
                        this.UserCorreo.SelectionLength = 0;
                        this.UserCorreo.SelectionStart = 0;
                        this.UserCorreo.ShortcutsEnabled = true;
                        this.UserCorreo.Size = new System.Drawing.Size(250, 48);
                        this.UserCorreo.SkipLiterals = true;
                        this.UserCorreo.TabIndex = 2;
                        this.UserCorreo.TabStop = false;
                        this.UserCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.UserCorreo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.UserCorreo.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("UserCorreo.TrailingIcon")));
                        this.UserCorreo.UseSystemPasswordChar = false;
                        this.UserCorreo.ValidatingType = null;
                        // 
                        // UserPass
                        // 
                        this.UserPass.AllowPromptAsInput = true;
                        this.UserPass.AnimateReadOnly = false;
                        this.UserPass.AsciiOnly = false;
                        this.UserPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.UserPass.BeepOnError = false;
                        this.UserPass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.UserPass.Depth = 0;
                        this.UserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.UserPass.HidePromptOnLeave = false;
                        this.UserPass.HideSelection = true;
                        this.UserPass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.UserPass.LeadingIcon = global::SETEA_Sistema.Properties.Resources.avatar_de_usuario;
                        this.UserPass.Location = new System.Drawing.Point(95, 280);
                        this.UserPass.Mask = "";
                        this.UserPass.MaxLength = 32767;
                        this.UserPass.MouseState = MaterialSkin.MouseState.OUT;
                        this.UserPass.Name = "UserPass";
                        this.UserPass.PasswordChar = '#';
                        this.UserPass.PrefixSuffixText = null;
                        this.UserPass.PromptChar = '_';
                        this.UserPass.ReadOnly = false;
                        this.UserPass.RejectInputOnFirstFailure = false;
                        this.UserPass.ResetOnPrompt = true;
                        this.UserPass.ResetOnSpace = true;
                        this.UserPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.UserPass.SelectedText = "";
                        this.UserPass.SelectionLength = 0;
                        this.UserPass.SelectionStart = 0;
                        this.UserPass.ShortcutsEnabled = true;
                        this.UserPass.Size = new System.Drawing.Size(250, 48);
                        this.UserPass.SkipLiterals = true;
                        this.UserPass.TabIndex = 3;
                        this.UserPass.TabStop = false;
                        this.UserPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.UserPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.UserPass.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("UserPass.TrailingIcon")));
                        this.UserPass.UseSystemPasswordChar = false;
                        this.UserPass.ValidatingType = null;
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(177, 379);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(86, 36);
                        this.materialButton1.TabIndex = 4;
                        this.materialButton1.Text = "Acceder";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // linkLabel1
                        // 
                        this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SkyBlue;
                        this.linkLabel1.AutoSize = true;
                        this.linkLabel1.Location = new System.Drawing.Point(161, 432);
                        this.linkLabel1.Name = "linkLabel1";
                        this.linkLabel1.Size = new System.Drawing.Size(118, 13);
                        this.linkLabel1.TabIndex = 6;
                        this.linkLabel1.TabStop = true;
                        this.linkLabel1.Text = "No Tienes Un Usuario?";
                        this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = global::SETEA_Sistema.Properties.Resources.LogoSeteaHD;
                        this.pictureBox1.Location = new System.Drawing.Point(6, 402);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(83, 82);
                        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.pictureBox1.TabIndex = 7;
                        this.pictureBox1.TabStop = false;
                        // 
                        // InicioSeccion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(456, 490);
                        this.Controls.Add(this.pictureBox1);
                        this.Controls.Add(this.linkLabel1);
                        this.Controls.Add(this.materialButton1);
                        this.Controls.Add(this.UserPass);
                        this.Controls.Add(this.UserCorreo);
                        this.Controls.Add(this.materialLabel2);
                        this.Controls.Add(this.materialLabel1);
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "InicioSeccion";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Inicio De Seccion";
                        this.Load += new System.EventHandler(this.InicioSeccion_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialMaskedTextBox UserCorreo;
                private MaterialSkin.Controls.MaterialMaskedTextBox UserPass;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private System.Windows.Forms.LinkLabel linkLabel1;
                private System.Windows.Forms.PictureBox pictureBox1;
        }
}

