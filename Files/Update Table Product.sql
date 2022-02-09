

UPDATE p
SET p.Hpp = m.HppExTax
,p.Ppn = 10
,p.SellPrice = m.HargaJual
,p.LastModifiedby = 'UpdateHarga'
,p.LastModified = GETDATE()
FROM Products p
INNER JOIN MigrateStock m ON P.Code = m.PLU

UPDATE p
SET p.Ppn = 0
FROM Products p
INNER JOIN MigrateStock m ON P.Code = m.PLU
WHERE m.Tax = 0

UPDATE Products
SET Margin = SellPrice - (Hpp + (Hpp * ppn/100))
WHERE LastModifiedby = 'UpdateHarga'

