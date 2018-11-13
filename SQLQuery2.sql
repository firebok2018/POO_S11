use Negocios2018
create procedure usp_clientes
@nom varchar(50)
as
	select*from tb_clientes
	where NombreCia like @nom+'%'
go
exec usp_clientes 'm'
go

select*from tb_pedidoscabe

create procedure fechass
@year  int
as 
	select*from tb_pedidoscabe where year(FechaPedido )=@year

go

exec fechass 1998

select*from tb_paises

create proc usp_pais
as select*from tb_paises
go

exec usp_pais

create proc usp_addpais
@idpais char(3),@nompais varchar(40)
as insert tb_paises values (@idpais,@nompais)
go
exec usp_addpais 123,'asdasdsa'

create proc usp_updatepais
@idpais char(3), @nompais varchar(40) 
as update tb_paises 
set NombrePais=@nompais where Idpais=@idpais
go

create proc usp_delete
@id char(3)
as delete tb_paises where Idpais=@id
go

exec usp_delete 123


select*from tb_paises
select*from tb_clientes

create proc usp_addCliente
@idCli varchar(5),
@nombre varchar(60),
@direccion varchar(80),
@pais char(3),
@fono varchar (24)
as insert into tb_clientes
values (@idCli,@nombre,@direccion,@pais,@fono)
go

create proc usp_updateCliente
@idCli varchar(5),
@nombre varchar(60),
@direccion varchar(80),
@pais char(3),
@fono varchar (24)
as update tb_clientes 
set NombreCia=@nombre, Direccion=@direccion,idpais=@pais,Telefono=@fono
where IdCliente=@idCli
go

create proc usp_listClientes as
select*from tb_clientes
go

create proc usp_paises as select*from tb_paises go

exec sp_helptext 'usp_paises'