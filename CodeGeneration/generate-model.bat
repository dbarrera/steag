set connectionstring="Data Source=.\ALPHA;Initial Catalog=G.Demo;Integrated Security=True"
set namespace="Steag.Framework.Model"
sqlmetal /conn:%connectionstring% /code:output\Models.cs /map:output\Schema.xml /namespace:%namespace%
pause