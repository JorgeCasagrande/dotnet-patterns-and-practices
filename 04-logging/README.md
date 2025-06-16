# 04 - Logging / Registro de eventos

## 🌐 English

### 🎯 Goal
This module demonstrates logging in .NET, using both console and file providers.

### 🧠 Key Concepts
- **Logging**: The process of recording information about application execution, errors, and events for monitoring and troubleshooting.
- **Providers**: .NET supports multiple logging providers, such as console, file, debug, and more.
- **Serilog**: A popular third-party logging library for .NET, used here for its powerful file logging capabilities and flexible configuration.
- **Other Providers**: Besides Serilog, .NET supports built-in providers like Console, Debug, EventLog, Azure Application Insights, and others (e.g., NLog, log4net).
- **Configuration**: Logging can be configured to write messages to different outputs and with different levels (Information, Warning, Error, etc.).

### ➕ Advantages
- Helps diagnose and monitor application behavior.
- Supports multiple outputs (console, file, etc.).
- Flexible and extensible.

### ➖ Disadvantages
- Improper configuration can lead to performance issues or missing logs.
- Sensitive data may be exposed if not filtered properly.

---

## 🇪🇸 Español

### 🎯 Objetivo
Este módulo demuestra el registro de eventos (logging) en .NET, usando proveedores de consola y archivos.

### 🧠 Conceptos clave
- **Logging**: Proceso de registrar información sobre la ejecución de la aplicación, errores y eventos para monitoreo y diagnóstico.
- **Proveedores**: .NET soporta múltiples proveedores de logging, como consola, archivos, debug, y más.
- **Serilog**: Una de las librerías de logging más populares en .NET, utilizada aquí por su capacidad avanzada para registrar en archivos y su configuración flexible.
- **Otros proveedores**: Además de Serilog, .NET soporta proveedores integrados como Console, Debug, EventLog, Azure Application Insights y otros (por ejemplo, NLog, log4net).
- **Configuración**: El logging puede configurarse para escribir mensajes en diferentes salidas y con distintos niveles (Información, Advertencia, Error, etc.).

### ➕ Ventajas
- Ayuda a diagnosticar y monitorear el comportamiento de la aplicación.
- Soporta múltiples salidas (consola, archivo, etc.).
- Flexible y extensible.

### ➖ Desventajas
- Una configuración incorrecta puede causar problemas de rendimiento o pérdida de logs.
- Datos sensibles pueden ser expuestos si no se filtran adecuadamente.

### 📦 Requirements/Requisitos
- [.NET 6+](https://dotnet.microsoft.com/)
- Paquetes NuGet:
  - `Microsoft.Extensions.Logging`
  - `Serilog`
  - `Serilog.Extensions.Logging`
  - `Serilog.Sinks.File`
  - `Serilog.Sinks.Console`

---

## ▶️ Execute / Ejecutar
```bash
dotnet run
```

---