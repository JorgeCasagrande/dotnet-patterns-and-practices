# 02 - Repository Pattern / Patrón Repositorio

## 🌐 English

### 🎯 Goal
This module demonstrates the Repository pattern in .NET, using an in-memory list to simulate a database.

### 🧠 Key Concepts
- **Repository Pattern**: Provides a way to separate the data access logic from the business logic by using a repository class to manage entities.
- **In-memory simulation**: Instead of a real database, a `List<T>` is used to store and manage entities for demonstration purposes.

### ➕ Advantages
- Decouples business logic from data access logic.
- Makes code easier to test and maintain.
- Allows swapping data sources (e.g., from in-memory to database) with minimal changes.

### ➖ Disadvantages
- Adds an extra layer of abstraction, which can be unnecessary for very simple applications.
- May introduce boilerplate code if not managed properly.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Repositorio en .NET, usando una lista en memoria para simular una base de datos.

### 🧠 Conceptos clave
- **Patrón Repositorio**: Proporciona una forma de separar la lógica de acceso a datos de la lógica de negocio mediante una clase repositorio que gestiona entidades.
- **Simulación en memoria**: En lugar de una base de datos real, se utiliza una `List<T>` para almacenar y gestionar entidades con fines demostrativos.

### ➕ Ventajas
- Desacopla la lógica de negocio de la lógica de acceso a datos.
- Facilita las pruebas y el mantenimiento del código.
- Permite cambiar la fuente de datos (por ejemplo, de memoria a base de datos) con cambios mínimos.

### ➖ Desventajas
- Añade una capa extra de abstracción, que puede ser innecesaria en aplicaciones muy simples.
- Puede introducir código repetitivo si no se gestiona adecuadamente.

---

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
