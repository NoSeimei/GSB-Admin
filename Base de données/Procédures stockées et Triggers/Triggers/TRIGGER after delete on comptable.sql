-- Permet de supprimer l'utilisateur concerner par le comptable
CREATE TRIGGER delete_User_Comptable ON comptable
AFTER DELETE
AS

BEGIN
DECLARE @id as int;
SELECT @id = id  FROM deleted --On récupére ici le numéro du comptable sur le point d'être supprimé

DELETE FROM utilisateur WHERE id = @id;
END;