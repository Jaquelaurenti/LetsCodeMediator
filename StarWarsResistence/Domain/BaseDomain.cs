using System;
namespace MediatorSimples.Domain
{
    public class BaseDomain
    {
        public Guid Id { get; private set; }

        public BaseDomain()
        {
            Id = Guid.NewGuid();
        }
    }
}
