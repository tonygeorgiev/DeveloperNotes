IF NOT EXISTS (
  SELECT
    *
  FROM
    INFORMATION_SCHEMA.COLUMNS
  WHERE
    TABLE_NAME = 'table_name' AND COLUMN_NAME = 'col_name')
BEGIN
  ALTER TABLE table_name
    ADD col_name data_type NULL
END;