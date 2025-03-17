using System.Text.RegularExpressions;

namespace parawork
{
    public class PasswordChecker()
    {
        static int SecurityLevel = 0;
        public static int CheckCheck(string entered_string)
        {
            int length = entered_string.Length;
            if (length > 7)
            {
                SecurityLevel += 1;
            }
            if (entered_string.Any(char.IsDigit))
            {
                SecurityLevel += 1;
            }
            if (entered_string.Any(char.IsLower))
            {
                SecurityLevel += 1;
            }
            if(entered_string.Any(char.IsUpper))
            {
                SecurityLevel += 1;
            }
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(entered_string))
            {
                SecurityLevel += 1;
            }

            return SecurityLevel;
        }

        static void Main(string[] args)
        {
            string entered = Console.ReadLine();
            int level = CheckCheck(entered);
            Console.WriteLine("Уровень безопасности пароля", level);
        }
    }
}
