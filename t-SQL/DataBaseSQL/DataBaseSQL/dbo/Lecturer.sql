CREATE TABLE dbo.Lecturer
(
	Lecturer_id INT NOT NULL PRIMARY KEY, 
    Surname NVARCHAR(50) NULL, 
    Name NVARCHAR(50) NULL, 
    City NVARCHAR(50) NULL, 
    Univ_id INT NULL
	constraint Univlect_for_key foreign key (Univ_id)
	references dbo.University (Univ_id)
)
