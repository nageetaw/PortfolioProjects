
<?php
include "Connection.php";

if($_GET['action'] == "true") {
	$query="DELETE FROM leads_list_table WHERE Id='".$_GET['id']."'";
	$result=mysqli_query($db,$query);
					echo '<script type="text/javascript">'; 
					echo ' alert("Deleted")'; 
					echo '</script>';
					header("refresh:1");
  }
 
?>