using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
             Employee employee1 = new Employee();
            Console.Write("Номро дохил кунед: ");
            employee1.name = Console.ReadLine();
            Console.Write("Насабро дохил кунед: ");
            employee1.surname = Console.ReadLine();
            Console.WriteLine("Дар кадом зина чойгир аст:");
            Console.WriteLine("1. Саркунанда");
            Console.WriteLine("2. Огозкарда");
            Console.WriteLine("3. Миёна");
            Console.WriteLine("4. Пешкадам");

            int ChoicePosition = Convert.ToInt32(Console.ReadLine());
            if((ChoicePosition>=1)&&(ChoicePosition<=4))
            {
                Console.WriteLine("Чанд сол рутбаи кори дорад:");
                Console.WriteLine("1. Як сол");
                Console.WriteLine("2. Ду сол");
                Console.WriteLine("3. Се сол");
                Console.WriteLine("4. Чор сол");
            }
            else
            {
                Console.WriteLine("Амали номаълум!");
                
            }
            
            int ChoiceExperience = int.Parse(Console.ReadLine());
            if((ChoiceExperience>=1)&&(ChoiceExperience<=4))
            {
                Console.WriteLine("Info about employee:");
            Console.WriteLine($"Name: {employee1.name}");
            Console.WriteLine($"Surname: {employee1.surname}");
            Console.WriteLine($"Position: {employee1.post[ChoicePosition-1]}");
            Console.WriteLine($"Salary: {employee1.salary(ChoicePosition, ChoiceExperience)}");
            Console.WriteLine($"Tax: {employee1.tax(employee1.salary(ChoicePosition, ChoiceExperience))}");
            }
            else
            {
                Console.WriteLine("Амали шумо номаълум аст!");
            }
            // ZaniHub Zabotlivaya = new ZaniHub ();
            // Zabotlivaya.HurokpaziNagz();
            // Console.WriteLine("Хамсари табьи дилатонро интихоб намоед!");
            // System.Console.WriteLine("1.HurokpaziNagz  \n2.RubuchiniHona \n3.Mehrubon \n4.Namozhon ");
            // int ZaniHub = int.Parse(Console.ReadLine());
            // if (ZaniHub == 1)
            // {
            //     Zabotlivaya.HurokpaziNagz();
            //     System.Console.WriteLine("Ба шумо мукин ки < Гулсанам синусол: 20 тел: (9566656)> Маъкул шавад!");
            // }
            // else if(ZaniHub == 2)
            // {
            //     Zabotlivaya.RubuchiniHona();
            //     System.Console.WriteLine("Ба шумо мукин ки < Гулсумби синусол: 20 тел: (904006656)> Маъкул шавад!");
            // }
            // else if (ZaniHub == 3)
            // {
            //     Zabotlivaya.Mehrubon();
            //     System.Console.WriteLine("Ба шумо мукин ки < Шамигул синусол: 20 тел: (9340000056)> Маъкул шавад!");
            // }
            // else if (ZaniHub == 4)
            // {
            //     Zabotlivaya.Namozhon();
            //     System.Console.WriteLine("Ба шумо мукин ки < Нозия синусол: 20 тел: (93456656)> Маъкул шавад!");
            // }
            // else
            // {
            //     Console.WriteLine("У вас неопределённый вкус!");
            // }
            

            // Console.Write("a = ");  
            // double a = double.Parse(Console.ReadLine());
            // Console.Write("b = ");
            // double b = double.Parse(Console.ReadLine());
            
            //     var rectangle = new Rectangle(a ,b);
            //   Console.WriteLine($"Масофа = " + rectangle.AreaCalculator());
            //   Console.WriteLine($"Периметр = " + rectangle.PerimetrCalculator());
            //  Console.Write("Номи китобро дохил кунед = ");            
            //  string title = Console.ReadLine();
            //  Console.Write(" Муаллифи китобро дохил кунед = ");
            //  string author = Console.ReadLine();
            //  Console.Write(" Матни китобро дохил кунед = ");
            //  string content = Console.ReadLine();
            //  Book book1 = new Book(title, author, content);

            //  book1.ShowAll();

        //     аввал:
        //     Converter converter = new Converter(11.20, 13.00, 0.15);
        //     Console.Write($"Маблагро дохил кунед: ");
        //     // var jursozi = double.Parse(Console.ReadLine());
        //     var isParsed = int.TryParse(Console.ReadLine(),    out var jursozi); 
        //     if(!isParsed){
        //         System.Console.WriteLine("Шумо ракам дохил накардед!");
        //     }
        //     else
        //     {
                
        //     Console.WriteLine($"Маблаги ивазшавандаатонро дохил кунед: ");
        //     Console.WriteLine("1. TJS to USD \n2. TJS to EUR \n3. TJS to RUB \n4. USD to TJS \n5. EUR to TJS \n6. RUB to TJS");
        //     Console.Write($"Навьи ивазкунии маблагро интихоб кунед (Аз 1 то 6): ");
            
        //     int IntihobiMan = int.Parse(Console.ReadLine()); // Аз 1 то 6
        //     if (IntihobiMan == 1)
        //     {
        //         double TJStoUSD = converter.ConvertTjsToUsd(jursozi);
        //         Console.WriteLine("Маблаги TJS ба USD = " + TJStoUSD);
        //     }
        //     else if (IntihobiMan == 2)
        //     {
        //         double TJStoEUR = converter.ConvertTjsToEur(jursozi);
        //         Console.WriteLine("Маблаги TJS ба EUR = " + TJStoEUR);
        //     }
        //     else if (IntihobiMan == 3)
        //     {
        //         double TJStoRUB = converter.ConvertTjsToRub(jursozi);
        //         Console.WriteLine("Маблаги TJS ба Rub = " + TJStoRUB);
        //     }
        //     else if (IntihobiMan == 4)
        //     {
        //         double USDtoTJS = converter.ConvertUSdToTjs(jursozi);
        //         Console.WriteLine ("Маблаги USD ба TJS="+ USDtoTJS );
        //     }
        //     else if (IntihobiMan == 5)
        //     {
        //         double EurtoTJS = converter.ConvertUSdToTjs(jursozi);
        //         Console.WriteLine("Маблаги EUR ба TJS = " + EurtoTJS);
        //     }           
        //     else if (IntihobiMan == 6)
        //     {
        //         double RUBtoTJS = converter.ConvertRubToTjs(jursozi);
        //         Console.WriteLine("Маблаги RUB ба TJS = " +  RUBtoTJS );
        //     }

        //     else 
        //     {
        //         Console.WriteLine("Шумо интихоби номаълум кардед! ");
        //     }
        //     goto аввал;
            
        // }   
        //     }
            
    }
            

        }
    //}
    //  class Rectangle                        //ВХ №1 Машки 2.
    //      {
    //        public double side1;
    //        public double side2;
    //        public Rectangle(double side1, double side2)
    //        {
    //            this.side1 = side1;
    //            this.side2 = side2;

    //        }

    //        public double AreaCalculator()
    //        {
    //            return side1 *side2;
    //        }
    //        public double PerimetrCalculator()
    //        {
    //            return 2*(side1 + side2);
    //    }
       
    //       }
          
         //}

        //  class Book           //ВХ №1 Машки 3
        //  {
        //      Title title;
        //      Author author;
        //      Content content; 
        //      public Book(string t, string a, string c)
        //      {
        //          title = new Title(t);
        //          author = new Author(a);
        //          content = new Content(c);
        //      }
        //      public void ShowAll()
        //      {
        //          Console.ForegroundColor = ConsoleColor.Red;
        //          title.Show();
        //           Console.ForegroundColor = ConsoleColor.Yellow;
        //          author.Show();
        //           Console.ForegroundColor = ConsoleColor.Green;
        //          content.Show();
        //          Console.ForegroundColor = ConsoleColor.White;
        //      }
        //  }
        //  class Title
        //  {
        //      string title;
        //      public Title(string t)
        //      {
        //          title = t;
        //      }
            
        //      public void Show()
        //      {
        //           Console.WriteLine(title);   
        //      }
        //  }

        //   class Author
        //  {
        //      public Author(string a)
        //      {
        //          author = a;
        //      }
        //      string author;
        //      public void Show()
        //      {
        //          Console.WriteLine(author);
        //      }
        //  }
        //  class Content
        //  {
        //      public Content(string c)
        //      {
        //          content = c;
        //      }
        //      string content;

        //     public void Show()
        //      {
        //          Console.WriteLine(content);
        //      }
             
    //          class Converter      //ВХ №2 Машки 2
    // {
    //     public Converter(double usd, double eur, double rub)
    //     {
        
    //         this.usd = usd;
    //         this.eur = eur;
    //         this.rub = rub;


    //     }

    //     public double usd {get; set;} 
    //     public double eur {get; set;}
    //     public double rub {get; set;}

    //     public double ConvertTjsToUsd(double tjs)
    //     {
    //         return tjs / this.usd;
    //     }
    //      public double ConvertTjsToEur(double tjs)
    //      {
    //          return tjs / this.eur;
    //      }
    //       public double ConvertTjsToRub(double tjs)
    //       {
    //           return tjs / this.rub;
    //       }
        
    //       public double ConvertUSdToTjs(double usd)
    //     {
    //         return usd * this.usd;
    //     }

    //     public double ConvertEurToTjs(double eur)
    //     {
    //         return eur * this.eur;
    //     }
    //     public double ConvertRubToTjs(double rub)
    //     {
    //         return rub * this.rub;
         }
         
            // class ZaniHub                //ВХ №1 Машки 4
            // {
            //     public void HurokpaziNagz()
            //     {
            //         Console.WriteLine("The best variant is:");
        
            //     }
            //     public void RubuchiniHona()
            //     {
            //         Console.WriteLine("The best variant is:");
            //     }
            //     public void Mehrubon() 
            //     {
            //         Console.WriteLine("The best variant is:");
            //     }
            //     public void Namozhon()
            //     {
            //         Console.WriteLine("The best variant is:");
            //     }
            class Employee{                 //ВХ №2 Машки 3
            public string name {get; set;}
            public string surname {get; set;}
            public Employee (string name, string surname){
                this.name = name;
                this.surname = surname;
            }
            public Employee(){

            }
            public int[] postSalary = {1000, 3000, 5000, 7000};
            public string[] post = {"Саркунанда", "Огозкарда", "Миёна", "Пешкадам"};
            public int[] service = {1000, 50000, 15000, 90000};   
            public int salary(int cP, int cE)
            {
                return postSalary[cP-1] + service[cE-1];
            }
            public double tax(int salary)
            {
                return 0.14*salary;
            }
        }
            
