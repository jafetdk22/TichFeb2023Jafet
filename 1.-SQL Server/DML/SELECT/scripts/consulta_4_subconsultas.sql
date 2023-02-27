select
CC.nombre,
C.fechaInicio,
C.fechatermino,
count(*) as Total,
Max(CA.calificacion) as CalMax,
min(CA.calificacion) as CalMin,
avg(CA.calificacion) as CalProm
from CursoAlumnos CA 
INNER JOIN Cursos C on CA.idcurso = C.id 
INNER JOIN CatCursos CC ON C.idCatCurso = CC.id
GROUP BY C.id,CA.idcurso,C.idCatCurso,CC.nombre,C.fechaInicio,
C.fechatermino

SELECT
    CC.nombre,
    C.fechaInicio,
    C.fechatermino,
	(SELECT COUNT(*) FROM CursoAlumnos WHERE idcurso = C.id) as Total,
    (SELECT MAX(calificacion) FROM CursoAlumnos WHERE idcurso = C.id) as CalMax,
    (SELECT MIN(calificacion) FROM CursoAlumnos WHERE idcurso = C.id) as CalMin,
    (SELECT AVG(calificacion) FROM CursoAlumnos WHERE idcurso = C.id) as CalProm
FROM Cursos C INNER JOIN CatCursos CC ON C.idCatCurso = CC.id