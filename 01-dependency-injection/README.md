# 01 - Dependency Injection / Inyección de Dependencias

## 🌐 English

### 🎯 Goal
This module demonstrates the Dependency Injection (DI) pattern in .NET, showing both manual (constructor) injection and the use of the built-in .NET DI container.

### 🧠 Key Concepts
- **Dependency Injection** is a design pattern that allows you to decouple classes from their dependencies, making code easier to test and maintain.
- **Manual injection**: Dependencies are provided via the constructor.
- **DI Container**: .NET provides a built-in container to automatically resolve and inject dependencies.

### ▶️ How does it work?
1. **Manual Injection:**
   - You create the dependency (`EmailMessageService`) and pass it to the consumer (`Notifier`) via the constructor.
   - This makes the dependency explicit and easy to replace for testing.
2. **.NET DI Container:**
   - You register the service and consumer types in the DI container.
   - The container creates and injects the dependencies automatically when you request the consumer (`Notifier`).
   - This approach is scalable and preferred for larger applications.

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el patrón de Inyección de Dependencias (DI) en .NET, mostrando tanto la inyección manual (por constructor) como el uso del contenedor de DI integrado en .NET.

### 🧠 Conceptos clave
- **Inyección de dependencias** es un patrón de diseño que permite desacoplar las clases de sus dependencias, facilitando las pruebas y el mantenimiento del código.
- **Inyección manual**: Las dependencias se pasan mediante el constructor.
- **Contenedor de DI**: .NET provee un contenedor integrado para resolver e inyectar dependencias automáticamente.

### ▶️ ¿Cómo funciona?
1. **Inyección manual:**
   - Creas la dependencia (`EmailMessageService`) y la pasas al consumidor (`Notifier`) mediante el constructor.
   - Esto hace que la dependencia sea explícita y fácil de reemplazar para pruebas.
2. **Contenedor de DI de .NET:**
   - Registras los tipos de servicio y consumidor en el contenedor de DI.
   - El contenedor crea e inyecta las dependencias automáticamente cuando solicitas el consumidor (`Notifier`).
   - Este enfoque es escalable y preferido en aplicaciones grandes.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)
- Paquete NuGet: `Microsoft.Extensions.DependencyInjection`

### ▶️ Execute/Ejecutar
```bash
dotnet run

---
