# Caching / Caching (Almacenamiento en Caché)

## English

### Theory
Caching is a technique used to temporarily store frequently accessed data in a fast storage layer, reducing the need to repeatedly fetch or compute the same information. In .NET, caching can be implemented in-memory, distributed, or using third-party providers. Caching improves performance, reduces latency, and can help scale applications.

### When to Use
- When data is expensive to retrieve or compute.
- For frequently accessed data that does not change often.
- To reduce load on databases or external services.

### Advantages
- Improves application performance and responsiveness.
- Reduces load on backend systems.
- Can help scale applications to handle more users.

### Disadvantages
- Adds complexity to data consistency and cache invalidation.
- Risk of serving stale data if not managed properly.
- Memory usage increases with in-memory caching.

### Example
This module demonstrates how to use a simple in-memory cache to store and retrieve data, simulating a slow data source. The code is fully commented in English for clarity.

---

## Español

### Teoría
El almacenamiento en caché es una técnica utilizada para guardar temporalmente datos de acceso frecuente en una capa de almacenamiento rápido, reduciendo la necesidad de recuperar o calcular la misma información repetidamente. En .NET, la caché puede implementarse en memoria, de forma distribuida o usando proveedores externos. La caché mejora el rendimiento, reduce la latencia y ayuda a escalar aplicaciones.

### Cuándo Usar
- Cuando los datos son costosos de recuperar o calcular.
- Para datos de acceso frecuente que no cambian a menudo.
- Para reducir la carga en bases de datos o servicios externos.

### Ventajas
- Mejora el rendimiento y la capacidad de respuesta de la aplicación.
- Reduce la carga en los sistemas de backend.
- Ayuda a escalar aplicaciones para más usuarios.

### Desventajas
- Añade complejidad en la consistencia de datos e invalidación de caché.
- Riesgo de servir datos obsoletos si no se gestiona correctamente.
- El uso de memoria aumenta con la caché en memoria.

### Ejemplo
Este módulo muestra cómo usar una caché en memoria para almacenar y recuperar datos, simulando una fuente de datos lenta. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---