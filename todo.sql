-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Feb 26, 2018 at 11:12 PM
-- Server version: 5.6.35
-- PHP Version: 7.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `todo`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `name`) VALUES
(16, NULL),
(17, NULL),
(18, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `categories_items`
--

CREATE TABLE `categories_items` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `category_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `raw_date` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `description`, `raw_date`) VALUES
(3, 'Walking the Dog', '2018-02-28'),
(4, 'Walking the Dog', '2018-02-28'),
(5, 'dxdxdx', '2018-02-24'),
(6, 'dxdxdx', '2018-02-24'),
(7, 'dxdxdx', '2018-02-24'),
(8, 'walking the dog', '2018-02-10'),
(9, 'walking the dog', '2018-02-10'),
(10, 'walking the dog', '2018-02-10'),
(11, 'walking the dog', '2018-02-10'),
(12, 'kkhhhhhhh', '2018-02-28'),
(13, 'moooooo', '2018-03-02'),
(14, NULL, '2018-02-09'),
(15, 'afsfsafasfasfsafsa', NULL),
(16, 'x   x', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `categories_items`
--
ALTER TABLE `categories_items`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `categories_items`
--
ALTER TABLE `categories_items`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
