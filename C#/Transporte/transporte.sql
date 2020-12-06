-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.3.9-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para transporte
CREATE DATABASE IF NOT EXISTS `transporte` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `transporte`;

-- Volcando estructura para tabla transporte.vdiesel
CREATE TABLE IF NOT EXISTS `vdiesel` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `VelocMax` float NOT NULL,
  `CapacLitros` float NOT NULL,
  `NumCilindros` int(11) NOT NULL,
  `Bio` tinyint(1) NOT NULL,
  `ID_Vehiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ID_Vehiculo` (`ID_Vehiculo`),
  CONSTRAINT `vdiesel_ibfk_1` FOREIGN KEY (`ID_Vehiculo`) REFERENCES `xvehiculo` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.vdiesel: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `vdiesel` DISABLE KEYS */;
INSERT INTO `vdiesel` (`Id`, `VelocMax`, `CapacLitros`, `NumCilindros`, `Bio`, `ID_Vehiculo`) VALUES
	(1, 130, 45, 10, 1, 3),
	(2, 123, 560, 14, 0, 8),
	(3, 146, 508.5, 14, 1, 13);
/*!40000 ALTER TABLE `vdiesel` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.velectrico
CREATE TABLE IF NOT EXISTS `velectrico` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `VelocMax` float NOT NULL,
  `CargaMax` float NOT NULL,
  `ID_Vehiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ID_Vehiculo` (`ID_Vehiculo`),
  CONSTRAINT `velectrico_ibfk_1` FOREIGN KEY (`ID_Vehiculo`) REFERENCES `xvehiculo` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.velectrico: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `velectrico` DISABLE KEYS */;
INSERT INTO `velectrico` (`Id`, `VelocMax`, `CargaMax`, `ID_Vehiculo`) VALUES
	(1, 120, 350.5, 1),
	(2, 95, 600, 6),
	(3, 134.5, 444, 11),
	(4, 124, 600, 15);
/*!40000 ALTER TABLE `velectrico` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.vgasolina
CREATE TABLE IF NOT EXISTS `vgasolina` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `VelocMax` float NOT NULL,
  `CapacLitros` float NOT NULL,
  `NumCilindros` int(11) NOT NULL,
  `ID_Vehiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ID_Vehiculo` (`ID_Vehiculo`),
  CONSTRAINT `vgasolina_ibfk_1` FOREIGN KEY (`ID_Vehiculo`) REFERENCES `xvehiculo` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.vgasolina: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `vgasolina` DISABLE KEYS */;
INSERT INTO `vgasolina` (`Id`, `VelocMax`, `CapacLitros`, `NumCilindros`, `ID_Vehiculo`) VALUES
	(1, 124, 50, 8, 2),
	(2, 145, 520.5, 12, 7),
	(3, 145, 56.5, 12, 12),
	(4, 160, 50, 10, 16);
/*!40000 ALTER TABLE `vgasolina` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.vhibrido
CREATE TABLE IF NOT EXISTS `vhibrido` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `VelocMax` float NOT NULL,
  `CapacLitros` float NOT NULL,
  `NumCilindros` int(11) NOT NULL,
  `CargaMax` float NOT NULL,
  `ID_Vehiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ID_Vehiculo` (`ID_Vehiculo`),
  CONSTRAINT `vhibrido_ibfk_1` FOREIGN KEY (`ID_Vehiculo`) REFERENCES `xvehiculo` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.vhibrido: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `vhibrido` DISABLE KEYS */;
INSERT INTO `vhibrido` (`Id`, `VelocMax`, `CapacLitros`, `NumCilindros`, `CargaMax`, `ID_Vehiculo`) VALUES
	(1, 105.5, 60.5, 10, 240, 5),
	(2, 180, 45, 16, 412, 10);
/*!40000 ALTER TABLE `vhibrido` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.vhidrogeno
CREATE TABLE IF NOT EXISTS `vhidrogeno` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `VelocMax` float NOT NULL,
  `Por_Eficiencia` int(11) NOT NULL,
  `ID_Vehiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ID_Vehiculo` (`ID_Vehiculo`),
  CONSTRAINT `vhidrogeno_ibfk_1` FOREIGN KEY (`ID_Vehiculo`) REFERENCES `xvehiculo` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.vhidrogeno: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `vhidrogeno` DISABLE KEYS */;
INSERT INTO `vhidrogeno` (`Id`, `VelocMax`, `Por_Eficiencia`, `ID_Vehiculo`) VALUES
	(1, 90.5, 82, 4),
	(2, 185, 90, 9),
	(3, 153.5, 500, 14);
/*!40000 ALTER TABLE `vhidrogeno` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.xlider_sindical
CREATE TABLE IF NOT EXISTS `xlider_sindical` (
  `RFC` char(13) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Contrasenha` varchar(20) NOT NULL,
  PRIMARY KEY (`RFC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.xlider_sindical: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `xlider_sindical` DISABLE KEYS */;
INSERT INTO `xlider_sindical` (`RFC`, `Nombre`, `Contrasenha`) VALUES
	('1A2S3D4F5G6', 'Pepe Peréz', 'QWE123'),
	('1JABDRPD92MA', 'Admin', 'Contraseña'),
	('3GGUO90HJPOI5', 'Ruben García', 'Supe-rman9'),
	('6Z1X2C3V4B5', 'Alan Ramirez', 'cam78X');
/*!40000 ALTER TABLE `xlider_sindical` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.xlinea
CREATE TABLE IF NOT EXISTS `xlinea` (
  `Color` varchar(15) NOT NULL,
  `Zona` varchar(30) NOT NULL,
  `HoraInicio` time NOT NULL,
  `HoraFinal` time NOT NULL,
  `Categoria` varchar(20) NOT NULL,
  `ID_Lider` char(13) DEFAULT NULL,
  PRIMARY KEY (`Color`),
  KEY `fk_lider` (`ID_Lider`),
  CONSTRAINT `fk_lider` FOREIGN KEY (`ID_Lider`) REFERENCES `xlider_sindical` (`RFC`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.xlinea: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `xlinea` DISABLE KEYS */;
INSERT INTO `xlinea` (`Color`, `Zona`, `HoraInicio`, `HoraFinal`, `Categoria`, `ID_Lider`) VALUES
	('Amarillo', 'Parque industrial', '06:15:00', '14:00:00', 'Transporte privado', '3GGUO90HJPOI5'),
	('Azul', 'Centro', '08:00:00', '10:00:00', 'Calafias', '1JABDRPD92MA'),
	('Rojo', 'Otay', '07:30:00', '09:30:00', 'Camiones', '1A2S3D4F5G6'),
	('Verde', 'Cetys', '10:00:00', '14:30:00', 'Taxis de ruta', '6Z1X2C3V4B5');
/*!40000 ALTER TABLE `xlinea` ENABLE KEYS */;

-- Volcando estructura para tabla transporte.xvehiculo
CREATE TABLE IF NOT EXISTS `xvehiculo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Color` varchar(15) DEFAULT NULL,
  `NombreChofer` varchar(30) NOT NULL,
  `TipoTrans` varchar(20) NOT NULL,
  `TipoMotor` varchar(20) NOT NULL,
  `Modelo` int(11) NOT NULL,
  `Placa` varchar(20) NOT NULL,
  `Tarifa` float NOT NULL,
  `Costo_Min` float NOT NULL,
  `Mom_Pago` varchar(20) NOT NULL,
  `Capacidad` int(11) NOT NULL,
  `Tarifa_est` float DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_color` (`Color`),
  CONSTRAINT `fk_color` FOREIGN KEY (`Color`) REFERENCES `xlinea` (`Color`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla transporte.xvehiculo: ~16 rows (aproximadamente)
/*!40000 ALTER TABLE `xvehiculo` DISABLE KEYS */;
INSERT INTO `xvehiculo` (`Id`, `Color`, `NombreChofer`, `TipoTrans`, `TipoMotor`, `Modelo`, `Placa`, `Tarifa`, `Costo_Min`, `Mom_Pago`, `Capacidad`, `Tarifa_est`) VALUES
	(1, 'Verde', 'Mariano Santos', 'Taxi', 'Electrico', 523, 'C8ASHC7', 12.5, 5.45, 'Bajada', 9, NULL),
	(2, 'Verde', 'Pedro Ayala', 'Taxi', 'Gasolina', 112, 'CS98HC0', 13.5, 3.6, 'Bajada', 9, NULL),
	(3, 'Verde', 'Maria de las nieves', 'Taxi', 'Diesel', 230, '9JPDOSP', 14.6, 4.12, 'Bajada', 9, NULL),
	(4, 'Azul', 'Santiago Hernandez', 'Calafia', 'Hidrogeno', 2834, 'UD20H3', 10.5, 0, 'Bajada', 20, 6),
	(5, 'Azul', 'Sonia Sanchez', 'Calafia', 'Hibrido', 9727, 'RJT2007Z', 11, 0, 'Bajada', 24, 5),
	(6, 'Azul', 'Jaime Ramones', 'Calafia', 'Electrico', 345, 'DW3994Q', 12, 0, 'Bajada', 22, 6),
	(7, 'Rojo', 'Penelope Sanchez', 'Camion', 'Gasolina', 885, 'D0SPJP7', 14.5, 0, 'Subida', 40, 7),
	(8, 'Rojo', 'Dolores Cruz', 'Camion', 'Diesel', 237, 'I0JSD12', 13, 0, 'Subida', 36, 7),
	(9, 'Rojo', 'Rafael Cevilla', 'Camion', 'Hidrogeno', 4455, '34G5887W', 14.5, 0, 'Subida', 43, 7.5),
	(10, 'Amarillo', 'Pablo Mendoza', 'Transporte privado', 'Hibrido', 542, 'AS8D9K', 36.5, 3.4, 'Bajada', 5, 36.5),
	(11, 'Amarillo', 'Jaime Altozano', 'Transporte privado', 'Electrico', 792, '662ER4', 40.4, 4, 'Bajada', 4, 40.4),
	(12, 'Amarillo', 'Julia Torres', 'Transporte privado', 'Gasolina', 1818, '09VSD09', 48, 4, 'Bajada', 6, 45),
	(13, 'Rojo', 'Laura Simpson', 'Camion', 'Diesel', 333, '3R23EWF2', 14, 0, 'Subida', 34, 7),
	(14, 'Rojo', 'Edward Lopez', 'Camion', 'Hidrogeno', 741, 'V5GW4G', 15, 0, 'Subida', 35, 7),
	(15, 'Azul', 'Pepe Pecas', 'Calafia', 'Electrico', 2221, '545H75Z', 13.5, 0, 'Bajada', 27, 5),
	(16, 'Amarillo', 'Alfonso Torres', 'Transporte privado', 'Gasolina', 805, 'FD883N', 37, 4, 'Bajada', 4, 37);
/*!40000 ALTER TABLE `xvehiculo` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
