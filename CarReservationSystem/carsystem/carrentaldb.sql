-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 21, 2020 at 01:31 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `carrentaldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `carstocks`
--

CREATE TABLE `carstocks` (
  `C_NAME` varchar(50) NOT NULL,
  `STATUS` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `carstocks`
--

INSERT INTO `carstocks` (`C_NAME`, `STATUS`) VALUES
('2018 Honda Civic', 'RETURNED'),
('2019 Honda Civic', 'RETURNED'),
('BMW 2015', 'RETURNED'),
('Carola 2018', 'RESERVED'),
('Civic 2018', 'RESERVED'),
('Ferari 2019', 'RETURNED'),
('Honda Civic 2020', 'RESERVED'),
('Suzuki 2015', 'RESERVED');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `C_ID` int(11) NOT NULL,
  `FIRST_NAME` varchar(40) NOT NULL,
  `LAST_NAME` varchar(40) NOT NULL,
  `EMAIL_ID` varchar(50) DEFAULT NULL,
  `NIC_NUMBER` int(11) DEFAULT NULL,
  `PHONE_NUMBER` int(11) DEFAULT NULL,
  `PASSWORD` varchar(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`C_ID`, `FIRST_NAME`, `LAST_NAME`, `EMAIL_ID`, `NIC_NUMBER`, `PHONE_NUMBER`, `PASSWORD`) VALUES
(1, 'hina', 'ahmed', 'sara@gmail.com', 45210963, 302356930, '1100'),
(2, 'ZEESHAN', 'ALI', 'ZEESHAN@GMAIL', 8960963, 356987120, '12'),
(3, 'ALI', 'ZUBHAIR', 'ALIZES@GMAIL.com', 452522263, 302356930, '13'),
(4, 'SARA', 'KHAN', 'SARA@GMAIL', 8968523, 356987120, '14'),
(5, 'sonia', 'khana', 'sknaa@gmail.com', 925454545, 90078601, '12345'),
(6, 'hina', 'akmal', 'hina@gmail.com', 45108859, 21598736, 'hinaakmal'),
(7, 'alia', 'khan', 'khan123@gmail.com', 895122122, 9896325, '5200'),
(8, 'kinza', 'kiran', 'kinza@gmail.com', 45963215, 928975631, 'kinza123'),
(9, 'john', 'johny', 'john@gmail.com', 85961, 989966321, 'john123'),
(10, 'zahiad', 'khan', 'zahidkhan@gmail.com', 1234567891, 123456789, 'khan0011'),
(11, 'Hina', 'IQbal', 'hina@gmail.com', 451203, 99896321, 'hina123'),
(12, 'Sumbul', 'Chachar', 'shhh@gmail.com', 12121, 9895322, 'sum1');

-- --------------------------------------------------------

--
-- Table structure for table `customer_histroy`
--

CREATE TABLE `customer_histroy` (
  `C_ID` int(11) DEFAULT NULL,
  `C_NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer_histroy`
--

INSERT INTO `customer_histroy` (`C_ID`, `C_NAME`) VALUES
(2, 'Suzuki Cultus 2019'),
(1, 'Honda Civic 2020'),
(2, 'Honda Civic 2020'),
(1, 'BMW 2015'),
(3, 'Carola 2018'),
(1, 'Suzuki 2015'),
(1, 'Civic 2018'),
(1, 'Carola 2018');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `R_ID` int(11) NOT NULL,
  `C_ID` int(11) DEFAULT NULL,
  `C_NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`R_ID`, `C_ID`, `C_NAME`) VALUES
(3, 2, 'Honda Civic 2020'),
(6, 1, 'Suzuki 2015'),
(7, 1, 'Civic 2018'),
(8, 1, 'Carola 2018');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `carstocks`
--
ALTER TABLE `carstocks`
  ADD PRIMARY KEY (`C_NAME`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`C_ID`),
  ADD UNIQUE KEY `NIC_NUMBER` (`NIC_NUMBER`);

--
-- Indexes for table `customer_histroy`
--
ALTER TABLE `customer_histroy`
  ADD KEY `CUSTOMER_HISTROY_FK` (`C_ID`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`R_ID`),
  ADD KEY `RESERVATION_FK` (`C_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `R_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer_histroy`
--
ALTER TABLE `customer_histroy`
  ADD CONSTRAINT `CUSTOMER_HISTROY_FK` FOREIGN KEY (`C_ID`) REFERENCES `customers` (`C_ID`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `RESERVATION_FK` FOREIGN KEY (`C_ID`) REFERENCES `customers` (`C_ID`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
