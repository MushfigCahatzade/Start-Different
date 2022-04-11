CREATE DATABASE Department
Use Department 
CREATE TABLE Employee(
Id int Primary key identity,
Fullname varchar(255) Not Null, 
Age int Not Null CHECK(Age>0),
Email varchar(50) unique,
Salary float Not Null Check(salary>=300 AND salary<=2000)
)
Insert into Employee Values('Mushfig Ayvazov',20,'mushfig.ayvazov.m.a@gmail.com',350)
Insert into Employee Values('Orxan Yusifli',30,'orxanyusifli@gmail.com',430)
Insert into Employee Values('Nizam Cabbarli',23,'nizamcabbarli@gmail.com',1035)
Insert into Employee Values('Gunay Hacizade',20,'gunayhacizade@gmail.com',301)

Select*from Employee 

Update Employee Set Salary=700 where Id=1

Select*from Employee where (Salary>=500 AND Salary<=1500)

Select Fullname,Email,Salary from Employee Order by Salary Desc



