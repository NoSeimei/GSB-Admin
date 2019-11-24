-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 29 oct. 2019 à 13:14
-- Version du serveur :  5.7.26
-- Version de PHP :  7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `Gsb-BDD`
--

-- --------------------------------------------------------

--
-- Structure de la table `comptable`
--

DROP TABLE IF EXISTS `comptable`;
CREATE TABLE IF NOT EXISTS `comptable` (
  `id` int(11) NOT NULL,
  `nbFicheRefusee` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

-- --------------------------------------------------------

--
-- Structure de la table `datel`
--

DROP TABLE IF EXISTS `datel`;
CREATE TABLE IF NOT EXISTS `datel` (
  `DateDebut` date NOT NULL,
  PRIMARY KEY (`DateDebut`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `mdp` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `adresse` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `cp` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `ville` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `dateEmbauche` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`) VALUES
(1, 'Jean', 'Michelle', 'peut', 'etre', '4 test des gsb', '98471', 'Saint-manguier', '2019-10-02');

-- --------------------------------------------------------

--
-- Structure de la table `utiliser`
--

DROP TABLE IF EXISTS `utiliser`;
CREATE TABLE IF NOT EXISTS `utiliser` (
  `immat` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `DateDebut` date NOT NULL,
  `id` int(11) NOT NULL,
  `dateFin` date NOT NULL,
  PRIMARY KEY (`immat`,`DateDebut`,`id`),
  KEY `Utiliser_DateL0_FK` (`DateDebut`),
  KEY `Utiliser_Visiteur1_FK` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

-- --------------------------------------------------------

--
-- Structure de la table `vehicule`
--

DROP TABLE IF EXISTS `vehicule`;
CREATE TABLE IF NOT EXISTS `vehicule` (
  `immat` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `puiss` double NOT NULL,
  `modeleMarque` varchar(50) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  PRIMARY KEY (`immat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `comptable`
--
ALTER TABLE `comptable`
  ADD CONSTRAINT `Comptable_Utilisateur_FK` FOREIGN KEY (`id`) REFERENCES `utilisateur` (`id`);

--
-- Contraintes pour la table `utiliser`
--
ALTER TABLE `utiliser`
  ADD CONSTRAINT `Utiliser_DateL0_FK` FOREIGN KEY (`DateDebut`) REFERENCES `datel` (`DateDebut`),
  ADD CONSTRAINT `Utiliser_Vehicule_FK` FOREIGN KEY (`immat`) REFERENCES `vehicule` (`immat`),
  ADD CONSTRAINT `Utiliser_Visiteur1_FK` FOREIGN KEY (`id`) REFERENCES `visiteur` (`id`);

--
-- Contraintes pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD CONSTRAINT `Visiteur_Utilisateur_FK` FOREIGN KEY (`id`) REFERENCES `utilisateur` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
