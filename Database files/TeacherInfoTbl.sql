CREATE TABLE [dbo].[TeacherInfoTbl] (
    [Teacher_Id]      INT           NOT NULL,
    [Teacher_Name]    VARCHAR (250) NOT NULL,
    [Dob]             DATE          NOT NULL,
    [Gender]          VARCHAR (250) NOT NULL,
    [Phone_Num]       VARCHAR (250) NOT NULL,
    [Email]           VARCHAR (250) NOT NULL,
    [Subject]         VARCHAR (250) NOT NULL,
    [Subject_Section] VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Teacher_Id] ASC)
);

