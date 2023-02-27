DELETE FROM CursoAlumnos;
DBCC CHECKIDENT (CursoAlumnos, RESEED, 0);
DBCC CHECKIDENT ('nombre_de_la_tabla', NORESEED);
