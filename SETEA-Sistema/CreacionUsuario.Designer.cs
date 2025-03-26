namespace SETEA_Sistema
{
        partial class CreacionUsuario
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreacionUsuario));
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.NewName = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.NewCorreo = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.NewPass = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel1.Location = new System.Drawing.Point(35, 125);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(72, 24);
                        this.materialLabel1.TabIndex = 0;
                        this.materialLabel1.Text = "Nombre";
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel2.Location = new System.Drawing.Point(35, 186);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(61, 24);
                        this.materialLabel2.TabIndex = 1;
                        this.materialLabel2.Text = "Correo";
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel3.Location = new System.Drawing.Point(35, 248);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(104, 24);
                        this.materialLabel3.TabIndex = 2;
                        this.materialLabel3.Text = "Contraseña";
                        // 
                        // NewName
                        // 
                        this.NewName.AllowPromptAsInput = true;
                        this.NewName.AnimateReadOnly = false;
                        this.NewName.AsciiOnly = false;
                        this.NewName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NewName.BeepOnError = false;
                        this.NewName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NewName.Depth = 0;
                        this.NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NewName.HidePromptOnLeave = false;
                        this.NewName.HideSelection = true;
                        this.NewName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.NewName.LeadingIcon = null;
                        this.NewName.Location = new System.Drawing.Point(342, 133);
                        this.NewName.Mask = "";
                        this.NewName.MaxLength = 32767;
                        this.NewName.MouseState = MaterialSkin.MouseState.OUT;
                        this.NewName.Name = "NewName";
                        this.NewName.PasswordChar = '\0';
                        this.NewName.PrefixSuffixText = null;
                        this.NewName.PromptChar = '_';
                        this.NewName.ReadOnly = false;
                        this.NewName.RejectInputOnFirstFailure = false;
                        this.NewName.ResetOnPrompt = true;
                        this.NewName.ResetOnSpace = true;
                        this.NewName.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NewName.SelectedText = "";
                        this.NewName.SelectionLength = 0;
                        this.NewName.SelectionStart = 0;
                        this.NewName.ShortcutsEnabled = true;
                        this.NewName.Size = new System.Drawing.Size(250, 48);
                        this.NewName.SkipLiterals = true;
                        this.NewName.TabIndex = 5;
                        this.NewName.TabStop = false;
                        this.NewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.NewName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NewName.TrailingIcon = null;
                        this.NewName.UseSystemPasswordChar = false;
                        this.NewName.ValidatingType = null;
                        // 
                        // NewCorreo
                        // 
                        this.NewCorreo.AllowPromptAsInput = true;
                        this.NewCorreo.AnimateReadOnly = false;
                        this.NewCorreo.AsciiOnly = false;
                        this.NewCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NewCorreo.BeepOnError = false;
                        this.NewCorreo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NewCorreo.Depth = 0;
                        this.NewCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NewCorreo.HidePromptOnLeave = false;
                        this.NewCorreo.HideSelection = true;
                        this.NewCorreo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.NewCorreo.LeadingIcon = null;
                        this.NewCorreo.Location = new System.Drawing.Point(342, 194);
                        this.NewCorreo.Mask = "";
                        this.NewCorreo.MaxLength = 32767;
                        this.NewCorreo.MouseState = MaterialSkin.MouseState.OUT;
                        this.NewCorreo.Name = "NewCorreo";
                        this.NewCorreo.PasswordChar = '\0';
                        this.NewCorreo.PrefixSuffixText = null;
                        this.NewCorreo.PromptChar = '_';
                        this.NewCorreo.ReadOnly = false;
                        this.NewCorreo.RejectInputOnFirstFailure = false;
                        this.NewCorreo.ResetOnPrompt = true;
                        this.NewCorreo.ResetOnSpace = true;
                        this.NewCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NewCorreo.SelectedText = "";
                        this.NewCorreo.SelectionLength = 0;
                        this.NewCorreo.SelectionStart = 0;
                        this.NewCorreo.ShortcutsEnabled = true;
                        this.NewCorreo.Size = new System.Drawing.Size(250, 48);
                        this.NewCorreo.SkipLiterals = true;
                        this.NewCorreo.TabIndex = 6;
                        this.NewCorreo.TabStop = false;
                        this.NewCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.NewCorreo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NewCorreo.TrailingIcon = null;
                        this.NewCorreo.UseSystemPasswordChar = false;
                        this.NewCorreo.ValidatingType = null;
                        // 
                        // NewPass
                        // 
                        this.NewPass.AllowPromptAsInput = true;
                        this.NewPass.AnimateReadOnly = false;
                        this.NewPass.AsciiOnly = false;
                        this.NewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NewPass.BeepOnError = false;
                        this.NewPass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NewPass.Depth = 0;
                        this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NewPass.HidePromptOnLeave = false;
                        this.NewPass.HideSelection = true;
                        this.NewPass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.NewPass.LeadingIcon = null;
                        this.NewPass.Location = new System.Drawing.Point(342, 248);
                        this.NewPass.Mask = "";
                        this.NewPass.MaxLength = 32767;
                        this.NewPass.MouseState = MaterialSkin.MouseState.OUT;
                        this.NewPass.Name = "NewPass";
                        this.NewPass.PasswordChar = '#';
                        this.NewPass.PrefixSuffixText = null;
                        this.NewPass.PromptChar = '_';
                        this.NewPass.ReadOnly = false;
                        this.NewPass.RejectInputOnFirstFailure = false;
                        this.NewPass.ResetOnPrompt = true;
                        this.NewPass.ResetOnSpace = true;
                        this.NewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NewPass.SelectedText = "";
                        this.NewPass.SelectionLength = 0;
                        this.NewPass.SelectionStart = 0;
                        this.NewPass.ShortcutsEnabled = true;
                        this.NewPass.Size = new System.Drawing.Size(250, 48);
                        this.NewPass.SkipLiterals = true;
                        this.NewPass.TabIndex = 7;
                        this.NewPass.TabStop = false;
                        this.NewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.NewPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.NewPass.TrailingIcon = null;
                        this.NewPass.UseSystemPasswordChar = false;
                        this.NewPass.ValidatingType = null;
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(39, 310);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(132, 36);
                        this.materialButton1.TabIndex = 9;
                        this.materialButton1.Text = "Crear Usuario";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // linkLabel1
                        // 
                        this.linkLabel1.AutoSize = true;
                        this.linkLabel1.Location = new System.Drawing.Point(468, 341);
                        this.linkLabel1.Name = "linkLabel1";
                        this.linkLabel1.Size = new System.Drawing.Size(124, 13);
                        this.linkLabel1.TabIndex = 10;
                        this.linkLabel1.TabStop = true;
                        this.linkLabel1.Text = "Ya Creacte Tu Usuario ?";
                        this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = global::SETEA_Sistema.Properties.Resources.LogoSeteaHD;
                        this.pictureBox1.Location = new System.Drawing.Point(581, 70);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(55, 57);
                        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.pictureBox1.TabIndex = 11;
                        this.pictureBox1.TabStop = false;
                        // 
                        // CreacionUsuario
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(642, 391);
                        this.Controls.Add(this.pictureBox1);
                        this.Controls.Add(this.linkLabel1);
                        this.Controls.Add(this.materialButton1);
                        this.Controls.Add(this.NewPass);
                        this.Controls.Add(this.NewCorreo);
                        this.Controls.Add(this.NewName);
                        this.Controls.Add(this.materialLabel3);
                        this.Controls.Add(this.materialLabel2);
                        this.Controls.Add(this.materialLabel1);
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "CreacionUsuario";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "CreacionUsuario";
                        this.Load += new System.EventHandler(this.CreacionUsuario_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialMaskedTextBox NewName;
                private MaterialSkin.Controls.MaterialMaskedTextBox NewCorreo;
                private MaterialSkin.Controls.MaterialMaskedTextBox NewPass;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private System.Windows.Forms.LinkLabel linkLabel1;
                private System.Windows.Forms.PictureBox pictureBox1;
        }
}