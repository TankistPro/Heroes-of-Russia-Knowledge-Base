CREATE TABLE HeroesRussia (
	id SERIAL PRIMARY KEY,
	firstName VARCHAR(50) NOT NULL,
	lastName VARCHAR(100) NOT NULL,
	middleName VARCHAR(150),
	biography TEXT,
	placeBirth TEXT,
	imageUrl VARCHAR
)

ALTER TABLE HeroesRussia 
	ADD COLUMN BirthDate DATE