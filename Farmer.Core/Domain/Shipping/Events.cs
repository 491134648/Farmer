namespace Farmer.Core.Domain
{
    /// <summary>
    /// 配送事件
    /// </summary>
    public class ShipmentSentEvent
    {
        private readonly Shipment _shipment;

        public ShipmentSentEvent(Shipment shipment)
        {
            this._shipment = shipment;
        }

        public Shipment Shipment
        {
            get { return _shipment; }
        }
    }

    /// <summary>
    /// 配送交付时间
    /// </summary>
    public class ShipmentDeliveredEvent
    {
        private readonly Shipment _shipment;

        public ShipmentDeliveredEvent(Shipment shipment)
        {
            this._shipment = shipment;
        }

        public Shipment Shipment
        {
            get { return _shipment; }
        }
    }
}