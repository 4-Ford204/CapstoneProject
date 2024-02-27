using System.Security.Cryptography;
using System.Text;

namespace BusinessObjects
{
    public static class Common
    {
        public static int GetFirstPageInPagination()
        {
            return 1;
        }

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

        public static string RandomPhoneNumber()
        {
            int size = 10;
            string result = "0";
            for (int i = 0; i < size - 1; i++)
                result = string.Concat(result, RandomNumberGenerator.GetInt32(1, 10).ToString());
            return result;
        }

        public static string GetEmailConfirmation(string redirectURL)
        {
            return
                "<body style=\"background-color: #E9ECEF;\">" +
                    "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\">" +
                        "<tr>" +
                            "<td align=\"center\" bgcolor=\"#E9ECEF\">" +
                                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">" +
                                    "<tr>" +
                                        "<td align=\"left\" bgcolor=\"#FFFFFF\" style=\"padding: 36px 24px 0; font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif; border-top: 3px solid #D4DADF;\">" +
                                            "<h1 style=\"margin: 0; font-size: 32px; font-weight: 700; letter-spacing: -1px; line-height: 48px;\">" +
                                                "Xác Nhận Địa Chỉ Gmail Của Bạn" +
                                            "</h1>" +
                                        "</td>" +
                                    "</tr>" +
                                "</table>" +
                            "</td>" +
                        "</tr>" +
                        "<tr>" +
                            "<td align=\"center\" bgcolor=\"#e9ecef\">" +
                                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">" +
                                    "<tr>" +
                                        "<td align=\"left\" bgcolor=\"#FFFFFF\" style=\"padding: 24px; font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif; font-size: 16px; line-height: 24px;\">" +
                                            "<p style=\"margin: 0;\">" +
                                                "Nhấn nút &nbsp;<strong>Xác Nhận</strong>&nbsp; bên dưới để xác nhận đây sẽ là gmail của bạn trong hệ thống <strong>FVenue</strong>." +
                                            "</p>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td align=\"left\" bgcolor=\"#FFFFFF\">" +
                                            "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\">" +
                                                "<tr>" +
                                                    "<td align=\"center\" bgcolor=\"#FFFFFF\" style=\"padding: 12px;\">" +
                                                        "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">" +
                                                            "<tr>" +
                                                                "<td align=\"center\" bgcolor=\"#04AA6D\" style=\"border-radius: 6px;\">" +
                                                                    $"<a href=\"{redirectURL}\" target=\"_blank\" style=\"display: inline-block; padding: 16px 36px; font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif; font-size: 16px; color: #FFFFFF; text-decoration: none; border-radius: 6px;\">" +
                                                                        "Xác Nhận" +
                                                                    "</a>" +
                                                                "</td>" +
                                                            "</tr>" +
                                                        "</table>" +
                                                    "</td>" +
                                                "</tr>" +
                                            "</table>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td align=\"left\" bgcolor=\"#FFFFFF\" style=\"padding: 24px; font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif; font-size: 16px; line-height: 24px; border-bottom: 3px solid #d4dadf\">" +
                                            "<p style=\"margin: 0;\">Thân ái,<br> FVenue</p>" +
                                        "</td>" +
                                    "</tr>" +
                                "</table>" +
                            "</td>" +
                        "</tr>" +
                    "</table>" +
                "</body>";
        }

        #endregion

        #region GeoLocation

        public static void ConvertGeoLocationToLatLong(string geoLocation, out float Latitude, out float Longitude)
        {
            var geo = geoLocation.Split(',');
            Latitude = float.Parse(geo[0]);
            Longitude = float.Parse(geo[1]);
        }

        public static string FormatGeoLocation(string geoLocation)
        {
            float Latitude, Longitude;
            ConvertGeoLocationToLatLong(geoLocation, out Latitude, out Longitude);
            return $"{Latitude.ToString("0.00")},{Longitude.ToString("0.00")}";
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
        public static string FormatDateTime(DateTime? dateTime)
        {
            return dateTime.HasValue ? dateTime.Value.ToString("dd/MM/yyyy HH:mm:ss") : "";
        }

        #endregion

        #region Role

        public static string GetRoleName(int id)
        {
            foreach (var role in Enum.GetValues(typeof(EnumModel.Role)))
                if ((int)role == id)
                    return role.ToString() ?? "";
            return String.Empty;
        }

        #endregion

        #region SubCategoryRequest

        public static KeyValuePair<string, string> SetBadgeBaseOnCreateDate(DateTime createDate)
        {
            var minute = 60;
            var hour = 3600;
            var day = 86400;
            var week = 604800;
            // badge-info: light gray
            // badge-primary: blue
            // badge-success: green
            // badge-warning: yellow
            // badge-danger: red
            // badge-secondary: gray
            double result = (DateTime.Now - createDate).TotalSeconds;
            if (result < day)
                return new KeyValuePair<string, string>(
                    "badge-primary",
                    result < minute ? $"{(int)result} giây" : result < hour ? $"{(int)result / minute} phút" : $"{(int)result / hour} giờ");
            else if (result < 4 * day)
                return new KeyValuePair<string, string>("badge-success", $"{(int)result / day} ngày");
            else if (result < week)
                return new KeyValuePair<string, string>("badge-warning", $"{(int)result / day} ngày");
            else
                return new KeyValuePair<string, string>("badge-danger", $"{(int)result / 604800} tuần");
        }

        #endregion
    }
}
