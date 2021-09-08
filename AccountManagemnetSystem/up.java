import java.sql.*;
public class up{
	public static Statement statement;
	public static ResultSet resultset;
	public static Connection connection;
	public static void main(String args[]){
		try{
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			connection=DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
			
			
			statement=connection.createStatement();
			resultset=statement.executeQuery("select user_id,Amount from Table1");
			boolean flag=true;
			while(resultset.next() && flag== true){
				if(resultset.getString(1).equals("023_18_0011")){
					UPDATE Table1 SET user_id= ""+="nigeeta" WHERE serial='1';
					flag=false;
				}
				
			}
			connection.close();
			resultset.close();
			statement.close();
		}catch(Exception e){
			e.printStackTrace();
		}
		
		
	}
	
}