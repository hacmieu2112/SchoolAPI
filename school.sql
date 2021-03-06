-- MySQL Script generated by MySQL Workbench
-- Mon Jun 21 01:47:21 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema school
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema school
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `school` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `school` ;

-- -----------------------------------------------------
-- Table `school`.`class`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `school`.`class` (
  `ClassID` INT NOT NULL AUTO_INCREMENT,
  `ClassName` VARCHAR(255) CHARACTER SET 'utf8' NOT NULL,
  PRIMARY KEY (`ClassID`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `school`.`student`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `school`.`student` (
  `StudentID` INT NOT NULL AUTO_INCREMENT,
  `StudentName` VARCHAR(255) CHARACTER SET 'utf8' NOT NULL,
  PRIMARY KEY (`StudentID`))
ENGINE = InnoDB
AUTO_INCREMENT = 12
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `school`.`studentinclass`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `school`.`studentinclass` (
  `ClassID` INT NOT NULL,
  `StudentID` INT NOT NULL,
  PRIMARY KEY (`ClassID`, `StudentID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
