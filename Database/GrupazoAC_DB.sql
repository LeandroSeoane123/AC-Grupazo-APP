Drop database if exists GrupazoAC_DB;
Create database GrupazoAC_DB;
Use GrupazoAC_DB;

CREATE TABLE Roles(
	RolUsu INT,
	NomRol VARCHAR(30),
	CONSTRAINT PRIMARY KEY(RolUsu)
)ENGINE=INNODB;

insert into Roles values
(1,'Administrador'),
(2,'Empleado');

CREATE TABLE Usuario (
	CodUsu INT AUTO_INCREMENT,
    NomUsuario VARCHAR(50) NOT NULL,
    Pass VARCHAR(50) NOT NULL,
    RolUsu INT,
	Activo BOOLEAN DEFAULT TRUE,
	CONSTRAINT pk_usuario PRIMARY KEY (CodUsu),
	CONSTRAINT fk_usuario FOREIGN KEY(RolUsu) REFERENCES Roles(RolUsu)
)ENGINE=INNODB;

insert into Usuario values
(1,'MartinComito','123456',1,true),
(2,'LeandroSeoane','123456',1,true),
(3,'LucreciaPedraza','123456',1,true),
(4,'CamilaCuns','123456',1,true),
(5,'PabloCombis','123456',1,true);

CREATE TABLE Cliente (
    dni VARCHAR(20) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    fecha_nacimiento VARCHAR(20) NOT NULL,
    telefono VARCHAR(20),
    email VARCHAR(100),
    tipo_cliente VARCHAR(10) NOT NULL CHECK (tipo_cliente IN ('SOCIO', 'NO SOCIO'))
)ENGINE=INNODB;
insert into Cliente values(41668660,'Leandro','Seoane', '1999-01-24','1140560102','leandromseoane@gmail.com', "Socio");
insert into Cliente values(40561562,'Lucrecia','Pedraza', '1995-06-10','1156478294','lupedraza@gmail.com', "No socio");
insert into Cliente values(36564812,'Martin','Comito', '1993-05-07','1156812354','martincomito@gmail.com', "Socio");
insert into Cliente values(40564923,'Camila','Cuns', '1998-03-17','114200368741','milacuns@gmail.com', "Socio");
insert into Cliente values(35681234,'Pablo','Combis', '1990-09-30','1126543790','pablocombis@gmail.com', "Socio");

-- Tabla "Socio"
CREATE TABLE Socio (
    dni VARCHAR(20) PRIMARY KEY,
    numero_socio INT UNIQUE NOT NULL ,
    fecha_ingreso DATE NOT NULL,
    numero_carnet INT UNIQUE NOT NULL,
    FOREIGN KEY (dni) REFERENCES Cliente(dni)
)ENGINE=INNODB;
insert into Socio values(41668660, 1, '2022-05-15', 51);
insert into Socio values(36564812, 2, '2022-05-16', 52);
insert into Socio values(40564923, 3, '2022-05-16', 53);
insert into Socio values(35681234, 4, '2022-05-17', 54);

-- Tabla "NoSocio"
CREATE TABLE NoSocio (
    dni VARCHAR(20) PRIMARY KEY,
    ultima_visita DATE,
    FOREIGN KEY (dni) REFERENCES Cliente(dni)
)ENGINE=INNODB;
insert into NoSocio values (40561562, '2024-10-15');

-- Tabla "Actividad"
CREATE TABLE Actividad (
    id INT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    precio VARCHAR(32) NOT NULL,
    cupo INT NOT NULL
)ENGINE=INNODB;
insert into Actividad values(1, 'Futbol', '1500', 10);
insert into Actividad values(2, 'Hockey', '1500', 10);
insert into Actividad values(3, 'Basket', '1000', 7);
insert into Actividad values(4, 'Volley', '2000', 4);
insert into Actividad values(5, 'Tenis', '3500', 2);
insert into Actividad values(6, 'Handball', '3000', 15);
insert into Actividad values(7, 'Natacion', '4000', 9);

-- Tabla "Cuota"
CREATE TABLE Cuota (
    id INT PRIMARY KEY,
    fecha VARCHAR(20) NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    estado VARCHAR(20) NOT NULL,
    dni_socio VARCHAR(20) NOT NULL,
    forma_de_pago VARCHAR(20) NOT NULL,
    fecha_vencimiento VARCHAR(20) NOT NULL,
    FOREIGN KEY (dni_socio) REFERENCES Socio(dni)
)ENGINE=INNODB;
insert into Cuota values(1, '2024-10-16', '2500', 'No paga', '41668660', 'Efectivo', '2024-11-17');
insert into Cuota values(2, '2024-10-16', '2500', 'Al dia', '36564812', 'Efectivo', '2024-11-17');
insert into Cuota values(3, '2024-10-16', '2500', 'No paga', '40564923', 'Efectivo', '2024-11-17');
insert into Cuota values(4, '2024-10-16', '2500', 'Al dia', '35681234', 'Efectivo', '2024-12-17');

-- Tabla de relación entre "Socio" y "Actividad"
CREATE TABLE Socio_Actividad (
    dni_socio VARCHAR(20),
    id_actividad INT,
    fecha_inscripcion DATE NOT NULL,
    PRIMARY KEY (dni_socio, id_actividad),
    FOREIGN KEY (dni_socio) REFERENCES Socio(dni),
    FOREIGN KEY (id_actividad) REFERENCES Actividad(id)
)ENGINE=INNODB;
insert into Socio_Actividad values(41668660, 1, '2024-09-5');

-- Tabla de relación entre "NoSocio" y "Actividad"
CREATE TABLE NoSocio_Actividad (
    dni_no_socio VARCHAR(20),
    id_actividad INT,
    fecha_inscripcion DATE NOT NULL,
    estado_cuota VARCHAR(30),
    forma_pago VARCHAR(20) NOT NULL,
	PRIMARY KEY (dni_no_socio, id_actividad),
    FOREIGN KEY (dni_no_socio) REFERENCES NoSocio(dni),
    FOREIGN KEY (id_actividad) REFERENCES Actividad(id)
)ENGINE=INNODB;
insert into NoSocio_Actividad values(40561562, 2, '2024-08-8', 'No paga', "Tarjeta");

delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

begin
  
  select NomRol
	from Usuario u inner join Roles r on u.RolUsu = r.RolUsu
		where u.NomUsuario = Usu and u.Pass = Pass 
			and Activo = true; 

end
//

create procedure NuevoCliente(in Dni varchar(20), in Nom varchar(50),in Ape varchar(50), in Nacimiento varchar(20) , in Tel varchar(20), in Email varchar(100), in Tipo_c varchar(10))

begin

    declare dniAux int default 0;
    set dniAux = (select dni from Cliente as c where c.dni = Dni);
    
    if dniAux = Dni then
        select "EL SOCIO YA FUE REGISTRADO";
    else
		insert into Cliente values(Dni, Nom, Ape, Nacimiento, Tel, Email, Tipo_c);
    end if;
      
 end //

create procedure NuevoSocioONoSocio(in Dni varchar(20), in Tipo_c varchar(10))
begin

	declare numSoc int;
    declare numCar int;
    declare idCuotaAux int;
    
    Select ifnull(max(numero_socio), 0) + 1 into numSoc from Socio;
    set numCar = numSoc+50;
    
    Select ifnull(max(id), 1) + 1 into idCuotaAux from Cuota;

	if Tipo_c = "Socio" then
				insert into Socio values(Dni, numSoc, CURDATE(), numCar);
				insert into Cuota values (idCuotaAux, CURDATE(), '2500', 'No paga', Dni, 'Por definir', DATE_ADD(CURDATE(), INTERVAL 1 MONTH));
			else
				if Tipo_c = "No socio" then
                insert into NoSocio values(Dni, CURDATE());
                end if;
            end if;
end//

create procedure AsignarActividad(in nombreAct VARCHAR(100), in dniCliente VARCHAR(20))
begin
	
    declare idActAux int;
    declare dniSocAux int default 0;
    declare dniNoSocAux int default 0;
    declare cupoAux int;
    declare tipo_c varchar(20);
    
    set idActAux = (select a.id from Actividad as a where a.nombre = nombreAct);
    set cupoAux = (Select a.cupo from Actividad as a where idActAux = a.id);
    set dniSocAux = (Select dni_socio from Socio_Actividad where id_actividad = idActAux AND dni_socio = dniCliente);
    set dniNoSocAux = (Select dni_no_socio from NoSocio_Actividad where id_actividad = idActAux AND dni_no_socio = dniCliente);
    
    if (select exists (select 1 from cliente where dni = dniCliente)) then
		if(select exists(select 1 from Socio as s where s.dni = dniCliente)) then
		set tipo_c = "Socio";
			else
            set tipo_c = "No socio";
		end if;
		if (dniCliente = dniSocAux OR dniCliente = dniNoSocAux) then
			Select "El cliente ya esta registrado en esa actividad.";
			else
				if (cupoAux = 0) then
				Select "No hay cupos suficientes en la actividad seleccionada.";
					else
						if(tipo_c = "Socio") then
						insert into Socio_Actividad values (dniCliente, idActAux, curdate());
						update Actividad set cupo = cupo-1 where id = (select id from (select id from Actividad where nombre = nombreAct)as temp);
							else
							insert into NoSocio_Actividad values (dniCliente, idActAux, curdate(), 'No paga', "Por definir");
							update Actividad set cupo = cupo-1 where id = (select id from (select id from Actividad where nombre = nombreAct)as temp);
						end if;
				end if;
		end if;
        
        else
        Select "El dni ingresado no corresponde a un cliente registrado.";
    end if;

end//

create procedure PagarCuota(in dniSocio VARCHAR(20), in formaDePago VARCHAR(20), in montoAPagar VARCHAR(20), in fechaVencimiento VARCHAR(20))
begin
	
    Update Cuota set estado = "Al dia" where dni_socio = dniSocio;
    Update Cuota set forma_de_pago = formaDePago where dni_socio = dniSocio;
    Update Cuota set monto = montoAPagar where dni_socio = dniSocio; 
    update Cuota set fecha = CURDATE() where dni_socio = dniSocio;
    update Cuota set fecha_vencimiento = fechaVencimiento where dni_socio = dniSocio;
    
end//

create procedure PagarActividad(in dniNoSocio VARCHAR(20), in formaDePago VARCHAR(20), in nombreActividad VARCHAR(100))
begin
	
    Update NoSocio_Actividad set estado_cuota = 'Al dia' where dni_no_socio = dniNoSocio;
    Update NoSocio_Actividad set forma_pago = formaDePago where dni_no_socio = dniNoSocio; 
    
end//

Create procedure listarSociosCuotaVencida()
begin
	
    Select CONCAT(c.nombre, ' ', c.apellido) as "Nombre", c.dni as "DNI", s.numero_socio as "N° socio", cu.fecha_vencimiento as "Vencimiento", CONCAT('$',cu.monto) as "Monto adeudado"
    From Cuota as cu inner join Socio as s on cu.dni_socio = s.dni 
					 inner join Cliente as c on s.dni = c.dni
                     where cu.fecha_vencimiento <= curdate();
			
end//
