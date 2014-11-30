using System;
namespace Switch{
  class Test{
    static void Main(string []args){
    
      // step 01 - create switch object passing your option list
      Switch sw = new Switch("one","two","three","four");
            
      // step 02 - display and get the user's choice 
      int x = sw.get();
            
      // step 03 - handle the choice 
      Console.Write("Your choice was "+x);

    }
  }
    
  // just copy and paste below class to any of your program to use it 
    
  class Switch{
    private string[] list;
    public int get(){
      int choice=1;
      bool error=false;
      do{
        int c = 1;
        Console.Write(error ? "\nInvalid option!\n\n" : "\n");
        foreach(string a in list){Console.WriteLine(c+++" - "+a);}
        Console.Write("\nYour option : ");
        choice = Convert.ToInt16(Console.ReadLine());
        error = 0 > choice || choice > list.Length;
      }while(error);
      return choice;
    }
  public Switch(params string[] x){list = x;}
  }
}
