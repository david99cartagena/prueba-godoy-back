# 🐱 CatFact & GIF Finder - Backend (.NET 8 Web API)

Este backend en .NET expone una API REST que interactúa con dos servicios externos (Cat Facts API y GIF API) y persiste los resultados de las búsquedas en una base de datos.

## 🚀 Tecnologías utilizadas

- .NET 8 Web API
- C#
- Entity Framework Core
- SQL Server (o SQLite, opcional)
- Swagger (documentación interactiva)

## 🎯 Endpoints principales

### `GET /api/search`

Genera un fact aleatorio, un GIF relacionado y almacena la búsqueda en la base de datos.

### `GET /api/search/history`

Retorna el historial completo de búsquedas.

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
