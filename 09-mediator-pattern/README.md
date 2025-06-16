# 09 - Mediator Pattern / Patrón Mediador

## 🌐 English

### 🎯 Goal
This module demonstrates the classic Mediator pattern in .NET, showing how to centralize communication between components. It also references popular libraries like MediatR for advanced scenarios.

### 🧠 Key Concepts
- **Mediator Pattern**: Defines an object (mediator) that encapsulates how a set of objects interact, promoting loose coupling by preventing objects from referring to each other directly.
- **Centralized Communication**: Components communicate through the mediator, not directly with each other.
- **Reference**: In real-world .NET projects, libraries like [MediatR](https://github.com/jbogard/MediatR) are often used to implement the mediator pattern in a scalable way.

### ➕ Advantages
- Reduces dependencies between components.
- Simplifies communication and coordination logic.
- Improves maintainability and testability.

### ➖ Disadvantages
- The mediator can become complex if it handles too many responsibilities.
- Adds an extra layer of abstraction.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Mediador clásico en .NET, mostrando cómo centralizar la comunicación entre componentes. También se referencia el uso de librerías como MediatR para escenarios avanzados.

### 🧠 Conceptos clave
- **Patrón Mediador**: Define un objeto (mediador) que encapsula cómo interactúan un conjunto de objetos, promoviendo bajo acoplamiento al evitar que los objetos se refieran entre sí directamente.
- **Comunicación centralizada**: Los componentes se comunican a través del mediador, no directamente entre ellos.
- **Referencia**: En proyectos reales de .NET, se suelen usar librerías como [MediatR](https://github.com/jbogard/MediatR) para implementar el patrón mediador de forma escalable.

### ➕ Ventajas
- Reduce las dependencias entre componentes.
- Simplifica la lógica de comunicación y coordinación.
- Mejora la mantenibilidad y testabilidad.

### ➖ Desventajas
- El mediador puede volverse complejo si asume demasiadas responsabilidades.
- Añade una capa extra de abstracción.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
