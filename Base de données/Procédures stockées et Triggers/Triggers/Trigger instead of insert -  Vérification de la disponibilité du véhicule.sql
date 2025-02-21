USE [GSB-Admin]
GO
/****** Object:  Trigger [dbo].[verifAdd_Voiture]    Script Date: 01/12/2019 13:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[verifAdd_Voiture] on [dbo].[utiliser]
INSTEAD OF INSERT

AS
BEGIN
-- DECLARATION DE NOS VARIABLES
------------------------------------------------------------------------------------
DECLARE @immat as varchar(50) -- Pour récupérer l'immatriculation
DECLARE @dateDebut as date
DECLARE @id as int
DECLARE @dateFin as date

DECLARE @IntervalleProc as int -- Permet d'obtenir l'intervalle l'intervalle entre la date de debut et de fin envoyé 
DECLARE @IntervalleWhile int --Permet d'obtenir l'intervalle entres la date de fin et de début de chaque utilisation dans la boucle
DECLARE @OldDateDeFinWhile as date --Conseve la date de fin de la valeur x-1 du while
DECLARE @DateDeFinWhile as date --Nécessaire à la boucle WHILE
DECLARE @DateDebutWhile as date --Nécessaire à la boucle WHILE

SELECT @dateDebut = dateDebut, @immat = immat, @id = id, @dateFin = dateFin FROM inserted;
------------------------------------------------------------------------------------


-- SI UNE VOITURE EST EN COURS D'UTILISATION ON NE FAIT RIEN ET ON ANNULE L'INSERTION / UPDATE
-------------------------------------------------------------------------------------------
IF EXISTS(SELECT * FROM utiliser WHERE immat = @immat AND dateFin >= @dateDebut) -- On effectue un test avant la boucle
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

			-- On vérifie que cet intervalle est assez grand pour acceuillir l'emprunt de la voiture en cours
			IF @IntervalleWhile >= 2 + @IntervalleProc
			BEGIN

				-- On insére dans utiliser un des créneaux qui as été trouvé
				INSERT INTO utiliser VALUES(@immat, DATEADD(day, 1, @OldDateDeFinWhile) ,@id, DATEADD(day, 1 + @IntervalleProc, @OldDateDeFinWhile))
				print CONCAT('La date du ', @dateDebut, ' jusqu''au ', @dateFin, ' soit pour ', @IntervalleProc, ' jours, as été insérer du ',
				DATEADD(day, 1, @OldDateDeFinWhile), ' au ', DATEADD(day, 1 + @IntervalleProc, @OldDateDeFinWhile), 
				' pour le véhicule immatriculé ', @immat)

				CLOSE Date_Cursor;  -- Fermeture du curseur
				DEALLOCATE Date_Cursor;  
				RETURN --On arrête la procédure stockée puisque un intervalle a été trouvé 

			END

		-- ON met à jour la variable de fin qui correspondra à la valeur x-1 de la boucle
		SET @OldDateDeFinWhile = @DateDeFinWhile

		FETCH NEXT FROM Date_Cursor INTO @DateDebutWhile, @DateDeFinWhile;  -- On passe à la ligne suivante
	   END;  

	CLOSE Date_Cursor;  -- Fermeture du curseur
	DEALLOCATE Date_Cursor;  
	-- FIN TRAITEMENT WHILE
	-------------------------------------------------------------------------------------------

	--On insére dans utiliser le dernier créneau 
	INSERT INTO utiliser VALUES(@immat, DATEADD(day, 1, @DateDeFinWhile) ,@id, DATEADD(day, 1 + @IntervalleProc, @DateDeFinWhile))

	print CONCAT('La date du ', @dateDebut, ' jusqu''au ', @dateFin, ' soit pour ', @IntervalleProc, ' jours, as été insérer du ',
	DATEADD(day, 1, @DateDeFinWhile), ' au ', DATEADD(day, 1 + @IntervalleProc, @DateDeFinWhile), ' pour le véhicule immatriculé ', @immat)

	RETURN --On arrête la procédure stockée puisque un intervalle a été trouvé  
END	
-------------------------------------------------------------------------------------------

-- DEBUT ELSE
ELSE -- Si on est dans ce cas, alors la voiture est disponible
	BEGIN 

		-- On insére ici dans utiliser les valeurs envoyés qui sont valides
		INSERT INTO utiliser VALUES(@immat, @dateDebut, @id, @dateFin)
		print CONCAT('La date du ', @dateDebut, ' jusqu''au ', @dateFin, ' as été attribué avec succés pour le véhicule immatriculé ', @immat)

	END
	-- FIN ELSE
	-------------------------------------------------------------------------------------------

END