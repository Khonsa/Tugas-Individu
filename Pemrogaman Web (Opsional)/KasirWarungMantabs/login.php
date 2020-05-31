<?php
session_start();

if(isset($_SESSION["login"])){
    header("Location: selamatDatang.php");
    exit;
}
require 'function.php';

 if(isset($_POST["login"])){
     $namauser = $_POST["namauser"];
     $password = $_POST["password"];
     $result = mysqli_query($conn, "SELECT * FROM user WHERE namauser = '$namauser'");

     if(mysqli_num_rows($result) === 1){
         $row = mysqli_fetch_assoc($result);
         if (password_verify($password, $row["password"])){
            $_SESSION["login"] = true;
             header("Location: selamatDatang.php");
             exit;
         }
     }

     $error = true;
 }

?>
<!DOCTYPE html>
<html>
    <head>
        <link href="https://fonts.googleapis.com/css2?family=Josefin+Sans:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;1,100;1,200;1,300;1,400;1,500;1,600;1,700&display=swap" rel="stylesheet"> 
        <title>Login Warung Mantabs</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body class="login-page">
        <div class="login-box">
            <img src="/gambar/profile.png" class="profile">
            <h1> LOGIN </h1>
<?php if(isset($error)) : ?>
    <p style="color=red; font-style: italic;">username/password salah</p>
<?php endif; ?>
            <form action="" method="post">
                <input type="text" name="namauser" placeholder="Enter Username">
                <p>Password</p>
                <input type="Password" name="password" placeholder="Enter Password">
                <input type="submit" name="login" value="login">
                <a href="registrasi.php" class="registrasi"> Registrasi</a>
            </form>
        </div>
    </body>
</html>