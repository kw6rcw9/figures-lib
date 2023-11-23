

CREATE TABLE products(
id int IDENTITY (1,1) NOT NULL,
productName varchar(50) NOT NULL,
PRIMARY KEY (id)
);
INSERT INTO products (productName) VALUES
('Apple'),
('Chicken'),
('Shorts'),
('Phone')

CREATE TABLE categories(
id int IDENTITY (1,1) NOT NULL,
categoryName varchar(50) NOT NULL,
PRIMARY KEY (id)
);
INSERT INTO categories(categoryName) VALUES
('Meat'),
('Fruits'),
('Food'),
('Clothes')

CREATE TABLE products_categories(
	productId int FOREIGN KEY REFERENCES products(id),
	categoryId int FOREIGN KEY REFERENCES categories(id),
);

INSERT INTO products_categories (productId, categoryId) VALUES
(1, 2),
(1, 3),
(2, 1),
(2, 3),
(3, 4)


SELECT products.productName, categories.categoryName
FROM products 
LEFT JOIN products_categories ON products.id = products_categories.productId
LEFT JOIN categories ON categories.id = products_categories.categoryId;
