namespace Farmer.Core.Domain
{
    /// <summary>
    /// �����¼�
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
    /// ���ͽ���ʱ��
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