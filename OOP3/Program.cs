using OOP3;
using System.Collections.Generic;

ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();

consumerLoanManager.Calculate();

MortgageLoanManager mortgageLoanManager= new MortgageLoanManager();

mortgageLoanManager.Calculate();

CarLoanManager carLoanManager= new CarLoanManager();    
carLoanManager.Calculate();


ICreditManager consumerLoanManager2 = new ConsumerLoanManager();
ICreditManager mortgageLoanManager2 = new MortgageLoanManager();
ICreditManager carLoanManager2 = new CarLoanManager();

ApplyManager applyManager = new ApplyManager();
ILoggerService databaseLoggerService = new DatabaseLoggerService();

Console.WriteLine("-------------------------------------------------------");

List<ICreditManager> krediler=new List<ICreditManager>() {mortgageLoanManager,consumerLoanManager,carLoanManager };
applyManager.ÖnBilgilendirmeYap(krediler);
Console.WriteLine("---------------------------------");
applyManager.Basvuruyap(consumerLoanManager2,new DatabaseLoggerService());
applyManager.Basvuruyap(carLoanManager2,new FileLoggerService());
applyManager.Basvuruyap(mortgageLoanManager2,databaseLoggerService);