using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoListWinForms.Logic;
using TodoListWinForms.Model;

namespace TodoListWinForms
{
    public partial class Form1 : Form
    {
        private TaskManager _taskManager;
        public Form1()
        {
            InitializeComponent();
            _taskManager = new TaskManager();

            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dgvTareas.AutoGenerateColumns = false;
            dgvTareas.DataSource = _taskManager.Tareas; // Enlaza la lista

            // Añade las columnas manualmente
            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Descripcion"; // Se enlaza a la propiedad Descripcion de Tarea
            descriptionColumn.HeaderText = "Tarea";
            descriptionColumn.Name = "colDescription";
            descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Ocupa el espacio restante
            dgvTareas.Columns.Add(descriptionColumn);

            // Columna de completada
            DataGridViewCheckBoxColumn completedColumn = new DataGridViewCheckBoxColumn();
            completedColumn.DataPropertyName = "Completada";
            completedColumn.HeaderText = "Completada";
            completedColumn.Name = "colCompletada";
            completedColumn.Width = 80;
            dgvTareas.Columns.Add(completedColumn);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _taskManager.AgregarTarea(txtNuevaTarea.Text);
            txtNuevaTarea.Clear();  // Limpia el textbox
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTareas.SelectedRows[0].Index;
                string currentDescription = _taskManager.Tareas[selectedIndex].Descripcion;
                string nuevaDescripcion = Microsoft.VisualBasic.Interaction.InputBox(
                    "Editar tarea:", // Mensaje a mostrar
                    "Editar Tarea", // Titulo del cuadro de dialogo
                    currentDescription); // Valor predeterminado en el cuadro de texto

                if (!string.IsNullOrWhiteSpace(nuevaDescripcion))
                {

                    _taskManager.editarTarea(selectedIndex, nuevaDescripcion);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada.
            if (dgvTareas.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la primera fila seleccionada.
                int selectedIndex = dgvTareas.SelectedRows[0].Index;
                // Obtiene el estado actual de "Completada" de la tarea seleccionada.
                bool currentState = _taskManager.Tareas[selectedIndex].Completada;
                // Llama al método de TaskManager para invertir el estado de completado.
                _taskManager.marcarTarea(selectedIndex, !currentState);
            }
            else
            {
                // Muestra un mensaje de advertencia.
                MessageBox.Show("Por favor, selecciona una tarea para marcar/desmarcar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dgvTareas.SelectedRows.Count > 0 )
        {
                // Obtiene el indice de la primera fila seleccionada
                int selectedIndex = dgvTareas.SelectedRows[0].Index;

                // Llama al metodo de TaskManager para eliminar la tarea.
                _taskManager.EliminarTarea(selectedIndex);
            }
            else
            {
                // Muestra un mensaje de advertencia.
                MessageBox.Show("Por favor , selecciona una tarea para eliminar.", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
