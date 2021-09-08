
<!DOCTYPE html>
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
   
   function MainSearch(DisplayHere){
		
		var element=document.getElementById('searchbar').value;
		//alert(window.chooseStatus);
		 var Dislayblock = document.getElementById(DisplayHere);
			Dislayblock.style.display="Block";
	    if(element.length > 0){
			
			$.get({
						url: 'search.php?Item='+ element,
						success: function(result){
							$('#SearchedList').html(result);
							
						  }
					}
				  );
			
		}else{
			alert("Type something in search bar");
		}
	}

	
</script>
<style>

.container{
	 position: relative;
  padding-left: 15px;
  margin-bottom: 12px;
  cursor: pointer;
  font-size: 20px;
	
}
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
<div style="background-color:grey;">

<ul>
  <li><a class="active" href="Leads.php">Leads</a></li>
 
  <li><a href="ImportFile.php">Import</a></li>
  <li><a <button type="button" title="CV" data-toggle="modal" data-target="#cv" Style="Color:white;">Add Record</button></a>
						<div class="modal fade" id="cv" style="width:100%;">
							<div class="modal-dialog modal-lg">
								<div class="modal-content">
									<div class="modal-header">
										<button type="button" class="close" data-dismiss="modal"> &times;</button>
									</div>
									<div class="modal-body">
										<div id="AddRecordform" style=" margin-left:80px;">

<Form  method="POST"  class="formdesign">

               <h1 style="color: #5271FF" >Form</h1>
                <input type="text" class="Field" placeholder="First Name" name="userfirstname" required>
                <input type="text" class="Field" placeholder="Last Name" name="userlastname" ><br>
                <input type="text" class="Field" placeholder="Street" name="userstreet" required style ="width:350px;"><br>
                <input type="text" class="Field" placeholder="City" name="usercity" required><br>
				<input type="text" class="Field" placeholder="State" name="userstate" required>
				<input type="text" class="Field" placeholder="Zip" name="userzip" required><br>
				
                <input type="text" class="Field" placeholder="Email" name="useremail">
				<input type="text" class="Field" placeholder="Phone Number" name="userphonenumber" ><br>
				<input type="text" class="Field" placeholder="List" name="userlist" required style ="width:350px;"><br>
				<input type="text" class="Field" placeholder="Offer purchased" name="offers"  style ="width:350px;"><br>
				
				
				<label style="font-size:20px; height:auto; width:auto;">Status: </label>
				<select name="status" id="status" style="font-size:18px; height:auto; width:auto; margin-right:20px;">
						<option value="Valid">Valid</option>
						<option value="Customer">Customer</option>
						<option value="Reverse">Reverse</option>
						<option value="Nixie">Nixie</option>
				</select>
				
                 <input type="submit" class="default-btn" name="add_lead_record" value="ADD"/>

</form>

</div>
<?php
	
	include "Connection.php";
	
        if(isset($_POST['add_lead_record'])){
			
			$time=date("Y-m-d h:i:sa");
            $fname=trim($_POST["userfirstname"]);
			$lname=trim($_POST["userlastname"]);
            $street=trim($_POST["userstreet"]);
			$city=trim($_POST["usercity"]);
			$state=trim($_POST["userstate"]);
			$zip=trim($_POST["userzip"]);
			$email=trim($_POST["useremail"]);
			$phonenumber=trim($_POST["userphonenumber"]);
			$list=trim($_POST["userlist"]);
			$offer=trim($_POST["offers"]);
			$status=trim($_POST["status"]);
			
			if($db){
			  
			  $check=mysqli_query($db,"Select * FROM leads_list_table WHERE first_name='$fname' AND last_name='$lname' AND address='$street' AND zip_code='$zip'");
		      	       	
			if(mysqli_num_rows($check) == 0){
					$query=mysqli_query($db,"Insert into leads_list_table(first_name,last_name,address,city,state,zip_code,lists,status,offer,email,phone,created,modified) 
					values('$fname','$lname','$street','$city','$state','$zip','$list','$status','$offer','$email','$phonenumber','$time','$time')");
					echo '<script type="text/javascript">'; 
					echo ' alert("Succesfully Inserted")'; 
					echo '</script>';
			}else if(mysqli_num_rows($check) == 1){
				
				    
					
					$row = $check -> fetch_assoc();
					$updateID=$row['Id'];
					if($row['lists'] != $list){
						
						$oldlist=explode(",",$row['lists']);
							$newlist=explode(",",$list);
							
							$newComming=count($newlist);
							$totalExist=count($oldlist);
							
							
							
							for($i=0; $i<sizeof($newlist); $i=$i+1){
								 $found = false;
								 
								 
								for($j=0;$j<$totalExist;$j=$j+1){
									
									if(trim(strtolower($newlist[$i]))==trim(strtolower($oldlist[$j]))){
										$found = true;
										
									} 
								}
								if($found == false){
									$oldlist[$totalExist]=$newlist[$i]; $totalExist=$totalExist+1;
								}
						   }
					    
						$Str=implode(',',$oldlist);
						$query="UPDATE leads_list_table set lists='$Str' where Id= '$updateID'";
						$result=mysqli_query($db,$query);
	   
						
					}
					if($row['status']!=$status){
						  if(trim(strtolower($row['status']))== 'nixie'){
							  
							  $query="UPDATE leads_list_table set status='nixie' where Id= '$updateID'";
							  
						  }else if(trim(strtolower($row['status']))== 'reverse'){
							  
							  $query="UPDATE leads_list_table set status='reverse' where Id= '$updateID'";
							  
						  }else if(trim(strtolower($row['status']))== 'customer'){
							  
							  $query="UPDATE leads_list_table set status='customer' where Id= '$updateID'";
							  
						  }
						  else{
						      $query="UPDATE leads_list_table set status='$status' where Id= '$updateID'";
						  }
						$result=mysqli_query($db,$query);
	   
					}
					if($row['offer']!=$offer){
						  
						  
							$oldOffers=explode(",",$row['offer']);
							$newOffers=explode(",",$offer);
							
							$newComming=count($newOffers);
							$totalExist=count($oldOffers);
							
							
							
							for($i=0; $i<sizeof($newOffers); $i=$i+1){
								 $found = false;
								
								 
								for($j=0;$j<$totalExist;$j=$j+1){
									
									if(trim(strtolower($newOffers[$i]))==trim(strtolower($oldOffers[$j]))){
										$found = true;
										
									} 
								}
								if($found == false){
									$oldOffers[$totalExist]=$newOffers[$i]; $totalExist=$totalExist+1;
								}
						   }
					    
						$Str=implode(',',$oldOffers);
						$query="UPDATE leads_list_table set offer='$Str' where Id= '$updateID'";
						$result=mysqli_query($db,$query);
	   
			
					}if($row['email']!=$email){
						
						$query="UPDATE leads_list_table set email='$email' where Id= '$updateID'";
						$result=mysqli_query($db,$query);
						
						
					}if($row['phone']!=$phonenumber){
						
						$query="UPDATE leads_list_table set phone='$phonenumber' where Id= '$updateID'";
						$result=mysqli_query($db,$query);
					
					}
					
			}else{
				    echo '<script type="text/javascript">'; 
					echo ' alert("System Error")'; 
					echo '</script>';
				
			} 
		} 
	}
	
?>
									</div>
								</div>
							</div>
						</div>
</li>
  <li><a href="Customer.php">Customers</a></li>
  <li><a href="Valid.php">Valid</a></li>
   <li><a href="Reverse.php">Reverse</a></li>
  <li><a href="Nixie.php">Nixie</a></li>
</ul>

					 
</div>
<div style=" background-image: url('background.png'); height:450px; background-repeat:no-repeat; background-position:center top; " >
		
		<div class="search-container">
			<form action="#"> 
			  
			  <input type="text" placeholder="Type something..." name="search" id="searchbar" style="height:40px; width:400px; font-size:20px;">
			  <a href="javascript:void(0);"  class="fa fa-search" onclick="MainSearch('SearchedList');" style="font-size:35px; text-decoration:none; color:white;"></a>
			  <br>
		</form>
        	
			<a type="button" title="advancedSearch" data-toggle="modal" data-target="#AdavancedSearch" Style="Color:white;">Advanced Search</a>
				<div class="modal fade" id="AdavancedSearch" style="width:100%;">
					<div class="modal-dialog modal-lg">
						<div class="modal-content">
							<div class="modal-header">
								<button type="button" class="close" data-dismiss="modal"> &times;</button>
							</div>
							<div class="modal-body">
								<div id="AdavancedSearch" style=" margin-left:80px;">
								<Form  method="POST"  action="search.php" class="AdavancedSearchForm">

										<h1 style="color: #5271FF" >Advanced Search</h1>
										<input type="text" id="SelectedList" class="Field" placeholder="List" name="userlist"  >
										
										<input type="radio"  style="height:15px; width:15px;" name="includeORexclude" value="include" onclick="selectIncludeOrExcludeList('include');" checked>
										<label for="includeitemfromlist" style="font-family:arial; font-size:22px; margin-right:20px;" >Include</label>
										
										<input type="radio"  style="height:15px; width:15px;" name="includeORexclude" onclick="selectIncludeOrExcludeList('exclude');" value="exclude">
										<label for="excludeitemfromlist" style="font-family:arial; font-size:22px;  margin-right:20px;" >Exclude</label>
									 
									 <br>
									 
										<input type="text" id="SelectedOffer" class="Field" placeholder="Offer purchased" name="offers"  >
										<input type="radio"  style="height:15px; width:15px;" name="includeORexcludeoffer" value="include" onclick="selectIncludeOrExcludeOffer('include');" checked>
										<label for="includeofferfromlist" style="font-family:arial; font-size:22px; margin-right:20px;" >Include</label>
										
										<input type="radio"  style="height:15px; width:15px;" name="includeORexcludeoffer" onclick="selectIncludeOrExcludeOffer('exclude');" value="exclude">
										<label for="excludeofferfromlist" style="font-family:arial; font-size:22px;  margin-right:20px;" >Exclude</label>
									 
									 <br>
										
											
									<label for="SelectStatus" style=" font-family:arial, sans-serif;font-size:22px;
								   ">Status:</label>
									<select name="LeadsStatus" id="chooseStatus" style="font-size:18px; height:auto; width:auto;">
											<option value="Valid">Valid</option>
											<option value="Customer">Customer</option>
											<option value="Reverse">Reverse</option>
											<option value="Nixie">Nixie</option>
									</select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									   <input type="radio"  style="height:15px; width:15px;" name="includeStatus" value="include" onclick="selectStatus('include');" checked>
										<label for="includestatus" style="font-family:arial; font-size:22px;  margin-right:20px;" >Include</label>
										
										<input type="radio"  style="height:15px; width:15px;" name="includeStatus" onclick="selectStatus('exclude');" value="exclude">
										<label for="excludestatus" style="font-family:arial; font-size:22px; margin-right:20px;" >Exclude</label>
										
									<br>	
									
										 <input type="submit" class="default-btn" name="Adavanced_Search_form" value="Search"/>
										

						</form> 
						</div>
					</div>
				</div>
			</div>
		</div>
			
	</div>
</div>
<div class="options">
			  

      
</div>
<div id="SearchedList" style="display:none;">
  
</div>




<div id="OpenList" style="display:block;">
<?php
	include "Connection.php";
	
	$query ="SELECT * from leads_list_table";
	$result=mysqli_query($db,$query);	

?>

	<form method="post" action="export.php">
		<input type ="submit" name="Export" value="Csv Export" class="default-btn" >
	</form>
		<table id="Table" >
		
			 <tr>
			    <th>Edit</th>
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
			   while($row = $result -> fetch_assoc()){
				?>   
				   <tr>
				   <td >
				   <ul style="overflow:hidden;  background-color:white; "> 
				  <li ><button onclick="allowEdit(<?php echo $row['Id']; ?>);"><i class="fa fa-edit fa-2x" ></i></button></li>
				  
				  
				  <li> <button onclick="saveRecord(<?php echo $row['Id']; ?>);"><i class="fa fa-save  fa-2x" ></i></a></button></li>
				   <li> <button onclick="deleteRecord(<?php echo $row['Id']; ?>);"><i class="fa fa-trash  fa-2x" ></i></a></button></li>
				   
				   <ul>
				   </td>
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
						    <td  id="editPhone"><?php echo $row['phone']; ?>  </td>
							 
							 
						     <!-- <td><a href="update-process.php? id=<?php echo $row["Id"]; ?>&first_name=<?php echo $row["first_name"]; ?>"><i class="fa fa-save" ></i></a></button></td> -->
				   </tr>
			   <?php  
			   }
			   
			  ?>
			 
		</table>

		<p id ="here"></p>
	</div>
	</body>
	</html>

