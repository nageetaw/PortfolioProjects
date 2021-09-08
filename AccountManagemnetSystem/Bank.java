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
		                                                  // work												  // to save data
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
		 account account_obj= new account("Registered" , new_id, new_password);
		 
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
	  account(String name,String new_id, String new_password){
	      super(name);
	       setSize(500,400);
	       setVisible(true);
		   setContentPane(new JLabel(new ImageIcon("Capture8.JPG")));
		   setLayout(null);
		   
		   JLabel id = new JLabel("Account number : ");
		   id.setBounds(50,200,250,30);
		   id.setFont(new Font("TimesRoman", Font.BOLD, 20));
		   add(id);
		   
		   JLabel ID = new JLabel(new_id);
		   ID.setBounds(250,200,200,30);
		   ID.setFont(new Font("TimesRoman", Font.BOLD, 20));
		   add(ID);
		   
		   JLabel password = new JLabel("password : ");
		   password.setBounds(50,250,250,30);
		   password.setFont(new Font("TimesRoman", Font.BOLD, 20));
		   add(password);
		   
		   JLabel PASSWORD = new JLabel(new_password);
		   PASSWORD.setBounds(200,250,200,30);
		   PASSWORD.setFont(new Font("TimesRoman", Font.BOLD, 20));
		   add(PASSWORD);
		   
		   
		   
		   
		   
		   
		   
		   //profile_window obj = new profile_window("open");
		   
	  }
	  
  }
 
 
 
 //-------------------------------------------------------------profile_window-------------------------------------------------
 
 class profile_window extends JFrame implements ActionListener {
	   String user_name, user_id , user_password , user_email_id, user_amount, user_nic;
	   
	 profile_window(String[] data_collector){
		 this.user_id=data_collector[0];
		 this.user_password= data_collector[1];
		 this.user_amount=data_collector[2];
		 this.user_name= data_collector[3];
		 this.user_email_id= data_collector[4];
		 this.user_nic= data_collector[5];
		 
	 setSize(1370,1200);
	 setVisible(true);
	 setLayout(null);
	 setContentPane(new JLabel(new ImageIcon("513404.jpg")));
 	 
	 JButton withdraw = new JButton("withdraw");
	 withdraw.setBounds(40,560,100,100);
	 withdraw.setIcon(new ImageIcon("Capture3.JPG"));
	 add(withdraw);
	 withdraw.addActionListener(new profile_window(data_collector[0],data_collector[2]));
	 
	 JButton deposit = new JButton("deposit");
	 deposit.setBounds(300,560,100,100);
	 deposit.setIcon(new ImageIcon("Capture2.JPG"));
	 add(deposit);
	 deposit.addActionListener(new profile_window(data_collector[0],data_collector[2]));
	 
	 JButton transfer = new JButton("transfer");
	 transfer.setBounds(170,560,100,100);
	 transfer.setIcon(new ImageIcon("Capture1.JPG"));
	 add(transfer); 
	 transfer.addActionListener(new profile_window(data_collector[0],data_collector[2]));
	 
	 JLabel user_picture = new JLabel(new ImageIcon("user.JPG"));
	 user_picture.setBounds(20,30,100,100);
	 add(user_picture);
	 
	 JLabel name = new JLabel(user_name);
	 name.setBounds(140,30,200,30);
	 name.setFont(new Font("TimesRoman", Font.BOLD, 25));
	 name.setForeground(Color.WHITE);
	 add(name);
	 
	 JLabel id = new JLabel(user_id);
	 id.setBounds(140,70,200,30);
	 id.setFont(new Font("TimesRoman", Font.BOLD, 25));
	 id.setForeground(Color.WHITE);
	 add(id);
	 
	 JLabel email = new JLabel(user_email_id);
	 email.setBounds(140,110,350,30);
	 email.setFont(new Font("TimesRoman", Font.BOLD, 25));
	 email.setForeground(Color.WHITE);
	 add(email);
	 	
	 JLabel amount = new JLabel("Amount:");
	 amount.setBounds(30,180,90,30);
	 amount.setFont(new Font("TimesRoman", Font.BOLD, 20));
	 amount.setForeground(Color.WHITE);
	 add(amount);
	 
	 JLabel total_amount = new JLabel(user_amount);
	 total_amount.setBounds(120,180,150,30);
	 total_amount.setFont(new Font("TimesRoman", Font.BOLD, 20));
	 total_amount.setForeground(Color.BLUE);
	 add(total_amount);
	 
	 JLabel nic = new JLabel("NIC:");
	 nic.setBounds(30,210,90,30);
	 nic.setFont(new Font("TimesRoman", Font.BOLD, 20));
	 nic.setForeground(Color.WHITE);
	 add(nic);
	 
	 JLabel nic_num = new JLabel(user_nic);
	 nic_num.setBounds(120,210,200,30);
	 nic_num.setFont(new Font("TimesRoman", Font.BOLD, 20));
	 nic_num.setForeground(Color.BLUE);
	 add(nic_num);
	/* String array[] = new String[]{"log out" , "personal info"};
	 JComboBox box = new JComboBox(array);
	 box.setBounds(1100,20,100,50);
	 add(box);
	 */}
	 profile_window(String id , String amount){
		 this.user_id=id;
		 this.user_amount=amount;
		 }
	 public void actionPerformed(ActionEvent ae){
	  	 JButton btn = (JButton)ae.getSource();
		 switch(btn.getText()){
		 case "withdraw":
		    System.out.println(user_amount +"----"+ user_id);
		        withdraw_detail withdraw_detail_obj = new withdraw_detail("WITHDRAW" , this.user_id, this.user_amount);                            
		 break;
		 
		 case"transfer":
		 transfer_detail transfer_detail_obj = new transfer_detail(this.user_id,this.user_amount);
		 break;
		 
		 case"deposit":            // user_id and user_amount both are string values.
		 deposit_detail deposit_detail_obj  = new deposit_detail(this.user_id, this.user_amount);
		 break;
		 }
	 }
 }
 
 
 
 
 
 
 
 
 //---------------------------------------------------class transfer detail------------------------------------------------------------------------
 class transfer_detail extends JFrame implements ActionListener{
	 transfer_detail(String id , String user_amount){
		 setSize(400,300);
		 setVisible(true);
		 setLayout(null);
		 setContentPane(new JLabel(new ImageIcon("Capture6.JPG")));
		 
		 JLabel account_number = new JLabel("Account number :");
		 account_number.setBounds(30,110,200,30);
		 account_number.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 add(account_number);
		 
		 JTextField account = new JTextField(null);
		 account.setBounds(220,110,100,30);
		 add(account);
		 
		 JLabel transfer_amount = new JLabel("Amount :");
		 transfer_amount.setBounds(30,150,150,30);
		 transfer_amount.setFont(new Font("TimesRoman", Font.BOLD, 20));
		 add(transfer_amount);
		 
		 JTextField amount = new JTextField(null);
		 amount.setBounds(220,150,100,30);
		 add(amount);
		 
		 JButton confrim = new JButton("Confrim");
		 confrim.setBounds(100,210,100,30);
		 add(confrim);
		 confrim.addActionListener(new transfer_detail(id ,user_amount,account,amount));
		 
	 }
	 String user_id,user_amount;
	 JTextField transfer_amount,other_account;
	 
	 transfer_detail(String id, String user_amount,JTextField account, JTextField amount){
		 this.user_id=id;
		 this.user_amount= user_amount;
		 this.other_account= account;
		 this.transfer_amount=amount;
	 }
	 public void actionPerformed(ActionEvent ae){
	  JButton btn=(JButton)ae.getSource(); 
         int user_integer_amount=Integer.parseInt(this.user_amount),transfer_integer_amount=Integer.parseInt(this.transfer_amount.getText());
	      warning warning_obj;
		  transfer_process transfer_process_obj= new transfer_process();
		 switch(btn.getText()){
			 case"Confrim":
			 if(transfer_integer_amount<0)
				 warning_obj= new warning("Amount should be positive");
			 else if(transfer_integer_amount==0)
				 warning_obj= new warning("Please insert some Amount");
			 else {
				 if(transfer_integer_amount>user_integer_amount)
					 warning_obj= new warning("Amount is greater than User's Current Amount");
				 else if(transfer_integer_amount== user_integer_amount)
					 warning_obj=new warning("This leave your Account with zero Balance");
				 else{
					 
					 // transfer process
					 transfer_process_obj.transfer_method(this.user_id,transfer_integer_amount, this.other_account.getText());
					 
				 }
				 
				 
			 }
			 
			 
			 
			 break;
		 }
		 
		 
	 }
	 
	
	 
	  
 }
 



 
 
 
 //-------------------------------------------------------------class deposit detail------------------------------------------------------------------
 class deposit_detail extends JFrame implements ActionListener{
	 int user_amount;
	 JTextField deposit_amount;
	 String user_id;
	 
	 deposit_detail(String id ,String amount){
		 super("DEPOSIT");
		setSize(300,300); 
		setVisible(true);
		setLayout(null);
		setContentPane(new JLabel(new ImageIcon("Capture4.JPG")));
		
		JLabel note = new JLabel("Amount in Rupee");
		note.setBounds(50,90,300,30);
		note.setFont(new Font("TimesRoman", Font.BOLD, 15));
		add(note);
		
		JTextField deposit_amount_field = new JTextField(null);	
        deposit_amount_field.setBounds(50,130,150,30);		
		add(deposit_amount_field);
		
		JButton confrim = new JButton("Confrim");
		confrim.setBounds(70,180,100,30);
		add(confrim);                                 // here id and amount are string values.
		confrim.addActionListener(new deposit_detail(deposit_amount_field,id,amount));
		 
	 }
	 
      deposit_detail(JTextField deposit_amount_field,String id , String amount ){
		 this.user_id=id;
          this.user_amount=Integer.parseInt(amount);
		  this.deposit_amount=deposit_amount_field;
		 
	 }
	 
	 
    public void actionPerformed(ActionEvent ae){
		JButton btn = (JButton)ae.getSource();
		warning warning_obj;
		deposit_process deposit_process_obj = new deposit_process();
		
		int deposit_money= Integer.parseInt(deposit_amount.getText());
		
		switch(btn.getText()){
			case "Confrim":
	          if(deposit_money<0)
                  warning_obj = new warning("Amount should be positive");		
			  
			  else if(deposit_money==0)
				  warning_obj= new warning("Insert some Amount");
			  
			  else if(deposit_money>user_amount)
				  warning_obj=new warning("Amount is greater than user Account");
			  
			  else{
				  
				    int message=deposit_process_obj.deposit_method(this.user_id , deposit_money);             
									//                      deposit process  
				     if(message==1)
						 System.out.println("Money is Successfull deposited");
					else
						System.out.println("Deposit eroor");
			  }
			break;
		
		}
		
		
		
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
		 setSize(430,180);
		 setVisible(true);
		 setLayout(null);
          setContentPane(new JLabel(new ImageIcon("Capture7.JPG")));
	
		 JLabel warn = new JLabel(message);
		 warn.setBounds(5,50,350,30);
		 add(warn);
	 }
	 
	 
 }
 
 
 
 
 
 //-------------------------------------------------------------------withdraw detail------------------------------------------------------------------
 class withdraw_detail extends JFrame implements ActionListener{
	   String user_id;
	   int user_amount;
	    JTextField withdraw_AMOUNT;
		
	   withdraw_detail(String name ,String user_id, String user_amount){
		 super(name);
		setSize(300,300); 
		setVisible(true);
		setLayout(null);
		setContentPane(new JLabel(new ImageIcon("Capture4.JPG")));
		
		JLabel note = new JLabel("Amount should be multiple of 500");
		note.setBounds(30,90,300,30);
		note.setFont(new Font("TimesRoman", Font.BOLD, 15));
		add(note);

        JTextField withdraw_amount = new JTextField(null);	
        withdraw_amount.setBounds(50,130,150,30);		
		add(withdraw_amount);
		
		JButton confrim = new JButton("Confrim");
		confrim.setBounds(70,180,100,30);
		add(confrim);
		confrim.addActionListener(new withdraw_detail(withdraw_amount,user_amount,user_id));	
	 }

	 
	 withdraw_detail(JTextField withdraw_amount,String amount ,String id){
		 this.user_id= id;
		 this.user_amount= Integer.parseInt(amount);
		 this.withdraw_AMOUNT= withdraw_amount;
	 }
	 
	 public void actionPerformed(ActionEvent ae){
		 
		 JButton btn = (JButton) ae.getSource();
		 
		 int deduct_amount = Integer.parseInt(withdraw_AMOUNT.getText());
		 
		 withdraw_process withdraw_process_obj = new withdraw_process();
		 
		 warning warning_obj;
		 
		 
		 switch(btn.getText()){
			 case "Confrim":
		         if(deduct_amount < user_amount && deduct_amount%500 ==0 && deduct_amount>0){
					 
			       int value = withdraw_process_obj.withdraw_method(user_id,deduct_amount);
			      
				    if(value==1)
                            System.out.println("Congratulations");	
                    else
                            System.out.println("Sorry"); 						
			         
			
				 }
               else if(deduct_amount<0)
                   warning_obj = new warning("Amount should be positive");
				   
			   else if(deduct_amount==0)
				   warning_obj= new warning("please insert some amount");
			   else
				   warning_obj= new warning("Amount Should be multiple of 500");
              break;			
			 
			 
		 }
		 
		 
		 
	 }
	 
 }
 
 
 
 














