
USE [DataBaseSQL]
GO

DECLARE	@return_value float
Declare @in_value int = 5


EXEC	@return_value = [dbo].[F_Averange_grade] 
		@Student_id = @in_value

SELECT	@return_value as 'Return Value'

Select m.Student_id,  Sum(m.Mark) As 'Summ' , COUNT(m.Mark) as 'Count' From dbo.Exam_marks m where Student_id = @in_value Group by m.Student_id;
GO

