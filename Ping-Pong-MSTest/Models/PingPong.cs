using System;
using System.Collections.Generic;

namespace PingPongApp
{
  public class PingPong
  {
    static void Main()
    {
      Console.WriteLine("Enter number to ping and pong up 'til:");
      int userNum = int.Parse(Console.ReadLine());
      PingPong pingPong = new PingPong();
      Console.WriteLine(pingPong.PingPongCheck(userNum));
    }

    public string PingPongCheck(int chosenNum)
    {
      string resultString = "";

      for(int i = 1; i <= chosenNum; i++){
        if(i % 15 == 0){
          resultString += "Ping-Pong";
        } else if ( i % 3 == 0 ) {
          resultString += "Ping";
        } else if ( i % 5 == 0 ) {
          resultString += "Pong";
        } else {
          resultString += i.ToString();
        }
        if((i + 1) <= chosenNum){
          resultString += ", ";
        }
      }
      return resultString;
    }
  }
}

//                      PLAIN ENGLISH SPECS
//-------------------------------------------------------------------
//number is divisible by 3 -----------------> program outputs "Ping"
//number is divisble by 5 ------------------> program outputs "Pong"
//number is divisbile by 15 ----------------> program outputs "Ping-Pong"
//number is not divisible by 3, 5, or 15 ---> program outputs number