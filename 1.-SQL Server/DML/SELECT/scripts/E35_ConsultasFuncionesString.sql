SELECT 
id, 
nombre, 
primerApellido, 
segundoApellido, 
fechaNacimiento,GETDATE() as Hoy, 
DATEDIFF(MONTH,fechaNacimiento,GETDATE())/12 AS Edad,
DATEDIFF(MONTH, fechaNacimiento, DATEADD(MONTH, 5, GETDATE()))/12 AS Edad5Meses
FROM Alumnos;

SELECT 
id, 
UPPER(nombre), 
UPPER(primerApellido), 
UPPER(segundoApellido), 
fechaNacimiento,GETDATE() as Hoy, 
DATEDIFF(MONTH,fechaNacimiento,GETDATE())/12 AS Edad,
DATEDIFF(MONTH, fechaNacimiento, DATEADD(MONTH, 5, GETDATE()))/12 AS Edad5Meses
FROM Alumnos;

select curp from Alumnos
SELECT
id, 
nombre, 
primerApellido, 
segundoApellido, 
fechaNacimiento,GETDATE() as Hoy, 
DATEDIFF(MONTH,fechaNacimiento,GETDATE())/12 AS Edad,
DATEDIFF(MONTH, fechaNacimiento, DATEADD(MONTH, 5, GETDATE()))/12 AS Edad5Meses,
CONVERT(DATE, SUBSTRING(curp, 5, 6)) as [Fecha curp]
FROM Alumnos;


SELECT
id, 
nombre, 
primerApellido, 
segundoApellido, 
fechaNacimiento,GETDATE() as Hoy, 
DATEDIFF(MONTH,fechaNacimiento,GETDATE())/12 AS Edad,
DATEDIFF(MONTH, fechaNacimiento, DATEADD(MONTH, 5, GETDATE()))/12 AS Edad5Meses,
CONVERT(DATE, SUBSTRING(curp, 5, 6)) as [Fecha curp],
IIF(SUBSTRING(curp, 11,1)= 'H','hombre','Mujer') AS Sexo
FROM Alumnos;
SELECT
id, 
nombre, 
primerApellido, 
segundoApellido, 
fechaNacimiento,
correo,
REPLACE(correo, 'gmail', 'hotmail') as correoHot
FROM Alumnos;