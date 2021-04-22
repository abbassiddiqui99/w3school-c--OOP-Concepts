namespace w3school_c__OOP_Concepts
{
    public class Car
    {
        internal string model;
        public string color;
        private int year;

        public Car(string model, string color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public void getCarDetails(){
            System.Console.WriteLine("Car Details: {0} {1} {2}",model, color, year);
        }
    }
}