using System; 
          
public class GFG { 
      
    // Method that return count of the given 
    // character in the string 
    public static int count(string s, char c) 
    { 
        int res = 0; 
  
        for (int i = 0; i < s.Length; i++) 
        { 
              
            // checking character in string 
            if (s[i] == c) 
            res++; 
        }  
          
        return res; 
    } 
      
    // Driver method 
    public static void Main() 
    { 
        string str = "helloworld"; 
        char c = 'l'; 
          
        Console.WriteLine(count(str, c)); 
    } 
} 