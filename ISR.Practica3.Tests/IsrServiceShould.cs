using ISR.Practica3.Core.Services;
namespace ISR.Practica3.Tests;

public class IsrServiceShould
{
    [Fact]
    public void WhenUpperLimitIs_13500_return_517_46936()
    {
        var salary = new Core.Entities.Income() { Salary = 13500 };
        var expected = 517.46936;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);

}
    
     [Fact]
    public void WhenUpperLimitIs_15500_return_645()
    {
        var salary = new Core.Entities.Income() { Salary = 15500};
        var expected = 645.46936;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_10000_return_293_46936()
    {
        var salary = new Core.Entities.Income() { Salary = 10000};
        var expected = 293.46936;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_800672_return_182835()
    {
        var salary = new Core.Entities.Income() { Salary = 800672};
        var expected = 182835.0370;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_800750_return_182858()
    {
        var salary = new Core.Entities.Income() { Salary = 800750};
        var expected = 182858.4370;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_1100666_return_275355()
    {
        var salary = new Core.Entities.Income() { Salary = 1100666};
        var expected = 275355.8572;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_505420_return_1610070()
    {
        var salary = new Core.Entities.Income() { Salary = 5005420};
        var expected = 1610070.7145;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_7005045_return_239583_44()
    {
        var salary = new Core.Entities.Income() { Salary = 7005045};
        var expected = 2309939.4645;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenUpperLimitIs_511875_return_96195()
    {
        var salary = new Core.Entities.Income() { Salary = 511875};
        var expected = 96195.9370;
        var sut = new IsrService();
        var result = sut.ProcessIsr(salary);
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_3785100_return_1184089()
    {
        var salary = new Core.Entities.Income() { Salary = 3785100};
        var expected = 1184089.1230;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal((decimal)expected, result.Index);
        
    }
    
    [Fact]
    public void WhenLimiteSupiriorIs_408560_return_71803()
    {
        var salary = new Core.Entities.Income() { Salary = 408560};
        var expected = 71803.977248;
        var sut = new IsrService();

        var result = sut.ProcessIsr(salary);
        
        Assert.Equal((decimal)expected, result.Index);
    }
}