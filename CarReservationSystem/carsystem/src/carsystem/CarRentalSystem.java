package carsystem;
import java.util.ArrayList;
import java.util.Scanner;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import javax.swing.table.*;



public class CarRentalSystem {

	public static void main(String[] args) {
		welcome_window obj = new welcome_window("WELCOME"); // calling the first window for login and signup 

	}

}
//--------------------------------------------------------welcome window class ---------------------------------------------------------------

class welcome_window extends JFrame implements ActionListener{
	JPasswordField password;
     JTextField id;
	 JLabel p_message,id_message;

	    welcome_window(String window_name){

	    setSize(1100,1100);
        setVisible(true);
		setLayout(null);
		setContentPane(new JLabel(new ImageIcon("car2.jpg")));

       JLabel bank_name = new JLabel("Car Reservation System");
		bank_name.setBounds(10,10,600,80);
		bank_name.setFont(new Font("TimesRoman", Font.BOLD, 40));
		bank_name.setForeground(Color.WHITE);
        add(bank_name);

		JLabel login_id = new JLabel("User ID");
		login_id.setBounds(30,120,150,40);
		login_id.setFont(new Font("TimesRoman", Font.BOLD, 20));
		login_id.setForeground(Color.WHITE);
		add(login_id);

		 id = new JTextField();
         id.setBounds(30,170,300,30);
         add(id);

         id_message=new JLabel();
		 id_message.setBounds(340,170,300,30);
		 id_message.setForeground(Color.RED);
		 add(id_message);

		JLabel password_label = new JLabel("Password");
		password_label.setBounds(30,200,100,40);
		password_label.setFont(new Font("TimesRoman", Font.BOLD, 20));
		password_label.setForeground(Color.WHITE);
		add(password_label);

	    password = new JPasswordField();
		password.setBounds(30,240,300,30);
		add(password);

		p_message = new JLabel();
		p_message.setBounds(340,240,300,30);
		p_message.setForeground(Color.RED);
		add(p_message);

		JButton login =new JButton("Login");
		login.setBounds(30,290,100,30);
		add(login);
		login.addActionListener(this);

		JButton signup = new JButton("SignUp");
		signup .setBounds(150,290,150,30);
		add(signup);
		signup.addActionListener(this);
	}

	welcome_window(){


	}
	String[] data_collector = new String[7];
	String Admin_id ="0011", Admin_pass ="1100";
	public void actionPerformed(ActionEvent ae){
		
		SqlDatabaseConnection SqlDatabaseConnection_obj; 
		customer_dashboard profile_obj;
		JButton btn= (JButton)ae.getSource();
		String str_id=this.id.getText();
		String obj_pass=new String(password.getPassword());
		String pass_length=String.valueOf(obj_pass);

		switch(btn.getText()){
			case "Login":
			  if(str_id.length()==0  && pass_length.length()==0){
					 JOptionPane.showMessageDialog(this,"Enter your ID and password");
					

			  }else if(str_id.length()==0){

					 JOptionPane.showMessageDialog(this,"Enter your ID");

				}else if(pass_length.length()==0){

					 JOptionPane.showMessageDialog(this,"Enter your Password");
				}
				 else{

					String pass =new String(password.getPassword());
					if(str_id.equals(Admin_id) && pass.equals(Admin_pass)){
						this.dispose();
						Admin_Profile Admin_Profile_obj = new Admin_Profile(Admin_id,Admin_pass);
						
					}else
					{
							SqlDatabaseConnection_obj= new SqlDatabaseConnection();

							int result = SqlDatabaseConnection_obj.checker(str_id,pass);//obj_info.checker(id.getText(),pass);

			  if(result==1){

					id_message.setText("");
					p_message.setText("");
					SqlDatabaseConnection_obj.data_sender(data_collector);
				                              // to show user details 

				
					  
				  	  customer_dashboard  customer_dashboard_obj= new customer_dashboard(data_collector);
			

				 this.dispose();
       
			  }
			  
		      else if(result == 0){
				  id.setForeground(Color.RED);
					id_message.setText("Incorrect ID");
					p_message.setText("");
					password.setForeground(Color.BLACK);
				}
			  else{
				  password.setForeground(Color.RED);
					p_message.setText("Incorrect Password");
					id_message.setText("");
					id.setForeground(Color.BLACK);
				 }
		       }
	         }

			break;
			case "SignUp":
			signup_window signup_object = new signup_window("Registration");
		this.dispose();
			break;

		}

	}

}
//-----------------------------------------------------------ADMIN DASHBOARD WINDOW--------------------------------------------------------------------------
class Admin_Profile extends JFrame implements ActionListener {
	JLabel dashboard, Admin_menu;
	JButton LogOut;
	String Admin_id,Admin_pass;
	Admin_Profile(String Admin_id,String Admin_pass){
		super("Admin Profile");
		setSize(1370,1200);
		setVisible(true);
		setLayout(null);
	    setContentPane(new JLabel(new ImageIcon("background.jpg")));
	   
	    dashboard = new JLabel("Dashboard");
		dashboard.setBounds(20,20,200,40);
		dashboard.setFont(new Font("TimesRoman", Font.BOLD, 40));
		add(dashboard);
		
		
		
		LogOut = new JButton("LogOut");
	    LogOut.setBounds(1200,10,100,50);
	    add(LogOut);
	    
		LogOut.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent a){
				dispose();
				welcome_window obj = new welcome_window("WELCOME");
				
			}
			});
		JButton viewCars = new JButton("View Cars");
		viewCars.setBounds(60,180,150,30);
		add(viewCars);
		viewCars.addActionListener(this);
		
		JButton AddCars = new JButton("ADD New Car");
		AddCars.setBounds(60,240,150,30);
		add(AddCars);
		AddCars.addActionListener(this);
		
		
		JButton bookingsCars = new JButton("View Booking");
		bookingsCars.setBounds(60,300,150,30);
		add(bookingsCars);
		bookingsCars.addActionListener(this);
		
	}
	
	 public void actionPerformed(ActionEvent ae){
	    	
		 JButton btn = (JButton)ae.getSource();

		 switch(btn.getText()){
		 case "ADD New Car":
			 	AddCar AddCar_obj = new AddCar();
			 break;
			 
		 case "View Booking":
	        ViewBooking ViewBooking_obj = new ViewBooking();
			 break;
		 case "View Cars":
			 ViewCars ViewCars_obj = new ViewCars();
			 break;
		 }
	 }
			
}

//----------------------------------------------------------------ADMIN DASHBOARD OPTIONS---------------------------------------------------

// ADD car class to add any new car in the database

class AddCar extends JFrame implements ActionListener{
	AddCar(){
		setSize(500,400);
		setVisible(true);
		setLayout(null);
	    setContentPane(new JLabel(new ImageIcon("background.jpg")));
	    
	    JTextField newcar= new JTextField();
	     newcar.setBounds(50,50,150,30);
	     add(newcar);
	     JButton btn= new JButton("Add");
	     btn.setBounds(70,90,100,30);
	     add(btn);
	     btn.addActionListener(new ActionListener(){
				public void actionPerformed(ActionEvent a){
					String newCar=newcar.getText();
					SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
	                
	                int check=SqlDatabaseConnection_obj.AddNewCar(newCar);
	                 if(check == 1){
	                	 JOptionPane.showMessageDialog(new customer_dashboard(),"Successfully Added");
	                      dispose();
	                       ViewCars  ViewCar_obj = new ViewCars(); 
	                      }else // when car is already exists in the carstocks
	                    	  JOptionPane.showMessageDialog(new customer_dashboard(),"This Car Already Exits in the Stock");
		             
	              } 
				}
				);
		
	}
	public void actionPerformed(ActionEvent ae){
	}
}

// -----------view car class to see current car stocks in the system

class ViewCars extends JFrame implements ActionListener{
	final JList<String> Carlist;
	ViewCars(){
		setSize(500,500);
		setVisible(true);
		setLayout(null);
	    setContentPane(new JLabel(new ImageIcon("background.jpg")));
	   
	    DefaultListModel<String> carStocks = new DefaultListModel<>(); 
	    
	    SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
		
		ArrayList<String> clist=new ArrayList<String>();
		
		clist=SqlDatabaseConnection_obj.AvailableCarStocks();
		
		if(clist.size()==0) {
			carStocks.addElement("You have still not rented any car");	
			
		}else {
			
			for(String item: clist) {
				
				carStocks.addElement(item);			
			}
          }
	   
	    Carlist = new JList<>(carStocks);  
	    Carlist.setFont(new Font("TimesRoman", Font.BOLD, 15));
	    Carlist.setBounds(40,10,300,350); 
	    add(Carlist);
	    
	    JLabel message= new JLabel("Click Car Name first");
	    message.setBounds(10,370,300,30);
	    add(message);
	    message.setFont(new Font("TimesRoman", Font.BOLD, 20));
	    
	    JButton RemoveCar = new JButton("Remove Car");
	    RemoveCar.setBounds(300,370,90,30);
	    add(RemoveCar);
	    
	    RemoveCar.addActionListener(this);
	    
	    JButton Updatecar = new JButton("Update Car");
	    Updatecar.setBounds(400,370,90,30);
	    add(Updatecar);
	    
	    Updatecar.addActionListener(this);
	}
	public void actionPerformed(ActionEvent ae){
		 
		JButton btn = (JButton)ae.getSource();
		 switch(btn.getText()){
		 case "Update Car":
			 if (Carlist.getSelectedIndex() != -1) { 
				 String CarName = Carlist.getSelectedValue();
             	UpdateCarWindow UpdateCarWindow_obj= new UpdateCarWindow(CarName);
             	dispose();
              } 
			 
			 break;
			 
		 case "Remove Car":
			 if (Carlist.getSelectedIndex() != -1) {                       
                 String CarName = Carlist.getSelectedValue();  
                 SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
                 int check=SqlDatabaseConnection_obj.RemoveCar(CarName);
                 if(check == 1)
                 	 JOptionPane.showMessageDialog(new customer_dashboard(),"Successfully Remvoved");
                      dispose();
                      new ViewCars();
              }
			 break;
		 
		 }
	}
}

//------------------------- update carstatus in the system 
class UpdateCarWindow extends JFrame implements ActionListener{
	String newName;
	UpdateCarWindow(String oldCarName){
		setSize(1000,200);
		setVisible(true);
		setLayout(null);
	    setContentPane(new JLabel(new ImageIcon("background.jpg")));
       
	     JTextField newname= new JTextField();
	     newname.setBounds(50,50,150,30);
	     add(newname);
	     JButton btn= new JButton("update");
	     btn.setBounds(70,90,100,30);
	     add(btn);
	     btn.addActionListener(new ActionListener(){
				public void actionPerformed(ActionEvent a){
					newName=newname.getText();
					SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
	                
	                int check=SqlDatabaseConnection_obj.UpdateCarName(oldCarName,newName);
	                 if(check == 1){
	                	 JOptionPane.showMessageDialog(new customer_dashboard(),"Successfully Updated");
	                      dispose();
	                      new ViewCars(); 
	                      }
	              } 
				}
				);
	}
	
	public void actionPerformed(ActionEvent ae){
	}
}


//------------------------------------ to see the current bookings in the system
class ViewBooking extends JFrame implements ActionListener{
   
	ViewBooking(){
		
	    SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
	
		DefaultTableModel dtm = new DefaultTableModel();
		
    	String	Bookinglist[][]=SqlDatabaseConnection_obj.Bookings();
		
			   String column[]= {"Customer Id","Car Name", "Status"};
			    JTable data=new JTable(Bookinglist,column);    
			    data.setBounds(30,40,200,300);          
			    JScrollPane sp=new JScrollPane(data);    
			    add(sp);     
			    
	           String option[]= {"RESERVED","RENTED","RETURNED","CANCELED"};
	
	           JComboBox optionBox = new JComboBox<String>(option);
	           optionBox.addActionListener(new ActionListener() {
	        	   public void actionPerformed(ActionEvent ae) {
	        		   
	        		   String new_status=(String)optionBox.getSelectedItem();
	        		int row = data.getSelectedRow();


	        		if (row >= 0) {
	        		String c_id = data.getModel().getValueAt(row, 0).toString();
	        		String cname = data.getModel().getValueAt(row, 1).toString();
	        		
	        		SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
	     
	                int check=SqlDatabaseConnection_obj.UpdateCarStatus(Integer.parseInt(c_id),cname,new_status);
	                 if(check == 1){
	                	 JOptionPane.showMessageDialog(new customer_dashboard(),"Successfully Updated");
	                      dispose();
	                      
	                      }
	        		}
	        		    
	        	   }
	           });
	           
		    TableColumn col= data.getColumnModel().getColumn(2);
		    col.setCellEditor(new DefaultCellEditor(optionBox));
		    
		    
			for(String val[] : Bookinglist) {
				for(String value : val) {
					System.out.print(value+" ");
				}		   
			}
			
	
			setSize(600,800);
			setVisible(true);

		}
		
	public void actionPerformed(ActionEvent ae){
	}
}


//------------------------------------------------------------signup window---------------------------------------------------------------------------------
class signup_window extends JFrame implements ActionListener{

	 JTextField First_name,Last_name,nic_number,email_id,phone_number,amount,picture;
	 String new_password;
	 int new_id;
	 JLabel email_message,number_message,money_message,nic_message,one,two,three,four,five,six;
	 JPasswordField user_pass;
	signup_window(String window_name){
	   setSize(1370,1200);
	   setVisible(true);
	   setLayout(null);
	   setContentPane(new JLabel(new ImageIcon("background.jpg")));

	   JLabel create_account= new JLabel("CREATE AN ACCOUNT");
	   create_account.setBounds(300,50,500,50);
	   create_account.setFont(new Font("TimesRoman", Font.BOLD, 40));
	   create_account.setForeground(Color.BLUE);
	   add(create_account);

	   one= new JLabel("First Name");
	   one.setBounds(300,110,300,20);
	   one.setFont(new Font("TimesRoman", Font.BOLD, 15));
	   one.setForeground(Color.BLUE);
	   add(one);

	   First_name = new JTextField("First Name");
	   First_name.setBounds(300,130,300,30);
	   add(First_name);

	   two= new JLabel("Last Name");
	   two.setBounds(300,160,300,20);
	   two.setForeground(Color.BLUE);
	   two.setFont(new Font("TimesRoman", Font.BOLD, 15));
	   add(two);

	   Last_name = new JTextField("Last Name");
	   Last_name.setBounds(300,180,300,30);
	   add(Last_name);

	   three= new JLabel("Email ID");
	   three.setBounds(300,210,300,20);
	   three.setForeground(Color.BLUE);
	   three.setFont(new Font("TimesRoman", Font.BOLD, 15));
	   add(three);

	   email_id = new JTextField("Email ID");
	   email_id.setBounds(300,230,300,30);
	   add(email_id);

	    email_message = new JLabel();
		email_message.setBounds(610,230,300,30);
		email_message.setForeground(Color.RED);
		add(email_message);

	   four= new JLabel("NIC Numbers");
	   four.setBounds(300,260,300,20);
	   four.setForeground(Color.BLUE);
	   four.setFont(new Font("TimesRoman", Font.BOLD, 15));
	   add(four);

	   nic_number = new JTextField("NIC Numbers");
	   nic_number.setBounds(300,280,300,30);
	   add(nic_number);

		 nic_message= new JLabel();
		 nic_message.setBounds(610,280,300,30);
		 nic_message.setForeground(Color.RED);
		 add(nic_message);

	   five= new JLabel("Phone Number");
	   five.setBounds(300,310,300,20);
	   five.setForeground(Color.BLUE);
	   five.setFont(new Font("TimesRoman", Font.BOLD, 15));
	   add(five);

      phone_number= new JTextField("Phone Number");
      phone_number.setBounds(300,330,300,30);
      add(phone_number);

			 number_message= new JLabel();
			 number_message.setBounds(610,330,300,30);
			 number_message.setForeground(Color.RED);
			 add(number_message);

		six= new JLabel("Password");
	   six.setBounds(300,360,300,20);
	   six.setForeground(Color.BLUE);
	   six.setFont(new Font("TimesRoman", Font.BOLD, 15));
	   add(six);

	   user_pass = new JPasswordField("Password");
	   user_pass.setBounds(300,380,300,30);
	   add(user_pass);

		 money_message= new JLabel();
		 money_message.setBounds(610,380,300,30);
		 money_message.setForeground(Color.RED);
		 add(money_message);

      
       JButton register_done = new JButton("Register");
       register_done.setBounds(300,480,150,30);
	    add(register_done);
		register_done.addActionListener(this);
	 }


	 public void actionPerformed(ActionEvent ae){
		 int find;
		 JButton btn = (JButton)ae.getSource();

		 switch(btn.getText()){
		 case "Register":
		                                                  											
			 SqlDatabaseConnection SqlDatabaseConnection_obj = new SqlDatabaseConnection();
		                                                  
		
//1st try
		try{                                                  
           if(First_name.getText().equals("First Name") || Last_name.getText().equals("Last Name")|| email_id.getText().equals("Email ID") ||
						 nic_number.getText().equals("Nic Numbers")|| new String(user_pass.getPassword()).equals("Password")||
						  phone_number.getText().equals("Phone Numbers")){

        	   		JOptionPane.showMessageDialog(this,"All fields must be filled");
			}
       else{
			   String data[]=email_id.getText().toLowerCase().split("@");
			   int  l = data.length;


				 if(l > 0 && l <= 2 ){
			   if(l==2){
			   if(data[1].equals("gmail.com")){
						email_message.setText("");

				    // code for email extension

//2nd try
try{
		 		double nic_int_val=Double.parseDouble(nic_number.getText());
				String nic_str_val=nic_number.getText();

							nic_message.setText("");
//3rd try						
try{
					
	               double phone_number_int_val=Double.parseDouble(phone_number.getText());
				
					number_message.setText("");
                	new_id=SqlDatabaseConnection_obj.ID_assigner();
					
						find= SqlDatabaseConnection_obj.data_saver(First_name.getText(),Last_name.getText(),email_id.getText(),nic_number.getText(),
								new_id,new String(user_pass.getPassword()),phone_number.getText());
						
						if(find>=0){
			                 // when registration is done
							JOptionPane.showMessageDialog(this,"Successfully Registered","Alert",JOptionPane.WARNING_MESSAGE);
							// assign customer id to user 
							JOptionPane.showMessageDialog(this,"Your Id is "+find+"","Alert",JOptionPane.WARNING_MESSAGE);
	                      
	                      
	                    		  this.dispose();
	                    		  new welcome_window("Welcome");
	                    		  
						}else if(find==-1)
							JOptionPane.showMessageDialog(this,"ERROR! Try again","Alert",JOptionPane.WARNING_MESSAGE);

	}catch(NumberFormatException e){
			number_message.setText("Hint: 09007860100");
	}


  }catch(NumberFormatException e){
		 		nic_message.setText("Hint (451051521)");
		 	}

			   }else{
		    	email_message.setText("@gmail.com");// messages for valid input
			   }
			   }else{
		    	email_message.setText("@gmail.com");
		   }

	   }else if (l >2){
		   email_message.setText("Enter a valid email address");
	     }
		else{
			 email_message.setText("Enter your email address");

		   }
	    }

	}
		 catch(Exception ex){
			 ex.printStackTrace();
			 JOptionPane.showMessageDialog(this,"Give UseFull Inputs");

			}

		}
	}

}

//------------------------------------------------------------- Customer profile_window-------------------------------------------------
class ProfileWindow extends JFrame implements ActionListener {
	String First_name,Last_name, user_id , user_password , user_email_id, user_nic,user_Contact_no;
	String data_collector[];
	ProfileWindow(String data_collector[]){
		this.data_collector=data_collector;
		this.user_id=data_collector[0];
		 this.First_name= data_collector[1];
		 this.Last_name= data_collector[2];
		 this.user_email_id= data_collector[3];
		 this.user_nic= data_collector[4];
		 this.user_Contact_no=data_collector[5];
		 this.user_password= data_collector[6];

		 setSize(700,700);
		 setVisible(true);
		 setLayout(null);
		 setContentPane(new JLabel(new ImageIcon("background.jpg")));
		 
			 JLabel user_pic = new JLabel();
			 user_pic.setBounds(20,30,100,100);
			 user_pic.setIcon(new ImageIcon(("user.jpg")));
			 add(user_pic);	
			 
			JLabel fname = new JLabel(First_name);
			fname.setBounds(140,30,150,30);
			fname.setFont(new Font("TimesRoman", Font.BOLD, 25));
			fname.setForeground(Color.BLACK);
			add(fname);
			
			JLabel lname = new JLabel(Last_name);
			lname.setBounds(140,60,150,30);
			lname.setFont(new Font("TimesRoman", Font.BOLD, 25));
			lname.setForeground(Color.BLACK);
			add(lname);
			
			
			JLabel id = new JLabel(user_id);
			id.setBounds(140,90,200,30);
			id.setFont(new Font("TimesRoman", Font.BOLD, 25));
			id.setForeground(Color.BLACK);
			add(id);
			
			JLabel email = new JLabel(user_email_id);
			email.setBounds(140,110,350,30);
			email.setFont(new Font("TimesRoman", Font.BOLD, 25));
			email.setForeground(Color.BLACK);
			add(email);
			
			JLabel nic = new JLabel("NIC:");
			nic.setBounds(30,210,90,30);
			nic.setFont(new Font("TimesRoman", Font.BOLD, 20));
			nic.setForeground(Color.BLACK);
			add(nic);
			
			JLabel nic_num = new JLabel(user_nic);
			nic_num.setBounds(120,210,200,30);
			nic_num.setFont(new Font("TimesRoman", Font.BOLD, 20));
			nic_num.setForeground(Color.BLUE);
			add(nic_num);
			
			JLabel Contact= new JLabel("Number:");
			Contact.setBounds(30,240,90,30);
			Contact.setFont(new Font("TimesRoman", Font.BOLD, 20));
			Contact.setForeground(Color.BLACK);
			add(Contact);
			
			JLabel Contact_num= new JLabel(user_Contact_no);
			Contact_num.setBounds(120,240,250,30);
			Contact_num.setFont(new Font("TimesRoman", Font.BOLD, 20));
			Contact_num.setForeground(Color.BLUE);
			add(Contact_num);
			
			JButton update_profile = new JButton("Update Profile");
			update_profile.setBounds(500,10,150,30);
			add(update_profile);
			update_profile.addActionListener(this);
	
	}
	 public void actionPerformed(ActionEvent ae){
	  	 try{
	  		ProfileSetting ProfileSetting_obj = new ProfileSetting(this.data_collector);
		 }
			 catch(Exception e){
				 System.out.println("Error in user profile");
				 	e.printStackTrace();
			 }
	 }
}
//---------------------------------------------------------customer dashboard----------------------------------------------------------------
class customer_dashboard  extends JFrame implements ActionListener {
	  
		JPopupMenu popupmenu,popupmenu1,popupmenu2;

		JProgressBar Refresh_Bar;

		JMenuItem ChangePassword,Profile,SeeCarHistory;
		JButton LogOut;
        String user_id;
		customer_dashboard(String[] data_collector){
	

			 setSize(1370,1200);
			 setVisible(true);
			 setLayout(null);
			 setContentPane(new JLabel(new ImageIcon("background.jpg")));
			 this.user_id=data_collector[0];
			 JLabel dashboard = new JLabel("DASHBOARD");
			 dashboard.setBounds(20,20,300,50);
			 add(dashboard);
			 dashboard.setFont(new Font("TimesRoman", Font.BOLD, 40));
			 dashboard.setForeground(Color.ORANGE);
			 
			 JLabel stocks = new JLabel("CAR STOCKS");
			 stocks.setBounds(40,100,200,40);
			 add(stocks);
			 stocks.setFont(new Font("TimesRoman", Font.BOLD, 25));
			 stocks.setForeground(Color.ORANGE);
			 
			    DefaultListModel<String> carStocks = new DefaultListModel<>(); 
			    
			    SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
				
				ArrayList<String> clist=new ArrayList<String>();
				clist=SqlDatabaseConnection_obj.getCarStocks();
				
				if(clist.size()==0) {
					carStocks.addElement("You have still not rented any car");	
					
				}else {
					
					for(String item: clist) {
						
						carStocks.addElement(item);			
					}
		          }
			   
			    final JList<String> Carlist = new JList<>(carStocks);  
			    Carlist.setFont(new Font("TimesRoman", Font.BOLD, 15));
			    Carlist.setBackground(Color.BLACK);
			    Carlist.setForeground(Color.WHITE);
			    Carlist.setBounds(40,150,300,500); 
			    add(Carlist);
			    
			    JLabel instruction = new JLabel("SELECT A CAR AND THEN CLICK RESERVE");
			    instruction.setBounds(40,660,360,40);
			    add(instruction); 
			    instruction.setForeground(Color.BLUE);
			    instruction.setFont(new Font("TimesRoman", Font.BOLD, 15));
			    
			    JButton ReserveCar = new JButton("Reserve");
			    ReserveCar.setBounds(400,660,100,40);
			    add(ReserveCar);
			   
			    ReserveCar.addActionListener(
			    new ActionListener() {  		              
			    	public void actionPerformed(ActionEvent e) {   
		                 if (Carlist.getSelectedIndex() != -1) {                       
		                    String CarName = Carlist.getSelectedValue();  
		                    SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
		                    boolean check=SqlDatabaseConnection_obj.ReserveCar(user_id,CarName);
		                    if(check == true)
		                    	 JOptionPane.showMessageDialog(new customer_dashboard(),"Successfully Reserved");
		                          dispose();
		                          new customer_dashboard(data_collector); 
		                 } } });
			   
			JMenu setting = new JMenu("Options");
			JMenuBar menu_bar = new JMenuBar();
			Profile= new JMenuItem("Profile");
			ChangePassword= new JMenuItem("Change Password");
			SeeCarHistory= new JMenuItem("Rented Car Histroy");
			
			setting.addActionListener(this);
			setting.add(Profile);
		    setting.add(ChangePassword);
		    setting.add(SeeCarHistory);
			
			
			ChangePassword.addActionListener(new ActionListener(){
				public void actionPerformed(ActionEvent a){
					password_setting password_setting_obj = new password_setting(user_id);
				}
				});
			

			SeeCarHistory.addActionListener(new ActionListener(){
				public void actionPerformed(ActionEvent a){
					CarHistoryWindow CarHistoryWindow_obj = new CarHistoryWindow(user_id);
				}
				});
			
			Profile.addActionListener(new ActionListener(){
				public void actionPerformed(ActionEvent a){
					ProfileWindow ProfileWindow_obj = new ProfileWindow(data_collector);
				}
				});
			
			//	LogOut.addActionListener(this);
		    LogOut = new JButton("LogOut");
		    LogOut.setBounds(1200,10,100,50);
		    add(LogOut);
		    
			LogOut.addActionListener(new ActionListener(){
				public void actionPerformed(ActionEvent a){
					dispose();
					welcome_window obj = new welcome_window("WELCOME");
					
				}
				});
			menu_bar.add(setting);
			setJMenuBar(menu_bar);
			
	 }
		customer_dashboard(){
			
			
		}
	 public void actionPerformed(ActionEvent ae){
	  
        }
	 }
// -----------------------------------------------------------customer profile setting---------------------------------------------------------
class ProfileSetting extends JFrame implements ActionListener{
	
	 String First_name,Last_name,user_email_id,user_Contact_no,user_id;
	 JTextField Change_fname,Change_lname,Change_contact,Change_email;
	 ProfileSetting(String data_collector[]){
		 super(" Profile Setting");
		 setSize(800,600);
		 setVisible(true);
		 setLayout(null);
		 setContentPane(new JLabel(new ImageIcon("background.jpg")));
		 this.First_name= data_collector[1];
		 this.Last_name= data_collector[2];
		 this.user_email_id= data_collector[3];
		 this.user_Contact_no=data_collector[5];
		 this.user_id= data_collector[0];
		
		 // use combo box for different themes
		 JLabel fname = new JLabel("First name");
		 fname.setBounds(140,110,150,30);
		 fname.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 fname.setForeground(Color.BLACK);
		 add(fname);
		 
		 Change_fname = new JTextField(First_name);
		 Change_fname.setBounds(300,110,150,30);
		 add(Change_fname);
		 
		 JLabel lname = new JLabel("Last name");
		 lname.setBounds(140,150,150,30);
		 lname.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 lname.setForeground(Color.BLACK);
		 add(lname);
		 
		  Change_lname = new JTextField(Last_name);
		 Change_lname.setBounds(300,150,150,30);
		 add(Change_lname);
		 
		 JLabel email = new JLabel("Email id");
		 email.setBounds(140,190,350,30);
		 email.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 email.setForeground(Color.BLACK);
		 add(email);
		 
		 Change_email= new JTextField(user_email_id);
		 Change_email.setBounds(300,190,150,30);
		 add(Change_email);
		 
		 JLabel Contact= new JLabel("Contact Number");
		 Contact.setBounds(140,230,150,30);
		 Contact.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 Contact.setForeground(Color.BLACK);
		 add(Contact);
		 
		 Change_contact = new JTextField(user_Contact_no);
		 Change_contact.setBounds(300,230,150,30);
		 add(Change_contact);
		 
		 JButton Confrim = new JButton("Confrim Chnages");
		 Confrim.setBounds(200,290,150,30);
         add(Confrim);
         Confrim.addActionListener(this);
	 }
	 
	
	 public void actionPerformed(ActionEvent ae){
		 
		 if(Change_fname.getText().equals("") || Change_lname.getText().equals("")|| Change_email.getText().equals("") ||
				  Change_contact.getText().equals("")) {
			 JOptionPane.showMessageDialog(this,"You can not leave any field empty");
			 
		 }else {
			 password_changer password_changer_obj = new password_changer();
			 
			 boolean check = password_changer_obj.update_my_data(this.Change_fname.getText(),this.Change_lname.getText(),this.Change_email.getText(),this.Change_contact.getText(),user_id);
			 if(check == true) {
				 JOptionPane.showMessageDialog(this,"Updated Sucessfully");
			     this.dispose();
			 }else {
				 JOptionPane.showMessageDialog(this,"System Error");				 
			 }
		 } 
	 
	 }

}
// ------------------------car histroy of customer----------------------------
class CarHistoryWindow extends JFrame implements ActionListener{

	CarHistoryWindow(String user_id){
		super("Rented car histroy");
		setSize(500,500);
		 setVisible(true);
		 setLayout(null);
		 
		 JLabel carhistroy = new JLabel("Your Rented Car Histroy");
		 carhistroy.setBounds(40,20,400,40);
		 add(carhistroy);
		 carhistroy.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 carhistroy.setForeground(Color.ORANGE);
		 
		    DefaultListModel<String> carhistroyStocks = new DefaultListModel<>(); 
		    
		    SqlDatabaseConnection SqlDatabaseConnection_obj= new SqlDatabaseConnection();
			
			ArrayList<String> clist=new ArrayList<String>();
			clist=SqlDatabaseConnection_obj.getCarHistory(user_id);
			
			if(clist.size()==0) {
				carhistroyStocks.addElement("You have still not rented any car");	
				
			}else {
			
			for(String item: clist) {
				carhistroyStocks.addElement(item);			
			 }
			}
		    final JList<String> Carlist = new JList<>(carhistroyStocks);  
		    Carlist.setFont(new Font("TimesRoman", Font.BOLD, 15));
		    Carlist.setBackground(Color.WHITE);
		    Carlist.setForeground(Color.BLACK);
		    Carlist.setBounds(40,60,400,400); 
		    add(Carlist);
		    
		
	}
	 public void actionPerformed(ActionEvent ae){
	 
	 
	 }
	
}
//---------------------------password setting-------------------------------------------------------
class password_setting extends JFrame implements ActionListener{
 String User_id;
	JLabel password_message,old_pass_message;
	JPasswordField oldpassword,newpassword,repeatpassword;
	password_setting(String Userid){
		 super("password setting");
		 setSize(500,500);
		 setVisible(true);
		 setLayout(null);
		 this.User_id=Userid;
		 setContentPane(new JLabel(new ImageIcon("background.jpg")));

		 JLabel oldpass = new JLabel("old Password");
		 oldpass.setBounds(20,20,100,30);
		 add(oldpass);

		 oldpassword = new JPasswordField(null);
		 oldpassword.setBounds(130,20,150,30);
		 add(oldpassword);

		 old_pass_message= new JLabel();
		 old_pass_message.setBounds(290,20,200,30);
		 old_pass_message.setForeground(Color.RED);
		 add(old_pass_message);

		 JLabel newpass = new JLabel("new Password");
		 newpass.setBounds(20,60,100,30);
		 add(newpass);

		 newpassword = new JPasswordField(null);
		 newpassword.setBounds(130,60,150,30);
		 add(newpassword);

		 JLabel repeatpass = new JLabel("repeat Password");
		 repeatpass.setBounds(20,100,100,30);
		 add(repeatpass);

		 repeatpassword = new JPasswordField(null);
		 repeatpassword.setBounds(130,100,150,30);
		 add(repeatpassword);

		 password_message= new JLabel();
		 password_message.setBounds(290,100,200,30);
		 password_message.setForeground(Color.RED);
		 add(password_message);

		 JButton Confrim = new JButton("Confrim");
		 Confrim.setBounds(20,140,100,30);
		 Confrim.addActionListener(this);
		 add(Confrim);

	 }

	 public void actionPerformed(ActionEvent ae){

		 JButton btn=(JButton)ae.getSource();

		  password_changer password_changer_obj= new password_changer();

		 SqlDatabaseConnection  SqlDatabaseConnection_obj= new SqlDatabaseConnection();

		 switch(btn.getText()){
			 case"Confrim":

			 int check = SqlDatabaseConnection_obj.checker(this.User_id,new String(this.oldpassword.getPassword()));

			 if(check==1){

				 String p1=new String(this.newpassword.getPassword()),p2=new String(this.repeatpassword.getPassword());
				 String x1=String.valueOf(p1),x2=String.valueOf(p2);
				
				 old_pass_message.setText("");
				  if(x1.length()==0 || x2.length()==0){
						JOptionPane.showMessageDialog(this,"Enter new  password");
				 }

				 else if(x1.equals(x2)){

					boolean is_change=password_changer_obj.change_my_password(this.User_id,new String(this.newpassword.getPassword()));

					if(is_change){
						password_message.setText("");
						JOptionPane.showMessageDialog(this,"Password Changes Successfully","Alert",JOptionPane.WARNING_MESSAGE);
						this.dispose();

					}else{
						JOptionPane.showMessageDialog(this,"system issue occurs");
					}
				 }
				 else{
						password_message.setText("Didn't Match, Try Again");
				 }
			}else if(check == -1){

				 old_pass_message.setText("old password is incorrect");
			 }
			 else
				  JOptionPane.showMessageDialog(this,"id not found");
			 break;
		 }
	 }
}

