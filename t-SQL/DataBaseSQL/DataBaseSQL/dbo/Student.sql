CREATE TABLE dbo.Student
(
	Student_Id INT NOT NULL PRIMARY KEY, 
    Surname NVARCHAR(50) NULL, 
    Name NVARCHAR(50) NULL, 
   Stipend MONEY NULL, 
    Kurs INT NULL, 
   City NVARCHAR(50) NULL, 
    Birthday DATE NULL, 
    Univ_id INT NULL, 
    CONSTRAINT Univ_for_key FOREIGN KEY (Univ_id) REFERENCES dbo.University (Univ_id)
)
