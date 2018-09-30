using System.Collections.Generic;
using Hal.Poc.Hypermedia;

namespace Hal.Poc.Models.Hypermedia
{
    public class PersonRepresentation : Hal<Person>
    {
        protected override IEnumerable<Link> LinksFor(Person resource)
        {
            yield return new Link(Link.Self, $"/people/{resource.Id}");
        }
    }
}