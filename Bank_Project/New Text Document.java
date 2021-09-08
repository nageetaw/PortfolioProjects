import java.util.Scanner;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
//import Bank_Project.information;
class Bank{
	public static void main(String args[]){
		welcome_window obj = new welcome_window("WELCOME");	
	   
	}
}

class welcome_window extends JFrame implements ActionListener{
	JTextField user_id, user_password;
	welcome_window(String window_name){
		super(window_name);
	    setSize(1370,1200);
        setVisible(true);
		setContentPane(new JLabel(new ImageIcon("blue-background-200533.jpg ")));
		setLayout(null);
		
        JLabel bank_name = new JLabel("JAI SAMADHA");
		bank_name.setBounds(10,10,400,80);
		bank_name.setFont(new Font("TimesRoman", Font.BOLD, 50));
		bank_name.setForeground(Color.WHITE);
        add(bank_name);		
		
		JLabel login_id = new JLabel("Account number");
		login_id.setBounds(30,120,150,40);
		login_id.setFont(new Font("TimesRoman", Font.BOLD, 20));
		login_id.setForeground(Color.WHITE);
		add(login_id);
		
		JTextField id = new JTextField(null);
        id.setBounds(30,170,300,30);
        add(id);		
		
		JLabel password_label = new JLabel("Password");
		password_label.setBounds(30,200,100,40);
		password_label.setFont(new Font("TimesRoman", Font.BOLD, 20));
		password_label.setForeground(Color.WHITE);
		add(password_label);
		
		JTextField password = new JTextField(null);
		password.setBounds(30,240,300,30);
		add(password);
		
		JButton login =new JButton("Login");
		login.setBounds(30,290,100,30);
		add(login);
		login.addActionListener(new welcome_window(id,password));
		
		JButton register = new JButton("Create Account");
		register.setBounds(150,290,150,30);
		add(register);	
        register.addActionListener(new welcome_window(id,password));		
		
	}
	welcome_window(JTextField id, JTextField password){
		user_id=id;
		user_password=password;
		
	}
	welcome_window(){
		
		
	}
	String[] data_collector = new String[6];
	 
	public void actionPerformed(ActionEvent ae){
		profile_window profile_obj;
	    information obj_info = new information();
		JButton btn= (JButton)ae.getSource();
		switch(btn.getText()){
			case "Login":	  
			  if(this.user_id.getText()== null){
				System.out.println("in color code");
			  }
				 else{
					 
              int result = obj_info.checker(user_id.getText(),user_password.getText());
			  
			  if(result==1){
				  
				  obj_info.data_sender(data_collector);
				                              // to show user details on console.
				  for(String value : data_collector)
					  System.out.println(value);
				  
			  profile_obj = new profile_window(data_collector);
			  
			  }
		      else if(result == 0)
				  user_id.setForeground(Color.RED);
			  else
				  user_password.setForeground(Color.RED);
			  }
			  
			break;
			case "Create Account":
			Registration_window register_object = new Registration_window("Registration");
			break;		
			
		}
				
	}
	
}


//----------------------------------------------------register--------------------------------------------------------------------------


 class Registration_window extends JFrame implements ActionListener{
	 Registration_window(String window_name){
		 super(window_name);
	   setSize(1370,1200);
	   setVisible(true);
	   setLayout(null);	 
	   setContentPane(new JLabel(new ImageIcon("register.jpg"))); 
	   
	   JLabel create_account= new JLabel("CREATE AN ACCOUNT");
	   create_account.setBounds(300,50,500,50);
	   create_account.setFont(new Font("TimesRoman", Font.BOLD, 40));
	   create_account.setForeground(Color.WHITE);
	   add(create_account);
	   
	   JTextField user_name = new JTextField("Name");
	   user_name.setBounds(300,110,300,30);
	   add(user_name);
	   
	   JTextField email_id = new JTextField("Email ID");
	   email_id.setBounds(300,170,300,30);
	   add(email_id);	   
	   
	   JTextField nic_number = new JTextField("NIC Numbers");
	   nic_number.setBounds(300,230,300,30);
	   add(nic_number);		   
	   
	   JTextField amount = new JTextField("Amount in Rupee");
	   amount.setBounds(300,290,300,30);
	   add(amount);	

      JButton register_done = new JButton("Register");
       register_done.setBounds(300,350,150,30); 
	    add(register_done);
		register_done.addActionListener(new Registration_window(user_name,email_id,nic_number,amount));
	 }
	 
	 JTextField user_name,email_id,nic_number,amount;
	 
	 Registration_window(JTextField user_name,JTextField email_id,JTextField nic_number,JTextField amount){
		 this.user_name=user_name;
		 this.email_id= email_id;
		 this.nic_number=nic_number;
		 this.amount=amount;
	 }
	 public void actionPerformed(ActionEvent ae){
		 JButton btn = (JButton)ae.getSource();
		 		 warning warning_obj;
		 switch(btn.getText()){
		 case "Register":
		                                                  // work
														  // to save data
		 data_handler data_obj = new data_handler();
		                                                  // to assign new id
		 id_manager manager_obj = new id_manager();	 
		String new_id = manager_obj.id_assigner();
		                                                  // to assign new password
		 password_manager password_obj= new password_manager();
		 String new_password = password_obj.password_assigner();
		                                                    // to save data of new customer
            if(user_name.getText().equals("Name")|| email_id.getText().equals("Email ID") || nic_number.getText().equals("NIC Numbers") || amount.getText().equals("Amount in Rupee")){
				warning_obj = new warning("All fields must be filled");
			} 
           else{
				if(Integer.parseInt(amount.getText())>=2000){	
              				
		int find= data_obj.data_saver(user_name.getText(),email_id.getText(),nic_number.getText(),amount.getText(),new_id, new_password);
		 if(find==1){ 
		                 // when registration is done
		 account account_obj= new account("Registered");
		 }
		 else
			 System.out.println("value of find" + find);

		 break;
		 
		 }
		 else if(Integer.parseInt(amount.getText())<0)
			 warning_obj = new warning("Amount should be positive");
		 else
           warning_obj= new warning("Amount should be greater than or equal to 2000");
	 
	 }
		 }
	 }
	 
 }
 
 //------------------------------------------------------------------account---------------------------------------------------------
  class account extends JFrame{
	  account(String name){
	      super(name);
	       setSize(500,500);
	       setVisible(true);
		   setContentPane(new JLabel(new ImageIcon("DSC100591180.jpg")));
		   setLayout(null);
		   JLabel label = new JLabel();
		   label.setBounds(10,10,200,200);
		   label.setIcon(new ImageIcon("729479-200.png"));
		   add(label);
		   //profile_window obj = new profile_window("open");
		   
	  }
	  
  }
 
 
 
 //-------------------------------------------------------------profile_window-------------------------------------------------
 
 class profile_window extends JFrame implements ActionListener {
	 profile_window(String[] data_collector){
		 String user_name, user_id , user_password , user_email_id, user_amount, user_nic;
		 user_id=data_collector[0];
		 user_password= data_collector[1];
		 user_amount=data_collector[2];
		 user_name= data_collector[3];
		 user_email_id= data_collector[4];
		 user_nic= data_collector[5];
		 
	 setSize(1370,1200);
	 setVisible(true);
	 setLayout(null);
	 setContentPane(new JLabel(new ImageIcon("330021.jpg")));
 	 
	 JButton withdraw = new JButton();
	 withdraw.setBounds(1200,300,100,100);
	 withdraw.setIcon(new ImageIcon("Capture3.JPG"));
	 add(withdraw);
	 
	 JButton deposit = new JButton();
	 deposit.setBounds(1200,560,100,100);
	 deposit.setIcon(new ImageIcon("Capture2.JPG"));
	 add(deposit);
	 
	 JButton transfer = new JButton();
	 transfer.setBounds(1200,430,100,100);
	 transfer.setIcon(new ImageIcon("Capture1.JPG"));
	 add(transfer); 
	 
	 JLabel user_picture = new JLabel(new ImageIcon("user.JPG"));
	 user_picture.setBounds(20,30,100,100);
	 add(user_picture);
	 
	 JLabel name = new JLabel(user_name);
	 name.setBounds(130,30,200,30);
	 name.setFont(new Font("TimesRoman", Font.BOLD, 25));
	 add(name);
	 
	 JLabel id = new JLabel(user_id);
	 id.setBounds(130,70,200,30);
	 id.setFont(new Font("TimesRoman", Font.BOLD, 25));
	 add(id);
	 
	 String[] list= new String[]{"setting","password","logout"};
	 JList setting = new JList(list);
	 setting.setBounds(1300,10,50,50);
	 add(setting);
	 
	 
	 
	 
	 }
	 public void actionPerformed(ActionEvent ae){
	  	 
		 
	 }
 }
 
 
 
 //----------------------------------------------Timer-------------------------------------------------------------
 class timer extends Thread{
	 public void run(){
		 try{
			 
			 
		 }catch(Exception e){
			 
		 }
	 }
	 
 }
 
 
 
 //------------------------------------------------warning window----------------------------------------------
 class warning extends JFrame{
	 warning(String message){
		 super("Warrning");
		 setSize(450,200);
		 setVisible(true);
		 setLayout(null);
		 JLabel logo = new JLabel();
		 logo.setBounds(10,10,90,50);
		 logo.setIcon(new ImageIcon("Capture.JPG"));
		 add(logo);
		 JLabel warn = new JLabel(message);
		 warn.setBounds(110,50,300,30);
		 add(warn);
	 }
	 
	 
 }
 
 
 
 
 
 
 
 
 
 
 
 
 
























