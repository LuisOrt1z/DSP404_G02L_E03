CREATE DATABASE TurnOverDB;
GO

USE TurnOverDB;
GO

CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    contrasena VARCHAR(100) NOT NULL,
    fecha_registro DATETIME DEFAULT GETDATE()
);
GO


CREATE TABLE Conciertos (
    id_concierto INT IDENTITY(1,1) PRIMARY KEY,
    nombre_concierto VARCHAR(100) NOT NULL,
    fecha_concierto DATE NOT NULL,
    ubicacion VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Secciones (
    id_seccion INT IDENTITY(1,1) PRIMARY KEY,
    id_concierto INT FOREIGN KEY REFERENCES Conciertos(id_concierto) ON DELETE CASCADE,
    nombre_seccion VARCHAR(50) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    cantidad_disponible INT NOT NULL
);
GO

CREATE TABLE Entradas (
    id_entrada INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario) ON DELETE CASCADE, 
    id_concierto INT FOREIGN KEY REFERENCES Conciertos(id_concierto) ON DELETE NO ACTION,  
    id_seccion INT FOREIGN KEY REFERENCES Secciones(id_seccion) ON DELETE NO ACTION, 
    cantidad INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    fecha_compra DATETIME DEFAULT GETDATE()
);
GO


CREATE TABLE HistorialCompras (
    id_historial INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario) ON DELETE CASCADE, 
    id_entrada INT FOREIGN KEY REFERENCES Entradas(id_entrada) ON DELETE NO ACTION, 
    fecha_historial DATETIME DEFAULT GETDATE()
);
GO
