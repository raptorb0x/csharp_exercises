CREATE TABLE dbo.Subj_Lect
(
	Lecturer_id INT NOT NULL PRIMARY KEY, 
    Subj_id INT NOT NULL
	CONSTRAINT Lect_for_key FOREIGN KEY (Lecturer_id) REFERENCES dbo.Lecturer (Lecturer_id)
	CONSTRAINT Subj_for_key FOREIGN KEY (Subj_id) REFERENCES dbo.Subject (Subj_id)
)
