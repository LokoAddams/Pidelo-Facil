--Update ciudad Separada -LaPaz- es diferente a -La Paz-
update Entidad set PaisyCiudad='Santa Cruz,Bolivia' where PaisyCiudad like 'SantaCruz,Bolivia' 
go
--generando json para usar IA para llenar datos de la tablas
SELECT *
FROM ObjetoVenta
FOR JSON AUTO;
go


declare @id int=1
while @id<=1044
begin
insert into Producto(codProducto)
values (@id)
set @id=@id+1
end
go


declare @id int=2129
while @id<=5046
begin
insert into Negocio(codNegocio)
values (@id)
set @id=@id+1
end
go

declare @id int=5047
while @id<=6046
begin
insert into Cliente(codCliente)
values (@id)
set @id=@id+1
end
go

declare @id int=6047
while @id<=7046
begin
insert into Cliente(codCliente)
values (@id)
set @id=@id+1
end
go

declare @id int=8047
while @id<=9046
begin
insert into Cliente(codCliente)
values (@id)
set @id=@id+1
end

go


declare @id int=2048
while @id<=3049
begin
insert into Producto(codProducto)
values (@id)
set @id=@id+1
end
go


--Llenando pedidos y otros
declare @id int=1047,
@idNegocio int=2047
while @id<=9046 and @idNegocio<=17046
begin
insert into Pedido(codCliente,codNegocio)
values (@id,@idNegocio)
set @id=@id+1
set @idNegocio=@idNegocio+1
end
go

--Registrando mas productos dentro de un mismo negocio

--actualizar Negocio con categorias aleatorias
declare @id int=2047
while @id<=5000
begin
insert into Negocio(codNegocio,categoria) values(@id,'Salud y bienestar')
set @id=@id+2
end
go
--Obtener ultimo idAutonumerico
alter PROCEDURE Sp_NombreProcedimiento
    @tabla_nombre sysname,
    @atributo_nombre sysname
AS
BEGIN
    DECLARE @sql_query nvarchar(max);

    SET @sql_query = 'SELECT ' + QUOTENAME(@atributo_nombre) + ' FROM ' + QUOTENAME(@tabla_nombre)
					+' WHERE ' + QUOTENAME(@atributo_nombre) + '>=all('+ 
					'SELECT ' + QUOTENAME(@atributo_nombre) + ' FROM ' + QUOTENAME(@tabla_nombre)+ ')';

    EXEC sp_executesql @sql_query;
END;

execute Sp_NombreProcedimiento 'Pedido','codPedido'
go

--probando insert into
insert into Pedido(codCliente,codNegocio) values(23,25)
go
insert into Horarios(codProveedor,dia,horaInicio,horaFin) values(25,'lunes','4 pm','6 pm')
go

--obtener ObjetoVenta segun negocio
create procedure sp_obtenerPromosSegunNegocio
@id int as
begin
select o.*,p.*
from ObjetoVenta o,Negocio n,Promocion p
where o.codNegocio=n.codNegocio and p.codPromocion=o.codObjetoVenta
		and @id=o.codNegocio
end
go

execute sp_obtenerPromosSegunNegocio 25
go
--obtener todos los negocios
alter procedure sp_NegociosSegunCliente 
@idCliente int as
begin
declare @ciudadyPaisCliente char(50)
select @ciudadyPaisCliente=e.PaisyCiudad
from Cliente c,Entidad e
where codCliente=@idCliente and c.codCliente=e.codEntidad
select e.codEntidad,e.nombre,e.celular,e.puntuacion,e.Email
from Entidad e,Negocio n
where e.codEntidad=n.codNegocio and @ciudadyPaisCliente=e.PaisyCiudad
end

execute sp_NegociosSegunCliente  23
go
--obtener solo productos segun negocio
alter procedure sp_obtenerProductosSegunNegocio
@idNegocio int
as
begin
select o.codObjetoVenta,o.nombre
from Negocio n,ObjetoVenta o,Producto p
where o.codObjetoVenta=p.codProducto and n.codNegocio=o.codNegocio and @idNegocio=n.codNegocio
end
go
execute sp_obtenerProductosSegunNegocio 25
go

--filtrar pais y ciudad
create procedure sp_filtrarPorPaisyCiudad 
@PaisyCiudad char(50)
as 
begin
select *
from Entidad
where PaisyCiudad=@PaisyCiudad
end
go
--clientes
create procedure sp_Clientes
as
begin
select *
from Cliente
end

go
--Repartidores
create procedure sp_Repartidores
as
begin
select *
from Repartidor
end
go
--Negocios
create procedure sp_Negocioss
as
begin
select *
from Negocio
end
go
--buscar cliente
create procedure sp_buscarCliente
@id int
as
begin
select *
from Cliente
where codCliente=@id
end

execute sp_buscarCliente 23
go
--buscar negocio
create procedure sp_buscarNegocio
@id int
as
begin
select *
from Negocio
where codNegocio=@id
end

execute sp_buscarNegocio 25
go
--buscar repartidor
create procedure sp_buscarRepartidor
@id int
as
begin
select *
from Repartidor
where CodRepartidor=@id
end

execute sp_buscarRepartidor 32
go
execute sp_filtrarPorPaisyCiudad 'Cochabamba,Bolivia'
go
create procedure sp_recuperarUltimoId as
begin
DECLARE @IdEntidad INT;
SET @IdEntidad = SCOPE_IDENTITY();
end
execute sp_recuperarUltimoId
go

insert into Entidad(nombre) values('Chingada')
DECLARE @IdEntidad INT;
SET @IdEntidad = SCOPE_IDENTITY(); 
insert into Proveedor(codProveedor) values(@IdEntidad)

go

create procedure sp_nombreCliente 
@nombre char(50) as
begin
select c.*
from Cliente c
where c.nombre=@nombre
end
execute sp_nombreCliente 'Juan Perez'
go
--MUY IMPORTANTE HACER QUE EL PRECIO DE PRODUCTO CONINCIDA
--CON UN PRECIO UNITARIO DE DETALLE PEDIDO

--1
--obtener la cantidad de pedidos por cada cliente
create procedure sp_cantPedidosPorCliente as
begin
select c.codCliente,count(*) as pedidos
from Cliente c,Pedido p
where c.codCliente=p.codCliente
group by c.codCliente
end
go
--2
--obtener la cantidad de productos DIFERENTES por cada pedido
create procedure sp_cantProdDifPorPedido as
begin
select codPedido,count(distinct codProducto) as productos
from DetallePedido
group by codPedido
end
go

--3
--obtener el precio total de cada pedido
create procedure sp_precioTotalPorPedido as
begin
select codPedido,sum(precio) as Total
from DetallePedido
group by codPedido
end
go
--4
--obtener la cantidad de productos de cada negocio
create procedure sp_cantProdPorNegocio as
begin
select p.codNegocio,count(*) as productos
from ObjetoVenta p
group by p.codNegocio
end
go

--5
--obtener todas las posibles combinaciones de pedidos que 
--tengan un producto en comun
create procedure sp_parejasPediConProdComun as
begin
select distinct dp4.codPedido,dp2.codPedido
from DetallePedido dp4,DetallePedido dp2
where dp4.codProducto=dp2.codProducto and dp4.codPedido<>dp2.codPedido
end
go

select distinct dp4.codPedido,dp2.codPedido
from DetallePedido dp4,DetallePedido dp2
where dp4.codPedido<>dp2.codPedido 
		and dp4.codProducto=any(select dp3.codProducto
								from DetallePedido dp3
								where dp3.codPedido=dp2.codPedido)
go
--6
--obtener la cantidad de productos de un pedido
--sin importar si son DIFERENTES
create procedure sp_cantProdPorPed2 as
begin
select dp.codPedido,sum(dp.cantidad) as productos
from DetallePedido dp
group by dp.codPedido
end
go

--7
--obtener todas las posibles combinaciones de pedidos que 
--no tengan productos en comun
create procedure sp_parejasSinProdComun as
begin
select distinct dp4.codPedido,dp2.codPedido
from DetallePedido dp4,DetallePedido dp2
where dp4.codPedido<>dp2.codPedido and dp4.codPedido<>all(select dp3.codProducto
							from DetallePedido dp3
							where dp2.codPedido=dp3.codPedido)
end
go
--8
--obtener todos los pedidos que tengan los productos de 
--la comida
create procedure sp_ProdCategoComida as
begin
select distinct dp.codPedido
from DetallePedido dp
where not exists(select *
					from Producto p
					where p.categoria='comida' and p.codProducto 
					not in(select p1.codProducto
							from Producto p1,DetallePedido dp2
							where dp.codPedido=dp2.codPedido
							and p1.codProducto=dp2.codProducto))
end
go
--9
--obtener todos los clientes que hayan alguna vez hecho un pedido a un negocio
--de Categoria1
create procedure sp_ClientesPidieronComida as
begin
select distinct c.codCliente
from Cliente c,DetallePedido dp,Negocio n,Producto pro,Pedido pe,ObjetoVenta o
where pe.codCliente=c.codCliente and n.codNegocio=o.codNegocio and o.codObjetoVenta=pro.codProducto
		and dp.codPedido=pe.codPedido and n.categoria='comida' 
		and pro.codProducto=dp.codProducto
end
go

--10
--obtener los clientes que nunca hicieron un pedido
create procedure sp_clienteNuncaPidieron as
begin
select c.codCliente
from Cliente c
where not exists(select *
					from Pedido p
					where p.codCliente=c.codCliente)
end
go

--11
--obtener clientes con Inicial C
create procedure sp_clientesNombreConC as
begin
select c.codCliente
from Entidad e,Cliente c
where e.nombre like 'C%' and e.codEntidad=c.codCliente
end
go

--12
--obtener clientes con celular que inicie con 9
create procedure sp_celularIniciaNueve as
begin
select c.codCliente
from Cliente c,Entidad e
where e.celular like '9%' and c.codCliente=e.codEntidad
end
go

--13
--obtener todas las posibles combinaciones de productos
--con el mismo precio
create procedure sp_parejasCombConMismoPrecio as
begin
select distinct p1.codProducto,p2.codProducto
from Producto p1,Producto p2,ObjetoVenta o1,ObjetoVenta o2
where o1.precio=o2.precio and p1.codProducto<>p2.codProducto 
		and o1.codNegocio=p1.codProducto and o2.codObjetoVenta=p2.codProducto
end
go

--14
--obtener la cantidad de productos de Categoria1
create procedure sp_cantProdCategoComida as
begin
select count(*) as cantidad
from Producto
where categoria='comida'
end
go
--15
--obtener estadistico de cada pedido
create procedure sp_estadPorPedido as
begin
select dp.codPedido,sum(dp.precio) as precioTotal,max(dp.precio) as precioMax,
		count(*) as cantProductos
from DetallePedido dp,Pedido p
where dp.codPedido=p.codPedido
group by dp.codPedido
end
go

--16
--obtener el maximo de productos en un pedido
create procedure sp_maxProducPorPedido as
begin
select count(*) as maximo
from DetallePedido dp4
group by dp4.codPedido
having count(*)>=all(select count(*)
						from DetallePedido dp2
						group by dp2.codPedido)
end
go

--17
--obtener la cantidad de veces que Juan Perez hizo un pedido
create procedure sp_cantPedLucas as
begin
select count(*) as cantidad
from Pedido p,Cliente c,Entidad e
where p.codCliente=c.codCliente and e.nombre='Lucas' and e.codEntidad=c.codCliente
group by c.codCliente
end
go

--18
--obtener los clientes que pidieron un producto de Categoria1
--pero nunca pidieron uno de Categoria10
create procedure sp_clientesPidieronCat1NoCat2 as
begin
select distinct c.codCliente
from Cliente c,Pedido pe,Producto p,DetallePedido dp
where pe.codCliente=c.codCliente and p.categoria='comida' 
		and dp.codProducto=p.codProducto and pe.codPedido=dp.codPedido
except
select distinct c.codCliente
from Cliente c,Pedido pe,Producto p,DetallePedido dp
where pe.codCliente=c.codCliente and p.categoria='maquiellaje' 
		and dp.codProducto=p.codProducto and pe.codPedido=dp.codPedido
end
go

--19
--obtener el precio de pedido que mas se repite

select suma.total,count(*) as repeticiones
from (select dp4.codPedido,sum(precio) as total
					from DetallePedido dp4
					group by dp4.codPedido) as suma
group by suma.total
having count(*)>=all(select count(*) as repeticiones1
from (select dp31.codPedido,sum(precio) as total1
					from DetallePedido dp31
					group by dp31.codPedido) as suma
						group by suma.total1)
go
--20
--obtener el negocio que ofrece mas productos
create procedure sp_NegocioConMaxProductos as
begin
select n.codNegocio,count(*) as cantProduc
from ObjetoVenta p,Negocio n
where p.codNegocio=n.codNegocio
group by n.codNegocio
having count(*)>=all(select count(*)
						from ObjetoVenta p,Negocio n
						where p.codNegocio=n.codNegocio
						group by n.codNegocio)
end
go