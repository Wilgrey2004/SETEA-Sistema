namespace SETEA_Sistema.CodigoDeVerificacion
{
        partial class ReceptorDeCodigoShow
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
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.MyCodigoDeConfimacionTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
                        this.materialCard1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.materialButton2);
                        this.materialCard1.Controls.Add(this.materialButton1);
                        this.materialCard1.Controls.Add(this.materialLabel1);
                        this.materialCard1.Controls.Add(this.MyCodigoDeConfimacionTxt);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(3, 64);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(409, 507);
                        this.materialCard1.TabIndex = 0;
                        // 
                        // materialButton2
                        // 
                        this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton2.Depth = 0;
                        this.materialButton2.HighEmphasis = true;
                        this.materialButton2.Icon = global::SETEA_Sistema.Properties.Resources.Aceprtar;
                        this.materialButton2.Location = new System.Drawing.Point(236, 299);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(114, 36);
                        this.materialButton2.TabIndex = 3;
                        this.materialButton2.Text = "Aceptar";
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
                        this.materialButton1.Icon = global::SETEA_Sistema.Properties.Resources.Cancelar;
                        this.materialButton1.Location = new System.Drawing.Point(61, 299);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(124, 36);
                        this.materialButton1.TabIndex = 2;
                        this.materialButton1.Text = "Cancelar";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.Location = new System.Drawing.Point(58, 171);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(292, 19);
                        this.materialLabel1.TabIndex = 1;
                        this.materialLabel1.Text = "Ingrese el codigo enviado al adminitrador";
                        // 
                        // MyCodigoDeConfimacionTxt
                        // 
                        this.MyCodigoDeConfimacionTxt.AllowPromptAsInput = true;
                        this.MyCodigoDeConfimacionTxt.AnimateReadOnly = false;
                        this.MyCodigoDeConfimacionTxt.AsciiOnly = false;
                        this.MyCodigoDeConfimacionTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.MyCodigoDeConfimacionTxt.BeepOnError = false;
                        this.MyCodigoDeConfimacionTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.MyCodigoDeConfimacionTxt.Depth = 0;
                        this.MyCodigoDeConfimacionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.MyCodigoDeConfimacionTxt.HidePromptOnLeave = false;
                        this.MyCodigoDeConfimacionTxt.HideSelection = true;
                        this.MyCodigoDeConfimacionTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
                        this.MyCodigoDeConfimacionTxt.LeadingIcon = global::SETEA_Sistema.Properties.Resources.producto_de_codigo_de_barras2;
                        this.MyCodigoDeConfimacionTxt.Location = new System.Drawing.Point(61, 213);
                        this.MyCodigoDeConfimacionTxt.Mask = "";
                        this.MyCodigoDeConfimacionTxt.MaxLength = 32767;
                        this.MyCodigoDeConfimacionTxt.MouseState = MaterialSkin.MouseState.OUT;
                        this.MyCodigoDeConfimacionTxt.Name = "MyCodigoDeConfimacionTxt";
                        this.MyCodigoDeConfimacionTxt.PasswordChar = '\0';
                        this.MyCodigoDeConfimacionTxt.PrefixSuffixText = null;
                        this.MyCodigoDeConfimacionTxt.PromptChar = '_';
                        this.MyCodigoDeConfimacionTxt.ReadOnly = false;
                        this.MyCodigoDeConfimacionTxt.RejectInputOnFirstFailure = false;
                        this.MyCodigoDeConfimacionTxt.ResetOnPrompt = true;
                        this.MyCodigoDeConfimacionTxt.ResetOnSpace = true;
                        this.MyCodigoDeConfimacionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.MyCodigoDeConfimacionTxt.SelectedText = "";
                        this.MyCodigoDeConfimacionTxt.SelectionLength = 0;
                        this.MyCodigoDeConfimacionTxt.SelectionStart = 0;
                        this.MyCodigoDeConfimacionTxt.ShortcutsEnabled = true;
                        this.MyCodigoDeConfimacionTxt.Size = new System.Drawing.Size(286, 48);
                        this.MyCodigoDeConfimacionTxt.SkipLiterals = true;
                        this.MyCodigoDeConfimacionTxt.TabIndex = 0;
                        this.MyCodigoDeConfimacionTxt.TabStop = false;
                        this.MyCodigoDeConfimacionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.MyCodigoDeConfimacionTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
                        this.MyCodigoDeConfimacionTxt.TrailingIcon = null;
                        this.MyCodigoDeConfimacionTxt.UseSystemPasswordChar = false;
                        this.MyCodigoDeConfimacionTxt.ValidatingType = null;
                        // 
                        // ReceptorDeCodigoShow
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(415, 574);
                        this.Controls.Add(this.materialCard1);
                        this.Name = "ReceptorDeCodigoShow";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Receptor de codigo";
                        this.Load += new System.EventHandler(this.ReceptorDeCodigoShow_Load);
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialMaskedTextBox MyCodigoDeConfimacionTxt;
        }
}