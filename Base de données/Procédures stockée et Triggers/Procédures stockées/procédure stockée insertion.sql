CREATE PROCEDURE Insert_User

-- But de cette proc�dure : Permet lors de son appel d'effectuer les insertion dans utilisateur MAIS AUSSI dans comptable ou visiteur en
-- Fonction des param�tres envoyer


-- Param�tres destin� � l'insertion
@param_nom nvarchar(50),
@param_prenom nvarchar(50),
@param_login nvarchar(50),
@param_mdp nvarchar(50),
@param_adresse nvarchar(50),
@param_cp nvarchar(50),
@param_ville nvarchar(50),
@param_dateEmbauche date,

--param�tres par d�faut concernant le comptable
@param_nbFichesRefuse INT = NULL


 AS

 -- Insertion dans la table utilisateur 
INSERT INTO utilisateur (nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES
(@param_nom, @param_prenom, @param_login, @param_mdp, @param_adresse, @param_cp, @param_ville, @param_dateEmbauche);

DECLARE @param_id INT;
SELECT id FROM inserted WHERE id = @param_id;

-- V�rifie quel type d'utilisateur il est
IF @param_nbFichesRefuse = NULL

INSERT INTO comptable (id, nbFicheRefusee) VALUES
(@param_id, @param_nbFichesRefuse);

ELSE

INSERT INTO visiteur (id) VALUES
(@param_id);



