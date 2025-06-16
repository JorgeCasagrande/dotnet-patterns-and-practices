# 10 - Observer Pattern / Patrón Observador

## 🌐 English

### 🎯 Goal
This module demonstrates the Observer pattern in .NET, including both a classic implementation and the use of .NET's built-in `IObservable<T>` and `IObserver<T>` interfaces.

### 🧠 Key Concepts
- **Observer Pattern**: Defines a one-to-many dependency so that when one object changes state, all its dependents are notified and updated automatically.
- **Classic Implementation**: Uses custom interfaces for subject and observer.
- **.NET Implementation**: Uses the built-in `IObservable<T>` and `IObserver<T>` interfaces for reactive programming.

### ➕ Advantages
- Promotes loose coupling between subject and observers.
- Supports dynamic subscription and notification.
- .NET interfaces enable integration with reactive extensions (Rx.NET).

### ➖ Disadvantages
- Can lead to memory leaks if observers are not unsubscribed.
- May add complexity if overused for simple scenarios.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Observador en .NET, incluyendo una implementación clásica y el uso de las interfaces `IObservable<T>` y `IObserver<T>` de .NET.

### 🧠 Conceptos clave
- **Patrón Observador**: Define una dependencia uno-a-muchos para que cuando un objeto cambie de estado, todos sus dependientes sean notificados y actualizados automáticamente.
- **Implementación clásica**: Usa interfaces personalizadas para el sujeto y el observador.
- **Implementación en .NET**: Usa las interfaces integradas `IObservable<T>` y `IObserver<T>` para programación reactiva.

### ➕ Ventajas
- Promueve bajo acoplamiento entre el sujeto y los observadores.
- Soporta suscripción y notificación dinámica.
- Las interfaces de .NET permiten integración con reactive extensions (Rx.NET).

### ➖ Desventajas
- Puede causar fugas de memoria si los observadores no se desuscriben.
- Puede agregar complejidad si se usa en lógica muy simple.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
