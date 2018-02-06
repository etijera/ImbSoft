
-- Contabiliodad, asientos movimientos
select * from accglmas

-- Cuentas por pagar
select * from acccpcxp

-- Cuentas por cobrar
select * from acccccxc

-- Configuracion
select * from ne_gl_cfg
select * from gl_cfg
select * from Si_cfg
select * from TipoTercero
select * from Tercero_TipoTercero
select * from TipoConceptos
select * from tipodocumento
select * from profuentes
select * from proTipoEgreso


-- Plan de cuentas 
SELECT * FROM accglPUC where glRetTipo = 3
select * from Puc_Clasificacion
select * from Puc_Clasificacion_Det



select * from ClasificacionTer

select * from profuentes
select * from ACCGLRETENCION

select * from procencos

select * from Departamentos
select * from Ciudades


select * from Paises
select * from ImbZonas

select * from Bancos



SELECT glcod Codigo,glnum Nombre,glbal Balance,glter Tercero, glRetTipo  AS TipoRetencion
FROM accglPUC 

select Det_codigo AS CodigoClasificacion, Det_Puc AS CodigoPuc from Puc_Clasificacion_Det


SELECT  accglmas.Mascod				Codigo	
				,ISNULL(accglpuc.glnum,'')	Cuenta 					
				,ISNULL(accGLMAS.masdet,'')	Detalle
				,ISNULL(procencos.ccocod,'')Ccosto	
				,ISNULL(procencos.cconom,'')DesCcosto
				,ISNULL(accglTer.ternit,'')	Tercero 
				,ISNULL(accglTer.ternom,'')	NomTercero 
				,accglmas.masdeb			Debe 
				,0							Haber 
				,accglpuc.glcct				RCcosto
				,accglmas.MasOT				OT
				,ordenes.ordnom             DetOT
		FROM	accGLMAS
				LEFT JOIN accglter		ON accglTer.tercod   = accGLMAS.Master
				LEFT JOIN procencos		ON procencos.ccocod	 = accglmas.Mascco
				LEFT JOIN accglpuc		ON accglPUC.glcod	 = accGLMAS.Mascod
				LEFT JOIN ordenes       ON ordenes.ordnro    = accGLMAS.MasOT
		WHERE	accGLMAS.Masdeb>0 



SELECT * FROM accglUsuarios
SELECT * FROM ProTipoUsuarios


en el perfilador agregarle el esquema 