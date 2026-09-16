﻿using System.Windows.Forms;

namespace GestorProductos;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }


    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblPrecio = new Label();
        nudPrecio = new NumericUpDown();
        lblStock = new Label();
        nudStock = new NumericUpDown();
        lblRubro = new Label();
        txtRubro = new ComboBox();
        btnAgregar = new Button();
        btnEditar = new Button();
        btnCancelar = new Button();
        btnEliminar = new Button();
        lblIdEliminar = new Label();
        txtIdEliminar = new TextBox();
        dgvProductos = new DataGridView();
        lblContador = new Label();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        lblStockLimite = new Label();
        nudStockLimite = new NumericUpDown();
        btnEliminarStock = new Button();
        btnExportar = new Button();
        nombrePrograma = new Label();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudStockLimite).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 10F);
        lblNombre.Location = new Point(25, 25);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(89, 28);
        lblNombre.TabIndex = 31;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(120, 22);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(220, 31);
        txtNombre.TabIndex = 1;
        txtNombre.TextChanged += txtNombre_TextChanged;
        // 
        // lblPrecio
        // 
        lblPrecio.AutoSize = true;
        lblPrecio.Font = new Font("Segoe UI", 10F);
        lblPrecio.Location = new Point(31, 66);
        lblPrecio.Name = "lblPrecio";
        lblPrecio.Size = new Size(70, 28);
        lblPrecio.TabIndex = 30;
        lblPrecio.Text = "Precio:";
        // 
        // nudPrecio
        // 
        nudPrecio.DecimalPlaces = 2;
        nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        nudPrecio.Location = new Point(120, 67);
        nudPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        nudPrecio.Name = "nudPrecio";
        nudPrecio.Size = new Size(220, 31);
        nudPrecio.TabIndex = 3;
        nudPrecio.ThousandsSeparator = true;
        // 
        // lblStock
        // 
        lblStock.AutoSize = true;
        lblStock.Font = new Font("Segoe UI", 10F);
        lblStock.Location = new Point(31, 109);
        lblStock.Name = "lblStock";
        lblStock.Size = new Size(64, 28);
        lblStock.TabIndex = 29;
        lblStock.Text = "Stock:";
        // 
        // nudStock
        // 
        nudStock.Location = new Point(120, 110);
        nudStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudStock.Name = "nudStock";
        nudStock.Size = new Size(220, 31);
        nudStock.TabIndex = 5;
        nudStock.ThousandsSeparator = true;
        // 
        // lblRubro
        // 
        lblRubro.AutoSize = true;
        lblRubro.Font = new Font("Segoe UI", 10F);
        lblRubro.Location = new Point(31, 147);
        lblRubro.Name = "lblRubro";
        lblRubro.Size = new Size(70, 28);
        lblRubro.TabIndex = 28;
        lblRubro.Text = "Rubro:";
        // 
        // txtRubro
        // 
        txtRubro.DropDownStyle = ComboBoxStyle.DropDownList;
        txtRubro.FormattingEnabled = true;
        txtRubro.Location = new Point(120, 147);
        txtRubro.Name = "txtRubro";
        txtRubro.Size = new Size(220, 33);
        txtRubro.TabIndex = 7;
        txtRubro.SelectedIndexChanged += txtRubro_SelectedIndexChanged;
        // 
        // btnAgregar
        // 
        btnAgregar.BackColor = Color.Green;
        btnAgregar.Location = new Point(829, 186);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(111, 36);
        btnAgregar.TabIndex = 27;
        btnAgregar.Text = "➕";
        btnAgregar.UseVisualStyleBackColor = false;
        btnAgregar.Click += btnAgregar_Click;
        // 
        // btnEditar
        // 
        btnEditar.BackColor = Color.Yellow;
        btnEditar.Location = new Point(834, 228);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(106, 36);
        btnEditar.TabIndex = 26;
        btnEditar.Text = "✏️";
        btnEditar.UseVisualStyleBackColor = false;
        btnEditar.Click += btnEditar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(834, 270);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(106, 33);
        btnCancelar.TabIndex = 25;
        btnCancelar.Text = "❌";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Visible = false;
        btnCancelar.Click += btnCancelar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = Color.Red;
        btnEliminar.Location = new Point(803, 505);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(111, 38);
        btnEliminar.TabIndex = 24;
        btnEliminar.Text = "🗑️";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // lblIdEliminar
        // 
        lblIdEliminar.AutoSize = true;
        lblIdEliminar.Font = new Font("Segoe UI", 10F);
        lblIdEliminar.Location = new Point(481, 505);
        lblIdEliminar.Name = "lblIdEliminar";
        lblIdEliminar.Size = new Size(125, 28);
        lblIdEliminar.TabIndex = 23;
        lblIdEliminar.Text = "ID a eliminar:";
        // 
        // txtIdEliminar
        // 
        txtIdEliminar.Location = new Point(612, 507);
        txtIdEliminar.Name = "txtIdEliminar";
        txtIdEliminar.Size = new Size(195, 31);
        txtIdEliminar.TabIndex = 22;
        // 
        // dgvProductos
        // 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProductos.Location = new Point(25, 186);
        dgvProductos.Name = "dgvProductos";
        dgvProductos.RowHeadersWidth = 51;
        dgvProductos.Size = new Size(785, 281);
        dgvProductos.TabIndex = 13;
        // 
        // lblContador
        // 
        lblContador.AutoSize = true;
        lblContador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblContador.Location = new Point(819, 372);
        lblContador.Name = "lblContador";
        lblContador.Size = new Size(148, 28);
        lblContador.TabIndex = 22;
        lblContador.Text = "0 PRODUCTOS";
        lblContador.Click += lblContador_Click;
        // 
        // lblBuscar
        // 
        lblBuscar.AutoSize = true;
        lblBuscar.Font = new Font("Segoe UI", 10F);
        lblBuscar.Location = new Point(517, 466);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(72, 28);
        lblBuscar.TabIndex = 19;
        lblBuscar.Text = "Buscar:";
        // 
        // txtBuscar
        // 
        txtBuscar.Location = new Point(585, 466);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(153, 31);
        txtBuscar.TabIndex = 18;
        txtBuscar.TextChanged += txtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(731, 466);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(57, 34);
        btnBuscar.TabIndex = 1;
        btnBuscar.Text = "🔍";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // lblStockLimite
        // 
        lblStockLimite.AutoSize = true;
        lblStockLimite.Font = new Font("Segoe UI", 10F);
        lblStockLimite.Location = new Point(23, 497);
        lblStockLimite.Name = "lblStockLimite";
        lblStockLimite.Size = new Size(118, 28);
        lblStockLimite.TabIndex = 21;
        lblStockLimite.Text = "Stock límite:";
        // 
        // nudStockLimite
        // 
        nudStockLimite.Location = new Point(138, 497);
        nudStockLimite.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudStockLimite.Name = "nudStockLimite";
        nudStockLimite.Size = new Size(100, 31);
        nudStockLimite.TabIndex = 15;
        nudStockLimite.ValueChanged += nudStockLimite_ValueChanged;
        // 
        // btnEliminarStock
        // 
        btnEliminarStock.Location = new Point(244, 490);
        btnEliminarStock.Name = "btnEliminarStock";
        btnEliminarStock.Size = new Size(200, 43);
        btnEliminarStock.TabIndex = 20;
        btnEliminarStock.Text = "Eliminar según Stock";
        btnEliminarStock.UseVisualStyleBackColor = true;
        btnEliminarStock.Click += btnEliminarStock_Click;
        // 
        // btnExportar
        // 
        btnExportar.Location = new Point(816, 309);
        btnExportar.Name = "btnExportar";
        btnExportar.Size = new Size(150, 38);
        btnExportar.TabIndex = 0;
        btnExportar.Text = "Exportar";
        btnExportar.UseVisualStyleBackColor = true;
        btnExportar.Click += btnExportar_Click;
        // 
        // nombrePrograma
        // 
        nombrePrograma.AutoSize = true;
        nombrePrograma.BackColor = Color.Transparent;
        nombrePrograma.FlatStyle = FlatStyle.Flat;
        nombrePrograma.Font = new Font("Segoe UI", 14F);
        nombrePrograma.ForeColor = Color.FromArgb(0, 192, 0);
        nombrePrograma.Location = new Point(507, 67);
        nombrePrograma.Name = "nombrePrograma";
        nombrePrograma.Size = new Size(281, 38);
        nombrePrograma.TabIndex = 33;
        nombrePrograma.Text = "VERDULERIA GESTOR";
        nombrePrograma.Click += nombrePrograma_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(345, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(621, 180);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 34;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(979, 550);
        Controls.Add(nombrePrograma);
        Controls.Add(pictureBox1);
        Controls.Add(btnExportar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(lblBuscar);
        Controls.Add(btnEliminarStock);
        Controls.Add(nudStockLimite);
        Controls.Add(lblStockLimite);
        Controls.Add(dgvProductos);
        Controls.Add(lblContador);
        Controls.Add(txtIdEliminar);
        Controls.Add(lblIdEliminar);
        Controls.Add(btnEliminar);
        Controls.Add(btnCancelar);
        Controls.Add(btnEditar);
        Controls.Add(btnAgregar);
        Controls.Add(txtRubro);
        Controls.Add(lblRubro);
        Controls.Add(nudStock);
        Controls.Add(lblStock);
        Controls.Add(nudPrecio);
        Controls.Add(lblPrecio);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestor de Productos";
        ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudStockLimite).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion


    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtNombre;

    private System.Windows.Forms.Label lblPrecio;
    private System.Windows.Forms.NumericUpDown nudPrecio;

    private System.Windows.Forms.Label lblStock;
    private System.Windows.Forms.NumericUpDown nudStock;

    private System.Windows.Forms.Label lblRubro;
    private System.Windows.Forms.ComboBox txtRubro;

    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnEliminar;

    private System.Windows.Forms.Label lblIdEliminar;
    private System.Windows.Forms.TextBox txtIdEliminar;

    private System.Windows.Forms.DataGridView dgvProductos;

    private System.Windows.Forms.Label lblContador;

    private System.Windows.Forms.Label lblBuscar;
    private System.Windows.Forms.TextBox txtBuscar;
    private System.Windows.Forms.Button btnBuscar;

    private System.Windows.Forms.Label lblStockLimite;
    private System.Windows.Forms.NumericUpDown nudStockLimite;
    private System.Windows.Forms.Button btnEliminarStock;

    private System.Windows.Forms.Button btnExportar;
    private Label nombrePrograma;
    private PictureBox pictureBox1;
}

