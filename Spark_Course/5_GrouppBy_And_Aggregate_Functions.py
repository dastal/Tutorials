from pyspark.sql import SparkSession

spark = SparkSession.builder.appName('Aggregate').getOrCreate()
df_pyspark = spark.read.csv('data/test5.csv', header=True, inferSchema=True)
df_pyspark.show()
df_pyspark.printSchema()

# GroupBy Operations (mean average salary)
# Group by Name and show the summed up salary
df_pyspark.groupby('Name').sum().show()

# Group by Department to find the summed up salary
df_pyspark.groupby('Department').sum().show()

# Group by Department to find the maximum salary
df_pyspark.groupby('Name').max().show()

# Group by Department to find the minimum salary
df_pyspark.groupby('Name').min().show()

# Group by Department to find the average salary (=mean)
df_pyspark.groupby('Name').avg().show()

# Group by Department to find the mean salary
df_pyspark.groupby('Department').mean().show()

# Group by Department to find the number of Employees
df_pyspark.groupby('Department').count().show()

# Aggregate Functions
df_pyspark.agg({'Salary': 'sum'}).show()
