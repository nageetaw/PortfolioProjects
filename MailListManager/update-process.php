<?php
include "Connection.php";

if($_GET['action'] == "true") {
    $time=date("Y-m-d h:i:sa");
	$query="UPDATE leads_list_table set first_name='".$_GET['first_name']."',last_name='".$_GET['last_name']."',address='".$_GET['address']."',city='".$_GET['city']."',state='".$_GET['state']."',zip_code='".$_GET['zip_code']."',lists='".$_GET['list']."',offer='".$_GET['offer']."',status='".$_GET['status']."',email='".$_GET['email']."',phone='".$_GET['phone']."',modified='".$time."' WHERE Id='".$_GET['id']."'";
	$result=mysqli_query($db,$query);
	
  }

?>