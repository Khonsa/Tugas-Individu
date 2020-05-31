<?php

require 'function.php';

if (isset($_POST["submit"]) ) {
        
        if( ubah($_POST) > 0 ){
            echo "<script>
            alert('data berhasil diubah');
            document.location.href = 'selamatDatang.php';
            </script>";
        }else{
            echo "<script>
            alert('data gagal diubah');
            document.location.href = 'selamatDatang.php';
            </script>";
        }

?>