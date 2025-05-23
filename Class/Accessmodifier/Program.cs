using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessmodifier
{
    class WaterHeater
    {
        protected int temperature;
        public void SetTemperature(int temperature)     // SetTemperature() 메소드는 -5~42사이의 값만 받아들이고. 이 범위를 벗어난 값에 대해서는 예외 발생 시킴
        {
            if ( temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;  // temperature 필드는 protected로 수식됐으므로 외부에서 직접 접근 할 수 없스빈다. 이렇게 public메소드를 통해 접근해야 한다.
        }
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);      // 여기서 예외발생하며, 밑에 행은 실행되지 않고 catch 블록으로 실행위치 이동함
                heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
