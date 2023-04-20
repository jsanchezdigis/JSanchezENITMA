CREATE DATABASE JSanchezENITMA
USE JSanchezENITMA
GO

CREATE TABLE Empleado(
nDIEmp INT IDENTITY(1,1) PRIMARY KEY,
nombEmp VARCHAR(30) NOT NULL,
sexEmp VARCHAR(5) NOT NULL,
fecNac DATE NOT NULL,
fecIncorporacion DATE NOT NULL,
salEmp INT NOT NULL,
comis INT NOT NULL,
codSuc INT NOT NULL,
jefeDI INT NOT NULL,
cargo VARCHAR(50) NOT NULL,
nroDepto INT NOT NULL
)
GO

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Maria', 'M', '1990-08-04', '2019-02-10', 2500, 1200, 3214, 10, 'Secretaria', 3)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Diana', 'M', '1994-11-14', '2018-04-01', 2500, 1200, 3214, 10, 'Secretaria', 2)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Jose', 'H', '1996-08-25', '2018-11-15', 2200, 800, 3214, 3, 'Vendedor', 5)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Pedro', 'H', '1996-01-02', '2019-02-19', 2600, 1000, 3214, 3, 'Vendedor', 6)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Alexa', 'M', '1997-09-10', '2019-01-11', 1900, 1200, 3214, 3, 'Vendedor', 6)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Felipe', 'H', '1995-06-12', '2019-10-25', 2100, 3900, 3214, 3, 'Vendedor', 6)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Andres', 'H', '1990-01-05', '2019-08-27', 3000, 1900, 3214, 3, 'Gerente Ventas', 2000)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Ricardo', 'H', '2000-12-28', '2019-03-14', 3000, 1900, 3214, 3, 'Gerente Ventas', 2000)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Lupita', 'M', '1997-07-12', '2019-02-19', 1450, 700, 3214, 5, 'Contador', 3000)

INSERT INTO Empleado (nombEmp, sexEmp, fecNac, fecIncorporacion, salEmp, comis, codSuc, jefeDI, cargo, nroDepto)
VALUES('Brenda', 'M', '1999-08-03', '2018-12-08', 2900, 1300, 3214, 5, 'Contador', 3000)
GO

/*TABLA Departamento*/
CREATE TABLE Departamento(
codDepto INT NOT NULL,
nombreDpto VARCHAR(50) NOT NULL,
ciudad VARCHAR(30) NOT NULL,
director VARCHAR(50) NOT NULL
)
GO

INSERT INTO Departamento (codDepto, nombreDpto, ciudad, director)
VALUES(6, 'Ventas', 'Ciudad de mexico',3214)

INSERT INTO Departamento (codDepto, nombreDpto, ciudad, director)VALUES(3, 'Ventas', 'Ciudad de mexico',3214)

INSERT INTO Departamento (codDepto, nombreDpto, ciudad, director)
VALUES(5, 'Administracion', 'Queretaro',3214)
GO

--1)Obtener los datos completos de los empleados.
SELECT nDIEmp,nombEmp,sexEmp,fecNac,fecIncorporacion,salEmp,comis,codSuc,jefeDI,cargo,nroDepto FROM Empleado 
--2)Obtener los datos completos de los departamentos.
SELECT codDepto,nombreDpto,ciudad,director FROM Departamento
--3)Obtener los datos de los empleados con cargo 'Secretaria'.
SELECT nDIEmp,nombEmp,sexEmp,fecNac,fecIncorporacion,salEmp,comis,codSuc,jefeDI,cargo,nroDepto FROM Empleado WHERE cargo='Secretaria'
--4)Obtener el nombre y salario de los empleados.
SELECT nombEmp,salEmp FROM Empleado
--5)Obtener los datos de los empleados vendedores, ordenado por nombre.
SELECT nDIEmp,nombEmp,sexEmp,fecNac,fecIncorporacion,salEmp,comis,codSuc,jefeDI,cargo,nroDepto FROM Empleado WHERE cargo='Vendedor' ORDER BY(nombEmp)
--6)Listar el nombre de los departamentos.
SELECT nombreDpto FROM Departamento
--7)Listar el nombre de los departamentos, ordenado por nombre.
SELECT nombreDpto FROM Departamento ORDER BY (nombreDpto)
--8)Listar el nombre de los departamentos, ordenado por ciudad.
SELECT nombreDpto,ciudad FROM Departamento ORDER BY (ciudad)
--9)Listar el nombre de los departamentos, ordenado por ciudad, en orden inverso.
SELECT nombreDpto,ciudad FROM Departamento ORDER BY (ciudad) DESC
--10)Obtener el nombre y cargo de todos los empleados, ordenado por salario.
SELECT nombEmp,cargo,salEmp FROM Empleado ORDER BY (salEmp)
--11)Obtener el nombre y cargo de todos los empleados, ordenado por cargo y por salario.
SELECT nombEmp,cargo,salEmp FROM Empleado GROUP BY cargo,nombEmp,salEmp
--12)Obtener el nombre y cargo de todos los empleados, en orden inverso por cargo.
SELECT nombEmp,cargo FROM Empleado ORDER BY(cargo) DESC
--13)Listar los salarios y comisiones de los empleados del departamento 2000.
SELECT salEmp,comis FROM Empleado WHERE nroDepto = 2000
--14)Listar los salarios y comisiones de los empleados del departamento 2000, ordenado por comisión.
SELECT salEmp,comis FROM Empleado WHERE nroDepto = 2000 ORDER BY (comis)
--15)Listar todas las comisiones.
SELECT comis AS Comisiones FROM Empleado
--16)Listar las comisiones que sean diferentes, ordenada por valor.
SELECT DISTINCT comis AS Comisiones FROM Empleado
--17)Listar los diferentes salarios.
SELECT DISTINCT salEmp AS Salario FROM Empleado
--18)Obtener el valor total a pagar que resulta de sumar a los empleados del departamento 3000 una 
--bonificación de $500.000, en orden alfabético del empleado
SELECT nombEmp,salEmp,SUM(salEmp + 500) AS ValorTotal FROM Empleado WHERE nroDepto = 3000 GROUP BY nombEmp,salEmp
--20)Obtener la lista de los empleados que ganan una comisión superior a su sueldo.
SELECT nombEmp,salEmp,comis FROM Empleado WHERE comis > salEmp
--21)Listar los empleados cuya comisión es menor o igual que el 30% de su sueldo.
SELECT nombEmp,comis FROM Empleado WHERE comis <= (.3 * salEmp)   
--22)Elabore un listado donde para cada fila, figure ‘Nombre’ y ‘Cargo’ antes del valor respectivo para cada empleado

---CHECAR
SELECT nombEmp AS Nombre,cargo AS Cargo, salEmp, comis FROM Empleado
--24)Hallar el salario y la comisión de aquellos empleados cuyo número de documento de identidad es superior al '19.709.802'
--No HACER

--26)Listar los empleados cuyo salario es menor o igual que el 40% de su comisión
SELECT nombEmp,comis FROM Empleado WHERE salEmp <= (.4 * comis)  
--27)Divida los empleados, generando un grupo cuyo nombre inicie por la letra J y termine en la letra Z.
SELECT nombEmp, cargo FROM Empleado WHERE nombEmp LIKE 'J%Z%'
--28)Liste estos empleados y su cargo por orden alfabético.
SELECT nombEmp, cargo FROM Empleado WHERE nombEmp LIKE 'J%Z%' ORDER BY cargo
--29)Listar el salario, la comisión, el salario total (salario + comisión), documento de identidad del
--empleado y nombre, de aquellos empleados que tienen comisión superior a $1.000.000, ordenar el
--informe por el número del documento de identidad
SELECT salEmp, comis,(salEmp + comis) AS SalarioTotal, nombEmp FROM Empleado WHERE comis > 1000
--32)Obtener un listado similar al anterior, pero de aquellos empleados que NO tienen comisión
SELECT salEmp, comis,(salEmp + comis) AS SalarioTotal, nombEmp FROM Empleado WHERE comis IS NULL
--33)Hallar el nombre de los empleados que tienen un salario superior a $1.000.000, y tienen como jefe al 
--empleado con documento de identidad '31.840.269'
SELECT nombEmp,salEmp,jefeDI FROM Empleado WHERE salEmp > 1000 AND jefeDI = 10
--35)Hallar el conjunto complementario del resultado del ejercicio anterior.
--36)Hallar los empleados cuyo nombre no contiene la cadena “MA”
SELECT nombEmp FROM Empleado WHERE nombEmp NOT LIKE '%MA%'
--37)Obtener los nombres de los departamentos que no sean “Ventas” ni “Investigación” ni ‘MANTENIMIENTO’, ordenados por ciudad.
SELECT nombreDpto,ciudad FROM Departamento WHERE nombreDpto != 'Ventas' AND nombreDpto != 'Mantenimiento' AND nombreDpto != 'Investigacion'

CREATE TABLE Exa_CatalogoProducto(
	IdProducto INT IDENTITY(1,1) PRIMARY KEY,
	Descripcion VARCHAR(256),
	IdUsuario INT,
	FechaCreacion DATETIME
)
GO

CREATE PROCEDURE sp_InsCatalogoProd
@Descripcion VARCHAR(256)
AS
INSERT INTO Exa_CatalogoProducto(Descripcion,IdUsuario,FechaCreacion)VALUES(@Descripcion,1,GETDATE())
GO

CREATE PROCEDURE sp_GetAllCatalogoProd
AS
SELECT IdProducto,Descripcion,IdUsuario,FechaCreacion FROM Exa_CatalogoProducto
GO