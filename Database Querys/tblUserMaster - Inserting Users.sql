SELECT * FROM tblUserMaster WITH(NOLOCK)




SELECT * FROM tblUserMaster WITH(NOLOCK) WHERE UserName = 'Shrikant' AND Password = 'Shrikant' AND IsActive=1

--INSERT INTO tblUserMaster VALUES('SuperAdmin','Mohan','mohan',1,'Shrikant',GETDATE(),NULL)
--INSERT INTO tblUserMaster VALUES('Admin','Shrikant','s',1,'Shrikant',GETDATE(),NULL)
--INSERT INTO tblUserMaster VALUES('Admin','a','a',1,'Shrikant',GETDATE(),NULL)
--INSERT INTO tblUserMaster VALUES('Biller','Akshay','Akshay',1,'Shrikant',GETDATE(),NULL)
--INSERT INTO tblUserMaster VALUES('Biller','Rahul','Rahul',1,'Shrikant',GETDATE(),NULL)