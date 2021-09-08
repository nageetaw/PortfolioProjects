<?php
session_start();
include "Connection.php";
 		
	    header('Content-type: application/csv');
		header('Content-Disposition: attachment; filename=File.csv');
		
		$output=fopen("php://output","w");
		fputcsv($output,array('Id', 'first_name', 'last_name', 'address', 'city', 'state', 'zip_code', 'lists', 'status', 'offer', 'email', 'phone','created','modified'));
		
		//$query = "SELECT * FROM leads_list_table";
		//$result = mysqli_query($db, $query);

		foreach ($_SESSION['results'] as $row){
			
				fputcsv($output,$row);
			
			
		}	
		
  fclose($output);

  
?>