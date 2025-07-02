UPDATE InventoryTable
SET icon = (SELECT * FROM OPENROWSET(BULK N'C:\Users\Lincoln\Downloads\Scouts-Australia-Logo.jpg', SINGLE_BLOB) AS ImageData)
WHERE itemName = '3x6 Canvas Tent';


