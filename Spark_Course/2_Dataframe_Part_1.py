from pyspark.sql import SparkSession

# Build the Session
spark = SparkSession.builder.appName('DataFrame').getOrCreate()

# Read the Dataset, inferSchema = True will take every value as it should be, otherwise all the values are strings
df_pyspark = spark.read.option('header', 'true').csv('data/test2.csv', inferSchema=True)
# df_pyspark = spark.read.csv('data/test2.csv', header=True, inferSchema=True)  # same way than former line but cleaner

# Check the Schema
df_pyspark.printSchema()

# Selecting the columns of a PySpark Dataframe
print(df_pyspark.columns)
print(df_pyspark.head(3))

df_pyspark.select('Name').show()
df_pyspark.select(['Name', 'Experience']).show()

print(df_pyspark.dtypes)

# Check Describe Option similar to Pandas
df_pyspark.describe().show()

# Adding Columns in Dataframe
df_pyspark = df_pyspark.withColumn('Experience After 2 Years', df_pyspark['Experience']+2)
df_pyspark.show()

# Drop the Columns
df_pyspark = df_pyspark.drop('Experience After 2 Years')
df_pyspark.show()

# Rename the Column
df_pyspark = df_pyspark.withColumnRenamed('Name', 'New Name')
df_pyspark.show()
