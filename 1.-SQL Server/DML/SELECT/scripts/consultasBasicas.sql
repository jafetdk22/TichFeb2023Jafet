/*1.- SELECCIONA APELLIDO PATERNO,APELLIDO MATERNO ,NOMBRE,TELEFONO Y CORREO DE LA TABLA ALUMNOS*/
SELECT primerApellido as 'Apellido Paterno',segundoApellido as 'Apellido Materno',nombre,telefono,correo FROM Alumnos
/*2.-SELECCIONA NOMBRE,APELLIDO PATERNO, APELLIDO MATERNO, FRC, CUOTA POR HORA*/
SELECT nombre,primerApellido as 'Apellido Paterno',segundoApellido as 'Apellido Materno', rfc,cuotaHora as 'Cuota por Hora'  FROM Instructores
/*3-. SELECCIONA CLAVE, NOMBRE, DESCRIPCION, HORAS DE LA TABLA CATCURSOS */
SELECT clave,nombre,descripcion,horas FROM CatCursos
/*4 realiza la consulta de los 5 alumnos mas jovenes*/
SELECT TOP(5) id, nombre,DATEDIFF(YEAR,fechaNacimiento,GETDATE()) as Edad  FROM Alumnos ORDER BY DATEDIFF(YEAR,fechaNacimiento,GETDATE()) DESC
/*5 Crear la base de datos 'Ejercicios'*/
CREATE DATABASE Ejercicios
/*copiar las tablas de Alumnos e Instructores desde la Base de datos InstitutoThich a la de Ejercicios*/
Use InstitutoTich 
SELECT * INTO Ejercicios.dbo.Alumnos from Alumnos
SELECT * INTO Ejercicios.dbo.Instructores from Instructores