using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Devices.Sensors
{
    public class Accelerometer : SensorBase<AccelerometerReading>
    {
        public static bool IsSupported
        {
            get { return false; }
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
