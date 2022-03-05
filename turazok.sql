-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 05. 16:39
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `turazok`
--
CREATE DATABASE IF NOT EXISTS `turazok` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `turazok`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_turazo`
--

CREATE TABLE IF NOT EXISTS `vizsga_turazo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vezeteknev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `keresztnev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `varos` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `telefonszam` varchar(11) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_turazo`
--

INSERT INTO `vizsga_turazo` (`id`, `vezeteknev`, `keresztnev`, `varos`, `telefonszam`) VALUES
(1, 'Kiss', 'Manyi', 'Velence', '06701234567'),
(2, 'Nagy', 'Imre', 'Budapest', '06703216547'),
(3, 'Tompa', 'Mihály', 'Budapest', '06207854563'),
(4, 'Teszt', 'Gabor', 'Debrecen', '0620123');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_utvonal`
--

CREATE TABLE IF NOT EXISTS `vizsga_utvonal` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `turazoID` int(11) NOT NULL,
  `honnan` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `hova` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `km` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `turazoID` (`turazoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_utvonal`
--

INSERT INTO `vizsga_utvonal` (`id`, `turazoID`, `honnan`, `hova`, `km`) VALUES
(1, 2, 'Budapest', 'Monor', 38),
(2, 3, 'Budapest', 'Esztergom', 54);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vizsga_utvonal`
--
ALTER TABLE `vizsga_utvonal`
  ADD CONSTRAINT `FK_turazo` FOREIGN KEY (`turazoID`) REFERENCES `vizsga_turazo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
