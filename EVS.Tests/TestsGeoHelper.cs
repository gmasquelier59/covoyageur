using EVS.Api.Helpers;

namespace EVS.Tests
{
    public class TestsGeoHelper
    {
        private double lilleLatitude = 50.6310733;
        private double lilleLongitude = 3.0056983;

        private double parisLatitude = 48.8588255;
        private double parisLongitude = 2.2646344;

        private double marseilleLatitude = 43.280227;
        private double marseilleLongitude = 5.2158397;

        private int distanceLilleParis = 204;
        private int distanceLilleMarseille = 834;

        [Test]
        public void DistanceBetween_Lille_Paris_IsCorrect()
        {
            int distance = GeoHelper.GetDistanceAsTheCrowFlies(lilleLatitude, lilleLongitude, parisLatitude, parisLongitude);

            Assert.That(distance, Is.EqualTo(distanceLilleParis));
        }

        [Test]
        public void DistanceBetween_Paris_Lille_IsCorrect()
        {
            int distance = GeoHelper.GetDistanceAsTheCrowFlies(parisLatitude, parisLongitude, lilleLatitude, lilleLongitude);

            Assert.That(distance, Is.EqualTo(distanceLilleParis));
        }

        [Test]
        public void DistanceBetween_Lille_Lille_IsCorrect()
        {
            int distance = GeoHelper.GetDistanceAsTheCrowFlies(lilleLatitude, lilleLongitude, lilleLatitude, lilleLongitude);

            Assert.That(distance, Is.EqualTo(0));
        }

        [Test]
        public void DistanceBetween_Lille_Marseille_IsCorrect()
        {
            int distance = GeoHelper.GetDistanceAsTheCrowFlies(lilleLatitude, lilleLongitude, marseilleLatitude, marseilleLongitude);

            Assert.That(distance, Is.EqualTo(distanceLilleMarseille));
        }

        [Test]
        public void DistanceBetween_Marseille_Lille_IsCorrect()
        {
            int distance = GeoHelper.GetDistanceAsTheCrowFlies(marseilleLatitude, marseilleLongitude, lilleLatitude, lilleLongitude);

            Assert.That(distance, Is.EqualTo(distanceLilleMarseille));
        }
    }
}