/*Realiza la siguiente consulta de instructores para obtener nombre, Apellido Paterno,Apellido Materno
rfc,cuota por hora , estatus */
SELECT 
I.nombre,
I.primerApellido AS 'APELLIDO PATERNO',
I.segundoApellido AS 'APELLIDO MATERNO', 
I.rfc,I.cuotaHora AS 'CUOTA POR HORA',
CASE I.activo
	WHEN 1 THEN 'ACTIVO'
	WHEN 0 THEN 'INACTIVO'
	END
	AS 'ESTATUS'
FROM Instructores I

/*REALIZA LA SIGUIENTE CONSULTA EN LA TABLA CURSOS PARA OBTENER NOMBRE DE L CURSO,HORAS,FECHA DE INICIO, FECHA DE TERMINO*/

SELECT CC.nombre as Curso,CC.horas,C.fechaInicio,C.fechatermino FROM Cursos C INNER JOIN CatCursos CC ON C.idCatCurso =CC.id 

/*Realizar la siguiente consulta de alumnos
parta obtener  nombre, primerApellido, segundoApellido, curp, Estado, Estatus*/

SELECT A.nombre,A.primerApellido,A.segundoApellido,A.curp,E.nombre AS ESTADO,EA.nombre AS ESTATUS 
FROM Alumnos A INNER JOIN Estados E ON A.idEstadoOrigen = E.id INNER JOIN EstatusAlumnos EA ON A.idEstatus =EA.id 

/*Realizar la siguiente consulta de Instructores, en que cursos ha participado la consulta debera mostrar nombre del
instructor,cuota por hora, nombre curso, fecha de inicio, fecha de termino*/
SELECT Instructores.nombre, Instructores.cuotaHora, CatCursos.nombre AS Expr1, Cursos.fechaInicio, Cursos.fechatermino
FROM            Instructores INNER JOIN
                         CursosInstructores ON Instructores.id = CursosInstructores.idInstructor INNER JOIN
                         Cursos ON CursosInstructores.idcurso = Cursos.id AND CursosInstructores.idcurso = Cursos.id INNER JOIN
                         CatCursos ON Cursos.idCatCurso = CatCursos.id AND Cursos.idCatCurso = CatCursos.id

/*Realizar la siguiente consulta de Alumnos, mostrando los cursos ha tomado*/
SELECT Alumnos.nombre, CatCursos.nombre AS Curso
FROM    Alumnos INNER JOIN
                         CursoAlumnos ON Alumnos.id = CursoAlumnos.idAlumno AND Alumnos.id = CursoAlumnos.idAlumno INNER JOIN
                         Cursos ON CursoAlumnos.idCurso = Cursos.id AND CursoAlumnos.idCurso = Cursos.id INNER JOIN
                         CatCursos ON Cursos.idCatCurso = CatCursos.id AND Cursos.idCatCurso = CatCursos.id