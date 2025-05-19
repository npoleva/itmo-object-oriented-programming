using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public interface IRepository<T>
    where T : class
{
    IEnumerable<T> GetComputerComponentsList();
    T? GetComputerComponent(string id);
    void AddComputerComponent(T item);
}