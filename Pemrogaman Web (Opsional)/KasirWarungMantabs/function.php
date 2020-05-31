<?php

$conn = mysqli_connect("localhost","root","","databasekasir");



function query($query){
    global $conn;
    $result = mysqli_query($conn, $query);
    $rows = [];
    while( $row = mysqli_fetch_assoc($result)){
        $rows[] = $row;
    }
    return $rows;
}

function tambah ($data){
    global $conn;
        $namapelanggan = $data["namapelanggan"];
        $jeniskelamin = $data["jeniskelamin"];
        $nohp = $data["nohp"];
        $alamat = $data["alamat"]; 

        $query = "INSERT INTO pelanggan VALUES ('','$namapelanggan','$jeniskelamin','$nohp','$alamat')";

        mysqli_query($conn, $query);

        return mysqli_affected_rows($conn);
}

function hapus($id){
    global $conn;
    mysqli_query($conn, "DELETE FROM pelanggan WHERE idpelanggan = $id");
    return mysqli_affected_rows($conn);
}

function registrasi($data){
    global $conn;
    $usernama = strtolower(stripslashes($data["namauser"]));
    $password = mysqli_real_escape_string($conn, $data["password"]);
    $password2 = mysqli_real_escape_string($conn, $data["password2"]);
    $resultreg = mysqli_query($conn, "SELECT namauser FROM user WHERE namauser = '$usernama'");

    if (mysqli_fetch_assoc($resultreg)){
        echo "<script>
        alert ('username sudah terdaftar!')</script>";
        return false;
    }
    if ($password != $password2){
        echo "<script>
            alert ('konfirmasi password tidak sesuai:');
            </script>";
            return false;
    }

    

    $password = password_hash($password, PASSWORD_DEFAULT);
 
    mysqli_query($conn, "INSERT INTO user VALUES('','$usernama','$password')");

    return mysqli_affected_rows($conn);




}
?>