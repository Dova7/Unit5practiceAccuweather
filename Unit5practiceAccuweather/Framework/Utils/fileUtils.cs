using Aquality.Selenium.Browsers;

namespace Unit5practiceAccuweather.Framework.Utils
{
    public class fileUtils
    {
        public static bool IsFileExists(string filePath)
        {
            AqualityServices.ConditionalWait.WaitForTrue(() => File.Exists(filePath));
            return File.Exists(filePath);
        }
    }
}
