# 07 - Singleton Pattern / Patrón Singleton

## 🌐 English

### 🎯 Goal
This module demonstrates the Singleton pattern in .NET, including both classic and thread-safe implementations.

### 🧠 Key Concepts
- **Singleton Pattern**: Ensures a class has only one instance and provides a global point of access to it.
- **Classic Singleton**: Simple implementation, but not thread-safe.
- **Thread-Safe Singleton**: Uses locking or static initialization to ensure only one instance is created, even in multithreaded scenarios.

### ➕ Advantages
- Guarantees a single instance throughout the application's lifetime.
- Useful for shared resources (e.g., configuration, logging, caches).
- Provides a global access point.

### ➖ Disadvantages
- Can introduce hidden dependencies and make testing harder.
- May lead to issues in multithreaded environments if not implemented correctly.
- Can be considered an anti-pattern if overused.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón Singleton en .NET, incluyendo implementaciones clásica y segura para hilos (thread-safe).

### 🧠 Conceptos clave
- **Patrón Singleton**: Garantiza que una clase tenga solo una instancia y proporciona un punto de acceso global a ella.
- **Singleton clásico**: Implementación simple, pero no segura para hilos.
- **Singleton thread-safe**: Usa locking o inicialización estática para asegurar que solo se cree una instancia, incluso en escenarios multihilo.

### ➕ Ventajas
- Garantiza una única instancia durante toda la vida de la aplicación.
- Útil para recursos compartidos (por ejemplo, configuración, logging, cachés).
- Proporciona un punto de acceso global.

### ➖ Desventajas
- Puede introducir dependencias ocultas y dificultar las pruebas.
- Puede causar problemas en entornos multihilo si no se implementa correctamente.
- Puede considerarse un anti-patrón si se abusa de él.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
