SELECT CAST( ROUND(MAX(LAT_N), 4, 1) AS DECIMAL (10, 4) )
FROM STATION
WHERE LAT_N < 137.2345;