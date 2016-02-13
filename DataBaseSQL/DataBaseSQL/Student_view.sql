CREATE VIEW [dbo].[Student_view]
	AS 
	SELECT  s.Student_Id AS 'Номер студента',
			s.Name AS 'Имя',
		    s.Surname AS 'Фамилия',
			u.Univ_name as 'Институт'
	FROM Student as s
			join University as u on s.Univ_id = u.Univ_id
			
