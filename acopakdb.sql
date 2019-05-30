# Host: localhost  (Version: 5.0.41-community-nt)
# Date: 2013-01-23 13:20:27
# Generator: MySQL-Front 5.3  (Build 2.16)

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

DROP DATABASE IF EXISTS `acopak`;
CREATE DATABASE `acopak` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `acopak`;

#
# Source for table "all_members"
#

DROP TABLE IF EXISTS `all_members`;
CREATE TABLE `all_members` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(20) default NULL,
  `Memno` varchar(20) default NULL,
  `Mr_Mrs` varchar(10) default NULL,
  `Name` varchar(50) default NULL,
  `Father_Husband` varchar(50) default NULL,
  `Receipt` varchar(20) default NULL,
  `dob` date default NULL,
  `Add1` varchar(100) default NULL,
  `Add2` varchar(100) default NULL,
  `Add3` varchar(100) default NULL,
  `Add4` varchar(100) default NULL,
  `Town` varchar(100) default NULL,
  `Area` varchar(50) default NULL,
  `Phone1` varchar(100) default NULL,
  `Phone2` varchar(255) default NULL,
  `Mobile` varchar(255) default NULL,
  `EMail` varchar(255) default NULL,
  `Profession_MK` varchar(100) default NULL,
  `Profession` varchar(255) default NULL,
  `foi1` varchar(100) default NULL,
  `foi2` varchar(50) default NULL,
  `foi3` varchar(50) default NULL,
  `Qualification` varchar(255) default NULL,
  `Proposed_by` varchar(255) default NULL,
  `Seconder` varchar(255) default NULL,
  `nic` varchar(20) default NULL,
  `Category` varchar(255) default NULL,
  `image` varchar(100) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "all_members"
#


#
# Source for table "all_members_old"
#

DROP TABLE IF EXISTS `all_members_old`;
CREATE TABLE `all_members_old` (
  `ID` int(11) NOT NULL auto_increment,
  `Memno` varchar(30) default NULL,
  `Mr_Mrs` varchar(4) default NULL,
  `Name` varchar(50) default NULL,
  `Father_Husband` varchar(50) default NULL,
  `Receipt` varchar(20) default '0',
  `dob` date default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Town` varchar(50) default NULL,
  `Area` varchar(50) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `Mobile` text,
  `EMail` varchar(255) default NULL,
  `Profession_MK` varchar(50) default NULL,
  `Profession` varchar(255) default NULL,
  `Qualification` varchar(50) default NULL,
  `Proposed_by` varchar(50) default NULL,
  `Seconder` varchar(255) default NULL,
  `nic` varchar(50) default NULL,
  `Category` varchar(50) default NULL,
  `Status` int(11) NOT NULL default '0',
  `foi1` varchar(30) default NULL,
  `foi2` varchar(30) default NULL,
  `foi3` varchar(30) default NULL,
  `image` varchar(30) default NULL,
  PRIMARY KEY  (`ID`),
  KEY `Category` (`Category`),
  KEY `ID` (`ID`),
  KEY `ID Card No` (`nic`),
  KEY `ID_2` (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=112 DEFAULT CHARSET=latin1;

#
# Data for table "all_members_old"
#

/*!40000 ALTER TABLE `all_members_old` DISABLE KEYS */;
/*!40000 ALTER TABLE `all_members_old` ENABLE KEYS */;

#
# Source for table "all_staff"
#

DROP TABLE IF EXISTS `all_staff`;
CREATE TABLE `all_staff` (
  `ID` int(11) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Staffno` varchar(255) default NULL,
  `Mr_Mrs` varchar(255) default NULL,
  `Name` varchar(255) default NULL,
  `Father_Husband` varchar(255) default NULL,
  `photo` varchar(255) default NULL,
  `dob` date default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Town` varchar(255) default NULL,
  `Area` varchar(255) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `Mobile` varchar(255) default NULL,
  `EMail` varchar(255) default NULL,
  `Profession_MK` varchar(255) default NULL,
  `Profession` varchar(255) default NULL,
  `foi1` varchar(255) default NULL,
  `foi2` varchar(255) default NULL,
  `foi3` varchar(255) default NULL,
  `Qualification` varchar(255) default NULL,
  `Proposed_by` varchar(255) default NULL,
  `Seconder` varchar(255) default NULL,
  `nic` varchar(255) default NULL,
  `Category` varchar(255) default NULL,
  `EmployeeID` varchar(255) default NULL,
  `image` varchar(50) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "all_staff"
#


#
# Source for table "all_staff_old"
#

DROP TABLE IF EXISTS `all_staff_old`;
CREATE TABLE `all_staff_old` (
  `ID` int(11) NOT NULL auto_increment,
  `Staffno` varchar(8) default NULL,
  `Mr_Mrs` varchar(4) default NULL,
  `Name` varchar(50) default NULL,
  `Father_Husband` varchar(50) default NULL,
  `dob` varchar(20) default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Town` varchar(50) default NULL,
  `Area` varchar(50) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `Mobile` varchar(50) default NULL,
  `EMail` varchar(255) default NULL,
  `Profession_MK` varchar(50) default NULL,
  `Profession` varchar(255) default NULL,
  `Qualification` varchar(50) default NULL,
  `Proposed_by` varchar(50) default NULL,
  `Seconder` varchar(255) default NULL,
  `nic` varchar(50) default NULL,
  `Category` varchar(50) default NULL,
  `EmployeeID` varchar(4) default NULL,
  `image` varchar(20) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "all_staff_old"
#


#
# Source for table "co-operative form (final)"
#

DROP TABLE IF EXISTS `co-operative form (final)`;
CREATE TABLE `co-operative form (final)` (
  `Receipt No` int(11) default '0',
  `Memno` varchar(8) default NULL,
  `Form No` int(11) default '0',
  `Remarks` varchar(80) default NULL,
  UNIQUE KEY `Memno` (`Memno`),
  UNIQUE KEY `Receipt No` (`Receipt No`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "co-operative form (final)"
#


#
# Source for table "co-operative receipt detail ( cash book )"
#

DROP TABLE IF EXISTS `co-operative receipt detail ( cash book )`;
CREATE TABLE `co-operative receipt detail ( cash book )` (
  `Receipt No` double default NULL,
  `Memno` varchar(255) default NULL,
  `Mr&Mrs` varchar(255) default NULL,
  `Name` varchar(255) default NULL,
  `Receipt Date` varchar(255) default NULL,
  `Remarks` varchar(255) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "co-operative receipt detail ( cash book )"
#


#
# Source for table "co-operative receipt detail ( co-operative)"
#

DROP TABLE IF EXISTS `co-operative receipt detail ( co-operative)`;
CREATE TABLE `co-operative receipt detail ( co-operative)` (
  `Receipt No` double default NULL,
  `Memno` varchar(255) default NULL,
  `Mr&Mrs` varchar(255) default NULL,
  `Name` varchar(255) default NULL,
  `Receipt Date` varchar(255) default NULL,
  `Remarks` varchar(255) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "co-operative receipt detail ( co-operative)"
#


#
# Source for table "cooperative_form"
#

DROP TABLE IF EXISTS `cooperative_form`;
CREATE TABLE `cooperative_form` (
  `ID` int(11) NOT NULL auto_increment,
  `Receipt_No` varchar(20) default '0',
  `Memno` varchar(8) default NULL,
  `Form_No` varchar(20) default '0',
  `Remarks` varchar(50) default NULL,
  PRIMARY KEY  (`ID`),
  UNIQUE KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "cooperative_form"
#


#
# Source for table "co-opertive members ( memno)"
#

DROP TABLE IF EXISTS `co-opertive members ( memno)`;
CREATE TABLE `co-opertive members ( memno)` (
  `Memno` varchar(8) default NULL,
  UNIQUE KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "co-opertive members ( memno)"
#


#
# Source for table "expiredmem"
#

DROP TABLE IF EXISTS `expiredmem`;
CREATE TABLE `expiredmem` (
  `ID` int(11) NOT NULL auto_increment,
  `Field1` varchar(50) default NULL,
  `Memno` varchar(30) default NULL,
  `Mr_Mrs` varchar(4) default NULL,
  `Name` varchar(50) default NULL,
  `Father_Husband` varchar(50) default NULL,
  `Receipt` varchar(20) default '0',
  `dob` varchar(20) default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Town` varchar(50) default NULL,
  `Area` varchar(50) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `Mobile` text,
  `EMail` varchar(255) default NULL,
  `Profession_MK` varchar(50) default NULL,
  `Profession` varchar(255) default NULL,
  `Qualification` varchar(50) default NULL,
  `Proposed_by` varchar(50) default NULL,
  `Seconder` varchar(255) default NULL,
  `nic` varchar(50) default NULL,
  `Category` varchar(50) default NULL,
  `foi1` varchar(40) default NULL,
  `foi2` varchar(40) default '',
  `foi3` varchar(40) default NULL,
  `image` varchar(20) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "expiredmem"
#


#
# Source for table "expiredmem01"
#

DROP TABLE IF EXISTS `expiredmem01`;
CREATE TABLE `expiredmem01` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Field3` varchar(255) default NULL,
  `Name` varchar(255) default NULL,
  `Father's Name` varchar(255) default NULL,
  `Field2` varchar(255) default NULL,
  `Receipt No` varchar(255) default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Field4` varchar(255) default NULL,
  `Field6` varchar(255) default NULL,
  `Field5` varchar(255) default NULL,
  `Phone-1` varchar(255) default NULL,
  `Phone-2` varchar(255) default NULL,
  `Field7` varchar(255) default NULL,
  `E-Mail` varchar(255) default NULL,
  `Profession` varchar(255) default NULL,
  `Field of Interest` varchar(255) default NULL,
  `Interest` varchar(255) default NULL,
  `Interest 2` varchar(255) default NULL,
  `Interest 3` varchar(255) default NULL,
  `Proposed by` varchar(255) default NULL,
  `Seconder` varchar(255) default NULL,
  `1` varchar(255) default NULL,
  `2` varchar(255) default NULL,
  `3` varchar(255) default NULL,
  `4` varchar(255) default NULL,
  `5` varchar(255) default NULL,
  `6` varchar(255) default NULL,
  `7` varchar(255) default NULL,
  `8` varchar(255) default NULL,
  `9` varchar(255) default NULL,
  `0` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "expiredmem01"
#


#
# Source for table "field_interest"
#

DROP TABLE IF EXISTS `field_interest`;
CREATE TABLE `field_interest` (
  `mem_no` varchar(20) NOT NULL,
  `field_of_interest` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "field_interest"
#

/*!40000 ALTER TABLE `field_interest` DISABLE KEYS */;
/*!40000 ALTER TABLE `field_interest` ENABLE KEYS */;

#
# Source for table "for membership cards"
#

DROP TABLE IF EXISTS `for membership cards`;
CREATE TABLE `for membership cards` (
  `Memno` varchar(8) default NULL,
  UNIQUE KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "for membership cards"
#


#
# Source for table "for staff cards"
#

DROP TABLE IF EXISTS `for staff cards`;
CREATE TABLE `for staff cards` (
  `Staffno` varchar(8) default NULL,
  UNIQUE KEY `Staffno` (`Staffno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "for staff cards"
#


#
# Source for table "honorary_members"
#

DROP TABLE IF EXISTS `honorary_members`;
CREATE TABLE `honorary_members` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(255) default NULL,
  `Name` varchar(255) default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `EMail` varchar(255) default NULL,
  `Profession` varchar(255) default NULL,
  `foi1` varchar(255) default NULL,
  `image` varchar(100) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "honorary_members"
#


#
# Source for table "honorary_members_old"
#

DROP TABLE IF EXISTS `honorary_members_old`;
CREATE TABLE `honorary_members_old` (
  `ID` int(11) NOT NULL auto_increment,
  `Memno` varchar(15) default NULL,
  `Mr_Mrs` varchar(10) NOT NULL,
  `Name` varchar(50) default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `EMail` varchar(255) default NULL,
  `Profession` varchar(255) default NULL,
  `foi1` varchar(255) default NULL,
  `image` varchar(20) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "honorary_members_old"
#


#
# Source for table "list of candidate 2010 aazad"
#

DROP TABLE IF EXISTS `list of candidate 2010 aazad`;
CREATE TABLE `list of candidate 2010 aazad` (
  `Memno` varchar(8) default NULL,
  `Applied for` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "list of candidate 2010 aazad"
#


#
# Source for table "list of candidate for 2011"
#

DROP TABLE IF EXISTS `list of candidate for 2011`;
CREATE TABLE `list of candidate for 2011` (
  `Memno` varchar(8) default NULL,
  `Applied for` varchar(50) default NULL,
  KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "list of candidate for 2011"
#


#
# Source for table "login"
#

DROP TABLE IF EXISTS `login`;
CREATE TABLE `login` (
  `Id` int(11) NOT NULL auto_increment,
  `Username` varchar(50) NOT NULL default '',
  `Password` varchar(50) NOT NULL default '',
  PRIMARY KEY  (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Data for table "login"
#

/*!40000 ALTER TABLE `login` DISABLE KEYS */;
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

#
# Source for table "mailing list for 2012"
#

DROP TABLE IF EXISTS `mailing list for 2012`;
CREATE TABLE `mailing list for 2012` (
  `Memno` varchar(8) default NULL,
  UNIQUE KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "mailing list for 2012"
#


#
# Source for table "memno authors list"
#

DROP TABLE IF EXISTS `memno authors list`;
CREATE TABLE `memno authors list` (
  `Memno` varchar(8) default NULL,
  UNIQUE KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memno authors list"
#


#
# Source for table "memno for member gb"
#

DROP TABLE IF EXISTS `memno for member gb`;
CREATE TABLE `memno for member gb` (
  `Memno` varchar(8) default NULL,
  UNIQUE KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memno for member gb"
#


#
# Source for table "memsub2005voter"
#

DROP TABLE IF EXISTS `memsub2005voter`;
CREATE TABLE `memsub2005voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2005voter"
#


#
# Source for table "memsub2006voter"
#

DROP TABLE IF EXISTS `memsub2006voter`;
CREATE TABLE `memsub2006voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(255) default '25',
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2006voter"
#


#
# Source for table "memsub2007voter"
#

DROP TABLE IF EXISTS `memsub2007voter`;
CREATE TABLE `memsub2007voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2007voter"
#


#
# Source for table "memsub2009voter"
#

DROP TABLE IF EXISTS `memsub2009voter`;
CREATE TABLE `memsub2009voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2009voter"
#


#
# Source for table "memsub2010voter"
#

DROP TABLE IF EXISTS `memsub2010voter`;
CREATE TABLE `memsub2010voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2010voter"
#


#
# Source for table "memsub2011voter"
#

DROP TABLE IF EXISTS `memsub2011voter`;
CREATE TABLE `memsub2011voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2011voter"
#


#
# Source for table "memsub2012voter"
#

DROP TABLE IF EXISTS `memsub2012voter`;
CREATE TABLE `memsub2012voter` (
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Recept` double default NULL,
  `Todate` varchar(50) default NULL,
  `AMT` double default NULL,
  `RECPTNO` double default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2012voter"
#


#
# Source for table "memsub2012voter_old"
#

DROP TABLE IF EXISTS `memsub2012voter_old`;
CREATE TABLE `memsub2012voter_old` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "memsub2012voter_old"
#


#
# Source for table "memsub2013voter"
#

DROP TABLE IF EXISTS `memsub2013voter`;
CREATE TABLE `memsub2013voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "memsub2013voter"
#


#
# Source for table "memsub2014voter"
#

DROP TABLE IF EXISTS `memsub2014voter`;
CREATE TABLE `memsub2014voter` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Recept` varchar(11) default NULL,
  `Todate` varchar(25) default NULL,
  `AMT` varchar(11) default '300',
  `RECPTNO` varchar(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "memsub2014voter"
#


#
# Source for table "old address as march 2011"
#

DROP TABLE IF EXISTS `old address as march 2011`;
CREATE TABLE `old address as march 2011` (
  `ID` int(11) default NULL,
  `Field1` varchar(50) default NULL,
  `Memno` varchar(8) default NULL,
  `Mr&Mrs` varchar(4) default NULL,
  `Name` varchar(50) default NULL,
  `Father/Husband Name` varchar(50) default NULL,
  `Receipt No` int(11) default NULL,
  `Date of Birth` datetime default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Town` varchar(50) default NULL,
  `Name Wise` varchar(50) default NULL,
  `Field2` varchar(50) default NULL,
  `Phone-1` varchar(255) default NULL,
  `Phone-2` varchar(255) default NULL,
  `Mobile` varchar(50) default NULL,
  `E-Mail` varchar(255) default NULL,
  `Profession MK` varchar(50) default NULL,
  `Profession` varchar(255) default NULL,
  `Field of Interest-1` varchar(50) default NULL,
  `Field of Interest-2` varchar(50) default NULL,
  `Field of Interest-3` varchar(50) default NULL,
  `Qualification` varchar(50) default NULL,
  `Proposed by` varchar(50) default NULL,
  `Seconder` varchar(255) default NULL,
  `ID Card No` varchar(50) default NULL,
  `Category` varchar(50) default NULL,
  `1` int(11) default NULL,
  `2` varchar(50) default NULL,
  `3` varchar(50) default NULL,
  `4` varchar(50) default NULL,
  `5` varchar(50) default NULL,
  `6` varchar(50) default NULL,
  `7` varchar(50) default NULL,
  `8` varchar(50) default NULL,
  `9` varchar(50) default NULL,
  `10` varchar(50) default NULL,
  `11` varchar(50) default NULL,
  `12` varchar(50) default NULL,
  `13` varchar(50) default NULL,
  `14` varchar(50) default NULL,
  `15` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "old address as march 2011"
#


#
# Source for table "paste errors"
#

DROP TABLE IF EXISTS `paste errors`;
CREATE TABLE `paste errors` (
  `Field0` text,
  `Field1` text,
  `Field2` text,
  `Field3` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "paste errors"
#


#
# Source for table "remove_members"
#

DROP TABLE IF EXISTS `remove_members`;
CREATE TABLE `remove_members` (
  `ID` int(11) NOT NULL auto_increment,
  `Field1` varchar(15) default NULL,
  `Memno` varchar(15) NOT NULL default '',
  `Mr_Mrs` varchar(4) default NULL,
  `Name` varchar(50) default NULL,
  `Father_Husband` varchar(50) default NULL,
  `Receipt` int(11) default '0',
  `dob` date default NULL,
  `Add1` varchar(100) default NULL,
  `Add2` varchar(100) default NULL,
  `Add3` varchar(100) default NULL,
  `Add4` varchar(100) default NULL,
  `Town` varchar(50) default NULL,
  `Area` varchar(50) default NULL,
  `Phone1` varchar(255) default NULL,
  `Phone2` varchar(255) default NULL,
  `Mobile` varchar(50) default NULL,
  `EMail` varchar(255) default NULL,
  `Profession_MK` varchar(50) default NULL,
  `Profession` varchar(255) default NULL,
  `Qualification` varchar(50) default NULL,
  `Proposed_by` varchar(50) default NULL,
  `Seconder` varchar(255) default NULL,
  `nic` varchar(50) default NULL,
  `Category` varchar(50) default NULL,
  `foi1` varchar(40) default '',
  `foi2` varchar(40) default '',
  `foi3` varchar(40) default '',
  `image` varchar(20) default '',
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "remove_members"
#


#
# Source for table "state life members list (all)"
#

DROP TABLE IF EXISTS `state life members list (all)`;
CREATE TABLE `state life members list (all)` (
  `Field1` double default NULL,
  `Memno` varchar(255) default NULL,
  `Name` varchar(255) default NULL,
  `Add1` varchar(255) default NULL,
  `Add2` varchar(255) default NULL,
  `Add3` varchar(255) default NULL,
  `Add4` varchar(255) default NULL,
  `Phone-1` varchar(255) default NULL,
  `Phone-2` varchar(255) default NULL,
  `Date of Birth` datetime default NULL,
  KEY `Memno` (`Memno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "state life members list (all)"
#


#
# Source for table "state life membership approved (memno)"
#

DROP TABLE IF EXISTS `state life membership approved (memno)`;
CREATE TABLE `state life membership approved (memno)` (
  `Field1` varchar(50) default NULL,
  `Memno` varchar(50) default NULL,
  `Name` varchar(50) default NULL,
  `Field4` varchar(50) default NULL,
  `DOB` datetime default NULL,
  `Age` int(11) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "state life membership approved (memno)"
#


#
# Source for table "state life membership approved (memno)(21-08-2007)"
#

DROP TABLE IF EXISTS `state life membership approved (memno)(21-08-2007)`;
CREATE TABLE `state life membership approved (memno)(21-08-2007)` (
  `Field1` varchar(50) default NULL,
  `Memno` varchar(50) default NULL,
  `Name` varchar(50) default NULL,
  `Field4` varchar(50) default NULL,
  `DOB` datetime default NULL,
  `Age` int(11) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "state life membership approved (memno)(21-08-2007)"
#


#
# Source for table "state life mimbersb list (approved)"
#

DROP TABLE IF EXISTS `state life mimbersb list (approved)`;
CREATE TABLE `state life mimbersb list (approved)` (
  `SNo` double default NULL,
  `Name` varchar(255) default NULL,
  `Date of Birth` datetime default NULL,
  `Age` double default NULL,
  `Sum Assured` double default NULL,
  `Rate` double default NULL,
  `Premium` double default NULL,
  `Field8` double default NULL,
  `Field9` double default NULL,
  `Field10` varchar(255) default NULL,
  `Field11` varchar(255) default NULL,
  `Field12` varchar(255) default NULL,
  `Field13` varchar(255) default NULL,
  `Field14` varchar(255) default NULL,
  `Field15` varchar(255) default NULL,
  `Field16` varchar(255) default NULL,
  `Field17` varchar(255) default NULL,
  `Field18` double default NULL,
  `Field19` varchar(255) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "state life mimbersb list (approved)"
#


#
# Source for table "t3"
#

DROP TABLE IF EXISTS `t3`;
CREATE TABLE `t3` (
  `ID` bigint(20) NOT NULL default '0',
  `nic` varchar(255) default ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "t3"
#


#
# Source for table "underpostal2005"
#

DROP TABLE IF EXISTS `underpostal2005`;
CREATE TABLE `underpostal2005` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` double default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2005"
#


#
# Source for table "underpostal2005_old"
#

DROP TABLE IF EXISTS `underpostal2005_old`;
CREATE TABLE `underpostal2005_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Outstanding` varchar(20) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2005_old"
#


#
# Source for table "underpostal2006"
#

DROP TABLE IF EXISTS `underpostal2006`;
CREATE TABLE `underpostal2006` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` double default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2006"
#


#
# Source for table "underpostal2006_old"
#

DROP TABLE IF EXISTS `underpostal2006_old`;
CREATE TABLE `underpostal2006_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Outstanding` varchar(20) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2006_old"
#


#
# Source for table "underpostal2007"
#

DROP TABLE IF EXISTS `underpostal2007`;
CREATE TABLE `underpostal2007` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` double default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2007"
#


#
# Source for table "underpostal2007_old"
#

DROP TABLE IF EXISTS `underpostal2007_old`;
CREATE TABLE `underpostal2007_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Outstanding` varchar(20) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2007_old"
#


#
# Source for table "underpostal2008"
#

DROP TABLE IF EXISTS `underpostal2008`;
CREATE TABLE `underpostal2008` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` double default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2008"
#


#
# Source for table "underpostal2008_old"
#

DROP TABLE IF EXISTS `underpostal2008_old`;
CREATE TABLE `underpostal2008_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Outstanding` varchar(20) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2008_old"
#


#
# Source for table "underpostal2009"
#

DROP TABLE IF EXISTS `underpostal2009`;
CREATE TABLE `underpostal2009` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2009"
#


#
# Source for table "underpostal2009_old"
#

DROP TABLE IF EXISTS `underpostal2009_old`;
CREATE TABLE `underpostal2009_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(8) default NULL,
  `Outstanding` varchar(50) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2009_old"
#


#
# Source for table "underpostal2010"
#

DROP TABLE IF EXISTS `underpostal2010`;
CREATE TABLE `underpostal2010` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2010"
#


#
# Source for table "underpostal2010_old"
#

DROP TABLE IF EXISTS `underpostal2010_old`;
CREATE TABLE `underpostal2010_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(8) default NULL,
  `Outstanding` varchar(50) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2010_old"
#


#
# Source for table "underpostal2011"
#

DROP TABLE IF EXISTS `underpostal2011`;
CREATE TABLE `underpostal2011` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2011"
#


#
# Source for table "underpostal2011_old"
#

DROP TABLE IF EXISTS `underpostal2011_old`;
CREATE TABLE `underpostal2011_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(8) default NULL,
  `Outstanding` varchar(50) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2011_old"
#


#
# Source for table "underpostal2012"
#

DROP TABLE IF EXISTS `underpostal2012`;
CREATE TABLE `underpostal2012` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2012"
#


#
# Source for table "underpostal2012_old"
#

DROP TABLE IF EXISTS `underpostal2012_old`;
CREATE TABLE `underpostal2012_old` (
  `Id` bigint(20) unsigned NOT NULL auto_increment,
  `Memno` varchar(8) default NULL,
  `Outstanding` varchar(50) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2012_old"
#


#
# Source for table "underpostal2013"
#

DROP TABLE IF EXISTS `underpostal2013`;
CREATE TABLE `underpostal2013` (
  `ID` bigint(20) NOT NULL auto_increment,
  `Field1` varchar(255) default NULL,
  `Memno` varchar(255) default NULL,
  `Outstanding` double default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2013"
#


#
# Source for table "underpostal2013_old"
#

DROP TABLE IF EXISTS `underpostal2013_old`;
CREATE TABLE `underpostal2013_old` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Outstanding` varchar(20) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2013_old"
#


#
# Source for table "underpostal2014"
#

DROP TABLE IF EXISTS `underpostal2014`;
CREATE TABLE `underpostal2014` (
  `Id` bigint(20) NOT NULL auto_increment,
  `Memno` varchar(10) default NULL,
  `Outstanding` varchar(20) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "underpostal2014"
#


/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
