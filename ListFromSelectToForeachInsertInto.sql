DECLARE @Cols Table(idx int identity(1, 1), colName nvarchar(128))

INSERT INTO @Cols(colName)
SELECT [column_name]
FROM [zones_ftz214].[form_configuration]
WHERE [column_name] NOT IN
(SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS
 WHERE TABLE_CATALOG = 'filing_portal_dev'
 AND TABLE_SCHEMA LIKE '%zones_ftz214%'
 AND TABLE_NAME LIKE '%declaration%')
 
 DECLARE @INDEX INT
 DECLARE @COUNT INT
 DECLARE @NAMEOFCOLUMN NVARCHAR(128)

 SELECT @INDEX = MIN(idx) - 1, @COUNT = MAX(idx) from @Cols
 WHILE @INDEX < @COUNT
	BEGIN
		SELECT @INDEX = @INDEX + 1
		SET @NAMEOFCOLUMN = SELECT colName from @Cols where idx = @index
		INSERT INTO[zones_ftz214].[form_configuration]
		()
		VALUES
		()
	END