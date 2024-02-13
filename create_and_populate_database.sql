-- create empty database
-- drop database if exists my_first_database;
create database my_first_database;

-- connect to database
\c my_first_database;

-- create table 1
CREATE TABLE table_1(
    INT1 INT PRIMARY KEY NOT NULL,
    BOOL1 BOOLEAN NOT NULL,
    INT2 INT NOT NULL,
    BOOL2 BOOLEAN NOT NULL,
    INT3 INT NOT NULL,
    BOOL3 BOOLEAN NOT NULL,
    INT4 INT NOT NULL,
    BOOL4 BOOLEAN NOT NULL,
    INT5 INT NOT NULL,
    BOOL5 BOOLEAN NOT NULL);

-- populate table 1
INSERT INTO table_1 (INT1, BOOL1, INT2, BOOL2, INT3, BOOL3, INT4, BOOL4, INT5, BOOL5)
SELECT g.id, true, g.id, false, g.id, true, g.id, false, g.id, true
FROM generate_series(1,10_000_000)
AS g (id);

-- drop table 1
-- DROP TABLE table_1;

-- create table 2
CREATE TABLE table_2(
    INT1 INT PRIMARY KEY NOT NULL,
    INT2 INT NOT NULL,
    INT3 INT NOT NULL,
    INT4 INT NOT NULL,
    INT5 INT NOT NULL,
    BOOL1 BOOLEAN NOT NULL,
    BOOL2 BOOLEAN NOT NULL,
    BOOL3 BOOLEAN NOT NULL,
    BOOL4 BOOLEAN NOT NULL,
    BOOL5 BOOLEAN NOT NULL);

-- populate table 2
INSERT INTO table_2 (INT1, INT2, INT3, INT4, INT5, BOOL1, BOOL2, BOOL3, BOOL4, BOOL5)
SELECT g.id, g.id, g.id, g.id, g.id, true, false, true, false, true
FROM generate_series(1,10_000_000)
AS g (id);

-- drop table 2
-- DROP TABLE table_2;
