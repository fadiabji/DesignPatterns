﻿using DesignPatterns.Behavioral_Patterns._1_Chain_of_Responsibility;
using DesignPatterns.Behavioral_Patterns._10_Template_Method.Abstract;
using DesignPatterns.Behavioral_Patterns._10_Template_Method.Subclasses;
using DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_elements;
using DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_visitors;
using DesignPatterns.Behavioral_Patterns._2_Command;
using DesignPatterns.Behavioral_Patterns._3_Interpreter.Implementations;
using DesignPatterns.Behavioral_Patterns._3_Interpreter.Interfaces;
using DesignPatterns.Behavioral_Patterns._4_Iterator.Interfaces;
using DesignPatterns.Behavioral_Patterns._5_Mediator.Colleagure;
using DesignPatterns.Behavioral_Patterns._5_Mediator.Implementations;
using DesignPatterns.Behavioral_Patterns._5_Mediator.Interfaces;
using DesignPatterns.Behavioral_Patterns._6_Memento;
using DesignPatterns.Behavioral_Patterns._7_Observer.Implementations;
using DesignPatterns.Behavioral_Patterns._7_Observer.Interfaces;
using DesignPatterns.Behavioral_Patterns._9_Strategy;
using DesignPatterns.Behavioral_Patterns.State.Wrong;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Client;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Abstract_Factory;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces.Abstract_Factory;
using DesignPatterns.Creational_Patterns._2_Builder.Implementations;
using DesignPatterns.Creational_Patterns._2_Builder.Models;
using System.Linq.Expressions;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Behaviour Patterns
            // 1- Chanin of responsibility Pattern 
            // Client ...............................
            // Create handlers
            //IHandler discountHandler = new DiscountHandler();
            //IHandler refundHandler = new RefundHandler();
            //IHandler supportHandler = new SupportHandler();
            //// Set the chain of responsibility
            //discountHandler.HandleRequest(new Request("Discount"));
            //refundHandler.HandleRequest(new Request("Refund"));
            //supportHandler.HandleRequest(new Request("Support"));
            //Console.ReadKey();


            // 8- State Pattern right using
            // Client ...............................
            //Canvas canvas = new Canvas();
            //canvas.SetCurrentTool(new SelectionTool());
            //canvas.mouseDown();
            //canvas.mouseUp();
            //State Pattern wrong using
            //StopWatch stopwatch = new StopWatch();
            //stopwatch.Click();
            //stopwatch.Click();

            // 2- Command Desing pattern
            // Client ...............................
            //ShoppingCart cart = new ShoppingCart();
            //User user = new User();
            //// Adding items to the cart
            //ICommand addItemCommand1 = new AddItemCommand(cart, "Product A");
            //ICommand addItemCommand2 = new AddItemCommand(cart, "Product B");
            //user.ExecuteCommand(addItemCommand1);
            //user.ExecuteCommand(addItemCommand2);
            //// Removing an item from the cart
            //ICommand removeItemCommand = new RemoveItemCommand(cart, "Product A");
            //user.ExecuteCommand(removeItemCommand);
            //// Displaying the cart
            //cart.DisplayCart();
            //Console.ReadKey();

            //3_ Interpret Design pattern
            // Client ..................
            //IExpression expression = new AdditionExpression(
            //new NumberExpression(5),
            //new AdditionExpression(
            //    new NumberExpression(3),
            //    new NumberExpression(7)
            //        )
            //    );
            //int result = expression.Interpret();
            //Console.WriteLine("Result: " + result);
            //Console.ReadKey();

            //4_ Iterator Design pattern
            // Client code
            //MyCollection collection = new MyCollection();
            //collection.AddItem("First");
            //collection.AddItem("Second");
            //collection.AddItem("Third");

            //IIterator iterator = collection.CreateIterator();
            //while (iterator.HasNext())
            //{
            //    string item = (string)iterator.Next();
            //    Console.WriteLine(item);
            //}


            //5_ Mediator Design pattern
            // Client code
            //IChatRoomMediator chatRoom = new ChatRoom();

            //MedaitorUser user1 = new MedaitorUser(chatRoom, "Alice");
            //MedaitorUser user2 = new MedaitorUser(chatRoom, "Bob");
            //MedaitorUser user3 = new MedaitorUser(chatRoom, "Charlie");

            //chatRoom.RegisterUser(user1);
            //chatRoom.RegisterUser(user2);
            //chatRoom.RegisterUser(user3);

            //user1.Send("Hello, everyone!");
            //user2.Send("Hi, Alice!");
            //user3.Send("Hey there!");


            //6- Memento Design pattern 
            // Client
            //TextEditor editor = new TextEditor();
            //TextEditorHistory history = new TextEditorHistory();

            //editor.Write("Hello, ");
            //history.AddMemento(editor.CreateMemento());

            //editor.Write("World!");
            //history.AddMemento(editor.CreateMemento());

            //editor.ShowContent();  // Output: Current Content: Hello, World!

            //editor.Write(" How are you?");
            //history.AddMemento(editor.CreateMemento());

            //editor.ShowContent();  // Output: Current Content: Hello, World! How are you?

            //// Undo last change
            //Memento lastMemento = history.GetMemento(history.GetHistory().Count - 2);
            //editor.Restore(lastMemento);

            //editor.ShowContent();  // Output: Current Content: Hello, World!

            //7 - Observer Pattern
            //Client
            // Create a WeatherData subject
            //WeatherData weatherData = new WeatherData();
            //// Create observers
            //CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            //StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            //// Register observers
            //weatherData.RegisterObserver(currentDisplay);
            //weatherData.RegisterObserver(statisticsDisplay);
            //// Simulate new weather measurements
            //weatherData.SetMeasurements(80, 65, 30.4f);
            //weatherData.SetMeasurements(82, 70, 29.2f);
            //weatherData.SetMeasurements(78, 90, 29.2f);

            //9 - Strategy pattern
            //Console.WriteLine("Choose payment method (credit/paypal/bitcoin): ");
            //string paymentMethod = Console.ReadLine().Trim().ToLower();

            //IPaymentStrategy strategy = null;

            //switch (paymentMethod)
            //{
            //    case "credit":
            //        strategy = new CreditCardPayment();
            //        break;
            //    case "paypal":
            //        strategy = new PayPalPayment();
            //        break;
            //    case "bitcoin":
            //        strategy = new BitcoinPayment();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid payment method");
            //        return;
            //}

            //Behavioral_Patterns._9_Strategy.ShoppingCart cart = new Behavioral_Patterns._9_Strategy.ShoppingCart(strategy);
            //cart.Checkout(100.0); // Example amount to pay


            //10 Template_Method Pattern 

            //Game game = new Football();
            //game.Play();

            //Console.WriteLine();

            //game = new Cricket();
            //game.Play();

            //11- Visitor Pattern
            // Create some shapes
            //Circle circle = new Circle(5);
            //Rectangle rectangle = new Rectangle(3, 4);

            //// Create visitors
            //AreaVisitor areaVisitor = new AreaVisitor();
            //DrawVisitor drawVisitor = new DrawVisitor();

            //// Use visitors
            //circle.Accept(areaVisitor);
            //circle.Accept(drawVisitor);

            //rectangle.Accept(areaVisitor);
            //rectangle.Accept(drawVisitor);

            // Creational_Patterns
            //1_ Abstract Factory
            // Use Windows Factory
            //IGUIFactory windowsFactory = new WindowsFactory();
            //Application windowsApp = new Application(windowsFactory);
            //windowsApp.Run();

            //// Use MacOS Factory
            //IGUIFactory macFactory = new MacOSFactory();
            //Application macApp = new Application(macFactory);
            //macApp.Run();

            //2_ Builder Pattern
            // Create a pizza maker with a specific builder
                var hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
                var pizzaMaker = new PizzaMaker(hawaiianPizzaBuilder);

                // Make the pizza
                pizzaMaker.MakePizza();

                // Get the pizza from the builder
                Pizza pizza = hawaiianPizzaBuilder.GetPizza();

                // Display the pizza details
                Console.WriteLine("Hawaiian Pizza:");
                pizza.Display();
        }
    }
}
