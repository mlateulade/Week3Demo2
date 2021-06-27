using System;

//loops
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //input testscore
    //Syntax of the while loop while condition: while(condition){}

  int counter = 0;
  int total = 0; 

  Console.WriteLine("How many students do you have?");
  int numberOfStudents = Convert.ToInt32(Console.ReadLine());

  while (counter < numberOfStudents)
  {
    Console.WriteLine("Enter score of kid");
    int testscore = Convert.ToInt32(Console.ReadLine());
    total = total + testscore;
    counter++;//counter = counter + 1
  }
  
  double average = total / numberOfStudents;

  Console.WriteLine("Average of test scores of "+numberOfStudents+" students = " + average);


  }
}