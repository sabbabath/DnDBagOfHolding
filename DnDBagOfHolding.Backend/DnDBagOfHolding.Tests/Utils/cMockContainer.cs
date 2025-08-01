using DnDBagOfHolding.Common.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.Tests.Utils
{
    public record rMockContainer : rDtoContainer
    {
        public rMockContainer(long Id, long ContainerTypeId, rDtoContainerType ContainerType, long CurrentWeight, IEnumerable<rDtoItem> Items) : base(Id, ContainerTypeId, ContainerType, CurrentWeight, Items)
        {

        }

        public static rMockContainer WithContainerTypeId()
        {

        }
    }
}
