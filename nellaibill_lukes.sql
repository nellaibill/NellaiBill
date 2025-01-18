-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2022 at 02:57 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nellaibill_lukes`
--

-- --------------------------------------------------------

--
-- Table structure for table `account_group`
--

CREATE TABLE `account_group` (
  `account_group_id` int(11) NOT NULL,
  `account_group_name` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account_group`
--

INSERT INTO `account_group` (`account_group_id`, `account_group_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'AC REGISTER', 'user', '2020-07-01 21:57:34', 0, '2020-07-02 15:49:04'),
(2, 'COURIER', 'user', '2020-07-01 22:08:54', 0, '2020-07-02 15:49:13'),
(3, 'CLEANING MATERIALS', 'user', '2020-07-01 22:11:12', 0, '2020-07-02 15:49:25'),
(4, 'ARASAN GAS(EMPTY CYLINDER RECEIPT BILL)', 'user', '2020-07-02 15:48:52', NULL, NULL),
(5, 'test', 'user', '2020-07-03 07:19:59', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `backup`
--

CREATE TABLE `backup` (
  `id` int(5) NOT NULL,
  `date` date NOT NULL,
  `path` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `config`
--

CREATE TABLE `config` (
  `config_id` int(1) NOT NULL,
  `is_hms` varchar(10) NOT NULL,
  `is_accounts` varchar(10) NOT NULL,
  `is_donor` varchar(10) NOT NULL,
  `is_batch` varchar(10) NOT NULL,
  `is_expiry` varchar(10) NOT NULL,
  `backup_path` varchar(100) NOT NULL,
  `is_m_hsn_code` varchar(10) NOT NULL,
  `is_m_product_name_in_tamil` varchar(10) NOT NULL,
  `is_m_product_code` varchar(10) NOT NULL,
  `is_m_product_mrp` varchar(10) NOT NULL,
  `patient_id` int(6) NOT NULL,
  `doctor_id` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config`
--

INSERT INTO `config` (`config_id`, `is_hms`, `is_accounts`, `is_donor`, `is_batch`, `is_expiry`, `backup_path`, `is_m_hsn_code`, `is_m_product_name_in_tamil`, `is_m_product_code`, `is_m_product_mrp`, `patient_id`, `doctor_id`) VALUES
(0, 'NO', 'NO', 'YES', 'NO', 'NO', 'C:\\Users\\HP\\OneDrive\\Desktop', 'YES', 'NO', 'YES', 'YES', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `lukes_donor_donation_details`
--

CREATE TABLE `lukes_donor_donation_details` (
  `p_donor_donation_details_id` int(5) NOT NULL,
  `f_donor_id` int(5) NOT NULL,
  `date` date NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `channel` varchar(100) NOT NULL,
  `purpose` varchar(100) NOT NULL,
  `remarks` varchar(250) NOT NULL,
  `createdason` datetime NOT NULL,
  `updatedason` datetime NOT NULL,
  `createdby` varchar(50) NOT NULL,
  `updatedby` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lukes_donor_donation_details`
--

INSERT INTO `lukes_donor_donation_details` (`p_donor_donation_details_id`, `f_donor_id`, `date`, `amount`, `channel`, `purpose`, `remarks`, `createdason`, `updatedason`, `createdby`, `updatedby`) VALUES
(1, 11, '2022-05-02', '5000.00', 'IOB', 'Welfare', '', '2022-06-18 15:21:47', '0001-01-01 00:00:00', '', ''),
(2, 20, '1956-06-08', '20000.00', '', 'donation', '', '2022-06-27 16:27:22', '0001-01-01 00:00:00', '', ''),
(3, 24, '2022-08-04', '2000.00', '', 'IOB', '', '2022-06-27 16:48:10', '0001-01-01 00:00:00', '', ''),
(4, 24, '2022-08-05', '6000.00', '', 'Welfare', '', '2022-06-27 16:48:39', '0001-01-01 00:00:00', '', ''),
(5, 26, '2000-06-05', '500.00', '', 'CLOTHES', '', '2022-06-27 16:54:19', '2022-06-27 16:54:40', '', ''),
(6, 31, '2022-08-06', '100.00', 'a', 'a', 'a', '2022-08-06 15:36:22', '0000-00-00 00:00:00', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `lukes_donor_fd_details`
--

CREATE TABLE `lukes_donor_fd_details` (
  `p_donor_fd_details_id` int(5) NOT NULL,
  `f_donor_id` int(5) NOT NULL,
  `date` date NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `bank` varchar(100) NOT NULL,
  `purpose` varchar(100) NOT NULL,
  `remarks` varchar(250) NOT NULL,
  `createdason` datetime NOT NULL,
  `updatedason` datetime NOT NULL,
  `createdby` varchar(50) NOT NULL,
  `updatedby` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lukes_donor_fd_details`
--

INSERT INTO `lukes_donor_fd_details` (`p_donor_fd_details_id`, `f_donor_id`, `date`, `amount`, `bank`, `purpose`, `remarks`, `createdason`, `updatedason`, `createdby`, `updatedby`) VALUES
(1, 10, '2022-06-18', '50000.00', 'IOB', 'walfare', '', '2022-06-18 15:25:22', '0001-01-01 00:00:00', '', ''),
(2, 9, '2022-02-01', '34156.00', 'IOB', 'clothes', '', '2022-06-18 15:35:59', '0001-01-01 00:00:00', '', ''),
(3, 3, '2002-05-05', '60000.00', 'SBI', 'dinner', '', '2022-06-18 16:24:24', '0001-01-01 00:00:00', '', ''),
(4, 18, '2019-08-02', '200.00', 'IOB', 'welfare', '', '2022-06-27 15:05:00', '0001-01-01 00:00:00', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `lukes_donor_important_dates`
--

CREATE TABLE `lukes_donor_important_dates` (
  `p_donor_imp_date_id` int(5) NOT NULL,
  `f_donor_id` int(5) NOT NULL,
  `name` varchar(100) NOT NULL,
  `relation` varchar(100) NOT NULL,
  `occasion_date` date NOT NULL,
  `occasion` varchar(100) NOT NULL,
  `remarks` varchar(500) NOT NULL,
  `createdason` datetime NOT NULL,
  `updatedason` datetime NOT NULL,
  `createdby` varchar(100) NOT NULL,
  `updatedby` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lukes_donor_important_dates`
--

INSERT INTO `lukes_donor_important_dates` (`p_donor_imp_date_id`, `f_donor_id`, `name`, `relation`, `occasion_date`, `occasion`, `remarks`, `createdason`, `updatedason`, `createdby`, `updatedby`) VALUES
(1, 11, 'Anu', 'daughter', '2000-05-20', 'DOB', '', '2022-06-18 15:20:06', '0001-01-01 00:00:00', '', ''),
(2, 11, 'kevi', 'brother', '2000-09-10', 'DOB', '', '2022-06-18 15:21:09', '0001-01-01 00:00:00', '', ''),
(3, 10, 'nithiya', 'mother', '1998-06-05', 'DOW', '', '2022-06-18 15:26:52', '0001-01-01 00:00:00', '', ''),
(4, 9, 'dinesh', 'son', '1999-08-30', 'DOD', '', '2022-06-18 15:35:00', '0001-01-01 00:00:00', '', ''),
(5, 9, 'kavya', 'daughter', '2022-12-17', 'DOB', '', '2022-06-18 15:35:26', '0001-01-01 00:00:00', '', ''),
(6, 7, 'Jebaraj', 'self', '1966-03-07', 'DOB', '', '2022-06-18 15:39:38', '0001-01-01 00:00:00', '', ''),
(7, 7, 'Mrs. Seramin Ezhil Arasi', 'wife', '2022-08-27', 'DOB', '17.05.93', '2022-06-18 15:40:08', '2022-06-18 15:41:40', '', ''),
(8, 7, 'Mrs. Seramin Ezhil Arasi', 'wife', '1993-05-17', 'DOW', '', '2022-06-18 15:48:33', '0001-01-01 00:00:00', '', ''),
(9, 7, 'Jeejy', 'grandson', '1995-01-18', 'DOB', '', '2022-06-18 15:49:27', '0001-01-01 00:00:00', '', ''),
(10, 7, 'Jimry', '18', '1997-07-18', 'DOB', '', '2022-06-18 15:49:53', '0001-01-01 00:00:00', '', ''),
(11, 8, 'Rev. S. Pon Manuel.', 'Self', '1945-04-01', 'DOB', '', '2022-06-18 16:10:40', '2022-06-18 16:15:34', '', ''),
(12, 8, 'Mrs. Alice Gnanam.', 'wife', '1945-11-19', 'DOB', '', '2022-06-18 16:10:59', '0001-01-01 00:00:00', '', ''),
(13, 8, 'Emimal', 'daughter', '2022-08-01', 'DOB', '', '2022-06-18 16:16:07', '0001-01-01 00:00:00', '', ''),
(14, 8, 'Cravids', 'Emimals husband', '2022-09-05', 'DOB', '', '2022-06-18 16:18:31', '0001-01-01 00:00:00', '', ''),
(15, 3, 'shantha', 'wife', '1987-06-18', 'DOB', '', '2022-06-18 16:24:47', '2022-06-18 16:25:06', '', ''),
(16, 3, 'prema', 'daughter', '1992-05-13', 'DOB', '', '2022-06-18 16:26:28', '0001-01-01 00:00:00', '', ''),
(17, 3, 'john', 'son', '2022-12-08', 'DOB', '', '2022-06-18 16:27:24', '0001-01-01 00:00:00', '', ''),
(18, 3, 'paul', 'father', '1988-02-18', 'DOD', '', '2022-06-18 16:27:50', '0001-01-01 00:00:00', '', ''),
(19, 6, 'kkk', '', '2001-06-18', 'DOW', '', '2022-06-18 17:17:14', '0001-01-01 00:00:00', '', ''),
(20, 14, 'NIrai Mathi', 'selt', '1958-06-05', 'DOB', '', '2022-06-18 17:36:33', '0001-01-01 00:00:00', '', ''),
(21, 16, 'david', 'self', '2022-06-27', 'DOB', '', '2022-06-27 15:00:55', '0001-01-01 00:00:00', '', ''),
(22, 20, 'Abiraj.', 'self', '1956-12-05', 'DOB', '', '2022-06-27 16:27:56', '2022-06-27 16:28:26', '', ''),
(23, 20, 'kani', 'wife', '1965-06-27', 'DOB', '', '2022-06-27 16:29:03', '0001-01-01 00:00:00', '', ''),
(24, 20, 'rani', 'daughter', '1986-11-09', 'DOB', '', '2022-06-27 16:31:13', '0001-01-01 00:00:00', '', ''),
(25, 32, 'test1', '', '2022-07-23', 'DOW', '', '2022-07-23 12:08:35', '0001-01-01 00:00:00', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `lukes_donor_registration`
--

CREATE TABLE `lukes_donor_registration` (
  `p_donor_id` int(5) NOT NULL,
  `donor_name` varchar(100) NOT NULL,
  `address_line1` varchar(500) NOT NULL,
  `address_line2` varchar(500) NOT NULL,
  `country` varchar(50) NOT NULL,
  `state` varchar(50) NOT NULL,
  `city_id` int(4) NOT NULL,
  `phone_no1` varchar(50) NOT NULL,
  `phone_no2` varchar(15) NOT NULL,
  `landline_no1` varchar(20) NOT NULL,
  `landline_no2` varchar(20) NOT NULL,
  `donor_file_name` varchar(50) NOT NULL,
  `email_id1` varchar(50) NOT NULL,
  `email_id2` varchar(50) NOT NULL,
  `reference` varchar(1000) NOT NULL,
  `related_files` varchar(100) NOT NULL,
  `pancard` varchar(25) NOT NULL,
  `category_id` int(3) NOT NULL,
  `notes` varchar(5000) NOT NULL,
  `donor_annual` tinyint(1) NOT NULL,
  `donor_endowment` int(1) NOT NULL,
  `donor_things` int(1) NOT NULL,
  `donor_welfare` int(1) NOT NULL,
  `support_cs` int(1) NOT NULL,
  `support_fs` int(1) NOT NULL,
  `support_bs` int(1) NOT NULL,
  `support_cloth` int(1) NOT NULL,
  `support_other` int(1) NOT NULL,
  `sr_ooc` int(1) NOT NULL,
  `sr_ntc` int(1) NOT NULL,
  `sr_post` int(1) NOT NULL,
  `sr_visitor` int(1) NOT NULL,
  `sr_email` int(1) NOT NULL,
  `greetings_pongal` int(1) NOT NULL,
  `greetings_easter` int(1) NOT NULL,
  `greetings_christmas` int(1) NOT NULL,
  `greetings_others` int(1) NOT NULL,
  `createdason` date NOT NULL DEFAULT '2025-01-01',
  `updatedason` date NOT NULL DEFAULT '2025-01-01',
  `createdby` varchar(100) NOT NULL,
  `updatedby` varchar(100) NOT NULL,
  `other_details` varchar(1000) NOT NULL,
  `is_active` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lukes_donor_registration`
--

INSERT INTO `lukes_donor_registration` (`p_donor_id`, `donor_name`, `address_line1`, `address_line2`, `country`, `state`, `city_id`, `phone_no1`, `phone_no2`, `landline_no1`, `landline_no2`, `donor_file_name`, `email_id1`, `email_id2`, `reference`, `related_files`, `pancard`, `category_id`, `notes`, `donor_annual`, `donor_endowment`, `donor_things`, `donor_welfare`, `support_cs`, `support_fs`, `support_bs`, `support_cloth`, `support_other`, `sr_ooc`, `sr_ntc`, `sr_post`, `sr_visitor`, `sr_email`, `greetings_pongal`, `greetings_easter`, `greetings_christmas`, `greetings_others`, `createdason`, `updatedason`, `createdby`, `updatedby`, `other_details`, `is_active`) VALUES
(2, 'Rev. N.S. Jeremiah.', '62-A, 1st Street, Vazhiadi, Nazareth.- 628 617.', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '', '', 'K- 2', '', '', '', '', '', 0, '', 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(3, 'Mr.Silas Sargunam.', 'S/o. Late. Mr.S. Sathiaseharan,\nKeelaputhukudi Kaspa, Ammanpuram Post, Thoothukudi.- 628 201.', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '9443562314', '', '', '', 'K- 40', 'silassargunam@gmai.com.', '', '', '', '', 0, '', 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(4, 'Rev. Moses Jebaraj.', 'Test Address Line 1\n', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '9486656602', '', '', '', '', '', '', 'No donation given by Rev. Moses. so not applicable.', '', '', 2, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(5, 'Rev. Kingsley J. Daniel.', 'Test Address Line 1\n', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', 'kingnew06@gmail.com.', 'kjoel94@icloud.com.', 'B-50', '', '', '', '', '', 2, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(6, 'Mr. E. Barnabas.', '11/691, New Muniasamipuram, 4th Street, \nThoothukudi.- 628 002.', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '9442234080', '', '', 'barnabas163@gmail.com.', '', '', '', '', 4, 'SAWYERPURAM-SUBRAMANIAPURAM FRIEND\n\nNOT WILLING TO GIVE INFORMATION DATA.\n', 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(7, 'Mr.Peter.', '11/22, Middle Sstreet, East panaikulam, Asirvathapuram Post, Thoothukudi Dis.- 628 613.', 'Test Address Line 2', 'India', 'Tamilnadu.', 0, '9489115348', '', '', '', 'P- 76', '', '', '', '', '', 4, '', 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(8, 'Rev. S. Pon Manuel.', 'Test Address Line 1\n', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '9442759142', '9176313975', '', '', '', 'joel36@gmail.com', '', '', 'R- 89', '75645241', 2, 'NOT WILLING TO GIVE INFORMATION DATA.\n', 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(9, 'Rev. D.J. Jebaraj.', 'Test Address Line 1\n', 'Test Address Line 2', 'India', 'TAMILNADU.', 0, '', '', '', '', 'J -214', 'revdjjebaraj@gmail.com.', '', '', '', 'AMFPJ3005K', 2, '\n', 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(10, 'Mrs. v. Navaroji.', 'W/o. Late. Mr.Veerapandian, Ebenezer Illam, 192', 'Kadalakara Theru, Kovillpatti.- 628 501.', 'India', 'Tamil Nadu.', 0, '8682930396', '8056735658', '9080987456', '', 'N- 19', 'Daisyanushia@gmail.com', '', '', 'Y- 6', '253564', 4, '  Enclosed here with is a copy of the partakers list along with our prayer request for the month of july 2022.', 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(11, 'Mrs. Gayathi.', '3/557, st. Lekes Leprosarium, Peikulam.- 628 613', 'Test Address Line 2', 'India', 'TAMILNADU', 0, '6385801199.', '', '', '', '', 'gaya5425@gmail.com', '', '', '', '', 4, 'NOT WILLING TO GIVE IMPORTANT DATES.\n\n', 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(12, 'Mr.Peter.', '11/22, Middle Sstreet, East panaikulam, ', 'Asirvathapuram Post, Thoothukudi Dis.- 628 613.', 'India', 'Tamilnadu.', 0, '9489115348', '', '', '', 'P- 76', '', '', '', 'k 95', '', 4, 'Dr.MARTIN THOMAS’ FRIEND & APPLICANT TO NESARANI, USA.\n', 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(13, 'Jenifer Alex. A', '1/185 B, Main Road,\nMullikulam,\nSankaranKoil Taluk,\nTenkasi Dt. -  627 755.\nIndia', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '78268 97464', '', '', '', '', '', '', '', 'J- 251', '266666', 4, 'Staff \n\n\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(14, 'Mrs. Nirai Mathi. A', 'Test Address Line 1\n', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '', '', '', '', '', '', '', '', 4, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(15, 'Mr. A. Joseph Raja Asir', '35, Bangalow Street, \nSattankulam,\nThoothukudi Dt. -  628 704.\nIndia.', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '', '', '', '', '', '', '', '', 4, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-18', '2022-06-18', '', '', '', 1),
(16, 'Mr. A. David', '44 B, First Street, \nValaiyadi,\nNazareth,\nThoothukudi Dt. -  628 617.\nIndia', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '5268622258', '', '', '', '', 'anand35@gmail.com.', '', '', '', '', 2, '', 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(17, 'Pastor. A. Xavier', '6/106, Panchayat Office Street,\nBethel Prayer House,\nMela Naduvakurichi,\nKommadikottai (via)\nThoothukudi Dt  Tamil Nadu  628 653\nIndia', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '', '', 'x-2', '', '', '', '', '252625 K', 2, '\n', 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(18, 'Mr. Aadhithan', 'Principal,\nJames Memorial Matric.& Hr.Sec.School,\nMukuperi Post,\nPragasapuram.\nThoothukudi Dt  Tamil Nadu  628616,\nIndia', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '+91 (04639) 277-240', '+91 (04639) 277-262', '', 'Aadhithan (james_memorial_school@yahoo.co.in)', '', '', '', '', 2, 'PRAGASAPURAM S.D.A CHURCH PASTOR & DONOR:', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(19, 'Mr. R. Albert Pattu Pandi', '6/78, East Street,\nNattathi,\nPannaivilai(Via),\nThoothukudi Dist,  Tamil Nadu  628 751\nIndia', 'Test Address Line 2', 'India', 'Tamilnadu.', 0, '94430 82324', '', '', '', 'A- 125', '', '', '', '', '', 2, 'NO EMAIL ID \n', 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(20, 'Mr. Abiraj', '20, Kavel Ramasamy Street,\nT.N. Puthukudi,\nPuliangudi,\nTirunelveli Dist.  Tamil Nadu  627 855\nIndia', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '', '', 'A-187', 'joeljebastin56@gmail.com', '', '', '', '', 1, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(21, 'Mrs. A. Anita Mercy', 'A-40, 4th Cross Street, \nN.G.O A Colony,\nJawahar Nagar,\nTirunelveli', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '8012843074', '', '', '', '', 'anitamercy28@gmail.com', '', '', '', '', 0, '', 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(22, 'Mr. S. Aris Rajasingh', 'Kamalam Cottage,\n4/102-C,Kurichi Main Road,\nKulavanigarpuram,\nPalayamkottai\nTirunelveli  Tamil Nadu  627002\n', 'Kamalam Cottage,\n4/102-C,Kurichi Main Road,\nKulavanigarpuram,\nPalayamkottai\nTirunelveli  Tamil Nadu  627002\nIndia', 'India', 'Tamilnadu', 0, '', '94436 95680', '94431-17420', '', '', 'maj_joseph@licindia.com', '', '', 'A- 152', '', 2, 'REV.MOWLI JEBAMONI SON\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(23, 'Mr. S. N. Arumuga Nainar', 'Mr. S. N. Arumuga Nainar,\n29-A, Mela Sattankulam Post,\nThoothukudi Dt  Tamil Nadu  628 704\nIndia', 'Test Address Line 2', 'India', '', 0, '', '', '+91 (04639) 254-305', '+91 94865-48258', '', 'sureshkn78@gmail.com', '', '', '', '', 1, '', 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(24, 'Mr. Azariah Joseph', 'Test Address Line 1\n', 'Test Address Line 2', 'India', 'Tamilnadu', 0, '', '', '', '', 'A-145', '', '', '', '', '', 1, 'Wife: Mrs. Esther\nDtr: Mrs. Chrisy Bai Rachael \nSIL: Mr.Duraisingam\nG/Dtr: 1. Jennifer\n          2. Lydia\nSon: Mr.A.Jebaseelan\nDIL: Mrs.Stella\nG/Dtr: Saral\nG/Son: Andrew\nSon: Mr.Simon\nDIL: Mrs.Felcia\nG/Dtr: Liza\nG/Son:Roland\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(25, 'Dr. M. Balakrishnan B. V. Sc. M. A.', 'Test Address Line 1\n', 'Test Address Line 2', 'India', '', 0, '98402 25315', '', '+91 (044) 26211445', '', '', 'rajabala1928@gmail.com', '', '', '', '', 1, 'Dr.HAEBUS FAMILY FRIEND  - Vet.Dr.\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, '2022-06-27', '2022-06-27', '', '', '', 1),
(26, 'Mr. M. Barnabas Vincent', 'Jesus Nest,\n33-B, Thirumaraiyur', 'Nazareth\nThoothukudi Dt    628 617', 'India', 'Tamil Nadu', 0, '94424 45097', '', '', '', 'b- 18', '', '', '', '', '', 1, 'NAZARETH DONOR\nNO EMAIL ID - ONLY ONE POST TO Mr. BARNABAS DO NOT SEND SEPERATELY TO HIS DAUGHTER \n\n\nWife: Jeyaseeli\nDaughters:\n1.Mrs.Persis Gilbert Raj\n2.Mrs.Amutha Jansi Manoharan\n3.Mrs.Princess Mary Geofrey\n4.Mrs.Felicious Grace Jason\n\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(27, 'Mr. Chandrakumar', 'C/o Latha Fancy,\nNo.1/B-3, Thandiswaran Main Road', 'Velachery,\nCHENNAI  600 042', 'India', 'TAMILNADU  ', 0, '', '', '', '', '', '', '', '', '', '', 1, 'KODANKULAM DONOR MR.SOLOMON RAJA’S BROTHER\n\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(28, 'Mrs. Chandrika Francis', 'C-114, 4th Cross Street,', 'Maharajanagar,\nTIRUNELVELI    627 011', 'India', '', 0, '', '', '', '', 'G- 26', '', '', '', '', '', 1, 'TIRUNELVELI RANI ANNA WOMEN’S COLLEGE Ex-STAFF AND WELL-WISHER \n91 (0462) 2584684 - NOT PICKED UP.\n\n', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(29, 'Dr. Daniel Raj', '201, Aishwarya Lotus Apartments,\n2nd Floor, Michael Palya,\n', 'Indira Nagar, First Stage,\nBENGALURU,  560 038', 'India', 'Karnataka  ', 0, '', '', '+91 080-88055556', '', '', 'Daniel Raj (stelladanny1@gmail.com)', '', '', '', '', 2, 'SLL - DENTIST DR.JOHN IMMANUEL S COUSIN BROTHER\n\n\nWife: Dr.Mrs.Stella\n\nPip/24.11.16\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(30, 'Mr. Chandrakumar', 'C/o Latha Fancy,\nNo.1/B-3, Thandiswaran Main Road,\n', 'Velachery,\nCHENNAI  600 042', 'OutsideIndia', 'TAMILNADU  ', 0, '', '', '', '', 'C 52', '', '', '', '', '', 1, 'KODANKULAM DONOR MR.SOLOMON RAJA’S BROTHER\n\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(31, 'Dr. Daniel Raj', '201, Aishwarya Lotus Apartments,\n2nd Floor, Michael Palya,\n', 'Indira Nagar, First Stage,\nBENGALURU,  560 038\n', 'India', '', 0, '', '', '+91 080-88055556', '', 'D 25', 'Daniel Raj (stelladanny1@gmail.com)', '', '', '', '', 1, 'SLL - DENTIST DR.JOHN IMMANUEL S COUSIN BROTHER\n\n\nWife: Dr.Mrs.Stella\n\nPip/24.11.16\n', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, '2022-06-27', '2022-06-27', '', '', '', 1),
(32, 'Test Name', 'No.100, Santhai Adi Theru,\nAnna Nagar,\nSrivaikuntam\nThoothukudi Dt 628 601\n', 'Test Address Line 2', 'OutsideIndia', '', 0, '9090909090', '9898989898', '1', '1', '1', '11', '1', '1', '1', '11', 1, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-07-02', '2022-07-02', '', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `lukes_donor_settings`
--

CREATE TABLE `lukes_donor_settings` (
  `p_donor_settings_id` int(1) NOT NULL,
  `donor_annual` int(1) NOT NULL,
  `donor_endowment` int(1) NOT NULL,
  `donor_things` int(1) NOT NULL,
  `donor_welfare` int(1) NOT NULL,
  `support_cs` int(1) NOT NULL,
  `support_fs` int(1) NOT NULL,
  `support_bs` int(1) NOT NULL,
  `support_cloth` int(1) NOT NULL,
  `support_other` int(1) NOT NULL,
  `sr_ooc` int(1) NOT NULL,
  `sr_ntc` int(1) NOT NULL,
  `sr_post` int(1) NOT NULL,
  `sr_visitor` int(1) NOT NULL,
  `sr_email` int(1) NOT NULL,
  `isDonorImpDate` int(1) NOT NULL,
  `from_date` date NOT NULL DEFAULT '2025-01-01',
  `to_date` date NOT NULL DEFAULT '2025-01-01',
  `greetings_pongal` int(1) NOT NULL,
  `greetings_christmas` int(1) NOT NULL,
  `greetings_easter` int(1) NOT NULL,
  `greetings_others` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lukes_donor_settings`
--

INSERT INTO `lukes_donor_settings` (`p_donor_settings_id`, `donor_annual`, `donor_endowment`, `donor_things`, `donor_welfare`, `support_cs`, `support_fs`, `support_bs`, `support_cloth`, `support_other`, `sr_ooc`, `sr_ntc`, `sr_post`, `sr_visitor`, `sr_email`, `isDonorImpDate`, `from_date`, `to_date`, `greetings_pongal`, `greetings_christmas`, `greetings_easter`, `greetings_others`) VALUES
(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2022-07-23', '2022-07-23', 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `m_category`
--

CREATE TABLE `m_category` (
  `category_id` int(5) NOT NULL,
  `category_name` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_category`
--

INSERT INTO `m_category` (`category_id`, `category_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'CHRISTMAS CARD', 'user', '2020-06-25 21:56:23', 0, '2022-06-04 20:36:04'),
(2, 'PONGAL CARD', 'user', '2022-06-04 20:36:12', NULL, NULL),
(3, 'NEW YEAR CARD', 'user', '2022-06-04 20:36:17', NULL, NULL),
(4, 'GOOD FRIDAY CARD', 'user', '2022-06-04 20:36:27', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `m_user`
--

CREATE TABLE `m_user` (
  `user_id` int(3) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email_id` varchar(100) NOT NULL,
  `mobile_no` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(100) NOT NULL,
  `department_id` int(3) NOT NULL,
  `role` varchar(25) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_user`
--

INSERT INTO `m_user` (`user_id`, `name`, `email_id`, `mobile_no`, `username`, `password`, `department_id`, `role`) VALUES
(1, 'Dr.Raja', 'dr.raja@gmail.com', 2147483647, 'admin', 'admin', 1, 'A'),
(2, 'user', 'user', 9658995, 'user', 'user', 2, 'U');

-- --------------------------------------------------------

--
-- Table structure for table `setup_companyinfo`
--

CREATE TABLE `setup_companyinfo` (
  `companyno` int(2) NOT NULL,
  `companytitle` varchar(100) NOT NULL,
  `companyaddress1` varchar(100) NOT NULL,
  `companyaddress2` varchar(100) NOT NULL,
  `companyaddress3` varchar(100) NOT NULL,
  `companycontactno` varchar(100) NOT NULL,
  `gstinno` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setup_companyinfo`
--

INSERT INTO `setup_companyinfo` (`companyno`, `companytitle`, `companyaddress1`, `companyaddress2`, `companyaddress3`, `companycontactno`, `gstinno`) VALUES
(1, 'Test Company Name ', 'Tirunelveli   ', '-               ', '9090909090                  ', '                   ', '                   ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account_group`
--
ALTER TABLE `account_group`
  ADD PRIMARY KEY (`account_group_id`);

--
-- Indexes for table `backup`
--
ALTER TABLE `backup`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `config`
--
ALTER TABLE `config`
  ADD PRIMARY KEY (`config_id`);

--
-- Indexes for table `lukes_donor_donation_details`
--
ALTER TABLE `lukes_donor_donation_details`
  ADD PRIMARY KEY (`p_donor_donation_details_id`);

--
-- Indexes for table `lukes_donor_fd_details`
--
ALTER TABLE `lukes_donor_fd_details`
  ADD PRIMARY KEY (`p_donor_fd_details_id`);

--
-- Indexes for table `lukes_donor_important_dates`
--
ALTER TABLE `lukes_donor_important_dates`
  ADD PRIMARY KEY (`p_donor_imp_date_id`);

--
-- Indexes for table `lukes_donor_registration`
--
ALTER TABLE `lukes_donor_registration`
  ADD PRIMARY KEY (`p_donor_id`);

--
-- Indexes for table `lukes_donor_settings`
--
ALTER TABLE `lukes_donor_settings`
  ADD PRIMARY KEY (`p_donor_settings_id`);

--
-- Indexes for table `m_category`
--
ALTER TABLE `m_category`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `m_user`
--
ALTER TABLE `m_user`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `setup_companyinfo`
--
ALTER TABLE `setup_companyinfo`
  ADD PRIMARY KEY (`companyno`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account_group`
--
ALTER TABLE `account_group`
  MODIFY `account_group_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `backup`
--
ALTER TABLE `backup`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `lukes_donor_donation_details`
--
ALTER TABLE `lukes_donor_donation_details`
  MODIFY `p_donor_donation_details_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `lukes_donor_fd_details`
--
ALTER TABLE `lukes_donor_fd_details`
  MODIFY `p_donor_fd_details_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `lukes_donor_important_dates`
--
ALTER TABLE `lukes_donor_important_dates`
  MODIFY `p_donor_imp_date_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `lukes_donor_registration`
--
ALTER TABLE `lukes_donor_registration`
  MODIFY `p_donor_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `m_category`
--
ALTER TABLE `m_category`
  MODIFY `category_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `m_user`
--
ALTER TABLE `m_user`
  MODIFY `user_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `setup_companyinfo`
--
ALTER TABLE `setup_companyinfo`
  MODIFY `companyno` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
