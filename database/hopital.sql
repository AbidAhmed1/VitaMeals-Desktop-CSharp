-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 06 mai 2025 à 21:18
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `hopital`
--

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

CREATE TABLE `fournisseur` (
  `id_fournisseur` int(11) NOT NULL,
  `nom_fournisseur` varchar(50) DEFAULT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`id_fournisseur`, `nom_fournisseur`, `adresse`, `tel`) VALUES
(1, 'AgriFood', 'Rue des Jasmins, Tunis', '70112233'),
(2, 'BioFresh', 'Ariana Centre', '71334455');

-- --------------------------------------------------------

--
-- Structure de la table `ingredients`
--

CREATE TABLE `ingredients` (
  `ingredient_id` int(11) NOT NULL,
  `nom_ingredient` varchar(50) DEFAULT NULL,
  `quantite` int(11) DEFAULT NULL,
  `id_fournisseur` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `ingredients`
--

INSERT INTO `ingredients` (`ingredient_id`, `nom_ingredient`, `quantite`, `id_fournisseur`) VALUES
(1, 'Poulet', 50, 1),
(2, 'Riz', 100, 2),
(3, 'Tomate', 75, 1);

-- --------------------------------------------------------

--
-- Structure de la table `patients`
--

CREATE TABLE `patients` (
  `cin` varchar(8) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `date_naissance` date NOT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `num_chambre` int(11) DEFAULT NULL,
  `regime` varchar(100) DEFAULT NULL,
  `allergies` text DEFAULT NULL,
  `statut` enum('hospitalisé','sorti') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `patients`
--

INSERT INTO `patients` (`cin`, `nom`, `prenom`, `date_naissance`, `tel`, `adresse`, `num_chambre`, `regime`, `allergies`, `statut`) VALUES
('12333433', 'dvvdf', 'xvfdv', '2025-05-06', '33445', 'DVGGD', 22, 'FGF', 'FBG', 'hospitalisé'),
('2', 'Trabelsi', 'Fatma', '1992-11-15', '22987654', 'Sfax', 102, 'sans sel', 'Gluten', 'hospitalisé'),
('27168', 'SJHDJKS', 'DDJK', '2025-05-06', '3878829', 'JDJHJKQS', 33, 'NJSDS', 'KZJD', 'hospitalisé'),
('27168812', 'SJHDJKS', 'DDJK', '2025-05-06', '3878829', 'JDJHJKQS', 33, 'NJSDS', 'KZJD', 'hospitalisé'),
('3', 'kaffela', 'meriem', '2005-01-22', '29375575', 'manouba', 154, 'sans sel', 'rien', 'sorti'),
('4', 'ahmed', 'mohamed', '2006-05-05', '19875423', 'khaznadar', 20, 'végétarien', 'tomate', 'hospitalisé'),
('5', 'ahmed', 'ali', '2000-01-01', '15784963', 'bizerte', 9, 'normal', 'fraise', 'hospitalisé'),
('55555555', 'yahyaoui', 'wajih', '2025-05-06', '6217812', 'kjskdjsk', 23, 'psychoptae', 'laabed', 'hospitalisé'),
('8', 'eltaief', 'eya', '2004-01-01', '12345678', 'denden', 102, 'diabétique', 'fraise', 'hospitalisé'),
('9', 'abid', 'ahmed', '2004-01-20', '36925814', 'boumhal', 110, 'diabétique', 'thé', 'sorti'),
('99', 'jouini', 'fatma', '1999-06-20', '12365498', 'sousse', 199, 'Végétarien', 'rien', 'hospitalisé');

-- --------------------------------------------------------

--
-- Structure de la table `reclamation`
--

CREATE TABLE `reclamation` (
  `id_reclamation` int(11) NOT NULL,
  `cin` varchar(8) DEFAULT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `prenom` varchar(255) DEFAULT NULL,
  `date_reclamation` date DEFAULT NULL,
  `description` text DEFAULT NULL,
  `statut` enum('en cours','résolu','rejété') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `reclamation`
--

INSERT INTO `reclamation` (`id_reclamation`, `cin`, `nom`, `prenom`, `date_reclamation`, `description`, `statut`) VALUES
(1, '1', 'Ben Ali', 'Ahmed', '2025-04-14', 'Le repas était froid.', 'en cours'),
(2, '2', 'Trabelsi', 'Fatma', '2025-04-13', 'Erreur dans le régime alimentaire.', 'résolu'),
(5, '3', 'kaffela', 'meriem', '2025-04-25', 'mekla mesh bnina', ''),
(8, '8', 'eltaief', 'eya', '2025-04-17', 'froid', ''),
(9, '8', 'eltaief', 'eya', '2025-04-28', NULL, 'en cours'),
(10, '8', 'eltaief', 'eya', '2025-04-17', 'froid', '');

-- --------------------------------------------------------

--
-- Structure de la table `regime`
--

CREATE TABLE `regime` (
  `id_regime` int(11) NOT NULL,
  `type_regime` varchar(50) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `patient_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `regime`
--

INSERT INTO `regime` (`id_regime`, `type_regime`, `description`, `patient_id`) VALUES
(1, 'Diabétique', 'Repas sans sucre', 1),
(2, 'Sans sel', 'Pas de sel ajouté', 2);

-- --------------------------------------------------------

--
-- Structure de la table `repas`
--

CREATE TABLE `repas` (
  `id_repas` int(11) NOT NULL,
  `nom_repas` varchar(50) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `categorie` varchar(255) DEFAULT NULL,
  `regime` enum('normal','diabétique','sans sel','végétarien') DEFAULT NULL,
  `quantite` int(11) DEFAULT NULL,
  `date_ajout` date NOT NULL DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `repas`
--

INSERT INTO `repas` (`id_repas`, `nom_repas`, `description`, `categorie`, `regime`, `quantite`, `date_ajout`) VALUES
(1, 'Petit déjeuner classique', 'Un petit déjeuner composé de pain, beurre, confiture, et thé', 'petit_dejeuner', 'normal', 1, '2025-05-05'),
(2, 'Petit déjeuner diabétique', 'Petit déjeuner adapté pour diabétiques avec du pain complet et de l\'eau', 'petit_dejeuner', 'diabétique', 1, '2025-05-05'),
(3, 'Petit déjeuner sans sel', 'Petit déjeuner sans sel avec des fruits frais et de l\'eau', 'petit_dejeuner', 'sans sel', 2, '2025-05-05'),
(4, 'Déjeuner classique', 'Plat principal avec viande, légumes, et riz', 'dejeuner', 'normal', 1, '2025-05-05'),
(5, 'Déjeuner diabétique', 'Plat principal avec viande maigre, légumes cuits, et riz complet', 'dejeuner', 'diabétique', 1, '2025-05-05'),
(6, 'Déjeuner sans sel', 'Plat principal sans sel, avec légumes cuits et riz basmati', 'dejeuner', 'sans sel', 2, '2025-05-05'),
(7, 'Dîner classique', 'Dîner léger avec du poisson, salade et légumes', 'diner', 'normal', 1, '2025-05-05'),
(8, 'Dîner diabétique', 'Dîner léger avec du poisson grillé, légumes et riz brun', 'diner', 'diabétique', 1, '2025-05-05'),
(9, 'Dîner sans sel', 'Dîner léger avec poisson grillé et légumes', 'diner', 'sans sel', 2, '2025-05-05'),
(15, 'Dîner normal', 'Dîner léger avec du poisson, salade et légumes.', 'diner', 'normal', 2, '2025-05-06'),
(20, 'Petit déjeuner végétarien', 'Un petit déjeuner adapté avec des fruits frais, du pain complet et du thé', 'petit_dejeuner', 'végétarien', 3, '2025-05-05'),
(21, 'Déjeuner végétarien', 'Plat principal végétarien avec légumes cuits et riz complet', 'dejeuner', 'végétarien', 3, '2025-05-05'),
(22, 'Dîner végétarien', 'Dîner léger avec légumes grillés, salade et riz', 'diner', 'végétarien', 3, '2025-05-05'),
(66, 'Dîner normal', 'Dîner léger avec du poisson, salade et légumes.', 'diner', 'normal', 1, '2025-05-06'),
(88, 'Petit déjeuner normal', 'Un petit déjeuner composé de pain, beurre, confiture.', 'petit déjeuner', 'normal', 4, '2025-05-06');

-- --------------------------------------------------------

--
-- Structure de la table `repas_ingredients`
--

CREATE TABLE `repas_ingredients` (
  `id_repas` int(11) NOT NULL,
  `ingredient_id` int(11) NOT NULL,
  `quantite` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `user_id` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `mdp` varchar(255) DEFAULT NULL,
  `role` enum('medecin','cuisinier','administrateur','admin') DEFAULT NULL,
  `cin` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`user_id`, `nom`, `mdp`, `role`, `cin`) VALUES
(1, 'medecin1', '1234', 'medecin', '12345678'),
(2, 'cuisinier1', 'abcd', 'cuisinier', '23456789'),
(3, 'admin1', 'adm1234', 'administrateur', '34567890'),
(7, 'admin', 'admin', 'admin', '87654321'),
(8, 'cuisinier2', 'efgh', 'cuisinier', ''),
(9, 'med1', 'med1', 'medecin', ''),
(10, 'aaaa', '1223989332', 'medecin', '12687311'),
(11, 'admin2', 'dmin3', 'medecin', '1342627'),
(12, 'admin3', 'admin3', 'medecin', '12345678');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `fournisseur`
--
ALTER TABLE `fournisseur`
  ADD PRIMARY KEY (`id_fournisseur`);

--
-- Index pour la table `ingredients`
--
ALTER TABLE `ingredients`
  ADD PRIMARY KEY (`ingredient_id`),
  ADD KEY `fk_fournisseur` (`id_fournisseur`);

--
-- Index pour la table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`cin`);

--
-- Index pour la table `reclamation`
--
ALTER TABLE `reclamation`
  ADD PRIMARY KEY (`id_reclamation`),
  ADD KEY `fk_patient_reclamation` (`cin`);

--
-- Index pour la table `regime`
--
ALTER TABLE `regime`
  ADD PRIMARY KEY (`id_regime`),
  ADD KEY `fk_patient_regime` (`patient_id`);

--
-- Index pour la table `repas`
--
ALTER TABLE `repas`
  ADD PRIMARY KEY (`id_repas`);

--
-- Index pour la table `repas_ingredients`
--
ALTER TABLE `repas_ingredients`
  ADD PRIMARY KEY (`id_repas`,`ingredient_id`),
  ADD KEY `fk_ingredient` (`ingredient_id`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `fournisseur`
--
ALTER TABLE `fournisseur`
  MODIFY `id_fournisseur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `ingredients`
--
ALTER TABLE `ingredients`
  MODIFY `ingredient_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `reclamation`
--
ALTER TABLE `reclamation`
  MODIFY `id_reclamation` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `regime`
--
ALTER TABLE `regime`
  MODIFY `id_regime` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `repas`
--
ALTER TABLE `repas`
  MODIFY `id_repas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=89;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `ingredients`
--
ALTER TABLE `ingredients`
  ADD CONSTRAINT `fk_fournisseur` FOREIGN KEY (`id_fournisseur`) REFERENCES `fournisseur` (`id_fournisseur`) ON DELETE CASCADE,
  ADD CONSTRAINT `ingredients_ibfk_1` FOREIGN KEY (`id_fournisseur`) REFERENCES `fournisseur` (`id_fournisseur`);

--
-- Contraintes pour la table `reclamation`
--
ALTER TABLE `reclamation`
  ADD CONSTRAINT `reclamation_ibfk_1` FOREIGN KEY (`cin`) REFERENCES `patients` (`cin`) ON DELETE CASCADE;

--
-- Contraintes pour la table `repas_ingredients`
--
ALTER TABLE `repas_ingredients`
  ADD CONSTRAINT `fk_ingredient` FOREIGN KEY (`ingredient_id`) REFERENCES `ingredients` (`ingredient_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_repas` FOREIGN KEY (`id_repas`) REFERENCES `repas` (`id_repas`) ON DELETE CASCADE,
  ADD CONSTRAINT `repas_ingredients_ibfk_1` FOREIGN KEY (`id_repas`) REFERENCES `repas` (`id_repas`),
  ADD CONSTRAINT `repas_ingredients_ibfk_2` FOREIGN KEY (`ingredient_id`) REFERENCES `ingredients` (`ingredient_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
