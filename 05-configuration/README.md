# 05 - Configuration / Configuración

## 🌐 English

### 🎯 Goal
This module demonstrates configuration management in .NET, including reading settings from `appsettings.json` and environment variables.

### 🧠 Key Concepts
- **Configuration**: Centralized management of application settings, such as connection strings, API keys, and custom options.
- **Providers**: .NET supports multiple configuration providers, including JSON files, environment variables, command-line arguments, and more.
- **Binding**: Configuration values can be bound to strongly-typed objects for easier access.

### ➕ Advantages
- Centralizes and simplifies management of settings.
- Supports multiple sources and overrides (e.g., environment variables for production).
- Strongly-typed binding reduces errors.

### ➖ Disadvantages
- Sensitive data in configuration files must be protected.
- Misconfiguration can lead to runtime errors.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra la gestión de configuración en .NET, incluyendo la lectura de valores desde `appsettings.json` y variables de entorno.

### 🧠 Conceptos clave
- **Configuración**: Gestión centralizada de parámetros de la aplicación, como cadenas de conexión, claves de API y opciones personalizadas.
- **Proveedores**: .NET soporta múltiples proveedores de configuración, incluyendo archivos JSON, variables de entorno, argumentos de línea de comandos y más.
- **Binding**: Los valores de configuración pueden vincularse a objetos tipados para facilitar el acceso.

### ➕ Ventajas
- Centraliza y simplifica la gestión de parámetros.
- Soporta múltiples fuentes y sobreescrituras (por ejemplo, variables de entorno para producción).
- El binding tipado reduce errores.

### ➖ Desventajas
- Los datos sensibles en archivos de configuración deben protegerse.
- Una mala configuración puede causar errores en tiempo de ejecución.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)
- Paquetes NuGet:
  - `Microsoft.Extensions.Configuration`
  - `Microsoft.Extensions.Configuration.Json`
  - `Microsoft.Extensions.Configuration.EnvironmentVariables`

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---
