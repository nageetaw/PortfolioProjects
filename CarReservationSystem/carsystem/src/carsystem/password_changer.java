package carsystem;

import java.sql.*;
public class password_changer{
	public static Statement statement;
	public static Connection connection;
	
	public boolean change_my_password(String User_id,String new_password){
		
		try{

			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			 	
			statement.executeUpdate("update customers set PASSWORD='"+new_password+"' where C_ID='"+User_id+"'");
			
			connection.close();
			statement.close();
			return true;
				
			
		}catch(Exception e){
			System.out.println("Error in password cahnger");
			e.printStackTrace();
			
		}
		return false;
		
	}
	
	public boolean update_my_data(String fname, String lname, String email, String contactno, String user_id){	

		try{

			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			 	
			statement.executeUpdate("update customers set FIRST_NAME='"+fname+"',LAST_NAME='"+lname+"',EMAIL_ID='"+email+"',PHONE_NUMBER="+contactno+" where C_ID='"+user_id+"'");
			
			connection.close();
			statement.close();
			return true;
				
			
		}catch(Exception e){
			System.out.println("Error in password cahnger");
			e.printStackTrace();
			
		}
		return false;
	}
	
	
}