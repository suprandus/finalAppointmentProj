USE HairServicesDB;

CREATE TABLE user_category(
	role_id int PRIMARY KEY,
	[description] varchar(50),
	-- [user_id] int,
	--- FOREIGN KEY([user_id]) REFERENCES user_account([user_id])
);

SELECT * FROM user_information

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

CREATE TABLE user_account (
	[user_id] int PRIMARY KEY IDENTITY (1, 1001)
	username varchar(50) NOT NULL,
	[password] varchar(50) NOT NULL,
);

