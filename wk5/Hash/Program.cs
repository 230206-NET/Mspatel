 using System.Security.Cryptography;
 namespace hash;
 public class Program{

    private const int SaltSize = 16; //128 / 8, length in bytes
    private const int KeySize = 32; //256 / 8, length in bytes
    private const int Iterations = 10000;
    private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;
    private const char SaltDelimeter = ':';
    public static string PasswordHash(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, _hashAlgorithmName, KeySize);
        return string.Join(SaltDelimeter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
    }
    public static bool PasswordValidate(string passwordHash, string password)
    {
        string[] pwdElements = passwordHash.Split(SaltDelimeter);
        byte[] salt = Convert.FromBase64String(pwdElements[0]);
        byte[] hash = Convert.FromBase64String(pwdElements[1]);
        byte[] hashInput = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, _hashAlgorithmName, KeySize);
        return CryptographicOperations.FixedTimeEquals(hash, hashInput);
    }
    public static void Main(string[] args){
        string test = "PasswordTestString";
        string testhash = PasswordHash(test);
        Console.WriteLine(test);
        Console.WriteLine(testhash);
        Console.WriteLine();
        Console.WriteLine();
        bool val = PasswordValidate(testhash, test);
        Console.WriteLine("Correct Way String: "+val);
        Console.WriteLine();
        Console.WriteLine();
        string testMiss = "PasswordTestStrings";
        val = PasswordValidate(testhash, testMiss);
        Console.WriteLine("Wrong Way String: "+val);
    }
 }
