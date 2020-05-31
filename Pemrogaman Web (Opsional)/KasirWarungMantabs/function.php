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
    $nama = $_POST("nama");
        $jeniskelamin = $_POST("jeniskelamin");
        $nohp = $_POST("nohp");
        $alamat = $_POST("alamat"); 

        $query = "INSERT INTO pelanggan VALUES ('','$nama','$jeniskelamin','$nohp','$alamat')";

        mysqli_query($conn, $query);
        return mysqli_affected_row($conn);
}
?>