CREATE PROC rendre_Vehicule_Dispo
--- PARAMETRES NECESSAIRE A L'APPEL DE LA PROCEDURE
------------------------------------------------------------------------------------
@immat nvarchar(20) = NULL
------------------------------------------------------------------------------------

AS
BEGIN

-- DECLARATION DE NOS VARIABLES
------------------------------------------------------------------------------------
DECLARE @dateSys as date; -- Variables destiné à récupérer la date du système
SELECT @dateSys = CONVERT (date, SYSDATETIME()) ; -- Récupére la date du système
------------------------------------------------------------------------------------


-- DEBUT DU TRAITEMENT
IF @immat IS NOT NULL -- Si une valeur as été précisé alors on rend disponible le vahicule X
BEGIN
-- On rend le véhicule correspondant disponible!
UPDATE utiliser
SET dateFin = @dateSys
WHERE immat = @immat
AND dateFin IS NULL;

PRINT 'Le véhicule ayant pour immatriculation ' + @immat + ' est désormais disponible'
RETURN; -- On arrête l'éxécution de la procédure stockée
END;

ELSE
BEGIN
-- On rend ici tout les véhicules utilisés à ce jour disponibles!
UPDATE utiliser
SET dateFin = @dateSys
WHERE dateFin IS NULL;

PRINT 'Tout les véhicules sont désormais disponible'
RETURN; -- On arrête l'éxécution de la procédure stockée
END;
END