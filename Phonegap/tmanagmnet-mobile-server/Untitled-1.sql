-- Select rows from a Table or View 'TableOrViewName' in schema 'SchemaName'
SELECT * FROM projects;

SELECT * FROM sys.objects
WHERE type = 'PK' 
AND  object_id = OBJECT_ID ('actual_project_task')
