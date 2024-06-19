namespace DevPrime.Stream;
public class EventStream : EventStreamBase, IEventStream
{
    public override void StreamEvents()
    {
        
        Subscribe<IPaymentService, OrderCreatedEventDTO>("Stream1",
            "OrderCreated", (dto, paymentService, Dp) =>
            {
                Dp.Observability.Log("Evento recebido");

                var command = new Payment()
                {
                    CustomerName = dto.CustomerName,
                    OrderID = dto.OrderID,
                    Value = dto.Value
                };
                paymentService.Add(command);           


            });
    }
}