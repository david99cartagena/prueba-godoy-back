# 🐱 CatFact & GIF Finder - Backend (.NET 8 Web API)

Este backend en .NET expone una API REST que interactúa con dos servicios externos (Cat Facts API y GIF API) y persiste los resultados de las búsquedas en una base de datos.

## 🚀 Tecnologías utilizadas

- **.NET 8 Web API** - net v8.0
- **C#** - v12
- **Entity Framework Core**
- **SQL Server 2019** - 15.0

Dependencias usadas:

- Microsoft.EntityFrameworkCore - 8.0.18
- Microsoft.EntityFrameworkCore.SqlServer - 8.0.18
- Microsoft.EntityFrameworkCore.Tools - 8.0.18
- Swashbuckle.AspNetCore - 6.6.2

## 📦 Estructura del proyecto

```
backend/
├── Controllers/           # Controladores de la API
├── Data/                  # DbContext y configuración de base de datos
├── DTOs/                  # Data Transfer Objects
├── Interfaces/            # Interfaces para los servicios y repositorios
├── Migrations/            # Migraciones de Entity Framework Core
├── Models/                # Modelos de entidades de la base de datos
├── Repositories/          # Implementación de lógica de acceso a datos
├── Services/              # Lógica de negocio y servicios externos (APIs, etc.)
├── Properties/            # Configuraciones de arranque (launchSettings)
├── Program.cs             # Punto de entrada del proyecto
├── scriptbasededatos.sql  # Script de creacion de base de datos y tabla SearchHistories
├── appsettings.json       # Configuración general
├── appsettings.Development.json  # Configuración para entorno de desarrollo
├── backend.csproj         # Archivo de proyecto
```

## 🎯 Endpoints principales

### `GET /api/fact`

Retorna un dato aleatorio desde la API externa **Cat Facts**.

### `GET /api/gif`

Genera internamente un fact aleatorio, toma las primeras 3 palabras como query, obtiene un GIF relacionado y **guarda la búsqueda en la base de datos**.

> 🔎 Este endpoint realiza tres acciones:
>
> 1. Obtiene un fact aleatorio.
> 2. Usa las primeras tres palabras del fact como búsqueda para un GIF.
> 3. Guarda el fact, el GIF y la fecha de búsqueda en la base de datos.

### `GET /api/history`

Retorna el historial completo de búsquedas almacenadas.

## 📌 Ejemplo de respuesta (`GET /api/gif`)

```json
{
  "factCompleto": "Cats sleep 70% of their lives.",
  "gifUrl": "https://media.giphy.com/media/abc123/giphy.gif",
  "tresPalabrasQuery": "Cats sleep 70%",
  "fechaBusqueda": "2025-07-24T16:45:00Z"
}
```

## 🧠 Datos almacenados

Cada búsqueda contiene:

- Fecha de búsqueda
- Texto completo del fact
- Tres palabras clave del fact
- URL del GIF encontrado

## ⚙️ Configuración local

1. Clona el repositorio:

   ```bash
   git clone https://github.com/david99cartagena/prueba-godoy-back.git
   ```

2. Instala los paquetes:

   ```bash
   dotnet restore
   ```

3. Aplica las migraciones y crea la base de datos:

   ```bash
   dotnet ef database update
   ```

4. Inicia la API:

   ```bash
   dotnet run
   ```

5. Swagger: http://localhost:8000/swagger

## 🔐 Variables de entorno

Asegúrate de configurar:

- API Key de GIF (por ejemplo, Tenor o Giphy)
- Cadena de conexión a SQL Server

## 📸 Imagenes de la Aplicacion

- **Vista de Swagger**  
  ![CatFact](https://raw.githubusercontent.com/david99cartagena/prueba-godoy-back/refs/heads/main/backend/Media/Screenshot_1.png)

- **Peticion fact**  
  ![CatFact](https://raw.githubusercontent.com/david99cartagena/prueba-godoy-back/refs/heads/main/backend/Media/Screenshot_2.png)

- **Peticion gif**  
  ![CatFact](https://raw.githubusercontent.com/david99cartagena/prueba-godoy-back/refs/heads/main/backend/Media/Screenshot_3.png)

- **Peticion history**  
  ![CatFact](https://raw.githubusercontent.com/david99cartagena/prueba-godoy-back/refs/heads/main/backend/Media/Screenshot_4.png)
