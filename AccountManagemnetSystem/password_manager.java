import java.util.Random;
public class password_manager{
	
	public String password_assigner(){
		Random rand = new Random();
		int pass = rand.nextInt()*10;
		
		if(pass<0){
			pass =(-1*pass);
           
		}return ""+pass;
	}

	
}