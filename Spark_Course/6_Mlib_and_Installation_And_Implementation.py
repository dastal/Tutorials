from pyspark.sql import SparkSession
from pyspark.ml.feature import VectorAssembler
from pyspark.ml.regression import LinearRegression

spark = SparkSession.builder.appName('Missing').getOrCreate()
training = spark.read.csv('data/test6.csv', header=True, inferSchema=True)
training.show()
training.printSchema()
print(training.columns)

# VectorAssembler: Main features with which the ML-Algo is trained to get a totally new feature
# Combines/Assembles features to a vector
featureAssembler = VectorAssembler(inputCols=["Age", "Experience"], outputCol="Independent Features")
output = featureAssembler.transform(training)
output.show()
print(output.columns)

# Dataset of Interest
finalizedData = output.select("Independent Features", "Salary")
finalizedData.show()

# Train Test Split
trainData, testData = finalizedData.randomSplit([0.75, 0.25])

# Linear Regression Model
regressor = LinearRegression(featuresCol='Independent Features', labelCol='Salary')
regressor = regressor.fit(trainData)

# Coefficients
print(regressor.coefficients)

# Prediction
pred_results = regressor.evaluate(testData)
pred_results.predictions.show()

print(pred_results.meanAbsoluteError)
print(pred_results.meanSquaredError)
