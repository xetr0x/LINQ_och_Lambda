using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_och_Lambda
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
            List<Car> Cars = new List<Car>();   

            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });   //All Cars
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });
            
            var sortcars = Cars.OrderBy(x => x.Make);   // sorting all by make
            foreach (var item in sortcars)              //writing them down
            {
                listBox1.Items.Add($"ID:{item.Id} Make:{item.Make} Model:{item.Model} Color:{item.Color} km:{item.Km} Price:{item.Price} Year:{item.Year}");
            }

            BtnCountRed.Text = "Red color count";
            BtnCountolderthan2003.Text = "Cars older than 2003";
            btnGreyVolvos.Text = "Gray cars";
            BtnAverageDistance.Text = "Average driving distance ";
            BtnMostExpensiveCar.Text = "The most expensive car";




            BtnCountRed.Click += new EventHandler(                      //Method for the red count button
            (sender, e) =>
            {
                int red = Cars.Count(x => x.Color == "Red");
                listBox1.Items.Add($"There are  {red} red cars");
            });

            BtnCountolderthan2003.Click += new EventHandler((sender, e) =>              //Method for the Count older than 2003 button
            {
                int olderthan = Cars.Count(x => x.Year > 2003);
                listBox1.Items.Add($"There are {olderthan} cars younger than 2003");
            });

            btnGreyVolvos.Click += new EventHandler((sender, e) =>                      //Method for Grey volvos button
            {
                int GreyVolvo = Cars.FindAll(x => x.Make == "Volvo").Count(y => y.Color == "Grey");
                listBox1.Items.Add($"There are {GreyVolvo} grey Volvos");
            });

            BtnAverageDistance.Click += new EventHandler((sender, e) =>                 //MEthod for Average distance
            {
                double AverageDistance = Cars.FindAll(x => x.Make == "BMW").Average(y => y.Km);
                listBox1.Items.Add($"The average distance for BMWs' is {AverageDistance} ");
            });

            BtnMostExpensiveCar.Click += new EventHandler((sender, e) =>                //Method for expensive car
            {
                 Cars = Cars.OrderByDescending(x => x.Price).ToList();
                listBox1.Items.Add($"The most expensive car in storage is {Cars[0].Make} {Cars[0].Model} {Cars[0].Year} With the price of: {Cars[0].Price}");

            });





        }




    



    class Car               //Car class 
        {
           public int Id;
           public string Make;
           public string Model;
           public string Color;
           public int Km;
           public int Price;
           public int Year;
        }


    }
}
