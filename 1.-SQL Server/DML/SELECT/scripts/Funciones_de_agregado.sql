SELECT E.nombre,count(*) AS 'Total Alumnos'  from Alumnos A INNER JOIN Estados E on A.idEstadoOrigen=E.id GROUP BY  E.nombre;
SELECT E.nombre,count(*) AS 'Total Alumnos'  from Alumnos A INNER JOIN EstatusAlumnos E on A.idEstatus=E.id GROUP BY  E.nombre;

SELECT [Resumen Calificaciones]='CAlificaciones Alumnos',
count(*) as Total,
Max(CA.calificacion) as Maxima,
MIN(CA.calificacion)as Minima,
AVG(CA.calificacion) as Promedio
from CursoAlumnos CA;

SELECT
CC.nombre as Curso, 
C.fechaInicio, 
C.fechatermino,
count(*) as Total,
Max(CA.calificacion) as Maxima,
MIN(CA.calificacion)as Minima,
AVG(CA.calificacion) as Promedio
from CursoAlumnos CA 
INNER JOIN Cursos C ON CA.idcurso = C.id 
INNER JOIN CatCursos CC ON C.idCatCurso = CC.id 
GROUP BY CC.nombre, C.fechaInicio, C.fechatermino;



SELECT E.nombre,
count(*) as Total,
Max(CA.calificacion) as Maxima,
MIN(CA.calificacion)as Minima,
AVG(CA.calificacion) as Promedio
FROM CursoAlumnos CA
INNER JOIN Alumnos  A ON CA.idAlumno = A.id 
INNER JOIN Estados  E ON A.idEstadoOrigen = E.id AND A.idEstadoOrigen = E.id AND A.idEstadoOrigen = E.id
GROUP BY E.nombre;

