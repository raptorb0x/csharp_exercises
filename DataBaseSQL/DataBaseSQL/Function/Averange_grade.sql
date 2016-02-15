CREATE FUNCTION [dbo].[F_Averange_grade]
(
	@Student_id int  --входные данне
)
RETURNS Float  -- тип выходных данных
AS
BEGIN
	declare @temp  float; -- объявляем переменную
	Select @temp = 1.0 * Sum(m.Mark) / COUNT(m.Mark)  --вычисляем её, преобразуя int в float
	from Exam_Marks m
	Where m.Student_id = @Student_id;
	RETURN  round(@temp,2) --округляем до 2х знаков после запятой  и выводим
END
