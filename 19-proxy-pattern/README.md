# Proxy Pattern / Patrón Proxy

## English

### Theory
The Proxy Pattern provides a surrogate or placeholder for another object to control access to it. The proxy can add additional behavior (such as logging, access control, or lazy initialization) before or after delegating requests to the real object. Proxies are commonly used for security, caching, remote access, and monitoring.

### When to Use
- When you need to control access to an object.
- To add cross-cutting concerns (logging, caching, security) transparently.
- For lazy initialization or resource management.
- To work with remote or expensive resources.

### Advantages
- Adds additional behavior without modifying the real object.
- Controls access and manages resources efficiently.
- Supports lazy loading and remote proxies.

### Disadvantages
- Adds extra layers and complexity.
- May introduce performance overhead.
- Can make debugging more difficult.

### Example
This module demonstrates how to use the Proxy Pattern to add logging to a real service. The code is fully commented in English for clarity.

---

## Español

### Teoría
El Patrón Proxy proporciona un sustituto o intermediario para otro objeto para controlar el acceso a él. El proxy puede agregar comportamiento adicional (como logging, control de acceso o inicialización diferida) antes o después de delegar solicitudes al objeto real. Los proxies se usan comúnmente para seguridad, caché, acceso remoto y monitoreo.

### Cuándo Usar
- Cuando necesitas controlar el acceso a un objeto.
- Para agregar aspectos transversales (logging, caché, seguridad) de forma transparente.
- Para inicialización diferida o gestión de recursos.
- Para trabajar con recursos remotos o costosos.

### Ventajas
- Agrega comportamiento adicional sin modificar el objeto real.
- Controla el acceso y gestiona recursos eficientemente.
- Soporta carga diferida y proxies remotos.

### Desventajas
- Añade capas y complejidad extra.
- Puede introducir sobrecarga de rendimiento.
- Puede dificultar la depuración.

### Ejemplo
Este módulo muestra cómo usar el Patrón Proxy para agregar logging a un servicio real. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---