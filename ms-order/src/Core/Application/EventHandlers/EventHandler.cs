namespace Application.EventHandlers;
public class EventHandler : IEventHandler
{
    public EventHandler(IHandler handler)
    {
        handler.Add<OrderCreated, OrderCreatedEventHandler>();
        handler.Add<DeleteOrder, DeleteOrderEventHandler>();
        handler.Add<CreateOrder, CreateOrderEventHandler>();
        handler.Add<OrderUpdated, OrderUpdatedEventHandler>();
        handler.Add<OrderGetByID, OrderGetByIDEventHandler>();
        handler.Add<OrderDeleted, OrderDeletedEventHandler>();
        handler.Add<UpdateOrder, UpdateOrderEventHandler>();
        handler.Add<OrderGet, OrderGetEventHandler>();
    }
}