using System.Security.Cryptography;
using System.Text;

namespace BusinessObjects
{
    public static class Common
    {
        #region Account

        public static string HashPassword(string password, out byte[] salt, int keySize = 64, int iterations = 350000)
        {
            HashAlgorithmName hashAlgorithmName = HashAlgorithmName.SHA512;
            salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithmName,
                keySize
                );
            return Convert.ToHexString(hash);
        }
        public static bool VerifyPassword(string password, string hashPassword, byte[] salt, int keySize = 64, int iterations = 350000)
        {
            HashAlgorithmName hashAlgorithmName = HashAlgorithmName.SHA512;
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithmName,
                keySize
                );
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hashPassword));
        }

        #endregion

        #region DateTime

        public static DateOnly ConvertDateTimeToDateOnly(DateTime dateTime)
            => DateOnly.FromDateTime(dateTime);
        public static TimeOnly ConvertDateTimeToTimeOnly(DateTime dateTime)
            => TimeOnly.FromDateTime(dateTime);
        /// <summary>
        /// Convert DateOnly to DateTime
        /// </summary>
        /// <param name="date">yyyy/MM/dd || MM/dd/yyyy</param>
        /// <returns></returns>
        public static DateTime ConvertDateOnlyToDateTime(string date)
            => DateOnly.Parse(date).ToDateTime(TimeOnly.FromDateTime(DateTime.Now));
        /// <summary>
        /// Convert TimeOnly to DateTime
        /// </summary>
        /// <param name="time">HH:mm || HH:mm:ss</param>
        /// <returns></returns>
        public static DateTime ConvertTimeOnlyToDateTime(string time)
            => DateOnly.FromDateTime(DateTime.Now).ToDateTime(TimeOnly.Parse(time));
        public static string FormatDateTime(DateTime dateTime)
            => dateTime.ToString("dd/MM/yyyy HH:mm:ss");

        #endregion
    }
}
