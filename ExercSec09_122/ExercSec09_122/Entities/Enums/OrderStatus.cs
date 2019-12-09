using System;


namespace ExercSec09_122.Entities.Enums
{
    enum OrderStatus : int
    {
        pendingPayment = 0,
        processing = 1,
        shipped = 2,
        delivered = 3

    }
}
