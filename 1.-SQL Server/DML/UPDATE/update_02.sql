SELECT *
INTO Ejercicios.dbo.AlumnosTodos
FROM Alumnos;



/*d. Actualizar el teléfono de la tabla AlumnosTodos obtenidos desde la taba AlumnosHgo*/


update AlumnosTodos set telefono=(select telefono from AlumnosHgo where AlumnosHgo.id=AlumnosTodos.id)
where AlumnosTodos.idEstadoOrigen=12