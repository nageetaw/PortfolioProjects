import java.sql.*;
public class transfer_process{
	public static Connection connection;
	public static Statement statement;
	public static ResultSet resultset;
	
	public int transfer_method(String user_id,int transfer_amount, String other_id){
		try{
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			
			connection= DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
			statement=connection.createStatement();
			resultset=statement.executeQuery("select user_id,Amount from Table1");
			int user_amount;
			boolean check = true;
			while(resultset.next()&& check){
				if(resultset.getString(1).equals(user_id)){
					user_amount=Integer.parseInt(resultset.getString(2));
					System.out.println("in transfer user amount is equal to " + user_amount);
                      
 

				
					
					check= false;
					return 1;
				}
			
			}
			
			
		
			
		}catch(Exception e){
			System.out.println("in transfer process");
			e.printStackTrace();
			
			
		}
		return 0;		
		
	}	
}