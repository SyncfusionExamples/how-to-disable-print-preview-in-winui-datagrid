using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDemoApp
{
    public class Employee : NotificationObject
    {
        private int _EmployeeID;
        private string _Name;
        private long _NationalIDNumber;
        private int _ContactID;
        private string _LoginID;
        private int _ManagerID;
        private string _Title;
        private DateTime _BirthDate;
        private string _MaritalStatus;
        private string _Gender;
        private DateTime _HireDate;
        private int _SickLeaveHours;
        private double _Salary;
        private bool employeeStatus;
        private int _rating;


        /// <summary>
        /// Gets or sets the employee ID.
        /// </summary>
        /// <value>The employee ID.</value>
        public int EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged(nameof(EmployeeID));
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.RaisePropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public long NationalIDNumber
        {
            get
            {
                return this._NationalIDNumber;
            }
            set
            {
                this._NationalIDNumber = value;
                this.RaisePropertyChanged(nameof(NationalIDNumber));
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this._Title = value;
                this.RaisePropertyChanged(nameof(Title));
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public int ContactID
        {
            get
            {
                return this._ContactID;
            }
            set
            {
                this._ContactID = value;
                this.RaisePropertyChanged(nameof(ContactID));
            }
        }

        /// <summary>
        /// Gets or sets the BirthDate.
        /// </summary>
        /// <value>The BirthDate.</value>
        public DateTime BirthDate
        {
            get
            {
                return this._BirthDate;
            }
            set
            {
                this._BirthDate = value;
                this.RaisePropertyChanged(nameof(BirthDate));
            }
        }

        /// <summary>
        /// Gets or sets the MaritalStatus.
        /// </summary>
        /// <value>The MaritalStatus.</value>
        public string MaritalStatus
        {
            get
            {
                return this._MaritalStatus;
            }
            set
            {
                this._MaritalStatus = value;
                this.RaisePropertyChanged(nameof(MaritalStatus));
            }
        }

        /// <summary>
        /// Gets or sets the Gender.
        /// </summary>
        /// <value>The Gender.</value>
        public string Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                this._Gender = value;
                this.RaisePropertyChanged(nameof(Gender));
            }
        }

        /// <summary>
        /// Gets or sets the HireDate.
        /// </summary>
        /// <value>The HireDate.</value>
        public DateTime HireDate
        {
            get
            {
                return this._HireDate;
            }
            set
            {
                this._HireDate = value;
                this.RaisePropertyChanged(nameof(HireDate));
            }
        }

        /// <summary>
        /// Gets or sets the SickLeaveHours.
        /// </summary>
        /// <value>The SickLeaveHours.</value>
        public int SickLeaveHours
        {
            get
            {
                return this._SickLeaveHours;
            }
            set
            {
                this._SickLeaveHours = value;
                this.RaisePropertyChanged(nameof(SickLeaveHours));
            }
        }

        /// <summary>
        /// Gets or sets the Salary.
        /// </summary>
        /// <value>The Salary.</value>
        public double Salary
        {
            get
            {
                return this._Salary;
            }
            set
            {
                this._Salary = value;
                this.RaisePropertyChanged(nameof(Salary));
            }
        }

        /// <summary>
        /// Gets or sets the LoginID.
        /// </summary>
        /// <value>The LogID.</value>
        public string LoginID
        {
            get
            {
                return _LoginID;
            }
            set
            {
                _LoginID = value;
                this.RaisePropertyChanged(nameof(LoginID));
            }
        }

        /// <summary>
        /// Gets or sets the ManagerID.
        /// </summary>
        /// <value>The ManagerID.</value>
        public int ManagerID
        {
            get
            {
                return _ManagerID;
            }
            set
            {
                _ManagerID = value;
                this.RaisePropertyChanged(nameof(ManagerID));
            }
        }

        /// <summary>
        /// Gets or sets the EmployeeStatus.
        /// </summary>
        /// <value>The EmployeeStatus.</value>
        public bool EmployeeStatus
        {
            get
            {
                return employeeStatus;
            }
            set
            {
                employeeStatus = value;
                this.RaisePropertyChanged(nameof(EmployeeStatus));
            }
        }

        /// <summary>
        /// Gets or sets the Rating.
        /// </summary>
        /// <value>The Rating.</value>
        public int Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                this.RaisePropertyChanged(nameof(Rating));
            }
        }
    }

    public class OrderInfo : NotificationObject
    {
        private int _OrderID;
        private string _CustomerID;
        private string _productName;
        private double _unitPrice;
        private DateTime _orderDate;
        private double _freight;
        private long _contactNumber;
        private string _shipcity;
        private string _shipCountry;
        private int _quantity;
        private DateTime shippedDate;
        private string _shipAddress;
        private string _shipName;
        private double _discount;
        private double _NoOfOrders;
        private int _supplierID;
        private short _unitsInStock;
        private TimeSpan _deliveryDelay;
        private string _shipPostalCode;
        private bool _isShipped;
        private int _productID;
        private string _CompanyName;
        private double _Expense;
        private string imageLink;
        private int _employeeID;
        private ObservableCollection<OrderInfo> orderDetails;
        static int count = 0;
        private List<OrderInfo> orderList;

        public OrderInfo()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetails"/> class.
        /// </summary>
        /// <param name="ord">The ord.</param>
        /// <param name="cusid">The custmer iD.</param>
        /// <param name="productName">The product name.</param>
        /// <param name="NoOfOrders">The no of orders.</param>
        /// <param name="country">The country.</param>
        /// <param name="ShipCity">The ship city ID.</param>
        public OrderInfo(int ord, string cusid, string productName, int NoOfOrders, string country, int shipCityID)
        {
            this._OrderID = ord;
            this._CustomerID = cusid;
            this._shipCountry = country;
            this._shipCityID = shipCityID;
            this._productName = productName;
            this._NoOfOrders = NoOfOrders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfo"/> class.
        /// </summary>
        /// <param name="ord">The ord.</param>
        /// <param name="prod">The prod.</param>
        /// <param name="unit">The unit.</param>
        /// <param name="quan">The quan.</param>
        /// <param name="disc">The disc.</param>
        public OrderInfo(int ord, int prod, decimal unit, Int16 quan, double disc, string cusid, DateTime ordDt, string city)
        {
            this._discount = disc;
            this._OrderID = ord;
            this._productID = prod;
            this._quantity = quan;
            this._unitPrice = (double)unit;
            this._CustomerID = cusid;
            this._orderDate = ordDt;
            this.ShipCity = city;
            this._deliveryDelay = ordDt.AddDays(quan - 1) - ordDt;
            if (count % 3 == 0)
                this.imageLink = "US.jpg";
            else if (count % 2 == 0)
                this.imageLink = "UK.jpg";
            else
                this.imageLink = "Japan.jpg";
            this._supplierID = count % 3 == 0 ? 1 : count % 3;
            count++;

        }
        public ObservableCollection<OrderInfo> OrderDetails
        {
            get
            {
                return this.orderDetails;
            }
            set
            {
                this.orderDetails = value;
                RaisePropertyChanged("OrderDetails");
            }
        }

        public List<OrderInfo> OrderList
        {
            get
            {
                return this.orderList;
            }
            set
            {
                this.orderList = value;
                RaisePropertyChanged("OrderList");
            }
        }

        public int OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                _OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }
        public int ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
                RaisePropertyChanged("ProductID");
            }
        }

        public int ShipCityID
        {
            get
            {
                return _shipCityID;
            }
            set
            {
                _shipCityID = value;
                RaisePropertyChanged("ShipCityID");
            }
        }
        public int EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                _CompanyName = value;
                RaisePropertyChanged("CompanyName");
            }
        }

        public int SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = value;
                RaisePropertyChanged("SupplierID");
            }
        }

        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>The name of the product.</value>
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                RaisePropertyChanged("ProductName");
            }
        }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>The unit price.</value>
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                RaisePropertyChanged("UnitPrice");
            }
        }

        public short UnitsInStock
        {
            get
            {
                return this._unitsInStock;
            }
            set
            {
                this._unitsInStock = value;
                this.RaisePropertyChanged("UnitsInStock");
            }
        }

        public double Expense
        {
            get
            {
                return this._Expense;
            }
            set
            {
                this._Expense = value;
                this.RaisePropertyChanged("Expense");
            }
        }

        /// <summary>
        /// Gets or sets the freight.
        /// </summary>
        /// <value>The freight.</value>
        public double Freight
        {
            get
            {
                return _freight;
            }
            set
            {
                _freight = value;
                RaisePropertyChanged("Freight");
            }
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        public double NoOfOrders
        {
            get
            {
                return _NoOfOrders;
            }
            set
            {
                _NoOfOrders = value;
                RaisePropertyChanged("NoOfOrders");
            }
        }

        /// <summary>
        /// Gets or sets the ImageLink.
        /// </summary>    
        public string ImageLink
        {
            get
            {
                return imageLink;
            }
            set
            {
                imageLink = value;
                RaisePropertyChanged("ImageLink");
            }
        }

        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>The discount.</value>
        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
                RaisePropertyChanged("Discount");
            }
        }

        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        /// <value>The order date.</value>
        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                RaisePropertyChanged("OrderDate");
            }
        }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        public long ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
                RaisePropertyChanged("ContactNumber");
            }
        }

        /// <summary>
        /// Gets or sets the ShipAddress.
        /// </summary>
        /// <value>
        /// The ShipAddress.
        /// </value>
        public string ShipAddress
        {
            get
            {
                return _shipAddress;
            }
            set
            {
                _shipAddress = value;
                RaisePropertyChanged("ShipAddress");
            }
        }

        /// <summary>
        /// Gets or sets the ShipCity.
        /// </summary>
        /// <value>
        /// The ShipCity.
        /// </value>
        public string ShipCity
        {
            get
            {
                return _shipcity;
            }
            set
            {
                _shipcity = value;
                RaisePropertyChanged("ShipCity");
            }
        }

        /// <summary>
        /// Gets or sets the ShipCountry.
        /// </summary>
        /// <value>
        /// The ShipCity.
        /// </value>
        public string ShipCountry
        {
            get
            {
                return _shipCountry;
            }
            set
            {
                _shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        public bool IsShipped
        {
            get { return _isShipped; }
            set
            {
                _isShipped = value;
                RaisePropertyChanged("IsShipped");
            }
        }

        public string ShipName
        {
            get { return _shipName; }
            set
            {
                _shipName = value;
                RaisePropertyChanged("ShipName");
            }
        }

        public DateTime ShippedDate
        {
            get { return shippedDate; }
            set
            {
                shippedDate = value;
                RaisePropertyChanged("ShippedDate");
            }
        }

        /// <summary>
        /// Gets or sets the ship postal code.
        /// </summary>
        /// <value>The ship postal code.</value>
        public string ShipPostalCode
        {
            get
            {
                return _shipPostalCode;
            }
            set
            {
                _shipPostalCode = value;
                RaisePropertyChanged("ShipPostalCode");
            }
        }


        public TimeSpan DeliveryDelay
        {
            get
            {
                return _deliveryDelay;
            }
            set
            {
                _deliveryDelay = value;
                RaisePropertyChanged("DeliveryDelay");
            }
        }

        private bool _isChecked;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is checked.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is checked; otherwise, <c>false</c>.
        /// </value>
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                RaisePropertyChanged("IsChecked");
            }
        }

        public string _name;
        private int _shipCityID;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
    }
}
