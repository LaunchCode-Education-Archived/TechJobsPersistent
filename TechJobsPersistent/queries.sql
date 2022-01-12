--Part 1
CREATE TABLE Jobs (
	Id INTEGER PRIMARY KEY AUTO_INCREMENT,
	Name VARCHAR(50),
	EmployerId INTEGER
	FOREIGN KEY(EmployerId) REFERENCES Employer(Id)
	);

--Part 2
SELECT Name
FROM employers
WHERE location = "St. Louis";

--Part 3
SELECT Name, Description
FROM skills
INNER JOIN jobskills ON skills.Id = jobskill.skillsId;

