using OOP1;

Product product1 = new Product();

product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 20;


Product product2 = new Product { Id = 2,CategoryId=4,ProductName="Bilgisayar",UnitPrice=2000,UnitsInStock=45};


ProductManager productManager=new ProductManager();
productManager.Add(product1);







