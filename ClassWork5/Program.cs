namespace ClassWork5
{
    // ToyBear interface
    interface Toybear
    {
        //The ToyBear interface has one Method: void Hug()
        void Hug();
    }

    //TeddyBear class extends ToyBear interface
    class TeddyBear : Toybear
    {
        //TeddyBear class must implement the Method in the ToyBear interface
        public void Hug()
        {
            Console.WriteLine("HUG\n");
        }
    }


    //The Bear Interface
    interface Bear
    {
        //The bear interface has two operations/Methods: void Maul & void Hibernate
        void Maul();
        void Hibernate();
    }
    
    //Grizzly class extends Bear interface
    class Grizzly : Bear
    {
        //Grizzly class must implement both methods in Bear interface
        public void Maul()
        {
            Console.WriteLine("MAUL");
        }
        public void Hibernate()
        {
            Console.WriteLine("HIBERNATE\n");
        }
    }

    //BearAdapter class extends ToyBear Interface.
    class BearAdapter : Toybear
    {
        //BearAdapter contains a Bear object
        Bear bearObj;

        //Parameterized constructor takes in Bear Object (bearObj)
        public BearAdapter(Bear bearObj)
        {
            this.bearObj = bearObj;
        }

        //Implementing ToyBear's Method (Hug)
        public void Hug()
        {
            //using the bear object (bearObj) we call the Maul and Hibernate Methods
            bearObj.Maul();
            bearObj.Hibernate();
        }
    }
  
    //entry point of the program
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //testing the Grizzly class
            Console.WriteLine("Grizzly bear: ");
            Grizzly realBear = new Grizzly();
            realBear.Maul();
            realBear.Hibernate();

            //testing the ToyBear Class
            Console.WriteLine("Teddy bear: ");
            Toybear toy = new TeddyBear();
            toy.Hug();

            //testing BearAdapter class
            Console.WriteLine("Testing BearAdapter : ");
            BearAdapter adapterBear = new BearAdapter(realBear);
            adapterBear.Hug();
        }
    }
}