-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le :  Dim 12 mai 2019 à 15:53
-- Version du serveur :  10.1.26-MariaDB-0+deb9u1
-- Version de PHP :  7.2.11-2+0~20181015120801.9+stretch~1.gbp8105e0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `base_projet_vb`
--

-- --------------------------------------------------------

--
-- Structure de la table `Joueur`
--

CREATE TABLE `Joueur` (
  `ID` int(11) NOT NULL,
  `Nom` varchar(30) NOT NULL,
  `Pwd` varchar(50) NOT NULL,
  `nbArgent` int(11) NOT NULL DEFAULT '20',
  `IdPref` int(11) DEFAULT NULL,
  `IdStats` int(11) DEFAULT NULL,
  `estConnecter` tinyint(1) DEFAULT '0',
  `estOccuper` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Joueur`
--

INSERT INTO `Joueur` (`ID`, `Nom`, `Pwd`, `nbArgent`, `IdPref`, `IdStats`, `estConnecter`, `estOccuper`) VALUES
(15, 'Dabi', 'toto', 284, 13, 8, 1, 0),
(17, 'toto', 'toto', 83, 12, 7, 1, 0),
(18, 'Amadou', 'toto', 20, 14, 9, 0, 0),
(19, 'San', 'toto', 20, 15, 10, 0, 0),
(20, 'Karin', 'toto', 20, 16, 11, 0, 0),
(21, 'pascal', 'toto', 20, 17, 12, 0, 0),
(22, 'Luffy', 'toto', 20, 18, 13, 0, 0),
(23, 'Anoup', 'b72ca5df8f', 90, 19, 14, 0, 0);

-- --------------------------------------------------------

--
-- Structure de la table `Partie`
--

CREATE TABLE `Partie` (
  `IdPartie` int(11) NOT NULL,
  `IdJ1` int(11) DEFAULT NULL,
  `Idj2` int(11) DEFAULT NULL,
  `damierJ1` varchar(100) NOT NULL DEFAULT '',
  `damierJ2` varchar(100) NOT NULL DEFAULT '',
  `heures` int(11) NOT NULL,
  `minutes` int(11) NOT NULL,
  `secondes` int(11) NOT NULL,
  `lignes` int(11) NOT NULL,
  `colonnes` int(11) NOT NULL,
  `Idgagant` int(11) DEFAULT NULL,
  `date` datetime DEFAULT CURRENT_TIMESTAMP,
  `accepter` tinyint(1) DEFAULT '0',
  `refuser` tinyint(1) DEFAULT '0',
  `valider` tinyint(1) DEFAULT '0',
  `mise` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Partie`
--

INSERT INTO `Partie` (`IdPartie`, `IdJ1`, `Idj2`, `damierJ1`, `damierJ2`, `heures`, `minutes`, `secondes`, `lignes`, `colonnes`, `Idgagant`, `date`, `accepter`, `refuser`, `valider`, `mise`) VALUES
(109, 15, 17, '6;1;5;8;4;7;2;3;#', '5;2;8;1;7;4;#;6;3', 0, 1, 0, 3, 3, NULL, '2019-05-12 13:45:43', 1, 0, 1, 0),
(110, 15, 23, '1;#;2;4;7;8;3;6;5', '1;2;3;4;5;6;7;8;#', 0, 1, 0, 3, 3, 23, '2019-05-12 14:33:01', 1, 0, 1, 0),
(111, 15, 23, '', '1;2;3;4;5;6;7;8;#', 0, 1, 0, 3, 3, 23, '2019-05-12 14:34:24', 1, 0, 0, 0),
(112, 23, 15, '1;2;3;4;5;6;7;8;#', '1;2;#;7;5;3;6;4;8', 0, 1, 0, 3, 3, 23, '2019-05-12 14:35:46', 1, 0, 1, 0),
(113, 15, 23, '15;2;12;13;9;6;7;8;14;5;1;11;4;3;#;10', '1;2;3;4;6;#;8;14;13;7;11;15;9;5;10;12', 0, 1, 0, 4, 4, NULL, '2019-05-12 14:39:51', 1, 0, 1, 0),
(114, 15, 17, '1;15;3;8;2;6;5;9;4;7;14;12;10;11;13;#', '10;2;1;11;7;6;15;8;14;3;13;12;9;5;4;#', 0, 1, 0, 4, 4, NULL, '2019-05-12 14:43:31', 1, 0, 1, 0),
(115, 15, 17, '6;7;1;4;8;5;3;2;#', '3;8;4;7;1;2;6;5;#', 0, 1, 0, 3, 3, NULL, '2019-05-12 14:44:56', 1, 0, 1, 0),
(116, 15, 17, '7;11;9;6;4;1;3;8;2;10;5;12;13;14;15;#', '1;2;14;4;5;8;9;15;11;10;13;7;12;3;6;#', 0, 1, 0, 4, 4, NULL, '2019-05-12 14:45:16', 1, 0, 1, 0),
(117, 17, 15, '5;2;1;7;8;4;6;3;#', '8;3;6;4;7;5;2;1;#', 0, 1, 0, 3, 3, NULL, '2019-05-12 14:47:30', 1, 0, 1, 0),
(118, 15, 17, '1;2;3;14;7;11;13;5;9;10;#;8;15;12;4;6', '1;12;4;13;5;6;8;9;2;11;10;3;7;14;15;#', 0, 1, 0, 4, 4, NULL, '2019-05-12 14:48:46', 1, 0, 1, 0),
(119, 15, 17, '7;4;8;3;2;1;5;6;#', '1;3;2;4;6;5;7;#;8', 0, 1, 0, 3, 3, 17, '2019-05-12 15:36:08', 1, 0, 1, 15),
(120, 15, 17, '1;3;2;#', '2;1;#;3', 0, 1, 0, 2, 2, 17, '2019-05-12 15:37:18', 1, 0, 1, 15),
(121, 15, 17, '3;1;2;#', '2;1;#;3', 0, 1, 0, 2, 2, 17, '2019-05-12 15:37:43', 1, 0, 1, 15);

-- --------------------------------------------------------

--
-- Structure de la table `Preferences`
--

CREATE TABLE `Preferences` (
  `ID` int(11) NOT NULL,
  `lignes` int(11) NOT NULL DEFAULT '4',
  `colonnes` int(11) NOT NULL DEFAULT '4',
  `heures` int(11) NOT NULL DEFAULT '0',
  `minutes` int(11) NOT NULL DEFAULT '1',
  `secondes` int(11) DEFAULT '0',
  `unlimited` tinyint(1) NOT NULL DEFAULT '0',
  `cheminImage` varchar(500) DEFAULT NULL,
  `IdJoueur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Preferences`
--

INSERT INTO `Preferences` (`ID`, `lignes`, `colonnes`, `heures`, `minutes`, `secondes`, `unlimited`, `cheminImage`, `IdJoueur`) VALUES
(12, 3, 3, 0, 1, 0, 0, '', 17),
(13, 2, 2, 0, 2, 0, 0, '', 15),
(14, 4, 4, 0, 1, 0, 1, '', 18),
(15, 4, 4, 0, 1, 0, 0, NULL, 19),
(16, 2, 2, 0, 1, 0, 0, '', 20),
(17, 3, 3, 0, 1, 0, 0, 'C:\\Users\\Dabi\\Documents\\ISN\\IUT\\Projet\\ProjetVBA\\taquinProject\\taquinProject\\bin\\Debug\\Resources\\assets\\Images\\argent.png', 21),
(18, 2, 2, 0, 1, 0, 0, 'C:\\Users\\Dabi\\Documents\\ISN\\IUT\\Projet\\ProjetVBA\\taquinProject\\taquinProject\\bin\\Debug\\Resources\\assets\\Images\\onePiece.jpg', 22),
(19, 7, 7, 0, 1, 0, 0, '', 23);

-- --------------------------------------------------------

--
-- Structure de la table `Statistiques`
--

CREATE TABLE `Statistiques` (
  `ID` int(11) NOT NULL,
  `nbPartie` int(11) DEFAULT '0',
  `nbLose` int(11) NOT NULL DEFAULT '0',
  `nbAbandon` int(11) NOT NULL DEFAULT '0',
  `totalSec` int(11) NOT NULL DEFAULT '0',
  `nbCoup` int(11) NOT NULL DEFAULT '0',
  `meilleurTps` int(11) NOT NULL DEFAULT '-1',
  `IdJoueur` int(11) DEFAULT NULL,
  `nbPartieWin` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Statistiques`
--

INSERT INTO `Statistiques` (`ID`, `nbPartie`, `nbLose`, `nbAbandon`, `totalSec`, `nbCoup`, `meilleurTps`, `IdJoueur`, `nbPartieWin`) VALUES
(7, 18, 0, 12, 239, 160, 3, 17, 6),
(8, 86, 1, 36, 834, 771, 2, 15, 41),
(9, 3, 0, 3, 7, 0, -1, 18, 0),
(10, 0, 0, 0, 0, 0, -1, 19, 0),
(11, 1, 0, 0, 3, 6, 3, 20, 1),
(12, 5, 0, 2, 30, 33, 2, 21, 3),
(13, 1, 0, 0, 3, 4, 3, 22, 1),
(14, 5, 2, 0, 298, 424, 11, 23, 7);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `Joueur`
--
ALTER TABLE `Joueur`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Nom` (`Nom`),
  ADD KEY `idStats` (`IdStats`),
  ADD KEY `fk_pref` (`IdPref`);

--
-- Index pour la table `Partie`
--
ALTER TABLE `Partie`
  ADD PRIMARY KEY (`IdPartie`),
  ADD KEY `fk_j1` (`IdJ1`),
  ADD KEY `fk_j2` (`Idj2`),
  ADD KEY `fk_idGagnant` (`Idgagant`);

--
-- Index pour la table `Preferences`
--
ALTER TABLE `Preferences`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Fk_joueurPref` (`IdJoueur`);

--
-- Index pour la table `Statistiques`
--
ALTER TABLE `Statistiques`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `IdJoueur` (`IdJoueur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `Joueur`
--
ALTER TABLE `Joueur`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT pour la table `Partie`
--
ALTER TABLE `Partie`
  MODIFY `IdPartie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=122;

--
-- AUTO_INCREMENT pour la table `Preferences`
--
ALTER TABLE `Preferences`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT pour la table `Statistiques`
--
ALTER TABLE `Statistiques`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Joueur`
--
ALTER TABLE `Joueur`
  ADD CONSTRAINT `Joueur_ibfk_1` FOREIGN KEY (`IdStats`) REFERENCES `Statistiques` (`ID`),
  ADD CONSTRAINT `fk_pref` FOREIGN KEY (`IdPref`) REFERENCES `Preferences` (`ID`);

--
-- Contraintes pour la table `Partie`
--
ALTER TABLE `Partie`
  ADD CONSTRAINT `fk_idGagnant` FOREIGN KEY (`Idgagant`) REFERENCES `Joueur` (`ID`),
  ADD CONSTRAINT `fk_j1` FOREIGN KEY (`IdJ1`) REFERENCES `Joueur` (`ID`),
  ADD CONSTRAINT `fk_j2` FOREIGN KEY (`Idj2`) REFERENCES `Joueur` (`ID`);

--
-- Contraintes pour la table `Preferences`
--
ALTER TABLE `Preferences`
  ADD CONSTRAINT `Fk_joueurPref` FOREIGN KEY (`IdJoueur`) REFERENCES `Joueur` (`ID`);

--
-- Contraintes pour la table `Statistiques`
--
ALTER TABLE `Statistiques`
  ADD CONSTRAINT `Statistiques_ibfk_1` FOREIGN KEY (`IdJoueur`) REFERENCES `Joueur` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
