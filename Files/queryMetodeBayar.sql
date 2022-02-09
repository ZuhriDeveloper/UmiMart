use umdb
ALTER TABLE TblPenjualan
ADD Metode_Pembayaran NVARCHAR(50) DEFAULT 'TUNAI'

UPDATE TblPenjualan
SET Metode_Pembayaran = 'TUNAI'
WHERE Metode_Pembayaran IS NULL

UPDATE TblPenjualan
SET Diskon = 0
WHERE Diskon IS NULL

SELECT * FROM tblPenjualan
