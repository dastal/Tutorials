from pyspark.sql import SparkSession
from pyspark.ml.feature import Imputer

# Reading the csv file and save it into a Dataframe
spark = SparkSession.builder.appName('Practise').getOrCreate()
df_pyspark = spark.read.csv('data/test3.csv', header=True, inferSchema=True)
df_pyspark.show()

# Dropping a column
df_pyspark.drop('Name').show()

# Dropping the null Values, by default the how-value of drop is any, this means that any row that contains a null value
# is deleted
df_pyspark.na.drop().show()

# drop(): how="all" -> drops only rows that contain only null values
df_pyspark.na.drop(how="all").show()

# drop(): thresh=2 -> the lines that contain at least two non-null values is deleted
df_pyspark.na.drop(how="any", thresh=2).show()
df_pyspark.na.drop(how="any", thresh=3).show()

# drop(): subset=['Experience'] -> Whenever there is a null value in the Experience-column it will be deleted
df_pyspark.na.drop(how="any", subset=['Experience']).show()

# Filling the missing values
# Fills the null values with whatever is given to fill, 'Missing Value' in this case
df_pyspark.na.fill('Missing Values').show()

# Fills the null values with whatever is given to fill but only in the 'Experience' column, 'Missing Value' in this case
df_pyspark.na.fill('Missing Values', 'Experience').show()

# Use the Imputer Function (here with the mean, can also be done with the median or the mode)
imputer = Imputer(
    inputCols=['Age', 'Experience', 'Salary'],
    outputCols=["{}_imputed".format(c) for c in ['Age', 'Experience', 'Salary']]
).setStrategy("mean")

# Add imputation columns to df
imputer.fit(df_pyspark).transform(df_pyspark).show()
