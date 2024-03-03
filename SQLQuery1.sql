CREATE TABLE Student (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Gender NVARCHAR(10),
    Address NVARCHAR(255),
    IDCard NVARCHAR(50),
    DateOfBirth DATE,
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Teacher (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Gender NVARCHAR(10),
    Address NVARCHAR(255),
    IDCard NVARCHAR(50),
    DateOfBirth DATE,
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);

-- Inserting dummy data into the Student table
INSERT INTO Student (Name, Gender, Address, IDCard, DateOfBirth, Phone, Email)
VALUES
    ('John Doe', 'Male', '123 Main St, City', '123456789', '1998-05-15', '123-456-7890', 'john.doe@example.com'),
    ('Jane Smith', 'Female', '456 Elm St, Town', '987654321', '1999-08-20', '987-654-3210', 'jane.smith@example.com'),
    ('Michael Johnson', 'Male', '789 Oak St, Village', '456123789', '1997-12-10', '789-123-4567', 'michael.johnson@example.com');

-- Inserting dummy data into the Teacher table
INSERT INTO Teacher (Name, Gender, Address, IDCard, DateOfBirth, Phone, Email)
VALUES
    ('Alice Brown', 'Female', '321 Pine St, County', '741852963', '1985-03-25', '456-789-1230', 'alice.brown@example.com'),
    ('Bob Green', 'Male', '654 Cedar St, State', '852963741', '1978-11-12', '987-654-3210', 'bob.green@example.com'),
    ('Emily White', 'Female', '987 Maple St, Country', '369258147', '1990-09-08', '321-654-9870', 'emily.white@example.com');
