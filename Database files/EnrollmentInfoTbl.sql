CREATE TABLE [dbo].[EnrollmentInfoTbl] (
    [Enroll_Id]    INT           NOT NULL,
    [Student_Id]   INT           NOT NULL,
    [Student_Name] VARCHAR (150) NOT NULL,
    [Doe]          DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Enroll_Id] ASC)
);

