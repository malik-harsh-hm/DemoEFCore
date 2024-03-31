INSERT INTO [Products] ([Name], [Price])
VALUES 
    ('Margherita Pizza', 10.99),
    ('Pepperoni Pizza', 12.99),
    ('Vegetarian Pizza', 11.99),
    ('Supreme Pizza', 14.99),
    ('Hawaiian Pizza', 13.99),
    ('BBQ Chicken Pizza', 15.99),
    ('Mushroom Lovers Pizza', 12.49),
    ('Meat Lovers Pizza', 14.99),
    ('Vegan Pizza', 13.49),
    ('Buffalo Chicken Pizza', 13.99);

INSERT INTO [Customers] ([FirstName], [LastName], [Address], [Phone], [Email])
VALUES 
    ('John', 'Doe', '123 Main St', '555-1234', 'john.doe@email.com'),
    ('Jane', 'Smith', '456 Oak Ave', '555-5678', 'jane.smith@email.com'),
    ('Bob', 'Johnson', '789 Pine Ln', '555-9101', 'bob.johnson@email.com'),
    ('Alice', 'Williams', '101 Elm Rd', '555-1122', 'alice.williams@email.com'),
    ('Charlie', 'Brown', '202 Maple Dr', '555-3344', 'charlie.brown@email.com'),
    ('Eva', 'Davis', '303 Birch Blvd', '555-5566', 'eva.davis@email.com'),
    ('Michael', 'Miller', '404 Cedar Ln', '555-7788', 'michael.miller@email.com'),
    ('Sophia', 'Moore', '505 Spruce Ave', '555-9900', 'sophia.moore@email.com'),
    ('David', 'Wilson', '606 Oak St', '555-1122', 'david.wilson@email.com'),
    ('Olivia', 'Taylor', '707 Pine Rd', '555-3344', 'olivia.taylor@email.com');


INSERT INTO [Orders] ([OrderPlaced], [OrderFulfilled], [CustomerId])
VALUES 
    ('2024-02-23 08:00:00', '2024-02-23 12:00:00', 1),
    ('2024-02-24 09:30:00', '2024-02-24 14:45:00', 2),
    ('2024-02-25 11:15:00', '2024-02-25 17:30:00', 3),
    ('2024-02-26 14:45:00', '2024-02-26 18:00:00', 4),
    ('2024-02-27 10:00:00', '2024-02-27 15:30:00', 5),
    ('2024-02-28 12:30:00', '2024-02-28 16:45:00', 6),
    ('2024-02-29 15:15:00', '2024-02-29 20:00:00', 7),
    ('2024-03-01 08:45:00', '2024-03-01 14:30:00', 8),
    ('2024-03-02 11:30:00', '2024-03-02 16:15:00', 9),
    ('2024-03-03 13:00:00', '2024-03-03 18:45:00', 10);

INSERT INTO [OrderDetails] ([Quantity], [OrderId], [ProductId])
VALUES 
    (2, 1, 1),   -- 2 Margherita Pizzas for Order 1
    (1, 2, 2),   -- 1 Pepperoni Pizza for Order 2
    (3, 3, 3),   -- 3 Vegetarian Pizzas for Order 3
    (1, 4, 4),   -- 1 Supreme Pizza for Order 4
    (2, 5, 5),   -- 2 Hawaiian Pizzas for Order 5
    (1, 6, 6),   -- 1 BBQ Chicken Pizza for Order 6
    (4, 7, 7),   -- 4 Mushroom Lovers Pizzas for Order 7
    (1, 8, 8),   -- 1 Meat Lovers Pizza for Order 8
    (3, 9, 9),   -- 3 Vegan Pizzas for Order 9
    (2, 10, 10);  -- 2 Buffalo Chicken Pizzas for Order 10