Create database CMS;
Use CMS;

Create table Items
(
Itemid int identity,
Itemname varchar(30),
Itemrate float,

Constraint pk_Items primary key(Itemid)
);
sp_help Items


select * from Items;

Create table CustomerType
(
Customertypeid int identity,
Customertypename varchar(30),
Constraint pk_CustomerType primary key(Customertypeid)
);
sp_help CustomerType;
Select * from CustomerType;

Create table Customer
(
Ccode int identity,
Cfname varchar(30),
Clname varchar(30),
Caddress varchar(30),
Cgender char,
Username varchar(30),
Password varchar(20),
Customertypeid int,
Constraint pk_Customer primary key(Ccode),
Constraint fk_Customer_Customertypeid foreign key(Customertypeid) references CustomerType
);
sp_help Customer;

select * from Customer;

Create table Bill
(
Billno int identity,
Ccode int,
Total float,
Discount float,
Vat float,
Nettotal float,
Constraint pk_Bill primary key(Billno),
Constraint fk_Bill_Ccode foreign key(Ccode) references Customer
);
sp_help Bill;


Create table ItemBill
(
Billno int,
Itemid int,
Quantity int,
Ltotal float,
Constraint fk_ItemBill_Billno foreign key(Billno) REFERENCES Bill,
Constraint fk_ItemBill_Itemid foreign key(Itemid) REFERENCES Items
);
sp_help ItemBill;

