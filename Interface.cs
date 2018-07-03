using System;

namespace OOP
{
    public interface IShippingCalculator{
        //When members implemented should be with Public modifier
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator{
        public float CalculateShipping(Order order){
            if(order.TotalPrice < 30f)
                return order.TotalPrice * .1f;

            return 0;
        }
    }
}