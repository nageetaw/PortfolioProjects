import java.sql.*;
public class withdraw_process{
      public static ResultSet resultset;
	  public static Statement statement;
	  public static Connection connection;	
		
	public int withdraw_method(String user_id,int deduct_amount){
        try{
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			connection=DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
			statement= connection.createStatement();
			resultset= statement.executeQuery("select user_id,Amount from Table1");
			boolean flag= true;
			int amount;
			
			while(resultset.next()&& flag==true){
		
				if(resultset.getString(1).equals(user_id)){
					
					System.out.println(resultset.getString(1));
				    amount = Integer.parseInt(resultset.getString(2));
					amount-=deduct_amount;
					System.out.println(amount);
					System.out.println();
					System.out.println();
					
					flag=false;
					return 1;
				}
				
				
			}
			connection.close();
			resultset.close();
			statement.close();
			
			
		}catch(Exception e){
			System.out.println("error in withdraw process");
			e.printStackTrace();
			
			
		}
		return 0;
	}
}
