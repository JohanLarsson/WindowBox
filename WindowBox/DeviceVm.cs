using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowBox
{
    using System.Collections.ObjectModel;
    using System.Net.Mime;
    using System.Windows;

    public class DeviceVm
    {
        private readonly ObservableCollection<HtmlPacket> _packets = new ObservableCollection<HtmlPacket>();
        public DeviceVm(Device device)
        {
            Device = device;
            Device.SnoopedPacket += (sender, packet) => Application.Current.Dispatcher.Invoke(() => Packets.Add(packet));
        }

        public Device Device { get; private set; }
        public ObservableCollection<HtmlPacket> Packets
        {
            get { return _packets; }
        }
        // Commands and stuff
    }
}
