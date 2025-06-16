# 11 - Command Pattern / Patrón Comando

## 🌐 English

### 🎯 Goal
This module demonstrates the Command pattern in .NET, using a remote control example to encapsulate requests as objects.

### 🧠 Key Concepts
- **Command Pattern**: Encapsulates a request as an object, allowing parameterization, queuing, logging, and undo/redo operations.
- **Decoupling**: Separates the object that invokes the operation from the one that knows how to perform it.
- **Use Cases**: Useful in UI actions, task queues, macro recording, and transactional systems.

### ➕ Advantages
- Decouples sender and receiver.
- Supports undo/redo and logging of operations.
- Enables flexible command composition and queuing.

### ➖ Disadvantages
- Increases the number of classes.
- Can add complexity for simple scenarios.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Comando en .NET, usando un ejemplo de control remoto para encapsular solicitudes como objetos.

### 🧠 Conceptos clave
- **Patrón Comando**: Encapsula una solicitud como un objeto, permitiendo parametrización, encolado, registro y operaciones de deshacer/rehacer.
- **Desacoplamiento**: Separa el objeto que invoca la operación del que sabe cómo realizarla.
- **Casos de uso**: Útil en acciones de UI, colas de tareas, grabación de macros y sistemas transaccionales.

### ➕ Ventajas
- Desacopla el emisor y el receptor.
- Soporta deshacer/rehacer y registro de operaciones.
- Permite composición y encolado flexible de comandos.

### ➖ Desventajas
- Aumenta la cantidad de clases.
- Puede agregar complejidad en escenarios simples.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
