-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 30, 2020 at 05:41 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_berese`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(64) NOT NULL,
  `Password` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`ID`, `Nama`, `Password`) VALUES
(0, 'Antares', '1234'),
(1, 'Ferdinand', '1234'),
(2, 'Maria', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `bengkel`
--

CREATE TABLE `bengkel` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(64) NOT NULL,
  `Address` varchar(64) NOT NULL,
  `Contact` int(12) NOT NULL,
  `Job_Desc` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bengkel`
--

INSERT INTO `bengkel` (`ID`, `Nama`, `Address`, `Contact`, `Job_Desc`) VALUES
(1, 'The Dotux', 'Airmadidi Bawah, Minahasa Utara', 254636952, 'Service, Ban Dalam, Ban Luar'),
(2, 'Broh', 'Airmadidi Atas, Minahasa Utara', 125487635, 'Ganti Oli, Ban Luar, Isi Angin');

-- --------------------------------------------------------

--
-- Table structure for table `kendaraan`
--

CREATE TABLE `kendaraan` (
  `ID` int(11) NOT NULL,
  `Tipe_Motor` varchar(15) NOT NULL,
  `Merek` varchar(64) NOT NULL,
  `Mesin` varchar(64) NOT NULL,
  `Warna` varchar(64) NOT NULL,
  `Tahun_Pembuatan` varchar(64) NOT NULL,
  `No_Polisi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kendaraan`
--

INSERT INTO `kendaraan` (`ID`, `Tipe_Motor`, `Merek`, `Mesin`, `Warna`, `Tahun_Pembuatan`, `No_Polisi`) VALUES
(1, 'Manual', 'Honda CBR 250R', '250 CC', 'Hitam Metalik', '2017', 1050),
(2, 'Automatic', 'Honda Beat', '110 CC ESP', 'Merah - Abu-Abu', '2020', 1125);

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `ID` int(11) NOT NULL,
  `First Name` varchar(64) NOT NULL,
  `Last Name` varchar(64) NOT NULL,
  `ID_Vehicle` int(10) NOT NULL,
  `Address` varchar(64) NOT NULL,
  `Contact` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`ID`, `First Name`, `Last Name`, `ID_Vehicle`, `Address`, `Contact`) VALUES
(1, 'Maria', 'Sambur', 2, 'Amurang', 142563877),
(2, 'Prince', 'Siahaan', 1, 'Luwuk, Sulawesi Tengah', 125463587);

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `ID` int(10) NOT NULL,
  `Job_Desc` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `request`
--

INSERT INTO `request` (`ID`, `Job_Desc`) VALUES
(1, 'Isi Angin'),
(2, 'Isi Angin, Ban Luar');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `ID_Service` int(11) NOT NULL,
  `ID_Bengkel` int(11) NOT NULL,
  `ID_Request` int(11) NOT NULL,
  `ID_Member` int(11) NOT NULL,
  `Date_Start` datetime NOT NULL,
  `Date_Finish` datetime NOT NULL,
  `Cost` int(64) NOT NULL,
  `Status` enum('Finish','Pending','On Going','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`ID_Service`, `ID_Bengkel`, `ID_Request`, `ID_Member`, `Date_Start`, `Date_Finish`, `Cost`, `Status`) VALUES
(1, 2, 1, 2, '2020-11-10 10:58:42', '2020-11-11 13:58:42', 125000, 'On Going');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bengkel`
--
ALTER TABLE `bengkel`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `kendaraan`
--
ALTER TABLE `kendaraan`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_Vehicle` (`ID_Vehicle`);

--
-- Indexes for table `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`ID_Service`),
  ADD KEY `ID_Bengkel` (`ID_Bengkel`,`ID_Request`,`ID_Member`),
  ADD KEY `ID_Request` (`ID_Request`),
  ADD KEY `ID_Member` (`ID_Member`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `member`
--
ALTER TABLE `member`
  ADD CONSTRAINT `member_ibfk_1` FOREIGN KEY (`ID_Vehicle`) REFERENCES `kendaraan` (`ID`);

--
-- Constraints for table `service`
--
ALTER TABLE `service`
  ADD CONSTRAINT `service_ibfk_1` FOREIGN KEY (`ID_Request`) REFERENCES `request` (`ID`),
  ADD CONSTRAINT `service_ibfk_2` FOREIGN KEY (`ID_Member`) REFERENCES `member` (`ID`),
  ADD CONSTRAINT `service_ibfk_3` FOREIGN KEY (`ID_Bengkel`) REFERENCES `bengkel` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
