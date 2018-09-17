CREATE DATABASE  IF NOT EXISTS `rhtdata` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `rhtdata`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: rhtdata
-- ------------------------------------------------------
-- Server version	5.7.23-log

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
-- Dumping data for table `alternativa`
--

LOCK TABLES `alternativa` WRITE;
/*!40000 ALTER TABLE `alternativa` DISABLE KEYS */;
INSERT INTO `alternativa` VALUES (4,2,'Apresenta resistência na execursão, principalemnte quando contrapõe seu posição a idéia apresentada.',0),(5,2,'Não apresenta resistência, mas não tem iniciativa espontana na execursão.',0),(6,2,'Põe-se à disposição espontaneamente para executar.',1),(7,3,'Se adequa bem, procurando resolver os imprevistos e buscando soluções aos problemas.',1),(8,3,'Tem dificuldades sobre pressão e comete mais erros.',0),(9,3,'Tenta resolver os problemas, contudo não busca ajuda o que acarreta em maior tempo para solução.',0);
/*!40000 ALTER TABLE `alternativa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `avaliacao`
--

LOCK TABLES `avaliacao` WRITE;
/*!40000 ALTER TABLE `avaliacao` DISABLE KEYS */;
INSERT INTO `avaliacao` VALUES (1,'2018-09-12 09:43:57','Avaliação de competência - Gestores',2);
/*!40000 ALTER TABLE `avaliacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `classificacao`
--

LOCK TABLES `classificacao` WRITE;
/*!40000 ALTER TABLE `classificacao` DISABLE KEYS */;
INSERT INTO `classificacao` VALUES (1,'Capacidade de Gestão'),(2,'Preparo  e Qualificação'),(3,'Capacidade de Trabalho em equipe'),(4,'Compromisso com os resultdos'),(5,'Visão Institucional'),(6,'Carcateristicas comportamentais');
/*!40000 ALTER TABLE `classificacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pergunta`
--

LOCK TABLES `pergunta` WRITE;
/*!40000 ALTER TABLE `pergunta` DISABLE KEYS */;
INSERT INTO `pergunta` VALUES (2,0,3,1,'Em relação as idéias apresentadas pela equipe, o funcionario ...','Coopera no compartilhamento de ideias, atividades e soluções com os membros da equipe e das demais áreas. Põe-se à disposição espontaneamente para executar outros '),(3,0,6,1,'Em relação a adversidades, pressões, imprevistos, obstáculos e conflito, o funcionário ...','Realiza seu trabalho de forma equilibrada e convive bem com adversidades, pressões, imprevistos, obstáculos e conflitos. Recebe bem críticas e as trata adequadamente, '),(4,1,1,1,'Seguindo a escala apresenta, qual a nível de mobilização do funcionário para com o envolvimento e compromentimento dos seus colaboradores.','Mobiliza, envolve e compromete seus colaboradores, visando a realização dos objetivos e metas definidas e estimulando a equipe a valorizar o que faz. '),(5,1,3,1,'Qual nível de relacionamento com outros membro da equipe?','Interage e mantém bom relacionamento com seus pares, superiores e outras equipes,  contribuindo para o trabalho das outras áreas. Atende ao cliente interno e externo, de ');
/*!40000 ALTER TABLE `pergunta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `peso`
--

LOCK TABLES `peso` WRITE;
/*!40000 ALTER TABLE `peso` DISABLE KEYS */;
INSERT INTO `peso` VALUES (7,1,3,20),(8,1,6,30),(9,1,1,50);
/*!40000 ALTER TABLE `peso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pessoa`
--

LOCK TABLES `pessoa` WRITE;
/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
INSERT INTO `pessoa` VALUES (1,'laerton','senha',3,'Laerton',0),(2,'jose','senha',1,'José',0),(3,'senha','senha',1,'Cassandra',0),(4,'Carlos','senha',1,'Carlos',0);
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pessoaavaliacao`
--

LOCK TABLES `pessoaavaliacao` WRITE;
/*!40000 ALTER TABLE `pessoaavaliacao` DISABLE KEYS */;
INSERT INTO `pessoaavaliacao` VALUES (1,3,1),(2,4,1);
/*!40000 ALTER TABLE `pessoaavaliacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'rhtdata'
--

--
-- Dumping routines for database 'rhtdata'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-09-17 14:25:21
