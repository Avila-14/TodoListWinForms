# ToDo List con WinForms (C# .NET Framework)

Este es un proyecto de nivel principiante que implementa una aplicación de escritorio simple para gestionar tareas, construida con Windows Forms (.NET Framework) y C#.

## Funcionalidad

La aplicación permite a los usuarios:
* **Crear** nuevas tareas.
* **Editar** descripciones de tareas existentes.
* **Marcar/Desmarcar** tareas como completadas.
* **Eliminar** tareas de la lista.

## Tecnologías Utilizadas

* **.NET Framework**: Plataforma de desarrollo principal.
* **WinForms**: Para la construcción de la interfaz gráfica de usuario (GUI).
* **C#**: Lenguaje de programación.

## Buenas Prácticas Implementadas

* **Separación Lógica en Capas**: El código está organizado en capas (UI, Lógica de Negocio y Modelo de Datos) para mejorar la modularidad y el mantenimiento.
* **Uso de `BindingList<T>`**: Permite la actualización automática de la interfaz de usuario (DataGridView) cuando la colección de tareas cambia, optimizando la gestión de datos en la UI.

## Objetivo del Proyecto

El principal objetivo de este proyecto es familiarizarse con el diseño de interfaces de usuario en WinForms, el manejo de eventos y la implementación de una separación de lógica básica para proyectos de escritorio.
