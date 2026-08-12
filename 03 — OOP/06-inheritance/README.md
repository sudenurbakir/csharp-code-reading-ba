# Inheritance (Kalıtım)

Inheritance, bir class'ın başka bir class'ın özelliklerini ve davranışlarını miras almasını sağlar.

## Örnek

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ElectronicProduct : Product
{
    public int WarrantyMonths { get; set; }
}

ElectronicProduct, Product class'ından miras alır.

Bu nedenle ElectronicProduct:

- Name
- Price
- WarrantyMonths

özelliklerine sahip olabilir.

## BA Açısından

Inheritance, ortak özellikleri olan business nesnelerinin birbirleriyle olan ilişkisini anlamamıza yardımcı olabilir.

Örneğin:

Product
├── ElectronicProduct
├── ClothingProduct
└── FoodProduct

Burada Product ortak özellikleri temsil ederken, alt class'lar kendilerine özel özellikleri temsil eder.
