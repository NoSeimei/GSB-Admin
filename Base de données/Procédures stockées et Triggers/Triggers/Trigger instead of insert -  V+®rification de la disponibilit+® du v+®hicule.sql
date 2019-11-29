CREATE TRIGGER verifAdd_Voiture on utiliser
INSTEAD OF INSERT

AS
BEGIN
-- DECLARATION DE NOS VARIABLES
------------------------------------------------------------------------------------
DECLARE @immat as varchar(50) -- Pour r�cup�rer l'immatriculation
DECLARE @dateDebut as date
DECLARE @id as int
DECLARE @dateFin as date
SELECT @dateDebut = dateDebut, @immat = immat, @id = id, @dateFin = dateFin FROM inserted;
------------------------------------------------------------------------------------


-- SI UNE VOITURE EST EN COURS D'UTILISATION ON NE FAIT RIEN ET ON ANNULE L'INSERTION / UPDATE
-------------------------------------------------------------------------------------------
IF EXISTS(SELECT * FROM utiliser WHERE immat = @immat AND dateFin >= @dateDebut) -- On effectue un test avant la boucle
BEGIN
	PRINT 'La voiture choisie n''est pas disponible' -- Si on est dans ce cas, alors la voiture n'est pas disponible
	RETURN -- On arr�te alors l'�x�cution de la requ�te SQL
END	

ELSE -- Si on est dans ce cas, alors la voiture est disponible
	BEGIN
		INSERT INTO utiliser VALUES(@immat, @dateDebut, @id, @dateFin) -- On ins�re alors les informations
		PRINT 'La voiture ' + @immat + ' a bien �t� attribu�e' --On affiche le message
	END
END