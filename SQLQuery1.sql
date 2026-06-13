CREATE DATABASE ProductDB;

USE ProductDB;

CREATE TABLE Produts(
ID INT PRIMARY KEY IDENTITY NOT NULL,
NAME NVARCHAR(100) NOT NULL,
PRICE DECIMAL(10,2),
ISACTIVE BIT
)

INSERT INTO Produts (NAME, PRICE, ISACTIVE)
VALUES
('Laptop', 150000, 1),
('Mouse', 2500, 1),
('Keyboard', 4500, 1),
('Monitor', 45000, 1),
('Headphones', 8500, 1),
('USB Drive', 3000, 1),
('Webcam', 7000, 1),
('Printer', 35000, 1),
('Speaker', 12000, 1),
('Router', 9500, 1);

SELECT * FROM Produts;