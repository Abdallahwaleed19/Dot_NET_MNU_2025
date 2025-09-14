using System;
namespace Day06
{
    public delegate void TankFullHandler();
    public delegate void LightChangedHandler(int luxLevel);
    class Program
    {
        static async Task Main(string[] args)
        {
            //WaterTank tank = new WaterTank();
            //Pump pump = new Pump();
            //tank.TankFull += pump.StopPump; 
            //tank.Fill();


            //LightSensor sensor = new LightSensor();
            //LampController controller = new LampController();
            //sensor.LightChanged += controller.TurnOnLamp;
            //sensor.LightChanged += controller.LogLightChange;
            //sensor.SetLightLevel(80);


            //Order order = new Order();
            //OrderConfirmationService confirmationService = new OrderConfirmationService();
            //order.OrderPlaced += confirmationService.SendConfirmation;
            //order.PlaceOrder();


            //DoorLock door = new DoorLock();
            //DoorSystem doorSystem = new DoorSystem();
            //door.DoorStateChanged += doorSystem.ShowDoorStatus;
            //door.DoorStateChanged += doorSystem.PlayLockSound;
            //door.LockDoor(true);
            //door.LockDoor(false);




            //CoffeeMachine coffeeMachine = new CoffeeMachine();
            //await coffeeMachine.BrewCoffeeAsync();


            //FileProcessor fileProcessor = new FileProcessor();
            //Task readTask = fileProcessor.ReadFileAsync();
            //Task analyzeTask = fileProcessor.AnalyzeFileAsync();
            //await Task.WhenAll(readTask, analyzeTask);
            //Console.WriteLine("All file operations complete.");


        }
    }
}