# Service Locator / Localizador de Servicios

## English

### Theory
The Service Locator pattern provides a central registry (or locator) where application components can request dependencies by type or name. Instead of injecting dependencies directly, components ask the service locator for the required service. While this can simplify wiring in some scenarios, it can also hide dependencies and make code harder to test and maintain.

### When to Use
- When you need to resolve dependencies dynamically at runtime.
- In legacy systems where dependency injection is not feasible.
- For prototyping or simple applications (with caution).

### Advantages
- Centralizes service resolution logic.
- Can simplify configuration in some cases.
- Useful for dynamic or plugin-based scenarios.

### Disadvantages
- Hides dependencies, making code harder to understand and test.
- Can lead to tight coupling with the locator.
- Not recommended for most modern applications (prefer Dependency Injection).

### Example
This module demonstrates a basic service locator that registers and resolves services by type. The code is fully commented in English for clarity.

---

## Español

### Teoría
El patrón Service Locator proporciona un registro central (o localizador) donde los componentes de la aplicación pueden solicitar dependencias por tipo o nombre. En lugar de inyectar dependencias directamente, los componentes piden al localizador el servicio requerido. Aunque puede simplificar la configuración en algunos escenarios, también puede ocultar dependencias y dificultar las pruebas y el mantenimiento.

### Cuándo Usar
- Cuando necesitas resolver dependencias dinámicamente en tiempo de ejecución.
- En sistemas legados donde la inyección de dependencias no es factible.
- Para prototipos o aplicaciones simples (con precaución).

### Ventajas
- Centraliza la lógica de resolución de servicios.
- Puede simplificar la configuración en algunos casos.
- Útil para escenarios dinámicos o basados en plugins.

### Desventajas
- Oculta dependencias, dificultando la comprensión y pruebas del código.
- Puede llevar a un acoplamiento fuerte con el localizador.
- No se recomienda para la mayoría de aplicaciones modernas (preferir inyección de dependencias).

### Ejemplo
Este módulo muestra un localizador de servicios básico que registra y resuelve servicios por tipo. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
