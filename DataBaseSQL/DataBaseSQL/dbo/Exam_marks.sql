CREATE TABLE dbo.Exam_marks
(
	Exam_id INT NOT NULL PRIMARY KEY, 
    Student_id INT NOT NULL, 
    Subj_id INT NOT NULL, 
    Mark INT NULL, 
    Exam_date DATE NULL
	CONSTRAINT Student_for_key FOREIGN KEY (Student_id) REFERENCES dbo.Student (Student_id)
	CONSTRAINT Subject_for_key FOREIGN KEY (Subj_id) REFERENCES dbo.Subject (Subj_id)
)

GO

CREATE INDEX Student_id_1 ON dbo.Exam_marks (Student_id)
