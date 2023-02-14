## Delete Records ##
As we have seen in the last few sections, primary keys can uniquely identify a record. So when we want to delete a record from a table, we should, in most cases, use the primary key. If we want to delete the record with the `id = 1`, we can use the following command:

```sql
DELETE FROM person WHERE id = 1;
```

If we want to delete every single record in our table, we can use the following command:

```sql
DELETE FROM person;
```

We can also use other attributes to delete records.

## Update Records ##
The update command allows us to update a column or multiple columns based on our `WHERE` clause. We could also update every single row if we do not provide a where clause. For example when we want to update an e-mail address of a person that did initially not provide an e-mail address. Therefore we can use the following command:

```sql
UPDATE person SET email = 'dloughrey@psql.com' WHERE id = 4;
```

We could also update multiple columns, by using the following command:

```sql
UPDATE person SET first_name = 'Omar', last_name = 'Montana', email = 'omar.montan@bluewin.ch' WHERE id = 1;
```

Just have in mind that always when you want to delete or update one or more records you always have a where clause, because otherwise we might update or delete the entire table.