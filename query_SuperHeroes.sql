create database Prueba
go

use Prueba
go

create table SuperPoderes(
	IdSuperPoder int primary key identity(1,1),
	Descripcion nvarchar(255) not null
)
go

create table SuperHeroes(
	IdSuperHeroe int primary key identity(1,1),
	Nombre nvarchar(255) not null
)
go

create table SuperHeroe_SuperPoder(
	IdSuperHeroe_SuperPoder int primary key identity(1,1),
	IdSuperHeroe int not null,
	IdSuperPoder int not null,
	foreign key (IdSuperHeroe) references SuperHeroes(IdSuperHeroe),
	foreign key (IdSuperPoder) references SuperPoderes(IdSuperPoder)
)
go

insert into SuperPoderes (Descripcion) 
values ('Vuelo'), 
('Fuerza'), 
('Invisibilidad'), 
('Teletransportación'), 
('Velocidad')

insert into SuperHeroes (Nombre)
values ('Superman'), 
('Batman'),
('Flash'),
('SpiderMan'),
('Hulk')
go

insert into SuperHeroe_SuperPoder (IdSuperHeroe, IdSuperPoder)
values 
(1, 1),
(1, 2),
(3, 5),
(4, 2),
(5, 2)
go
-- Insertar Heroe
create or alter procedure SP_InsertarSuperHeroe
	@Nombre nvarchar(50),
	@Mensaje nvarchar(255) output,
	@Resultado int output
as
begin

	if not exists (select 1 from SuperHeroes where Nombre = @Nombre)
		begin
			insert into SuperHeroes (Nombre)
			values (@Nombre)
			set @Mensaje = 'Superhéroe insertado correctamente.'
			set @Resultado = 1
		end

	else
		begin
			set @Mensaje = 'El superhéroe ya existe.'
			set @Resultado = 0
			Return
		end
end
go

-- Insertar SuperPoder
create or alter procedure SP_InsertarSuperPoder
	@Descripcion nvarchar(255),
	@Mensaje nvarchar(255) output,
	@Resultado int output
as
begin
	if not exists (select 1 from SuperPoderes where Descripcion = @Descripcion)
		begin
			insert into SuperPoderes (Descripcion)
			values (@Descripcion)
			set @Mensaje = 'Superpoder agregado correctamente'
			set @Resultado = 1
		end
	else
		begin
			set @Mensaje = 'El superpoder ya existe'
			set @Resultado = 0
			Return
		end
end
go

-- Ver Super Poderes por SuperHeroe
create or alter procedure SP_ObtenerSuperPoderes
	@IdSuperHeroe int,
	@Mensaje nvarchar(255) output,
	@Resultado int output
as
begin
	select
	shsp.IdSuperHeroe_SuperPoder,
	sp.IdSuperPoder,
	sp.Descripcion
	from SuperHeroe_SuperPoder shsp
	inner join SuperPoderes sp on shsp.IdSuperPoder = sp.IdSuperPoder
	where shsp.IdSuperHeroe = @IdSuperHeroe
end
go

-- Insertar SuperPoder a un SuperHeroe
create or alter procedure SP_InsertarSuperPoderASuperHeroe
	@IdSuperHeroe int,
	@IdSuperPoder int,
	@Mensaje nvarchar(255) output,
	@Resultado int output
as
begin
	begin try
		insert into SuperHeroe_SuperPoder (IdSuperHeroe, IdSuperPoder)
		values (@IdSuperHeroe, @IdSuperPoder)
		set @Mensaje = 'Superpoder insertado correctamente'
		set @Resultado = 1
	end try
	begin catch
		set @Mensaje = 'Error al insertar el superpoder al superheroe'
		set @Resultado = 0
	end catch
end
go
		

