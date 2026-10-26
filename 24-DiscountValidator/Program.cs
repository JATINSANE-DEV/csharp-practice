double cartTotal = 1200;
double discountRate = 0.15;
double freeShippingThreshold = 1000.0;
double shippingFee = 100.0;
Console.WriteLine($"Original Cart Total : ₹{cartTotal}");

double finalTotal = cartTotal;
if(cartTotal>=freeShippingThreshold)
{
    double discountAmount = cartTotal*discountRate;
    finalTotal = cartTotal-discountAmount;
    shippingFee = 0.0;

    Console.WriteLine($"Discount Applied (15%) : -₹{discountAmount}");
    Console.WriteLine("Free Shipping Unlocked!");
}
else
{
    finalTotal += shippingFee;
    Console.WriteLine($"Shipping Fee Applied : +{shippingFee}");
}
Console.WriteLine($"\nFinal Payable Amount : ₹{finalTotal}");