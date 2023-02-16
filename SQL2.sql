
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO, DESC_PRODUCTO) VALUES (10007, 'Jabones')

INSERT INTO CIUDAD (COD_CIUDAD, CODIGO_DPTO, DESCRIPCION_CIUDAD) VALUES (1001, 23, 'Cali')

INSERT INTO CLIENTES (ID_CLIENTE, NOMBRES, APELLIDOS, CARGO, MAIL, TIPO_IDENTIFICACION, DIRECCION, NUMERO_IDENTIFICACION, TELEFONO, CODIGO_CIUDAD, CODIGO_USUARIO) 
VALUES (7210844, 'Ramiro', 'Solano', 'Asesor', 'colombia@gmail.com', 'CC', 'Centro suba', 46673132, 3114587859, 1001, 45689)

INSERT INTO  DEPARTAMENTO (CODIGO_DPTO, DESCRIPCION_CPTO) VALUES (23, 'Valle del cauca')

INSERT INTO USUARIOS (CODIGO_USUARIO, USUARIO, CLAVE) VALUES (45689, 'SSOLANO', 'dfaASg12')

INSERT INTO VENTAS (ID_CLIENTE, COD_CIUDAD, CODIGO_PRODUCTO, FECHA_VENTA, VALOR_VENTA, CANTIDAD_PRODUCTO) VALUES (7210844, 1001, 10007, TO_DATE('2022-03-10 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), 750000, 6)



/* ################################################################################################################   */
/* ################################################################################################################   */
/* ################################################################################################################   */
Select 
    ID_CLIENTE , 
    NOMBRES ,
    APELLIDOS ,
    DIRECCION,
    DESCRIPCION_CIUDAD,
    USUARIO
From clientes cl , ciudad ciu , usuarios us
Where cl.codigo_ciudad = ciu.cod_ciudad
and cl.codigo_usuario = us.codigo_usuario
and tipo_identificacion = 'CC'
and numero_identificacion = '46673132';


/* ################################################################################################################   */   
/* ################################################################################################################   */
/* ################################################################################################################   */

select sum(count(1))
from ventas
group by id_cliente
having  sum(valor_venta) > 30000000
;

/* ################################################################################################################   */   
/* ################################################################################################################   */
/* ################################################################################################################   */


Select 
ve.ID_CLIENTE,
cli.NOMBREs,
cli.APELLIDOs,
ve.fecha_venta,
pr.desc_producto,
ve.valor_venta
From ventas ve , Clientes cli , productos pr
Where ve.id_cliente = cli.id_cliente
and ve.codigo_producto = pr.codigo_producto
and fecha_venta between to_date('01/10/2010','dd/mm/yyyy') and to_date('31/12/2010','dd/mm/yyyy')
;

/* ################################################################################################################   */   


ALTER TABLE CLIENTES 
ADD (CLASE VARCHAR2(50) );


update clientes cl
 set clase = 'ALTO'
 Where (Select sum(valor_venta)
        From ventas ve
        Where ve.id_cliente = cl.id_cliente) >= 200000;
		
		
update clientes cl
 set clase = 'ALTO'
 Where (Select sum(valor_venta)
        From ventas ve
        Where ve.id_cliente = cl.id_cliente) between 100000 and 199999;
		
		
		
update clientes cl
 set clase = 'BAJO'
 Where (Select sum(valor_venta)
        From ventas ve
        Where ve.id_cliente = cl.id_cliente) < 100000;
/* ################################################################################################################   */
/* ################################################################################################################   */
/* ################################################################################################################   */
/* ################################################################################################################   */


delete from ventas
where id_cliente in (Select id_cliente 
                    from clientes
                    Where clase = 'BAJO'
                    );
        
delete from clientes
where clase = 'BAJO';

/* ################################################################################################################   */
/* ################################################################################################################   */
/* ################################################################################################################   */