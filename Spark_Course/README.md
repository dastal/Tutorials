# Spark Course #

Course I finished to get to know Spark and how to use it, especially PySpark. Therefore, I used this [Tutorial](https://www.youtube.com/watch?v=_C8kWso4ne4). For more information about Spark visit the [Spark Documentation](https://spark.apache.org/).

## Setup ##
- IDE: [PyCharm](https://www.jetbrains.com/de-de/pycharm/)
- Python Version 3.10.7
- PySpark: `pip install pyspark` (in project terminal)
- Make Sure Java is installed on your computer
- To make it run, follow the steps of this [blog](https://towardsdatascience.com/installing-apache-pyspark-on-windows-10-f5f0c506bea1)

## Dataframe Part 1 ##
- PySpark Dataframe
- Reading the Dataset
- Checking the Datatypes of the Column (Schema)
- Selecting Columns and Indexing
- Check Describe Option similar to Pandas
- Adding Columns
- Dropping Columns
- Rename the Column

## Handling Missing Values ##
- Dropping Columns
- Dropping Rows
- Various Parameter in Dropping Functionalities
- Handling Missing Values by Mean, Median and Mode

## DataFrame Part 2 ##
- Filter Operation
- &,|,==
- ~

## GroupBy and Aggregate Functions ##
- Different GroupBy Functions
- Aggregate Function

## Mlib and Installation and Implementation ##
Simple linear regression model

## Introduction to Databricks ##
Find more information about [Databricks](https://www.databricks.com/try-databricks?itm_data=Homepage-HeroCTA-Trial)

- Sing up to the free [Databricks](https://www.databricks.com/try-databricks?itm_data=Homepage-HeroCTA-Trial) and select "Get Started with the community edition"
- After signing in, on the left hand side choose "Create" -> "Cluster"
- Give a name to the new cluster and choose the correct Spark version (3.3.0 in this case)
- Click "Create Cluster"
- Upload a dataset and run it on a Notebook
- Attach the notebook to the cluster
- Now you're ready write and execute code