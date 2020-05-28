using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace OrderApi
{
   public class OrderService
    {
        [Key]
        public int OrderServiceID { get; set; }
        public List<Order> Order_list = new List<Order>();//声明一个列表用于保存Order数据
        public void DeleteOrder(double order_ID)
        {
            try
            {
                for (int i = 0; i < Order_list.Count; i++)
                {
                    if (order_ID == Order_list[i].Order_ID)
                    {
                        Order_list.Remove(Order_list[i]);//删除订单
                        break;//成功删除订单后结束循环
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("删除订单失败", e);
            }
        }
        public void ReviseOrder(double order_ID, Order new_order)//根据ID删除旧Order,传入新Order
        {
            try
            {
                for (int i = 0; i < Order_list.Count; i++)
                {
                    if (Order_list[i].Order_ID == order_ID)
                    {
                        Order_list.Remove(Order_list[i]);
                        Order_list.Add(new_order);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("修改订单失败", e);
            }
        }

        public bool Save_Order(Order order)//完成下单
        {
            bool flag = true;
            for (int i = 0; i < Order_list.Count; i++)
            {
                if (Order_list[i].Equals(order))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true&&order !=null)
            {
                Order_list.Add(order);
                SortOrderList();
            }
            return flag;
        }
        public void SortOrderList()
        {
            Order_list.Sort();//让订单按订单号进行排序
        }

        /*实现各种查询语句，Linq*/
        public List<Order> Check_By_Order_custormet_Name(String Order_custormet_Name)
        {
            var query = from order in Order_list
                        where order.Order_custormet_Name == Order_custormet_Name
                        orderby order.Order_total_consumption
                        select order;
            return query.ToList();
        }
        //返回查询用户名下的所有订单
        /*public List<Order> Check_By_Order_address(String Order_address)
        {
            var query = from order in Order_list
                        where order.Order_address == Order_address
                        orderby order.Order_total_consumption
                        select order;
            return query.ToList();
        }*/
        //返回查询订单地址的所有订单
        /*public List<Order> Check_By_Custormer_ID(double Custormer_ID)
        {
            var query = from order in Order_list
                        where order.Custormer_ID == Custormer_ID
                        orderby order.Order_total_consumption
                        select order;
            return query.ToList();
        }*/
        //返回查询用户ID下的所有订单
        public List<Order> Check_By_Order_date(DateTime Order_date)
        {
            var query = from order in Order_list
                        where order.Order_date == Order_date
                        orderby order.Order_total_consumption
                        select order;
            return query.ToList();
        }
        //返回查询订单时间的所有订单
        public List<Order> Check_By_name_of_item(string name_of_item)
        {
            var query = Order_list.Where(
          order => {
              foreach (OrderItem item in order.Orderitem_list)
              {
                  if (item.name_of_item == name_of_item) return true;
              }
              return false;
          }).OrderBy(order => order.Order_total_consumption);
            return query.ToList();
        }
        //按订单是否包含特定货物而返回
        public void Export(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Order_list);
            }
        }
        //将所有订单以xml的形式导出
        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!Order_list.Contains(order))
                    {
                        Order_list.Add(order);
                    }
                });
            }
        }
        /*
        public void Import(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                Order_list = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
        */
    }
}
