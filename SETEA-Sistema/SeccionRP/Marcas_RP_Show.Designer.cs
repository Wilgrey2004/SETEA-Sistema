namespace SETEA_Sistema.SeccionRP
{
        partial class Marcas_RP_Show
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
                        this.MyMarcasDG = new System.Windows.Forms.DataGridView();
                        this.NombreDeLasMarcas = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
                        this.AgregarMarca = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
                        ((System.ComponentModel.ISupportInitialize)(this.MyMarcasDG)).BeginInit();
                        this.materialCard1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // MyMarcasDG
                        // 
                        this.MyMarcasDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.MyMarcasDG.Location = new System.Drawing.Point(489, 67);
                        this.MyMarcasDG.Name = "MyMarcasDG";
                        this.MyMarcasDG.Size = new System.Drawing.Size(477, 616);
                        this.MyMarcasDG.TabIndex = 0;
                        this.MyMarcasDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyMarcasDG_CellClick);
                        this.MyMarcasDG.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MyMarcasDG_DataError);
                        // 
                        // NombreDeLasMarcas
                        // 
                        this.NombreDeLasMarcas.AnimateReadOnly = false;
                        this.NombreDeLasMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NombreDeLasMarcas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.NombreDeLasMarcas.Depth = 0;
                        this.NombreDeLasMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NombreDeLasMarcas.HideSelection = true;
                        this.NombreDeLasMarcas.LeadingIcon = null;
                        this.NombreDeLasMarcas.Location = new System.Drawing.Point(28, 50);
                        this.NombreDeLasMarcas.MaxLength = 32767;
                        this.NombreDeLasMarcas.MouseState = MaterialSkin.MouseState.OUT;
                        this.NombreDeLasMarcas.Name = "NombreDeLasMarcas";
                        this.NombreDeLasMarcas.PasswordChar = '\0';
                        this.NombreDeLasMarcas.PrefixSuffixText = null;
                        this.NombreDeLasMarcas.ReadOnly = false;
                        this.NombreDeLasMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NombreDeLasMarcas.SelectedText = "";
                        this.NombreDeLasMarcas.SelectionLength = 0;
                        this.NombreDeLasMarcas.SelectionStart = 0;
                        this.NombreDeLasMarcas.ShortcutsEnabled = true;
                        this.NombreDeLasMarcas.Size = new System.Drawing.Size(378, 48);
                        this.NombreDeLasMarcas.TabIndex = 1;
                        this.NombreDeLasMarcas.TabStop = false;
                        this.NombreDeLasMarcas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.NombreDeLasMarcas.TrailingIcon = null;
                        this.NombreDeLasMarcas.UseSystemPasswordChar = false;
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.Location = new System.Drawing.Point(28, 28);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(144, 19);
                        this.materialLabel1.TabIndex = 2;
                        this.materialLabel1.Text = "Nombre de la marca";
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.AgregarMarca);
                        this.materialCard1.Controls.Add(this.NombreDeLasMarcas);
                        this.materialCard1.Controls.Add(this.materialLabel1);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(14, 165);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(434, 185);
                        this.materialCard1.TabIndex = 3;
                        // 
                        // AgregarMarca
                        // 
                        this.AgregarMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.AgregarMarca.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.AgregarMarca.Depth = 0;
                        this.AgregarMarca.HighEmphasis = true;
                        this.AgregarMarca.Icon = null;
                        this.AgregarMarca.Location = new System.Drawing.Point(28, 122);
                        this.AgregarMarca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.AgregarMarca.MouseState = MaterialSkin.MouseState.HOVER;
                        this.AgregarMarca.Name = "AgregarMarca";
                        this.AgregarMarca.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.AgregarMarca.Size = new System.Drawing.Size(142, 36);
                        this.AgregarMarca.TabIndex = 3;
                        this.AgregarMarca.Text = "Agregar Marca";
                        this.AgregarMarca.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.AgregarMarca.UseAccentColor = false;
                        this.AgregarMarca.UseVisualStyleBackColor = true;
                        this.AgregarMarca.Click += new System.EventHandler(this.AgregarMarca_Click);
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.Location = new System.Drawing.Point(14, 132);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(65, 19);
                        this.materialLabel2.TabIndex = 4;
                        this.materialLabel2.Text = "Acciones";
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(26, 421);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(134, 36);
                        this.materialButton1.TabIndex = 5;
                        this.materialButton1.Text = "Elimina marca ";
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
                        this.materialButton2.Location = new System.Drawing.Point(26, 469);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(126, 36);
                        this.materialButton2.TabIndex = 6;
                        this.materialButton2.Text = "Editar Marca";
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
                        this.materialButton3.Location = new System.Drawing.Point(26, 544);
                        this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton3.Name = "materialButton3";
                        this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton3.Size = new System.Drawing.Size(240, 36);
                        this.materialButton3.TabIndex = 7;
                        this.materialButton3.Text = "Generar Reporte de Marcas";
                        this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton3.UseAccentColor = false;
                        this.materialButton3.UseVisualStyleBackColor = true;
                        this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.Location = new System.Drawing.Point(23, 396);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(65, 19);
                        this.materialLabel3.TabIndex = 8;
                        this.materialLabel3.Text = "Acciones";
                        // 
                        // materialLabel4
                        // 
                        this.materialLabel4.AutoSize = true;
                        this.materialLabel4.Depth = 0;
                        this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel4.Location = new System.Drawing.Point(23, 519);
                        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel4.Name = "materialLabel4";
                        this.materialLabel4.Size = new System.Drawing.Size(152, 19);
                        this.materialLabel4.TabIndex = 9;
                        this.materialLabel4.Text = "Acciones con la tabla";
                        // 
                        // Marcas_RP_Show
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(972, 689);
                        this.Controls.Add(this.materialLabel4);
                        this.Controls.Add(this.materialLabel3);
                        this.Controls.Add(this.materialButton3);
                        this.Controls.Add(this.materialButton2);
                        this.Controls.Add(this.materialButton1);
                        this.Controls.Add(this.materialLabel2);
                        this.Controls.Add(this.materialCard1);
                        this.Controls.Add(this.MyMarcasDG);
                        this.Name = "Marcas_RP_Show";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Marcas";
                        this.Load += new System.EventHandler(this.Marcas_RP_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.MyMarcasDG)).EndInit();
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.DataGridView MyMarcasDG;
                private MaterialSkin.Controls.MaterialTextBox2 NombreDeLasMarcas;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialButton AgregarMarca;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private MaterialSkin.Controls.MaterialButton materialButton3;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialLabel materialLabel4;
        }
}