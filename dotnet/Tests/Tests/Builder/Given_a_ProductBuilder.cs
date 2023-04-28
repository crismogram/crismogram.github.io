

[TestFixture]
public class Given_a_ProductBuilder
{
    private ProductBuilder _sut = new ProductBuilder();
    [Test]
    public void Then_Build_returns_null()
    {
        Assert.IsNull(_sut.Build());
    }

    [Test]
    public void Then_ForProduct_returns_the_expected_Product(){
        Assert.AreEqual("Product A",ProductBuilder.ForProduct("A").Build()!.Name);
        Assert.AreEqual("Product B",ProductBuilder.ForProduct("B").Build()!.Name);
        Assert.Throws<ArgumentException>(() => ProductBuilder.ForProduct("C"));
    }
}