# 🎬 APIPeliculas - .NET 10 Web API

¡Bienvenido al repositorio de **APIPeliculas**! Este proyecto es una API RESTful completa, profesional y segura desarrollada como parte de mi formación avanzada en el desarrollo backend con el ecosistema de Microsoft. Aunque el curso base está estructurado en .NET 9, este repositorio está completamente adaptado y desarrollado utilizando **.NET 10**, implementando las últimas novedades, optimizaciones y estándares del framework.

La API está diseñada bajo una arquitectura desacoplada e independiente. Toda la documentación, contratos y pruebas de los métodos HTTP (GET, POST, PUT, DELETE) se gestionan e interactúan de forma dinámica a través de **OpenAPI / Swagger UI** directamente desde el navegador.

---

## 🚀 Tecnologías y Características del Proyecto

* **Backend:** .NET 10 (ASP.NET Core Web API)
* **Persistencia de Datos (ORM):** Entity Framework Core (Enfoque Code First)
* **Base de Datos:** Microsoft SQL Server
* **Documentación y Pruebas:** OpenAPI / Swagger UI (Configurado Manualmente)
* **Arquitectura:** Patrón Repositorio (Repository Pattern) & Mapeo con DTOs
* **Seguridad:** Autenticación y Autorización basada en JWT (JSON Web Tokens) e Identity

---

## 📂 Estructura Completa del Proyecto

El proyecto sigue una arquitectura limpia estructurada en la solución a través de las siguientes capas especializadas:
* `Controllers/`: Contiene los controladores que exponen los endpoints y manejan las peticiones HTTP de la API.
* `Data/`: Aloja el contexto de la base de datos (`ApplicationDbContext`) para la comunicación con el ORM.
* `Models/`: Entidades puras del dominio del negocio que representan las tablas de la base de datos.
* `Models/Dtos/`: Objetos de Transferencia de Datos utilizados para moldear y asegurar las entradas/salidas de información.
* `PeliculasMapper/`: Perfiles de mapeo automático (AutoMapper) para la conversión limpia entre entidades y DTOs.
* `Repositorio/`: Contratos (`IRepositorio`) e implementaciones de la lógica de acceso a datos para desacoplar el controlador del ORM.

---

## 📦 Paquetes y Extensiones (NuGet)

Para habilitar la persistencia de datos, las migraciones automáticas y la interfaz de documentación, se integraron los siguientes paquetes esenciales en el proyecto:

1. **`Swashbuckle.AspNetCore`**: Motor encargado de generar la especificación OpenAPI y renderizar la interfaz gráfica de Swagger UI.
2. **`Microsoft.EntityFrameworkCore`**: El núcleo del ORM de Microsoft que provee el motor base y soporte para clases como `DbContext`.
3. **`Microsoft.EntityFrameworkCore.SqlServer`**: Proveedor oficial que le enseña a Entity Framework Core cómo traducir consultas de Linq a código nativo de SQL Server.
4. **`Microsoft.EntityFrameworkCore.Tools`**: Paquete de comandos que habilita la Consola de Administrador de Paquetes para la creación de migraciones (`Add-Migration`) y actualización de tablas (`Update-Database`).

---

## 🛠️ Configuración de Infraestructura Base

### 1. Resurrección y Automatización de Swagger UI en .NET 10
Dado que .NET 10 retira Swagger por defecto, se configuraron manualmente los archivos centrales para levantar la interfaz gráfica al dar Play:

* **Configuración en `Program.cs`:**
```csharp
var builder = WebApplication.CreateBuilder(args);

// Registrar explorador de endpoints y generador de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Activar la interfaz gráfica en entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Renderiza la UI interactiva en la ruta /swagger
}

app.Run();
2. Redirección en Properties/launchSettings.json (Perfil HTTPS)
Para evitar que el proyecto inicie apuntando a una pantalla en blanco o a un archivo JSON plano, se configuró manualmente el perfil HTTPS en los ajustes de lanzamiento del servidor. Esto fuerza al navegador web del sistema a abrirse de forma automática y apuntar directamente a la ruta de la interfaz gráfica de Swagger:

JSON
"https": {
  "commandName": "Project",
  "dotnetRunMessages": true,
  "launchBrowser": true,
  "launchUrl": "swagger",
  "applicationUrl": "https://localhost:7263;http://localhost:5176",
  "environmentVariables": {
    "ASPNETCORE_ENVIRONMENT": "Development"
  }
}
**`EOF`**
