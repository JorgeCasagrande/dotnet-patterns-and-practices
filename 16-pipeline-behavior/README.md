# Pipeline Behavior / Comportamiento de Pipeline

## English

### Theory
Pipeline behavior is a pattern where a series of processing steps (behaviors or middleware) are chained together to handle a request or command. Each step can perform actions before and/or after passing control to the next step. This is commonly used in request/response frameworks, such as MediatR in .NET, to implement cross-cutting concerns like logging, validation, caching, or error handling in a clean and reusable way.

### When to Use
- When you need to apply cross-cutting concerns to requests or commands.
- To keep business logic clean and focused.
- When you want to add, remove, or reorder behaviors without changing core logic.

### Advantages
- Clean separation of concerns.
- Reusable and composable behaviors.
- Easy to add or remove processing steps.
- Reduces code duplication.

### Disadvantages
- Can add complexity to the request pipeline.
- Debugging can be harder if the pipeline is long or dynamic.
- Overuse may lead to unnecessary indirection.

### Example
This module demonstrates a basic pipeline where a request passes through logging and validation behaviors before being handled. The code is fully commented in English for clarity.

---

## Español

### Teoría
El comportamiento de pipeline es un patrón donde una serie de pasos de procesamiento (comportamientos o middleware) se encadenan para manejar una solicitud o comando. Cada paso puede realizar acciones antes y/o después de pasar el control al siguiente. Es común en frameworks de solicitud/respuesta, como MediatR en .NET, para implementar aspectos transversales como logging, validación, caché o manejo de errores de forma limpia y reutilizable.

### Cuándo Usar
- Cuando necesitas aplicar aspectos transversales a solicitudes o comandos.
- Para mantener la lógica de negocio limpia y enfocada.
- Cuando quieres agregar, quitar o reordenar comportamientos sin cambiar la lógica principal.

### Ventajas
- Separación clara de responsabilidades.
- Comportamientos reutilizables y componibles.
- Fácil de agregar o quitar pasos de procesamiento.
- Reduce la duplicación de código.

### Desventajas
- Puede agregar complejidad al pipeline de solicitudes.
- Depurar puede ser más difícil si el pipeline es largo o dinámico.
- El uso excesivo puede llevar a una indirecta innecesaria.

### Ejemplo
Este módulo muestra un pipeline básico donde una solicitud pasa por comportamientos de logging y validación antes de ser manejada. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
