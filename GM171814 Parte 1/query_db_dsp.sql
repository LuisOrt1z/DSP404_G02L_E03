
USE sistema_restaurante;

CREATE TABLE Clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,  
    nombre VARCHAR(100) NOT NULL,
    contrasena NVARCHAR(256) NOT NULL,
    telefono VARCHAR(20),
    email VARCHAR(100),
    direccion VARCHAR(255)
);

CREATE TABLE Empleados (
    id_empleado INT IDENTITY(1,1) PRIMARY KEY,  
    nombre VARCHAR(100) NOT NULL,
    contrasena NVARCHAR(256) NOT NULL,
    puesto VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100)
);

CREATE TABLE Menu (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,  
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(255),
    precio DECIMAL(10,2) NOT NULL,
    categoria VARCHAR(50)
);

CREATE TABLE Pedidos (
    id_pedido INT IDENTITY(1,1) PRIMARY KEY,  
    id_cliente INT,
    id_empleado INT,
    fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10,2),
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),
    FOREIGN KEY (id_empleado) REFERENCES Empleados(id_empleado)
);

CREATE TABLE Detalles_Pedido (
    id_detalle INT IDENTITY(1,1) PRIMARY KEY,  
    id_pedido INT,
    id_producto INT,
    cantidad INT NOT NULL,
    subtotal DECIMAL(10,2),
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (id_producto) REFERENCES Menu(id_producto)
);

CREATE TABLE Forma_Pago (
    id_forma_pago INT IDENTITY(1,1) PRIMARY KEY,  
    descripcion VARCHAR(50) NOT NULL
);

CREATE TABLE Pagos (
    id_pago INT IDENTITY(1,1) PRIMARY KEY,  
    id_pedido INT,
    id_forma_pago INT,
    monto DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (id_forma_pago) REFERENCES Forma_Pago(id_forma_pago)
);

INSERT INTO Clientes (nombre, telefono, email, direccion, contrasena)
VALUES 
('Juan Pérez', '2257-7000', 'juan.perez@email.com', 'calle plan del pino', 'passwordJuan'),
('Diego Soruyo', '2277-7000', 'diego.soruyo@email.com', 'calle plan del pino', 'passwordDiego');

INSERT INTO Empleados (nombre, puesto, telefono, email, contrasena) 
VALUES 
('Sofía Ramírez', 'Cajera', '2250-1234', 'sofia.ramirez@email.com', 'passwordSofia'),
('José Torres', 'Mesero', '2250-5678', 'jose.torres@email.com', 'passwordJose');
