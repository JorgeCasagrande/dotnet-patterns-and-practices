# Validation / Validación

## English

### Theory
Validation is the process of ensuring that data meets certain rules or constraints before it is processed or stored. In .NET, validation can be implemented manually, using attributes (Data Annotations), or with specialized libraries. Good validation prevents errors, improves data quality, and enhances security.

### When to Use
- Always validate user input or external data.
- When business rules or data integrity are important.
- Before saving data to a database or processing it further.

### Advantages
- Prevents invalid or harmful data from entering the system.
- Improves user experience by providing clear feedback.
- Helps maintain data integrity and security.

### Disadvantages
- Can add boilerplate code if not using reusable patterns.
- Overly strict validation may block legitimate input.
- Needs to be maintained as business rules evolve.

### Example
This module demonstrates how to validate user data (e.g., name, email, age) using both manual validation and a reusable validator class. The code is fully commented in English for clarity.

---

## Español

### Teoría
La validación es el proceso de asegurar que los datos cumplen ciertas reglas o restricciones antes de ser procesados o almacenados. En .NET, la validación puede implementarse manualmente, con atributos (Data Annotations) o usando librerías especializadas. Una buena validación previene errores, mejora la calidad de los datos y aumenta la seguridad.

### Cuándo Usar
- Siempre valida la entrada del usuario o datos externos.
- Cuando las reglas de negocio o la integridad de los datos son importantes.
- Antes de guardar datos en una base de datos o procesarlos.

### Ventajas
- Previene que datos inválidos o dañinos entren al sistema.
- Mejora la experiencia del usuario al dar retroalimentación clara.
- Ayuda a mantener la integridad y seguridad de los datos.

### Desventajas
- Puede agregar código repetitivo si no se usan patrones reutilizables.
- Una validación demasiado estricta puede bloquear entradas legítimas.
- Debe mantenerse a medida que evolucionan las reglas de negocio.

### Ejemplo
Este módulo muestra cómo validar datos de usuario (nombre, email, edad) usando validación manual y una clase validadora reutilizable. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
