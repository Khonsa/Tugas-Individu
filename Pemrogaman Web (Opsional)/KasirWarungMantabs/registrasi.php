<?php
session_start();

if(!isset($_SESSION["login"])){
    header("Location: login.php");
    exit;
}
require 'function.php';

if( isset($_POST["registrasi"])){
    if(registrasi($_POST)>0){
        echo"<script>
        alert('user baru berhasil ditambahkan');
            </script>";
        header("Location: login.php");
    }else{
        echo mysqli_error($conn);
    }
}

?>

<!DOCTYPE html>
<html>
    <head>
        <link href="https://fonts.googleapis.com/css2?family=Josefin+Sans:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;1,100;1,200;1,300;1,400;1,500;1,600;1,700&display=swap" rel="stylesheet"> 
        <title>Registrasi Warung Mantabs</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body class="registrasi-page">
        <div class="registrasi-box">
            <img src="/gambar/profile.png" class="profile">
            <h1> REGISTRASI </h1>
            <form action="" method="post">
                <input type="text" name="namauser" placeholder="Enter Username">
                <p>Password</p>
                <input type="Password" name="password" placeholder="Enter Password">
                <input type="Password" name="password2" placeholder="Confirm Password">
                <input type="submit" name="registrasi" value="registrasi">
            </form>
        </div>
    </body>
</html>