-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2024 at 07:12 AM
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
-- Database: `elysia`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `categoryID` char(1) NOT NULL,
  `categoryName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`categoryID`, `categoryName`) VALUES
('A', 'Sheet Metal'),
('B', 'Major Asssemblies'),
('C', 'Light Components'),
('D', 'Accessories');

-- --------------------------------------------------------

--
-- Table structure for table `dealer`
--

CREATE TABLE `dealer` (
  `dealerID` char(7) NOT NULL,
  `dName` varchar(70) NOT NULL,
  `dCompany` varchar(255) NOT NULL,
  `dPhone` char(8) NOT NULL,
  `dEmail` varchar(255) NOT NULL,
  `dComAdd` varchar(255) NOT NULL,
  `dDelivAdd` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dealer`
--

INSERT INTO `dealer` (`dealerID`, `dName`, `dCompany`, `dPhone`, `dEmail`, `dComAdd`, `dDelivAdd`) VALUES
('DL00001', 'Sandra LO', 'Robot Motor', '23234141', 'robotmator@gmail.com', 'G/F, Shing Tak Building, 16 Shing Tak Street, TO KWA WAN, KOWLOON', 'Flat D, 9/F, Ka Lai Mansion, Jade Field Garden, 15-19 Ngau Tau Kok Road, NGAU TAU KOK, KOWLOON'),
('DL00002', 'Micheal LEE', 'Automate Spare', '32563256', 'automatespare@gmail.com', 'G/F, Block C-D, Ka Ming Court, 688-690 Castle Peak Road, CHEUNG SHA WAN, KOWLOON', ''),
('DL00003', 'Oscar LEUNG', 'Fast Line Spares', '26263939', 'flspares@gmail.com', 'G/F, Cheong Hing Building, 32 Yan Hing Street, TAI PO, N.T.', ''),
('DL00004', 'Josie CHEUNG', 'Josie Car Spares', '27276969', 'josiecar@gmail.com', 'Flat B, G/F, Benefit Industrial Factory Building, 59-61 Wong Chuk Hang Road, WONG CHUK HANG, HONG KONG', ''),
('DL00005', 'Scott LI', 'Car Healthy Center', '28286060', 'carhealthy@gmail.com', 'Flat C, G/F, Des Voeux Building, 19-25 Des Voeux Road West, SAI YING PUN, HONG KONG', 'G/F, Hong Ming Building, 233 Des Voeux Road West, SAI YING PUN, HONG KONG');

-- --------------------------------------------------------

--
-- Table structure for table `dept`
--

CREATE TABLE `dept` (
  `deptID` char(2) NOT NULL,
  `deptName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dept`
--

INSERT INTO `dept` (`deptID`, `deptName`) VALUES
('AC', 'Accountant'),
('AD', 'Admin'),
('GI', 'Goods Inward Department'),
('HR', 'Human Resources'),
('IS', 'Invoicing Section'),
('PD', 'Purchasing Department'),
('SD', 'Spares Dispatch Department'),
('SO', 'Sales Office'),
('SP', 'Spare Parts Store'),
('SR', 'Stock Record Clerk');

-- --------------------------------------------------------

--
-- Table structure for table `emp`
--

CREATE TABLE `emp` (
  `empID` char(6) NOT NULL,
  `empName` varchar(70) NOT NULL,
  `empGander` char(1) DEFAULT NULL,
  `empPhone` char(8) NOT NULL,
  `empEmail` varchar(255) NOT NULL,
  `deptID` char(2) NOT NULL,
  `empPostion` varchar(50) NOT NULL,
  `empPasswd` varchar(16) NOT NULL,
  `empStatus` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `emp`
--

INSERT INTO `emp` (`empID`, `empName`, `empGander`, `empPhone`, `empEmail`, `deptID`, `empPostion`, `empPasswd`, `empStatus`) VALUES
('E00000', 'Admin', NULL, '12345678', 'e00000@lc.com', 'AD', 'Admin', '1234', 'A'),
('E00001', 'Peter Chan', 'M', '23604141', 'e00001@lc.com', 'HR', 'Manager', '1234', 'A'),
('E00002', 'Betty Lam', 'F', '23605628', 'e00002@lc.com', 'SO', 'Crew', '1234', 'A'),
('E00003', 'Ben Lau', 'M', '23623622', 'e00003@lc.com', 'SP', 'Store Menager', '1234', 'A'),
('E00004', 'James Yeung', NULL, '23633388', 'e00004@lc.com', 'SD', 'Team Leader', '1234', 'A'),
('E00005', 'Richard Mak', 'M', '23645566', 'e00005@lc.com', 'IS', 'Clerk', '1234', 'A'),
('E00006', 'Jennifer Ma', 'F', '23659824', 'e00006@lc.com', 'SR', 'Clerk', '1234', 'A'),
('E00007', 'Joseph Wong', 'M', '23667788', 'e00007@lc.com', 'PD', 'Manager', '1234', 'A'),
('E00008', 'Daniel Tsui', 'M', '23679090', 'e00008@lc.com', 'GI', 'Crew', '1234', 'A'),
('E00009', 'Sandra Ip', 'F', '23687321', 'e00009@lc.com', 'AC', 'Accountant', '1234', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `goodinwardpart`
--

CREATE TABLE `goodinwardpart` (
  `reorderID` char(10) NOT NULL,
  `partID` char(6) NOT NULL,
  `receiveDate` date DEFAULT NULL,
  `roQty` int(12) NOT NULL,
  `actGiQty` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `goodinwardpart`
--

INSERT INTO `goodinwardpart` (`reorderID`, `partID`, `receiveDate`, `roQty`, `actGiQty`) VALUES
('R000000101', 'D00004', '2023-10-21', 15736, 15736),
('R159357462', 'C00003', '2023-04-01', 985, 985),
('R231021410', 'A00001', '2024-05-20', 62358, 62358),
('R426813975', 'B00002', '2023-12-21', 4562, 4562),
('R799135460', 'A00005', NULL, 52035, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `orderID` char(10) NOT NULL,
  `copyID` int(1) NOT NULL,
  `invStatus` char(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`orderID`, `copyID`, `invStatus`) VALUES
('N000000002', 1, 'Sign'),
('N000000002', 2, 'Sign'),
('N000000002', 3, 'Sign'),
('N000000002', 4, 'Sign'),
('N000000003', 1, 'Sign'),
('N000000003', 2, 'Sign'),
('N000000003', 3, 'Send'),
('N000000003', 4, 'Send'),
('N000000004', 1, 'Wait'),
('N000000004', 2, 'Wait'),
('N000000004', 3, 'Wait'),
('N000000004', 4, 'Wait');

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

CREATE TABLE `log` (
  `logID` char(16) NOT NULL,
  `empID` char(6) NOT NULL,
  `partID` char(6) NOT NULL,
  `logChanges` int(12) NOT NULL,
  `logDes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `log`
--

INSERT INTO `log` (`logID`, `empID`, `partID`, `logChanges`, `logDes`) VALUES
('2023040115221903', 'E00008', 'C00003', 985, 'Goods Inwards'),
('2023102113150007', 'E00008', 'D00004', 15736, 'Goods Inwards'),
('2023122110236501', 'E00008', 'B00002', 4562, 'Goods Inwards'),
('2024030317202101', 'E00004', 'A00002', -3, 'despatched'),
('2024030317505303', 'E00004', 'A00003', -3, 'despatched'),
('2024032613552001', 'E00006', 'A00001', -3, 'scrap item'),
('2024041911450203', 'E00006', 'B00003', -2, 'scrap item'),
('2024042009000605', 'E00004', 'B00002', -20, 'despatched'),
('2024042012035005', 'E00004', 'D00002', -150, 'despatched'),
('2024042213520601', 'E00006', 'C00002', -5, 'scrap item'),
('2024050110265504', 'E00006', 'B00005', -7, 'scrap item'),
('2024050316235209', 'E00006', 'D00001', -2, 'scrap item'),
('2024050317223526', 'E00006', 'D00002', -1, 'scrap item'),
('2024050515260701', 'E00006', 'A00002', -3, 'scrap item'),
('2024050709382202', 'E00006', 'B00004', -5, 'scrap item'),
('2024052014352300', 'E00008', 'A00001', 62358, 'Goods Inwards');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `orderID` char(10) NOT NULL,
  `dealerID` char(7) NOT NULL,
  `orderStatus` varchar(10) NOT NULL DEFAULT 'Processing',
  `OutStanding` char(1) NOT NULL DEFAULT 'N',
  `orderDate` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`orderID`, `dealerID`, `orderStatus`, `OutStanding`, `orderDate`) VALUES
('N000000001', 'DL00002', 'Cancelled', 'N', '2023-10-12'),
('N000000002', 'DL00001', 'Despatched', 'N', '2024-03-03'),
('N000000003', 'DL00003', 'Despatched', 'Y', '2024-04-19'),
('N000000004', 'DL00004', 'Assembled', 'N', '2024-05-19'),
('N000000005', 'DL00002', 'Processing', 'N', '2024-05-21');

-- --------------------------------------------------------

--
-- Table structure for table `orderpart`
--

CREATE TABLE `orderpart` (
  `orderID` char(10) NOT NULL,
  `partID` char(6) NOT NULL,
  `orderQty` int(8) NOT NULL,
  `actDespQty` int(8) DEFAULT NULL,
  `opStatus` varchar(10) NOT NULL,
  `addToOrder` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orderpart`
--

INSERT INTO `orderpart` (`orderID`, `partID`, `orderQty`, `actDespQty`, `opStatus`, `addToOrder`) VALUES
('N000000001', 'A00001', 5, NULL, 'Cancelled', NULL),
('N000000001', 'C00001', 50, NULL, 'Cancelled', NULL),
('N000000001', 'C00003', 10, NULL, 'Cancelled', NULL),
('N000000002', 'A00002', 3, 3, 'Assembled', NULL),
('N000000002', 'A00003', 3, 3, 'Assembled', NULL),
('N000000003', 'B00002', 20, 20, 'Assembled', NULL),
('N000000003', 'C00005', 20, 0, 'OStanding', NULL),
('N000000003', 'D00002', 150, 150, 'Assembled', NULL),
('N000000003', 'D00004', 200, 50, 'OStanding', NULL),
('N000000004', 'B00003', 15, 15, 'Assembled', NULL),
('N000000004', 'B00005', 15, 15, 'Assembled', NULL),
('N000000005', 'A00001', 3, NULL, 'Processing', NULL),
('N000000005', 'B00004', 12, NULL, 'Processing', NULL),
('N000000005', 'D00002', 75, NULL, 'Processing', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `part`
--

CREATE TABLE `part` (
  `partID` char(6) NOT NULL,
  `categoryID` char(1) NOT NULL,
  `partName` varchar(255) NOT NULL,
  `price` float NOT NULL,
  `partQty` int(12) NOT NULL,
  `partStatus` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `part`
--

INSERT INTO `part` (`partID`, `categoryID`, `partName`, `price`, `partQty`, `partStatus`) VALUES
('A00001', 'A', 'Panel', 12000, 47968, 'Reorder'),
('A00002', 'A', 'Left door', 2300, 136279, 'Normal'),
('A00003', 'A', 'Right door', 2300, 26940, 'Danger'),
('A00004', 'A', 'Engine Cover', 1690, 0, 'Out-of-stock'),
('A00005', 'A', 'Trunk Lids', 3780, 186414, 'Reorder'),
('B00001', 'B', 'AC Components', 4688, 774867, 'Normal'),
('B00002', 'B', 'Car Engine Parts', 899, 5112, 'Danger'),
('B00003', 'B', 'Autoline Parts', 679, 94937, 'Normal'),
('B00004', 'B', 'Calipers and Brackets', 599, 52300, 'Normal'),
('B00005', 'B', 'Air Compressor', 3760, 365877, 'Normal'),
('C00001', 'C', 'LED Bulb', 250, 60822, 'Normal'),
('C00002', 'C', 'Tail Light', 350, 46790, 'Reorder'),
('C00003', 'C', 'Headlight', 299, 184805, 'Normal'),
('C00004', 'C', 'Dome Light', 286, 59269, 'Normal'),
('C00005', 'C', 'Headlights for Tesla X', 598, 0, 'Out-of-stock'),
('D00001', 'D', 'Car Tire Pressure Alarm', 150, 45678, 'Reorder'),
('D00002', 'D', 'Car USB Charger', 56, 87643, 'Normal'),
('D00003', 'D', 'Full Car Cover', 128, 2345, 'Danger'),
('D00004', 'D', 'Car Wireless Charger', 299, 680532, 'Normal'),
('D00005', 'D', 'Phone Mount', 129, 134867, 'Normal');

-- --------------------------------------------------------

--
-- Table structure for table `reorder`
--

CREATE TABLE `reorder` (
  `reorderID` char(10) NOT NULL,
  `roDate` date NOT NULL DEFAULT current_timestamp(),
  `supplierID` char(6) NOT NULL,
  `roStatus` varchar(7) NOT NULL DEFAULT 'send'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reorder`
--

INSERT INTO `reorder` (`reorderID`, `roDate`, `supplierID`, `roStatus`) VALUES
('R000000101', '2023-09-28', 'S40100', 'paid'),
('R159357462', '2023-02-03', 'S02030', 'paid'),
('R231021410', '2024-04-01', 'S04009', 'receive'),
('R426813975', '2023-10-21', 'S01021', 'paid'),
('R799135460', '2024-05-20', 'S21021', 'send');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplierID` char(6) NOT NULL,
  `sComName` varchar(255) NOT NULL,
  `sAdd` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplierID`, `sComName`, `sAdd`) VALUES
('S00009', 'Circa', 'Borgo Conte 156, Piano 3, Borgo Gilda, ME 91892'),
('S01021', 'Halo', 'Municipio Lorena Loya s/n., Cádiz, Ext 61610'),
('S02030', 'Unipart', '873 Romaguera Via, Youlandashire, CT 50712-7438'),
('S04009', 'Sequre', '68951 Reynolds Port, Lake Odiliaville, AZ 80397'),
('S21021', 'Parto', 'Suite 310 95483 Luetta Loop, East Brain, NV 67509-8114'),
('S40100', 'Devo', '502 Tobi Pines, New Kyoko, ME 22038');

-- --------------------------------------------------------

--
-- Table structure for table `supplierpart`
--

CREATE TABLE `supplierpart` (
  `supplierID` char(6) NOT NULL,
  `partID` char(6) NOT NULL,
  `purPrice` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplierpart`
--

INSERT INTO `supplierpart` (`supplierID`, `partID`, `purPrice`) VALUES
('S01021', 'A00002', 1840),
('S01021', 'B00002', 710),
('S01021', 'C00002', 280),
('S01021', 'D00002', 40),
('S02030', 'A00003', 1840),
('S02030', 'B00003', 540),
('S02030', 'C00003', 235),
('S02030', 'D00003', 100),
('S04009', 'A00001', 9600),
('S04009', 'B00001', 3750),
('S04009', 'C00001', 200),
('S04009', 'D00001', 100),
('S21021', 'A00005', 3024),
('S21021', 'B00005', 3008),
('S21021', 'C00005', 478),
('S21021', 'D00005', 103),
('S40100', 'A00004', 1352),
('S40100', 'B00004', 475),
('S40100', 'C00004', 227),
('S40100', 'D00004', 235);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `dealer`
--
ALTER TABLE `dealer`
  ADD PRIMARY KEY (`dealerID`);

--
-- Indexes for table `dept`
--
ALTER TABLE `dept`
  ADD PRIMARY KEY (`deptID`);

--
-- Indexes for table `emp`
--
ALTER TABLE `emp`
  ADD PRIMARY KEY (`empID`),
  ADD KEY `emp_dept_fk` (`deptID`);

--
-- Indexes for table `goodinwardpart`
--
ALTER TABLE `goodinwardpart`
  ADD PRIMARY KEY (`reorderID`,`partID`),
  ADD KEY `goodInwardPart_part_fk` (`partID`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`orderID`,`copyID`);

--
-- Indexes for table `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`logID`),
  ADD KEY `log_emp_fk` (`empID`),
  ADD KEY `log_part_fk` (`partID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderID`),
  ADD KEY `order_dealer_fk` (`dealerID`);

--
-- Indexes for table `orderpart`
--
ALTER TABLE `orderpart`
  ADD PRIMARY KEY (`orderID`,`partID`),
  ADD KEY `orderpart_part_fk` (`partID`);

--
-- Indexes for table `part`
--
ALTER TABLE `part`
  ADD PRIMARY KEY (`partID`),
  ADD KEY `part_category_fk` (`categoryID`);

--
-- Indexes for table `reorder`
--
ALTER TABLE `reorder`
  ADD PRIMARY KEY (`reorderID`),
  ADD KEY `reorder_supplier_fk` (`supplierID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplierID`);

--
-- Indexes for table `supplierpart`
--
ALTER TABLE `supplierpart`
  ADD PRIMARY KEY (`supplierID`,`partID`),
  ADD KEY `supplierPart_part_fk` (`partID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `emp`
--
ALTER TABLE `emp`
  ADD CONSTRAINT `emp_dept_fk` FOREIGN KEY (`deptID`) REFERENCES `dept` (`deptID`);

--
-- Constraints for table `goodinwardpart`
--
ALTER TABLE `goodinwardpart`
  ADD CONSTRAINT `goodInwardPart_part_fk` FOREIGN KEY (`partID`) REFERENCES `part` (`partID`),
  ADD CONSTRAINT `goodInwardPart_reorder_fk` FOREIGN KEY (`reorderID`) REFERENCES `reorder` (`reorderID`);

--
-- Constraints for table `invoice`
--
ALTER TABLE `invoice`
  ADD CONSTRAINT `invoice_order_fk` FOREIGN KEY (`orderID`) REFERENCES `order` (`orderID`);

--
-- Constraints for table `log`
--
ALTER TABLE `log`
  ADD CONSTRAINT `log_emp_fk` FOREIGN KEY (`empID`) REFERENCES `emp` (`empID`),
  ADD CONSTRAINT `log_part_fk` FOREIGN KEY (`partID`) REFERENCES `part` (`partID`);

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_dealer_fk` FOREIGN KEY (`dealerID`) REFERENCES `dealer` (`dealerID`);

--
-- Constraints for table `orderpart`
--
ALTER TABLE `orderpart`
  ADD CONSTRAINT `orderpart_order_fk` FOREIGN KEY (`orderID`) REFERENCES `order` (`orderID`),
  ADD CONSTRAINT `orderpart_part_fk` FOREIGN KEY (`partID`) REFERENCES `part` (`partID`);

--
-- Constraints for table `part`
--
ALTER TABLE `part`
  ADD CONSTRAINT `part_category_fk` FOREIGN KEY (`categoryID`) REFERENCES `category` (`categoryID`);

--
-- Constraints for table `reorder`
--
ALTER TABLE `reorder`
  ADD CONSTRAINT `reorder_supplier_fk` FOREIGN KEY (`supplierID`) REFERENCES `supplier` (`supplierID`);

--
-- Constraints for table `supplierpart`
--
ALTER TABLE `supplierpart`
  ADD CONSTRAINT `supplierPart_part_fk` FOREIGN KEY (`partID`) REFERENCES `part` (`partID`),
  ADD CONSTRAINT `supplierPart_supplier_fk` FOREIGN KEY (`supplierID`) REFERENCES `supplier` (`supplierID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
