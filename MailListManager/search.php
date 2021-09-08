<?php session_start();?>
<html>
<head>
<meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Mailing Lists</title>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
   
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

		<!-- Popper JS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
 
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>

		<!-- Latest compiled JavaScript -->
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>	<link rel="stylesheet" type="text/css" href="my_style.css">
	
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <!-- contenteditable="true"-->
	 <link rel='stylesheet' type='text/css' media='screen' href='MailingStyles.css'>

<script>
  function deleteRecord(id){
	  
	  var myTab = document.getElementById('Table');
        var value="true";
      
		  var txt;
		  var r = confirm("Are you sure you want to delete a record");
		  if (r == true) {
			  
			

        for (i = 1; i < myTab.rows.length; i++) {

            
            var objCells = myTab.rows.item(i).cells;
			
			if(objCells.item(1).innerHTML == id){
				
				
				
				 for (var j = 2; j < objCells.length-3; j++) {
					 
						objCells.item(j).style.backgroundColor= "white";
					 $(objCells.item(j)).attr('contenteditable','false');
					 
			}
			       $.get({
						url: 'delete-record.php?id='+objCells.item(1).innerHTML+"&action="+value, 
						success: function(result){
							$('#here').html(result);
							
							
						  }
					}
				  );
        }
	   
     } 
	 } else {
			  
	
		  }location.reload();
	  
  }
   function allowEdit(id){
        var myTab = document.getElementById('Table');
        // alert("in edit");
      
        for (i = 1; i < myTab.rows.length; i++) {

            
            var objCells = myTab.rows.item(i).cells;
			
			if(objCells.item(1).innerHTML == id){
				
				
				 for (var j = 2; j < objCells.length; j++) {
					 
					
					 $(objCells.item(j)).attr('contenteditable','true');
					 objCells.item(j).style.backgroundColor= "lightgrey";
					 objCells.item(j).style.border="2px solid black";
					 
			}

        }
	   
     }
   }
   function saveRecord(id){
	    var myTab = document.getElementById('Table');
        var value="true";
        
        for (i = 1; i < myTab.rows.length; i++) {

            
            var objCells = myTab.rows.item(i).cells;
			
			if(objCells.item(1).innerHTML == id){
				
				
				
				 for (var j = 2; j < objCells.length; j++) {
					 
						objCells.item(j).style.backgroundColor= "white";
					 $(objCells.item(j)).attr('contenteditable','false');
					  objCells.item(j).style.border="1px solid #dddddd";
					 
			}
			       $.get({
						url: 'update-process.php?id='+objCells.item(1).innerHTML+'&first_name='+objCells.item(2).innerHTML+'&last_name='+objCells.item(3).innerHTML+'&address='+objCells.item(4).innerHTML+'&city='+objCells.item(5).innerHTML+'&state='+objCells.item(6).innerHTML+'&zip_code='+objCells.item(7).innerHTML+'&list='+objCells.item(8).innerHTML+'&offer='+objCells.item(9).innerHTML+'&status='+objCells.item(10).innerHTML+'&email='+objCells.item(11).innerHTML+'&phone='+objCells.item(12).innerHTML+"&action="+value, 
						success: function(result){
							$('#here').html(result);
							
							
						  }
					}
				  );
        }
	   
     }  
	   
   }

	
</script>
<style>
li{
	
	margin:0px 5px 5px;
	padding:0px;

}
       table{
		    width:100%;	
           margin-top:30px;	
		font-size:16px;
	   margin-left:auto;margin-right:auto;
	   }
		table, th, td {
			
		  border: 1px solid black;
		  border-collapse: collapse;
		  width:auto;
		}
		th{
			background-color:#5271FF;
			
		}
		th, td {
	     border: 1px solid #dddddd;
		  padding: 7px;
		  width:auto;
		 
		}
		ul li a:hover{
			text-decoration:none;
			color:white;
			
		}
.default-btn{
	
	background-color:#5271FF;
	color:white;
	width:120px;
	margin-left:20px;
	height:40px;
	border-radius: 2px;
}
</style>
</head>
<body>
<?php

	include "Connection.php";
	

	
	function DisplayResults($finalResult){
		
		?>
		<h1 style="text-align:center;">Filter Results</h1>
	    <form method="post" action="FilterExport.php">
		<input type ="submit" name="export" value="Csv Export" class="default-btn" >
		</form>
		<table id="Table" >
		
			 <tr>
			    <th>EDIT</th>
			    <th>ID</th>
				<th>FIRST NAME</th>
				<th>LAST NAME</th>
				<th>ADDRESS</th>
				<th>CITY</th>
				<th>STATE</th>
				<th>ZIP CODE</th>
				<th>LIST</th>
				<th>OFFER</TH>
	             <th>STATUS</th>
                <TH>EMAIL</TH>
                <TH>PHONE</TH>				
				
				
			 </tr>
			 
			 <?php
			   while($row = $finalResult -> fetch_assoc()){
				   $arr_rows[] = $row;
				?> 
				
			 <tr>
				   <td>
				   <ul style="overflow:hidden;  background-color:white;"> 
				  <li ><button onclick="allowEdit(<?php echo $row['Id']; ?>);"><i class="fa fa-edit fa-2x" ></i></button></li>
				  <li> <button onclick="saveRecord(<?php echo $row['Id']; ?>);"><i class="fa fa-save  fa-2x" ></i></a></button></li>
				   <li> <button onclick="deleteRecord(<?php echo $row['Id']; ?>);"><i class="fa fa-trash  fa-2x" ></i></a></button></li>
				   
				   <ul></td>
				   <td> <?php echo $row['Id']; ?>  </td>
				   <td ><?php echo $row['first_name']; ?>  </td>
				    <td ><?php echo $row['last_name']; ?>  </td>
					 <td ><?php echo $row['address']; ?>  </td>
					  <td ><?php echo $row['city']; ?>  </td>
					   <td ><?php echo $row['state']; ?>  </td>
					    <td ><?php echo $row['zip_code']; ?>  </td>
						  <td ><?php echo $row['lists']; ?>  </td>
						   <td ><?php echo $row['offer']; ?>  </td>
						   <td ><?php echo $row['status']; ?>  </td>
						    <td ><?php echo $row['email']; ?>  </td>
						    <td><?php echo $row['phone']; ?>  </td>
							
			<?php
			  $_SESSION[ 'arr_rows' ] = $arr_rows;
			  }
			?>	   </tr>
				   
		</table>
<?php
		

	}
   
 if(isset($_POST["Adavanced_Search_form"])){
	   
	$isList=trim(strtolower($_POST['includeORexclude']));
	$list=trim(strtolower($_POST['userlist']));
	$isOffer=trim(strtolower($_POST['includeORexcludeoffer']));
	$offer=trim(strtolower($_POST['offers']));
	$status=trim(strtolower($_POST['LeadsStatus']));
	$choosenStatus=trim(strtolower($_POST['includeStatus']));
	$query="Select * from leads_list_table";
	
	 
 
    if(strlen($list) >0 && strlen($offer)>0){ // when list and offer both are given
		
		//either both are included
		if($isList == "include" && $isOffer == "include"){
			
			    $query="Select * from leads_list_table";
				$result=mysqli_query($db,$query);
				$finalId=array();
				$count=0;
				$found=false;
				while($row = $result -> fetch_assoc()){// fetching rows
				
				$tempListArray=explode(",",$row['lists']); // array of list on individual row
				$tempOfferArray=explode(",",$row['offer']);// array of offer on individual row
				
				
				for($i=0; $i<sizeof($tempOfferArray); $i++){ // searching of included list
					
					if(trim(strtolower($tempOfferArray[$i]))== $offer){
					// if list is matched search of offer excluded
					$found=false;
					
					for($j=0; $j<sizeof($tempListArray);$j++){
						  
					     if(trim(strtolower($tempListArray[$j]))== $list)	{
							 
							 $found=true;
							 break;
						 }
					}
					  if($found== true){
						 
						 $finalId[$count]=$row['Id']; 
					     $count=$count+1;
					  
					  }
						
				 } 
				 
			   }	   
			   
			}
	
			
			       if($choosenStatus == "include"){
						 
						 $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status ='$status'";
						 
					 }else{
						 
						$query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status !='$status'"; 
						 
					 }
			
			
		}		// one is inclided and other is excluded
		else if($isList == "include" && $isOffer == "exclude"){
			
				$query="Select * from leads_list_table";
				$result=mysqli_query($db,$query);
				$finalId=array();
				$count=0;
				$found=false;
				while($row = $result -> fetch_assoc()){// fetching rows
				
				$tempListArray=explode(",",$row['lists']); // array of list on individual row
				$tempOfferArray=explode(",",$row['offer']);// array of offer on individual row
				
				
				for($i=0; $i<sizeof($tempListArray); $i++){ // searching of included list
					
					if(trim(strtolower($tempListArray[$i]))== $list){
					// if list is matched search of offer excluded
					$found=false;
					
					for($j=0; $j<sizeof($tempOfferArray);$j++){
						  
					     if(trim(strtolower($tempOfferArray[$j]))== $offer)	{
							 
							 $found=true;
							 break;
						 }
					}
					  if($found== false){
						 
						 $finalId[$count]=$row['Id']; 
					     $count=$count+1;
					  
					  }
						
				 } 
				 
			   }	   
			   
			}
	
			
			       if($choosenStatus == "include"){
						 
						 $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status ='$status'";
						 
					 }else{
						 
						$query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status !='$status'"; 
						 
					 }
			
		}
		// one is inclided and other is excluded
		else if($isList == "exclude" && $isOffer == "include"){
			
			    $query="Select * from leads_list_table";
				$result=mysqli_query($db,$query);
				$finalId=array();
				$count=0;
				$found=false;
				while($row = $result -> fetch_assoc()){// fetching rows
				
				$tempListArray=explode(",",$row['lists']); // array of list on individual row
				$tempOfferArray=explode(",",$row['offer']);// array of offer on individual row
				
				
				for($i=0; $i<sizeof($tempOfferArray); $i++){ // searching of included list
					
					if(trim(strtolower($tempOfferArray[$i]))== $offer){
					// if list is matched search of offer excluded
					$found=false;
					
					for($j=0; $j<sizeof($tempListArray);$j++){
						  
					     if(trim(strtolower($tempListArray[$j]))== $list)	{
							 
							 $found=true;
							 break;
						 }
					}
					  if($found== false){
						 
						 $finalId[$count]=$row['Id']; 
					     $count=$count+1;
					  
					  }
						
				 } 
				 
			   }	   
			   
			}
	
			
			       if($choosenStatus == "include"){
						 
						 $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status ='$status'";
						 
					 }else{
						 
						$query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status !='$status'"; 
						 
					 }
			
		}
		// both are excluded
		else{
				
			         
			    $query="Select * from leads_list_table";
				$result=mysqli_query($db,$query);
				$finalId=array();
				$count=0;
				$listfound=false;
				$offerfound=false;
				while($row = $result -> fetch_assoc()){// fetching rows
				
				$tempListArray=explode(",",$row['lists']); // array of list on individual row
				$tempOfferArray=explode(",",$row['offer']);// array of offer on individual row
				
				$offerfound=false;
				$listfound=false;
				
				for($i=0; $i<sizeof($tempOfferArray); $i++){ // searching of included list
					
					if(trim(strtolower($tempOfferArray[$i]))== $offer){
					// if list is matched search of offer excluded
					   $offerfound=true;
					   break;
						
				    } 
				 
			   }
			   if($offerfound == false){
				   
				   for($j=0; $j<sizeof($tempListArray);$j++){
						  
					     if(trim(strtolower($tempListArray[$j]))== $list){
							 
							 $listfound=true;
							 break;
						 }
					}
					if($listfound == false){
						
						$finalId[$count]=$row['Id']; 
					     $count=$count+1;
					}
				   
			   }
	   
			   
			}
	
			
			       if($choosenStatus == "include"){
						 
						 $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status ='$status'";
						 
					 }else{
						 
						$query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status !='$status'"; 
						 
					 }
			
		
		}
	
	}// end if 
    else if(strlen($list) >0){ // only list is given
		 
		 
		$query="Select * from leads_list_table";
		$result=mysqli_query($db,$query);
		$finalId=array();
		$count=0;
			
	
		 // list is include
		 if($isList =="include"){
			 while($row = $result -> fetch_assoc()){
			
			$tempArray=explode(",",$row['lists']);
			
			for($i=0; $i<sizeof($tempArray); $i++){
				
				if(trim(strtolower($tempArray[$i]))== $list){
				
					$finalId[$count]=$row['Id']; $count=$count+1;
					
			 } 
			 
		   }
		}
			 
		 }// list is exclude
		 else{
			 $found=false;
			 while($row = $result -> fetch_assoc()){
				$found=false;
				$tempArray=explode(",",$row['lists']);
				
				for($i=0; $i<sizeof($tempArray); $i++){
					
					if(trim(strtolower($tempArray[$i]))== $list){
					
					   $found=true;
					   break;
						
				 } 
				 
		        }if($found == false){
			   
					$finalId[$count]=$row['Id']; $count=$count+1;
		        }
		    }

		}
		
		if($choosenStatus == "include"){
						 
			 $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status ='$status'";
			 
		 }else{
			 
			$query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status !='$status'"; 
			 
		 }
		
	}else if(strlen($offer) >0){
		
		$query="Select * from leads_list_table";
		$result=mysqli_query($db,$query);
		$finalId=array();
		$count=0;
			
	
		 // list is include
		 if($isOffer =="include"){
			 while($row = $result -> fetch_assoc()){
			
			$tempArray=explode(",",$row['offer']);
			
			for($i=0; $i<sizeof($tempArray); $i++){
				
				if(trim(strtolower($tempArray[$i]))== $offer){
				
					$finalId[$count]=$row['Id']; $count=$count+1;
					
			 } 
			 
		   }
		}
			 
		 }// list is exclude
		 else{
			 $found=false;
			 while($row = $result -> fetch_assoc()){
				$found=false;
				$tempArray=explode(",",$row['offer']);
				
				for($i=0; $i<sizeof($tempArray); $i++){
					
					if(trim(strtolower($tempArray[$i]))== $offer){
					
					   $found=true;
					   break;
						
				 } 
				 
		        }if($found == false){
			   
					$finalId[$count]=$row['Id']; $count=$count+1;
		        }
		    }

		}
		
		if($choosenStatus == "include"){
						 
			 $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status ='$status'";
			 
		 }else{
			 
			$query="Select * from leads_list_table where Id IN (".implode(',',$finalId).") and status !='$status'"; 
			 
		 }
	}
	    
		$result=mysqli_query($db,$query);
		
		 if($result == null){
			 echo '<script type="text/javascript">'; 
					echo ' alert("Not Found")'; 
					echo '</script>';
					
		 }
		 else
			DisplayResults($result);
		
	    $result=mysqli_query($db,$query);
		if($result != null)
			$_SESSION['results'] = $result->fetch_all();   	 
 }else{	 
 
	 $Item=strtolower(trim($_GET['Item']));
	 $query="Select * from leads_list_table";
				$result=mysqli_query($db,$query);
				$finalId=array();
				$count=0;
				$listfound=false;
				$offerfound=false;
				while($row = $result -> fetch_assoc()){// fetching rows
				
				$tempListArray=explode(",",$row['lists']); // array of list on individual row
				$tempOfferArray=explode(",",$row['offer']);// array of offer on individual row
				
				$offerfound=false;
				$listfound=false;
				
				for($i=0; $i<sizeof($tempOfferArray); $i++){ // searching of included list
					
					if(trim(strtolower($tempOfferArray[$i]))== $Item){
					// if list is matched search of offer excluded
					   $offerfound=true;
					   break;
						
				    } 
				 
			   }
			   if($offerfound == false){
				   
				   for($j=0; $j<sizeof($tempListArray);$j++){
						  
					     if(trim(strtolower($tempListArray[$j]))== $Item){
							 
							 $listfound=true;
							 break;
						 }
					}
					if($listfound == true){
						
						$finalId[$count]=$row['Id']; 
					     $count=$count+1;
					}
				   
			   }else {
				    
					  $finalId[$count]=$row['Id']; 
					     $count=$count+1;
				   
			   }
			   
			}

				 
	    $query="Select * from leads_list_table where Id IN (".implode(',',$finalId).")";
		$result=mysqli_query($db,$query);
	   if($result == null){
		   
			 $query="Select * from leads_list_table where first_name ='$Item' or last_name='$Item' or status='$Item' or address='$Item' or city='$Item' or state='$Item' or zip_code='$Item' or email='$Item' or phone='$Item'"; 
	 			 
		   $Secondresult=mysqli_query($db,$query);
		   
			if($Secondresult == null){
			       echo '<script type="text/javascript">'; 
					echo ' alert("Not Found")'; 
					echo '</script>';
			}else {
			   DisplayResults($Secondresult);
			 echo '<script type="text/javascript">'; 
					echo 'alert(not found);'; 
					echo '</script>';
			}
		 }
		 else
			DisplayResults($result);
		
	    	 
 
 }


?>

 
</body>
</html>