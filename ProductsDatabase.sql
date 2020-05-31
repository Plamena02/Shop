USE Shop;
GO
INSERT INTO Drinks(Category, Name, Price, Quantity)
VALUES ('vodka', 'Smirnoff', 22.90, 20),
	   ('whiskey', 'Jack Daniels', 48.99, 10),
	   ('wine', 'Chardonnay', 38.50, 5),
	   ('beer', 'Corona', 2.80, 60),
	   ('water', 'Devin', 1.50, 100),
	   ('juice', 'Cappy', 2.00, 80),
	   ('ice-tea', 'Lipton', 1.80, 50),
	   ('cola', 'Coca-cola', 1.70, 120),
	   ('ice-coffee', 'Cieto', 3.00, 30),
	   ('energizer', 'Monster', 2.10, 90);

INSERT INTO FruitsAndVegetables(Category, Name, Price, Quantity)
VALUES ('fruit', 'banana', 1.80, 20),
	   ('fruit', 'orange', 1.70, 10),
	   ('fruit', 'kiwi', 1.90, 15),
	   ('fruit', 'strawberry', 3.00, 5),
	   ('fruit', 'melon', 4.50, 8),
	   ('fruit', 'grape', 2.80, 20),
	   ('vegetable', 'carrot', 2.20, 40),
	   ('vegetable', 'cucumber', 1.80, 30),
	   ('vegetable', 'tomato', 2.00, 25),
	   ('vegetable', 'celery', 2.50, 10);

INSERT INTO Nuts(Category, Name, Price, Quantity)
VALUES ('baked', 'almond', 4.80, 20),
	   ('baked', 'walnut', 4.70, 10),
	   ('baked', 'peanut', 5.90, 15),
	   ('baked', 'hazelnut', 5.00, 5),
	   ('raw', 'cashew', 5.50, 8),
	   ('raw', 'pistachio', 4.80, 20),
	   ('raw', 'sunflower seed', 3.20, 40),
	   ('raw', 'pumpkin seed', 3.80, 30),
	   ('raw', 'brazil nut', 6.00, 25),
	   ('raw', 'chickpea', 3.50, 10);

	   INSERT INTO Pastries(Category, Name, Price, Quantity)
VALUES ('salty', 'bread', 0.90, 50),
	   ('salty', 'banitsa', 1.20, 15),
	   ('salty', 'patty', 2.50, 20),
	   ('salty', 'horn', 0.60, 10),
	   ('sweet', 'donut', 2.80, 8),
	   ('sweet', 'easter bread', 2.80, 25),
	   ('sweet', 'muffins', 3.50, 35),
	   ('sweet', 'cookies', 2.00, 22),
	   ('sweet', 'eclairs', 2.35, 19),
	   ('sweet', 'croissant', 1.25, 29);

	   INSERT INTO AnimalProducts(Category, Name, Price, Quantity)
VALUES ('dairy', 'yogurt', 1.10, 15),
	   ('dairy', 'milk', 1.80, 20),
	   ('dairy', 'cottage cheese', 2.50, 6),
	   ('dairy', 'cheese', 3.00, 10),
	   ('fish', 'mackerel', 6.50, 29),
	   ('fish', 'shark', 15.00, 15),
	   ('fish', 'octopus', 14.00, 10),
	   ('meat', 'veal mince', 7.50, 35),
	   ('meat', 'chicken',6.90, 20),
	   ('meat', 'pork steak', 9.70, 30);