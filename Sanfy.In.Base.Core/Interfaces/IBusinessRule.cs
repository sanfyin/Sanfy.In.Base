using System;
namespace Sanfy.In.Base.Core.Interfaces
{
    public interface IBusinessRule
    {
        bool IsBroken();

        string Message { get; }
    }
}