# 06 - Factory Pattern / Patrón Fábrica

## 🌐 English

### 🎯 Goal
This module demonstrates the Factory and Factory Method patterns in .NET, showing how to create objects without specifying the exact class of object that will be created.

### 🧠 Key Concepts
- **Factory Pattern**: Provides a way to create objects without exposing the instantiation logic to the client.
- **Simple Factory**: A static method or class that returns instances of different classes based on input. The client requests an object by type, and the factory decides which class to instantiate. This is not a formal GoF pattern, but is widely used for simplicity.
- **Factory Method Pattern**: Defines an interface for creating an object, but lets subclasses decide which class to instantiate. Each subclass implements the factory method to return a specific type. This supports extensibility and polymorphism.
- **Polymorphism**: Factories often return objects that share a common interface or base class.

### ➕ Advantages
- Decouples object creation from usage.
- Makes code more flexible and extensible.
- Supports polymorphism and the Open/Closed Principle.

### ➖ Disadvantages
- Adds extra classes and complexity.
- Can be overkill for simple scenarios.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra los patrones Fábrica y Método Fábrica en .NET, mostrando cómo crear objetos sin especificar la clase exacta que se va a instanciar.

### 🧠 Conceptos clave
- **Patrón Fábrica**: Proporciona una forma de crear objetos sin exponer la lógica de instanciación al cliente.
- **Fábrica Simple**: Un método o clase estática que retorna instancias de diferentes clases según un parámetro. El cliente solicita un objeto por tipo y la fábrica decide qué clase instanciar. No es un patrón formal GoF, pero es muy usado por su simplicidad.
- **Patrón Método Fábrica**: Define una interfaz para crear un objeto, pero permite que las subclases decidan qué clase instanciar. Cada subclase implementa el método fábrica para retornar un tipo específico. Esto soporta extensibilidad y polimorfismo.
- **Polimorfismo**: Las fábricas suelen devolver objetos que comparten una interfaz o clase base común.

### ➕ Ventajas
- Desacopla la creación de objetos de su uso.
- Hace el código más flexible y extensible.
- Soporta polimorfismo y el Principio Abierto/Cerrado.

### ➖ Desventajas
- Añade clases y complejidad extra.
- Puede ser excesivo para escenarios simples.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
