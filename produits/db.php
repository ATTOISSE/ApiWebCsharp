<?php
//echo 'ok';
$db_name = "produit";
$bd_server = "127.0.0.1";
$db_user = "root";
$db_pass = "";

$db = new PDO("mysql:host={$bd_server};dbname={$db_name};charset=utf8", $db_user, $db_pass) ;
// $db  = new PDO("mysql:host={$bd_server}; dbname={$db_name}; charset=utf8",$username,$password);
$db->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
$db->setAttribute (PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

?>