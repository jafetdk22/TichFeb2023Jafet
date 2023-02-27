	SELECT 'Alumno' as TipoPersona,nombre, primerApellido, segundoApellido,DATEPART(month,fechaNacimiento)as MesNacimnento,DATEPART(day,fechaNacimiento)as DiaNacimnento
	FROM Alumnos
	UNION ALL
	SELECT 'Profesor' as TipoPersona, nombre, primerApellido, segundoApellido,DATEPART(month,fechaNacimiento)as MesNacimnento,DATEPART(day,fechaNacimiento)as DiaNacimnento
	FROM Instructores
	ORDER BY TipoPersona






