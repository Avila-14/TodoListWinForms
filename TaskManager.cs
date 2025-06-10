using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListWinForms.Model;
namespace TodoListWinForms.Logic
{
    // Gestiona la lógica de negocio para las operaciones con tareas.
    public class TaskManager
    {
        // Una lista de tareas que notifica a los controles enlazados cuando cambia.
        public BindingList<Tarea> Tareas {  get; private set; }

        // Inicializa una nueva instancia de la clase TaskManager.
        public TaskManager()
        {
            Tareas = new BindingList<Tarea>();
        }

        // Agrega una nueva tarea a la lista.
        public void AgregarTarea(string description) // Recibe la descripcion de la tarea a agregar
        {

            // Solo agrega si la descripción no está vacía
            // o solo contiene espacios en blanco.
            if (!string.IsNullOrWhiteSpace(description))
            {
                Tareas.Add(new Tarea(description));
            }
        }

        // "index" El índice de la tarea a editar
        // "nuevaDescripcion" La nueva descripción para la tarea.
        public void editarTarea(int index, string nuevaDescripcion)
        {
            // Verifica que el índice sea válido y que la nueva descripción no esté vacía.
            if (index >= 0 && index < Tareas.Count && !string.IsNullOrWhiteSpace(nuevaDescripcion))
            {
                    Tareas[index].Descripcion = nuevaDescripcion;
                // Notifica a cualquier control de UI enlazado que este elemento ha cambiado.
                Tareas.ResetItem(index);
            }
        }

        public void marcarTarea(int index, bool success)
        {
            if (index >=0 && index < Tareas.Count)
            {
                Tareas[index].Completada = success;
                Tareas.ResetItem(index);
            }
        }

        public void EliminarTarea(int index)
        {
           if(index >= 0 && index <  Tareas.Count)
            {
                Tareas.RemoveAt(index);
            }
        }
    }
}
