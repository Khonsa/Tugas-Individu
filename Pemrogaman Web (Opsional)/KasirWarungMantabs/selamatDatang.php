<?php
//ob_start();
session_start();

if(!isset($_SESSION["login"])){
    header("Location: login.php");
    exit;
}
//if(!isset($_SESSION['user_username'])) header("location: login.php");
//include "connect.php";
require 'function.php';
$pelanggan = query("SELECT * FROM pelanggan");
if (isset($_POST["submit"]) ) {
        
    if( tambah($_POST) > 0 ){
        echo "<script>
        alert('data berhasil ditambahkan');
        document.location.href = 'selamatDatang.php';
        </script>";
    }else{
        echo "<script>
        alert('data gagal ditambahkan');
        document.location.href = 'selamatDatang.php';
        </script>";
    }


}


?>

<!DOCTYPE html>
<html>
    <head>
        <link href="https://fonts.googleapis.com/css2?family=Josefin+Sans:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;1,100;1,200;1,300;1,400;1,500;1,600;1,700&display=swap" rel="stylesheet"> 
        <title>Welcome to Warung Mantabs</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body class="welcome-page">
        <!--awal header-->
        <header>
            <div class="container">
                <div class="column">
                    <div class="icon">
                        <img src="/gambar/iconApp.png" alt="icon kasir"/>
                    </div>
                    <div class="navbar">
                        <ul>
                            <li><a href="#home" class="active">HOME</a></li>
                            <li><a href="#menu">MENU</a></li>
                            <li><a href="#pelanggan">DATA PELANGGAN</a></li>
                            <li><a href="logout.php">LOGOUT</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </header>
        <!--akhir header-->
        <!--awal home-->
            <section class="SelamatDatang" id="home"> 
                <div class="container">
                    <div class="row">
                        <div class="main-content">
                            <div class="home-content">
                                <h1 class="selamat">Selamat Datang</h1>
                                <div class="buttonLearn">
                                    <a href="logout.php">Logout</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        <!--akhir header-->
        <!--awal menu-->
        <section class="Menu" id="menu"> 
            <div class="container">
                <div class="row">
                    <div class="main-content">
                        <div class="judul-section">
                            <h1> Menu</h1>
                        </div>
                        <div class="menu-content">
                            <div class="isi-menu">
                                <div class="box-daftar">
                                    <div class="judulmenu">
                                        <h3>MAKANAN</h3>
                                    </div>
                                    <div class="box-in">
                                        <div class="daftar">
                                            <ul>
                                                <li>Nasi Goreng</li>
                                                <li>Mie Goreng</li>
                                                <li>Pecel</li>
                                                <li>Penyetan Tahu Tempe</li>
                                            </ul>
                                        </div>
                                        <div class="harga">
                                            <ul>
                                                <li>10k</li>
                                                <li>8k</li>
                                                <li>8k</li>
                                                <li>7k</li>
                                            </ul>
                                        </div>
                                    </div> 
                                </div>
                                <div class="box-daftar">
                                    <div class="judulmenu">
                                        <h3>MINUMAN</h3>
                                    </div>
                                    <div class="box-in">
                                        <div class="daftar">
                                            <ul>
                                                <li>Es Teh</li>
                                                <li>Es Jeruk</li>
                                            </ul>
                                        </div>
                                        <div class="harga">
                                            <ul>
                                                <li>3k</li>
                                                <li>4k</li>
                                            </ul>
                                        </div>
                                    </div> 
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--akhir menu-->

        <!--awal datapelanggan-->
        <section class="datapelanggan " id="pelanggan">
            <div class ="container">
                <div class="row">
                    <div class="main-content">
                        <div class="judul-section">
                            <h1>DATA PELANGGAN</h1>
                        </div>
                        <div class="data-box">
                            <table class="tabel-pelanggan">
                                <thead>
                                    <tr>
                                        <th>No.</th>
                                        <th>Aksi</th>
                                        <th>ID</th>
                                        <th>Nama</th>
                                        <th>Jenis Kelamin</th>
                                        <th>No. HP</th>
                                        <th>Alamat</th>
                                    </tr>
                                </thead>
                                <tbody>
                                        <?php $i = 1; ?>
                                        <?php foreach($pelanggan as $plg ): ?>
                                            <tr>
                                                <td><?= $i; ?></td>
                                                <td>
                                                    <a href="#">Ubah</a> |
                                                    <a href="hapus.php?id= <?= $plg["idpelanggan"];?>">Hapus</a>
                                                </td> 
                                                <td><?= $plg["idpelanggan"]; ?></td>
                                                <td><?= $plg["namapelanggan"]; ?></td>
                                                <td><?= $plg["jeniskelamin"]; ?></td>
                                                <td><?= $plg["nohp"]; ?></td>
                                                <td><?= $plg["alamat"]; ?></td>
                                            </tr>
                                        <?php $i++; ?>
                                    <?php endforeach; ?>
                                </tbody>
                            </table>
                        </div>
                        <div class="buttonTambah">
                            <a href="#tambah">Tambah</a>
                        </div>
                    </div>
                </div> 
            </div>
        </section>
    <!--awal tambah form data-->
    <section class="tambahdata" id="tambah">
            <div class ="container">
                <div class="row">
                    <div class="main-content">
                        <div class="judul-section">
                        <h1> Tambah Data Pelanggan </h1>
                        </div>
                        <div class="data-box">
                            <form action="" method="post">
                                <ul>
                                    <li>
                                        <label for="namapelanggan">Nama : </label>
                                        <input type="text" name="namapelanggan" id="namapelanggan" required>
                                    </li>
                                    <li>
                                        <label for="jeniskelamin">Jenis Kelamin : </label>
                                        <input type="text" name="jeniskelamin" id="jeniskelamin" required>
                                    </li>
                                    <li>
                                        <label for="nohp">No. HP : </label>
                                        <input type="text" name="nohp" id="nohp" required>
                                    </li>
                                    <li>
                                        <label for="alamat">Alamat : </label>
                                        <input type="text" name="alamat" id="alamat" required>
                                    </li>
                                    <li>
                                    <button type="submit" name="submit"> Tambah Data</button>
                                    </li>
                                </ul>
                            </form>
                            <div class="buttonkembali">
                            <a href="#pelanggan">Kembali</a>
                        </div>
                        </div>  
                    </div>
                </div>
            </div>

        </section>
    <!--awal tambah form data-->

        <!--akhir datapelanggan-->
        <script src="script.js"></script>
    </body>
</html>

<?php

mysqli_close($conn);
ob_end_flush();
?>