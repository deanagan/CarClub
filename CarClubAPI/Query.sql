
-- ctrl+shift+e to execute this query
--SELECT * FROM INFORMATION_SCHEMA.TABLES
--SELECT * FROM Vehicles
SELECT number, make, model FROM PlateNumbers
INNER JOIN Vehicles ON
PlateNumbers.VehicleId = Vehicles.Id


GO
