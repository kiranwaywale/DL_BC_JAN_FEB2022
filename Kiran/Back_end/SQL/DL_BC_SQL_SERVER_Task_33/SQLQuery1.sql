--CREATE DATABASE
create database DLithe
use DLithe
create table trainees
(
ID int NOT NULL,
Name varchar(25) NOT NULL
);
--INSERT RECORDS INTO THE TABLE
insert into trainees values(1, 'KIRAN');
--SELECT
select * from trainees;
drop table trainees
select id from trainees;
--ALTER
alter table trainees add DepartmentName varchar(25);
--UPDATE
update trainees set DepartmentName='ECE' where id=1;
select * from trainees;
--INSERT MULTIPLE RECORDS
insert into trainees values(2, 'Rahul', 'IT');
insert into trainees values(3, 'Charan', 'IT');
insert into trainees values(4, 'Payal', 'CSE');
insert into trainees values(5, 'Deepak', 'CSE');
insert into trainees values(6, 'Venkatesh', 'CSE');
--SELECT (CONDITION-wherE clause)
select * from trainees where DepartmentName='IT';
select * from trainees where id>2 and id<6;
select * from trainees where Name like 'K%';
select * from trainees where Name like '_a%'


--CREATE SCHEMA
create schema TE;

--CREATE TABLE Inside the Schema TE
create table TE.MarchTrainees
(
ID int NOT NULL,
Name varchar(25),
Mobile nvarchar(10),
department varchar(25)
);

--DROP SCHEMA
drop schema if exists TE;
--Msg 3729, Level 16, State 1, Line 45
--Cannot drop schema 'TE' because it is being referenced by object 'MarchTrainees'.

--DROP TABLE MRACHTRAINEES
drop table TE.MarchTrainees;

--DELETE TABLE 
delete from trainees where DepartmentName='CSE';

select * from trainees;

--TRUNCATE will delete all the data without afeecting to structure of table
Truncate table trainees
