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


-- VIEWS 
CREATE VIEW UserView
AS
SELECT ua.[user_id], ua.username, ua.[password], ui.full_name, ui.phone_number, ui.email_address, ui.[role_id], uc.[description]
FROM dbo.user_account ua
JOIN user_information ui ON ua.[user_id] = ui.[user_id]
JOIN user_category uc ON ui.[role_id] = uc.[role_id];

SELECT * FROM UserView
