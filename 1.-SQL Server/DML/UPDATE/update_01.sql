/* 1.Actualizar el estatus del Alumnos de los que están en propedéutico a capacitación*/
UPDATE EstatusAlumnos SET nombre ='capacitaci_n' FROM EstatusAlumnos where nombre ='En curso propedéutico'

/*2.Actualizar el segundo apellido del Alumno a Mayúsculas
*/
UPDATE A SET A.segundoApellido = upper(A.segundoApellido)
from Alumnos A
/*3.Actualizar el segundo Apellido para que la primera letra sea mayúsculas y el resto
minúsculas*/
update A SET A.segundoApellido = (STUFF(LOWER(segundoApellido), 1,1 , UPPER(LEFT(segundoApellido,1)))) 
FROM Alumnos A;
/*Actualizar el número telefónico de los instructores para que los dos primeros
dígitos sean 55, en caso de que de acuerdo al curp sean del DF 12,13*/ 

UPDATE I SET I.telefono = STUFF(I.telefono,1, 2, '55') 
from Instructores I WHERE SUBSTRING(curp, 12, 2) = 'DF';

/*Subirles un punto en la calificación a los alumnos de Hidalgo y Oaxaca, y del Curso impartido 
en junio de 2021. Se deberá considerar que al incrementar el punto no exceda del máximo de la 
calificación permitida.*/

UPDATE CursoAlumnos SET calificacion = calificacion+1
from Alumnos
join CursoAlumnos on CursoAlumnos.idAlumno=Alumnos.id
join Estados on Estados.id=Alumnos.idEstadoOrigen
join Cursos on Cursos.id=CursoAlumnos.idCurso
where Estados.nombre='Hidalgo' or Estados.nombre='Oaxaca' and fechaInicio like '2021-06%' 
and calificacion between 0 and 9

/*6. Subirle el 10% de la cuota por hora a los profesores que han impartido el curso de Java
select Instructores.nombre, CatCursos.nombre, Instructores.cuotaHora*/

UPDATE Instructores SET cuotaHora = cuotaHora+(cuotaHora*.10)
from Instructores
join CursosInstructores on CursosInstructores.idInstructor=Instructores.id
join Cursos on CursosInstructores.idCurso=Cursos.id
join CatCursos on CatCursos.id=Cursos.idCatCurso
where CatCursos.nombre='Inteligencia Artificial'

/*Copiar a los alumnos de Hidalgo de la Tabla de Alumnos de la Base de Datos InstitutoTich a la Tabla AlumnosHgo
Use InstitutoTich*/
SELECT *
INTO Ejercicios.dbo.AlumnosHgo
FROM Alumnos
where idEstadoOrigen=12;
UPDATE AlumnosHgo SET telefono = (STUFF(telefono, 1,2, '77'))