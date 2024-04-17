Create Database University
Go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create table Student
(
 StudentId int IDENTITY(1,1) Not Null,
 FirstName varchar(50) Not null, 
 Surname varchar(50) Not Null,
 StudentNumber varchar(8) Not null,
 Age int,
 Gender varchar(10)
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



insert into Student(FirstName,Surname,StudentNumber,Age,Gender)
values
('Nondumiso','Sithole','74299833',21,'Female'),
('Jane','Doe','71299888',18, 'Female' )

Select *  from Student
