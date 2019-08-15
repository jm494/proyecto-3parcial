-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: tienda_2parcial
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `videojuego`
--

DROP TABLE IF EXISTS `videojuego`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `videojuego` (
  `videojuego_id` int(11) NOT NULL AUTO_INCREMENT,
  `consola_id` int(11) NOT NULL,
  `categoria_id` int(11) NOT NULL,
  `proveedor_id` int(11) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `precio` double(6,2) DEFAULT NULL,
  PRIMARY KEY (`videojuego_id`),
  KEY `consola_id` (`consola_id`),
  KEY `categoria_id` (`categoria_id`),
  KEY `proveedor_id` (`proveedor_id`),
  CONSTRAINT `videojuego_ibfk_1` FOREIGN KEY (`consola_id`) REFERENCES `consola` (`consola_id`),
  CONSTRAINT `videojuego_ibfk_2` FOREIGN KEY (`categoria_id`) REFERENCES `categoria` (`categoria_id`),
  CONSTRAINT `videojuego_ibfk_3` FOREIGN KEY (`proveedor_id`) REFERENCES `proveedor` (`proveedor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=216 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `videojuego`
--

LOCK TABLES `videojuego` WRITE;
/*!40000 ALTER TABLE `videojuego` DISABLE KEYS */;
INSERT INTO `videojuego` VALUES (173,14,2,15,'Super Mario Bros,',709.56),(174,6,5,11,'Grand thef auto san andreas',146.30),(175,3,1,17,'Final fantasy VII',275.98),(176,1,4,3,'Final fantasy VI',107.95),(177,20,5,11,'Final fantasy V',162.89),(178,20,2,13,'Final fantasy IV',252.44),(179,6,4,12,'Final fantasy III',192.74),(180,12,4,17,'Final fantasy II',901.35),(181,11,4,14,'Final fantasy I',416.50),(182,18,5,1,'The Legend of Zelda: Ocarina of time',239.79),(183,19,5,9,'God of War',576.53),(184,4,1,15,'Resident Evil',154.51),(185,21,5,24,'Assasin Creed',621.48),(186,2,5,23,'Crash Bandicoot',938.34),(187,12,3,13,'Super Mario 64',447.95),(188,15,5,9,'Pacman',464.53),(189,7,5,24,'Super Shash Bros',953.80),(190,12,3,24,'Call of duty',739.80),(191,13,5,17,'Medal of Honor',678.79),(192,21,5,24,'Mario Kart 64',644.66),(193,8,3,15,'Super Smash Bros Brawl',391.46),(194,8,5,18,'Moltal Kombat',729.31),(195,10,4,24,'Street fighter',432.87),(196,3,5,1,'Super Mario Word',675.43),(197,17,1,1,'Grand Theft Auto Vice City',273.08),(198,20,1,18,'Super Mario Bros 3',487.61),(199,3,2,24,'Grand Theft Auto 4',793.71),(200,5,4,23,'Call of Duty: Black Ops',653.93),(201,9,1,3,'Tetris',563.85),(202,2,1,24,'Bomberman',761.67),(203,15,5,5,'Residen Evil 5',784.51),(204,20,3,21,'Metal Slug',569.02),(205,3,4,20,'Metal Slug 2',459.68),(206,10,4,20,'Metal Slug 3',710.52),(207,11,3,9,'Metal Slug 4',363.33),(208,2,1,22,'Metal Slug 5',298.02),(209,7,4,20,'Metal Slug 6',757.46),(210,14,1,3,'Resident Evil 2',106.63),(211,15,5,8,'Contra',287.07),(212,19,4,6,'Donkey Kong Country',646.76),(213,6,1,23,'The Legend of Zelda Majora Mask',932.78),(214,11,2,11,'Call of Duty: Moder Warface 2',854.40),(215,11,4,4,'Call of Duty: Moder Warface',155.47);
/*!40000 ALTER TABLE `videojuego` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-07-19  0:22:18
