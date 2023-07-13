SELECT p.Name, c.Name FROM Product as p 
LEFT JOIN Product_Category AS pc ON p.ID = pc.ID_Product 
	LEFT JOIN Category as c on pc.ID_Category = c.Id




create table Product (
  ID INT NOT NULL IDENTITY PRIMARY KEY,
  Name varchar(255)
);

insert into Product (Name)
values ('sdf'),
  ('sdfsdf'),
  ('sdfsdf');


create table Product_Category (
  ID_Product int not null,
  ID_Category int not null
);

insert into Product_Category (ID_Product,ID_Category)
values (1,1),
  (2,2);


create table Category (
  ID INT NOT NULL IDENTITY PRIMARY KEY,
  Name varchar(255)
);

insert into Category (Name)
values ('asd'),
  ('asdasda');

