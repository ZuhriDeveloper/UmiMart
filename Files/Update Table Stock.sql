

INSERT INTO StockIns 
SELECT 
p.ProductId,'Migrate',0,m.Stock,p.SellPrice,GETDATE()
FROM MigrateStock m
INNER JOIN Products p ON m.PLU = p.Code
WHERE m.Stock > 0
AND p.SellPrice > 0

INSERT INTO StockOuts 
SELECT 
p.ProductId,'Migrate',0,m.Stock*-1,p.SellPrice,GETDATE()
FROM MigrateStock m
INNER JOIN Products p ON m.PLU = p.Code
WHERE m.Stock < 0
AND p.SellPrice > 0


