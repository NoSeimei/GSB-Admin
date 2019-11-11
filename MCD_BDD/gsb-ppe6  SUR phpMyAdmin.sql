-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  lun. 04 nov. 2019 à 23:01
-- Version du serveur :  10.4.6-MariaDB
-- Version de PHP :  7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb-ppe6`
--

-- --------------------------------------------------------

--
-- Structure de la table `comptable`
--

CREATE TABLE `comptable` (
  `id` int(11) NOT NULL,
  `nbFicheRefusee` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Déchargement des données de la table `comptable`
--

INSERT INTO comptable (id, nbFicheRefusee) VALUES
(5, '5'),
(6, '4'),
(7, '9');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `mdp` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `adresse` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `cp` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `ville` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `dateEmbauche` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`) VALUES
(1, 'Jean', 'Michelle', 'peut', 'etre', '4 test des gsb', '98471', 'Saint-manguier', '2019-10-02'),
(2, 'AUGUSTIN', 'Loïc', 'aLoic', '12-Soleil&', '12 chemin des filaos', '97452', 'Saint-Andrée', '2018-09-04'),
(3, 'COINDEVEL', 'Bryan', 'cBryan', '12-Soleil&', '159 quartier Chaudron', '97400', 'Saint-Denis', '2019-08-13'),
(4, 'LEBEAU', 'Emmanuel', 'lEmmanuel', '12-Soleil&', '14 Chemin des VB.Net', '97400', 'Saint-Denis', '2019-07-24'),
(5, 'TREPORT', 'Elie', 'tElie', '12-Soleil&', '35 Chemin des crayons de couleurs', '97417', 'La Montagne', '2019-08-06'),
(6, 'VALENTIN', 'Samuel', 'vSamuel', '12-Soleil&', '139 Chemin de la cuvette', '97417', 'La Montagne', '2019-08-13'),
(7, 'Test', 'test', 'test', 'test', '4 test des gsb', '98471', 'Saint-manguier', '0000-00-00');

-- --------------------------------------------------------

--
-- Structure de la table `utiliser`
--

CREATE TABLE `utiliser` (
  `immat` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `DateDebut` date NOT NULL,
  `id` int(11) NOT NULL,
  `dateFin` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Déchargement des données de la table `utiliser`
--

INSERT INTO `utiliser` (`immat`, `DateDebut`, `id`, `dateFin`) VALUES
('74-FF-77', '2019-11-04', 3, NULL),
('74-FF-78', '2019-11-04', 1, NULL),
('74-FF-78', '2019-11-04', 2, NULL),
('97-FF-45', '2019-11-04', 1, NULL),
('97-FF-47', '2019-11-04', 3, NULL),
('97-FF-79', '2019-10-04', 4, '2019-11-04');

-- --------------------------------------------------------

--
-- Structure de la table `vehicule`
--

CREATE TABLE `vehicule` (
  `immat` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `puiss` double NOT NULL,
  `modeleMarque` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Déchargement des données de la table `vehicule`
--

INSERT INTO `vehicule` (`immat`, `puiss`, `modeleMarque`) VALUES
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

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

CREATE TABLE `visiteur` (
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`id`) VALUES
(1),
(2),
(3),
(4);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `comptable`
--
ALTER TABLE `comptable`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `utiliser`
--
ALTER TABLE `utiliser`
  ADD PRIMARY KEY (`immat`,`DateDebut`,`id`),
  ADD KEY `Utiliser_Visiteur1_FK` (`id`);

--
-- Index pour la table `vehicule`
--
ALTER TABLE `vehicule`
  ADD PRIMARY KEY (`immat`);

--
-- Index pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `comptable`
--
ALTER TABLE `comptable`
  ADD CONSTRAINT `Comptable_Utilisateur_FK` FOREIGN KEY (`id`) REFERENCES `utilisateur` (`id`);

--
-- Contraintes pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD CONSTRAINT `Visiteur_Utilisateur_FK` FOREIGN KEY (`id`) REFERENCES `utilisateur` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
