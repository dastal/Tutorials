from pyspark.sql import SparkSession

spark = SparkSession.builder.appName('dataFrame').getOrCreate()
df_pyspark = spark.read.csv('data/test4.csv', header=True, inferSchema=True)
df_pyspark.show()

# Filter Operations
# Salary of the people less or equal to 20000
df_pyspark.filter("Salary<=20000").show()
df_pyspark.filter(df_pyspark['Salary'] <= 20000).show()                 # Same output like former line
df_pyspark.filter("Salary<=20000").select(['Name', 'Age']).show()
df_pyspark.filter("Salary==20000").show()

# Multiple conditions using &
df_pyspark.filter((df_pyspark['Salary'] <= 20000) &
                  (df_pyspark['Salary'] >= 18000)).show()

# Multiple conditions using |
df_pyspark.filter((df_pyspark['Salary'] > 20000) |
                  (df_pyspark['Salary'] < 18000)).show()

# Multiple conditions using ~
df_pyspark.filter(~(df_pyspark['Salary'] <= 20000)).show()
