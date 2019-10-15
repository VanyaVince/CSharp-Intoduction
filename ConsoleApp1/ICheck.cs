using System;

namespace ConsoleApp1
{
    public interface ICheck
    {
        bool IfExist(String nickName);

        void Record(User user);
    }
}