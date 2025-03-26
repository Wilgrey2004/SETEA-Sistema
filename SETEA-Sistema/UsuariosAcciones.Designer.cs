namespace SETEA_Sistema
{
        partial class UsuariosAcciones
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
                        this.fechaCreacionUser = new System.Windows.Forms.DateTimePicker();
                        this.correoUser = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.nameUser = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.passUser = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.UserId = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.Acceptar = new MaterialSkin.Controls.MaterialButton();
                        this.materialCard1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.Acceptar);
                        this.materialCard1.Controls.Add(this.fechaCreacionUser);
                        this.materialCard1.Controls.Add(this.correoUser);
                        this.materialCard1.Controls.Add(this.nameUser);
                        this.materialCard1.Controls.Add(this.passUser);
                        this.materialCard1.Controls.Add(this.UserId);
                        this.materialCard1.Controls.Add(this.materialLabel6);
                        this.materialCard1.Controls.Add(this.materialLabel5);
                        this.materialCard1.Controls.Add(this.materialLabel4);
                        this.materialCard1.Controls.Add(this.materialLabel3);
                        this.materialCard1.Controls.Add(this.materialLabel2);
                        this.materialCard1.Controls.Add(this.materialLabel1);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(63, 78);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(798, 374);
                        this.materialCard1.TabIndex = 0;
                        this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
                        // 
                        // fechaCreacionUser
                        // 
                        this.fechaCreacionUser.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
                        this.fechaCreacionUser.Location = new System.Drawing.Point(409, 182);
                        this.fechaCreacionUser.Name = "fechaCreacionUser";
                        this.fechaCreacionUser.Size = new System.Drawing.Size(245, 20);
                        this.fechaCreacionUser.TabIndex = 12;
                        // 
                        // correoUser
                        // 
                        this.correoUser.AllowPromptAsInput = true;
                        this.correoUser.AnimateReadOnly = false;
                        this.correoUser.AsciiOnly = false;
                        this.correoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.correoUser.BeepOnError = false;
                        this.correoUser.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.correoUser.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.correoUser.Depth = 0;
                        this.correoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.correoUser.HidePromptOnLeave = false;
                        this.correoUser.HideSelection = true;
                        this.correoUser.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.correoUser.LeadingIcon = null;
                        this.correoUser.Location = new System.Drawing.Point(531, 104);
                        this.correoUser.Mask = "";
                        this.correoUser.MaxLength = 32767;
                        this.correoUser.MouseState = MaterialSkin.MouseState.OUT;
                        this.correoUser.Name = "correoUser";
                        this.correoUser.PasswordChar = '\0';
                        this.correoUser.PrefixSuffixText = null;
                        this.correoUser.PromptChar = '_';
                        this.correoUser.ReadOnly = false;
                        this.correoUser.RejectInputOnFirstFailure = false;
                        this.correoUser.ResetOnPrompt = true;
                        this.correoUser.ResetOnSpace = true;
                        this.correoUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.correoUser.SelectedText = "";
                        this.correoUser.SelectionLength = 0;
                        this.correoUser.SelectionStart = 0;
                        this.correoUser.ShortcutsEnabled = true;
                        this.correoUser.Size = new System.Drawing.Size(250, 48);
                        this.correoUser.SkipLiterals = true;
                        this.correoUser.TabIndex = 10;
                        this.correoUser.TabStop = false;
                        this.correoUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.correoUser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.correoUser.TrailingIcon = null;
                        this.correoUser.UseSystemPasswordChar = false;
                        this.correoUser.ValidatingType = null;
                        // 
                        // nameUser
                        // 
                        this.nameUser.AllowPromptAsInput = true;
                        this.nameUser.AnimateReadOnly = false;
                        this.nameUser.AsciiOnly = false;
                        this.nameUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.nameUser.BeepOnError = false;
                        this.nameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.nameUser.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.nameUser.Depth = 0;
                        this.nameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.nameUser.HidePromptOnLeave = false;
                        this.nameUser.HideSelection = true;
                        this.nameUser.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.nameUser.LeadingIcon = null;
                        this.nameUser.Location = new System.Drawing.Point(273, 104);
                        this.nameUser.Mask = "";
                        this.nameUser.MaxLength = 32767;
                        this.nameUser.MouseState = MaterialSkin.MouseState.OUT;
                        this.nameUser.Name = "nameUser";
                        this.nameUser.PasswordChar = '\0';
                        this.nameUser.PrefixSuffixText = null;
                        this.nameUser.PromptChar = '_';
                        this.nameUser.ReadOnly = false;
                        this.nameUser.RejectInputOnFirstFailure = false;
                        this.nameUser.ResetOnPrompt = true;
                        this.nameUser.ResetOnSpace = true;
                        this.nameUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.nameUser.SelectedText = "";
                        this.nameUser.SelectionLength = 0;
                        this.nameUser.SelectionStart = 0;
                        this.nameUser.ShortcutsEnabled = true;
                        this.nameUser.Size = new System.Drawing.Size(250, 48);
                        this.nameUser.SkipLiterals = true;
                        this.nameUser.TabIndex = 8;
                        this.nameUser.TabStop = false;
                        this.nameUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.nameUser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.nameUser.TrailingIcon = null;
                        this.nameUser.UseSystemPasswordChar = false;
                        this.nameUser.ValidatingType = null;
                        // 
                        // passUser
                        // 
                        this.passUser.AllowPromptAsInput = true;
                        this.passUser.AnimateReadOnly = false;
                        this.passUser.AsciiOnly = false;
                        this.passUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.passUser.BeepOnError = false;
                        this.passUser.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.passUser.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.passUser.Depth = 0;
                        this.passUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.passUser.HidePromptOnLeave = false;
                        this.passUser.HideSelection = true;
                        this.passUser.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.passUser.LeadingIcon = null;
                        this.passUser.Location = new System.Drawing.Point(148, 181);
                        this.passUser.Mask = "";
                        this.passUser.MaxLength = 32767;
                        this.passUser.MouseState = MaterialSkin.MouseState.OUT;
                        this.passUser.Name = "passUser";
                        this.passUser.PasswordChar = '\0';
                        this.passUser.PrefixSuffixText = null;
                        this.passUser.PromptChar = '_';
                        this.passUser.ReadOnly = false;
                        this.passUser.RejectInputOnFirstFailure = false;
                        this.passUser.ResetOnPrompt = true;
                        this.passUser.ResetOnSpace = true;
                        this.passUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.passUser.SelectedText = "";
                        this.passUser.SelectionLength = 0;
                        this.passUser.SelectionStart = 0;
                        this.passUser.ShortcutsEnabled = true;
                        this.passUser.Size = new System.Drawing.Size(250, 48);
                        this.passUser.SkipLiterals = true;
                        this.passUser.TabIndex = 7;
                        this.passUser.TabStop = false;
                        this.passUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.passUser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.passUser.TrailingIcon = null;
                        this.passUser.UseSystemPasswordChar = false;
                        this.passUser.ValidatingType = null;
                        // 
                        // UserId
                        // 
                        this.UserId.AllowPromptAsInput = true;
                        this.UserId.AnimateReadOnly = true;
                        this.UserId.AsciiOnly = false;
                        this.UserId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.UserId.BeepOnError = false;
                        this.UserId.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.UserId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.UserId.Depth = 0;
                        this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.UserId.HidePromptOnLeave = false;
                        this.UserId.HideSelection = true;
                        this.UserId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.UserId.LeadingIcon = null;
                        this.UserId.Location = new System.Drawing.Point(17, 103);
                        this.UserId.Mask = "";
                        this.UserId.MaxLength = 32767;
                        this.UserId.MouseState = MaterialSkin.MouseState.OUT;
                        this.UserId.Name = "UserId";
                        this.UserId.PasswordChar = '\0';
                        this.UserId.PrefixSuffixText = null;
                        this.UserId.PromptChar = '_';
                        this.UserId.ReadOnly = false;
                        this.UserId.RejectInputOnFirstFailure = false;
                        this.UserId.ResetOnPrompt = true;
                        this.UserId.ResetOnSpace = true;
                        this.UserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.UserId.SelectedText = "";
                        this.UserId.SelectionLength = 0;
                        this.UserId.SelectionStart = 0;
                        this.UserId.ShortcutsEnabled = true;
                        this.UserId.Size = new System.Drawing.Size(250, 48);
                        this.UserId.SkipLiterals = true;
                        this.UserId.TabIndex = 6;
                        this.UserId.TabStop = false;
                        this.UserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        this.UserId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.UserId.TrailingIcon = null;
                        this.UserId.UseSystemPasswordChar = false;
                        this.UserId.ValidatingType = null;
                        // 
                        // materialLabel6
                        // 
                        this.materialLabel6.AutoSize = true;
                        this.materialLabel6.Depth = 0;
                        this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel6.Location = new System.Drawing.Point(639, 82);
                        this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel6.Name = "materialLabel6";
                        this.materialLabel6.Size = new System.Drawing.Size(47, 19);
                        this.materialLabel6.TabIndex = 5;
                        this.materialLabel6.Text = "Correo";
                        // 
                        // materialLabel5
                        // 
                        this.materialLabel5.AutoSize = true;
                        this.materialLabel5.Depth = 0;
                        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel5.Location = new System.Drawing.Point(465, 160);
                        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel5.Name = "materialLabel5";
                        this.materialLabel5.Size = new System.Drawing.Size(129, 19);
                        this.materialLabel5.TabIndex = 4;
                        this.materialLabel5.Text = "Fecha de creacion";
                        // 
                        // materialLabel4
                        // 
                        this.materialLabel4.AutoSize = true;
                        this.materialLabel4.Depth = 0;
                        this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel4.Location = new System.Drawing.Point(370, 82);
                        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel4.Name = "materialLabel4";
                        this.materialLabel4.Size = new System.Drawing.Size(57, 19);
                        this.materialLabel4.TabIndex = 3;
                        this.materialLabel4.Text = "Nombre";
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.Location = new System.Drawing.Point(245, 159);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(82, 19);
                        this.materialLabel3.TabIndex = 2;
                        this.materialLabel3.Text = "Contraseña";
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.Location = new System.Drawing.Point(134, 81);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(16, 19);
                        this.materialLabel2.TabIndex = 1;
                        this.materialLabel2.Text = "ID";
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                        this.materialLabel1.Location = new System.Drawing.Point(318, 29);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(160, 24);
                        this.materialLabel1.TabIndex = 0;
                        this.materialLabel1.Text = "Datos Del Usuario";
                        // 
                        // Acceptar
                        // 
                        this.Acceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.Acceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.Acceptar.Depth = 0;
                        this.Acceptar.HighEmphasis = true;
                        this.Acceptar.Icon = null;
                        this.Acceptar.Location = new System.Drawing.Point(335, 281);
                        this.Acceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.Acceptar.MouseState = MaterialSkin.MouseState.HOVER;
                        this.Acceptar.Name = "Acceptar";
                        this.Acceptar.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.Acceptar.Size = new System.Drawing.Size(86, 36);
                        this.Acceptar.TabIndex = 13;
                        this.Acceptar.Text = "Aceptar Edicion";
                        this.Acceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.Acceptar.UseAccentColor = false;
                        this.Acceptar.UseVisualStyleBackColor = true;
                        this.Acceptar.Click += new System.EventHandler(this.Acceptar_Click);
                        // 
                        // UsuariosAcciones
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(924, 469);
                        this.Controls.Add(this.materialCard1);
                        this.Name = "UsuariosAcciones";
                        this.Text = "Usuarios";
                        this.Load += new System.EventHandler(this.UsuariosAcciones_Load);
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialLabel materialLabel6;
                private MaterialSkin.Controls.MaterialLabel materialLabel5;
                private MaterialSkin.Controls.MaterialLabel materialLabel4;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialMaskedTextBox correoUser;
                private MaterialSkin.Controls.MaterialMaskedTextBox nameUser;
                private MaterialSkin.Controls.MaterialMaskedTextBox passUser;
                private MaterialSkin.Controls.MaterialMaskedTextBox UserId;
                private System.Windows.Forms.DateTimePicker fechaCreacionUser;
                private MaterialSkin.Controls.MaterialButton Acceptar;
        }
}