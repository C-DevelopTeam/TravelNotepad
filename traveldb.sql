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
  `diaryid` decimal(12,0) NOT NULL,
  `time` datetime NOT NULL,
  `title` varchar(45) DEFAULT NULL,
  `description` longtext,
  `photo` longtext,
  `share` decimal(1,0) NOT NULL DEFAULT '0',
  `uid` decimal(5,0) NOT NULL,
  `travelid` decimal(12,0) DEFAULT NULL,
  PRIMARY KEY (`diaryid`),
  KEY `travelid_idx` (`travelid`),
  KEY `uerid_idx` (`uid`),
  CONSTRAINT `travelid` FOREIGN KEY (`travelid`) REFERENCES `travel` (`travelid`),
  CONSTRAINT `uerid` FOREIGN KEY (`uid`) REFERENCES `user` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='日记表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route` (
  `routeid` decimal(14,0) NOT NULL,
  `state` decimal(1,0) NOT NULL DEFAULT '0',
  `method` varchar(100) NOT NULL DEFAULT '未定义出行方式',
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `start_siteid` varchar(45) DEFAULT NULL,
  `end_siteid` varchar(45) DEFAULT NULL,
  `travelid` decimal(12,0) NOT NULL,
  PRIMARY KEY (`routeid`),
  KEY `travelid_idx` (`travelid`),
  CONSTRAINT `travel_id` FOREIGN KEY (`travelid`) REFERENCES `travel` (`travelid`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='路线表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `site`
--

DROP TABLE IF EXISTS `site`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `site` (
  `siteid` varchar(45) NOT NULL,
  `sitename` varchar(100) NOT NULL,
  `city` varchar(45) NOT NULL,
  `distinct` varchar(80) DEFAULT NULL,
  `adcode` varchar(45) DEFAULT NULL,
  `location` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`siteid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='地点表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `task`
--

DROP TABLE IF EXISTS `task`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `task` (
  `taskid` decimal(16,0) NOT NULL,
  `state` decimal(1,0) NOT NULL DEFAULT '0',
  `description` varchar(45) NOT NULL,
  `routeid` decimal(14,0) NOT NULL,
  PRIMARY KEY (`taskid`),
  KEY `routeid_idx` (`routeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='待办表';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `travel`
--

DROP TABLE IF EXISTS `travel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `travel` (
  `travelid` decimal(12,0) NOT NULL,
  `description` varchar(200) DEFAULT NULL,
  `uid` decimal(5,0) NOT NULL,
  PRIMARY KEY (`travelid`),
  KEY `uid` (`uid`),
  CONSTRAINT `uid` FOREIGN KEY (`uid`) REFERENCES `user` (`uid`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='旅游表';
/*!40101 SET character_set_client = @saved_cs_client */;

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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-24 11:22:45
