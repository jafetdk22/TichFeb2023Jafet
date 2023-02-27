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
           'es un programa de enseñanza que se centra en la administración y la gestión de empresas y organizaciones',
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
           'El objetivo del curso es ayudar a los estudiantes a comprender cómo investigar, identificar y satisfacer las necesidades del mercado, así como cómo promocionar y vender productos o servicios de manera efectiva.',
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
           'En este curso, los estudiantes aprenderán acerca de los conceptos fundamentales del aprendizaje automático, incluyendo la regresión lineal, las redes neuronales, el aprendizaje supervisado y no supervisado, y la evaluación y optimización de los modelos. También se explorarán herramientas y técnicas de programación, como Python y TensorFlow, para implementar modelos de aprendizaje automático.',
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
		   'Durante el curso, los participantes aprenderán sobre la teoría subyacente detrás de los modelos de redes neuronales artificiales, incluyendo cómo funcionan, cómo se entrenan y cómo se utilizan para realizar tareas complejas como el reconocimiento de imágenes, la generación de texto y el procesamiento del lenguaje natural.',
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
		   ' Este curso ofrece una comprensión profunda de los algoritmos y métodos utilizados para hacer que las computadoras aprendan y tomen decisiones por sí mismas.',
           35,
           3,
           1)