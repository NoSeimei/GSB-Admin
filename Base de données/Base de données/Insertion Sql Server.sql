
INSERT INTO utilisateur (id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES
(1, 'Jean', 'Michelle', 'peut', 'etre', '4 test des gsb', '98471', 'Saint-manguier', '2019-10-02'),
(2, 'AUGUSTIN', 'Loïc', 'aLoic', '12-Soleil&', '12 chemin des filaos', '97452', 'Saint-Andrée', '2018-09-04'),
(3, 'COINDEVEL', 'Bryan', 'cBryan', '12-Soleil&', '159 quartier Chaudron', '97400', 'Saint-Denis', '2019-08-13'),
(4, 'LEBEAU', 'Emmanuel', 'lEmmanuel', '12-Soleil&', '14 Chemin des VB.Net', '97400', 'Saint-Denis', '2019-07-24'),
(5, 'TREPORT', 'Elie', 'tElie', '12-Soleil&', '35 Chemin des crayons de couleurs', '97417', 'La Montagne', '2019-08-06'),
(6, 'VALENTIN', 'Samuel', 'vSamuel', '12-Soleil&', '139 Chemin de la cuvette', '97417', 'La Montagne', '2019-08-13'),
(7, 'Test', 'test', 'test', 'test', '4 test des gsb', '98471', 'Saint-manguier', '2019-08-13');


INSERT INTO comptable (id, nbFicheRefusee) VALUES
(5, '5'),
(6, '4'),
(7, '9');


INSERT INTO visiteur (id) VALUES
(1),
(2),
(3),
(4);

INSERT INTO vehicule (immat, puiss, modeleMarque) VALUES
('74-FF-78', 75, 'Citroen'),
('77-FF-78', 75, 'Citroen'),
('97-FF-12', 200, 'Citroen'),
('97-FF-32', 700, 'Viper'),
('97-FF-45', 200, 'Porsche'),
('97-FF-46', 700, 'Viper'),
('97-FF-47', 200, 'Renault'),
('97-FF-48', 50, 'Citroen'),
('97-FF-78', 50, 'Peugeot'),
('97-FF-79', 50, 'Peugeot');

INSERT INTO utiliser (immat, DateDebut, id, dateFin) VALUES
('74-FF-77', '2019-11-04', 3, '2019-11-04'),
('74-FF-78', '2019-11-04', 1, '2020-11-04'),
('74-FF-78', '2019-11-04', 2, '2019-11-04'),
('97-FF-45', '2019-11-04', 1, '2020-11-04'),
('97-FF-47', '2019-11-04', 3, '2019-11-04'),
('97-FF-79', '2019-10-04', 4, '2020-11-04');