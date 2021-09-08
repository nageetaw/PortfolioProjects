-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 05, 2021 at 04:34 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `maillistmanager`
--

-- --------------------------------------------------------

--
-- Table structure for table `leads_list_table`
--

CREATE TABLE `leads_list_table` (
  `Id` int(255) NOT NULL,
  `first_name` text NOT NULL,
  `last_name` text NOT NULL,
  `address` text NOT NULL,
  `city` text NOT NULL,
  `state` text NOT NULL,
  `zip_code` text NOT NULL,
  `lists` text DEFAULT NULL,
  `status` text NOT NULL,
  `offer` text DEFAULT NULL,
  `email` text DEFAULT NULL,
  `phone` text DEFAULT NULL,
  `created` datetime DEFAULT NULL,
  `modified` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leads_list_table`
--

INSERT INTO `leads_list_table` (`Id`, `first_name`, `last_name`, `address`, `city`, `state`, `zip_code`, `lists`, `status`, `offer`, `email`, `phone`, `created`, `modified`) VALUES
(1, 'Stryker      ', 'Reedy', '1508 Alcott      ', 'Fort Collins      ', 'COO  ', '80525      ', 'IBB4Q19,ABCD      ', 'Valid      ', 'EDI,ABCD    ', 'jason@sinleymarketing.com      ', '970-798-0411      ', '2020-11-19 02:55:05', '2020-11-22 03:29:59'),
(2, 'John      ', 'Doe      ', '123 Mystreet      ', 'mytown      ', 'CO      ', '32983-1234      ', 'IBB4Q19      ', 'Reverse    ', 'IBB4Q19      ', '      ', '      ', '2020-11-19 02:55:05', '2020-11-22 07:53:20'),
(3, 'Gary', 'Riley', '345 main', 'yourtown', 'MN', '54365', 'IBB4Q19', 'Valid', '', 'abc@gmail.com', '', '2020-11-19 02:55:05', '2020-11-19 13:55:05'),
(4, 'Edward  ', 'Siu  ', '89745 1st ave  ', 'ourtown  ', 'TX  ', '77546  ', 'IBB4Q19  ', 'Nixie', '  ', '  ', '  ', '2020-11-19 02:55:05', '2020-11-22 03:04:16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `leads_list_table`
--
ALTER TABLE `leads_list_table`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `leads_list_table`
--
ALTER TABLE `leads_list_table`
  MODIFY `Id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
