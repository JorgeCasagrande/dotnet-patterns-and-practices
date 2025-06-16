# 08 - Strategy Pattern / Patrón Estrategia

## 🌐 English

### 🎯 Goal
This module demonstrates the Strategy pattern in .NET, applying it to a domain scenario (e.g., payment processing with different strategies).

### 🧠 Key Concepts
- **Strategy Pattern**: Defines a family of algorithms, encapsulates each one, and makes them interchangeable. The strategy lets the algorithm vary independently from clients that use it.
- **Polymorphism**: The context interacts with the strategy interface, allowing different concrete strategies to be used interchangeably at runtime. This is a key benefit of the pattern.
- **Domain Example**: Commonly used in business logic, such as payment methods, sorting algorithms, or validation rules.
- **Decoupling**: The context class delegates the algorithm to a strategy interface, promoting flexibility and maintainability.

### ➕ Advantages
- Makes algorithms interchangeable at runtime.
- Promotes code reuse and separation of concerns.
- Simplifies unit testing by isolating strategies.

### ➖ Disadvantages
- Increases the number of classes.
- Can add complexity if overused for simple logic.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Estrategia en .NET, aplicándolo a un escenario de dominio (por ejemplo, procesamiento de pagos con diferentes estrategias).

### 🧠 Conceptos clave
- **Patrón Estrategia**: Define una familia de algoritmos, encapsula cada uno y los hace intercambiables. Permite variar el algoritmo independientemente de los clientes que lo usan.
- **Polimorfismo**: El contexto interactúa con la interfaz de estrategia, permitiendo usar diferentes estrategias concretas de forma intercambiable en tiempo de ejecución. Este es un beneficio clave del patrón.
- **Ejemplo de dominio**: Muy usado en lógica de negocio, como métodos de pago, algoritmos de ordenamiento o reglas de validación.
- **Desacoplamiento**: La clase contexto delega el algoritmo a una interfaz de estrategia, promoviendo flexibilidad y mantenibilidad.

### ➕ Ventajas
- Permite intercambiar algoritmos en tiempo de ejecución.
- Promueve la reutilización de código y la separación de responsabilidades.
- Facilita las pruebas unitarias al aislar las estrategias.

### ➖ Desventajas
- Aumenta la cantidad de clases.
- Puede agregar complejidad si se usa en lógica muy simple.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---