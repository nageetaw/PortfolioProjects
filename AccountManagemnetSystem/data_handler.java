import java.sql.*;
public class data_handler{
	public static Connection connection;
	public static Statement statement;
	public static ResultSet resultset;
	
 public int data_saver(String user_name, String  email_id, String nic_number ,String amount, String id,String password){
	try{
		 Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
		 connection = DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
		 statement=connection.createStatement();
		 int find = statement.executeUpdate("insert into Table1(user_id,password,Amount,Name,Email_id,NIC) values('"+ id +"','"+ password + "','" + amount + "' ,'" + user_name +"','"+email_id+"','"+nic_number+"')");
	     connection.close();
		 statement.close();
		 return find;
	}catch(Exception e){}
		return 0; 
		 
	 
	 
 }	
}