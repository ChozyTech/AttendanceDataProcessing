/*
SQLyog Community v12.5.0 (64 bit)
MySQL - 10.1.31-MariaDB : Database - absensi
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`absensi` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `absensi`;

/*Table structure for table `tblharikerja` */

DROP TABLE IF EXISTS `tblharikerja`;

CREATE TABLE `tblharikerja` (
  `kode` varchar(10) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `keterangan` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`kode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblharikerja` */

insert  into `tblharikerja`(`kode`,`nama`,`keterangan`) values 
('001','Rico','R'),
('002','Chris','C');

/*Table structure for table `tbljamkerja` */

DROP TABLE IF EXISTS `tbljamkerja`;

CREATE TABLE `tbljamkerja` (
  `kode` varchar(10) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `keterangan` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`kode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbljamkerja` */

insert  into `tbljamkerja`(`kode`,`nama`,`keterangan`) values 
('001','Chris',NULL),
('002','Rico','R'),
('003','Adit','Normak'),
('004','Hafiz','W');

/*Table structure for table `tblkaryawan` */

DROP TABLE IF EXISTS `tblkaryawan`;

CREATE TABLE `tblkaryawan` (
  `kode` varchar(10) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `ttl` varchar(20) DEFAULT NULL,
  `notelp` varchar(20) DEFAULT NULL,
  `jamkerja` varchar(20) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `tglmasuk` date DEFAULT NULL,
  `tglkeluar` date DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`kode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblkaryawan` */

insert  into `tblkaryawan`(`kode`,`nama`,`alamat`,`ttl`,`notelp`,`jamkerja`,`email`,`tglmasuk`,`tglkeluar`,`keterangan`) values 
('a','a','a','a,2018-05-22','a','a','a','2018-05-22','2018-05-22','a'),
('asdasda','asdasdasdas','asdasd','kgjgjh,22/05/2018','hgjhgjhg','jhgjhg','jhgjhg','2018-05-22','2018-05-22','jhgjhgjhg'),
('asjk','aksjdka','aksjda','kasjdj,2018-05-22','aksjdk','askjdk','kasjdk','2018-05-22','2018-05-22','kajka'),
('chris','asu','kntl',NULL,NULL,NULL,NULL,NULL,NULL,'1'),
('jkhlhkjh','kjhkjh','kjhkj','hkjhk,2018-05-22','jhkjhk','jhkjh','kjhkjhk','2018-05-22','2018-05-22','jhkjhkjh'),
('kdjf','su','jl','asoasoa,22/05/2018','0909234','12','ackck','2018-05-22','2018-05-22','kdsfksmfksdf');

/*Table structure for table `tbluser` */

DROP TABLE IF EXISTS `tbluser`;

CREATE TABLE `tbluser` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(10) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tbluser` */

insert  into `tbluser`(`iduser`,`username`,`password`) values 
(1,'admin','YWRtaW4=');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
