// using System;

// namespace institute
// {
//     class person
//     {
//         static void Main(string[] args)
//         {
//             dog basa = new animals();
//             dog weight = new monkey();
//             weight.food();

//         }
//     }                                                                             // heirachy inheritance && polymprphism
//     public class animals : dog                                                            //---->monkey
//     {                                                                                // dog----> animals 
//         public override void food()
//         {
//             base.food();
//         }
//     }
//     public class monkey : dog
//     {
//         public override void food()
//         {
//             base.food();
//             for (int i = 1; i <= 5; i++)
//             {
//                 if (i % 2 == 0)
//                 {
//                     Console.WriteLine("i===" + i);
//                 }
//             }
//         }
//     }
//     public class dog
//     {
//         public virtual void food()
//         {

//             int a = 90;
//             a = a * a;
//             Console.WriteLine("a : " + a);
//         }
//     }

// }