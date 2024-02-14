using System; 
   
   
class GFG { 
       
    // reference to underlying 2D array 
    int[, ] data = new int[5, 5]; 
       
       
    // declaring Multidimensional Indexer 
    public int this[int index1, int index2] 
    { 
        // get accessor 
        get
        { 
               
             // it returns the values which 
            // read the indexes 
            return data[index1, index2]; 
               
        } 
           
        // set accessor 
        set
        { 
               
            // write the values in 'data' 
            // using value keyword 
            data[index1, index2] = value; 
               
        } 
    } 
} 
   
// Driver Class 
class Geeks { 
       
       
    // Main Method 
    public static void Main(String []args) 
    { 
           
        // creating the instance of  
        // Class GFG as "index" 
        GFG index = new GFG(); 
        Console.WriteLine("Hello world dear");
        Console.ForegroundColor = ConsoleColor.White;
        
           
   
        // assign the values accordingly to 
        // the indexes of the array 
        // 1st row 
        index[0, 0] = 1; 
        index[0, 1] = 2; 
        index[0, 2] = 3; 
           
        // 2nd row 
        index[1, 0] = 4; 
        index[1, 1] = 5; 
        index[1, 2] = 6; 
           
        // 3rd row 
        index[2, 0] = 7; 
        index[2, 1] = 8; 
        index[2, 2] = 9; 
       
        // displaying the values 
        // Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", 
        //                           index[0, 0], index[0, 1], index[0, 2], 
        //                           index[1, 0], index[1, 1], index[1, 2],  
        //                           index[2, 0], index[2, 1], index[2, 2]); 
    
        bool canIvote = true;
        Console.WriteLine("Biggest integer: {0}", int.MinValue);
          Console.WriteLine("Biggest integer: {0}", int.MaxValue);
          Console.WriteLine("Biggest long: {0}", long.MinValue);
          Console.WriteLine("Biggest long: {0}", long.MaxValue);
       
    } 
}