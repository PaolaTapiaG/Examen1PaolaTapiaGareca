CREATE DATABASE Examen1;
CREATE TABLE Persona (
IDPersona INT PRIMARY KEY,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Estado VARCHAR(50)
);

CREATE TABLE Empleado (
IDEmpleado INT PRIMARY KEY,
IDPersona INT,
Puesto VARCHAR(100),
Salario DECIMAL(10, 2),
FechaContratacion DATE,
FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona)
);

INSERT INTO Persona (IDPersona, Nombre, Apellido, Estado) VALUES 
(1, 'Juan', 'Pérez', 'Activo'),
(2, 'María', 'González', 'Inactivo'),
(3, 'Pedro', 'Sánchez', 'Activo');

INSERT INTO Empleado (IDEmpleado, IDPersona, Puesto, Salario, FechaContratacion) VALUES 
(101, 1, 'Gerente', 5000.00, '2020-01-15'),
(102, 2, 'Analista', 3500.00, '2021-03-20'),
(103, 3, 'Asistente', 2500.00, '2021-07-10');

Select* From Persona
