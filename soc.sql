-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: soc
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `tb_active`
--

DROP TABLE IF EXISTS `tb_active`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_active` (
  `soc` varchar(255) DEFAULT NULL,
  `dateS` varchar(255) DEFAULT NULL,
  `dateE` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_active`
--

LOCK TABLES `tb_active` WRITE;
/*!40000 ALTER TABLE `tb_active` DISABLE KEYS */;
INSERT INTO `tb_active` VALUES ('程序设计协会','12-1 20:16','12-1 20:26'),('程序设计协会','12-12 20:16','12-12 20:26'),('程序设计协会','12-19 22:05','12-19 23:08'),('程序设计协会','12-19 22:05','12-19 23:33');
/*!40000 ALTER TABLE `tb_active` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_manager`
--

DROP TABLE IF EXISTS `tb_manager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_manager` (
  `soc` varchar(255) DEFAULT NULL,
  `manager` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_manager`
--

LOCK TABLES `tb_manager` WRITE;
/*!40000 ALTER TABLE `tb_manager` DISABLE KEYS */;
INSERT INTO `tb_manager` VALUES ('程序设计协会','李杭瑞'),('舞蹈社团','王明'),('音乐社团','赵宁'),('外语社团','张辉明');
/*!40000 ALTER TABLE `tb_manager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_notice`
--

DROP TABLE IF EXISTS `tb_notice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_notice` (
  `soc` varchar(255) DEFAULT NULL,
  `user` varchar(255) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `notice` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_notice`
--

LOCK TABLES `tb_notice` WRITE;
/*!40000 ALTER TABLE `tb_notice` DISABLE KEYS */;
INSERT INTO `tb_notice` VALUES ('程序设计协会','李杭瑞','2020-11-11','下周三B711协会活动，进行蓝桥杯选拔，大家好好复习！'),('程序设计协会','李杭瑞','2020-12-1','下周三活动。'),('舞蹈社团','王明','2020-1-1','没有活动！'),('程序设计协会','默彦明','2020-12-19','test');
/*!40000 ALTER TABLE `tb_notice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_soc`
--

DROP TABLE IF EXISTS `tb_soc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_soc` (
  `soc` varchar(255) DEFAULT NULL,
  `teacher` varchar(255) DEFAULT NULL,
  `sdate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_soc`
--

LOCK TABLES `tb_soc` WRITE;
/*!40000 ALTER TABLE `tb_soc` DISABLE KEYS */;
INSERT INTO `tb_soc` VALUES ('程序设计协会','孙珊珊','2018-3-17'),('音乐社团','张明','2019-9-9'),('舞蹈社团','王辉','2020-10-14'),('外语社团','赵立','2017-5-5');
/*!40000 ALTER TABLE `tb_soc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_user`
--

DROP TABLE IF EXISTS `tb_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_user` (
  `uname` varchar(255) DEFAULT NULL,
  `sid` varchar(255) DEFAULT NULL,
  `gender` varchar(255) DEFAULT NULL,
  `age` varchar(255) DEFAULT NULL,
  `phone` varchar(255) DEFAULT NULL,
  `depart` varchar(255) DEFAULT NULL,
  `soc` varchar(255) DEFAULT NULL,
  `idenity` varchar(255) DEFAULT NULL,
  `pass` varchar(255) DEFAULT NULL,
  `admin` tinyint(1) DEFAULT '0',
  KEY `idenity` (`idenity`),
  KEY `sid` (`sid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_user`
--

LOCK TABLES `tb_user` WRITE;
/*!40000 ALTER TABLE `tb_user` DISABLE KEYS */;
INSERT INTO `tb_user` VALUES ('李杭瑞','201851802','男','20','12312312312','信息工程','程序设计协会','231121222211113333','123456',1),('张三明','201945216','男','20','32145698521','艺术设计','音乐社团','125426985212365478','321654',0),('王欧飞','201845612','女','21','98542123658','艺术设计','音乐社团','521236547895412365','321654',0),('王能否','201845698','男','20','54125478921','信息工程','舞蹈社团','212365412387452168','456123',0),('赵康宁','201745612','女','23','12365452369','电气工程','外语社团','123654123654123663','654987',0),('周金华','201845612','男','20','12354789654','电气工程','程序设计协会','236589652321454654','789521',0),('孙共江','201845673','男','20','12312312354','信息工程','程序设计协会','321654789654123654','654322',0),('默彦明','123','男','20','87656543576','信息工程','程序设计协会','321654789654123555','333',1),('汪小明','321','男','20','12312312353','信息工程','程序设计协会','321654789654123666','333',0);
/*!40000 ALTER TABLE `tb_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-19 23:49:57
