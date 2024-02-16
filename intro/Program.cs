// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");

string message1= "krediler";
int term = 12;
double amount = 23.4;
// veriables --> camelCase
bool isAutentication = true;
Console.WriteLine("mesaj:" + message1 + "\nterm:" + term + "\namount:" + amount + "\nisAutanticaiton:" + isAutentication);

//condition=şart

if (isAutentication) // if (isAutentication == true) aynı ifade
{
    Console.WriteLine("Buton HG Yeşim");

}
else
{
    Console.WriteLine("Sisteme Giriş yap");
}
Console.WriteLine("kod bitti");


string[] krediler = { "kredi1", "kredi2","kredi3" };
// sıfırdan başla, kredilerin eleman sayısından küçük olduğu sürece 1er artsın 
for (int i = 0; i < krediler.Length; i++)
{
    Console.WriteLine(krediler[i]);
}
/*
Course course1 = new Course();
course1.Id = 1;
course1.Name = "e.Demirog";
course1.Description = "message";
course1.Price= 12.5;

Course course2 = new Course();
course2.Id = 1;
course2.Name = "YG";
course2.Description = "yy";
course2.Price = 12.5;

Course[] courses = {course1,course2};
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name);
}
*/

CourseManager courseManager= new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name);
}


Console.WriteLine("Kod bitti");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIndentity = "23959483944";
customer1.FirstName="Yeşim";
customer1.LastName = "Gezici";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIndentity = "84930482844";
customer2.FirstName = "Fatma";
customer2.LastName = "Gezici";
customer2.CustomerNumber = "12363478";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "342235";
customer3.TaxNumber = "21321243432";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Engin Demirog";
customer4.CustomerNumber = "342235";
customer4.TaxNumber = "21321243432";

//value types --> in, bool,double...
//referance types --> array, class, interface...

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
for (int i = 0; i < customers.Length; i++)
{
    Console.WriteLine(customers[i].CustomerNumber);
}
//üsttekinin aynısının farklı yazımı
foreach (BaseCustomer customer in customers)
{


    Console.WriteLine(customer.CustomerNumber);
}