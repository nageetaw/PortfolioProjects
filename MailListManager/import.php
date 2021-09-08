<?php
include "Connection.php";

 if(isset($_POST["Import"])){
    $time=date("Y-m-d h:i:sa");
    $filename=$_FILES["file"]["tmp_name"];    
     if($_FILES["file"]["size"] > 0)
     {
        $file = fopen($filename, "r");
		$flag=true;
        while (($getData = fgetcsv($file, 10000, ",")) !== FALSE)
           {
			   if($flag){$flag=false; continue;}
			  else{
				  
				  
            $fname=trim($getData[0]);
			$lname=trim($getData[1]);
            $street=trim($getData[2]);
			$city=trim($getData[3]);
			$state=trim($getData[4]);
			$zip=trim($getData[5]);
			$email=trim($getData[9]);
			$phonenumber=trim($getData[10]);
			$list=trim($getData[6]);
			$offer=trim($getData[8]);
			$status=trim($getData[7]);
			
			if($db){
			  
			  $check=mysqli_query($db,"Select * FROM leads_list_table WHERE first_name='$fname' AND last_name='$lname' AND address='$street' AND zip_code='$zip'");
		      	       	
			if(mysqli_num_rows($check) == 0){
					$query=mysqli_query($db,"Insert into leads_list_table(first_name,last_name,address,city,state,zip_code,lists,status,offer,email,phone,created) 
					values('$fname','$lname','$street','$city','$state','$zip','$list','$status','$offer','$email','$phonenumber','$time')");
					
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
							  
						  }else{
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
      }
           fclose($file);  
     }
	                echo '<script type="text/javascript">'; 
					echo ' alert("Imported")'; 
					echo '</script>';
					header( "Location:https://www.sinleymarketing.com/DataBase/Leads.php" );// use url for leads page here.
  }   
 ?>
