using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ParqueCarbones
{
    public partial class Form1 : Form
    {
        public string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ParqueCarbones;Data Source=DESKTOP-QEC75T9\\SQLSERVER";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarEmpresas();
            CargarCamioneros();
            CargarDatosCamiones();
            ConfigurarChart();
            CargarDatosParaGrafico();
            CargarEntradasDeCamiones();

            dgvCamiones.MultiSelect = false;

            dgvCamiones.Columns["PesoMaximo"].HeaderText = "Peso Máximo";
            dgvCamiones.Columns["CamioneroID"].HeaderText = "ID Camionero";
            dgvCamiones.SelectionChanged += new EventHandler(dgvResultados_SelectionChanged);

            txtCamionesGrid2.Text = string.Empty;
            txtCamioneroGrid2.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarInsercion())
            {
                string query = "INSERT INTO Camiones (Matricula, Empresa, PesoMaximo, Observaciones, CamioneroID) " +
                           "VALUES (@Matricula, @Empresa, @PesoMaximo, @Observaciones, @CamioneroID)";

                SqlParameter[] parameters =
                {
                new SqlParameter("@Matricula", txtMatricula.Text),
                new SqlParameter("@Empresa", cBoxEmpresa.SelectedItem.ToString()),
                new SqlParameter("@PesoMaximo", decimal.Parse(txtPesoMax.Text)),
                new SqlParameter("@Observaciones", txtObservaciones.Text),
                new SqlParameter("@CamioneroID", cBoxCamionero.SelectedItem.ToString())
            };

                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if(rowsAffected > 0)
                {
                    MessageBox.Show("Camión guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarDatosCamiones();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarInsercion())
            {
                // Crear una lista de parámetros
                var parametros = new List<SqlParameter>
        {
                new SqlParameter("@Matricula", txtMatricula.Text),
                new SqlParameter("@PesoMaximo", decimal.Parse(txtPesoMax.Text)),
                new SqlParameter("@Empresa", cBoxEmpresa.SelectedItem.ToString()),
                new SqlParameter("@Id", selectedCamionId),
                new SqlParameter("@Observaciones", txtObservaciones.Text),
                new SqlParameter("@CamioneroID", cBoxCamionero.SelectedItem.ToString())
        };

                string query = "UPDATE Camiones SET Matricula = @Matricula, PesoMaximo = @PesoMaximo, Empresa = @Empresa, Observaciones = @Observaciones, CamioneroID = @CamioneroID WHERE Id = @Id";
                Database db = new Database();
                db.ExecuteNonQuery(query, parametros.ToArray()); // Pasamos el array de parámetros

                MessageBox.Show("Camión actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosCamiones();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtPesoMax.Clear();
            cBoxEmpresa.SelectedIndex = -1;
            txtObservaciones.Clear();

            dgvCamiones.ClearSelection();
            dgvCamiones.CurrentCell = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string query;
            SqlParameter[] parameters;

            if (string.IsNullOrEmpty(txtBuscarMatricula.Text))
            {
                // Si no se ha ingresado ninguna matrícula, se consulta todos los camiones
                query = "SELECT * FROM Camiones";
                parameters = new SqlParameter[0];
            }
            else
            {
                // Consulta con filtro por matrícula
                query = "SELECT * FROM Camiones WHERE Matricula LIKE @Matricula";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Matricula", "%" + txtBuscarMatricula.Text + "%")
                };
            }

            Database db = new Database();
            DataTable results = db.ExecuteQuery(query, parameters);

            dgvCamiones.DataSource = results;
        }


        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCamiones.Rows.Count > 0 || dgvEntradaCamiones.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "CSV (*.csv)|*.csv",
                        FileName = "DatosParqueCarbon.csv"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Exportar datos de dgvCamiones
                            if (dgvCamiones.Rows.Count > 0)
                            {
                                sw.WriteLine("Datos de Camiones:");

                                // Escribir los encabezados
                                for (int i = 0; i < dgvCamiones.Columns.Count; i++)
                                {
                                    sw.Write(dgvCamiones.Columns[i].HeaderText);
                                    if (i < dgvCamiones.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();

                                // Escribir los datos
                                foreach (DataGridViewRow row in dgvCamiones.Rows)
                                {
                                    for (int i = 0; i < row.Cells.Count; i++)
                                    {
                                        sw.Write(row.Cells[i].Value?.ToString() ?? "");
                                        if (i < row.Cells.Count - 1)
                                            sw.Write(",");
                                    }
                                    sw.WriteLine();
                                }

                                sw.WriteLine(); // Línea separadora entre secciones
                            }

                            // Exportar datos de dgvEntradaCamiones
                            if (dgvEntradaCamiones.Rows.Count > 0)
                            {
                                sw.WriteLine("Datos de Entradas de Camiones:");

                                // Escribir los encabezados
                                for (int i = 0; i < dgvEntradaCamiones.Columns.Count; i++)
                                {
                                    sw.Write(dgvEntradaCamiones.Columns[i].HeaderText);
                                    if (i < dgvEntradaCamiones.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();

                                // Escribir los datos
                                foreach (DataGridViewRow row in dgvEntradaCamiones.Rows)
                                {
                                    for (int i = 0; i < row.Cells.Count; i++)
                                    {
                                        sw.Write(row.Cells[i].Value?.ToString() ?? "");
                                        if (i < row.Cells.Count - 1)
                                            sw.Write(",");
                                    }
                                    sw.WriteLine();
                                }
                            }
                        }

                        MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarDatosCamiones()
        {
            string query = "SELECT * FROM Camiones";

            Database db = new Database();
            DataTable results = db.ExecuteQuery(query);

            dgvCamiones.DataSource = results;

            dgvCamiones.ClearSelection();

            if (dgvCamiones.SelectedRows.Count > 0)
            {
                dgvCamiones.SelectedRows[0].Selected = false; // Desactiva la selección de la primera fila si estaba seleccionada
            }

            txtMatricula.Text = string.Empty;
            txtPesoMax.Text = string.Empty;
            cBoxEmpresa.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            cBoxCamionero.Text = string.Empty;
        }

        // Configuración del dataGridView
        private void ConfigurarDataGridView()
        {
            dgvCamiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCamiones.AllowUserToAddRows = false;
            dgvCamiones.ReadOnly = true;
        }

        private void CargarEmpresas()
        {
            var empresas = new List<string> { "DHL", "Amazon", "SEUR", "Correos", "MRW", "CTT", "Nacex", "Tipsa", "GLS" };

            cBoxEmpresa.DataSource = empresas;
        }

        private void CargarCamioneros()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta para obtener solo los IDs de los camioneros
                string query = "SELECT ID FROM Camioneros";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cBoxCamionero.Items.Clear();
                        txtCamioneroGrid2.Clear();
                        txtCamionesGrid2.Clear();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("ID"));
                            txtCamioneroGrid2.Text += id.ToString() + Environment.NewLine;
                            txtCamionesGrid2.Text += id.ToString() + Environment.NewLine;
                            cBoxCamionero.Items.Add(id);
                        }

                        // Establecer el valor seleccionado por defecto o algún valor inicial si es necesario
                        if (!string.IsNullOrEmpty(txtCamioneroGrid2.Text))
                        {
                            txtCamioneroGrid2.Text = txtCamioneroGrid2.Text.Trim();
                            txtCamionesGrid2.Text = txtCamioneroGrid2.Text.Trim();
                        }
                    }
                }
                connection.Close();
            }
        }


        private bool ValidarInsercion()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, ingrese una matrícula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPesoMax.Text, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("Por favor, ingrese un peso válido mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesoMax.Focus();
                return false;
            }

            if (cBoxEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una empresa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBoxEmpresa.Focus();
                return false;
            }

            if (cBoxCamionero.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un camionero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBoxCamionero.Focus();
                return false;
            }

            return true;
        }

        // Variable que se utilizará para actualizar el dataGridView
        private int selectedCamionId;

        private void dgvResultados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCamiones.SelectedRows.Count > 0)
            {
                selectedCamionId = Convert.ToInt32(dgvCamiones.SelectedRows[0].Cells["Id"].Value);

                DataGridViewRow row = dgvCamiones.SelectedRows[0];

                // Establecer los valores en los controles del formulario
                txtMatricula.Text = row.Cells["Matricula"].Value.ToString();
                txtCamionesGrid2.Text = row.Cells["ID"].Value.ToString();
                txtPesoMax.Text = row.Cells["PesoMaximo"].Value.ToString();
                cBoxEmpresa.Text = row.Cells["Empresa"].Value.ToString(); // Cambiado de SelectedItem a Text
                txtObservaciones.Text = row.Cells["Observaciones"].Value.ToString();
                txtCamioneroGrid2.Text = row.Cells["CamioneroID"].Value.ToString(); // Cambiado de SelectedItem a Text
            }
        }


        private void dgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvCamiones.ClearSelection();
                dgvCamiones.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ConfigurarChart()
        {
            chartTotalKgPorHora.ChartAreas.Clear(); // Limpiar áreas de gráficos existentes

            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Día - Hora";
            chartArea.AxisY.Title = "Total Kg";
            chartTotalKgPorHora.ChartAreas.Add(chartArea);

            // Opciones adicionales para mejorar la visualización
            chartTotalKgPorHora.Titles.Clear();
            chartTotalKgPorHora.Titles.Add("Total de Kg por Hora");

            chartTotalKgPorHora.Legends.Clear(); // Limpiar leyendas existentes
            chartTotalKgPorHora.Legends.Add(new Legend("Leyenda")); // Añadir una leyenda genérica si es necesario
        }

        private void CargarDatosParaGrafico()
        {
            try
            {
                string query = @"
                    SELECT CONVERT(DATE, FechaHora) AS Dia,
                           DATEPART(HOUR, FechaHora) AS Hora,
                           SUM(Peso) AS TotalKG
                    FROM Entradas
                    GROUP BY CONVERT(DATE, FechaHora), DATEPART(HOUR, FechaHora)
                    ORDER BY Dia, Hora";

                Database db = new Database();
                DataTable resultados = db.ExecuteQuery(query);

                if (resultados.Rows.Count > 0)
                {
                    // Configurar datos para el Chart
                    Series series = new Series
                    {
                        Name = "TotalKG",
                        ChartType = SeriesChartType.Column // Tipo de gráfico de columnas para mostrar los totales de kg
                    };

                    // Agregar datos al Chart
                    foreach (DataRow row in resultados.Rows)
                    {
                        string dia = row["Dia"].ToString();
                        int hora = Convert.ToInt32(row["Hora"]);
                        int totalKG = Convert.ToInt32(row["TotalKG"]);

                        series.Points.AddXY($"{dia} - Hora {hora}", totalKG);
                    }

                    // Añadir la serie al Chart en el formulario
                    chartTotalKgPorHora.Series.Clear(); // Limpiar series existentes antes de añadir nuevas
                    chartTotalKgPorHora.Series.Add(series);
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos para el gráfico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarEntradasDeCamiones()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        FechaHora,
                        Matricula,
                        Empresa,
                        Nombre AS Camionero,
                        Peso,
                        Foto
                    FROM Entradas
                    INNER JOIN Camiones ON Entradas.CamionID = Camiones.ID
                    INNER JOIN Camioneros ON Entradas.CamioneroID = Camioneros.ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (dgvEntradaCamiones.Columns.Count == 0)
                        {
                            // Asegúrate de definir las columnas si no están definidas
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaHora", HeaderText = "Fecha Hora" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Matricula", HeaderText = "Matrícula" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Empresa", HeaderText = "Empresa" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Camionero", HeaderText = "Camionero" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Peso", HeaderText = "Peso" });
                        }

                        dgvEntradaCamiones.Rows.Clear(); // Limpiar los datos existentes

                        while (reader.Read())
                        {
                            int index = dgvEntradaCamiones.Rows.Add();
                            dgvEntradaCamiones.Rows[index].Cells["FechaHora"].Value = reader.GetDateTime(reader.GetOrdinal("FechaHora"));
                            dgvEntradaCamiones.Rows[index].Cells["Matricula"].Value = reader.GetString(reader.GetOrdinal("Matricula"));
                            dgvEntradaCamiones.Rows[index].Cells["Empresa"].Value = reader.GetString(reader.GetOrdinal("Empresa"));
                            dgvEntradaCamiones.Rows[index].Cells["Camionero"].Value = reader.GetString(reader.GetOrdinal("Camionero"));
                            dgvEntradaCamiones.Rows[index].Cells["Peso"].Value = reader.GetDecimal(reader.GetOrdinal("Peso"));

                        }
                    }
                    connection.Close();
                }
            }
        }


        private Image ConvertirBytesAImagen(byte[] fotoBytes)
        {
            using (MemoryStream ms = new MemoryStream(fotoBytes))
            {
                return Image.FromStream(ms);
            }
        }


        private void btnGuardarGrid2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los TextBoxes no estén vacíos y que los valores sean numéricos
                if (string.IsNullOrWhiteSpace(txtCamionesGrid2.Text) || !int.TryParse(txtCamionesGrid2.Text, out int camionID))
                {
                    MessageBox.Show("Por favor, selecciona un camión válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCamioneroGrid2.Text) || !int.TryParse(txtCamioneroGrid2.Text, out int camioneroID))
                {
                    MessageBox.Show("Por favor, selecciona un camionero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fecha = pickerFechaGrid2.Value;
                decimal peso = numPeso.Value; // Obtén el valor de peso del control NumericUpDown

                // Validar que el peso esté dentro del rango permitido
                if (peso <= 0 || peso > 999999999.999m)
                {
                    MessageBox.Show("El peso debe ser un número válido y mayor a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
                    INSERT INTO Entradas (FechaHora, CamionID, CamioneroID, Peso)
                    VALUES (@FechaHora, @CamionID, @CamioneroID, @Peso)";

                SqlParameter[] parameters = {
                    new SqlParameter("@FechaHora", fecha),
                    new SqlParameter("@CamionID", camionID),
                    new SqlParameter("@CamioneroID", camioneroID),
                    new SqlParameter("@Peso", peso)
                };

                Database db = new Database();
                db.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Entrada guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar todos los datos para que la tabla se actualice
                CargarEntradasDeCamiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarDatosParaGrafico();
        }


        private void RecargarEntradasDeCamiones()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        FechaHora,
                        Matricula,
                        Empresa,
                        Nombre AS Camionero,
                        Peso,
                        Foto
                    FROM Entradas
                    INNER JOIN Camiones ON Entradas.CamionID = Camiones.ID
                    INNER JOIN Camioneros ON Entradas.CamioneroID = Camioneros.ID
                    WHERE FechaHora = @FechaHora"; // Agrega la condición de fecha para filtrar correctamente

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añadimos el parámetro de fecha para filtrar correctamente
                    DateTime fechaSeleccionada = pickerFechaGrid2.Value;
                    command.Parameters.Add(new SqlParameter("@FechaHora", fechaSeleccionada));

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (dgvEntradaCamiones.Columns.Count == 0)
                        {
                            // Asegúrate de definir las columnas si no están definidas
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaHora", HeaderText = "Fecha Hora" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Matricula", HeaderText = "Matrícula" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Empresa", HeaderText = "Empresa" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Camionero", HeaderText = "Camionero" });
                            dgvEntradaCamiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Peso", HeaderText = "Peso" });
                        }

                        dgvEntradaCamiones.Rows.Clear(); // Limpiar los datos existentes

                        while (reader.Read())
                        {
                            int index = dgvEntradaCamiones.Rows.Add();
                            dgvEntradaCamiones.Rows[index].Cells["FechaHora"].Value = reader.GetDateTime(reader.GetOrdinal("FechaHora"));
                            dgvEntradaCamiones.Rows[index].Cells["Matricula"].Value = reader.GetString(reader.GetOrdinal("Matricula"));
                            dgvEntradaCamiones.Rows[index].Cells["Empresa"].Value = reader.GetString(reader.GetOrdinal("Empresa"));
                            dgvEntradaCamiones.Rows[index].Cells["Camionero"].Value = reader.GetString(reader.GetOrdinal("Camionero"));
                            dgvEntradaCamiones.Rows[index].Cells["Peso"].Value = reader.GetDecimal(reader.GetOrdinal("Peso"));

                        }
                    }
                    connection.Close();
                }
            }
        }

        private void btnLimpiarGrid2_Click(object sender, EventArgs e)
        {
            txtCamionesGrid2.Clear();
            txtCamioneroGrid2.Clear();
            numPeso.Value = 0;

            dgvEntradaCamiones.ClearSelection();
            dgvEntradaCamiones.CurrentCell = null;
        }

        private void dgvEntradaCamiones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvEntradaCamiones.Columns[e.ColumnIndex].Name == "Peso")
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal peso) || peso <= 0) // VerificaR si el valor es un número válido
                {
                    e.Cancel = true; // Cancela la validación para que no se inserte el valor
                    MessageBox.Show("El peso debe ser un número válido y mayor a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
