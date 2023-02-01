
## Select From ##
We already encountered the following command:

```sql
SELECT * FROM person;
```

The `*` means that we want to select everything from the table. If we just enter `SELECT FROM person;` we would receive the number of rows that we have in this table.

If we want only to select one column of the table, we can use:

```sql
SELECT first_name FROM person;
```

or if we want two columns, we can use:

```sql
SELECT frist_name, last_name FROM person;
```

If we select rows that have no entry, such as the column "email" that may or may not have an entry, then the line that has no entry is blank.

## Order By ##
In the following section, we are going to learn the keywords:
- ascending `ASC`: If ordered ascending, this means that the smallest number or letter is listed first (like: 1 2 3 4 5, or a b c d e)
- descending `DESC`: If ordered descending, this means that the biggest number or letter is listed first (like: 5 4 3 2 1, or: e d c b a)

```sql
SELECT * FROM person ORDER BY country_of_birth;
SELECT * FROM person ORDER BY country_of_birth DESC;
SELECT * FROM person ORDER BY country_of_birth ASC;
```

By default, the first command at the top, the list is sorted ascending. If we have columns like email that may or may not have an entry, the lines with no entries will be shown first. We can also sort over more than one column. 

```sql
SELECT * FROM person ORDER BY country_of_birth, email;
```

## Distinct ##
`DISTINCT` is used to select unique values from a column. If we have a look at our example table "person" and select the ordered country column, we can see that we have several entries in this column that have the same "country_of_birth". If we want to see each country once, we can use the following command:

```sql
SELECT DISTINCT country_of_birth FROM person ORDER BY country_of_birth;
```

The result looks as follows:

<img src="images/distinct.png" alt="distinct" width="200"/>


## Where Clause and AND ##
The `WHERE` clause allows us to filter our data based on conditions. For example, if we want to search for example all the entries in the table that have the gender "Female",  we can use the following command:

```sql
SELECT * FROM person WHERE gender = 'Female';
```

If we want to filter for more than one condition, we can use the `AND` operator, which would look as follows:

```sql
SELECT * FROM person WHERE gender = 'Female' AND country_of_birth = 'Poland';
```

We can also use the `OR` operator if we want to diversify our selection:

```sql
SELECT * FROM person WHERE gender = 'Female' AND country_of_birth = 'Poland' OR country_of_birth = 'China';
```

## Comparison Operators ##
(1:25:30)