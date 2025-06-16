# CQRS (Command Query Responsibility Segregation) / CQRS (Segregación de Responsabilidad de Comandos y Consultas)

## English

### Theory
CQRS (Command Query Responsibility Segregation) is a software architectural pattern that separates read (query) and write (command) operations into different models. This separation allows each side to be optimized, scaled, and evolved independently. Commands are responsible for changing the state of the system, while queries only retrieve data and never modify state.

### When to Use
- Complex domains where read and write workloads are very different.
- Systems requiring high scalability or performance.
- Applications that benefit from clear separation of concerns.

### Advantages
- Clear separation of concerns between reads and writes.
- Enables independent scaling and optimization of read and write sides.
- Facilitates complex business logic for commands.
- Can improve performance, security, and maintainability.
- Supports eventual consistency and event-driven architectures.

### Disadvantages
- Increased complexity in design and implementation.
- Potential for code duplication between models.
- Eventual consistency issues if using separate data stores.
- Not always necessary for simple CRUD applications.

### Example
This module demonstrates a basic order system where commands are used to create orders and queries are used to retrieve them. The code is fully commented in English for clarity.

---

## Español

### Teoría
CQRS (Segregación de Responsabilidad de Comandos y Consultas) es un patrón arquitectónico de software que separa las operaciones de lectura (consultas) y escritura (comandos) en modelos diferentes. Esta separación permite que cada lado se optimice, escale y evolucione de forma independiente. Los comandos son responsables de cambiar el estado del sistema, mientras que las consultas solo recuperan datos y nunca modifican el estado.

### Cuándo Usar
- Dominios complejos donde las cargas de trabajo de lectura y escritura son muy diferentes.
- Sistemas que requieren alta escalabilidad o rendimiento.
- Aplicaciones que se benefician de una clara separación de responsabilidades.

### Ventajas
- Separación clara de responsabilidades entre lecturas y escrituras.
- Permite escalar y optimizar cada lado de forma independiente.
- Facilita lógica de negocio compleja en comandos.
- Puede mejorar el rendimiento, la seguridad y el mantenimiento.
- Soporta consistencia eventual y arquitecturas orientadas a eventos.

### Desventajas
- Mayor complejidad en el diseño e implementación.
- Posible duplicación de código entre modelos.
- Problemas de consistencia eventual si se usan almacenes de datos separados.
- No siempre es necesario para aplicaciones CRUD simples.

### Ejemplo
Este módulo muestra un sistema básico de pedidos donde los comandos se usan para crear pedidos y las consultas para recuperarlos. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
