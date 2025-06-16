# Template Method Pattern / Patrón Método Plantilla

## English

### Theory
The Template Method Pattern defines the skeleton of an algorithm in a base class, allowing subclasses to override specific steps without changing the overall structure. This promotes code reuse and enforces a consistent process while enabling customization of individual steps.

### When to Use
- When multiple classes share the same algorithm structure but differ in some steps.
- To enforce a sequence of operations while allowing flexibility in specific steps.
- To avoid code duplication by moving common logic to a base class.

### Advantages
- Promotes code reuse and consistency.
- Allows subclasses to customize specific steps.
- Reduces code duplication.

### Disadvantages
- Can lead to a rigid class hierarchy.
- Changes in the base algorithm affect all subclasses.
- May be overkill for simple scenarios.

### Example
This module demonstrates the Template Method Pattern by defining a data processing workflow in a base class, with subclasses customizing specific steps. The code is fully commented in English for clarity.

---

## Español

### Teoría
El Patrón Método Plantilla define el esqueleto de un algoritmo en una clase base, permitiendo que las subclases sobrescriban pasos específicos sin cambiar la estructura general. Esto fomenta la reutilización de código y asegura un proceso consistente, permitiendo la personalización de pasos individuales.

### Cuándo Usar
- Cuando varias clases comparten la misma estructura de algoritmo pero difieren en algunos pasos.
- Para imponer una secuencia de operaciones permitiendo flexibilidad en pasos concretos.
- Para evitar duplicación de código moviendo la lógica común a una clase base.

### Ventajas
- Fomenta la reutilización y consistencia del código.
- Permite a las subclases personalizar pasos específicos.
- Reduce la duplicación de código.

### Desventajas
- Puede llevar a una jerarquía de clases rígida.
- Cambios en el algoritmo base afectan a todas las subclases.
- Puede ser excesivo para escenarios simples.

### Ejemplo
Este módulo muestra el Patrón Método Plantilla definiendo un flujo de procesamiento de datos en una clase base, con subclases que personalizan pasos concretos. El código está completamente comentado en inglés para mayor claridad.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---