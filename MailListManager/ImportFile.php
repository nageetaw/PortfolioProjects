<!DOCTYPE html>
<html>
<head>
 <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Mailing Lists</title>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <!-- Popper JS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
 
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>

		<!-- Latest compiled JavaScript -->
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>	<link rel="stylesheet" type="text/css" href="my_style.css">
	
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
	 <link rel='stylesheet' type='text/css' media='screen' href='MailingStyles.css'>
	<style>
	ul li a:hover{
			text-decoration:none;
			color:white;
			
		}
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
		

</style>
</head>
<body>
<div style="background-color:grey;">

					<ul>
  <li><a class="active" href="Leads.php">Leads</a></li>
 
  <li><a href="ImportFile.php">Import</a></li>
  <li><a href="Customer.php">Customers</a></li>
  <li><a href="Valid.php">Valid</a></li>
   <li><a href="Reverse.php">Reverse</a></li>
  <li><a href="Nixie.php">Nixie</a></li>
</ul>

					 
</div>
<div style=" background-image: url('background.png'); height:450px; background-repeat:no-repeat; background-position:center top; " >
		
		
		</div>
<div id="ImportFile" style="margin-top:50px;">

		<form action="import.php" method="post" enctype="multipart/form-data">
			  <input type="file" name="file" />
			  <button type="submit" name="Import" class="default-btn" value="Import">IMPORT</button>
			 
		</form>
		
                  

</div>
				</body>
</html>