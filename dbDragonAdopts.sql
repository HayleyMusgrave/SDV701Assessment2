CREATE TABLE [dbo].[tblBreed](
    [BreedName] varchar(50) NOT NULL PRIMARY KEY,
    [Rarity] varchar(20) NOT NULL,
    [Origin] varchar(15) NOT NULL,
    [BaseCost] integer NOT NULL,
);

CREATE TABLE [dbo].[tblInventory](
    [DragonID] integer NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] varchar(25) NOT NULL,
    [Species] varchar(15) NOT NULL,
    [Breed] varchar(50) NOT NULL 
		CONSTRAINT [FKBreed] FOREIGN KEY REFERENCES [dbo].[tblBreed] (BreedName)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    [Age] integer NOT NULL,
    [Sex] char(1) NOT NULL,
    [Size] integer NOT NULL,
    [Tame] char(1) NOT NULL,
    [Price] integer NOT NULL,
    [Image] image,
    [DateEdited] DateTime NOT NULL,
    [Available] char(1) NOT NULL,
    [Stance] varchar(20) NULL,
    [Fire] char(1) NULL,
    [Poison] char(1) NULL,
    [Length] integer NULL,
    [Whiskers] integer NULL,
    [Flight] char(1) NULL
);

CREATE TABLE [dbo].[tblPurchases](
    [OrderID] integer NOT NULL PRIMARY KEY IDENTITY(1,1),
    [DragonID] integer NOT NULL
        CONSTRAINT [FKDragonID] FOREIGN KEY REFERENCES [dbo].[tblInventory] (DragonID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    [CurrentPrice] integer NOT NULL,
    [DateOrdered] date NOT NULL,
    [CustomerName] varchar(30) NOT NULL
);

INSERT INTO [dbo].[tblBreed]
VALUES (
        'Golden blue-tongue',
        'Common',
        'Europe',
        '80'
        ),
    (
        'Tabby',
        'Common',
        'Unknown',
        '120'
        ),
    (
        'Ibex',
        'Uncommon',
        'Europe',
        '200'
        ),
    (
        'Kakapo Cloak',
        'Very Rare',
        'New Zealand',
        '1100'
        ),
    (
        'Mudskipper',
        'Uncommon',
        'Japan',
        '120'
        ),
    (
        'Spotted snow',
        'Legend',
        'Unknown',
        '1000'
);

INSERT INTO [dbo].[tblInventory] (Name, Species, Breed, Age, Sex, Size, Tame, Price, Image, DateEdited, Available, Stance, Fire, Poison, Length, Whiskers, Flight)
VALUES (
        'Aeon',
        'Western',
        'Mudskipper',
        '3',
        'F',
        '24',
        'Y',
        '170',
        '0',
        '2018-05-17',
        'Y',
        'Quadrapedal',
        'Y',
        'N',
        '0',
        '0',
        'N'
    ),
    (
        'Neo',
        'Western',
        'Mudskipper',
        '2',
        'M',
        '23',
        'Y',
        '140',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Kaia',
        'Western',
        'Mudskipper',
        '4',
        'F',
        '21',
        'Y',
        '160',
        '0',
        '2018-05-14',
        'Y',
        'Bipedal',
        'N',
        'Y',
        '0',
        '0',
        'N'
        ),
    (
        'Willow',
        'Western',
        'Golden blue-tongue',
        '3',
        'F',
        '26',
        'Y',
        '100',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'Y',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Kor',
        'Western',
        'Golden blue-tongue',
        '2',
        'M',
        '36',
        'N',
        '90',
        '0',
        '2018-05-07',
        'Y',
        'Bipedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Jaina',
        'Western',
        'Golden blue-tongue',
        '6',
        'F',
        '31',
        'Y',
        '120',
        '0',
        '2018-05-13',
        'N',
        'Bipedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Gem',
        'Western',
        'Kakapo Cloak',
        '2',
        'F',
        '31',
        'Y',
        '1600',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Ira',
        'Western',
        'Ibex',
        '6',
        'F',
        '20',
        'Y',
        '240',
        '0',
        '2018-05-18',
        'Y',
        'Quadrapedal',
        'N',
        'Y',
        '0',
        '0',
        'N'
        ),
    (
        'Ursa',
        'Western',
        'Ibex',
        '4',
        'F',
        '23',
        'Y',
        '260',
        '0',
        '2018-05-13',
        'Y',
        'Bipedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Cleo',
        'Western',
        'Tabby',
        '2',
        'F',
        '33',
        'Y',
        '140',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Hara',
        'Western',
        'Tabby',
        '3',
        'F',
        '31',
        'Y',
        '130',
        '0',
        '2018-05-20',
        'N',
        'Bipedal',
        'N',
        'Y',
        '0',
        '0',
        'N'
        ),
    (
        'Felix',
        'Western',
        'Tabby',
        '4',
        'M',
        '24',
        'Y',
        '150',
        '0',
        '2018-05-19',
        'Y',
        'Quadrapedal',
        'Y',
        'N',
        '0',
        '0',
        'N'
);

INSERT INTO [dbo].[tblInventory] (Name, Species, Breed, Age, Sex, Size, Tame, Price, Image, DateEdited, Available, Stance, Fire, Poison, Length, Whiskers, Flight)
VALUES (
        'Maraia',
        'Lung',
        'Mudskipper',
        '3',
        'F',
        '35',
        'N',
        '140',
        '0',
        '2018-05-13',
        'Y',
    
        'na',
        'n',
        'n',
    
        '123',
        '2',
        'Y'
        ),
    (
        'Haron',
        'Lung',
        'Mudskipper',
        '1',
        'M',
        '18',
        'Y',
        '140',
        '0',
        '2018-05-15',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '314',
        '0',
        'Y'
        ),
    (
        'Jei',
        'Lung',
        'Mudskipper',
        '5',
        'F',
        '21',
        'Y',
        '200',
        '0',
        '2018-05-13',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '230',
        '4',
        'N'
        ),
    (
        'Kath',
        'Lung',
        'Golden blue-tongue',
        '3',
        'F',
        '27',
        'Y',
        '110',
        '0',
        '2018-05-17',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '140',
        '2',
        'Y'
        ),
    (
        'Leia',
        'Lung',
        'Golden blue-tongue',
        '1',
        'F',
        '25',
        'Y',
        '130',
        '0',
        '2018-05-15',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '342',
        '0',
        'Y'
        ),
    (
        'Orro',
        'Lung',
        'Ibex',
        '5',
        'M',
        '35',
        'N',
        '230',
        '0',
        '2018-05-20',
        'N',
    
        'na',
        'n',
        'n',
    
        
        '149',
        '2',
        'Y'
        ),
    (
        'Tarron',
        'Lung',
        'Ibex',
        '3',
        'M',
        '31',
        'Y',
        '220',
        '0',
        '2018-05-01',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '203',
        '2',
        'N'
        ),
    (
        'Irex',
        'Lung',
        'Ibex',
        '6',
        'M',
        '31',
        'Y',
        '230',
        '0',
        '2018-05-11',
        'N',
    
        'na',
        'n',
        'n',
    
        
        '204',
        '4',
        'N'
        ),
    (
        'Kiki',
        'Lung',
        'Tabby',
        '2',
        'F',
        '31',
        'Y',
        '150',
        '0',
        '2018-05-16',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '202',
        '2',
        'Y'
        ),
    (
        'Fili',
        'Lung',
        'Tabby',
        '3',
        'F',
        '31',
        'Y',
        '110',
        '0',
        '2018-05-14',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '300',
        '0',
        'N'
);

INSERT INTO [dbo].[tblPurchases] (DragonID, CurrentPrice, DateOrdered, CustomerName)
VALUES (
        '6',
        '120',
        '2018-05-21',
        'Nyra Evans'
    ),
    (
        '11',
        '130',
        '2018-05-21',
        'Darren Karnoth'
    ),
    (
        '18',
        '230',
        '2018-05-21',
        'Irana Orees'
);






-- ---------------------------------------- --

CREATE TABLE [dbo].[tblBreed](
    [BreedName] varchar(50) NOT NULL PRIMARY KEY,
    [Rarity] varchar(20),
    [Origin] varchar(15),
    [BaseCost] integer,
);

CREATE TABLE [dbo].[tblInventory](
    [DragonID] integer NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] varchar(25),
    [Species] varchar(15),
    [Breed] varchar(50) 
		CONSTRAINT [FKBreed] FOREIGN KEY REFERENCES [dbo].[tblBreed] (BreedName)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    [Age] integer,
    [Sex] char(1),
    [Size] integer,
    [Tame] char(1),
    [Price] integer,
    [Image] image,
    [DateEdited] DateTime,
    [Available] char(1),
    [Stance] varchar(20),
    [Fire] char(1),
    [Poison] char(1),
    [Length] integer,
    [Whiskers] integer,
    [Flight] char(1)
);

CREATE TABLE [dbo].[tblPurchases](
    [OrderID] integer NOT NULL PRIMARY KEY IDENTITY(1,1),
    [DragonID] integer
        CONSTRAINT [FKDragonID] FOREIGN KEY REFERENCES [dbo].[tblInventory] (DragonID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    [CurrentPrice] integer,
    [DateOrdered] date,
    [CustomerName] varchar(30)
);

INSERT INTO [dbo].[tblBreed]
VALUES (
        'Golden blue-tongue',
        'Common',
        'Europe',
        '80'
        ),
    (
        'Tabby',
        'Common',
        'Unknown',
        '120'
        ),
    (
        'Ibex',
        'Uncommon',
        'Europe',
        '200'
        ),
    (
        'Kakapo Cloak',
        'Very Rare',
        'New Zealand',
        '1100'
        ),
    (
        'Mudskipper',
        'Uncommon',
        'Japan',
        '120'
        ),
    (
        'Spotted snow',
        'Legend',
        'Unknown',
        '1000'
);

INSERT INTO [dbo].[tblInventory] (Name, Species, Breed, Age, Sex, Size, Tame, Price, Image, DateEdited, Available, Stance, Fire, Poison, Length, Whiskers, Flight)
VALUES (
        'Aeon',
        'Western',
        'Mudskipper',
        '3',
        'F',
        '24',
        'Y',
        '170',
        '0',
        '2018-05-17',
        'Y',
        'Quadrapedal',
        'Y',
        'N',
        '0',
        '0',
        'N'
    ),
    (
        'Neo',
        'Western',
        'Mudskipper',
        '2',
        'M',
        '23',
        'Y',
        '140',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Kaia',
        'Western',
        'Mudskipper',
        '4',
        'F',
        '21',
        'Y',
        '160',
        '0',
        '2018-05-14',
        'Y',
        'Bipedal',
        'N',
        'Y',
        '0',
        '0',
        'N'
        ),
    (
        'Willow',
        'Western',
        'Golden blue-tongue',
        '3',
        'F',
        '26',
        'Y',
        '100',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'Y',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Kor',
        'Western',
        'Golden blue-tongue',
        '2',
        'M',
        '36',
        'N',
        '90',
        '0',
        '2018-05-07',
        'Y',
        'Bipedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Jaina',
        'Western',
        'Golden blue-tongue',
        '6',
        'F',
        '31',
        'Y',
        '120',
        '0',
        '2018-05-13',
        'N',
        'Bipedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Gem',
        'Western',
        'Kakapo Cloak',
        '2',
        'F',
        '31',
        'Y',
        '1600',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Ira',
        'Western',
        'Ibex',
        '6',
        'F',
        '20',
        'Y',
        '240',
        '0',
        '2018-05-18',
        'Y',
        'Quadrapedal',
        'N',
        'Y',
        '0',
        '0',
        'N'
        ),
    (
        'Ursa',
        'Western',
        'Ibex',
        '4',
        'F',
        '23',
        'Y',
        '260',
        '0',
        '2018-05-13',
        'Y',
        'Bipedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Cleo',
        'Western',
        'Tabby',
        '2',
        'F',
        '33',
        'Y',
        '140',
        '0',
        '2018-05-16',
        'Y',
        'Quadrapedal',
        'N',
        'N',
        '0',
        '0',
        'N'
        ),
    (
        'Hara',
        'Western',
        'Tabby',
        '3',
        'F',
        '31',
        'Y',
        '130',
        '0',
        '2018-05-20',
        'N',
        'Bipedal',
        'N',
        'Y',
        '0',
        '0',
        'N'
        ),
    (
        'Felix',
        'Western',
        'Tabby',
        '4',
        'M',
        '24',
        'Y',
        '150',
        '0',
        '2018-05-19',
        'Y',
        'Quadrapedal',
        'Y',
        'N',
        '0',
        '0',
        'N'
);

INSERT INTO [dbo].[tblInventory] (Name, Species, Breed, Age, Sex, Size, Tame, Price, Image, DateEdited, Available, Stance, Fire, Poison, Length, Whiskers, Flight)
VALUES (
        'Maraia',
        'Lung',
        'Mudskipper',
        '3',
        'F',
        '35',
        'N',
        '140',
        '0',
        '2018-05-13',
        'Y',
    
        'na',
        'n',
        'n',
    
        '123',
        '2',
        'Y'
        ),
    (
        'Haron',
        'Lung',
        'Mudskipper',
        '1',
        'M',
        '18',
        'Y',
        '140',
        '0',
        '2018-05-15',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '314',
        '0',
        'Y'
        ),
    (
        'Jei',
        'Lung',
        'Mudskipper',
        '5',
        'F',
        '21',
        'Y',
        '200',
        '0',
        '2018-05-13',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '230',
        '4',
        'N'
        ),
    (
        'Kath',
        'Lung',
        'Golden blue-tongue',
        '3',
        'F',
        '27',
        'Y',
        '110',
        '0',
        '2018-05-17',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '140',
        '2',
        'Y'
        ),
    (
        'Leia',
        'Lung',
        'Golden blue-tongue',
        '1',
        'F',
        '25',
        'Y',
        '130',
        '0',
        '2018-05-15',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '342',
        '0',
        'Y'
        ),
    (
        'Orro',
        'Lung',
        'Ibex',
        '5',
        'M',
        '35',
        'N',
        '230',
        '0',
        '2018-05-20',
        'N',
    
        'na',
        'n',
        'n',
    
        
        '149',
        '2',
        'Y'
        ),
    (
        'Tarron',
        'Lung',
        'Ibex',
        '3',
        'M',
        '31',
        'Y',
        '220',
        '0',
        '2018-05-01',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '203',
        '2',
        'N'
        ),
    (
        'Irex',
        'Lung',
        'Ibex',
        '6',
        'M',
        '31',
        'Y',
        '230',
        '0',
        '2018-05-11',
        'N',
    
        'na',
        'n',
        'n',
    
        
        '204',
        '4',
        'N'
        ),
    (
        'Kiki',
        'Lung',
        'Tabby',
        '2',
        'F',
        '31',
        'Y',
        '150',
        '0',
        '2018-05-16',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '202',
        '2',
        'Y'
        ),
    (
        'Fili',
        'Lung',
        'Tabby',
        '3',
        'F',
        '31',
        'Y',
        '110',
        '0',
        '2018-05-14',
        'Y',
    
        'na',
        'n',
        'n',
    
        
        '300',
        '0',
        'N'
);

INSERT INTO [dbo].[tblPurchases] (DragonID, CurrentPrice, DateOrdered, CustomerName)
VALUES (
        '6',
        '120',
        '2018-05-21',
        'Nyra Evans'
    ),
    (
        '11',
        '130',
        '2018-05-21',
        'Darren Karnoth'
    ),
    (
        '18',
        '230',
        '2018-05-21',
        'Irana Orees'
);

ALTER TABLE [dbo].[tblInventory]
DROP COLUMN [Image];

ALTER TABLE [dbo].[tblInventory]
ADD [Image] varchar(255);