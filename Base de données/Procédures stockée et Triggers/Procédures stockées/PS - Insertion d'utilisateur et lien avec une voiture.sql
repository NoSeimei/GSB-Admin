-- Cette procédure stockée permet d'insérer un utilisateur en le liant avec une voiture
-- Vérifie que la voiture n'est pas en cours d'utilsiation

CREATE PROC verifAdd_VoitureForVisiteur
--- PARAMETRES NECESSAIRE A L'APPEL DE LA PROCEDURE
------------------------------------------------------------------------------------

-- Paramètres pour la table UTILISER
@immat nvarchar(20),
@dateDebut date,

-- Paramètres pour la table USER
@idUser int,
@nomUser nvarchar(20),
@prenomUser nvarchar(20),
@login nvarchar(20),
@mdp nvarchar(20),
@adresse nvarchar(20),
@cp nvarchar(20),
@ville nvarchar(20),
@dateEmbauche date,


-- Permet de préciser la date fin d'utilisation si il y en as une
@dateFin date
------------------------------------------------------------------------------------

AS
BEGIN

-- DECLARATION DE NOS VARIABLES
------------------------------------------------------------------------------------
DECLARE @dateFinReq as date; -- Variables destinées à acceuillir la donnée x de la date de fin d'utilisation d'une voiture
DECLARE @Verif as int;
SET @Verif = 1;
DECLARE @dateSys as date; -- Variables destiné à récupérer la date du système
SELECT @dateSys = CONVERT (date, SYSDATETIME()); -- Récupére la date du système
------------------------------------------------------------------------------------


-- SI UNE VOITURE EST EN COURS D'UTILISATION ON NE FAIT RIEN
-------------------------------------------------------------------------------------------
IF EXISTS(SELECT * FROM utiliser WHERE immat = @immat AND dateFin >= @dateSys) -- On effectue un test avant la boucle
BEGIN
	PRINT 'La voiture choisie n''est pas disponible'; -- Si on est dans ce cas, alors la voiture n'est pas disponible
	SET @Verif = 0;
END;
-------------------------------------------------------------------------------------------



-- SINON EFFECTUE L'INSERTION 
-------------------------------------------------------------------------------------------
IF @Verif = 1
BEGIN

INSERT INTO utilisateur
VALUES(@idUser, @nomUser, @prenomUser, @login, @mdp, @adresse, @cp, @ville, @dateEmbauche)

INSERT INTO visiteur
VALUES(@idUser) -- On insére maintenant l'utilisateur et le visiteur

INSERT INTO utiliser
VALUES(@immat, @dateDebut, @idUser, @dateFin) -- On insére maintenant dans la table UTILISER

PRINT 'L''utilisateur as bien été enregistré' -- On affiche maintenant un message qui précise que l'utilsiateur as bien été insérer
END;
-------------------------------------------------------------------------------------------


END;