-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: traveldb
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
-- Table structure for table `diary`
--

DROP TABLE IF EXISTS `diary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diary` (
  `travelid` decimal(12,0) NOT NULL,
  `title` varchar(45) DEFAULT NULL,
  `description` longtext,
  `photo` longtext,
  `share` decimal(1,0) NOT NULL DEFAULT '0',
  `isdelete` decimal(1,0) NOT NULL DEFAULT '0',
  PRIMARY KEY (`travelid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='日记表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diary`
--

LOCK TABLES `diary` WRITE;
/*!40000 ALTER TABLE `diary` DISABLE KEYS */;
/*!40000 ALTER TABLE `diary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route` (
  `routeid` int NOT NULL,
  `state` decimal(1,0) NOT NULL,
  `method` varchar(100) NOT NULL DEFAULT '未定义出行方式',
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `start_siteid` varchar(45) DEFAULT NULL,
  `end_siteid` varchar(45) DEFAULT NULL,
  `travelid` decimal(12,0) NOT NULL,
  PRIMARY KEY (`routeid`),
  KEY `start_site_idx` (`start_siteid`),
  KEY `end_siteid_idx` (`end_siteid`),
  KEY `travelid_idx` (`travelid`),
  CONSTRAINT `end_siteid` FOREIGN KEY (`end_siteid`) REFERENCES `site` (`siteid`),
  CONSTRAINT `start_siteid` FOREIGN KEY (`start_siteid`) REFERENCES `site` (`siteid`),
  CONSTRAINT `travel_id` FOREIGN KEY (`travelid`) REFERENCES `diary` (`travelid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='路线表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route`
--

LOCK TABLES `route` WRITE;
/*!40000 ALTER TABLE `route` DISABLE KEYS */;
/*!40000 ALTER TABLE `route` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `site`
--

DROP TABLE IF EXISTS `site`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `site` (
  `siteid` varchar(45) NOT NULL,
  `sitename` varchar(100) NOT NULL,
  `distinct` varchar(80) DEFAULT NULL,
  `adcode` varchar(45) DEFAULT NULL,
  `location` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`siteid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='地点表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `site`
--

LOCK TABLES `site` WRITE;
/*!40000 ALTER TABLE `site` DISABLE KEYS */;
/*!40000 ALTER TABLE `site` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `todo`
--

DROP TABLE IF EXISTS `todo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `todo` (
  `taskid` int NOT NULL,
  `state` decimal(1,0) NOT NULL DEFAULT '0' COMMENT '1或0',
  `task` varchar(45) NOT NULL,
  `routeid` int NOT NULL,
  `siteid` varchar(45) NOT NULL,
  PRIMARY KEY (`taskid`),
  KEY `routeid_idx` (`routeid`),
  KEY `siteid_idx` (`siteid`),
  CONSTRAINT `routeid` FOREIGN KEY (`routeid`) REFERENCES `route` (`routeid`) ON DELETE CASCADE,
  CONSTRAINT `siteid` FOREIGN KEY (`siteid`) REFERENCES `site` (`siteid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='待办表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `todo`
--

LOCK TABLES `todo` WRITE;
/*!40000 ALTER TABLE `todo` DISABLE KEYS */;
/*!40000 ALTER TABLE `todo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `uid` decimal(5,0) NOT NULL,
  `uname` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `sex` varchar(2) DEFAULT NULL,
  `introduction` varchar(100) DEFAULT '此用户没有填写个人介绍',
  PRIMARY KEY (`uid`),
  CONSTRAINT `user_chk_1` CHECK ((`sex` in (_utf8mb4'男',_utf8mb4'女')))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='用户表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_travel`
--

DROP TABLE IF EXISTS `user_travel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_travel` (
  `uid` decimal(5,0) NOT NULL,
  `travelid` decimal(12,0) NOT NULL COMMENT '20200520xxxx',
  PRIMARY KEY (`uid`,`travelid`),
  KEY `travelid_idx` (`travelid`),
  CONSTRAINT `travelid` FOREIGN KEY (`travelid`) REFERENCES `diary` (`travelid`),
  CONSTRAINT `uid` FOREIGN KEY (`uid`) REFERENCES `user` (`uid`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='用户与旅游连接表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_travel`
--

LOCK TABLES `user_travel` WRITE;
/*!40000 ALTER TABLE `user_travel` DISABLE KEYS */;
/*!40000 ALTER TABLE `user_travel` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-30 10:50:19
