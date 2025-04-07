namespace SETEA_Sistema.SeccionRP
{
        partial class Estados_RP
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
                        this.NombreEstado = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.DescriocionEstado = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.MyDataEstados = new System.Windows.Forms.DataGridView();
                        this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
                        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialCard1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.MyDataEstados)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.DescriocionEstado);
                        this.materialCard1.Controls.Add(this.materialLabel2);
                        this.materialCard1.Controls.Add(this.NombreEstado);
                        this.materialCard1.Controls.Add(this.materialLabel1);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(9, 251);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(363, 250);
                        this.materialCard1.TabIndex = 0;
                        // 
                        // NombreEstado
                        // 
                        this.NombreEstado.AnimateReadOnly = false;
                        this.NombreEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.NombreEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.NombreEstado.Depth = 0;
                        this.NombreEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.NombreEstado.HideSelection = true;
                        this.NombreEstado.LeadingIcon = null;
                        this.NombreEstado.Location = new System.Drawing.Point(17, 36);
                        this.NombreEstado.MaxLength = 32767;
                        this.NombreEstado.MouseState = MaterialSkin.MouseState.OUT;
                        this.NombreEstado.Name = "NombreEstado";
                        this.NombreEstado.PasswordChar = '\0';
                        this.NombreEstado.PrefixSuffixText = null;
                        this.NombreEstado.ReadOnly = false;
                        this.NombreEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.NombreEstado.SelectedText = "";
                        this.NombreEstado.SelectionLength = 0;
                        this.NombreEstado.SelectionStart = 0;
                        this.NombreEstado.ShortcutsEnabled = true;
                        this.NombreEstado.Size = new System.Drawing.Size(326, 48);
                        this.NombreEstado.TabIndex = 1;
                        this.NombreEstado.TabStop = false;
                        this.NombreEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.NombreEstado.TrailingIcon = global::SETEA_Sistema.Properties.Resources.firma1;
                        this.NombreEstado.UseSystemPasswordChar = false;
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.Location = new System.Drawing.Point(17, 14);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(50, 19);
                        this.materialLabel1.TabIndex = 0;
                        this.materialLabel1.Text = "Estado";
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.Location = new System.Drawing.Point(17, 87);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(161, 19);
                        this.materialLabel2.TabIndex = 2;
                        this.materialLabel2.Text = "Descripcion del estado";
                        // 
                        // DescriocionEstado
                        // 
                        this.DescriocionEstado.AnimateReadOnly = false;
                        this.DescriocionEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.DescriocionEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.DescriocionEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
                        this.DescriocionEstado.Depth = 0;
                        this.DescriocionEstado.HideSelection = true;
                        this.DescriocionEstado.Location = new System.Drawing.Point(17, 109);
                        this.DescriocionEstado.MaxLength = 32767;
                        this.DescriocionEstado.MouseState = MaterialSkin.MouseState.OUT;
                        this.DescriocionEstado.Name = "DescriocionEstado";
                        this.DescriocionEstado.PasswordChar = '\0';
                        this.DescriocionEstado.ReadOnly = false;
                        this.DescriocionEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
                        this.DescriocionEstado.SelectedText = "";
                        this.DescriocionEstado.SelectionLength = 0;
                        this.DescriocionEstado.SelectionStart = 0;
                        this.DescriocionEstado.ShortcutsEnabled = true;
                        this.DescriocionEstado.Size = new System.Drawing.Size(329, 117);
                        this.DescriocionEstado.TabIndex = 3;
                        this.DescriocionEstado.TabStop = false;
                        this.DescriocionEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.DescriocionEstado.UseSystemPasswordChar = false;
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(434, 173);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(147, 36);
                        this.materialButton1.TabIndex = 1;
                        this.materialButton1.Text = "Agregar estado";
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
                        this.materialButton2.Location = new System.Drawing.Point(627, 173);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(131, 36);
                        this.materialButton2.TabIndex = 2;
                        this.materialButton2.Text = "Editar estado";
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
                        this.materialButton3.Location = new System.Drawing.Point(800, 173);
                        this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton3.Name = "materialButton3";
                        this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton3.Size = new System.Drawing.Size(148, 36);
                        this.materialButton3.TabIndex = 3;
                        this.materialButton3.Text = "Eliminar estado";
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
                        this.materialLabel3.Location = new System.Drawing.Point(6, 218);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(87, 19);
                        this.materialLabel3.TabIndex = 4;
                        this.materialLabel3.Text = "Informacion";
                        // 
                        // MyDataEstados
                        // 
                        this.MyDataEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.MyDataEstados.Location = new System.Drawing.Point(434, 218);
                        this.MyDataEstados.Name = "MyDataEstados";
                        this.MyDataEstados.Size = new System.Drawing.Size(514, 400);
                        this.MyDataEstados.TabIndex = 5;
                        this.MyDataEstados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataEstados_CellClick);
                        this.MyDataEstados.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MyDataEstados_DataError);
                        // 
                        // materialTextBox22
                        // 
                        this.materialTextBox22.AnimateReadOnly = false;
                        this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                        this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        this.materialTextBox22.Depth = 0;
                        this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialTextBox22.HideSelection = true;
                        this.materialTextBox22.LeadingIcon = global::SETEA_Sistema.Properties.Resources.busqueda_de_lupa1;
                        this.materialTextBox22.Location = new System.Drawing.Point(434, 114);
                        this.materialTextBox22.MaxLength = 32767;
                        this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
                        this.materialTextBox22.Name = "materialTextBox22";
                        this.materialTextBox22.PasswordChar = '\0';
                        this.materialTextBox22.PrefixSuffixText = null;
                        this.materialTextBox22.ReadOnly = false;
                        this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.materialTextBox22.SelectedText = "";
                        this.materialTextBox22.SelectionLength = 0;
                        this.materialTextBox22.SelectionStart = 0;
                        this.materialTextBox22.ShortcutsEnabled = true;
                        this.materialTextBox22.Size = new System.Drawing.Size(514, 48);
                        this.materialTextBox22.TabIndex = 33;
                        this.materialTextBox22.TabStop = false;
                        this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        this.materialTextBox22.TrailingIcon = null;
                        this.materialTextBox22.UseSystemPasswordChar = false;
                        this.materialTextBox22.TextChanged += new System.EventHandler(this.materialTextBox22_TextChanged);
                        // 
                        // materialLabel5
                        // 
                        this.materialLabel5.AutoSize = true;
                        this.materialLabel5.Depth = 0;
                        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel5.Location = new System.Drawing.Point(431, 81);
                        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel5.Name = "materialLabel5";
                        this.materialLabel5.Size = new System.Drawing.Size(254, 19);
                        this.materialLabel5.TabIndex = 32;
                        this.materialLabel5.Text = "Buscar Usuario por nombre o correo";
                        // 
                        // Estados_RP
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(969, 652);
                        this.Controls.Add(this.materialTextBox22);
                        this.Controls.Add(this.materialLabel5);
                        this.Controls.Add(this.MyDataEstados);
                        this.Controls.Add(this.materialLabel3);
                        this.Controls.Add(this.materialButton3);
                        this.Controls.Add(this.materialButton2);
                        this.Controls.Add(this.materialButton1);
                        this.Controls.Add(this.materialCard1);
                        this.Name = "Estados_RP";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Estados de reparacion";
                        this.Load += new System.EventHandler(this.Estados_RP_Load);
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.MyDataEstados)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private MaterialSkin.Controls.MaterialCard materialCard1;
                private MaterialSkin.Controls.MaterialTextBox2 NombreEstado;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriocionEstado;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private MaterialSkin.Controls.MaterialButton materialButton3;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private System.Windows.Forms.DataGridView MyDataEstados;
                private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
                private MaterialSkin.Controls.MaterialLabel materialLabel5;
        }
}