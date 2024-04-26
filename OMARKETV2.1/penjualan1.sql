-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Apr 2024 pada 12.28
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `penjualan1`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `kode_barang` varchar(30) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `jenis_barang` varchar(30) NOT NULL,
  `satuan_barang` varchar(25) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`kode_barang`, `nama_barang`, `jenis_barang`, `satuan_barang`, `harga_beli`, `harga_jual`, `stok`) VALUES
('BRG002', 'Ayam Geprek Jebol Tanah', 'Makanan', 'Pieces (Pcs)', 10000, 15000, 251),
('BRG003', 'Irja Sambal', 'Makanan Kurang Laku', 'Pack', 10000, 50000, 2),
('BRG001', 'SEPATU', 'PAKAIAN', 'Pieces (Pcs)', 2500, 4000, 120);

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_jual`
--

CREATE TABLE `detail_jual` (
  `faktur_jual` varchar(10) NOT NULL,
  `kode_barang` varchar(30) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `jumlah_jual` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_jual`
--

INSERT INTO `detail_jual` (`faktur_jual`, `kode_barang`, `nama_barang`, `harga_jual`, `jumlah_jual`, `subtotal`) VALUES
('J240416003', '\r\nBRG0', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416004', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 3, 360000),
('J240416008', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 1, 120000),
('J240416009', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416010', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416011', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416012', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416001', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416002', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240416003', '\r\nBRG002', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240417004', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240417005', '\r\nBRG001', 'Buku tulis 30lbr', 120000, 2, 240000),
('J240417006', '\r\nBRG002', 'Pulpem', 5000, 2, 10000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `jual`
--

CREATE TABLE `jual` (
  `faktur_jual` varchar(35) NOT NULL,
  `tgl_jual` date NOT NULL,
  `jam` time NOT NULL,
  `itemjual` int(11) NOT NULL,
  `grand_total` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL,
  `namapelanggan` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `jual`
--

INSERT INTO `jual` (`faktur_jual`, `tgl_jual`, `jam`, `itemjual`, `grand_total`, `dibayar`, `kembalian`, `namapelanggan`) VALUES
('J240426001', '2024-04-26', '17:02:33', 6, 92000, 10000, 2147483647, 'Asep');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_adm`
--

CREATE TABLE `tbl_adm` (
  `namaadmin` varchar(25) NOT NULL,
  `passwordadmin` varchar(20) NOT NULL,
  `kodeadmin` int(20) NOT NULL,
  `leveladmin` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_adm`
--

INSERT INTO `tbl_adm` (`namaadmin`, `passwordadmin`, `kodeadmin`, `leveladmin`) VALUES
('Ryann', 'riyan12345', 1523, 'SUPERADMIN'),
('MAPRATAMA', 'RRQ', 221, 'SUPERVISOR1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `namauser` varchar(30) NOT NULL,
  `passworduser` varchar(30) NOT NULL,
  `telpuser` varchar(20) NOT NULL,
  `alamatuser` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`namauser`, `passworduser`, `telpuser`, `alamatuser`) VALUES
('Asep', 'kontrakan', '088199', 'Bumi'),
('irja', 'irja', '2215', 'pluto');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`nama_barang`);

--
-- Indeks untuk tabel `jual`
--
ALTER TABLE `jual`
  ADD PRIMARY KEY (`faktur_jual`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`namauser`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
