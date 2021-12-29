CREATE VIEW [dbo].[PersonHasAccount]
	AS
	select p.person_name,p.person_dob,a.acc_name,a.acc_balance,a.acc_type
	from Person p, Account a where p.acc_ID = a.acc_Id;
