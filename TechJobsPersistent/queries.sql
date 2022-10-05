--Part 1

-- Employers: (int) id, (text) Name, (text) Location
-- Jobs: (int) Id, (text) Name, (int) EmployerId
-- JobSkills: (int) JobId, (int) SkillId
-- Skills: (int) Id, (text) Name, (text) Description

--Part 2

--SELECT Name FROM Employers WHERE Location = "St. Louis City";

--Part 3

-- SELECT * FROM Skills
   --   LEFT JOIN JobSkills ON Skill.Id = JobSkills.SkillId
   --   WHERE JobSkills.JobId IS NOT NULL
   --   ORDER BY name ASC;
