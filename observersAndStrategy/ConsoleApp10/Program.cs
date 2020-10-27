using System;
using ConsoleApp10.Subject;
using ConsoleApp10.Observer;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //##Observer part

            MainYouTubeChannel main = new MainYouTubeChannel();

            ISubscriber Jo = new User();
            ISubscriber Ken = new User();
            ISubscriber Takao = new Moderator();

            main.Subscribe(Jo);
            main.Subscribe(Ken);
            main.Subscribe(Takao);

            main.NotifySubscribers();

            Console.WriteLine("Ken unsbscribed");
            main.Unsubscribe(Ken);
            
            main.NotifySubscribers();


            GameChannel game = new GameChannel();
            game.Subscribe(Jo);
            game.Subscribe(Ken);
            
            
            CookingChannel cooking = new CookingChannel();
            cooking.Subscribe(Jo);
            cooking.Subscribe(Ken);


            Console.WriteLine("\n#################################\n");
            
            //##Strategy part

            Channels objchannelGeneric = new Channels(null); 
            objchannelGeneric.BillAmount = 1000;

            while (true)
            {
                Console.WriteLine("Calculating promotion fee for a YouTube channel.");
                Console.WriteLine("Choose a channel (1 = Main, 2 = Game, 3 = Cooking)");

                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        objchannelGeneric.CurrentStrategy = main;
                        objchannelGeneric.SubscriberNum = main.HowManySubscribers();
                        break;
                    case "2":
                        objchannelGeneric.CurrentStrategy = game;
                        objchannelGeneric.SubscriberNum = game.HowManySubscribers();
                        break;
                    case "3":
                        objchannelGeneric.CurrentStrategy = cooking;
                        objchannelGeneric.SubscriberNum = cooking.HowManySubscribers();
                        break;
                    default:
                        objchannelGeneric.CurrentStrategy = main;
                        objchannelGeneric.SubscriberNum = main.HowManySubscribers();
                        break;
                }

                Console.WriteLine("Promotion fee in this channel " + objchannelGeneric.GetFinalBill() + "$\n");
            }
            

        }
    }
}
