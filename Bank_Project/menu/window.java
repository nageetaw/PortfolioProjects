package menu;
import javax.swing.*;
import java.awt.event.*;
public class window extends JFrame{
   public window(String name){
        super(name);
        setSize(500,500);
        setVisible(true);
        setLayout(null);
       setDefaultCloseOperation(EXIT_ON_CLOSE);
      JButton btn1 = new JButton("menu");
     btn1.setBounds(10,10,450,40);
     add(btn1);

     JTextField no= new JTextField("0");
   no.setBounds(170,310,150,40);
    add(no);

     JButton btn= new JButton("Dishes");
    btn.setBounds(100,60,300,40);
    add(btn);

    JButton btn2= new JButton("Pizza");
    btn2.setBounds(100,110,100,40);
    add(btn2);
    btn2.addActionListener(new myListener(no));

    JButton btn3= new JButton("Burger");
    btn3.setBounds(100,160,100,40);
    add(btn3);
    btn3.addActionListener(new myListener(no));

    JButton btn4= new JButton("Wings");
    btn4.setBounds(100,210,100,40);
    add(btn4);
    btn4.addActionListener(new myListener(no));

    JButton btn5= new JButton("Fries");
    btn5.setBounds(300,110,100,40);
    add(btn5);
    btn5.addActionListener(new myListener(no));

    JButton btn7= new JButton("Colddrink");
    btn7.setBounds(300,160,100,40);
    add(btn7);
    btn7.addActionListener(new myListener(no));

    JButton btn8= new JButton("Tea");
    btn8.setBounds(300,210,100,40);
    add(btn8);
    btn8.addActionListener(new myListener(no));

      /*JButton btn9= new JButton("Add to Cart");
    btn9.setBounds(170,360,150,40);
    add(btn9);
    btn9.addActionListener(new myListener(no));*/

      JButton quantity= new JButton("Quantity");
   quantity.setBounds(170,260,150,40);
    add(quantity);
       }
   myListener v = new myListener();
     public String dish_selected(){
    return v.dish;

  }
   public String quantity(){
    return v.no.getText();
  }
}
 class myListener  implements ActionListener {
 JTextField no;
  String dish="";
  myListener(){}
  myListener(JTextField no){
    this.no=no;
   }
  public void actionPerformed(ActionEvent ae){
     JButton obj = (JButton)ae.getSource();
    switch(obj.getText()){
      case "Pizza":
      dish+="Pizza";
      break;
     case"Burger":
     dish+="Burger";
      break;
     case"Fries":
     dish+="Fries";
      break;
     case"Tea":
     dish+="Tea";
      break;
     case"Colddrink":
     dish+="Colddrink";
      break;
     case"Wings":
     dish+="Wings";
      break;
    }
   }      
}
