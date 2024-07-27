SELECT

CAST(  
    CEILING(
     AVG(CAST(SALARY AS FLOAT)) 
        -
     AVG( CAST(REPLACE(SALARY, 0, '') AS FLOAT) )    
    )
AS INT)

FROM employees;