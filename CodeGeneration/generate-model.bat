set connectionstring="Data Source=.\SQLEXPRESS;Initial Catalog=Steag.Security.DEVELOPMENT;Integrated Security=True;Pooling=False"
set namespace="Steag.Framework.Model"
sqlmetal /conn:%connectionstring% /code:output\Models.cs /map:output\Schema.xml /namespace:%namespace%
pause