# Adapter Pattern / Patrón Adaptador

## English

### Theory
The Adapter Pattern allows objects with incompatible interfaces to work together by providing a wrapper (adapter) that translates one interface into another. This is useful when integrating with legacy code, third-party libraries, or systems with different interfaces. The adapter acts as a bridge between the client and the adaptee.

### When to Use
- When you need to use an existing class but its interface does not match what you need.
- To integrate with legacy or third-party code.
- To enable classes with incompatible interfaces to collaborate.

### Advantages
- Promotes code reuse by adapting existing classes.
- Decouples client code from concrete implementations.
- Makes integration with external systems easier.

### Disadvantages
- Adds extra layers of abstraction.
- Can increase code complexity if overused.
- May introduce performance overhead in some scenarios.

### Example
This module demonstrates how to use the Adapter Pattern to make a legacy logger compatible with a new logging interface. The code is fully commented in English for clarity.

---

## Español

### Teoría
El Patrón Adaptador permite que objetos con interfaces incompatibles trabajen juntos proporcionando un envoltorio (adaptador) que traduce una interfaz en otra. Es útil al integrar código legado, librerías de terceros o sistemas con diferentes interfaces. El adaptador actúa como un puente entre el cliente y el adaptado.

### Cuándo Usar
- Cuando necesitas usar una clase existente pero su interfaz no coincide con lo que necesitas.
- Para integrar código legado o de terceros.
- Para permitir que clases con interfaces incompatibles colaboren.

### Ventajas
- Fomenta la reutilización de código adaptando clases existentes.
- Desacopla el código cliente de implementaciones concretas.
- Facilita la integración con sistemas externos.

### Desventajas
- Añade capas extra de abstracción.
- Puede aumentar la complejidad si se abusa del patrón.
- Puede introducir sobrecarga de rendimiento en algunos escenarios.

### Ejemplo
Este módulo muestra cómo usar el Patrón Adaptador para hacer compatible un logger legado con una nueva interfaz de logging. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---