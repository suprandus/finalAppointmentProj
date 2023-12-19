USE HairServicesDB;

-- REGULAR TABLE
CREATE TABLE user_category(
	role_id int PRIMARY KEY,
	[description] varchar(50),
);

CREATE TABLE user_account (
	[user_id] int PRIMARY KEY IDENTITY (1, 1001),
	username varchar(50) NOT NULL,
	[password] varchar(50) NOT NULL,
);

CREATE TABLE user_information(
	user_info_id int PRIMARY KEY IDENTITY (1, 1001),
	full_name varchar(50) NOT NULL,
	phone_number varchar(50) NOT NULL,
	email_address varchar(50) NOT NULL,
	[user_id] int NOT NULL,
	[role_id] int NOT NULL,
	FOREIGN KEY([user_id]) REFERENCES user_account([user_id]),
	FOREIGN KEY([role_id]) REFERENCES user_category([role_id])
);

CREATE TABLE services (
    service_name varchar(50) PRIMARY KEY,
    price decimal(10, 2) NOT NULL
);

-- Create Requested Services Table
--CREATE TABLE requested_services (
--    service_name varchar(50),
--    price decimal(10, 2),
--    [date] datetime,
--    user_id int,
--    status varchar(50) DEFAULT 'In Progress',
--    PRIMARY KEY (service_name, price, [date], user_id),
--    FOREIGN KEY (user_id) REFERENCES user_account([user_id])
--);

drop table requested_services
-- Updated table structure
CREATE TABLE requested_services (
    service_name varchar(50),
    price decimal(10, 2),
    [date] datetime,
    user_id int,
    staff_id int, 
	staff_name varchar(50) DEFAULT 'Not Assigned',
    status varchar(50) DEFAULT 'In Progress',
    PRIMARY KEY (service_name, price, [date], user_id),
    FOREIGN KEY (user_id) REFERENCES user_account([user_id]),
    FOREIGN KEY (staff_id) REFERENCES user_account([user_id]) 
);

-- Updated query
SELECT 
    rs.service_name AS 'Service Name', 
    rs.price AS 'Price', 
    rs.date AS 'Date', 
    rs.status AS 'Status',
    ua.user_id AS 'User ID',
    ua.username AS 'Staff Name'
FROM requested_services rs
JOIN user_account ua ON rs.staff_id = ua.user_id
WHERE rs.user_id = @user_id
ORDER BY rs.date ASC;


-- VIEWS 
CREATE VIEW UserView
AS
SELECT ua.[user_id], ua.username, ua.[password], ui.full_name, ui.phone_number, ui.email_address, ui.[role_id], uc.[description]
FROM dbo.user_account ua
JOIN user_information ui ON ua.[user_id] = ui.[user_id]
JOIN user_category uc ON ui.[role_id] = uc.[role_id];

SELECT * FROM UserView

-- VIew 
CREATE VIEW s_transations_history_view AS
SELECT
    staff_id,
    [date],
    SUM(price) AS totalAmount
FROM
    requested_services
WHERE
    status = 'Completed'
GROUP BY
    staff_id, [date];

SELECT * FROM s_transations_history_view

CREATE VIEW assigned_staff_view AS
SELECT
    rs.[service_name] AS 'Service Name',
    MAX(rs.price) AS 'Price',
    rs.[date] AS 'Date',
    MAX(rs.user_id) AS 'Client ID',
    MAX(rs.staff_name) AS 'Staff Name',
    MAX(rs.status) AS 'Status'
FROM
    [requested_services] rs
GROUP BY
    rs.[service_name], rs.[date];


---
CREATE VIEW service_view AS
SELECT
    user_id AS 'My ID',
    service_name AS 'Service Name',
    [date] AS 'Scheduled Date',
    staff_name 'Assigned Staff',
    status AS 'Current Status'
FROM
    requested_services;

-- STORED PROCEDURE
CREATE PROCEDURE GetUsers
AS
BEGIN
    SELECT 
        ua.[user_id] AS 'User ID',
        ua.username AS 'Username',
        ui.full_name AS 'Full Name',
        ui.phone_number AS 'Phone Number',
        ui.email_address AS 'Email Address',
        ui.[role_id] AS 'Role ID' 
    FROM 
        dbo.user_account ua
    JOIN 
        user_information ui ON ua.[user_id] = ui.[user_id]

END;

EXEC GetUsers;

CREATE PROCEDURE GetUsers1
AS
BEGIN
    SELECT 
        ua.[user_id] AS 'User ID',
        ua.username AS 'Username',
        ui.full_name AS 'Full Name',
        ui.phone_number AS 'Phone Number',
        ui.email_address AS 'Email Address',
        uc.[description] AS 'Role Description'
    FROM 
        dbo.user_account ua
    JOIN 
        user_information ui ON ua.[user_id] = ui.[user_id]
    JOIN 
        user_category uc ON ui.[role_id] = uc.[role_id];
END;

EXEC GetUsers1;

-- Create a Stored Procedure for Adding Services
CREATE PROCEDURE AddServiceRequest
    @user_id int,
    @service_name varchar(50),
    @price decimal(10, 2),
    @date datetime
AS
BEGIN
    INSERT INTO requested_services(user_id, service_name, price, [date])
    VALUES (@user_id, @service_name, @price, @date);
END;

DROP PROCEDURE AddServiceRequest

-- Create a Stored Procedure to Update Status Based on Date
CREATE PROCEDURE UpdateServiceStatus
    @user_id int,
    @service_name varchar(50),
    @date datetime,
    @new_status varchar(50)
AS
BEGIN
    UPDATE requested_services
    SET status = @new_status
    WHERE user_id = @user_id
      AND service_name = @service_name
      AND [date] = @date;
END;

--
CREATE PROCEDURE UpdateServiceStatus1
    @user_id int,
    @service_name varchar(50),
    @price decimal(10, 2),
    @date datetime,
    @staff_id int,
    @staff_name varchar(50),
    @new_status varchar(50)
AS
BEGIN
    UPDATE requested_services
    SET staff_id = @staff_id,
        staff_name = @staff_name,
        status = @new_status
    WHERE user_id = @user_id
      AND service_name = @service_name
      AND price = @price
      AND [date] = @date;
END;

drop procedure UpdateServiceStatus1

--
