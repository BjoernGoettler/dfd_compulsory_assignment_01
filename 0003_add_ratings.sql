USE shopping;
GO

CREATE TABLE product_ratings (id int primary key,
    product_id int not null,
    rating int not null);