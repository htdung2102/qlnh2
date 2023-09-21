CREATE TABLE Customer 
(
ID INT PRIMARY KEY IDENTITY,
CustomerID AS 'KH' + LEFT(CONVERT(NVARCHAR(50), NEWID()), 6),
CustomerName VARCHAR(50), 
Phone VARCHAR(11),
Levels NVARCHAR(50),
Scores Float
)
delete from Customer where CustomerID = 'KH4C4717'
alter table BAN 
ADD TypeID INT 

CREATE TABLE TableType (
    TypeID INT PRIMARY KEY IDENTITY,
    TypeName NVARCHAR(50)
);

SELECT O.ID, O.OrderDate, O.OrderTime,o.payStatus, O.TableName,OD.productID,M.TENMON, M.GIA, OD.quantity, OD.quantity * M.GIA AS Amount, o.total
FROM tblorder O
        inner join OrderDetails OD ON O.ID = OD.orderID
        left join MONAN M ON M.IDNO = OD.productID

select * from Customer 
SELECT * FROM tblorder
SELECT * FROM OrderDetails

DELETE from Customer where ID = 6

DELETE FROM OrderDetails 
DELETE FROM tblorder

SELECT * FROM tblorder O inner join OrderDetails OD ON O.ID = OD.orderID
left join MONAN M ON M.IDNO = OD.productID

SELECT * FROM TableList TL INNER JOIN tblorder O ON TL.TableName = O.TableName 
UPDATE TableList SET TableStatus = NULL WHERE TableName= '102'
Select TableStatus from BAN Where TENBAN ='102'

alter table tblorder
ADD NoCustomer INT, DiscountID NVARCHAR(50)

SELECT OD.DetailID, OD.ProductID, M.TENMON, OD.Quantity, M.GIA, OD.quantity * M.GIA AS Amount, O.total
               FROM tblorder O
                inner join OrderDetails OD ON O.ID = OD.orderID
               INNER JOIN MONAN M ON OD.ProductID = M.IDNO 
               WHERE O.TableName = '104' AND O.payStatus = 'Pending'

CREATE TABLE [dbo].[TableList] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [TableName]      NVARCHAR (30) NULL,
    [ReserveDate] DATE          NULL,
    [CustomerID]  INT           NULL,
    [TableStatus] NVARCHAR (50) NULL,
    [TypeID] INT
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
select * from TableList TL INNER JOIN TableType TT ON TL.TypeID = TT.TypeID WHERE TT.TypeName = N'Tầng 1'

SELECT * FROM tblorder
delete from tblorder where TableName = 102

SELECT * FROM MONAN M INNER JOIN NHOMMONAN N ON M.MANHOM = N.MANHOM

CREATE TABLE Discount
(
ID INT PRIMARY KEY IDENTITY,
Code NVARCHAR(50),
Description NVARCHAR(50),
DiscountValue decimal (18, 2),
TypeID INT,
StartDate DATE,
EndDate DATE
)
CREATE TABLE DiscountType
(ID INT PRIMARY KEY IDENTITY,
TypeName NVARCHAR(50))

select * from Discount
delete  from Discount




CREATE TABLE PaymentMethod
(
ID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50),
IsActive BIT
)

INSERT INTO PaymentMethod VALUES('VNP', 1)
SELECT * FROM PaymentMethod 

SELECT sum(OD.quantity * M.GIA) as total 
FROM tblorder O
        inner join OrderDetails OD ON O.ID = OD.orderID
        left join MONAN M ON M.IDNO = OD.productID
WHERE o.TableName = '102' AND O.payStatus = 'Paid'

SELECT * FROM MONAN 

SELECT OD.DetailID, OD.ProductID, M.TENMON, M.DVT, OD.Quantity, M.GIA, OD.quantity * M.GIA AS Amount
                   FROM tblorder O
                   inner join OrderDetails OD ON O.ID = OD.orderID
                   INNER JOIN MONAN M ON OD.ProductID = M.IDNO

CREATE TABLE Reservation 
(
ID INT PRIMARY KEY IDENTITY,
CustomerName NVARCHAR(50),
Phone VARCHAR(11),
TableTName NVARCHAR(30),
NoPeople INT,
BookDate DATETIME
)
ALTER TABLE Reservation
ADD BookTime DATETIME 

select * from Customer

alter table tblorder 
add PaymethodID INT 

UPDATE C
SET
    Scores = CASE
        WHEN W.TotalSpent < 500000 THEN +5
        WHEN W.TotalSpent >= 500000 AND W.TotalSpent < 1000000 THEN +10
        WHEN W.TotalSpent >= 1000000 THEN +15
        ELSE 0 -- Trường hợp còn lại
    END,
    Levels = CASE
        WHEN W.PurchaseCount = 1 THEN 'Titan'
        WHEN W.PurchaseCount = 2 THEN 'Silver'
        WHEN W.PurchaseCount = 3 THEN 'Gold'
        WHEN W.PurchaseCount >= 4 THEN 'Platinum'
        ELSE NULL -- Trường hợp còn lại
    END
FROM Customer C
INNER JOIN (
    SELECT tb.CustomerID,COUNT(tb.ID) AS PurchaseCount, SUM(tb.total) AS TotalSpent
    FROM tblorder tb
    GROUP BY CustomerID
) W ON C.ID = W.CustomerID;

   ;WITH W AS (SELECT tb.CustomerID, COUNT(tb.ID) AS PurchaseCount, SUM(tb.total) AS TotalSpent
FROM tblorder tb inner join Customer C ON tb.CustomerID = c.ID
GROUP BY CustomerID)
SELECT C.ID, C.CustomerName, C.Phone, w.PurchaseCount, w.TotalSpent, c.Levels, c.Scores 
FROM W LEFT JOIN Customer C ON W.CustomerID = C.ID
SELECT * FROM tblorder
delete from tblorder where TableName = 104


     DECLARE @OrderTotal DECIMAL;
    SELECT @OrderTotal = total FROM tblorder WHERE ID = 2050;
    UPDATE C
    SET Scores = CASE
        WHEN @OrderTotal < 500000 THEN ISNULL(C.Scores, 0) + 10
        WHEN @OrderTotal >= 500000 AND O.total < 1000000 THEN ISNULL(C.Scores, 0) + 15
         WHEN @OrderTotal >= 1000000 THEN ISNULL(C.Scores, 0) + 25
        ELSE ISNULL(C.Scores, 0)
    END
    FROM Customer C
    INNER JOIN tblorder O ON C.ID = O.CustomerID
    WHERE O.ID = 2050;
    
CREATE TABLE [dbo].[Product] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [ProductID]   AS            ('D'+right('00000'+CONVERT([varchar],[ID]),(5))),
    [Name]  NVARCHAR (50) NULL,
    [Price]     FLOAT (53)    NULL,
    [Image] IMAGE         NULL,
    [TypeID]  INT           NULL,
    [Unit]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
CREATE TABLE [dbo].[ProductType] (
    [ID]  INT           IDENTITY (1, 1) NOT NULL,
    [TypeName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

select * from TableList TL INNER JOIN TableType TT ON TL.TypeID = TT.TypeID WHERE TT.TypeName = N'Tầng 1'  AND TL.TableStatus = NULL
select * from Product


select tb.OrderDate, tb.OrderTime, tb.TableName,c.CustomerName, c.Phone, p.Name, p.Unit, p.Price, od.quantity, tb.total, tb.DiscountTotal
from tblorder tb inner join OrderDetails od on tb.ID = od.orderID 
                    inner join Product p on od.productID = p.ID
                    inner join Customer c on c.ID =  tb.CustomerID where tb.TableName = 108 and tb.payStatus = 'Pending'
