CREATE TABLE inventario (
    id INT IDENTITY(1,1) PRIMARY KEY,
    producto NVARCHAR(100) NOT NULL,
    cantidad INT NOT NULL
);


SELECT * FROM inventario;

SELECT producto FROM inventario;

SELECT COUNT(*) FROM inventario;

SELECT SUM(cantidad) FROM inventario;



INSERT INTO inventario (producto, cantidad)
VALUES ('Vasos rocas 24oz', 50), 
	   ('Vasos rocas 16oz', 70);


