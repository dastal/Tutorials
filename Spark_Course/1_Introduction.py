import pyspark
from pyspark.sql import SparkSession
import pandas as pd

# Importing Pandas
pd.read_csv('data/test1.csv')

# Starting Spark Session
spark = SparkSession.builder.appName('Practise').getOrCreate()

# Read Dataset (as pyspark dataframe)
df_pyspark = spark.read.option('header', 'true').csv('data/test1.csv')

df_pyspark.show()

df_pyspark.printSchema()
