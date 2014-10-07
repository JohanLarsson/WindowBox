namespace WindowBox
{
    using System;
    using System.Threading;

    public class Device
    {
        private readonly Timer _timer;
        private int _count = 0;
        public Device(string name)
        {
            Name = name;
            _timer = new Timer(CreatePacket, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

        public event EventHandler<HtmlPacket> SnoopedPacket;
        
        public string Name { get; private set; }
        
        protected virtual void OnSnoopedPacket(HtmlPacket e)
        {
            var handler = SnoopedPacket;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void CreatePacket(object _)
        {
            OnSnoopedPacket(new HtmlPacket(_count.ToString()));
            _count++;
        }
    }
}