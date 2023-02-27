alter table CatCursos add foreign key (idPrerequisito) references CatCursos(id)
alter table Cursos add foreign key (idCatCurso) references CatCursos(id)
alter table Alumnos add foreign key (idEstadoOrigen) references Estados(id)
alter table Alumnos add foreign key (idEstatus) references EstatusAlumnos(id)
alter table CursoAlumnos add foreign key (idCurso) references Cursos(id)
alter table CursoAlumnos add foreign key (idAlumno) references Alumnos(id)
alter table CursosInstructores add foreign key (idCurso) references Cursos(id)
alter table CursosInstructores add foreign key (idInstructor) references Instructores(id)


