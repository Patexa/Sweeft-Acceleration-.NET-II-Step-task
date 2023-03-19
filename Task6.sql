CREATE TABLE Teacher (
id INT NOT NULL,
name VARCHAR(50),
surname VARCHAR(50),
gender VARCHAR(50),
subject VARCHAR(50),
PRIMARY KEY (id),
);

CREATE TABLE Pupil (
id INT NOT NULL,
name VARCHAR(50),
surname VARCHAR(50) ,
gender VARCHAR(50),
class VARCHAR(50),
PRIMARY KEY(id)
);

CREATE TABLE Relation (
id INT PRIMARY KEY,
pupil_id INT references Pupil(id),
teacher_id INT references Teacher(id),
);

INSERT INTO Teacher (id,name,surname,gender,subject)
VALUES (1,'Giorgi','Ghlonti','M','CS'),
	   (2,'Hakan','ergun','M','BM'),
	   (3,'Khatuna','Chargazia','F','CS'),
	   (4,'Alkan','Dunkan','M','IR');
INSERT INTO Pupil (id,name,surname,gender,class)
VALUES (1,'Paata','Mushtashvili','M','CS'),
	   (2,'Luka','Rakviashvili','M','CS'),
	   (3,'Lela','Korguani','F','IR'),
	   (4,'Beka','Pataraia','M','BM'),
	   (5,'Giorgi','Tchabukiani','M','CS'),
	   (6,'Giorgi','Brtskinvale','M','CS');
       
SELECT * FROM Teacher 
INNER JOIN Pupil
on Pupil.class=Teacher.subject and Pupil.name='Giorgi'