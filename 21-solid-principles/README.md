# SOLID Principles / Principios SOLID

## English

### Theory
SOLID is an acronym for five fundamental object-oriented design principles that help create robust, maintainable, and scalable software. Each principle addresses a specific aspect of software design:

- **S**: Single Responsibility Principle (SRP)
- **O**: Open/Closed Principle (OCP)
- **L**: Liskov Substitution Principle (LSP)
- **I**: Interface Segregation Principle (ISP)
- **D**: Dependency Inversion Principle (DIP)

---

### Principles in Detail

#### S: Single Responsibility Principle (SRP)
- **Theory:** A class should have only one reason to change, meaning it should have only one job or responsibility.
- **Advantages:**
  - Easier to understand and maintain code.
  - Reduces risk of bugs when making changes.
  - Promotes separation of concerns.
- **Disadvantages:**
  - May lead to more classes in the system.
  - Can be overkill for very simple scenarios.
- **Example:** A class that only handles invoice data, and another class that only prints invoices.

#### O: Open/Closed Principle (OCP)
- **Theory:** Software entities (classes, modules, functions) should be open for extension, but closed for modification.
- **Advantages:**
  - New functionality can be added without changing existing code.
  - Reduces risk of introducing bugs in existing features.
- **Disadvantages:**
  - May require more abstraction and use of inheritance or interfaces.
  - Can increase complexity if overused.
- **Example:** A base `Shape` class with an `Area()` method, and new shapes can be added by extending the class.

#### L: Liskov Substitution Principle (LSP)
- **Theory:** Subtypes must be substitutable for their base types without altering the correctness of the program.
- **Advantages:**
  - Promotes reliable polymorphism.
  - Ensures derived classes extend base classes without changing expected behavior.
- **Disadvantages:**
  - Violations can be subtle and hard to detect.
- **Example:** Any subclass of `Bird` can be used wherever a `Bird` is expected, and it will behave correctly.

#### I: Interface Segregation Principle (ISP)
- **Theory:** Clients should not be forced to depend on interfaces they do not use. Prefer several small, specific interfaces over a large, general-purpose one.
- **Advantages:**
  - Reduces side effects and unnecessary dependencies.
  - Makes code easier to refactor and maintain.
- **Disadvantages:**
  - May result in more interfaces to manage.
- **Example:** Separate `IWorker` and `IEater` interfaces, so classes only implement what they need.

#### D: Dependency Inversion Principle (DIP)
- **Theory:** High-level modules should not depend on low-level modules; both should depend on abstractions. Abstractions should not depend on details.
- **Advantages:**
  - Promotes loose coupling and flexibility.
  - Makes code easier to test and maintain.
- **Disadvantages:**
  - May require more interfaces and dependency injection.
- **Example:** A notification service depends on an `IMessageSender` interface, not a concrete email sender.

---

## Examples Structure

This module contains two sets of examples for each SOLID principle:

- **Basic Examples** (`SolidBasicExamples.cs`):
  - Simple, didactic scenarios for each principle.
  - Each principle is demonstrated in a dedicated method (e.g., `RunSRP`, `RunOCP`, etc.).
  - Output includes clear section headers and, for OCP, the class name and area for each shape.

- **Advanced Examples** (`AdvancedExamples.cs`):
  - Realistic, more complex scenarios for each principle.
  - Each principle is demonstrated in a dedicated method (e.g., `RunSRP`, `RunOCP`, etc.).
  - Output includes clear section headers and domain-inspired use cases (e.g., strategy pattern, domain services, API clients).

Both sets of examples son ejecutados desde `Program.cs` para facilitar la comparación y el aprendizaje.

---

## Español

### Teoría
SOLID es un acrónimo de cinco principios fundamentales del diseño orientado a objetos que ayudan a crear software robusto, mantenible y escalable. Cada principio aborda un aspecto específico del diseño de software:

- **S**: Principio de Responsabilidad Única (SRP)
- **O**: Principio Abierto/Cerrado (OCP)
- **L**: Principio de Sustitución de Liskov (LSP)
- **I**: Principio de Segregación de Interfaces (ISP)
- **D**: Principio de Inversión de Dependencias (DIP)

---

### Principios en Detalle

#### S: Principio de Responsabilidad Única (SRP)
- **Teoría:** Una clase debe tener una sola razón para cambiar, es decir, debe tener una única responsabilidad o función.
- **Ventajas:**
  - Código más fácil de entender y mantener.
  - Menor riesgo de errores al hacer cambios.
  - Promueve la separación de responsabilidades.
- **Desventajas:**
  - Puede llevar a tener más clases en el sistema.
  - Puede ser excesivo para escenarios muy simples.
- **Ejemplo:** Una clase que solo maneja datos de facturas y otra que solo imprime facturas.

#### O: Principio Abierto/Cerrado (OCP)
- **Teoría:** Las entidades de software deben estar abiertas para extensión, pero cerradas para modificación.
- **Ventajas:**
  - Se puede agregar nueva funcionalidad sin modificar el código existente.
  - Menor riesgo de introducir errores en características ya implementadas.
- **Desventajas:**
  - Puede requerir más abstracción y uso de herencia o interfaces.
  - Puede aumentar la complejidad si se abusa del principio.
- **Ejemplo:** Una clase base `Shape` con un método `Area()`, y nuevas figuras se agregan extendiendo la clase.

#### L: Principio de Sustitución de Liskov (LSP)
- **Teoría:** Los subtipos deben ser sustituibles por sus tipos base sin alterar la corrección del programa.
- **Ventajas:**
  - Promueve el polimorfismo confiable.
  - Asegura que las clases derivadas extienden las bases sin cambiar el comportamiento esperado.
- **Desventajas:**
  - Las violaciones pueden ser sutiles y difíciles de detectar.
- **Ejemplo:** Cualquier subclase de `Bird` puede usarse donde se espera un `Bird` y se comportará correctamente.

#### I: Principio de Segregación de Interfaces (ISP)
- **Teoría:** Los clientes no deben depender de interfaces que no usan. Es mejor tener varias interfaces pequeñas y específicas que una grande y general.
- **Ventajas:**
  - Reduce efectos secundarios y dependencias innecesarias.
  - Facilita el mantenimiento y la refactorización.
- **Desventajas:**
  - Puede resultar en más interfaces para gestionar.
- **Ejemplo:** Interfaces separadas `IWorker` y `IEater`, para que las clases solo implementen lo que necesitan.

#### D: Principio de Inversión de Dependencias (DIP)
- **Teoría:** Los módulos de alto nivel no deben depender de módulos de bajo nivel; ambos deben depender de abstracciones. Las abstracciones no deben depender de los detalles.
- **Ventajas:**
  - Promueve el bajo acoplamiento y la flexibilidad.
  - Facilita las pruebas y el mantenimiento.
- **Desventajas:**
  - Puede requerir más interfaces e inyección de dependencias.
- **Ejemplo:** Un servicio de notificaciones depende de una interfaz `IMessageSender`, no de un remitente de correo concreto.

---

### Estructura de Ejemplos

Este módulo contiene dos conjuntos de ejemplos para cada principio SOLID:

- **Ejemplos Básicos** (`SolidBasicExamples.cs`):
  - Escenarios simples y didácticos para cada principio.
  - Cada principio se demuestra en un método dedicado (por ejemplo, `RunSRP`, `RunOCP`, etc.).
  - La salida incluye encabezados claros y, para OCP, el nombre de la clase y el área de cada figura.

- **Ejemplos Avanzados** (`AdvancedExamples.cs`):
  - Escenarios realistas y más complejos para cada principio.
  - Cada principio se demuestra en un método dedicado (por ejemplo, `RunSRP`, `RunOCP`, etc.).
  - La salida incluye encabezados claros y casos inspirados en dominios reales (patrón estrategia, servicios de dominio, clientes API).

Ambos conjuntos de ejemplos se ejecutan desde `Program.cs` para facilitar la comparación y el aprendizaje.

---

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
