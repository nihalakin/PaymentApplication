CREATE DATABASE PaymentApp;
USE PaymentApp;

CREATE TABLE Payments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    AdSoyad NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(20) NOT NULL,
    Tutar DECIMAL(18,2) NOT NULL,
    Durum INT NOT NULL DEFAULT 0, -- 0: Bekliyor, 1: Onaylandý, 2: Reddedildi
);
