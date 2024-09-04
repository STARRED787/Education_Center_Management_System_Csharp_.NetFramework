CREATE TABLE [dbo].[StudentInfoTbl] (
    [Student_Id]      INT           NOT NULL,
    [Student_Name]    VARCHAR (100) NOT NULL,
    [Dob]             DATE          NOT NULL,
    [Gender]          VARCHAR (10)  NOT NULL,
    [Phone_Num]       VARCHAR (10)  NOT NULL,
    [Email]           VARCHAR (50)  NOT NULL,
    [Subject]         VARCHAR (100) NOT NULL,
    [Subject_Section] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Student_Id] ASC)
);

