create database tienda_en_linea;
use tienda_en_linea;

create table warehouse (
	id int primary key not null identity(1,1),
	name varchar(150) not null,
	[address] varchar(150) not null,
	latitude decimal(9,6),
	longitude decimal(9,6)
);

create table products (
	id int primary key not null identity(1,1),
	name varchar(100) not null,
	details text not null,
	characteristics text,
	unit_price decimal(13,2) not null,
	available tinyint not null
);

create table product_images (
	id int primary key not null identity(1,1),
	name varchar(100) not null,
	[path] varchar(200) not null,
	created_at datetime not null,
	product_id int not null references products(id)
);

create table warehouse_products (
	id int primary key not null identity(1,1),
	warehouse_id int not null references warehouse(id),
	product_id int not null references products(id),
	quantity int not null
);

create table users (
	id int primary key not null identity(1,1),
	name varchar(150) not null,
	username varchar (50) not null unique,
	email varchar(100) not null unique,
	[password] varchar(255) not null,
	[address] varchar(150) not null,
	phone_number varchar(20) not null,
	register_date datetime not null,
	credit_card_number char(16) null,
	credit_card_expiration_year smallint null,
	credit_card_expiration_month tinyint null,
	credit_card_cvv smallint null,
	[type] varchar(50) not null,
	[status] tinyint not null
);

alter table users alter column [password] varchar(255) not null


create table [sessions] (
	id int primary key not null identity(1,1),
	[session] text not null,
	[status] tinyint not null
);

insert into users (name, username, email, [password], [address], phone_number, register_date, [type], [status]) 
values ('Administrador', 'admin', 'admin@tiendaenlinea.local', '12345678', 'Mi dirección', '8091231234', '2017-12-07 18:18:00', 'administrator', 1)

select * from products;
select * from users;