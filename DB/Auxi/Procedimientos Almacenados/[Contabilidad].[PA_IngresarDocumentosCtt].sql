
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Contabilidad].[PA_IngresarDocumentosCtt]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [Contabilidad].[PA_IngresarDocumentosCtt]
GO

CREATE PROCEDURE [Contabilidad].[PA_IngresarDocumentosCtt]  
		@Operacion			VARCHAR(12)		=NULL
		,@Consecutivo		VARCHAR(12)		= NULL
		,@Fuente			VARCHAR(4)		= NULL
		,@Fecha				DATETIME		= NULL
		,@NotaAclaratoria	VARCHAR(MAX)  = NULL		
AS
BEGIN
	IF @Operacion = 'SD'
	BEGIN
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
		WHERE	accGLMAS.Masfte= @Fuente 
				AND accGLMAS.Masdoc=  @Consecutivo   AND Masfec = @Fecha
				AND accGLMAS.Masdeb>0 			
		UNION ALL
		SELECT	accglmas.Mascod				Codigo	
				,ISNULL(accglpuc.glnum,'')	Cuenta 					
				,ISNULL(accGLMAS.masdet,'')	Detalle
				,ISNULL(procencos.ccocod,'')Ccosto	
				,ISNULL(procencos.cconom,'')DesCcosto
				,ISNULL(accglTer.ternit,'')	Tercero 
				,ISNULL(accglTer.ternom,'')	NomTercero 
				,0							Debe 
				,accglmas.Mashbr			Haber 
				,accglpuc.glcct				RCcosto
				,accglmas.MasOT				OT
				,ordenes.ordnom             DetOT
		FROM	accGLMAS 
				LEFT JOIN accglter		ON accglTer.tercod   = accGLMAS.Master
				LEFT JOIN procencos		ON procencos.ccocod	 = accglmas.Mascco
				LEFT JOIN accglpuc		ON accglPUC.glcod	 = accGLMAS.Mascod
				LEFT JOIN ordenes       ON ordenes.ordnro    = accGLMAS.MasOT
		WHERE	accGLMAS.Masfte=  @Fuente 
				AND accGLMAS.Masdoc=  @Consecutivo 
				AND accGLMAS.Mashbr>0   AND Masfec = @Fecha		
		ORDER BY accglmas.Mascod
	END	
END
