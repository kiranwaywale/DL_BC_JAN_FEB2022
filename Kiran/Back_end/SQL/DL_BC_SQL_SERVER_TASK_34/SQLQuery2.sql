use DLithe;
--=====================================
CREATE FUNCTION TE(@a INT)
returns INT
AS
BEGIN
return @a+@a
END
 --===============================
SELECT dbo.TE(10) as 'Result'

--=======================================
--CREATE  TABLE
CREATE TABLE EMPD
(
ID INT,
NAME VARCHAR(25),
DOB DATE
);

--========================================
--CRETATE FUNCTION FOR THE DOB COLUMN IN EMP
create function calcage(@dob date)
Returns int
as
begin
	declare @age int
	set @age=DATEDIFF(year,@dob,getdate())
	return @age
end
--============================================
select dbo.calcage('12/12/02') as Age;

--====================================
SELECT ID,NAME,DOB,dbo.calcage(DOB) AS AGE FROM EMPD;
SELECT * FROM DLITHE_TRAINEES
---==============================================
CREATE FUNCTION DLITHE_TRAINEES_FUN(@DIT VARCHAR(25))
RETURNS TABLE
AS
RETURN(SELECT * FROM DLITHE_TRAINEES WHERE TDEPT=@DIT)

--=======================================
SELECT * FROM DLITHE_TRAINEES_FUN('DITDOTNET')


----===============================================
--==MULTI STATEMENT 
CREATE FUNCTION MULTI_STMT()
RETURNS @TABLE TABLE(ID INT, NAME VARCHAR(25), DEPARTMENT VARCHAR(25))
AS
BEGIN
INSERT INTO @TABLE
SELECT TID,TNAME,TDEPT FROM DLITHE_TRAINEES WHERE TADDRESS='BANGALORE';
RETURN
END
--================================
SELECT * FROM MULTI_STMT()
