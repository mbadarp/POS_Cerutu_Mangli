-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Okt 2020 pada 10.55
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pos`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_cerutu`
--

CREATE TABLE `tb_cerutu` (
  `kodeproduk` varchar(7) NOT NULL,
  `cigar_brand` varchar(10) NOT NULL,
  `cigar_size` varchar(11) NOT NULL,
  `roller_name` varchar(20) NOT NULL,
  `jumlah_produk` int(11) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_cerutu`
--

INSERT INTO `tb_cerutu` (`kodeproduk`, `cigar_brand`, `cigar_size`, `roller_name`, `jumlah_produk`, `date`) VALUES
('CRT0001', 'OEM', 'GC', 'Bu Khusnul', 50, '2020-10-01'),
('CRT0002', 'RB', 'RO', 'Bu Siti', 50, '2020-10-01');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_checkpack`
--

CREATE TABLE `tb_checkpack` (
  `id_pack` varchar(7) NOT NULL,
  `inspector` varchar(20) NOT NULL,
  `date` date NOT NULL,
  `brand` varchar(10) NOT NULL,
  `cigarsize` varchar(20) NOT NULL,
  `cigarshape` varchar(20) NOT NULL,
  `size` int(5) NOT NULL,
  `color` int(5) NOT NULL,
  `texture` int(5) NOT NULL,
  `crack` int(5) NOT NULL,
  `total_before` int(5) NOT NULL,
  `cellop_during` int(5) NOT NULL,
  `ring` int(5) NOT NULL,
  `total_during` int(5) NOT NULL,
  `cellop_after` int(5) NOT NULL,
  `prod_code` int(5) NOT NULL,
  `cukai` int(5) NOT NULL,
  `total_after` int(5) NOT NULL,
  `remarks` varchar(50) NOT NULL,
  `kodebarang` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_checkpack`
--

INSERT INTO `tb_checkpack` (`id_pack`, `inspector`, `date`, `brand`, `cigarsize`, `cigarshape`, `size`, `color`, `texture`, `crack`, `total_before`, `cellop_during`, `ring`, `total_during`, `cellop_after`, `prod_code`, `cukai`, `total_after`, `remarks`, `kodebarang`) VALUES
('PCK0001', 'Dwi', '2020-09-14', 'RB', 'RO', 'Torpedo', 1, 1, 1, 0, 3, 2, 3, 5, 1, 0, 1, 2, 'LoremIpsum', 'BRG001'),
('PCK002', 'Nuril', '2020-09-29', 'AL', 'GC', 'Box-press', 1, 2, 1, 3, 7, 1, 0, 1, 1, 1, 1, 3, 'LoremIpsum', 'BRG002');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_cerutu`
--
ALTER TABLE `tb_cerutu`
  ADD PRIMARY KEY (`kodeproduk`);

--
-- Indeks untuk tabel `tb_checkpack`
--
ALTER TABLE `tb_checkpack`
  ADD PRIMARY KEY (`id_pack`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
