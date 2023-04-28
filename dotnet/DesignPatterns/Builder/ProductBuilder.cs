public class ProductBuilder : Builder<Product> {

    public static ProductBuilder ForProduct(string productType){
        switch (productType)
        {
            case "A":
                return ForProductA();
            case "B":
                return ForProductB();
            default:
                throw new ArgumentException($"Invalid product type '{productType}'.", nameof(productType));
        }
    }

    public static ProductBuilder ForProductA(){
        return new ProductBuilder() { Value = new Product("Product A") };
    }
    public static ProductBuilder ForProductB(){
        return new ProductBuilder() { Value = new Product("Product B") };
    }
}