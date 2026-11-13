# API de películas · .NET 10

API REST construida con **ASP.NET Core (.NET 10)**, **Entity Framework Core** y **SQL Server**, documentada con **Swagger / OpenAPI**. Es un proyecto de formación en desarrollo backend con el ecosistema de Microsoft, y sigue creciendo por etapas.

## Estado actual

| Capa | Qué incluye hoy |
| :-- | :-- |
| **Plataforma** | ASP.NET Core Web API sobre .NET 10 |
| **Persistencia** | EF Core con enfoque *Code First*, SQL Server y migración inicial |
| **Dominio** | Entidad `Categoria` (`Id`, `Nombre`, `FechaCreacion`) con validaciones por atributos |
| **Acceso a datos** | Patrón Repositorio (`ICategoriaRepositorio` y su implementación) |
| **Documentación** | Swagger UI disponible en desarrollo, con la ruta `/swagger` como página de inicio |

## Próximos pasos

- [ ] Controladores con los endpoints CRUD (GET, POST, PUT, DELETE)
- [ ] DTOs y mapeo automático con AutoMapper
- [ ] Entidad `Pelicula` y su repositorio
- [ ] Autenticación y autorización con JWT e ASP.NET Core Identity

## Estructura

```
APIpeliculas/
├── Data/            # ApplicationDbContext (EF Core)
├── Models/          # Entidades del dominio
├── Repositorio/     # Contratos e implementaciones de acceso a datos
├── Migrations/      # Migraciones de EF Core
└── Program.cs       # Configuración de servicios, Swagger y pipeline
```

## Tecnologías

`C#` · `.NET 10` · `ASP.NET Core` · `Entity Framework Core 10` · `SQL Server` · `Swashbuckle (Swagger)`

## Cómo ejecutarlo

Requisitos: [.NET 10 SDK](https://dotnet.microsoft.com/download) y una instancia de SQL Server.

1. Ajusta la cadena de conexión `ConexionSQL` en `APIpeliculas/appsettings.json`.
2. Aplica las migraciones y levanta la API:

```bash
cd APIpeliculas
dotnet ef database update
dotnet run --launch-profile https
```

3. Se abre Swagger UI en `https://localhost:7263/swagger`.

## Detalles de configuración

- **Swagger en .NET 10.** Desde .NET 9 la plantilla ya no incluye Swagger, así que se registra a mano en `Program.cs` con `AddSwaggerGen()`, `UseSwagger()` y `UseSwaggerUI()`, solo en el entorno de desarrollo.
- **Arranque directo en Swagger.** El perfil `https` de `Properties/launchSettings.json` usa `"launchUrl": "swagger"` para que el navegador abra la interfaz al ejecutar el proyecto.
