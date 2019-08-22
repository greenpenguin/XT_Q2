using DAL;
using Entities;

namespace Common
{
    public class DependensiesClass
    {
        public static IStorable Storage { get; } = new MemoryStorageClass();
    }
}