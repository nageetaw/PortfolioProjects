import java.util.Random;
import java.sql.*;
public class id_manager{
		public static Connection connection;
	    public static Statement statement;
	    public static ResultSet resultset;

	public String id_assigner(){
		String id="";
		int temp_id=0;
		try{
      Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
	  connection= DriverManager.getConnection("jdbc:ucanaccess://info.accdb");
	  statement=connection.createStatement();
	  resultset= statement.executeQuery("select user_id from Table1");
	  while(resultset.next()){
		  id= resultset.getString(1);
        System.out.println(id);
	  }
	connection.close();
	statement.close();
	resultset.close();
	 temp_id=Integer.parseInt(id);
	 System.out.println("id before increament" + temp_id);
	temp_id+=1;
	System.out.println("id after inceament" + temp_id);
	return ""+temp_id;
		}catch(Exception e){
			System.out.println();	System.out.println();	System.out.println();	System.out.println();
				System.out.println("in id manager");
			e.printStackTrace();
		}return ""+temp_id;
	}
	
}