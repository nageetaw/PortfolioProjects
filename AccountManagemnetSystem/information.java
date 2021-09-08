import java.sql.*;
public class information{
	public static ResultSet resultset;
	public static Statement statement;
	public static Connection connection;
	public static int  serial_no;
	
	public static int checker(String id , String password){
		try{
			boolean check_id=false;
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			connection= DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
			statement=connection.createStatement();
			
			resultset=statement.executeQuery("select user_id,password,serial from Table1");
			
			while(resultset.next()){
				
				if(resultset.getString(1).equals(id)){
				
				    //System.out.println(resultset.getString(1));
					check_id=true;
					
					
					
					if(resultset.getString(2).equals(password)){
					
			         	serial_no=resultset.getInt(3);
				
			          	System.out.println(resultset.getInt(3));
				
							resultset.close();
			                statement.close();
			                connection.close();
			
				            return 1;
				
				    }
			         else {
     	   			resultset.close();
			        statement.close();
			        connection.close();
	    			   return -1;
				    }
                      
       
					
				}
			
			}	
			if(check_id==false)
				return 0;
			
	
		}catch(Exception e){
			e.printStackTrace();
			System.out.println("error in  data handler");
		}
	return 0;	
		
	}
	
	public String[] data_sender(String data_collector[]){
		welcome_window  welcome_window_obj = new welcome_window();
		try{
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			connection= DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
			statement=connection.createStatement();
			resultset=statement.executeQuery("select serial,user_id,password,Amount,Name,Email_ID,NIC from Table1");
		    while(resultset.next()){
				if(resultset.getInt(1)==serial_no){
					System.out.println("find id");
					System.out.println(resultset.getString(2));
					System.out.println(resultset.getString(3));
					System.out.println(resultset.getString(4));
					System.out.println(resultset.getString(5));
					System.out.println(resultset.getString(6));
					System.out.println(resultset.getString(7));
					
					
					
					
				     data_collector[0]= resultset.getString(2);
					 data_collector[1]= resultset.getString(3);
					 data_collector[2]= resultset.getString(4);
					 data_collector[3]= resultset.getString(5);
					 data_collector[4]= resultset.getString(6);
					 data_collector[5] = resultset.getString(7);
					 
				}
				
			}
			resultset.close();
			statement.close();
			connection.close();
			return data_collector;
		}catch(Exception e){
			System.out.println("error in data sender");
			
			
		}
		return data_collector;
	}
}