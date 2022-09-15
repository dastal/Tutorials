import pyspark
from pyspark.sql import SparkSession
import pandas as pd

# Importing Pandas
pd.read_csv('data/test1.csv')

# Starting Spark Session
spark = SparkSession.builder.appName('Practise').getOrCreate()

# Read Dataset
df_pyspark = spark.read.csv('data/test1.csv')
