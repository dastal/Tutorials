
## Adding New Table and Data using Mockaroo ##
With Mockaroo, we create a new table called "car.sql" which has the following columns:

- `id`: BIGSERIAL NOT NULL PRIMARY KEY, identification number like in "person"
- `make`: VARCHAR(100) NOT NULL, name of the producer of the car
- `model`: VARCHAR(100) NOT NULL, name of the model of the car
- `price`: NUMERIC(19, 2) NOT NULL, the price of the car (between 10000 and 100000)

We insert this table into the database.

## Calculating Min, Max & Average ##
If we want to select the most expensive car in this table we can use the following command:

```sql
SELECT MAX(price) FROM car;
```

If we want to select the least expensive car in this table instead, we can use the following command:

```sql
SELECT MIN(price) FROM car;
```

To get the average of the price of all the cars in this table, we can use the command:

```sql
SELECT AVG(price) FROM car;
```

To get the rounded average price of all the cars in this table, we can use the following command:

```sql
SELECT ROUND(AVG(price)) FROM car;
```

To get the minimum or the maximum car price for each make (each producer), we can us the following command:

```sql
SELECT make, model, MIN(price) FROM car GROUP BY make, model;
SELECT make, model, MAX(price) FROM car GROUP BY make, model;
```

## SUM ##
The sum operator allows us to perform addition on our dataset. If we want to compute the sum of the prices of all the cars in the table, we can use the command:

```sql
SELECT SUM(price) FROM car;
```

If we want to compute the sum of the price of every model of a make (producer), we can use the following command:

```sql
SELECT make, SUM(price) FROM car GROUP BY make;
```

## Basics of Arithmetic Operators ##
(2:01:55)