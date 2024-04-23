//  Первая задача.


// void ShowNumbers(int m = 5,int n = 10)
// {
//     if (m == n)
//     {
//         Console.Write(m);
//         return;
//     }   
//          Console.Write(m + " ");
//             ShowNumbers(m + 1, n);
        

    
// }
// ShowNumbers(5 , 10);

// Вторая задача.


 // int ack(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return ack(n - 1, 1);
//     else
//         return ack(n - 1, ack(n, m - 1));
// }
 
// Console.WriteLine(ack(1, 2)); 
// Console.WriteLine(ack(0, 0)); 
 //Console.WriteLine(ack(4, 5)); 
 
 //Console.ReadKey();


//Третья задача.

 static void ReversArray(int[] Array, int i = 0)
   
 {
     
  if (i < Array.Length)
  {
    Console.WriteLine(Array[i]);
    ReversArray(Array, i --);
  }

    for(Array [i] = Array.Length -1; i>= 0; )
     {
    
        Console.WriteLine(Array[i]);
        return;
     }
       Console.Write(Array [i] + " ");


 }
 