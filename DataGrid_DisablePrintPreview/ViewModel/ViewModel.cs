using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDemoApp
{
    public class EmployeeViewModel : INotifyPropertyChanged, IDisposable
    {
        public EmployeeViewModel()
        {
            PopulateData();
            employees = this.GetEmployeeDetails(30);
            titleCollection = GetTitles();
        }

        private ObservableCollection<Employee> employees;
        /// <summary>
        /// Get or set the EmployeeDetails
        /// </summary>
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }

        }

        private ObservableCollection<string> titleCollection;
        /// <summary>
        /// Get or set the EmployeeDetails
        /// </summary>
        public ObservableCollection<string> TitleCollection
        {
            get
            {
                return titleCollection;
            }

        }

        private bool canAllowSorting = true;

        public bool CanAllowSorting
        {
            get
            {
                return canAllowSorting;
            }
            set
            {
                canAllowSorting = value;
            }
        }

        private bool canAllowFiltering = true;

        public bool CanAllowFiltering
        {
            get
            {
                return canAllowFiltering;
            }
            set
            {
                canAllowFiltering = value;
            }
        }
        private bool canAllowBlankFilters = true;

        public bool CanAllowBlankFilters
        {
            get
            {
                return canAllowBlankFilters;
            }
            set
            {
                canAllowBlankFilters = value;
            }
        }
        private bool canImmediateUpdateColumnFilter;

        public bool CanImmediateUpdateColumnFilter
        {
            get
            {
                return canImmediateUpdateColumnFilter;
            }
            set
            {
                canImmediateUpdateColumnFilter = value;
            }
        }

        Random r = new Random();
        Dictionary<string, string> loginID = new Dictionary<string, string>();
        Dictionary<string, string> gender = new Dictionary<string, string>();

        /// <summary>
        /// Get the EmployeeDetails
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public ObservableCollection<Employee> GetEmployeeDetails(int count)
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            for (int i = 1; i < count; i++)
            {
                var name = employeeName[r.Next(employeeName.Length - 1)];
                var emp = new Employee()
                {
                    EmployeeID = 1000 + i,
                    Name = name,
                    NationalIDNumber = r.Next(14417807, 112457891),
                    ContactID = r.Next(1001, 2000),
                    ManagerID = r.Next(3, 70),
                    LoginID = loginID[name],
                    Gender = gender[name],
                    Title = title[r.Next(title.Length - 1)],
                    MaritalStatus = r.Next(10, 60) % 2 == 0 ? "Single" : "Married",
                    HireDate = new DateTime(r.Next(1995, 2005), r.Next(1, 12), r.Next(1, 28)),
                    BirthDate = new DateTime(r.Next(1975, 1985), r.Next(1, 12), r.Next(1, 28)),
                    SickLeaveHours = r.Next(15, 70),
                    Salary = Math.Round(r.NextDouble() * 6000.5, 2),
                    EmployeeStatus = r.Next() % 2 == 0 ? true : false,
                    Rating = r.Next(1, 11)
                };
                employees.Add(emp);
            }
            return employees;
        }

        private static ObservableCollection<string> GetTitles()
        {
            ObservableCollection<string> titles = new ObservableCollection<string>();
            titles.Add("Marketing Assistant");
            titles.Add("Engineering Manager");
            titles.Add("Senior Tool Designer");
            titles.Add("Tool Designer");
            titles.Add("Marketing Manager");
            titles.Add("Production Supervisor - WC60");
            titles.Add("Production Technician - WC10");
            titles.Add("Design Engineer");
            titles.Add("Production Technician - WC10");
            titles.Add("Design Engineer");
            titles.Add("Vice President of Engineering");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Supervisor - WC50");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Supervisor - WC60");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Supervisor - WC60");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Technician - WC30");
            titles.Add("Production Control Manager");
            titles.Add("Production Technician - WC45");
            titles.Add("Production Technician - WC45");
            titles.Add("Production Technician - WC30");
            titles.Add("Production Supervisor - WC10");
            titles.Add("Production Technician - WC20");
            titles.Add("Production Technician - WC40");
            titles.Add("Network Administrator");
            titles.Add("Production Technician - WC50");
            titles.Add("Human Resources Manager");
            titles.Add("Production Technician - WC40");
            titles.Add("Production Technician - WC30");
            titles.Add("Production Technician - WC30");
            titles.Add("Stocker");
            titles.Add("Shipping and Receiving Clerk");
            titles.Add("Production Technician - WC50");
            titles.Add("Production Technician - WC60");
            titles.Add("Production Supervisor - WC50");
            titles.Add("Production Technician - WC20");
            titles.Add("Production Technician - WC45");
            titles.Add("Quality Assurance Supervisor");
            titles.Add("Information Services Manager");
            titles.Add("Production Technician - WC50");
            titles.Add("Master Scheduler");
            titles.Add("Production Technician - WC40");
            titles.Add("Marketing Specialist");
            titles.Add("Recruiter");
            titles.Add("Production Technician - WC50");
            titles.Add("Maintenance Supervisor");
            titles.Add("Production Technician - WC30");
            return titles;
        }
        /// <summary>
        /// Populate the data for Gender
        /// </summary>
        private void PopulateData()
        {
            gender.Add("Sean Jacobson", "Male");
            gender.Add("Phyllis Allen", "Male");
            gender.Add("Marvin Allen", "Male");
            gender.Add("Michael Allen", "Male");
            gender.Add("Cecil Allison", "Male");
            gender.Add("Oscar Alpuerto", "Male");
            gender.Add("Sandra Altamirano", "Female");
            gender.Add("Selena Alvarad", "Female");
            gender.Add("Emilio Alvaro", "Female");
            gender.Add("Maxwell Amland", "Male");
            gender.Add("Mae Anderson", "Male");
            gender.Add("Ramona Antrim", "Female");
            gender.Add("Sabria Appelbaum", "Male");
            gender.Add("Hannah Arakawa", "Male");
            gender.Add("Kyley Arbelaez", "Male");
            gender.Add("Tom Johnston", "Female");
            gender.Add("Thomas Armstrong", "Female");
            gender.Add("John Arthur", "Male");
            gender.Add("Chris Ashton", "Female");
            gender.Add("Teresa Atkinson", "Male");
            gender.Add("John Ault", "Male");
            gender.Add("Robert Avalos", "Male");
            gender.Add("Stephen Ayers", "Male");
            gender.Add("Phillip Bacalzo", "Male");
            gender.Add("Gustavo Achong", "Male");
            gender.Add("Catherine Abel", "Male");
            gender.Add("Kim Abercrombie", "Male");
            gender.Add("Humberto Acevedo", "Male");
            gender.Add("Pilar Ackerman", "Male");
            gender.Add("Frances Adams", "Female");
            gender.Add("Margar Smith", "Male");
            gender.Add("Carla Adams", "Male");
            gender.Add("Jay Adams", "Male");
            gender.Add("Ronald Adina", "Female");
            gender.Add("Samuel Agcaoili", "Male");
            gender.Add("James Aguilar", "Female");
            gender.Add("Robert Ahlering", "Male");
            gender.Add("Francois Ferrier", "Male");
            gender.Add("Kim Akers", "Male");
            gender.Add("Lili Alameda", "Female");
            gender.Add("Amy Alberts", "Male");
            gender.Add("Anna Albright", "Female");
            gender.Add("Milton Albury", "Male");
            gender.Add("Paul Alcorn", "Male");
            gender.Add("Gregory Alderson", "Male");
            gender.Add("J. Phillip Alexander", "Male");
            gender.Add("Michelle Alexander", "Male");
            gender.Add("Daniel Blanco", "Male");
            gender.Add("Cory Booth", "Male");
            gender.Add("James Bailey", "Female");

            loginID.Add("Sean Jacobson", "sean2");
            loginID.Add("Phyllis Allen", "phyllis0");
            loginID.Add("Marvin Allen", "marvin0");
            loginID.Add("Michael Allen", "michael10");
            loginID.Add("Cecil Allison", "cecil0");
            loginID.Add("Oscar Alpuerto", "oscar0");
            loginID.Add("Sandra Altamirano", "sandra1");
            loginID.Add("Selena Alvarad", "selena0");
            loginID.Add("Emilio Alvaro", "emilio0");
            loginID.Add("Maxwell Amland", "maxwell0");
            loginID.Add("Mae Anderson", "mae0");
            loginID.Add("Ramona Antrim", "ramona0");
            loginID.Add("Sabria Appelbaum", "sabria0");
            loginID.Add("Hannah Arakawa", "hannah0");
            loginID.Add("Kyley Arbelaez", "kyley0");
            loginID.Add("Tom Johnston", "tom1");
            loginID.Add("Thomas Armstrong", "thomas1");
            loginID.Add("John Arthur", "john6");
            loginID.Add("Chris Ashton", "chris3");
            loginID.Add("Teresa Atkinson", "teresa0");
            loginID.Add("John Ault", "john7");
            loginID.Add("Robert Avalos", "robert2");
            loginID.Add("Stephen Ayers", "stephen1");
            loginID.Add("Phillip Bacalzo", "phillip0");
            loginID.Add("Gustavo Achong", "gustavo0");
            loginID.Add("Catherine Abel", "catherine0");
            loginID.Add("Kim Abercrombie", "kim2");
            loginID.Add("Humberto Acevedo", "humberto0");
            loginID.Add("Pilar Ackerman", "pilar1");
            loginID.Add("Frances Adams", "frances0");
            loginID.Add("Margar Smith", "margaret0");
            loginID.Add("Carla Adams", "carla0");
            loginID.Add("Jay Adams", "jay1");
            loginID.Add("Ronald Adina", "ronald0");
            loginID.Add("Samuel Agcaoili", "samuel0");
            loginID.Add("James Aguilar", "james2");
            loginID.Add("Robert Ahlering", "robert1");
            loginID.Add("Francois Ferrier", "françois1");
            loginID.Add("Kim Akers", "kim3");
            loginID.Add("Lili Alameda", "lili0");
            loginID.Add("Amy Alberts", "amy1");
            loginID.Add("Anna Albright", "anna0");
            loginID.Add("Milton Albury", "milton0");
            loginID.Add("Paul Alcorn", "paul2");
            loginID.Add("Gregory Alderson", "gregory0");
            loginID.Add("J. Phillip Alexander", "jphillip0");
            loginID.Add("Michelle Alexander", "michelle0");
            loginID.Add("Daniel Blanco", "daniel0");
            loginID.Add("Cory Booth", "cory0");
            loginID.Add("James Bailey", "james3");

        }

        string[] title = new string[]
   {
            "Marketing Assistant",
            "Engineering Manager",
            "Senior Tool Designer",
            "Tool Designer",
            "Marketing Manager",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Design Engineer",
            "Production Technician - WC10",
            "Design Engineer",
            "Vice President of Engineering",
            "Production Technician - WC10",
            "Production Supervisor - WC50",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Technician - WC30",
            "Production Control Manager",
            "Production Technician - WC45",
            "Production Technician - WC45",
            "Production Technician - WC30",
            "Production Supervisor - WC10",
            "Production Technician - WC20",
            "Production Technician - WC40",
            "Network Administrator",
            "Production Technician - WC50",
            "Human Resources Manager",
            "Production Technician - WC40",
            "Production Technician - WC30",
            "Production Technician - WC30",
            "Stocker",
            "Shipping and Receiving Clerk",
            "Production Technician - WC50",
            "Production Technician - WC60",
            "Production Supervisor - WC50",
            "Production Technician - WC20",
            "Production Technician - WC45",
            "Quality Assurance Supervisor",
            "Information Services Manager",
            "Production Technician - WC50",
            "Master Scheduler",
            "Production Technician - WC40",
            "Marketing Specialist",
            "Recruiter",
            "Production Technician - WC50",
            "Maintenance Supervisor",
            "Production Technician - WC30",
   };

        string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
            "Kyley Arbelaez",
            "Tom Johnston",
            "Thomas Armstrong",
            "John Arthur",
            "Chris Ashton",
            "Teresa Atkinson",
            "John Ault",
            "Robert Avalos",
            "Stephen Ayers",
            "Phillip Bacalzo",
            "Gustavo Achong",
            "Catherine Abel",
            "Kim Abercrombie",
            "Humberto Acevedo",
            "Pilar Ackerman",
            "Frances Adams",
            "Margar Smith",
            "Carla Adams",
            "Jay Adams",
            "Ronald Adina",
            "Samuel Agcaoili",
            "James Aguilar",
            "Robert Ahlering",
            "Francois Ferrier",
            "Kim Akers",
            "Lili Alameda",
            "Amy Alberts",
            "Anna Albright",
            "Milton Albury",
            "Paul Alcorn",
            "Gregory Alderson",
            "J. Phillip Alexander",
            "Michelle Alexander",
            "Daniel Blanco",
            "Cory Booth",
            "James Bailey"
        };

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isdisposable)
        {
            if (Employees != null)
            {
                Employees.Clear();
            }
        }
    }

    public class OrderInfoViewModel : NotificationObject
    {
        static int countrycount;
        static int discountcount = 2;
        Random randomValue = new Random();
        int count = 100;

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        Dictionary<string, string[]> shipCities = new Dictionary<string, string[]>();

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoViewModel"/> class.
        /// </summary>
        public OrderInfoViewModel()
        {
            this.OrderedDates = GetDateBetween(2008, 2012, count);
            this.OrdersAdd(100);
            SetShipCity();
            this.PopulateData();
            productCollection = GetProducts();
            date = DateTime.Now;
        }

        private void OrdersAdd(int count)
        {
            ord.Add(new OrderInfo(10000, 239800, 12, 5, 10, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Newyork"));
            ord.Add(new OrderInfo(10000, 587929, 14, 10, 2, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Washington"));
            ord.Add(new OrderInfo(10000, 299913, 18, 5, 10, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "London"));

            ord.Add(new OrderInfo(10001, 445654, 23, 76, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Brisbane"));
            ord.Add(new OrderInfo(10001, 690871, 45, 23, 5, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Durban"));
            ord.Add(new OrderInfo(10001, 434762, 45, 16, 3, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Auckland"));
            ord.Add(new OrderInfo(10001, 989875, 23, 15, 2, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Wellington"));
            ord.Add(new OrderInfo(10002, 723480, 7, 6, 4, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Newyork"));
            ord.Add(new OrderInfo(10002, 245683, 30, 5, 2, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10003, 213463, 73, 9, 3, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Brisbane"));
            ord.Add(new OrderInfo(10003, 890898, 11, 8, 7, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Perth"));
            ord.Add(new OrderInfo(10003, 167590, 150, 1, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Durban"));
            ord.Add(new OrderInfo(10009, 469879, 35, 4, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Brisbane"));
            ord.Add(new OrderInfo(10009, 254389, 31, 7, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Perth"));
            ord.Add(new OrderInfo(10010, 790859, 23, 3, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Auckland"));
            ord.Add(new OrderInfo(10010, 565560, 65, 4, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Wellington"));
            ord.Add(new OrderInfo(10010, 345767, 15, 5, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Manchester"));
            ord.Add(new OrderInfo(10010, 290898, 31, 1, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Durban"));
            ord.Add(new OrderInfo(10011, 667876, 46, 2, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "London"));
            ord.Add(new OrderInfo(10011, 345676, 45, 4, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10011, 289780, 41, 7, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Washington"));
            ord.Add(new OrderInfo(10013, 195678, 80, 2, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10013, 204345, 111, 1, 7, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Auckland"));
            ord.Add(new OrderInfo(10021, 548908, 35, 2, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Brisbane"));
            ord.Add(new OrderInfo(10021, 634567, 46, 7, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Perth"));
            ord.Add(new OrderInfo(10021, 275467, 99, 5, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Auckland"));
            ord.Add(new OrderInfo(10022, 598907, 80, 3, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Wellington"));
            ord.Add(new OrderInfo(10022, 605678, 111, 1, 7, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Manchester"));
            ord.Add(new OrderInfo(10022, 472345, 35, 9, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Durban"));
            ord.Add(new OrderInfo(10032, 445678, 35, 6, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "London"));
            ord.Add(new OrderInfo(10032, 690909, 46, 8, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10034, 174356, 99, 1, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Washington"));
            ord.Add(new OrderInfo(10034, 196789, 80, 5, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10034, 206578, 111, 3, 7, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "London"));
            ord.Add(new OrderInfo(10042, 454578, 35, 1, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10042, 489076, 35, 9, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Washington"));
            ord.Add(new OrderInfo(10045, 667890, 46, 7, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10045, 174356, 99, 3, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "London"));
            ord.Add(new OrderInfo(10045, 199890, 80, 6, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Melbourne"));
            ord.Add(new OrderInfo(10045, 204356, 111, 1, 7, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Perth"));
            ord.Add(new OrderInfo(10056, 489087, 35, 2, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Brisbane"));
            ord.Add(new OrderInfo(10056, 443567, 35, 7, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Perth"));
            ord.Add(new OrderInfo(10056, 612367, 46, 4, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Auckland"));
            ord.Add(new OrderInfo(10067, 178796, 99, 4, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Wellington"));
            ord.Add(new OrderInfo(10067, 195468, 80, 2, 0, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Manchester"));
            ord.Add(new OrderInfo(10067, 207657, 111, 1, 7, CustomerID[r.Next(15)], this.OrderedDates[r.Next(count - 1)], "Durban"));
        }

        #endregion

        #region Properties 

        private ObservableCollection<OrderInfo> _ordersDetails = new ObservableCollection<OrderInfo>();

        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderInfo> OrdersDetails
        {
            get { return _ordersDetails; }
        }

        private ObservableCollection<string> productCollection;
        /// <summary>
        /// Get or set the ProductName
        /// </summary>
        public ObservableCollection<string> ProductCollection
        {
            get
            {
                return productCollection;
            }

        }
        #endregion



        #region Method

        /// <summary>
        /// Populates the data.
        /// </summary>
        private void PopulateData()
        {
            for (int i = 0; i < 100; i++)
            {
                var shipcountry = ShipCountry[randomValue.Next(0, 5)];
                var shipcitycoll = shipCities[shipcountry];

                OrderInfo orderInfo = new OrderInfo();
                orderInfo.OrderID = 10000 + i;
                orderInfo.ProductID = 1000 + i;
                orderInfo.CustomerID = CustomerID[randomValue.Next(0, 14)];
                orderInfo.ProductName = ProductName[randomValue.Next(0, 47)];
                orderInfo.UnitPrice = randomValue.Next(10, 500);
                orderInfo.Quantity = randomValue.Next(10, 50);
                orderInfo.Discount = (double)randomValue.Next(40);
                orderInfo.Freight = Math.Round(Freight[randomValue.Next(0, 11)], 2);
                orderInfo.OrderDate = new DateTime(randomValue.Next(2004, 2005), randomValue.Next(1, 06), randomValue.Next(1, 15));
                orderInfo.ShippedDate = new DateTime(randomValue.Next(2004, 2005), randomValue.Next(06, 12), randomValue.Next(16, 28));
                orderInfo.ShipPostalCode = PostalCode[randomValue.Next(0, 9)];
                orderInfo.ShipAddress = shipcountry;
                orderInfo.Expense = randomValue.Next(2000, 4000);
                orderInfo.ShipName = ShipName[randomValue.Next(0, 97)];
                orderInfo.CompanyName = CompanyName[randomValue.Next(0, 2)];
                orderInfo.UnitsInStock = (short)randomValue.Next(1, 40);
                orderInfo.ShipCity = shipcitycoll[randomValue.Next(shipcitycoll.Length - 1)];
                orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
                orderInfo.ShipCityID = randomValue.Next(100, 200);
                orderInfo.ContactNumber = 9991121234 + i;
                orderInfo.OrderDetails = getorder(orderInfo.OrderID);
                orderInfo.NoOfOrders = discountcount + 6 / 100;
                if (discountcount > 16)
                    discountcount = 7;
                orderInfo.SupplierID = countrycount % 3 == 0 ? 1 : countrycount % 3;
                if (countrycount % 3 == 0 || countrycount % 9 == 0)
                    orderInfo.ImageLink = "US.jpg";
                else if (countrycount % 5 == 0 || countrycount % 17 == 0)
                    orderInfo.ImageLink = "Japan.jpg";
                else
                    orderInfo.ImageLink = "UK.jpg";

                countrycount++;
                discountcount += 3;
                orderInfo.IsShipped = randomValue.Next() % 2 == 0 ? true : false;
                _ordersDetails.Add(orderInfo);
            }
        }

        private List<DateTime> OrderedDates;
        Random r = new Random();
        List<OrderInfo> ord = new List<OrderInfo>();

        private static ObservableCollection<string> GetProducts()
        {
            ObservableCollection<string> products = new ObservableCollection<string>();
            products.Add("Alice Mutton");
            products.Add("Boston Crab Meat");
            products.Add("Raclette Courdavault");
            products.Add("Vegie-spread");
            products.Add("Tarte au sucre");
            products.Add("Valkoinen suklaa");
            products.Add("Perth Pasties");
            products.Add("Tofu");
            products.Add("Manjimup Dried Apples");
            products.Add("Ipoh Coffee");
            products.Add("Carnarvon Tigers");
            products.Add("Inlagd Sill");
            products.Add("Steeleye Stout");
            products.Add("Carnarvon Tigers");
            products.Add("Queso Cabrales");
            products.Add("Longlife Tofu");
            products.Add("Konbu");
            return products;
        }

        /// <summary>
        /// Gets the date between.
        /// </summary>
        /// <param name="startYear">The start year.</param>
        /// <param name="EndYear">The end year.</param>
        /// <param name="Count">The count.</param>
        /// <returns></returns>
        private List<DateTime> GetDateBetween(int startYear, int EndYear, int Count)
        {
            List<DateTime> date = new List<DateTime>();
            Random d = new Random(1);
            Random m = new Random(2);
            Random y = new Random(startYear);
            for (int i = 0; i < Count; i++)
            {
                int year = y.Next(startYear, EndYear);
                int month = m.Next(3, 13);
                int day = d.Next(1, 31);

                date.Add(new DateTime(year, month, day));
            }
            return date;
        }

        public ObservableCollection<OrderInfo> getorder(int i)
        {
            ObservableCollection<OrderInfo> order = new ObservableCollection<OrderInfo>();
            foreach (var or in ord)
                if (or.OrderID == i)
                    order.Add(or);
            return order;
        }

        #endregion

        #region Collections

        /// <summary>
        /// Sets the ship city.
        /// </summary>
        private void SetShipCity()
        {
            string[] argentina = new string[] { "Buenos Aires" };

            string[] austria = new string[] { "Graz", "Salzburg" };

            string[] belgium = new string[] { "Bruxelles", "Charleroi" };

            string[] brazil = new string[] { "Campinas", "Resende", "Rio de Janeiro", "São Paulo" };

            string[] canada = new string[] { "Montréal", "Tsawassen", "Vancouver" };

            string[] denmark = new string[] { "Århus", "København" };

            string[] finland = new string[] { "Helsinki", "Oulu" };

            string[] france = new string[] { "Lille", "Lyon", "Marseille", "Nantes", "Paris", "Reims", "Strasbourg", "Toulouse", "Versailles" };

            string[] germany = new string[] { "Aachen", "Berlin", "Brandenburg", "Cunewalde", "Frankfurt a.M.", "Köln", "Leipzig", "Mannheim", "München", "Münster", "Stuttgart" };

            string[] ireland = new string[] { "Cork" };

            string[] italy = new string[] { "Bergamo", "Reggio Emilia", "Torino" };

            string[] mexico = new string[] { "México D.F." };

            string[] norway = new string[] { "Stavern" };

            string[] poland = new string[] { "Warszawa" };

            string[] portugal = new string[] { "Lisboa" };

            string[] spain = new string[] { "Barcelona", "Madrid", "Sevilla" };

            string[] sweden = new string[] { "Bräcke", "Luleå" };

            string[] switzerland = new string[] { "Bern", "Genève" };

            string[] uk = new string[] { "Colchester", "Hedge End", "London" };

            string[] usa = new string[] { "Albuquerque", "Anchorage", "Boise", "Butte", "Elgin", "Eugene", "Kirkland", "Lander", "Portland", "San Francisco", "Seattle", "Walla Walla" };

            string[] venezuela = new string[] { "Barquisimeto", "Caracas", "I. de Margarita", "San Cristóbal" };

            shipCities.Add("Argentina", argentina);
            shipCities.Add("Austria", austria);
            shipCities.Add("Belgium", belgium);
            shipCities.Add("Brazil", brazil);
            shipCities.Add("Canada", canada);
            shipCities.Add("Denmark", denmark);
            shipCities.Add("Finland", finland);
            shipCities.Add("France", france);
            shipCities.Add("Germany", germany);
            shipCities.Add("Ireland", ireland);
            shipCities.Add("Italy", italy);
            shipCities.Add("Mexico", mexico);
            shipCities.Add("Norway", norway);
            shipCities.Add("Poland", poland);
            shipCities.Add("Portugal", portugal);
            shipCities.Add("Spain", spain);
            shipCities.Add("Sweden", sweden);
            shipCities.Add("Switzerland", switzerland);
            shipCities.Add("UK", uk);
            shipCities.Add("USA", usa);
            shipCities.Add("Venezuela", venezuela);

        }

        string[] CustomerID = new string[]
      {
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
             "BLONP",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "FOLIG",
            "WELLI",
            "ALFKI",

      };

        double[] Freight = new double[]
        {
            4.45, 10.98, 17.67, 50.87, 20.12, 36.19, 49.21, 79.45, 18.59, 3.01, 4.13, 74,22
        };


        string[] ProductName = new string[]
       {
            "Alice Mutton",
            "NuNuCa Nub-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute Semmelknodel",
            "Konbu",
            "Wimmers gute Semmelknödel",
            "Gorgonzola Telino",
            "Chartreuse verte",
            "Fløtemysost",
            "Carnarvon Tigers",
            "Thüringer Rostbratwurst",
            "Vegie-spread",
            "Tarte au sucre",
            "Valkoinen suklaa",
            "Queso Manchego La Pastora",
            "Perth Pasties",
            "Vegie-spread",
            "Tofu",
            "Sir Rodney's Scones",
            "Manjimup Dried Apples",
            "Tunnbröd",
            "Manjimup Dried Apples",
            "Ipoh Coffee",
            "Fløtemysost",
            "Carnarvon Tigers",
            "Teatime Chocolate Biscuits",
            "Inlagd Sill",
            "Teatime Chocolate Biscuits",
            "Steeleye Stout",
            "Boston Crab Meat",
            "Jack's New England Clam Chowder",
            "Ipoh Coffee",
            "Carnarvon Tigers",
            "Queso Cabrales",
            "Guaraná Fantástica",
            "Röd Kaviar",
            "Longlife Tofu",
            "Sirop d'érable",
            "Tarte au sucre",
            "Scottish Longbreads",
            "Spegesild",
            "Wimmers gute Semmelknödel",
            "Rhönbräu Klosterbier",
            "Queso Cabrales",
            "Valkoinen suklaa",
            "Rhönbräu Klosterbier",
            "Northwoods Cranberry Sauce",
            "Pavlova"
       };

        string[] ShipName = new string[]
        {
            "Franchi S.p.A.",
            "Mère Paillarde",
            "Folk och fä HB",
            "Simons bistro",
            "Vaffeljernet",
            "Wartian Herkku",
            "Franchi S.p.A",
            "Morgenstern Gesundkost",
            "Furia Bacalhau e Frutos do Mar",
            "Seven Seas Imports",
            "Simons bistro",
            "Wellington Importadora",
            "LINO-Delicateses",
            "Richter Supermarkt",
            "GROSELLA-Restaurante",
            "Piccolo und mehr",
            "Folies gourmandes",
            "Blondel père et fils",
            "Rattlesnake Canyon Grocery",
            "Magazzini Alimentari Riuniti",
            "Vins et alcools Chevalier",
            "Ernst Handel",
            "La maison d'Asie",
            "Toms Spezialitäten",
            "Rattlesnake Canyon Grocery",
            "Morgenstern Gesundkost",
            "Ernst Handel",
            "Antonio Moreno Taquería ",
            "Santé Gourmet",
            "LILA-Supermercado",
            "Suprêmes délices",
            "Bólido Comidas preparadas",
            "Ottilies Käseladen	",
            "Eastern Connection",
            "HILARIÓN-Abastos",
            "Centro comercial Moctezuma ",
            "Vaffeljernet",
            "Old World Delicatessen",
            "Mère Paillarde",
            "White Clover Markets",
            "HILARIÓN-Abastos",
            "Folk och fä HB",
            "LINO-Delicateses",
            "Antonio Moreno Taquería",
            "Berglunds snabbköp",
            "Santé Gourmet",
            "Morgenstern Gesundkost",
            "HILARIÓN-Abastos",
            "Toms Spezialitäten",
            "Bólido Comidas preparadas",
            "Folk och fä HB",
            "Save-a-lot Markets",
            "Wartian Herkku",
            "Ricardo Adocicados",
            "Blondel père et fils",
            "LILA-Supermercado",
            "The Cracker Box",
            "Hungry Owl All-Night Grocers",
            "LILA-Supermercado ",
            "Seven Seas Imports",
            "Eastern Connection",
            "Alfred's Futterkiste",
            "Hungry Owl All-Night Grocers",
            "Vaffeljernet",
            "Save-a-lot Markets",
            "Wartian Herkku",
            "France restauration",
            "Piccolo und mehr",
            "La maison d'Asie",
            "Hungry Owl All-Night Grocers",
            "Folk och fä HB",
            "Hungry Owl All-Night Grocers",
            "Chop-suey Chinese",
            "Spécialités du monde",
            "La maison d'Asie",
            "Richter Supermarkt	",
            "Suprêmes délices",
            "Bottom-Dollar Markets	",
            "Chop-suey Chinese",
            "Godos Cocina Típica ",
            "Suprêmes délices",
            "La maison d'Asie",
            "Santé Gourmet",
            "Franchi S.p.A",
            "Mère Paillarde",
            "LINO-Delicateses",
            "Galería del gastronómo",
            "B's Beverages ",
            "Ricardo Adocicados ",
            "Ernst Handel	",
            "QUICK-Stop ",
            "Rattlesnake Canyon Grocery",
            "Lazy K Kountry Store",
            "Richter Supermarkt",
            "Eastern Connection",
            "Save-a-lot Markets ",
            "Magazzini Alimentari Riuniti"
        };

        string[] ShipCountry = new string[]
        {
            "Argentina",
            "Austria",
            "Belgium",
            "Brazil",
            "Canada",
            "Denmark",
            "Finland",
            "France",
            "Germany",
            "Ireland",
            "Italy",
            "Mexico",
            "Norway",
            "Poland",
            "Portugal",
            "Spain",
            "Sweden",
            "Switzerland",
            "UK",
            "USA",
            "Venezuela"
        };

        string[] CompanyName = new string[]
        {
            "Federal Shipping",
            "Speedy Express",
            "United Package"
        };

        internal string[] EmployeeName = new string[]
            {
                "Sean Jacobson",
                "Phyllis Allen",
                "Marvin Allen",
                "Michael Allen",
                "Cecil Allison",
                "Oscar Alpuerto",
                "Sandra Altamirano",
                "Selena Alvarad",
                "Emilio Alvaro",
                "Maxwell Amland",
                "Mae Anderson",
                "Ramona Antrim",
                "Sabria Appelbaum",
                "Hannah Arakawa",
                "Kyley Arbelaez",
                "Tom Johnston",
                "Thomas Armstrong",
                "John Arthur",
                "Chris Ashton",
                "Teresa Atkinson",
                "John Ault",
                "Robert Avalos",
                "Stephen Ayers",
                "Phillip Bacalzo",
                "Gustavo Achong",
                "Catherine Abel",
                "Kim Abercrombie",
                "Humberto Acevedo",
                "Pilar Ackerman",
                "Frances Adams",
                "Margar Smith",
                "Carla Adams",
                "Jay Adams",
                "Ronald Adina",
                "Samuel Agcaoili",
                "James Aguilar",
                "Robert Ahlering",
                "Francois Ferrier",
                "Kim Akers",
                "Lili Alameda",
                "Amy Alberts",
                "Anna Albright",
                "Milton Albury",
                "Paul Alcorn",
                "Gregory Alderson",
                "J. Phillip Alexander",
                "Michelle Alexander",
                "Daniel Blanco",
                "Cory Booth",
                "James Bailey"
            };

        string[] PostalCode = new string[]
        {
            "10100",
            "H1J 1c3",
            "S-844 67",
            "1734",
            "8200",
            "90110",
            "04179",
            "1675",
            "OX15 4NB",
            "08737-363",
            "4980",
            "1204",
            "1081",
            "5020"
        };
        #endregion
    }
}
