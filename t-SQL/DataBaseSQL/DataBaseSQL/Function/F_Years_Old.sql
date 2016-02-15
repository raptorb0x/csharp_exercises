CREATE FUNCTION dbo.F_Years_Old
(

)
RETURNS TABLE AS RETURN
(
	SELECT Surname, Name, datediff(yy, Birthday, GETDATE()) As 'Years Old'  From  dbo.Student 
		
)
