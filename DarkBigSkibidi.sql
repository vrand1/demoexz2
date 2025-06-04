-- Таблица "Типы-партнеров" // Надо для выпадающего списка
CREATE TABLE Типы_партнеров (
  Код int identity primary key,
  Наименование varchar(100)
);
-- Таблица "Партнеры"
CREATE TABLE Партнеры (
    Код INT identity PRIMARY KEY,
    Тип_партнера int foreign key references Типы_партнеров(Код),
    Наименование VARCHAR(255),
    Директор VARCHAR(255),
    Электронная_почта VARCHAR(255),
    Телефон VARCHAR(50),
    Юридический_адрес VARCHAR(500),
    Рейтинг INT,
    ИНН VARCHAR(20)
);
-- Таблица "Типы_продукции"
CREATE TABLE Типы_продукции (
    Код INT identity PRIMARY KEY,
    Наименование VARCHAR(255),
  Коэффициент DECIMAL(10,4)
    
);
-- Таблица "Продукция"
CREATE TABLE Продукция (
    Код INT identity PRIMARY KEY,
    Артикул VARCHAR(50),
    Наименование VARCHAR(255),
    Тип_продукции int foreign key references Типы_продукции(Код),
    Минимальная_стоимость DECIMAL(18,2)
);
-- Таблица "Продажи"
CREATE TABLE Продажи (
    Код INT identity PRIMARY KEY,
    Дата DATETIME,
    Продукция int foreign key references Продукция(Код),
    Партнер int foreign key references Партнеры(Код),
    Количество INT
);
-- Таблица "Типы_материалов"
CREATE TABLE Типы_материалов (
    Код INT identity PRIMARY KEY,
    Наименование VARCHAR(255),
    Процент_брака DECIMAL(5,4)
);
-- Таблица "Материалы_в_продукции"
CREATE TABLE Материалы_в_продукции (
    Код_продукции int foreign key references Продукция(Код),
    Код_типа_материала int foreign key references Типы_материалов(Код),
  PRIMARY KEY (Код_продукции, Код_типа_материала)
    
);