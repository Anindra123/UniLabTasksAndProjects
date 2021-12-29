CREATE TABLE [dbo].[Person]
(
	[person_Id] INT NOT NULL PRIMARY KEY, 
    [person_name] NVARCHAR(50) NOT NULL,
	[person_dob] NVARCHAR(50) NOT NULL, 
    [acc_ID] INT NOT NULL, 
    CONSTRAINT [FK_Person_Account] FOREIGN KEY ([acc_ID]) REFERENCES [Account]([acc_Id])
)
