USE shopping;

CREATE TABLE categories(
    id int primary key,
    name varchar(200)
);

ALTER TABLE products ADD  categories_id int NOT NULL;