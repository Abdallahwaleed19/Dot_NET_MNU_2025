namespace Day04;
using System;
class Program
{
    static void Main(string[] args)
    {
        //    Car car1 = new Car("Toyota", 30000, "CH12345");
        //    car1.DisplayInfo();
        //    Car car2 = new Car("Honda", 28000, "CH67890");
        //    car2.DisplayInfo();
        //    Car car3 = new Car("Ford", 35000, "CH54321");
        //    car3.DisplayInfo();

        //Dog dog = new Dog("Tom");   
        //dog.Eat();
        //dog.Bark();

        //Manager manager = new Manager("Abdallah", 90000);
        //manager.DisplayInfo();
        //manager.ManageTeam();

        //Rectangle rect = new Rectangle();
        //rect.Draw();
        //rect.Move();
        //rect.Resize();
        //Circle circle = new Circle();
        //circle.Draw();
        //circle.Move();
        //circle.Resize();

        Phone phone = new Phone("122334");
        phone.turnOn();
        SmartPhone smartPhone = new SmartPhone("998877");
        smartPhone.turnOn();
        smartPhone.Call("01005831772");
        smartPhone.TakePhoto("Abdallah.jpg");
        Tablet tablet = new Tablet("556677");
        tablet.turnOn();
    }
}