# 03 - Unit of Work Pattern / Patrón Unidad de Trabajo

## 🌐 English

### 🎯 Goal
This module demonstrates the Unit of Work pattern in .NET, coordinating multiple repositories and simulating a transaction in memory.

### 🧠 Key Concepts
- **Unit of Work Pattern**: Maintains a list of operations to be performed and coordinates the writing out of changes as a single transaction.
- **Repository Integration**: Works together with repositories to ensure all changes are committed or rolled back as a unit.
- **In-memory simulation**: For demonstration, all data is managed in memory.

### ➕ Advantages
- Ensures data consistency by treating a set of operations as a single transaction.
- Centralizes transaction management.
- Makes code easier to test and maintain.

### ➖ Disadvantages
- Adds complexity and an extra layer of abstraction.
- May be unnecessary for simple scenarios or small applications.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Unidad de Trabajo (Unit of Work) en .NET, coordinando múltiples repositorios y simulando una transacción en memoria.

### 🧠 Conceptos clave
- **Patrón Unidad de Trabajo**: Mantiene una lista de operaciones a realizar y coordina la escritura de los cambios como una sola transacción.
- **Integración con repositorios**: Trabaja junto con los repositorios para asegurar que todos los cambios se confirmen o deshagan como una unidad.
- **Simulación en memoria**: Para la demostración, todos los datos se gestionan en memoria.

### ➕ Ventajas
- Garantiza la consistencia de los datos tratando un conjunto de operaciones como una sola transacción.
- Centraliza la gestión de transacciones.
- Facilita las pruebas y el mantenimiento del código.

### ➖ Desventajas
- Añade complejidad y una capa extra de abstracción.
- Puede ser innecesario en escenarios simples o aplicaciones pequeñas.

---

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
