# Event Sourcing / Event Sourcing (Almacenamiento de Eventos)

## English

### Theory
Event Sourcing is a software architectural pattern in which state changes are stored as a sequence of events, rather than as direct updates to the data model. Each event represents a fact that happened in the system, and the current state is rebuilt by replaying these events. This approach provides a complete audit trail and enables powerful features such as temporal queries and event-driven integration.

### When to Use
- Systems requiring a full audit log or history of changes.
- Domains where business logic is complex and evolves over time.
- Applications that benefit from event-driven architectures or integration.

### Advantages
- Complete history of all changes (auditability).
- Enables temporal queries (see state at any point in time).
- Supports event-driven integration and CQRS.
- Facilitates debugging and troubleshooting.

### Disadvantages
- Increased complexity in design and implementation.
- Event versioning and schema evolution can be challenging.
- Rebuilding state from a large event store can be slow without snapshots.
- Not always necessary for simple CRUD applications.

### Example
This module demonstrates a basic bank account where deposits and withdrawals are stored as events. The account balance is rebuilt by replaying all events. The code is fully commented in English for clarity.

---

## Español

### Teoría
Event Sourcing es un patrón arquitectónico de software en el que los cambios de estado se almacenan como una secuencia de eventos, en lugar de actualizaciones directas al modelo de datos. Cada evento representa un hecho que ocurrió en el sistema, y el estado actual se reconstruye reproduciendo estos eventos. Este enfoque proporciona una auditoría completa y permite características avanzadas como consultas temporales e integración orientada a eventos.

### Cuándo Usar
- Sistemas que requieren un historial completo o auditoría de cambios.
- Dominios donde la lógica de negocio es compleja y evoluciona con el tiempo.
- Aplicaciones que se benefician de arquitecturas orientadas a eventos o integración.

### Ventajas
- Historial completo de todos los cambios (auditoría).
- Permite consultas temporales (ver el estado en cualquier momento).
- Soporta integración orientada a eventos y CQRS.
- Facilita la depuración y el análisis de problemas.

### Desventajas
- Mayor complejidad en el diseño e implementación.
- El versionado de eventos y la evolución de esquemas pueden ser desafiantes.
- Reconstruir el estado desde un almacén de eventos grande puede ser lento sin snapshots.
- No siempre es necesario para aplicaciones CRUD simples.

### Ejemplo
Este módulo muestra una cuenta bancaria básica donde los depósitos y retiros se almacenan como eventos. El saldo se reconstruye reproduciendo todos los eventos. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---