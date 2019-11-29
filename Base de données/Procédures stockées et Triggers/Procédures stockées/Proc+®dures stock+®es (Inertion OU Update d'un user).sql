CREATE PROCEDURE Insert_Update_User

-- But de cette procédure : Permet lors de son appel d'effectuer les insertion dans utilisateur MAIS AUSSI dans comptable ou visiteur en
-- Fonction des paramètres envoyer


-- Paramètres destiné à l'insertion
@param_id INT,
@param_nom nvarchar(50),
@param_prenom nvarchar(50),
@param_login nvarchar(50),
@param_mdp nvarchar(50),
@param_adresse nvarchar(50),
@param_cp nvarchar(50),
@param_ville nvarchar(50),
@param_dateEmbauche date,

--paramètres par défaut concernant le comptable
@param_nbFichesRefuse INT = NULL


 AS


 -- On véirifie tout d'abord que l'utilisateur n'existe pas déjà
 IF EXISTS (SELECT * FROM utilisateur WHERE id = @param_id)

 BEGIN

UPDATE utilisateur
SET nom = @param_nom, prenom = @param_prenom, login = @param_login, mdp = @param_mdp, adresse = @param_adresse, cp = @param_cp, 
ville = @param_ville, dateEmbauche = @param_dateEmbauche
WHERE id = @param_id;


SELECT 0, 'L''utilisateur existait déjà, il as été mise à jour'
END;

ELSE

 BEGIN

 -- Insertion dans la table utilisateur 
INSERT INTO utilisateur (id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES
(@param_id, @param_nom, @param_prenom, @param_login, @param_mdp, @param_adresse, @param_cp, @param_ville, @param_dateEmbauche);


-- Vérifie quel type d'utilisateur il est
IF @param_nbFichesRefuse = NULL

INSERT INTO comptable (id, nbFicheRefusee) VALUES
(@param_id, @param_nbFichesRefuse);

ELSE

INSERT INTO visiteur (id) VALUES
(@param_id);

-- Affiche un message spécifiant l'action effectuer
SELECT 1, 'L''utilisateur n''existait pas, il as été créer '
 END;

