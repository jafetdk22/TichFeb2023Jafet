INSERT INTO [dbo].[CatCursos]
           ([clave]
           ,[nombre]
           ,[descripcion]
           ,[horas]
           ,[idPreRequisito]
           ,[Activo])
     VALUES
           ('CL0001',
           'Negocios',
           'es un programa de ense�anza que se centra en la administraci�n y la gesti�n de empresas y organizaciones',
           20,
           null,
           1)
INSERT INTO [dbo].[CatCursos]
           ([clave]
           ,[nombre]
           ,[descripcion]
           ,[horas]
           ,[idPreRequisito]
           ,[Activo])
     VALUES
           ('CL0002',
           'Marketing',
           'El objetivo del curso es ayudar a los estudiantes a comprender c�mo investigar, identificar y satisfacer las necesidades del mercado, as� como c�mo promocionar y vender productos o servicios de manera efectiva.',
           10,
           null,
           1)
INSERT INTO [dbo].[CatCursos]
           ([clave]
           ,[nombre]
           ,[descripcion]
           ,[horas]
           ,[idPreRequisito]
           ,[Activo])
     VALUES
           ('CL0003',
           'Machine Learning',
           'En este curso, los estudiantes aprender�n acerca de los conceptos fundamentales del aprendizaje autom�tico, incluyendo la regresi�n lineal, las redes neuronales, el aprendizaje supervisado y no supervisado, y la evaluaci�n y optimizaci�n de los modelos. Tambi�n se explorar�n herramientas y t�cnicas de programaci�n, como Python y TensorFlow, para implementar modelos de aprendizaje autom�tico.',
           30,
           null,
           1)
INSERT INTO [dbo].[CatCursos]
           ([clave]
           ,[nombre]
           ,[descripcion]
           ,[horas]
           ,[idPreRequisito]
           ,[Activo])
     VALUES
           ('CL0004',
           'Deep Learning',
		   'Durante el curso, los participantes aprender�n sobre la teor�a subyacente detr�s de los modelos de redes neuronales artificiales, incluyendo c�mo funcionan, c�mo se entrenan y c�mo se utilizan para realizar tareas complejas como el reconocimiento de im�genes, la generaci�n de texto y el procesamiento del lenguaje natural.',
           35,
           null,
           1);
INSERT INTO [dbo].[CatCursos]
           ([clave]
           ,[nombre]
           ,[descripcion]
           ,[horas]
           ,[idPreRequisito]
           ,[Activo])
     VALUES
           ('CL0005',
           'Inteligencia Artificial',
		   ' Este curso ofrece una comprensi�n profunda de los algoritmos y m�todos utilizados para hacer que las computadoras aprendan y tomen decisiones por s� mismas.',
           35,
           3,
           1)