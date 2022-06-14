--SELECT EMPID, EMPNAME, EMPADDRESS, EMPCONTACT, EMPPOSITION,  USERNAME, PASSWRD, ACCSTATUS FROM tblemployee WHERE USERNAME ='admin'
SELECT * FROM tblUserMaster WITH(NOLOCK) WHERE UserName = 'rty' AND Password = 'hyr' AND IsActive=1

SELECT count(*) as Numresult,UserName FROM tblUserMaster WITH(NOLOCK) 
WHERE UserName = 'shrikant' AND Password = 'shrikant' AND IsActive=1
GROUP BY UserName

SELECT count(*) as Numresult,UserName,UserType FROM tblUserMaster WITH(NOLOCK) WHERE UserName = 'shrikant' AND Password = 'shrikant' AND IsActive=1 GROUP BY UserName,UserType