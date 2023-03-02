# Conflicts #

## On Conflict Do Nothing ##
Here we going to learn how to handle duplicate key errors or exceptions. So if for example we want to insert a new person that has `id=116`, then we receive an error which tells us that the ID already belongs to someone (with the person primary key). When we want to handle this conflic we can use the `ON CONFLICT` keyword, as follows:

```sql
INSERT INTO person (id, first_name, last_name, email, gender, date_of_birth, country_of_birth) VALUES (116, 'Leda', 'Mariot', 'lmarjot37@icio.us', 'Female', '2023-01-05', 'China') ON CONFLICT (id) DO NOTHING;
```

So we prevent inserting the person with the same id again by telling PostgreSQL that it should do nothing in case of a conflict, which it does. We could also handle the same thing for an email.

```sql
INSERT INTO person (id, first_name, last_name, email, gender, date_of_birth, country_of_birth) VALUES (116, 'Leda', 'Mariot', 'lmarjot37@icio.us', 'Female', '2023-01-05', 'China') ON CONFLICT (email) DO NOTHING;
```

But this will not work if we do not have a unique column, i.e. it is either a primary key or a unique contraint. 

## Upsert ##
Sometimes we want to do something instead of nothing with the `DO NOTHING` keyword. So for example if the user sets his data, but then in a second query he changes his mind and immediately sends another request with a changed e-mail address. In this case we can use the latest insert that comes from the client. 

```sql
INSERT INTO person (id, first_name, last_name, email, gender, date_of_birth, country_of_birth) VALUES (116, 'Leda', 'Mariot', 'lmarjot@gmail.cn', 'Female', '2023-01-05', 'China') ON CONFLICT (id) DO UPDATE SET email = EXCLUDED.email;
```

Now we had an id conflict but we simply chagned the e-mail address. In the part `email = EXCLUDED.email`, the `email` is the old email address and the `EXCLUDED.email` is the one to be updated. After the `SET` keyword, every other attribute can be updated.
