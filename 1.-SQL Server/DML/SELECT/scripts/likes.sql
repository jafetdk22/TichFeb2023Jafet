select * from Alumnos where primerApellido='Mendoza' or segundoApellido='Mendoza';
SELECT Alumnos.id,
Alumnos.nombre,
Alumnos.primerApellido,
Alumnos.segundoApellido,
Alumnos.correo,
Alumnos.telefono,
Alumnos.fechaNacimiento,
Alumnos.curp, 
Alumnos.sueldo, 
Alumnos.idEstadoOrigen,
Alumnos.idEstatus
FROM Alumnos 
INNER JOIN EstatusAlumnos ON Alumnos.idEstatus = EstatusAlumnos.id
where EstatusAlumnos.Nombre ='En Capacitación';

select * from Instructores where DATEDIFF(YEAR,fechaNacimiento,GETDATE())>= 30;
SELECT * FROM Alumnos where  DATEDIFF(YEAR,fechaNacimiento,GETDATE()) between 20 AND 25;

SELECT Alumnos.id,
Alumnos.nombre,
Alumnos.primerApellido, 
Alumnos.segundoApellido,
Alumnos.correo,
Alumnos.telefono,
Alumnos.fechaNacimiento,
Alumnos.curp,
Alumnos.sueldo, 
Alumnos.idEstadoOrigen,
Alumnos.idEstatus
FROM Alumnos 
INNER JOIN Estados ON Alumnos.idEstadoOrigen = Estados.id AND Alumnos.idEstadoOrigen = Estados.id AND Alumnos.idEstadoOrigen = Estados.id 
INNER JOIN EstatusAlumnos ON Alumnos.idEstatus = EstatusAlumnos.id
where Estados.nombre='Oaxaca' and EstatusAlumnos.Nombre='En Capacitaci_n' or Estados.nombre='Campeche' and EstatusAlumnos.Nombre='Prospecto';


SELECT 
*
FROM Alumnos
WHERE (correo LIKE '%gmail%');

Select * from Alumnos where DATEPART(Month,fechaNacimiento) = 03;

Select *from Alumnos where DATEDIFF(YEAR,fechaNacimiento,DATEADD(YEAR,5,GETDATE())) = 30;

Select *from Alumnos where LEN(nombre)>10;

select * from Alumnos where curp like '%[0-9]';

SELECT Alumnos.id, Alumnos.nombre, Alumnos.primerApellido, Alumnos.segundoApellido, Alumnos.correo, Alumnos.telefono, Alumnos.fechaNacimiento, Alumnos.curp, Alumnos.sueldo, Alumnos.idEstadoOrigen, 
Alumnos.idEstatus
FROM Alumnos INNER JOIN CursoAlumnos ON Alumnos.id = CursoAlumnos.idAlumno
where CursoAlumnos.calificacion > 8;

SELECT Alumnos.nombre, Alumnos.sueldo, EstatusAlumnos.Nombre AS Estatus
FROM Alumnos INNER JOIN EstatusAlumnos ON Alumnos.idEstatus = EstatusAlumnos.id
where Alumnos.sueldo >15000 and EstatusAlumnos.Nombre='liberado' or EstatusAlumnos.Nombre='laborando';

Select * from Alumnos where DATEPART(year,fechaNacimiento) between 1990 and 1995 and primerApellido like '[BCZ]%';

Select Alumnos.nombre, Alumnos.curp,fechaNacimiento
from Alumnos where fechaNacimiento != CONVERT(DATE,SUBSTRING(curp,5,6));

Select *,DATEDIFF(YEAR,fechaNacimiento,GETDATE()) from Alumnos where DATEPART(MONTH,fechaNacimiento)=04 and primerApellido 
like '[A]%' and DATEDIFF(YEAR,fechaNacimiento,GETDATE())between 21 and 30 ;

select * from Alumnos where nombre like '%Luis%';



SELECT Cursos.id, CatCursos.nombre, Cursos.fechaInicio, Cursos.fechatermino,
count(*) as [cantidad de alumnos],
AVG(CursoAlumnos.calificacion)as [Promedio de calificaciones]
FROM Cursos 
INNER JOIN CatCursos ON Cursos.idCatCurso = CatCursos.id AND Cursos.idCatCurso = CatCursos.id 
INNER JOIN CursoAlumnos ON Cursos.id = CursoAlumnos.idcurso
where Cursos.fechaInicio like '2023%'
Group by  Cursos.id,CatCursos.nombre, Cursos.fechaInicio, Cursos.fechatermino;


SELECT 
Estados.nombre,
count(*) as[Total],
AVG(CursoAlumnos.calificacion) as [Pormedio Calificaciones],
AVG(sueldo) as [Promedio Sueldo]
FROM CursoAlumnos 
INNER JOIN Alumnos ON CursoAlumnos.idAlumno = Alumnos.id 
INNER JOIN Estados ON Alumnos.idEstadoOrigen = Estados.id 
group by Estados.nombre HAVING COUNT(calificacion)>1 and AVG(calificacion)>6;
