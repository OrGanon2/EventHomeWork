using System;

namespace EventHomeWork
{
    class Program
    {
        public delegate void DeleName();
        public delegate void LuckyNumberWasEntered();
        public delegate void LuckyFive();
       


        #region Q1
        //static void print()
        //{
        //    Console.WriteLine("to many words");
        //}
        //static void print2()
        //{
        //    Console.WriteLine("its good");
        //}
        #endregion
        #region Q2

        //public static void Luck()
        //{
        //    Console.Write("Lucky number!");
        //}
        //public static void Unlucky()
        //{
        //    Console.WriteLine("Try again");
        //}

        #endregion
        #region Q3
        //public static void Fifthstudent()
        //{
        //    Console.WriteLine("you get 5% discount");
        //}

        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //NameList Student = new NameList("Salava gonzales");

            //TooLongName = print;
            //NotTolong = print2;

            //if (Student.Name.Length >= 8)
            //{
            //    TooLongName();
            //}
            //else
            //{
            //    NotTolong();
            //}
            #endregion


            #region Q2


            //Console.WriteLine("question 2:  Enter Number");
            //var Number = int.Parse(Console.ReadLine());
            //while (Number != 999)
            //{
            //    Unlucky2();
            //    Console.WriteLine("question 2:  Enter Number");
            //     Number = int.Parse(Console.ReadLine());
            //}
            //LuckyLucky();
            #endregion


            #region Q3
            //LuckyStudent = Fifthstudent;
            //while (StudentList.LuckyFifthStudent.Count != 15 )
            //{
            //    Console.WriteLine("question 3: enter your name");
            //    StudentList.LuckyFifthStudent.Add(new NameList(Console.ReadLine()));
            //    if (StudentList.LuckyFifthStudent.Count % 5 == 0)
            //    {
            //        LuckyStudent();
            //    }

            //}

            #endregion
            #region Q4

            var point = new Pinpoint(7);
            var square = new square(5);

            Console.WriteLine("Guess the loaction by entering a number");
            Shape.shapeChecker(point,int.Parse(Console.ReadLine()));









            #endregion

            

        }









        public static event DeleName TooLongName;
        public static event DeleName NotTolong;
        //public static event LuckyNumberWasEntered LuckyLucky = Luck;
        //public static event LuckyNumberWasEntered Unlucky2 = Unlucky;
        public static event LuckyFive LuckyStudent;


    }
}
