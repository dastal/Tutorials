# Key Handling in Tables #

## Primary Keys ##
Let us assume that we have two people with the exact same values in our table. How would we identify the two? None of the columns can be used to uniquely idetify the two. This is where we use primary keys. A primary key is a value with which we can identify uniquely any record in our tables.

## Understanding Primary Keys ##
When we think back to when we created the table "person", we remember that we used the keyword `PRIMARY KEY` for the attribute id. So if we want to insert antother person who has the `id = 1`, we receive an error, saying that there already exists a person with `id = 1`. This means that the `id` is a unique constraint that cannot be duplicated. 

If we want to remove the key, we have to can use the following command:

```sql
ALTER TABLE person DROP CONSTRAINT person_pkey;
```

## Adding Primary Key ##
Now we want to add back the primary key and see what happens. Therefore we use the following command:

```sql
ALTER TABLE person ADD PRIMARY KEY (id);
```

But mind if there are two persons that have the same id, setting the primary key newly is not possible. 

## Unique Constraints ##
The unique constraint allows us to have unique values for a given column. The reason why we have to use unique constraints is that for example e-mail addresses must be unique, because if not we could not address a single person, but many persons. To make a column unique, we can use the following command:

```sql
ALTER TABLE person ADD CONSTRAINT unique_email_address UNIQUE (email);
```

To again drop this constraint, we can use the following command:

```sql
ALTER TABLE person DROP CONSTRAINT unique_email_address;
```

Another way to add a new constraint can be done using the following command:

```sql
ALTER TABLE person ADD UNIQUE (email);
```

The difference between those two ways is that in the latter one we let PostgreSQL define the constraint name.

## Check Constraints ##
The check constraint allows us to add a constraint based on a boolean condition. For example if we want to verify that we only have the already existing genders in our table (I know, not contemporary but it is the example from the video...).  Let us use the following command:

```sql
ALTER TABLE person ADD CONSTRAINT gender_constraint CHECK (gender = 'Female' OR gender = 'Male' OR gender = 'Genderqueer' OR gender = 'Bigender' OR gender = 'Genderfluid' OR gender = 'Polygender' OR gender = 'Non-binary' OR gender = 'Agender');
```
