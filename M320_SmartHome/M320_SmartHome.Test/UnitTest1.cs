namespace M320_SmartHome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Wettersensor testSensor1 = new();
            Wohnung testWohnung1 = new(testSensor1);

            testWohnung1.SetTemperaturvorgabe("BadWC", 25);
            testWohnung1.SetTemperaturvorgabe("Kueche", 22);
            testWohnung1.SetTemperaturvorgabe("Schlafen", 23);
            testWohnung1.SetTemperaturvorgabe("Wohnen", 24);
            testWohnung1.SetTemperaturvorgabe("Wintergarten", 18);

            testWohnung1.SetPersonenImZimmer("Kueche", true);
            testWohnung1.SetPersonenImZimmer("Schlafen", false);
            testWohnung1.SetPersonenImZimmer("Wohnen", true);
            testWohnung1.SetPersonenImZimmer("Wintergarten", true);

            for (var i = 0; i < TimeSpan.FromHours(1).TotalMinutes; i++)
            {
                testWohnung1.GenerateWetterdaten();
            }
        }
    }
}