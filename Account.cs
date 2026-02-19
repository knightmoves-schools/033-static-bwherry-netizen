namespace knightmoves;

public class Account {

   public static string Name = "Dave";

   public static string ChangeName (string newName) 
   {
       newName = "Jack";
      
       Name = newName;
      
       return Name;
   }  
}


