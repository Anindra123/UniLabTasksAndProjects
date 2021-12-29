CREATE PROCEDURE [dbo].[GetAccountNameAndBalance]

AS
	select acc_name,acc_balance 
	from Account;
RETURN 0
