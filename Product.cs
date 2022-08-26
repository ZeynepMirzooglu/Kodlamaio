using System;

  class Program {
    public static void Main (string[] args) {
   Product product=new Product();
    product.ProductName="Laptop";
    product.ProductDescription="Dizüstü bilgisayar";
    product.UnitPrice=8000;
    product.QuantityPerUnit=6;

     Product product1=new Product();
    product1.ProductName="Mouse";
    product1.ProductDescription="Wireless Mouse";
    product1.UnitPrice=987;
    product1.QuantityPerUnit=5;

     Product product2=new Product();
    product2.ProductName="Keyboard";
    product2.ProductDescription="Bilgisayar klavyesi";
    product2.UnitPrice=5000;
    product2.QuantityPerUnit=12;
    
     Product product3=new Product();
    product3.ProductName="Mic";
    product3.ProductDescription="Mikrofon";
    product3.UnitPrice=500;
    product3.QuantityPerUnit=23;

    Product[] products=new Product[]{product,product1,product2,product3};
    Console.WriteLine("Foreach döngüsü!");
    Console.WriteLine("***********");
    foreach(var prod in products)
    {
      Console.WriteLine("Ürünün adı :"+prod.ProductName+"\n"+"Ürünün açıklaması :"+ 
      prod.ProductDescription+ " "+"\n"+"Ürünün fiyatı = "+prod.UnitPrice+" "+"\n"+ 
       "Stok adeti : "+prod.QuantityPerUnit);
    }
    Console.WriteLine("***********");
    Console.WriteLine("For döngüsü!");
    Console.WriteLine("***********");
    for(int i=0;i<products.Length;i++)
    {
      Console.WriteLine(products[i].ProductName+"  "+ products[i].UnitPrice);
    }
   Console.WriteLine("***********");
   Console.WriteLine("While döngüsü"); 
   Console.WriteLine("***********");
    int k=0;
    while(k<products.Length)
    {
      Console.WriteLine(products[k].ProductName+ " : " + 
       products[k].QuantityPerUnit);
      k++;
    }
    Console.WriteLine("***********");
     
  }
    
    

 } 
  class Product
  {
    public string ProductName {get;set;}
    public string ProductDescription{get;set;}
    public int UnitPrice{get;set;}
    public int QuantityPerUnit{get;set;}
    
  }
