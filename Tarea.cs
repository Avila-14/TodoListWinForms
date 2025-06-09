using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListWinForms.Model
{
    /// Representa una tarea individual en la lista de tareas.
    public class Tarea
    {
        public string Descripcion { get; set; } // Establece la descripcion de una tarea
        public bool Completada { get; set; } // Valor que indica si la tarea esta completada

    
            //Inicializa una instancia de la clase tarea
        public Tarea(string description, bool success = false)
        {
            Descripcion = description; 
            Completada = success;
        }

        /// Proporciona una representación de cadena de la tarea,
        /// incluyendo un indicador de si está completada.
        public override string ToString()
        {
            // Muestra [X] si la tarea está completada, o [ ] si no.
            return Completada ? $"[X] {Descripcion}" : $"[ ] {Descripcion}";
        }
    } 
}
