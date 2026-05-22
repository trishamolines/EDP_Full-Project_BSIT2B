-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2026 at 05:34 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `molines_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllogincredentials`
--

CREATE TABLE `tbllogincredentials` (
  `loginID` int(11) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `userID` int(11) NOT NULL,
  `is_active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbllogincredentials`
--

INSERT INTO `tbllogincredentials` (`loginID`, `user_username`, `user_password`, `userID`, `is_active`) VALUES
(1, 'user1', 'password', 2, 1),
(3, 'admin', 'admin', 1, 1),
(7, 'seokjin92', 'worldwidehandsome', 3, 1),
(11, 'avrilmae', 'gorgeous', 7, 0),
(12, 'ritchiemae', 'mishika2', 8, 0),
(14, 'ritchiemae', 'mishika2', 10, 1),
(15, 'sunookim', '12345', 11, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbluserinformation`
--

CREATE TABLE `tbluserinformation` (
  `userID` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL,
  `emailAddress` varchar(255) NOT NULL,
  `homeAddress` varchar(255) NOT NULL,
  `birthDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluserinformation`
--

INSERT INTO `tbluserinformation` (`userID`, `firstname`, `middlename`, `lastname`, `emailAddress`, `homeAddress`, `birthDate`) VALUES
(1, 'trisha ', 'orejana', 'molines', 'trishamolines37@gmail.com', 'BLK 68 LOT 1 Brgy. San Juan, A-G', '2006-05-08'),
(2, 'jungwon', 'delos reyes', 'yang', 'yangjungwon9@gmail.com', 'BLK 41 LOT 2 Brgy. Pitipiwpiw, A-E', '2004-02-09'),
(3, 'seokjin', 'yearner', 'kim', 'kimseokjin1992@gmail.com', 'BLK 43 LOT 4 Brgy. San Simon, A-C', '1992-12-04'),
(7, 'april mae', 'temiozo', 'combalicer', 'aprilcombalicer27@gmail.com', 'BLK 65 LOT 8 Brgy. Ka-freshness, A-4', '2005-03-27'),
(8, 'ritchie ', 'senit', 'montuerto', 'ritchiemontuerto8@gmail.com', 'BLK 64 LOT 7 Brgy. Editorism, A-B', '2006-05-28'),
(10, 'ritchie', 'senit', 'montuerto', 'ritchiemontuerto8@gmail.com', 'BLK 64 LOT 7 Brgy. Editorism, A-B', '2006-05-28'),
(11, 'sunoo', 'molines', 'kim', 'kimsunoo@gmail.com', 'BLK 65 LOT 2 Brgy. San Simon A-D', '2026-05-17');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllogincredentials`
--
ALTER TABLE `tbllogincredentials`
  ADD PRIMARY KEY (`loginID`);

--
-- Indexes for table `tbluserinformation`
--
ALTER TABLE `tbluserinformation`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllogincredentials`
--
ALTER TABLE `tbllogincredentials`
  MODIFY `loginID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbluserinformation`
--
ALTER TABLE `tbluserinformation`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
