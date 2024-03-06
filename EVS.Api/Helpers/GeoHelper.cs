namespace EVS.Api.Helpers
{
    public static class GeoHelper
    {
        public static int GetDistanceAsTheCrowFlies(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double theta = longitude1 - longitude2;
            double distance = (Math.Sin(ConvertDegreesToRadians(latitude1)) * Math.Sin(ConvertDegreesToRadians(latitude2))) + (Math.Cos(ConvertDegreesToRadians(latitude1)) * Math.Cos(ConvertDegreesToRadians(latitude2)) * Math.Cos(ConvertDegreesToRadians(theta)));
            distance = Math.Acos(distance);
            distance = ConvertRadiansToDegrees(distance);
            distance = distance * 60 * 1.1515;
            distance *= 1.609344;
            return (int)Math.Round(distance, 0);
        }

        private static double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }

        private static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return (degrees);
        }
    }
}
