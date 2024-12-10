
namespace ParqueCarbones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.btnGuardarCamiones = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblBuscarMatricula = new System.Windows.Forms.Label();
            this.txtBuscarMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.btnActualizarCamiones = new System.Windows.Forms.Button();
            this.btnLimpiarCamiones = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.chartTotalKgPorHora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEntradaCamiones = new System.Windows.Forms.DataGridView();
            this.cBoxCamionero = new System.Windows.Forms.ComboBox();
            this.lblCamionero = new System.Windows.Forms.Label();
            this.pickerFechaGrid2 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaGrid2 = new System.Windows.Forms.Label();
            this.lblCamionGrid2 = new System.Windows.Forms.Label();
            this.lblCamioneroGrid2 = new System.Windows.Forms.Label();
            this.lblPesoGrid2 = new System.Windows.Forms.Label();
            this.btnGuardarGrid2 = new System.Windows.Forms.Button();
            this.btnLimpiarGrid2 = new System.Windows.Forms.Button();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.txtCamionesGrid2 = new System.Windows.Forms.TextBox();
            this.txtCamioneroGrid2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalKgPorHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamiones.Location = new System.Drawing.Point(497, 51);
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.Size = new System.Drawing.Size(608, 318);
            this.dgvCamiones.TabIndex = 0;
            this.dgvCamiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellClick);
            this.dgvCamiones.SelectionChanged += new System.EventHandler(this.dgvResultados_SelectionChanged);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(57, 61);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(381, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(54, 45);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(54, 96);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(54, 146);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Location = new System.Drawing.Point(57, 162);
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.Size = new System.Drawing.Size(381, 20);
            this.txtPesoMax.TabIndex = 5;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(54, 252);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 8;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(57, 268);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(381, 53);
            this.txtObservaciones.TabIndex = 9;
            this.txtObservaciones.Text = "";
            // 
            // btnGuardarCamiones
            // 
            this.btnGuardarCamiones.Location = new System.Drawing.Point(57, 338);
            this.btnGuardarCamiones.Name = "btnGuardarCamiones";
            this.btnGuardarCamiones.Size = new System.Drawing.Size(381, 23);
            this.btnGuardarCamiones.TabIndex = 10;
            this.btnGuardarCamiones.Text = "Guardar Camión";
            this.btnGuardarCamiones.UseVisualStyleBackColor = true;
            this.btnGuardarCamiones.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(57, 570);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(381, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblBuscarMatricula
            // 
            this.lblBuscarMatricula.AutoSize = true;
            this.lblBuscarMatricula.Location = new System.Drawing.Point(54, 515);
            this.lblBuscarMatricula.Name = "lblBuscarMatricula";
            this.lblBuscarMatricula.Size = new System.Drawing.Size(88, 13);
            this.lblBuscarMatricula.TabIndex = 13;
            this.lblBuscarMatricula.Text = "Buscar Matrícula";
            // 
            // txtBuscarMatricula
            // 
            this.txtBuscarMatricula.Location = new System.Drawing.Point(57, 531);
            this.txtBuscarMatricula.Name = "txtBuscarMatricula";
            this.txtBuscarMatricula.Size = new System.Drawing.Size(381, 20);
            this.txtBuscarMatricula.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "*Nota: Los pesos están redondeados a 3 decimales.";
            // 
            // cBoxEmpresa
            // 
            this.cBoxEmpresa.FormattingEnabled = true;
            this.cBoxEmpresa.Location = new System.Drawing.Point(57, 112);
            this.cBoxEmpresa.Name = "cBoxEmpresa";
            this.cBoxEmpresa.Size = new System.Drawing.Size(381, 21);
            this.cBoxEmpresa.TabIndex = 15;
            // 
            // btnActualizarCamiones
            // 
            this.btnActualizarCamiones.Location = new System.Drawing.Point(57, 379);
            this.btnActualizarCamiones.Name = "btnActualizarCamiones";
            this.btnActualizarCamiones.Size = new System.Drawing.Size(381, 23);
            this.btnActualizarCamiones.TabIndex = 16;
            this.btnActualizarCamiones.Text = "Modificar Camión";
            this.btnActualizarCamiones.UseVisualStyleBackColor = true;
            this.btnActualizarCamiones.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiarCamiones
            // 
            this.btnLimpiarCamiones.Location = new System.Drawing.Point(57, 417);
            this.btnLimpiarCamiones.Name = "btnLimpiarCamiones";
            this.btnLimpiarCamiones.Size = new System.Drawing.Size(381, 23);
            this.btnLimpiarCamiones.TabIndex = 17;
            this.btnLimpiarCamiones.Text = "Limpiar";
            this.btnLimpiarCamiones.UseVisualStyleBackColor = true;
            this.btnLimpiarCamiones.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Location = new System.Drawing.Point(57, 618);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(381, 23);
            this.btnExportarCSV.TabIndex = 18;
            this.btnExportarCSV.Text = "Exportar a CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = true;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // chartTotalKgPorHora
            // 
            chartArea7.Name = "ChartArea1";
            this.chartTotalKgPorHora.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartTotalKgPorHora.Legends.Add(legend7);
            this.chartTotalKgPorHora.Location = new System.Drawing.Point(497, 389);
            this.chartTotalKgPorHora.Name = "chartTotalKgPorHora";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartTotalKgPorHora.Series.Add(series7);
            this.chartTotalKgPorHora.Size = new System.Drawing.Size(608, 362);
            this.chartTotalKgPorHora.TabIndex = 19;
            this.chartTotalKgPorHora.Text = "Fechas de entrada";
            // 
            // dgvEntradaCamiones
            // 
            this.dgvEntradaCamiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradaCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaCamiones.Location = new System.Drawing.Point(1111, 51);
            this.dgvEntradaCamiones.Name = "dgvEntradaCamiones";
            this.dgvEntradaCamiones.Size = new System.Drawing.Size(608, 318);
            this.dgvEntradaCamiones.TabIndex = 20;
            this.dgvEntradaCamiones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEntradaCamiones_CellValidating);
            // 
            // cBoxCamionero
            // 
            this.cBoxCamionero.FormattingEnabled = true;
            this.cBoxCamionero.Location = new System.Drawing.Point(57, 216);
            this.cBoxCamionero.Name = "cBoxCamionero";
            this.cBoxCamionero.Size = new System.Drawing.Size(381, 21);
            this.cBoxCamionero.TabIndex = 31;
            // 
            // lblCamionero
            // 
            this.lblCamionero.AutoSize = true;
            this.lblCamionero.Location = new System.Drawing.Point(54, 200);
            this.lblCamionero.Name = "lblCamionero";
            this.lblCamionero.Size = new System.Drawing.Size(57, 13);
            this.lblCamionero.TabIndex = 30;
            this.lblCamionero.Text = "Camionero";
            // 
            // pickerFechaGrid2
            // 
            this.pickerFechaGrid2.Location = new System.Drawing.Point(1231, 434);
            this.pickerFechaGrid2.Name = "pickerFechaGrid2";
            this.pickerFechaGrid2.Size = new System.Drawing.Size(382, 20);
            this.pickerFechaGrid2.TabIndex = 34;
            // 
            // lblFechaGrid2
            // 
            this.lblFechaGrid2.AutoSize = true;
            this.lblFechaGrid2.Location = new System.Drawing.Point(1228, 418);
            this.lblFechaGrid2.Name = "lblFechaGrid2";
            this.lblFechaGrid2.Size = new System.Drawing.Size(84, 13);
            this.lblFechaGrid2.TabIndex = 33;
            this.lblFechaGrid2.Text = "Fecha a Insertar";
            // 
            // lblCamionGrid2
            // 
            this.lblCamionGrid2.AutoSize = true;
            this.lblCamionGrid2.Location = new System.Drawing.Point(1228, 469);
            this.lblCamionGrid2.Name = "lblCamionGrid2";
            this.lblCamionGrid2.Size = new System.Drawing.Size(42, 13);
            this.lblCamionGrid2.TabIndex = 35;
            this.lblCamionGrid2.Text = "Camión";
            // 
            // lblCamioneroGrid2
            // 
            this.lblCamioneroGrid2.AutoSize = true;
            this.lblCamioneroGrid2.Location = new System.Drawing.Point(1228, 522);
            this.lblCamioneroGrid2.Name = "lblCamioneroGrid2";
            this.lblCamioneroGrid2.Size = new System.Drawing.Size(57, 13);
            this.lblCamioneroGrid2.TabIndex = 37;
            this.lblCamioneroGrid2.Text = "Camionero";
            // 
            // lblPesoGrid2
            // 
            this.lblPesoGrid2.AutoSize = true;
            this.lblPesoGrid2.Location = new System.Drawing.Point(1228, 576);
            this.lblPesoGrid2.Name = "lblPesoGrid2";
            this.lblPesoGrid2.Size = new System.Drawing.Size(31, 13);
            this.lblPesoGrid2.TabIndex = 40;
            this.lblPesoGrid2.Text = "Peso";
            // 
            // btnGuardarGrid2
            // 
            this.btnGuardarGrid2.Location = new System.Drawing.Point(1232, 632);
            this.btnGuardarGrid2.Name = "btnGuardarGrid2";
            this.btnGuardarGrid2.Size = new System.Drawing.Size(381, 23);
            this.btnGuardarGrid2.TabIndex = 41;
            this.btnGuardarGrid2.Text = "Guardar en Entradas";
            this.btnGuardarGrid2.UseVisualStyleBackColor = true;
            this.btnGuardarGrid2.Click += new System.EventHandler(this.btnGuardarGrid2_Click);
            // 
            // btnLimpiarGrid2
            // 
            this.btnLimpiarGrid2.Location = new System.Drawing.Point(1231, 671);
            this.btnLimpiarGrid2.Name = "btnLimpiarGrid2";
            this.btnLimpiarGrid2.Size = new System.Drawing.Size(381, 23);
            this.btnLimpiarGrid2.TabIndex = 42;
            this.btnLimpiarGrid2.Text = "Limpiar";
            this.btnLimpiarGrid2.UseVisualStyleBackColor = true;
            this.btnLimpiarGrid2.Click += new System.EventHandler(this.btnLimpiarGrid2_Click);
            // 
            // numPeso
            // 
            this.numPeso.Location = new System.Drawing.Point(1232, 593);
            this.numPeso.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(380, 20);
            this.numPeso.TabIndex = 43;
            // 
            // txtCamionesGrid2
            // 
            this.txtCamionesGrid2.Location = new System.Drawing.Point(1231, 487);
            this.txtCamionesGrid2.Name = "txtCamionesGrid2";
            this.txtCamionesGrid2.Size = new System.Drawing.Size(382, 20);
            this.txtCamionesGrid2.TabIndex = 44;
            // 
            // txtCamioneroGrid2
            // 
            this.txtCamioneroGrid2.Location = new System.Drawing.Point(1231, 538);
            this.txtCamioneroGrid2.Name = "txtCamioneroGrid2";
            this.txtCamioneroGrid2.Size = new System.Drawing.Size(382, 20);
            this.txtCamioneroGrid2.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 763);
            this.Controls.Add(this.txtCamioneroGrid2);
            this.Controls.Add(this.txtCamionesGrid2);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.btnLimpiarGrid2);
            this.Controls.Add(this.btnGuardarGrid2);
            this.Controls.Add(this.lblPesoGrid2);
            this.Controls.Add(this.lblCamioneroGrid2);
            this.Controls.Add(this.lblCamionGrid2);
            this.Controls.Add(this.pickerFechaGrid2);
            this.Controls.Add(this.lblFechaGrid2);
            this.Controls.Add(this.cBoxCamionero);
            this.Controls.Add(this.lblCamionero);
            this.Controls.Add(this.dgvEntradaCamiones);
            this.Controls.Add(this.chartTotalKgPorHora);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnLimpiarCamiones);
            this.Controls.Add(this.btnActualizarCamiones);
            this.Controls.Add(this.cBoxEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBuscarMatricula);
            this.Controls.Add(this.txtBuscarMatricula);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardarCamiones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPesoMax);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.dgvCamiones);
            this.MaximumSize = new System.Drawing.Size(1744, 802);
            this.MinimumSize = new System.Drawing.Size(1744, 802);
            this.Name = "Form1";
            this.Text = "Parque de Carbones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalKgPorHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardarCamiones;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblBuscarMatricula;
        private System.Windows.Forms.TextBox txtBuscarMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxEmpresa;
        private System.Windows.Forms.Button btnActualizarCamiones;
        private System.Windows.Forms.Button btnLimpiarCamiones;
        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalKgPorHora;
        private System.Windows.Forms.DataGridView dgvEntradaCamiones;
        private System.Windows.Forms.ComboBox cBoxCamionero;
        private System.Windows.Forms.Label lblCamionero;
        private System.Windows.Forms.DateTimePicker pickerFechaGrid2;
        private System.Windows.Forms.Label lblFechaGrid2;
        private System.Windows.Forms.Label lblCamionGrid2;
        private System.Windows.Forms.Label lblCamioneroGrid2;
        private System.Windows.Forms.Label lblPesoGrid2;
        private System.Windows.Forms.Button btnGuardarGrid2;
        private System.Windows.Forms.Button btnLimpiarGrid2;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.TextBox txtCamionesGrid2;
        private System.Windows.Forms.TextBox txtCamioneroGrid2;
    }
}

