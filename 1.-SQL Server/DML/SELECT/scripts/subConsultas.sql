select nombre FROM Alumnos where len([nombre]) =  (select max(len([nombre])) FROM alumnos);
/*SELECT nombre FROM Alumnos WHERE len([nombre]) = Count(max(len([nombre])))*/

SELECT nombre,
DATEDIFF(YEAR,fechaNacimiento,
GETDATE()) as edad 
from Alumnos 
where DATEDIFF(YEAR,fechaNacimiento,GETDATE())>= All(select DATEDIFF(YEAR,fechaNacimiento,GETDATE()) FROM alumnos);


SELECT A.nombre, 
A.primerApellido, 
A.segundoApellido,
CC.nombre,
C.fechaInicio, 
C.fechatermino, 
CA.calificacion
FROM   CursoAlumnos CA
INNER JOIN Alumnos A  ON A.id = CA.idAlumno 
INNER JOIN Cursos C ON  CA.idcurso = C.id
INNER JOIN CatCursos CC ON C.idCatCurso = CC.id 
where CA.calificacion = (select Max(calificacion) FROM CursoAlumnos);

/*onsulta escalar */
SELECT
    CC.nombre,
    C.fechaInicio,
    C.fechatermino,
	(SELECT COUNT(*) FROM CursoAlumnos WHERE idcurso = C.id) as Total,
    (SELECT MAX(calificacion) FROM CursoAlumnos WHERE idcurso = C.id) as CalMax,/*consulta escalar*/
    (SELECT MIN(calificacion) FROM CursoAlumnos WHERE idcurso = C.id) as CalMin,
    (SELECT AVG(calificacion) FROM CursoAlumnos WHERE idcurso = C.id) as CalProm
FROM Cursos C INNER JOIN CatCursos CC ON C.idCatCurso = CC.id

SELECT A.nombre,CA.calificacion FROM Alumnos A
INNER JOIN CursoAlumnos CA on A.id = CA.idAlumno 
WHERE CA.calificacion <= (select AVG(calificacion) from CursoAlumnos);


SELECT
Alumnos.nombre, 
Alumnos.primerApellido, 
Alumnos.segundoApellido, 
Alumnos.fechaNacimiento,
CatCursos.nombre as Curso,
Cursos.fechaInicio, 
Cursos.fechatermino, 
CursoAlumnos.calificacion,
(SELECT id FROM CatCursos WHERE id = Cursos.idCatCurso) as Curso,
Cursos.idCatCurso
FROM CursoAlumnos 
INNER JOIN Alumnos ON CursoAlumnos.idAlumno = Alumnos.id
INNER JOIN Cursos ON CursoAlumnos.idcurso = Cursos.id 
INNER JOIN CatCursos ON Cursos.idCatCurso= CatCursos.id
WHERE CursoAlumnos.calificacion = (SELECT MAX(calificacion) FROM CursoAlumnos WHERE idcurso = Cursos.id)
