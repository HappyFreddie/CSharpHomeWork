using Microsoft.EntityFrameworkCore;
namespace OrderApi{
public class OrderContext : DbContext{
    public OrderContext(DbContextOptions<OrderContext>options):base(options){
        this.Database.EnsureCreated();
    }
    //创建webapi项目的数据与普通的本地数据的context类的区别在于4-6行的代码
    public DbSet<OrderItem> OrderItems{get;set;}
    public DbSet<Order> Orders{get;set;}
    public DbSet<OrderService> OrderServices { get; set; }
}
}