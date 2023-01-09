-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: jewellary_managementdb
-- ------------------------------------------------------
-- Server version	5.7.9-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `product_type`
--

DROP TABLE IF EXISTS `product_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_type` (
  `Product_Type_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Product_Type_Title` varchar(45) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Product_Type_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_type`
--

LOCK TABLES `product_type` WRITE;
/*!40000 ALTER TABLE `product_type` DISABLE KEYS */;
INSERT INTO `product_type` VALUES (1,'Ring','Diamond ring'),(2,' Gold Solitaire Ring','So this product in 20-carat gold with Solitaire Diamond.\r\n'),(3,'18K Gold Ring','Gold type is 18 carat which in less in gold quality thats not good but its okay in gold.'),(4,'Earrings','Diamond Earrings(0.06ct,IJ-SI),18KT yellow Gold Jewellery.'),(5,'Gold Earrings','Gold Earrings(1.60gm),18KT Plain Yellow Gold Jewellery.'),(6,'Diamond Earrings','Diamond Earrings(0.05ct,IJ-SI),14KT yellow gold jewellery.'),(7,'Gold Rose Earrings','Gold Rose Earrings In 18kt rose gold(5gm) The Blooming Rose Stud Earrings.'),(8,'Gold Diamond Pendant','Gold Diamond Pendant(0.o1ct,IJ-SI),18KT Yellow Gold Jewellery.'),(9,'Gold Diamond Necklace ','Gold Diamond Necklace In 18Kt yellow gold(16gm) The Almire Necklace .'),(10,'Gold Necklace Earrings','Gold Necklace Earrings Jewellery 22KT .'),(11,'Gold Chain','Gold Chain ,11.05gm,22KT Textured Swirl Motif Chain Yellow Gold Jewellary.'),(12,'Gold chain','Gold chain 20kt'),(13,'Bengals','Gold Bengals with 22-Carat Gold with American Diamond settled'),(14,'Gold Bengals','Bengal with 18-Carat pure gold...');
/*!40000 ALTER TABLE `product_type` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-09 12:28:38
