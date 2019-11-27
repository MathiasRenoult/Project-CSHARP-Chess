DROP DATABASE IF EXISTS  ChessCSHARP;

CREATE DATABASE ChessCSHARP;

USE ChessCSHARP;

CREATE TABLE `Joueur` (
	`idJoueur` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT,
	`pseudo` VARCHAR(50) NOT NULL,
	`mail` VARCHAR(50) NOT NULL,
	`password` VARCHAR(50) NOT NULL,
	`nb_victoire` INT(11) UNSIGNED NOT NULL DEFAULT '0',
	`nb_defaite` INT(11) UNSIGNED NOT NULL DEFAULT '0',
	PRIMARY KEY (`idJoueur`)
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=InnoDB
;

#Missing foreign key
CREATE TABLE `Partie` (
	`idPartie` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT,
	`date` VARCHAR(50) NOT NULL,
	`difficulte` VARCHAR(50) NOT NULL,
	`nb_tour` INT(11) UNSIGNED NOT NULL DEFAULT '0',
	PRIMARY KEY (`idPartie`)
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=InnoDB
;
