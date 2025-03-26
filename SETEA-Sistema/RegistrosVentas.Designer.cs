namespace SETEA_Sistema
{
        partial class RegistrosVentas
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
                        this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
                        this.Reportes = new System.Windows.Forms.TabPage();
                        this.LabelTotal = new MaterialSkin.Controls.MaterialLabel();
                        this.Fecha = new System.Windows.Forms.DateTimePicker();
                        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
                        this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
                        this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
                        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                        this.MyTextNameOrProduct = new MaterialSkin.Controls.MaterialTextBox();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        this.MyDataProductosCaja = new System.Windows.Forms.DataGridView();
                        this.materialTabControl1.SuspendLayout();
                        this.Reportes.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.MyDataProductosCaja)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // materialTabControl1
                        // 
                        this.materialTabControl1.Controls.Add(this.Reportes);
                        this.materialTabControl1.Depth = 0;
                        this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
                        this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialTabControl1.Multiline = true;
                        this.materialTabControl1.Name = "materialTabControl1";
                        this.materialTabControl1.SelectedIndex = 0;
                        this.materialTabControl1.Size = new System.Drawing.Size(1166, 422);
                        this.materialTabControl1.TabIndex = 0;
                        // 
                        // Reportes
                        // 
                        this.Reportes.Controls.Add(this.LabelTotal);
                        this.Reportes.Controls.Add(this.Fecha);
                        this.Reportes.Controls.Add(this.materialLabel3);
                        this.Reportes.Controls.Add(this.materialLabel2);
                        this.Reportes.Controls.Add(this.materialButton3);
                        this.Reportes.Controls.Add(this.materialButton2);
                        this.Reportes.Controls.Add(this.materialLabel1);
                        this.Reportes.Controls.Add(this.MyTextNameOrProduct);
                        this.Reportes.Controls.Add(this.materialButton1);
                        this.Reportes.Controls.Add(this.MyDataProductosCaja);
                        this.Reportes.Location = new System.Drawing.Point(4, 22);
                        this.Reportes.Name = "Reportes";
                        this.Reportes.Padding = new System.Windows.Forms.Padding(3);
                        this.Reportes.Size = new System.Drawing.Size(1158, 396);
                        this.Reportes.TabIndex = 0;
                        this.Reportes.Text = "Generar Reportes";
                        this.Reportes.UseVisualStyleBackColor = true;
                        // 
                        // LabelTotal
                        // 
                        this.LabelTotal.AutoSize = true;
                        this.LabelTotal.Depth = 0;
                        this.LabelTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.LabelTotal.Location = new System.Drawing.Point(785, 374);
                        this.LabelTotal.MouseState = MaterialSkin.MouseState.HOVER;
                        this.LabelTotal.Name = "LabelTotal";
                        this.LabelTotal.Size = new System.Drawing.Size(203, 19);
                        this.LabelTotal.TabIndex = 9;
                        this.LabelTotal.Text = "Total de Ganancia: @TOTAL";
                        // 
                        // Fecha
                        // 
                        this.Fecha.Location = new System.Drawing.Point(782, 100);
                        this.Fecha.Name = "Fecha";
                        this.Fecha.Size = new System.Drawing.Size(366, 20);
                        this.Fecha.TabIndex = 8;
                        this.Fecha.Value = new System.DateTime(2025, 2, 1, 0, 0, 0, 0);
                        this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
                        // 
                        // materialLabel3
                        // 
                        this.materialLabel3.AutoSize = true;
                        this.materialLabel3.Depth = 0;
                        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel3.Location = new System.Drawing.Point(785, 78);
                        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel3.Name = "materialLabel3";
                        this.materialLabel3.Size = new System.Drawing.Size(125, 19);
                        this.materialLabel3.TabIndex = 7;
                        this.materialLabel3.Text = "Buscar Por Fecha";
                        // 
                        // materialLabel2
                        // 
                        this.materialLabel2.AutoSize = true;
                        this.materialLabel2.Depth = 0;
                        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel2.Location = new System.Drawing.Point(782, 126);
                        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel2.Name = "materialLabel2";
                        this.materialLabel2.Size = new System.Drawing.Size(65, 19);
                        this.materialLabel2.TabIndex = 6;
                        this.materialLabel2.Text = "Acciones";
                        // 
                        // materialButton3
                        // 
                        this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton3.Depth = 0;
                        this.materialButton3.HighEmphasis = true;
                        this.materialButton3.Icon = null;
                        this.materialButton3.Location = new System.Drawing.Point(784, 199);
                        this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton3.Name = "materialButton3";
                        this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton3.Size = new System.Drawing.Size(191, 36);
                        this.materialButton3.TabIndex = 5;
                        this.materialButton3.Text = "Limpiar Caja De Texto";
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
                        this.materialButton2.Location = new System.Drawing.Point(785, 245);
                        this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton2.Name = "materialButton2";
                        this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton2.Size = new System.Drawing.Size(163, 36);
                        this.materialButton2.TabIndex = 4;
                        this.materialButton2.Text = "Generrar Reporte";
                        this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton2.UseAccentColor = false;
                        this.materialButton2.UseVisualStyleBackColor = true;
                        this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
                        // 
                        // materialLabel1
                        // 
                        this.materialLabel1.AutoSize = true;
                        this.materialLabel1.Depth = 0;
                        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.materialLabel1.Location = new System.Drawing.Point(782, 3);
                        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialLabel1.Name = "materialLabel1";
                        this.materialLabel1.Size = new System.Drawing.Size(373, 19);
                        this.materialLabel1.TabIndex = 3;
                        this.materialLabel1.Text = "Buscar por Nombre de cliente o Nombre del producto";
                        // 
                        // MyTextNameOrProduct
                        // 
                        this.MyTextNameOrProduct.AnimateReadOnly = false;
                        this.MyTextNameOrProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.MyTextNameOrProduct.Depth = 0;
                        this.MyTextNameOrProduct.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        this.MyTextNameOrProduct.LeadingIcon = null;
                        this.MyTextNameOrProduct.Location = new System.Drawing.Point(782, 25);
                        this.MyTextNameOrProduct.MaxLength = 50;
                        this.MyTextNameOrProduct.MouseState = MaterialSkin.MouseState.OUT;
                        this.MyTextNameOrProduct.Multiline = false;
                        this.MyTextNameOrProduct.Name = "MyTextNameOrProduct";
                        this.MyTextNameOrProduct.Size = new System.Drawing.Size(366, 50);
                        this.MyTextNameOrProduct.TabIndex = 2;
                        this.MyTextNameOrProduct.Text = "";
                        this.MyTextNameOrProduct.TrailingIcon = null;
                        this.MyTextNameOrProduct.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = null;
                        this.materialButton1.Location = new System.Drawing.Point(785, 151);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(220, 36);
                        this.materialButton1.TabIndex = 1;
                        this.materialButton1.Text = "Cargar Todos Las Ventas";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
                        // 
                        // MyDataProductosCaja
                        // 
                        this.MyDataProductosCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.MyDataProductosCaja.Location = new System.Drawing.Point(0, 0);
                        this.MyDataProductosCaja.Name = "MyDataProductosCaja";
                        this.MyDataProductosCaja.Size = new System.Drawing.Size(776, 400);
                        this.MyDataProductosCaja.TabIndex = 0;
                        // 
                        // RegistrosVentas
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1172, 489);
                        this.Controls.Add(this.materialTabControl1);
                        this.DrawerTabControl = this.materialTabControl1;
                        this.Name = "RegistrosVentas";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Registros Ventas";
                        this.Load += new System.EventHandler(this.RegistrosVentas_Load);
                        this.materialTabControl1.ResumeLayout(false);
                        this.Reportes.ResumeLayout(false);
                        this.Reportes.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.MyDataProductosCaja)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
                private System.Windows.Forms.TabPage Reportes;
                private System.Windows.Forms.DataGridView MyDataProductosCaja;
                private MaterialSkin.Controls.MaterialLabel materialLabel1;
                private MaterialSkin.Controls.MaterialTextBox MyTextNameOrProduct;
                private MaterialSkin.Controls.MaterialButton materialButton1;
                private MaterialSkin.Controls.MaterialButton materialButton2;
                private MaterialSkin.Controls.MaterialButton materialButton3;
                private System.Windows.Forms.DateTimePicker Fecha;
                private MaterialSkin.Controls.MaterialLabel materialLabel3;
                private MaterialSkin.Controls.MaterialLabel materialLabel2;
                private MaterialSkin.Controls.MaterialLabel LabelTotal;
        }
}