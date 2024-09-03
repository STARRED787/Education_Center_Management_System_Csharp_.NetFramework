CREATE TABLE [dbo].[TeacherInfoTbl]
(
	[Teacher_Id] INT NOT NULL PRIMARY KEY, 
    [Teacher_Name] VARCHAR(250) NOT NULL, 
    [Dob] VARCHAR(250) NOT NULL, 
    [Gender] VARCHAR(250) NOT NULL, 
    [Phone_Num] VARCHAR(250) NOT NULL, 
    [Email] VARCHAR(250) NOT NULL, 
    [Subject] VARCHAR(250) NOT NULL, 
    [Subject_Section] VARCHAR(250) NOT NULL
)
