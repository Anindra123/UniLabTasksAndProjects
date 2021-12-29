CREATE TABLE [dbo].[Account]
(
	[acc_Id] INT NOT NULL PRIMARY KEY,
	[acc_name] NVARCHAR(50) NOT NULL, 
    [acc_balance] DECIMAL NOT NULL, 
    [acc_type] NVARCHAR(10) NULL,

)
