-- Create the database
CREATE DATABASE sclManagementSystem;

-- Use the database
USE sclManagementSystem;

-- Create the table
CREATE TABLE LogingTb (
    Email VARCHAR(20),
    Username VARCHAR(50) PRIMARY KEY,
    Password VARCHAR(50)
);

-- Add sample data
INSERT INTO LogingTb (Email, Username, Password) VALUES 
('sample1@example.com', 'user1', 'password1'),
('sample2@example.com', 'user2', 'password2');
