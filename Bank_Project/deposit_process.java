import java.sql.*;
public class deposit_process{
	public static Statement statement;
	public static ResultSet resultset;
	public static Connection connection;
	public int deposit_method(String user_id, int deposit_amount){
		
		try{


			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			connection=DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
			statement= connection.createStatement();
			resultset= statement.executeQuery("select user_id,Amount from Table1");
			
			boolean check=true;
			int amount;
			
			while(resultset.next() && check== true){
				
				if(resultset.getString(1).equals(user_id)){
					
					System.out.println("user id in deposit process matched");
					amount=Integer.parseInt(resultset.getString(2));
					System.out.println("amount before deposit is " + amount);
					amount+=deposit_amount;
					System.out.println("amount after deposit is " + amount);
					
					check= false;
					
					return 1;
					
				}
				
		    connection.close();
			resultset.close();
			statement.close();	
				
			}
			
			
			
		}catch(Exception e){
			System.out.println("Error in deposit process");
			e.printStackTrace();
			
		}
		
		return 0;
	}
	
	
	
	
}