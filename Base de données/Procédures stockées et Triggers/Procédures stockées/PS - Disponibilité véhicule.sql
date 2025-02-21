USE [GSB-Admin]
GO
/****** Object:  StoredProcedure [dbo].[verifAdd_VoitureForVisiteur]    Script Date: 01/12/2019 17:07:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Cette procédure stockée permet d'insérer un utilisateur en le liant avec une voiture
-- Vérifie que la voiture n'est pas en cours d'utilsiation

ALTER PROC [dbo].[verifAdd_VoitureForVisiteur]
--- PARAMETRES NECESSAIRE A L'APPEL DE LA PROCEDURE
------------------------------------------------------------------------------------

-- Paramètres permettant la vérification
@immat varchar(20),
@dateDebut date,
@dateFin date
------------------------------------------------------------------------------------

AS
BEGIN

DECLARE @IntervalleProc as int -- Permet d'obtenir l'intervalle l'intervalle entre la date de debut et de fin envoyé 
DECLARE @IntervalleWhile int --Permet d'obtenir l'intervalle entres la date de fin et de début de chaque utilisation dans la boucle
DECLARE @OldDateDeFinWhile as date --Conseve la date de fin de la valeur x-1 du while
DECLARE @DateDeFinWhile as date --Nécessaire à la boucle WHILE
DECLARE @DateDebutWhile as date --Nécessaire à la boucle WHILE
DECLARE @Message varchar(100) -- Contient un message personnalisé destinée au retour de la procédure




-------------------------------------------------------------------------------------------
-- SI UNE VOITURE EST EN COURS D'UTILISATION ALORS ON LUI RETOURNE QUAND IL POURRA L'UTILISER
IF EXISTS(SELECT * FROM utiliser WHERE immat = @immat AND dateFin >= @dateDebut) 
BEGIN


	DECLARE Date_Cursor CURSOR FOR  -- On déclare ici notre curseur sur notre requête SQL suivante
	SELECT dateDebut, dateFin FROM utiliser WHERE immat = @immat AND dateFin >= @dateDebut ORDER BY dateFin;  

	-- On récupére ici l'intervalledes des dates envoyés (en jour pour être précis) à l'appel de la procédure pour la suite des tests
	SET @IntervalleProc = DATEDIFF(day, @dateDebut, @dateFin)

	-------------------------------------------------------------------------------------------
	-- DEBUT TRAITEMENT WHILE
	OPEN Date_Cursor;  -- On ouvre ici le curseur
	FETCH NEXT FROM Date_Cursor INTO @DateDebutWhile, @DateDeFinWhile;  --On insére les valeurs de la première ligne dans cette variable

	WHILE @@FETCH_STATUS = 0  
	   BEGIN  

			   --On récupére l'intervalle entres l'ancienne et la date de début suivante
		SET @IntervalleWhile = DATEDIFF(day, @OldDateDeFinWhile, @DateDebutWhile) 
		print CONCAT('Intervalle entres les deux eprunts déjà présentes ', @IntervalleWhile)

			-- On vérifie que cet intervalle est assez grand pour acceuillir l'emprunt de la voiture en cours
			IF @IntervalleWhile >= 2 + @IntervalleProc
			BEGIN

				-- Création du message personalisé
				SET @Message = CONCAT('La voiture pourra être emprunté le ' , 
				DATEADD(day, 1, @OldDateDeFinWhile) ,' pour ', @IntervalleProc , ' jours' )

				SELECT 0 as Num, 
				@Message as MessageSend, 
				DATEADD(day, 1, @OldDateDeFinWhile) as Date_Debut_Valide, 
				DATEADD(day, 1 + @IntervalleProc, @OldDateDeFinWhile) as Date_Fin_Valide;
				
				CLOSE Date_Cursor;  -- Fermeture du curseur
				DEALLOCATE Date_Cursor;  
				RETURN --On arrête la procédure stockée puisque un intervalle a été trouvé 

			END

		-- ON met à jour la variable de fin qui correspondra à la valeur x-1 de la boucle
		SET @OldDateDeFinWhile = @DateDeFinWhile
		print CONCAT('Anciennce date de fin ', @OldDateDeFinWhile)

		FETCH NEXT FROM Date_Cursor INTO @DateDebutWhile, @DateDeFinWhile;  -- On passe à la ligne suivante
	   END;  

	CLOSE Date_Cursor;  -- Fermeture du curseur
	DEALLOCATE Date_Cursor;  
	-- FIN TRAITEMENT WHILE
	-------------------------------------------------------------------------------------------

	
	SET @Message =  CONCAT('La voiture ne sera disponible qu''à partir du ' , DATEADD(day, 1, @DateDeFinWhile))

	SELECT 0 as Num, 
	@Message as MessageSend, 
	DATEADD(day, 1, @DateDeFinWhile) as Date_Debut_Valide,
	DATEADD(day, 1 + @IntervalleProc, @DateDeFinWhile) as Date_Fin_Valide;;
	RETURN --On arrête la procédure stockée puisque un intervalle a été trouvé 

END	
-- FIN IF
-------------------------------------------------------------------------------------------


-------------------------------------------------------------------------------------------
-- DEBUT ELSE
ELSE -- Si on est dans ce cas, alors la voiture est disponible
	BEGIN 
		SET @Message = CONCAT('La voiture ', @immat , ' peut bien été attribuée pour le ', @dateDebut) --On affiche le message
		SELECT 1 as Num, 
		@Message as MessageSend, 
		@dateDebut as Date_Debut_Valide,
		@dateFin as Date_Fin_Valide;;
	END
	-- FIN ELSE
	-------------------------------------------------------------------------------------------

END

