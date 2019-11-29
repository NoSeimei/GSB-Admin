-- Cette procédure stockée permet d'insérer un utilisateur en le liant avec une voiture
-- Vérifie que la voiture n'est pas en cours d'utilsiation

CREATE PROC verifAdd_VoitureForVisiteur
--- PARAMETRES NECESSAIRE A L'APPEL DE LA PROCEDURE
------------------------------------------------------------------------------------

-- Paramètres permettant la vérification
@immat nvarchar(20),
@dateDebut date
------------------------------------------------------------------------------------

AS
BEGIN

DECLARE @Message varchar(50)

-- SI UNE VOITURE EST EN COURS D'UTILISATION ON NE FAIT RIEN
-------------------------------------------------------------------------------------------
IF EXISTS(SELECT * FROM utiliser WHERE immat = @immat AND dateFin >= @dateDebut) -- On effectue un test avant la boucle
BEGIN
	SET @Message =  'La voiture choisie n''est pas disponible' -- Si on est dans ce cas, alors la voiture n'est pas disponible
	SELECT 0, @Message;
END	
ELSE -- Si on est dans ce cas, alors la voiture est disponible
	BEGIN 
		SET @Message = 'La voiture ' + @immat + ' peut bien été attribuée' --On affiche le message
		SELECT 1, @Message;
	END
END
