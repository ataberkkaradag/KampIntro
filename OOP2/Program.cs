using OOP2;



//Gerçek müşteri -Tüzel müşteri


IndividualCustomer gercekMusteri=new IndividualCustomer();

gercekMusteri.MusteriNo = "325432";
gercekMusteri.Adi = "Ataberk";
gercekMusteri.Soyadi = "Karadag";

CorporateCustomer tuzelMusteri=new CorporateCustomer();

tuzelMusteri.Id = 2;
tuzelMusteri.MusteriNo = "324233";
tuzelMusteri.SirketAdi = "Apple";


Customer customer1 = new IndividualCustomer(); 
Customer customer2 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();

customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(gercekMusteri);
customerManager.Add(tuzelMusteri);