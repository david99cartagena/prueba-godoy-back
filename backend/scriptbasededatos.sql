-- 1. Crear la base de datos si no existe
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'prueba')
BEGIN
    CREATE DATABASE prueba;
END
GO

-- 2. Usar la base de datos
USE prueba;
GO

-- 3. Crear la tabla SearchHistories si no existe
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchHistories]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[SearchHistories] (
        [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [FechaBusqueda] DATETIME2 NOT NULL,
        [FactCompleto] NVARCHAR(MAX) NOT NULL,
        [TresPalabrasQuery] NVARCHAR(MAX) NOT NULL,
        [GifUrl] NVARCHAR(MAX) NOT NULL
    );
END
GO
