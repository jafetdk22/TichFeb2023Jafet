SELECT nombre,primerApellido as 'Apellido Paterno', segundoApellido as 'Apellido Materno',rfc,cuotaHora,IIF(activo = 1, 'Activo', 'No Activo') as Estatus
FROM Instructores;


SELECT CC.nombre as Curso, CC.horas,C.fechaInicio as 'Fecha Inicio',  C.fechatermino as 'Fecha Termino'
FROM Cursos C INNER JOIN CatCursos CC
ON C.idCatCurso = CC.id AND C.idCatCurso = CC.id;


SELECT A.nombre, A.primerApellido, A.segundoApellido, A.curp, E.nombre AS Estado , EA.Nombre AS Estatus
FROM Alumnos A 
INNER JOIN Estados E
ON A.idEstadoOrigen = E.id AND A.idEstadoOrigen = E.id AND A.idEstadoOrigen = E.id 
INNER JOIN EstatusAlumnos EA 
ON A.idEstatus = EA.id;


SELECT  
Concat(I.nombre,' ',I.primerApellido,'',I.segundoApellido) AS Instructor,
I.cuotaHora, 
CC.nombre AS 'nombre', 
C.fechaInicio, 
C.fechatermino
FROM CatCursos CC
INNER JOIN Cursos C ON CC.id = C.idCatCurso AND CC.id = C.idCatCurso 
CROSS JOIN Instructores I;


SELECT A.nombre,
A.primerApellido, 
A.segundoApellido, 
E.nombre AS Estado, 
CC.nombre AS Curso,
CA.fechaInscripcion,
C.fechaInicio, 
C.fechatermino, 
CA.calificacion
FROM Alumnos A 
INNER JOIN CursoAlumnos CA ON A.id = CA.idAlumno 
INNER JOIN Cursos C ON CA.idcurso = C.id 
INNER JOIN Estados E ON A.idEstadoOrigen = E.id AND A.idEstadoOrigen = E.id AND A.idEstadoOrigen = E.id 
INNER JOIN CatCursos CC ON C.idCatCurso = CC.id AND C.idCatCurso = CC.id;

SELECT A.nombre,
A.primerApellido, 
A.segundoApellido, 
CC.nombre AS Curso,
C.fechaInicio, 
C.fechatermino, 
CA.calificacion
FROM Alumnos A 
INNER JOIN CursoAlumnos CA ON A.id = CA.idAlumno 
INNER JOIN Cursos C ON CA.idcurso = C.id 
INNER JOIN CatCursos CC ON C.idCatCurso = CC.id AND C.idCatCurso = CC.id
ORDER BY CA.calificacion Desc;

SELECT CC.clave, CC.nombre, CC.horas,CC.idPreRequisito,
IIF(CC.idPreRequisito != 0, CC.nombre,'no') as Prerequisito
FROM Cursos C LEFT JOIN CatCursos  CC ON C.idCatCurso = CC.id AND C.idCatCurso = CC.id;


SELECT 
A.nombre, 
A.primerApellido, 
A.segundoApellido, 
CC.nombre AS Nombre, 
C.fechaInicio, 
C.fechatermino, 
CA.calificacion,
	CASE
	WHEN CA.calificacion BETWEEN 9 AND 10 THEN 'Excelente'
	WHEN CA.calificacion BETWEEN 7 AND 8 THEN 'Bien'
	WHEN CA.calificacion = 6 THEN 'Suficiente'
	ELSE 'N/A'
	END AS Nivel
FROM Cursos C INNER JOIN CatCursos CC ON C.idCatCurso = CC.id AND C.idCatCurso = CC.id 
INNER JOIN CursoAlumnos CA ON C.id = CA.idcurso 
INNER JOIN Alumnos A ON CA.idAlumno = A.id;