SELECT 
   nombre,
   fechaNacimiento,
   DATEDIFF(YEAR, fechaNacimiento, GETDATE()) AS edad_actual_meses,
   DATEDIFF(YEAR, DATEADD(MONTH, -5, fechaNacimiento), GETDATE()) AS edad_en_5_meses
FROM alumnos;
