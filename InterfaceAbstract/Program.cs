using System;
using InterfaceAbstract;
using InterfaceAbstract.Abstract;
using InterfaceAbstract.Concrete;


BaseCustomerManager    customerManager=new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = 2000, FirstName = "Ataberk", LastName = "Karadağ", NationalityId = 21344325432 });

