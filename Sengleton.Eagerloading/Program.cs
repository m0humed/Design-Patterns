namespace Sengleton.Eagerloading
{
    internal class Program
    {
        static MemoryLogger _memoryLogger;
        static void Main(string[] args)
        {
            AssignVoucher("A@A.com", "1234");

            UseVoucher("B@B.com", "5678");

            _memoryLogger.showLogCounts();
        }

        static void AssignVoucher(string email, string code)
        {
            _memoryLogger = MemoryLogger.Instance;

            _memoryLogger.LogInfo($"Voucher assigned to {email} with code {code}");

            _memoryLogger.LogError($"Error assigning voucher to {email} with code {code}");
        }

        static void UseVoucher(string email, string code)
        {
            _memoryLogger = MemoryLogger.Instance;

            _memoryLogger.LogWarning($"Warning using voucher by {email} with code {code}");

            _memoryLogger.LogInfo($"Voucher used by {email} with code {code}");
        }
    }
}
