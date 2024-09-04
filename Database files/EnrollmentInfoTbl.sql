CREATE TABLE [dbo].[EnrollmentInfoTbl]
(
	[Enroll_Id] INT NOT NULL PRIMARY KEY, 
    [Student_Id] INT NOT NULL, 
    [Student_Name] VARCHAR(150) NOT NULL, 
    [Doe] DATETIME NOT NULL
)
