-- Ses commandes sont a effectué sur un compte admin ayant les droits pour les faires!!!!


-- Création du login de connexion avec un mot de passe
CREATE LOGIN AdminGSB
WITH PASSWORD = '12-Soleil&';

-- Création d'un utilisateur
CREATE USER AdminGSB FOR LOGIN AdminGSB;


-- Permissions sur les principal requêtes du CRUD sur les données de la BDD
GRANT SELECT, UPDATE, DELETE, INSERT
  TO AdminGSB;


  -- Permissions sur les différentes procédures stockées (que le droit à l'éxécution)
  GRANT EXECUTE ON OBJECT::Insert_Update_User
  TO AdminGSB;


  GRANT EXECUTE ON OBJECT::rendre_Vehicule_Dispo
  TO AdminGSB;

  GRANT EXECUTE ON OBJECT::verifAdd_VoitureForVisiteur
  TO AdminGSB;


-- Source pour apprendre le grantt --> http://www.bts-sio.com/cours/SI3/sql/8%20-%20GRANT.php
-- OU --> https://www.techonthenet.com/sql_server/grant_revoke.php