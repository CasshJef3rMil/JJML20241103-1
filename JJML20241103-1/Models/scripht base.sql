-- Usar la base de datos recién creada
USE JML20241103;
GO

-- Crear tabla de Empleados
CREATE TABLE Empleados (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Edad INT,
    Cargo VARCHAR(100),
    FechaContratacion DATE NOT NULL
);

-- Crear tabla de Referencias Personales
CREATE TABLE ReferenciasPersonales (
    Id INT PRIMARY KEY IDENTITY(1,1),
    EmpleadoId INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Relacion VARCHAR(100),
    Telefono VARCHAR(20),
    FOREIGN KEY (EmpleadoId) REFERENCES Empleados(Id) ON DELETE CASCADE
);
