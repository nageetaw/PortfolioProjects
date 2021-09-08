package carsystem;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Date;

import javax.swing.JOptionPane;

import java.util.*; 
public class SqlDatabaseConnection {
	public static ResultSet resultset;
	public static Statement statement;
	public static Connection connection;
	public static int  ID;
	int checker(String user_id, String user_pass){	
		try{
		boolean check_id=false;

		Class.forName("com.mysql.jdbc.Driver");		
		connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
		statement=connection.createStatement();
		resultset=statement.executeQuery("select C_ID,PASSWORD from customers;");
		int user_int_id= Integer.parseInt(user_id);
		while(resultset.next()){
			
			if(resultset.getInt(1)==(user_int_id)){
				ID=resultset.getInt(1);
			    //System.out.println(resultset.getString(1));
				check_id=true;		
				
				if(resultset.getString(2).equals(user_pass)){
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
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			resultset=statement.executeQuery("select C_ID,FIRST_NAME,LAST_NAME,EMAIL_ID,NIC_NUMBER,PHONE_NUMBER,PASSWORD from customers;");
			
			while(resultset.next()){
				if(resultset.getInt(1)==ID){
					System.out.println("find id");
					
					System.out.println(resultset.getString(2));
					System.out.println(resultset.getString(3));
					System.out.println(resultset.getString(4));
					System.out.println(resultset.getInt(5));
					System.out.println(resultset.getInt(6));
					System.out.println(resultset.getString(7));
									
					
				     data_collector[0]= resultset.getString(1);
					 data_collector[1]= resultset.getString(2);
					 data_collector[2]= resultset.getString(3);
					 data_collector[3]= resultset.getString(4);
					 data_collector[4]= resultset.getString(5);
					 data_collector[5]= resultset.getString(6);
					 data_collector[6]= resultset.getString(6);
					 
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
	
	
	public ArrayList<String> getCarStocks(){
		
		ArrayList<String> carlist=new ArrayList<String>();
		
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			resultset=statement.executeQuery("select C_NAME,STATUS FROM CARSTOCKS WHERE STATUS='RETURNED'");
			System.out.println("in car stocks");
			while(resultset.next()){
				System.out.println(resultset.getString(1));
				carlist.add(resultset.getString(1));
			}
			resultset.close();
			statement.close();
			connection.close();
			
		}catch(Exception e){
			System.out.println("error in data sender");
			e.printStackTrace();
		}
		
		return  carlist;
	}
	
	public boolean ReserveCar(String user_id,String CarName){
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			
			statement.executeUpdate("INSERT INTO RESERVATION(C_ID,C_NAME) VALUES('"+user_id+"','"+CarName+"')");
			statement.executeUpdate("INSERT INTO CUSTOMER_HISTROY(C_ID,C_NAME) VALUES('"+user_id+"','"+CarName+"')");
			statement.executeUpdate("UPDATE CARSTOCKS SET STATUS='RESERVED' WHERE C_NAME='"+CarName+"'");
			resultset.close();
			statement.close();
			connection.close();
			
			return true;
			
		}catch(Exception e){
			System.out.println("error in car reservation");
			e.printStackTrace();
		}
		return false;
	}
	
	
	public ArrayList<String>  getCarHistory(String user_id){

		ArrayList<String> carlist=new ArrayList<String>();
		
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			resultset=statement.executeQuery("select C_NAME FROM CUSTOMER_HISTROY WHERE C_ID='"+user_id+"'");
			
			while(resultset.next()){
				//System.out.println(resultset.getString(1));
				carlist.add(resultset.getString(1));
			}
			resultset.close();
			statement.close();
			connection.close();
			
		}catch(Exception e){
			System.out.println("error in car histroy function");
			e.printStackTrace();
		}
		
		return  carlist;
	 }
	
	public int ID_assigner() {
		int id=-1;
		try {
			
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			resultset=statement.executeQuery("SELECT C_ID FROM CUSTOMERS ORDER BY C_ID DESC LIMIT 1");
		
			while(resultset.next())
			   id=(resultset.getInt(1))+1;
			
			return id;
			
		}catch(Exception e) {
			
			e.printStackTrace();
			System.out.println("error in id assignmner");
		}
	return 8;
	
	}
	
	public int data_saver(String fname,String lname, String  email_id, String nic_number, int id,String password,String contactNo){
		try{
			
			 Class.forName("com.mysql.jdbc.Driver");		
			 connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			 statement=connection.createStatement();
			
			 statement.executeUpdate("INSERT INTO CUSTOMERS VALUES("+ id +",'"+ fname+ "','" + lname+ "' ,'" + email_id +"',"+nic_number+","+contactNo+",'"+password+"')");
			 
			 connection.close();
			 statement.close();
			 
			 return id;
		}catch(Exception e){
			System.out.println("error in data saver");	
		}
			return 0; 		 
	 }	

public ArrayList<String> AvailableCarStocks(){
		
		ArrayList<String> carlist=new ArrayList<String>();
		
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			resultset=statement.executeQuery("select C_NAME,STATUS FROM CARSTOCKS WHERE STATUS='RETURNED'");
			
			while(resultset.next()){
			
				carlist.add(resultset.getString(1));
			}
			resultset.close();
			statement.close();
			connection.close();
			
		}catch(Exception e){
			System.out.println("erroravailable car stocks");
			e.printStackTrace();
		}
		
		return  carlist;
	}
	public int UpdateCarName(String oldCarName,String newName){
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			statement.executeUpdate("update CARSTOCKS set C_NAME='"+newName+"' WHERE C_NAME='"+oldCarName+"'");
			statement.close();
			connection.close();
			return 1;
		    }catch(Exception e){
			System.out.println("error in update car");
			e.printStackTrace();
		   }
		
		return 0;
	}
	
	public int AddNewCar(String newCar){
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			statement.executeUpdate("Insert INTO CARSTOCKS(C_NAME,STATUS) VALUES('"+newCar+"','RETURNED')");
			statement.close();
			connection.close();
			return 1;
		    }catch(Exception e){
			System.out.println("error in add car");
			 
			
		   }
		
		return 0;
		
	}
 public int RemoveCar(String CarName) {
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			statement.executeUpdate("DELETE FROM CARSTOCKS WHERE C_NAME='"+CarName+"'");
		
			statement.close();
			connection.close();
			return 1;
		    }catch(Exception e){
			System.out.println("error in remove car");
			e.printStackTrace();
		   }
		    return -1;
	     }
 String data[][];
 	public String[][] Bookings(){
 		
		try{
			Class.forName("com.mysql.jdbc.Driver");		
			connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
			statement=connection.createStatement();
			resultset=statement.executeQuery("SELECT C_ID,C_NAME,STATUS FROM CUSTOMERS INNER JOIN RESERVATION USING(C_ID) INNER JOIN CARSTOCKS USING(C_NAME);");
			int i=0,j=0,count=0;
			while(resultset.next()){
				count++;// to find the rows retrived
			}
			data= new String[count][3];
			
			resultset=statement.executeQuery("SELECT C_ID,C_NAME,STATUS FROM CUSTOMERS INNER JOIN RESERVATION USING(C_ID) INNER JOIN CARSTOCKS USING(C_NAME);");
			
			while(resultset.next()){
				data[i][j]=(resultset.getString(1));
				++j;
				data[i][j]=(resultset.getString(2));
				++j;
				data[i][j]=(resultset.getString(3));
	            j=0;
	            ++i;
			}
			resultset.close();
			statement.close();
			connection.close();
			
		}catch(Exception e){
			System.out.println("error in car booking data");
			e.printStackTrace();
		}
		
		return data;
     }
 	
 	int UpdateCarStatus(int id,String carname ,String newStatus){
 		try{
				Class.forName("com.mysql.jdbc.Driver");		
				connection= DriverManager.getConnection("jdbc:mysql://localhost:3306/carrentaldb","root","");		
				statement=connection.createStatement();
			
			if (newStatus.contentEquals("CANCELED") ||newStatus.contentEquals("RETURNED")){
				
				statement.executeUpdate("DELETE FROM RESERVATION WHERE C_ID="+id+" AND C_NAME = '"+carname+"';");
				statement.executeUpdate("UPDATE CARSTOCKS SET STATUS='RETURNED' WHERE C_NAME='"+carname+"'");	
			}else {
				
			   statement.executeUpdate("UPDATE CARSTOCKS SET STATUS='"+newStatus+"' where C_NAME='"+carname+"'");
			
			}
			statement.close();
			connection.close();
			return 1;
		    }catch(Exception e){
			System.out.println("error in update status or cancel booking");
			e.printStackTrace();
		   }
 		return 0;
 	}
}

