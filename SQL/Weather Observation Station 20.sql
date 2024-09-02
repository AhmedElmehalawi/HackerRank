WITH OrderedValues AS (
    SELECT 
        LAT_N,
        ROW_NUMBER() OVER (ORDER BY LAT_N) AS RowAsc,
        ROW_NUMBER() OVER (ORDER BY LAT_N DESC) AS RowDesc
    FROM 
        STATION
)
SELECT 
    CAST(ROUND(AVG(LAT_N),4) AS DECIMAL(10,4)) 
FROM 
    OrderedValues
WHERE 
    RowAsc = RowDesc
   OR RowAsc + 1 = RowDesc;
