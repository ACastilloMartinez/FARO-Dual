-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: airforcedb
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `formulario`
--

DROP TABLE IF EXISTS `formulario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formulario` (
  `id_form` int NOT NULL AUTO_INCREMENT,
  `id_piloto` int NOT NULL,
  `id_vehiculo` int NOT NULL,
  `id_hora` int NOT NULL,
  `id_terreno` int NOT NULL,
  `id_tiempo` int NOT NULL,
  `id_val` int NOT NULL,
  PRIMARY KEY (`id_form`),
  KEY `id_piloto_idx` (`id_piloto`),
  KEY `id_hora_idx` (`id_hora`),
  KEY `id_terreno_idx` (`id_terreno`),
  KEY `id_tiempo_idx` (`id_tiempo`),
  KEY `id_vehiculo_idx` (`id_vehiculo`),
  KEY `id_val_idx` (`id_val`),
  CONSTRAINT `id_hora` FOREIGN KEY (`id_hora`) REFERENCES `hora` (`id_hora`),
  CONSTRAINT `id_piloto` FOREIGN KEY (`id_piloto`) REFERENCES `piloto` (`id_pil`),
  CONSTRAINT `id_terreno` FOREIGN KEY (`id_terreno`) REFERENCES `terreno` (`id_terreno`),
  CONSTRAINT `id_tiempo` FOREIGN KEY (`id_tiempo`) REFERENCES `tiempo` (`id_tiempo`),
  CONSTRAINT `id_val` FOREIGN KEY (`id_val`) REFERENCES `validez` (`id_val`),
  CONSTRAINT `id_vehiculo` FOREIGN KEY (`id_vehiculo`) REFERENCES `vehiculo` (`id_veh`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formulario`
--

LOCK TABLES `formulario` WRITE;
/*!40000 ALTER TABLE `formulario` DISABLE KEYS */;
INSERT INTO `formulario` VALUES (1,1,1,1,1,1,0),(2,1,2,3,1,1,1),(3,4,3,2,5,4,0),(14,2,6,3,1,7,0),(15,2,6,4,1,7,1),(16,3,1,1,3,3,1),(17,3,1,4,1,7,1),(18,6,1,1,1,7,1),(19,6,1,4,1,7,1),(20,6,1,4,1,7,1),(21,6,1,3,1,7,0),(22,1,5,18,2,2,1);
/*!40000 ALTER TABLE `formulario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hora`
--

DROP TABLE IF EXISTS `hora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hora` (
  `id_hora` int NOT NULL AUTO_INCREMENT,
  `descripcion_h` varchar(45) NOT NULL,
  PRIMARY KEY (`id_hora`),
  UNIQUE KEY `descripcion_h_UNIQUE` (`descripcion_h`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hora`
--

LOCK TABLES `hora` WRITE;
/*!40000 ALTER TABLE `hora` DISABLE KEYS */;
INSERT INTO `hora` VALUES (1,'0000'),(2,'0100'),(3,'0200'),(4,'0300'),(5,'0400'),(6,'0500'),(7,'0600'),(8,'0700'),(9,'0800'),(10,'0900'),(11,'1000'),(12,'1100'),(13,'1200'),(14,'1300'),(15,'1400'),(16,'1500'),(17,'1600'),(18,'1700'),(19,'1800'),(20,'1900'),(21,'2000'),(22,'2100'),(23,'2200'),(24,'2300');
/*!40000 ALTER TABLE `hora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nivel`
--

DROP TABLE IF EXISTS `nivel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nivel` (
  `id_nivel` int NOT NULL AUTO_INCREMENT,
  `descripcion_niv` varchar(45) NOT NULL,
  PRIMARY KEY (`id_nivel`),
  UNIQUE KEY `descripcion_niv_UNIQUE` (`descripcion_niv`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nivel`
--

LOCK TABLES `nivel` WRITE;
/*!40000 ALTER TABLE `nivel` DISABLE KEYS */;
INSERT INTO `nivel` VALUES (4,'Alto'),(1,'Aprendiz'),(6,'As'),(2,'Bajo'),(5,'Experto'),(3,'Medio');
/*!40000 ALTER TABLE `nivel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `piloto`
--

DROP TABLE IF EXISTS `piloto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `piloto` (
  `id_pil` int NOT NULL,
  `usuario_pil` varchar(45) NOT NULL,
  `contrasena_pil` varchar(45) NOT NULL,
  `nombre_pil` varchar(45) NOT NULL,
  `rango_pil` varchar(45) NOT NULL,
  `id_nivel` int NOT NULL,
  PRIMARY KEY (`id_pil`,`usuario_pil`),
  UNIQUE KEY `usuario_pil_UNIQUE` (`usuario_pil`),
  KEY `id_nivel_idx` (`id_nivel`),
  CONSTRAINT `id_nivel` FOREIGN KEY (`id_nivel`) REFERENCES `nivel` (`id_nivel`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `piloto`
--

LOCK TABLES `piloto` WRITE;
/*!40000 ALTER TABLE `piloto` DISABLE KEYS */;
INSERT INTO `piloto` VALUES (1,'AvieM','ACE7AM','Avril Mead','Teniente',4),(2,'MihShi','RUSACE7','Mihaly Shilage','Comandante',6),(3,'JanRazor','SPOOKY01','Janice Rehl','Mayor',3),(4,'WBishop','BRASS108','William Bishop','Teniente Coronel',5),(5,'Sharky','AKULA1','Andrei Markov','Coronel',2),(6,'WedgeCole','HUNTINGBF3','Jennifer Hawkins','Teniente',1);
/*!40000 ALTER TABLE `piloto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `terreno`
--

DROP TABLE IF EXISTS `terreno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `terreno` (
  `id_terreno` int NOT NULL AUTO_INCREMENT,
  `descripcion_ter` varchar(45) NOT NULL,
  PRIMARY KEY (`id_terreno`),
  UNIQUE KEY `descripcion_ter_UNIQUE` (`descripcion_ter`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `terreno`
--

LOCK TABLES `terreno` WRITE;
/*!40000 ALTER TABLE `terreno` DISABLE KEYS */;
INSERT INTO `terreno` VALUES (3,'Bosque'),(4,'Desertico'),(5,'Llanura'),(6,'Maritimo'),(1,'Montanoso'),(2,'Urbano');
/*!40000 ALTER TABLE `terreno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiempo`
--

DROP TABLE IF EXISTS `tiempo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiempo` (
  `id_tiempo` int NOT NULL,
  `descripcion_ti` varchar(45) NOT NULL,
  PRIMARY KEY (`id_tiempo`),
  UNIQUE KEY `descripcion_UNIQUE` (`descripcion_ti`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiempo`
--

LOCK TABLES `tiempo` WRITE;
/*!40000 ALTER TABLE `tiempo` DISABLE KEYS */;
INSERT INTO `tiempo` VALUES (3,'Lluvia'),(6,'Niebla'),(4,'Nieve'),(2,'Nubloso'),(1,'Soleado'),(7,'Tormenta de arena'),(5,'Ventoso');
/*!40000 ALTER TABLE `tiempo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_vehiculo`
--

DROP TABLE IF EXISTS `tipo_vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_vehiculo` (
  `id_tipoveh` int NOT NULL AUTO_INCREMENT,
  `nombre_tipoveh` varchar(45) NOT NULL,
  PRIMARY KEY (`id_tipoveh`),
  UNIQUE KEY `nombre_veh_UNIQUE` (`nombre_tipoveh`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_vehiculo`
--

LOCK TABLES `tipo_vehiculo` WRITE;
/*!40000 ALTER TABLE `tipo_vehiculo` DISABLE KEYS */;
INSERT INTO `tipo_vehiculo` VALUES (2,'Avion de carga'),(4,'Avion de personal'),(3,'Avioneta'),(1,'Cazas'),(5,'Helicoptero');
/*!40000 ALTER TABLE `tipo_vehiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `validez`
--

DROP TABLE IF EXISTS `validez`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `validez` (
  `id_val` int NOT NULL,
  `descripcion_val` varchar(45) NOT NULL,
  PRIMARY KEY (`id_val`),
  UNIQUE KEY `descripcion_val_UNIQUE` (`descripcion_val`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `validez`
--

LOCK TABLES `validez` WRITE;
/*!40000 ALTER TABLE `validez` DISABLE KEYS */;
INSERT INTO `validez` VALUES (0,'NO'),(1,'SI');
/*!40000 ALTER TABLE `validez` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculo`
--

DROP TABLE IF EXISTS `vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehiculo` (
  `id_veh` int NOT NULL AUTO_INCREMENT,
  `matricula` varchar(45) NOT NULL,
  `nombre_veh` varchar(45) NOT NULL,
  `tipo_veh` int NOT NULL,
  PRIMARY KEY (`id_veh`,`matricula`),
  UNIQUE KEY `matricula_UNIQUE` (`matricula`),
  KEY `tipo_veh_idx` (`tipo_veh`),
  CONSTRAINT `tipo_veh` FOREIGN KEY (`tipo_veh`) REFERENCES `tipo_vehiculo` (`id_tipoveh`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiculo`
--

LOCK TABLES `vehiculo` WRITE;
/*!40000 ALTER TABLE `vehiculo` DISABLE KEYS */;
INSERT INTO `vehiculo` VALUES (1,'CZ123','F-22A Raptor',1),(2,'1RG23','KC-10 Extender',2),(3,'12TR3','172E Skyhawk',3),(4,'PR123','C-130 Hercules',4),(5,'H123H','MH-60 BlackHawk',5),(6,'CZ456','Typhoon',1),(7,'4RG56','C-17 Globemaster III',2),(8,'45TR6','C-101',3),(9,'PR456','Ilyushin IL-76',4),(10,'H456H','AH-64D Apache Longbow',5);
/*!40000 ALTER TABLE `vehiculo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-02 11:56:45
