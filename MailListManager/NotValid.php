
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Mailing Lists</title>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <link rel='stylesheet' type='text/css' media='screen' href='MailingStyles.css'>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
   <script>
	function show(ID){
		
		 var element = document.getElementById(ID);
		    if(ID == 'OpenList'){
			  element.style.display = "block";
			  hide('ImportFile');
			  
			}
			else if(ID == 'ImportFile'){
				element.style.display = "block";
			  hide('OpenList');
			 	
			}else if(ID == 'Export'){
			    hide('OpenList');
               hide('ImportFile');			  
			}
	}
	function hide(ID){
		   var element = document.getElementById(ID);
		     element.style.display = "none";
	  }
    $(document).ready(function(){
        $("input[type='radio']").click(function(){
            var radioValue = $("input[name='is_selected']:checked").val();
            if(radioValue){
	
				show(radioValue);
            }
        });
    });
</script>
  <style>
       table{
		    width:100%;	
           margin-top:30px;			
	   }
		table, th, td {
			
		  border: 1px solid black;
		  border-collapse: collapse;
		}
		th{
			background-color: #ec9521;
		}
		th, td {
			  border: 1px solid #dddddd;
		  padding: 15px;
		 
		}
</style>
</head>
<body>

<div class="nav_bar">
		<ul>
		  <li><a href="dbconfignew.php">Home</a></li>
		  <li><a href="Leads.php">Leads</a></li>
		  <li><a href="Customers.php">Customers</a></li>
		  <li><a href="Reverse.php">Reverse</a></li>
		   <li><a href="#">NotValid</a></li>
		</ul>
</div>
<div style=" background-image: url('image1.png'); height:350px; background-repeat:no-repeat; background-position:center top; " >
		
		
	
</div>

<div class="options">
				<input type="radio" class="btn" id="opennotvalidlist" name="is_selected" value="OpenList" checked>
				  <label for="openlist" class="btn_label">Open List</label>
				  
                   <input type="radio" class="btn" id="importnotvalidlist" name="is_selected" value="ImportFile" >
				  <label for="importfile" class="btn_label">Import File</label>
				  
				   <input type="radio" class="btn" id="exportnotvalidlist" name="is_selected" value="Export" >
				  <label for="exportfile" class="btn_label">Export File</label>
 </div>
 
 
<div id="OpenList" style="display:block;">
<?php
	include "Connection.php";
	
	$query ="SELECT * from invalid_address_list_table";
	$result=mysqli_query($db,$query);	

?>

	
		<table>
		
			 <tr>
			    <th>ID</th>
				<th>FIRST NAME</th>
				<th>LAST NAME</th>
				<th>ADDRESS</th>
				<th>CITY</th>
				<th>STATE</th>
				<th>ZIP CODE</th>
				
				<th>LIST</th>
				
				<th>CREATED</th>
				
				
			 </tr>
			 <?php
			   while($row = $result -> fetch_assoc()){
				?>   
				   <tr>
				   <td> <?php echo $row['Id']; ?>  </td>
				   <td><?php echo $row['first_name']; ?>  </td>
				    <td><?php echo $row['last_name']; ?>  </td>
					 <td><?php echo $row['address']; ?>  </td>
					  <td><?php echo $row['city']; ?>  </td>
					   <td><?php echo $row['state']; ?>  </td>
					    <td><?php echo $row['zip_code']; ?>  </td>
				
						  <td><?php echo $row['list']; ?>  </td>
					
						    <td><?php echo $row['created']; ?>  </td>
							 
				   </tr>
			   <?php  
			   }
			  ?>
			 
		</table>		
</div>
<div id="ImportFile" style="display:none;">

		<form action="#" method="post" enctype="multipart/form-data">
			  <input type="file" name="file" />
			  <input type="submit" class="import_btn" name="importSubmit" value="IMPORT">
			 <!-- <p><a href="sample-csv-members.csv" download>download sample file</a></p>-->
		</form>
                  

</div>
<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
	</body>
	</html>

